using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace VSDiscordRP
{
    public class Settings
    {

        public GlobalSettings GSettings = new GlobalSettings();
        public List<ProjectSettings> PSettings = new List<ProjectSettings>();

        public static Settings GetOrCreateSettings()
        {
            string ConfigString = Properties.Settings.Default.Configuration;
            Settings NewSettings = JsonConvert.DeserializeObject<Settings>(ConfigString);

            if (NewSettings == null)
            {
                string SolutionName = Path.GetFileNameWithoutExtension(VSDiscordRPPackage.ide.Solution.FullName);

                NewSettings = new Settings();
                ProjectSettings NewProjectSettings = new ProjectSettings();
                NewProjectSettings.SolutionName = SolutionName;
                NewSettings.PSettings.Add(NewProjectSettings);

                Properties.Settings.Default.Configuration = JsonConvert.SerializeObject(NewSettings);
                Properties.Settings.Default.Save();

                MessageBox.Show("Created new settings!");
            }

            return NewSettings;
        }

        // Global Settings
        public class GlobalSettings
        {
            // Is the extension enabled globally?
            public bool bEnabled { get; set; } = true;

            // If true all projects with the UE4 solution name will be made private
            public bool bHideUE4Projects { get; set; }

            // The message to be displayed if the project is hidden
            public string HiddenMessage { get; set; } = "Sorry, but this project is private and I can't show you currently.";

            public bool bShowLanguageImage { get; set; } = true;

            public List<string> Prefixes { get; set; } = new List<string>() { "Programming on", "Working on", "Coding on", "Programming", "Coding" };
        }

        // Project Settings
        public class ProjectSettings
        {
            public string SolutionName { get; set; }

            public bool bHiddenMode { get; set; }

            // The message to be displayed if the project is hidden
            public string HiddenMessage { get; set; }

            public bool bShowTime { get; set; } = true;

            public bool bResetTimeOnFileChange { get; set; } = false;

            public bool bShowFileName { get; set; } = true;

            public bool bShowSolutionName { get; set; } = true;

            public bool bShowBuildingStatus { get; set; } = true;
        }
    }

    // Yoinked from https://github.com/Discord-RP/Visual-Studio/blob/master/Constants.cs
    public static class Constants
    {
        public static readonly Dictionary<string[], string[]> Languages = new Dictionary<string[], string[]>
        {
            { new string[] { ".H", ".CC", ".HH", ".CPP", ".IPP", ".INL", ".C++", ".H++", ".HPP" }, new string[] { "cpp", "C++" } },
            { new string[] { ".GO" }, new string[] { "go", "GO" } },
            { new string[] { ".PHP" }, new string[] { "php", "PHP" } },
            { new string[] { ".C" }, new string[] { "c", "C" } },
            { new string[] { ".RB", ".rbw" }, new string[] { "ruby", "Ruby" } },
            { new string[] { ".CS" }, new string[] { "csharp", "C#" } },
            { new string[] { ".FS", ".FSI", ".FSX", ".FSSCRIPT" }, new string[] { "fsharp", "F#" } },
            { new string[] { ".TS" }, new string[] { "typescript", "Typescript" } },
            { new string[] { ".CLASS", ".JAVA" }, new string[] { "java", "Java" } },
            { new string[] { ".TXT" }, new string[] { "text", "Text document" } },
            { new string[] { ".JSON" }, new string[] { "json", "JSON" } },
            { new string[] { ".PY", ".PYW", ".PYI", ".PYX" }, new string[] { "python", "Python" } },
            { new string[] { ".CSS" }, new string[] { "css", "CSS" } },
            { new string[] { ".SCSS", ".SASS" }, new string[] { "sass", "SASS" } },
            { new string[] { ".LESS" }, new string[] { "less", "LESS" } },
            { new string[] { ".HTML" }, new string[] { "html", "Html" } },
            { new string[] { ".JS" }, new string[] { "javascript", "Javascript" } },
            { new string[] { "CMAKELISTS.TXT", "CMAKECACHE.TXT" }, new string[] { "cmake", "CMake" } },
            { new string[] { ".MD", ".MARKDOWN" }, new string[] { "markdown", "Markdown" } },
            { new string[] { ".XML" }, new string[] { "xml", "XML" } },
            { new string[] { ".XAML" }, new string[] { "xaml", "XAML" } },
            { new string[]{ ".CSHTML", ".RAZOR" }, new string[] { "cshtml", "CSHtml" } },
            { new string[]{ ".RS" }, new string[] { "rust", "Rust" } },
            { new string[]{ ".TOML" }, new string[] { "toml", "TOML" } },
            { new string[]{ ".LUA" }, new string[] { "lua", "Lua" } },
            { new string[]{ ".HLSL" }, new string[] { "text", "HLSL" } },
            { new string[]{ ".GLSL" }, new string[] { "text", "GLSL" } },
        };
        public static readonly Dictionary<int, string> IDEVersions = new Dictionary<int, string>
        {
            { 15, "2017" },
            { 16, "2019" }
        };
    }
}
