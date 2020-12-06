using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Newtonsoft.Json;
using System.IO;

namespace VSDiscordRP
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void LoadSettings()
        {
            string SolutionName = Path.GetFileNameWithoutExtension(VSDiscordRP.VSDiscordRPPackage.ide.Solution.FullName);
            Settings obj = Settings.GetOrCreateSettings();
            Settings.ProjectSettings CurrentProject = obj.PSettings.Where(x => x.SolutionName == SolutionName).FirstOrDefault();

            if (SolutionName != "")
            {
                groupBox2.Text += $" ({SolutionName})";
            }

            // Global
            cbEnabled.Checked = obj.GSettings.bEnabled;
            cbHideUE4.Checked = obj.GSettings.bHideUE4Projects;
            txtHiddenMessage.Text = obj.GSettings.HiddenMessage;
            cbShowLangImage.Checked = obj.GSettings.bShowLanguageImage;
            txtPrefixes.Text = string.Join(",", obj.GSettings.Prefixes ?? new List<string>() { "Working on", "Programming", "Programming on", "Coding on", "Coding" });
            txtIdleMessage.Text = obj.GSettings.IdleMessage;

            // Project
            cbEnabledProject.Checked = CurrentProject.bEnabled;
            cbHiddenMode.Checked = CurrentProject.bHiddenMode;
            cbShowTime.Checked = CurrentProject.bShowTime;
            cbResetTime.Checked = CurrentProject.bResetTimeOnFileChange;
            cbShowFileName.Checked = CurrentProject.bShowFileName;
            cbShowSolutionName.Checked = CurrentProject.bShowSolutionName;
            txtProjectHiddenMessage.Text = CurrentProject.HiddenMessage;
            cbDisplayBuilding.Checked = CurrentProject.bShowBuildingStatus;
        }

        private void SaveSettings()
        {
            Settings NewSettingsObj = new Settings();

            // Global
            NewSettingsObj.GSettings.bEnabled = cbEnabled.Checked;
            NewSettingsObj.GSettings.bHideUE4Projects = cbHideUE4.Checked;
            NewSettingsObj.GSettings.HiddenMessage = txtHiddenMessage.Text;
            NewSettingsObj.GSettings.bShowLanguageImage = cbShowLangImage.Checked;
            NewSettingsObj.GSettings.Prefixes = txtPrefixes.Text.Split(new char[] { ',' }).ToList();
            NewSettingsObj.GSettings.IdleMessage = txtIdleMessage.Text;

            // Project
            Settings tmpProjectObj = JsonConvert.DeserializeObject<Settings>(Properties.Settings.Default.Configuration);
            if (tmpProjectObj != null)
            {
                List<Settings.ProjectSettings> ExistingProjects = tmpProjectObj.PSettings;
                if (ExistingProjects.Count > 0)
                {
                    Settings.ProjectSettings CurrentProject = ExistingProjects.Where(x => x.SolutionName == Path.GetFileNameWithoutExtension(VSDiscordRP.VSDiscordRPPackage.ide.Solution.FullName)).FirstOrDefault();
                    CurrentProject.bEnabled = cbEnabledProject.Checked;
                    CurrentProject.bHiddenMode = cbHiddenMode.Checked;
                    CurrentProject.bShowTime = cbShowTime.Checked;
                    CurrentProject.bResetTimeOnFileChange = cbResetTime.Checked;
                    CurrentProject.bShowFileName = cbShowFileName.Checked;
                    CurrentProject.bShowSolutionName = cbShowSolutionName.Checked;
                    CurrentProject.HiddenMessage = txtProjectHiddenMessage.Text;
                    CurrentProject.bShowBuildingStatus = cbDisplayBuilding.Checked;

                    NewSettingsObj.PSettings = ExistingProjects;
                }
            }

            Properties.Settings.Default.Configuration = JsonConvert.SerializeObject(NewSettingsObj);
            Properties.Settings.Default.Save();
        }

        private void btnSettingsLocation_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Path.GetDirectoryName(ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath));
        }
    }
}
