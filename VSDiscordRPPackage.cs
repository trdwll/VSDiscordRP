using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using DiscordRPC;
using EnvDTE;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Newtonsoft.Json;
using Task = System.Threading.Tasks.Task;

namespace VSDiscordRP
{
    /// <summary>
    /// This is the class that implements the package exposed by this assembly.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The minimum requirement for a class to be considered a valid package for Visual Studio
    /// is to implement the IVsPackage interface and register itself with the shell.
    /// This package uses the helper classes defined inside the Managed Package Framework (MPF)
    /// to do it: it derives from the Package class that provides the implementation of the
    /// IVsPackage interface and uses the registration attributes defined in the framework to
    /// register itself and its components with the shell. These attributes tell the pkgdef creation
    /// utility what data to put into .pkgdef file.
    /// </para>
    /// <para>
    /// To get loaded into VS, the package must be referred by &lt;Asset Type="Microsoft.VisualStudio.VsPackage" ...&gt; in .vsixmanifest file.
    /// </para>
    /// </remarks>
    ///
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [ProvideAutoLoad(UIContextGuids80.NoSolution, PackageAutoLoadFlags.BackgroundLoad)]
    [ProvideAutoLoad(UIContextGuids80.SolutionExists, PackageAutoLoadFlags.BackgroundLoad)]
    [Guid(VSDiscordRPPackage.PackageGuidString)]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [ProvideBindingPath]
    public sealed class VSDiscordRPPackage : AsyncPackage, IDisposable
    {
        internal static DTE ide;
        private readonly DiscordRpcClient Discord = new DiscordRpcClient("759419908995285074");
        private readonly RichPresence Presence = new RichPresence();
        private readonly Assets Assets = new Assets();

        private Settings SettingsObj;
        private Settings.ProjectSettings ProjectSettings;

        private bool bProjectContainsUE4, bInitialTimestamp;
        private string VersionString, VersionImageKey, SolutionName;
        private Timestamps FileCurrentTimestamp, FileInitialTimestamp;

        public enum EPresence
        {
            None,
            Building,
        }

        /// <summary>
        /// VSDiscordRPPackage GUID string.
        /// </summary>
        public const string PackageGuidString = "c86c0c68-5ff5-43af-8a60-54540cbea3e2";
        public void Dispose() => Discord.Dispose();

        protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {
            try
            {
                await JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);

                ide = GetGlobalService(typeof(SDTE)) as DTE;
                ide.Events.WindowEvents.WindowActivated += WindowActivated;
                ide.Events.BuildEvents.OnBuildBegin += SolutionBuildingStart;
                ide.Events.SolutionEvents.BeforeClosing += SolutionBeforeClosing;

                // TODO bProjectContainsUE4

                string IDEVersion = ide.Version.Split(new char[1] { '.' })[0];
                VersionString = $"Visual Studio {Constants.IDEVersions[int.Parse(IDEVersion, CultureInfo.InvariantCulture)]}";
                VersionImageKey = $"dev{IDEVersion}";

                await SettingsCommand.InitializeAsync(this);
                await HelpCommand.InitializeAsync(this);

                if (!Discord.IsInitialized && !Discord.IsDisposed)
                {
                    Discord.Initialize();
                }

                await UpdatePresenceAsync(ide.ActiveDocument).ConfigureAwait(true);
                await base.InitializeAsync(cancellationToken, progress).ConfigureAwait(true);
            }
            catch (Exception e)
            {
                //MessageBox.Show($"InitializeAsync: {e.Message}");
            }
        }
        private async void SolutionBuildingStart(vsBuildScope Scope, vsBuildAction Action)
        {
            await JoinableTaskFactory.SwitchToMainThreadAsync();

            await UpdatePresenceAsync(null, EPresence.Building).ConfigureAwait(true);
        }

        private async void SolutionBeforeClosing() => await UpdatePresenceAsync(null).ConfigureAwait(true);

        private async void WindowActivated(Window windowActivated, Window lastWindow)
        {
            await JoinableTaskFactory.SwitchToMainThreadAsync();

            if (!Discord.IsInitialized && !Discord.IsDisposed)
            {
                if (!Discord.Initialize())
                {
                    return;
                }
            }

            if (windowActivated.Document != null)
            {
                await UpdatePresenceAsync(windowActivated.Document).ConfigureAwait(true);
            }
        }

