using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Media;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common;
using WolvenKit.Core;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.WKitGlobal;
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Functionality.Services
{
    /// <summary>
    /// This handles the application settings defined by the user.
    /// </summary>
    public class SettingsManager : ReactiveObject, ISettingsManager
    {
        #region fields

        private static string GetConfigurationPath() => Path.Combine(ISettingsManager.GetAppData(), "config.json");
        private static string GetImagePath() => Path.Combine(ISettingsManager.GetAppData(), "_profile_image.png");

        #endregion fields

        #region constructors

        /// <summary>
        /// Default constructor.
        /// </summary>
        public SettingsManager()
        {
            ManagerVersions = new string[(int)EManagerType.Max];

            _assemblyVersion = CommonFunctions.GetAssemblyVersion(Constants.AssemblyName).ToString();
        }

        #endregion constructors

        #region properties

        [Reactive] public bool ShowGuidedTour { get; set; } = true;

        [Reactive] public bool CheckForUpdates { get; set; }

        [Reactive] public EUpdateChannel UpdateChannel { get; set; }

        [Reactive] public string DepotPath { get; set; }

        [Reactive] public string MaterialRepositoryPath { get; set; }

        [Reactive] public string ThemeAccentString { get; set; }

        public Color GetThemeAccent() =>
            !string.IsNullOrEmpty(ThemeAccentString)
                ? (Color)ColorConverter.ConvertFromString(ThemeAccentString)
                : (Color)ColorConverter.ConvertFromString("#DF2935");

        public void SetThemeAccent(Color color)
        {
            ThemeAccentString = color.ToString();
        }

        [Reactive] public EAnimals  CatFactAnimal { get; set; } =  EAnimals.Cat;

        private string _assemblyVersion;

        public string GetVersionNumber() => _assemblyVersion;

        [Reactive] public string[] ManagerVersions { get; set; }

        /// <summary>
        /// Gets/Sets the author's profile image brush.
        /// </summary>
        [JsonIgnore] [Reactive] public ImageBrush ProfileImageBrush { get; set; }

        [Reactive] public string TextLanguage { get; set; }

        #region red4

        [Reactive] public string CP77ExecutablePath { get; set; }

        #endregion red4

        #region red3

        [Reactive] public string W3ExecutablePath { get; set; }

        [Reactive] public string WccLitePath { get; set; }

        #endregion red3

        #endregion properties

        #region methods

        #region red4

        public string GetRED4GameRootDir()
        {
            if (string.IsNullOrEmpty(CP77ExecutablePath))
            {
                return null;
            }

            var fi = new FileInfo(CP77ExecutablePath);
            return fi.Directory is { Parent: { Parent: { } } } ? Path.Combine(fi.Directory.Parent.Parent.FullName) : null;
        }

        public string GetRED4GameModDir()
        {
            var dir = Path.Combine(GetRED4GameRootDir(), "archive", "pc", "mod");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }

        public string GetRED4OodleDll() => Path.Combine(GetRED4GameRootDir(), "bin", "x64", WolvenKit.Core.Constants.Oodle);

        #endregion

        public string GetW3GameContentDir() => Path.Combine(GetW3GameRootDir(), "content");

        public string GetW3GameDlcDir() => Path.Combine(GetW3GameRootDir(), "DLC");

        public string GetW3GameModDir() => Path.Combine(GetW3GameRootDir(), "Mods");

        public string GetW3GameRootDir()
        {
            if (string.IsNullOrEmpty(W3ExecutablePath))
            {
                return null;
            }

            var fi = new FileInfo(W3ExecutablePath);
            return fi.Directory is { Parent: { Parent: { } } } ? Path.Combine(fi.Directory.Parent.Parent.FullName) : null;
        }


        public List<string> IsHealthy()
        {
            var messages = new List<string>();

            if (!File.Exists(CP77ExecutablePath))
            {
                messages.Add("Game exe location was not found.");
                return messages;
            }

            if (!File.Exists(GetRED4OodleDll()))
            {
                messages.Add($"Oodle dll was not found with the game. Please make sure you have {Core.Constants.Oodle} next to your game executable.");
            }

            return messages;
        }

        private static SettingsManager FromDto(SettingsDto settings)
        {
            var config = new SettingsManager()
            {
                CheckForUpdates = settings.CheckForUpdates,
                UpdateChannel = settings.UpdateChannel,
                ShowGuidedTour = settings.ShowGuidedTour,
                //ProfileImageBrush = settings.ProfileImageBrush,
                TextLanguage = settings.TextLanguage,
                ThemeAccentString = settings.ThemeAccentString,
                ManagerVersions = settings.ManagerVersions,
                DepotPath = settings.DepotPath,
                CP77ExecutablePath = settings.CP77ExecutablePath,
                MaterialRepositoryPath = settings.MaterialRepositoryPath,
                W3ExecutablePath = settings.W3ExecutablePath,
                WccLitePath = settings.WccLitePath,
                CatFactAnimal = settings.CatFactAnimal
            };
            return config;
        }

        public static SettingsManager Load()
        {
            SettingsManager config = null;
            try
            {
                if (File.Exists(GetConfigurationPath()))
                {
                    var jsonString = File.ReadAllText(GetConfigurationPath());
                    var dto = JsonSerializer.Deserialize<SettingsDto>(jsonString);
                    if (dto != null)
                    {
                        config = FromDto(dto);
                    }
                }
            }
            catch (Exception)
            {
            }

            // Defaults
            config ??= new SettingsManager
            {
                TextLanguage = "en",
                //VoiceLanguage = "en",
            };

            // TODO: move this?
            // add a mechanism to update individual cache managers
            //for (var j = 0; j < config.ManagerVersions.Length; j++)
            //{
            //    var savedversions = config.ManagerVersions[j];
            //    var e = (EManagerType)j;
            //    var curversion = IGameController.GetManagerVersion(e);

            //    if (savedversions != curversion)
            //    {
            //        if (File.Exists(IGameController.GetManagerPath(e)))
            //        {
            //            File.Delete(IGameController.GetManagerPath(e));
            //        }
            //    }
            //}

            return config;
        }

        public void Save()
        {
            var src = (System.Windows.Media.Imaging.BitmapSource)ProfileImageBrush?.ImageSource;
            if (src != null)
            {
                using var fs1 = new FileStream(GetImagePath(), FileMode.OpenOrCreate);
                var frame = System.Windows.Media.Imaging.BitmapFrame.Create(src);
                var enc = new System.Windows.Media.Imaging.PngBitmapEncoder();
                enc.Frames.Add(frame);
                enc.Save(fs1);
            }

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            var json = JsonSerializer.Serialize(new SettingsDto(this), options);
            File.WriteAllText(GetConfigurationPath(), json);
        }

        #endregion methods
    }

    public class SettingsDto : ISettingsDto
    {
        public SettingsDto()
        {
        }

        public SettingsDto(SettingsManager settings)
        {
            CheckForUpdates = settings.CheckForUpdates;
            UpdateChannel = settings.UpdateChannel;
            ShowGuidedTour = settings.ShowGuidedTour;
            //ProfileImageBrush = settings.ProfileImageBrush;
            TextLanguage = settings.TextLanguage;
            ThemeAccentString = settings.ThemeAccentString;
            ManagerVersions = settings.ManagerVersions;
            DepotPath = settings.DepotPath;
            CP77ExecutablePath = settings.CP77ExecutablePath;
            MaterialRepositoryPath = settings.MaterialRepositoryPath;
            W3ExecutablePath = settings.W3ExecutablePath;
            WccLitePath = settings.WccLitePath;
            CatFactAnimal = settings.CatFactAnimal;
        }

        public EAnimals CatFactAnimal { get; set; }

        public bool CheckForUpdates { get; set; }
        public EUpdateChannel UpdateChannel { get; set; }

        //public ImageBrush ProfileImageBrush { get; set; }
        public string TextLanguage { get; set; }

        public string ThemeAccentString { get; set; }
        public string[] ManagerVersions { get; set; }
        public string DepotPath { get; set; }
        public string CP77ExecutablePath { get; set; }
        public string MaterialRepositoryPath { get; set; }
        public string W3ExecutablePath { get; set; }
        public string WccLitePath { get; set; }

        public bool ShowGuidedTour { get; set; }
    }
}
