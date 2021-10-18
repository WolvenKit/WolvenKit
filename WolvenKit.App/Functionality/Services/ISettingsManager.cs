using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Media;
using WolvenKit.Common;
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Functionality.Services
{
    public interface ISettingsDto
    {
        #region Properties

        bool CheckForUpdates { get; set; }

        string TextLanguage { get; set; }

        string ThemeAccentString { get; set; }

        EAnimals CatFactAnimal { get; set; }

        string[] ManagerVersions { get; set; }

        string DepotPath { get; set; }

        // red 4

        string ReddbHash { get;set; }

        string CP77ExecutablePath { get; set; }

        // red 3

        string W3ExecutablePath { get; set; }

        string WccLitePath { get; set; }

        #endregion Properties
    }

    public interface ISettingsManager : ISettingsDto, INotifyPropertyChanged
    {
        // This is here because Catel can't expose inherited Properties ¯\_(ツ)_/¯
        // and we use this in the first set up viewmodels
        public EUpdateChannel UpdateChannel { get; set; }

        bool ShowGuidedTour { get; set; }

        public ImageBrush ProfileImageBrush { get; set; }

        string MaterialRepositoryPath { get; set; }

        string GetRED4OodleDll();


        string GetW3GameContentDir();

        string GetW3GameDlcDir();

        string GetW3GameModDir();

        string GetW3GameRootDir();

        string GetRED4GameRootDir();

        public string GetRED4GameModDir();


        public static string GetAppData()
        {
            var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "REDModding",
                "WolvenKit");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }

        public static string GetManagerCacheDir()
        {
            var dir = Path.Combine(GetAppData(), "Config");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }

        public static string GetWorkDir()
        {
            var dir = Path.Combine(GetAppData(), "tmp_workdir");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }

        public static string GetXBMDumpPath()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "__xbmdump_3768555366.csv");
        }

        public static string GetTemp_AudioPath()
        {
            var dir = Path.Combine(GetAppData(), "Temp_Audio");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }

        public static string GetTemp_OBJPath()
        {
            var dir = Path.Combine(GetAppData(), "Temp_OBJ");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }

        public static string GetTemp_MeshPath()
        {
            var dir = Path.Combine(GetAppData(), "Temp_Mesh");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }

        public static string GetTemp_Audio_importPath()
        {
            var dir = Path.Combine(GetAppData(), "Temp_Audio_import");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }

        public static string GetTemp_Video_PreviewPath()
        {
            var dir = Path.Combine(GetAppData(), "Temp_Video_Preview");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }

        public static string GetWebViewDataPath()
        {
            var dir = Path.Combine(GetAppData(), "WebViewData");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }

        void Save();

        Color GetThemeAccent();

        void SetThemeAccent(Color color);

        string GetVersionNumber();

        bool IsHealthy();

    }
}