        public async Task UpdatePresenceAsync(Document OpenedDocument, EPresence Status = EPresence.None)
        {
            try
            {
                await JoinableTaskFactory.SwitchToMainThreadAsync();

                bool bIsIdling = ide.Solution == null || string.IsNullOrEmpty(ide.Solution.FullName);

                // We get the settings every time we update so we can keep the latest config
                SettingsObj = Settings.GetOrCreateSettings();
                SolutionName = Path.GetFileNameWithoutExtension(ide.Solution.FullName);
                ProjectSettings = SettingsObj.PSettings.Where(x => x.SolutionName == SolutionName).FirstOrDefault();

                if (!SettingsObj.GSettings.bEnabled || !ProjectSettings.bEnabled)
                {
                    Discord.ClearPresence();
                    return;
                }

                if (ProjectSettings.bShowBuildingStatus && Status != EPresence.None && !ProjectSettings.bHiddenMode)
                {
                    Presence.Details = $"Building {SolutionName}";
                    Presence.State = "";

                    Presence.Timestamps = new Timestamps() { Start = DateTime.UtcNow };

                    Discord.SetPresence(Presence);

                    return;
                }

                if (bIsIdling)
                {
                    Presence.State = $"Idling";
                    Discord.SetPresence(Presence);
                    return;
                }

                if (ProjectSettings.bHiddenMode || (bProjectContainsUE4 && SettingsObj.GSettings.bHideUE4Projects))
                {
                    string Message = ProjectSettings.HiddenMessage == "" ? SettingsObj.GSettings.HiddenMessage : ProjectSettings.HiddenMessage;
                    Presence.Details = Message.Substring(0, Message.Length / 2);
                    Presence.State = Message.Substring(Message.Length / 2, Message.Length / 2);

                    Presence.Timestamps = null;

                    Discord.SetPresence(Presence);
                    return;
                }

                string[] SelectedLanguage = Array.Empty<string>();
                if (OpenedDocument != null)
                {
                    string FileName = Path.GetFileName(OpenedDocument.FullName).ToUpperInvariant(), FileExtension = Path.GetExtension(FileName);
                    List<KeyValuePair<string[], string[]>> LanguagesList = Constants.Languages.Where(x => x.Key.Contains(FileName) || x.Key.Contains(FileExtension)).ToList();
                    SelectedLanguage = LanguagesList.Count > 0 ? LanguagesList[0].Value : Array.Empty<string>();
                }

                bool bLangSupported = SelectedLanguage.Length > 0;
                Assets.LargeImageKey = SettingsObj.GSettings.bShowLanguageImage ? bLangSupported ? SelectedLanguage[0] : "text" : VersionImageKey;
                Assets.LargeImageText = SettingsObj.GSettings.bShowLanguageImage ? bLangSupported ? $"{SelectedLanguage[1]} file" : "Unrecognized extension" : VersionString;
                Assets.SmallImageKey = SettingsObj.GSettings.bShowLanguageImage ? VersionImageKey : bLangSupported ? SelectedLanguage[0] : "text";
                Assets.SmallImageText = SettingsObj.GSettings.bShowLanguageImage ? VersionString : bLangSupported ? $"{SelectedLanguage[1]} file" : "Unrecognized extension";

                if (ProjectSettings.bShowFileName)
                {
                    Presence.Details = OpenedDocument != null ? Path.GetFileName(OpenedDocument.FullName) : "No file.";
                }

                if (ProjectSettings.bShowSolutionName)
                {
                    string Prefix = "Developing";

                    List<string> Prefixes = SettingsObj.GSettings.Prefixes;
                    if (Prefixes != null && Prefixes.Count > 0)
                    {
                        Random rand = new Random();
                        Prefix = Prefixes[rand.Next(Prefixes.Count)];
                    }

                    Presence.State = $"{Prefix} {SolutionName}";
                }

                if (ProjectSettings.bShowTime && OpenedDocument != null)
                {
                    if (!bInitialTimestamp)
                    {
                        FileInitialTimestamp = new Timestamps() { Start = DateTime.UtcNow };
                        bInitialTimestamp = true;
                    }

                    Presence.Timestamps = ProjectSettings.bResetTimeOnFileChange ? new Timestamps() { Start = DateTime.UtcNow } : FileInitialTimestamp;
                    FileCurrentTimestamp = Presence.Timestamps;
                }

                Presence.Assets = Assets;
                Discord.SetPresence(Presence);
            }
            catch (Exception e)
            {
                // MessageBox.Show($"UpdatePresenceAsync: {e.Message}");
            }
        }

        public async Task SetIconsAsync(Document OpenedDocument)
        {

        }
    }
}
