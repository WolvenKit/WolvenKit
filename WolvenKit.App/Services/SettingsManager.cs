using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text.Json;
using System.Windows.Media;
using DynamicData.Binding;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.App.Models;
using WolvenKit.Common;
using WolvenKit.Core;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.Functionality.Services
{
    /// <summary>
    /// This handles the application settings defined by the user.
    /// </summary>
    public class SettingsManager : ReactiveObject, ISettingsManager
    {
        private bool _isLoaded;

        private readonly string _assemblyVersion;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public SettingsManager()
        {
            _assemblyVersion = CommonFunctions.GetAssemblyVersion(Constants.AssemblyName).ToString();

            _ = this.WhenAnyPropertyChanged(
                nameof(ShowGuidedTour),
                nameof(MaterialRepositoryPath),
                nameof(ThemeAccentString),
                nameof(SkipUpdateCheck),
                nameof(CP77ExecutablePath),
                nameof(CP77LaunchCommand),
                nameof(CP77LaunchOptions),
                nameof(ShowFilePreview),
                nameof(ReddbHash),
                nameof(TreeViewGroups),
                nameof(TreeViewGroupSize),
                nameof(ShowAdvancedOptions),
                nameof(ShowCNameAsHex),
                nameof(ShowNodeRefAsHex),
                nameof(ShowTweakDBIDAsHex),
                nameof(ShowReferenceGraph)
                )
              .Subscribe(_ =>
              {
                  if (_isLoaded)
                  {
                      Save();
                  }
              });
        }

        #region lifecycle

        public static SettingsManager Load()
        {
            var dto = LoadFromFile();

            var settings =
                dto != null
                ? dto.ToSettingsManager()
                : new SettingsManager();

            settings._isLoaded = true;
            return settings;
        }

        public void Save()
        {
            if (!_isLoaded)
            {
                return;
            }

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            };
            var json = JsonSerializer.Serialize(new SettingsDto(this), options);
            File.WriteAllText(GetConfigurationPath(), json);
            // _loggerService.Info("Settings saved.");
        }

        public void Bounce()
        {
            Save();
            var bouncedSettings = SettingsManager.LoadFromFile();
            bouncedSettings.ReconfigureSettingsManager(this);
        }

        private static SettingsDto LoadFromFile()
        {
            try
            {
                if (File.Exists(GetConfigurationPath()))
                {
                    var options = new JsonSerializerOptions
                    {
                        WriteIndented = true,
                        DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
                    };
                    var jsonString = File.ReadAllText(GetConfigurationPath());
                    var dto = JsonSerializer.Deserialize<SettingsDto>(jsonString, options);

                    return dto;
                }
            }
            catch (Exception)
            {
                return null;
            }

            return null;
        }

        #endregion lifecycle

        #region properties

        [Category("General")]
        [Display(Name = "Settings Version")]
        [Reactive]
        [Browsable(false)]
        public int SettingsVersion { get; set; }

        [Category("General")]
        [Display(Name = "Do not check for updates")]
        [Reactive]
        public bool SkipUpdateCheck { get; set; }

        [Category("General")]
        [Display(Name = "Update Channel")]
        [Reactive]
        public EUpdateChannel UpdateChannel { get; set; } // deprecated

        [Category("General")]
        [Display(Name = "Show Guided Tour")]
        [Reactive]
        public bool ShowGuidedTour { get; set; } = true;

        [Category("General")]
        [Display(Name = "Theme Accent")]
        [Reactive]
        public string ThemeAccentString { get; set; }

        [Category("Cyberpunk")]
        [Display(Name = "Game Executable Path (.exe)")]
        [Reactive]
        public string CP77ExecutablePath { get; set; }

        // This should be conditionally updated by CP77ExecutablePath, but not implemented..
        [Category("Cyberpunk")]
        [Display(Name = "Launch Command (executable or other command (e.g. steam:// uri)")]
        [Reactive]
        public string CP77LaunchCommand { get; set; }

        [Category("Cyberpunk")]
        [Display(Name = "Launch Options or Command-Line Parameters To Launch Command")]
        [Reactive]
        public string CP77LaunchOptions { get; set; }

        [Category("Cyberpunk")]
        [Display(Name = "Show File Preview")]
        [Reactive]
        public bool ShowFilePreview { get; set; } = true;

        [Browsable(false)]
        public string ReddbHash { get; set; }

        [Category("Cyberpunk")]
        [Display(Name = "Depot Path")]
        [Reactive]
        public string MaterialRepositoryPath { get; set; }

        [Category("File Editor")]
        [Display(Name = "Group Large Collections")]
        [Reactive]
        public bool TreeViewGroups { get; set; } = false;

        [Category("File Editor")]
        [Display(Name = "Group Size")]
        [Reactive]
        public uint TreeViewGroupSize { get; set; } = 100;

        [Category("Import / Export")]
        [Display(Name = "Show advanced Options")]
        [Reactive]
        public bool ShowAdvancedOptions { get; set; }

        [Category("Display")]
        [Display(Name = "Show CName hashes as hex")]
        [Reactive]
        public bool ShowCNameAsHex { get; set; }

        [Category("Display")]
        [Display(Name = "Show NodeRef hashes as hex")]
        [Reactive]
        public bool ShowNodeRefAsHex { get; set; }

        [Category("Display")]
        [Display(Name = "Show TweakDBID hashes as hex")]
        [Reactive]
        public bool ShowTweakDBIDAsHex { get; set; }

        [Category("Display")]
        [Display(Name = "Show reference graph")]
        [Reactive]
        public bool ShowReferenceGraph { get; set; }

        [Reactive]
        [Browsable(false)]
        public Dictionary<string, LaunchProfile> LaunchProfiles { get; set; }

        #endregion properties

        [Reactive]
        [Browsable(false)]
        public bool IsUpdateAvailable { get; set; }

        #region methods

        public string GetVersionNumber() => _assemblyVersion;

        private static string GetConfigurationPath() => Path.Combine(ISettingsManager.GetAppData(), "config.json");

        public Color GetThemeAccent() =>
           !string.IsNullOrEmpty(ThemeAccentString)
               ? (Color)ColorConverter.ConvertFromString(ThemeAccentString)
               : (Color)ColorConverter.ConvertFromString("#DF2935");

        public void SetThemeAccent(Color color) => ThemeAccentString = color.ToString();
        public string GetRED4GameRootDir()
        {
            var fi = new FileInfo(CP77ExecutablePath);

            return fi.Directory is { Parent.Parent: { } }
                ? Path.Combine(fi.Directory.Parent.Parent.FullName)
                : throw new DirectoryNotFoundException();
        }

        public string GetRED4GameExecutablePath() => CP77ExecutablePath;

        public string GetRED4GameLaunchCommand() => CP77LaunchCommand;

        public string GetRED4GameLaunchOptions() => CP77LaunchOptions;

        public string GetRED4GameLegacyModDir()
        {
            var dir = Path.Combine(GetRED4GameRootDir(), "archive", "pc", "mod");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }

        public string GetRED4GameModDir()
        {
            //var dir = Path.Combine(GetRED4GameRootDir(), "archive", "pc", "mod");
            var dir = Path.Combine(GetRED4GameRootDir(), "mods");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }

        public string GetRED4OodleDll() => string.IsNullOrEmpty(GetRED4GameRootDir())
                ? null
                : Path.Combine(GetRED4GameRootDir(), "bin", "x64", WolvenKit.Core.Constants.Oodle);

        public bool IsHealthy() => File.Exists(CP77ExecutablePath) && File.Exists(GetRED4OodleDll());

        #endregion methods
    }
}
