using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text.Json;
using System.Windows.Media;
using DynamicData.Binding;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common;
using WolvenKit.Core;

namespace WolvenKit.Functionality.Services
{
    /// <summary>
    /// This handles the application settings defined by the user.
    /// </summary>
    public class SettingsManager : ReactiveObject, ISettingsManager
    {
        #region fields

        private bool _isLoaded;

        private string _assemblyVersion;

        #endregion fields

        #region constructors

        /// <summary>
        /// Default constructor.
        /// </summary>
        public SettingsManager()
        {
            _assemblyVersion = CommonFunctions.GetAssemblyVersion(Constants.AssemblyName).ToString();

            _ = this.WhenAnyPropertyChanged(
                nameof(ShowGuidedTour),
                nameof(UpdateChannel),
                nameof(MaterialRepositoryPath),
                nameof(ThemeAccentString),
                nameof(CheckForUpdates),
                nameof(CP77ExecutablePath),
                nameof(ShowFilePreview),
                nameof(ReddbHash)
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

        #region properties

        #region general

        [Category("General")]
        [Display(Name = "Show guided tour")]
        [Reactive]
        public bool ShowGuidedTour { get; set; } = true;

        [Category("General")]
        [Display(Name = "Update channel")]
        [Reactive]
        public EUpdateChannel UpdateChannel { get; set; }

        [Category("General")]
        [Display(Name = "Depot path")]
        [Reactive]
        public string MaterialRepositoryPath { get; set; }

        [Reactive]
        public string ThemeAccentString { get; set; }

        // unused
        [Reactive]
        [Browsable(false)]
        public bool CheckForUpdates { get; set; }

        #endregion

        #region red4

        [Category("Cyberpunk")]
        [Display(Name = "Game executable path (.exe)")]
        [Reactive]
        public string CP77ExecutablePath { get; set; }

        [Category("Cyberpunk")]
        [Display(Name = "Show file preview")]
        [Reactive]
        public bool ShowFilePreview { get; set; }

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

        public string GetRED4OodleDll() => string.IsNullOrEmpty(GetRED4GameRootDir()) ? null : Path.Combine(GetRED4GameRootDir(), "bin", "x64", WolvenKit.Core.Constants.Oodle);

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

        public bool IsHealthy() => File.Exists(CP77ExecutablePath) && File.Exists(GetRED4OodleDll());

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
                        config = dto.FromDto();
                    }
                }
            }
            catch (Exception)
            {
            }

            // Defaults
            config ??= new SettingsManager
            {

            };

            config._isLoaded = true;
            return config;
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
            ThemeAccentString = settings.ThemeAccentString;
            CP77ExecutablePath = settings.CP77ExecutablePath;
            ShowFilePreview = settings.ShowFilePreview;
            ReddbHash = settings.ReddbHash;
            MaterialRepositoryPath = settings.MaterialRepositoryPath;
            W3ExecutablePath = settings.W3ExecutablePath;
            WccLitePath = settings.WccLitePath;
        }

        public bool CheckForUpdates { get; set; }
        public EUpdateChannel UpdateChannel { get; set; }
        public bool ShowGuidedTour { get; set; }
        public string ThemeAccentString { get; set; }
        public string CP77ExecutablePath { get; set; }
        public bool ShowFilePreview { get; set; }
        public string ReddbHash { get; set; }
        public string MaterialRepositoryPath { get; set; }
        public string W3ExecutablePath { get; set; }
        public string WccLitePath { get; set; }

        public SettingsManager FromDto()
        {
            var config = new SettingsManager()
            {
                CheckForUpdates = CheckForUpdates,
                UpdateChannel = UpdateChannel,
                ShowGuidedTour = ShowGuidedTour,
                ThemeAccentString = ThemeAccentString,
                CP77ExecutablePath = CP77ExecutablePath,
                ShowFilePreview = ShowFilePreview,
                ReddbHash = ReddbHash,
                MaterialRepositoryPath = MaterialRepositoryPath,
                W3ExecutablePath = W3ExecutablePath,
                WccLitePath = WccLitePath,
            };
            return config;
        }
    }
}
