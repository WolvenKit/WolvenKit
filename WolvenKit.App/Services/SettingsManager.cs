using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text.Json;
using System.Windows.Media;
using DynamicData.Binding;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
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
        #region fields

        private readonly ILoggerService _loggerService;

        private bool _isLoaded;

        private readonly string _assemblyVersion;

        #endregion fields

        #region constructors

        /// <summary>
        /// Default constructor.
        /// </summary>
        public SettingsManager()
        {
            _loggerService = Locator.Current.GetService<ILoggerService>();
            _assemblyVersion = CommonFunctions.GetAssemblyVersion(Constants.AssemblyName).ToString();

            _ = this.WhenAnyPropertyChanged(
                nameof(ShowGuidedTour),
                nameof(MaterialRepositoryPath),
                nameof(ThemeAccentString),
                nameof(CheckForUpdates),
                nameof(CP77ExecutablePath),
                nameof(CP77LaunchCommand),
                nameof(CP77LaunchOptions),
                nameof(ShowFilePreview),
                nameof(ReddbHash),
                nameof(TreeViewGroups),
                nameof(TreeViewGroupSize),
                nameof(ShowAdvancedOptions)
                )
              .Subscribe(_ =>
              {
                  if (_isLoaded)
                  {
                      Save();
                  }
              });
        }

        #endregion constructors

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
                    var jsonString = File.ReadAllText(GetConfigurationPath());
                    var dto = JsonSerializer.Deserialize<SettingsDto>(jsonString);

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

        #region general

        [Category("General")]
        [Display(Name = "Settings Version")]
        [Reactive]
        [Browsable(false)]
        public int SettingsVersion { get; set; }

        [Category("General")]
        [Display(Name = "Show Guided Tour")]
        [Reactive]
        public bool ShowGuidedTour { get; set; } = true;

        [Category("General")]
        [Display(Name = "Update Channel")]
        [Reactive]
        public EUpdateChannel UpdateChannel { get; set; } // deprecated

        [Category("General")]
        [Display(Name = "Theme Accent")]
        [Reactive]
        public string ThemeAccentString { get; set; }

        // unused
        [Reactive]
        [Browsable(false)]
        public bool CheckForUpdates { get; set; }

        [Reactive]
        [Browsable(false)]
        public bool IsUpdateAvailable { get; set; }

        #endregion

        #region red4

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
        [Display(Name = "Depot Path")]
        [Reactive]
        public string MaterialRepositoryPath { get; set; }

        [Category("Cyberpunk")]
        [Display(Name = "Show File Preview")]
        [Reactive]
        public bool ShowFilePreview { get; set; } = true;

        [Browsable(false)]
        public string ReddbHash { get; set; }

        #endregion red4

        #region red3

        // unused
        [Reactive]
        [Category("Cyberpunk")]
        [Display(Name = "Game executable path (.exe)")]
        [Browsable(false)]
        public string W3ExecutablePath { get; set; }

        // unused
        [Reactive]
        [Category("Cyberpunk")]
        [Display(Name = "wcc_lite executable path (.exe)")]
        [Browsable(false)]
        public string WccLitePath { get; set; }

        #endregion red3

        #region TreeView

        [Category("File Editor")]
        [Display(Name = "Group Large Collections")]
        [Reactive]
        public bool TreeViewGroups { get; set; } = false;

        [Category("File Editor")]
        [Display(Name = "Group Size")]
        [Reactive]
        public uint TreeViewGroupSize { get; set; } = 100;

        #endregion

        #region Import / Export

        [Category("Import / Export")]
        [Display(Name = "Show advanced Options")]
        [Reactive]
        public bool ShowAdvancedOptions { get; set; }

        #endregion Import / Export

        #endregion properties

        #region methods

        public string GetVersionNumber() => _assemblyVersion;

        private static string GetConfigurationPath() => Path.Combine(ISettingsManager.GetAppData(), "config.json");

        public Color GetThemeAccent() =>
           !string.IsNullOrEmpty(ThemeAccentString)
               ? (Color)ColorConverter.ConvertFromString(ThemeAccentString)
               : (Color)ColorConverter.ConvertFromString("#DF2935");

        public void SetThemeAccent(Color color) => ThemeAccentString = color.ToString();

        #region red4

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
            return fi.Directory is { Parent.Parent: { } } ? Path.Combine(fi.Directory.Parent.Parent.FullName) : null;
        }

        public bool IsHealthy() => File.Exists(CP77ExecutablePath) && File.Exists(GetRED4OodleDll());


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
            ThemeAccentString = settings.ThemeAccentString;
            CP77ExecutablePath = settings.CP77ExecutablePath;
            CP77LaunchCommand = settings.CP77LaunchCommand;
            CP77LaunchOptions = settings.CP77LaunchOptions;
            ShowFilePreview = settings.ShowFilePreview;
            ReddbHash = settings.ReddbHash;
            MaterialRepositoryPath = settings.MaterialRepositoryPath;
            W3ExecutablePath = settings.W3ExecutablePath;
            WccLitePath = settings.WccLitePath;

            TreeViewGroups = settings.TreeViewGroups;
            TreeViewGroupSize = settings.TreeViewGroupSize;

            ShowAdvancedOptions = settings.ShowAdvancedOptions;

            if (settings.SettingsVersion != 2)
            {
                MigrateFromV1ToV2();
            }
        }

        public int SettingsVersion { get; set; }
        public bool CheckForUpdates { get; set; }
        public EUpdateChannel UpdateChannel { get; set; }
        public bool ShowGuidedTour { get; set; }
        public string ThemeAccentString { get; set; }
        public string CP77ExecutablePath { get; set; }
        public string CP77LaunchCommand { get; set; }
        public string CP77LaunchOptions { get; set; }
        public bool ShowFilePreview { get; set; }
        public string ReddbHash { get; set; }
        public string MaterialRepositoryPath { get; set; }
        public string W3ExecutablePath { get; set; }
        public string WccLitePath { get; set; }

        public bool TreeViewGroups { get; set; }
        public uint TreeViewGroupSize { get; set; }

        public bool ShowAdvancedOptions { get; set; }

        public SettingsManager ReconfigureSettingsManager(SettingsManager settingsManager)
        {
            if (SettingsVersion != 2)
            {
                MigrateFromV1ToV2();
            }

            settingsManager.SettingsVersion = SettingsVersion;
            settingsManager.CheckForUpdates = CheckForUpdates;
            settingsManager.UpdateChannel = UpdateChannel;
            settingsManager.ShowGuidedTour = ShowGuidedTour;
            settingsManager.ThemeAccentString = ThemeAccentString;
            settingsManager.CP77ExecutablePath = CP77ExecutablePath;
            settingsManager.CP77LaunchCommand = CP77LaunchCommand;
            settingsManager.CP77LaunchOptions = CP77LaunchOptions;
            settingsManager.ShowFilePreview = ShowFilePreview;
            settingsManager.ReddbHash = ReddbHash;
            settingsManager.MaterialRepositoryPath = MaterialRepositoryPath;
            settingsManager.W3ExecutablePath = W3ExecutablePath;
            settingsManager.WccLitePath = WccLitePath;

            settingsManager.TreeViewGroups = TreeViewGroups;
            settingsManager.TreeViewGroupSize = TreeViewGroupSize;

            settingsManager.ShowAdvancedOptions = ShowAdvancedOptions;

            return settingsManager;
        }

        public SettingsManager ToSettingsManager()
        {
            var config = new SettingsManager()
            {
            };

            return ReconfigureSettingsManager(config);
        }

        // Rather than create all kinds of new interfaces etc.,
        // always maintain the DTO as the current, and apply
        // all migrations in order for a controlled upgrade.
        private void MigrateFromV1ToV2()
        {
            if (!string.IsNullOrWhiteSpace(CP77ExecutablePath))
            {
                CP77LaunchCommand = CP77ExecutablePath;
            }

            SettingsVersion = 2;
        }
    }
}
