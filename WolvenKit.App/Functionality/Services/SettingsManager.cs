using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Media;
using Catel.Data;
using Newtonsoft.Json;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.WKitGlobal;

namespace WolvenKit.Functionality.Services
{
    /// <summary>
    /// This handles the application settings defined by the user.
    /// </summary>
    public class SettingsManager : ValidatableModelBase, ISettingsManager
    {
        #region fields

        private string _cp77ExecutablePath = "";
        private string _depotPath = "";
        private string _materialRepositoryPath = "";
        private System.Windows.Media.ImageBrush _profileImageBrush;
        private string _w3ExecutablePath = "";
        private string _wccLitePath = "";

        private static string ConfigurationPath
        {
            get
            {
                return Path.Combine(IGameController.WKitAppData, "_config_n.json");
            }
        }

        private static string ImagePath
        {
            get
            {
                return Path.Combine(IGameController.WKitAppData, "_profile_image.png");
            }
        }

        #endregion fields

        #region constructors

        /// <summary>
        /// Default constructor.
        /// </summary>
        public SettingsManager()
        {
        }

        #endregion constructors

        #region properties

        public static bool FirstTimeSetupForUser { get; set; } = true;

        public bool ShowGuidedTour { get; set; } = true;

        public bool CheckForUpdates { get; set; }

        public string DepotPath
        {
            get => _depotPath;
            set
            {
                _depotPath = value;
                RaisePropertyChanged(nameof(DepotPath));
            }
        }

        public string MaterialRepositoryPath
        {
            get => _materialRepositoryPath;
            set
            {
                _materialRepositoryPath = value;
                RaisePropertyChanged(nameof(MaterialRepositoryPath));
            }
        }

        public string[] ManagerVersions { get; set; } = new string[(int)EManagerType.Max];

        /// <summary>
        /// Gets/Sets the author's profile image brush.
        /// </summary>
        [JsonIgnore]
        public ImageBrush ProfileImageBrush
        {
            get => _profileImageBrush;
            set
            {
                _profileImageBrush = value;
                RaisePropertyChanged(nameof(ProfileImageBrush));
            }
        }

        public string TextLanguage { get; set; }

        public Color ThemeAccent { get; set; } = (Color)ColorConverter.ConvertFromString("#DF2935");

        #region red4

        public string CP77ExecutablePath
        {
            get => _cp77ExecutablePath;
            set
            {
                _cp77ExecutablePath = value;
                RaisePropertyChanged(nameof(CP77ExecutablePath));
            }
        }

        public string RED4GameRootDir
        {
            get
            {
                try
                {
                    return Path.Combine(new FileInfo(CP77ExecutablePath).Directory.Parent.Parent.FullName);
                }
                catch (Exception e)
                {
                    Trace.WriteLine(e);

                    return e.Message;
                }
            }
        }

        public string RED4GameModDir
        {
            get
            {
                var dir = Path.Combine(RED4GameRootDir, "archive", "pc", "mod");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                return dir;
            }
        }

        #endregion red4

        #region red3

        public string W3ExecutablePath
        {
            get => _w3ExecutablePath;
            set
            {
                _w3ExecutablePath = value;
                RaisePropertyChanged(nameof(W3ExecutablePath));
            }
        }

        public string WccLitePath
        {
            get => _wccLitePath;
            set
            {
                _wccLitePath = value;
                RaisePropertyChanged(nameof(WccLitePath));
            }
        }

        public string W3GameContentDir => Path.Combine(W3GameRootDir, "content");

        public string W3GameDlcDir => Path.Combine(W3GameRootDir, "DLC");

        public string W3GameModDir => Path.Combine(W3GameRootDir, "Mods");

        public string W3GameRootDir => Path.Combine(W3ExecutablePath, @"..\..\..\");

        #endregion red3

        #endregion properties

        #region methods

        public bool CheckSelf() => File.Exists(CP77ExecutablePath);

        public static SettingsManager Load()
        {
            SettingsManager config;
            try
            {
                if (File.Exists(ConfigurationPath))
                {
                    config = JsonConvert.DeserializeObject<SettingsManager>(File.ReadAllText(ConfigurationPath));

                    if (config == null)
                    {
                        throw new SerializationException();
                    }

                    if (config.CheckSelf())
                    {
                        FirstTimeSetupForUser = false;
                    }
                }
                else
                {
                    // Defaults
                    config = new SettingsManager
                    {
                        TextLanguage = "en",
                        //VoiceLanguage = "en",
                    };
                }
            }
            catch (Exception)
            {
                // Defaults
                config = new SettingsManager
                {
                    TextLanguage = "en",
                    //VoiceLanguage = "en",
                };
            }

            // TODO: move this?
            // add a mechanism to update individual cache managers
            for (var j = 0; j < config.ManagerVersions.Length; j++)
            {
                var savedversions = config.ManagerVersions[j];
                var e = (EManagerType)j;
                var curversion = IGameController.GetManagerVersion(e);

                if (savedversions != curversion)
                {
                    if (File.Exists(IGameController.GetManagerPath(e)))
                    {
                        File.Delete(IGameController.GetManagerPath(e));
                    }
                }
            }

            return config;
        }

        public void Save()
        {
            var src = (System.Windows.Media.Imaging.BitmapSource)ProfileImageBrush?.ImageSource;
            if (src != null)
            {
                using var fs1 = new FileStream(ImagePath, FileMode.OpenOrCreate);
                var frame = System.Windows.Media.Imaging.BitmapFrame.Create(src);
                var enc = new System.Windows.Media.Imaging.PngBitmapEncoder();
                enc.Frames.Add(frame);
                enc.Save(fs1);
            }

            File.WriteAllText(ConfigurationPath,
                JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    PreserveReferencesHandling = PreserveReferencesHandling.None,
                    TypeNameHandling = TypeNameHandling.None
                }));
        }

        #endregion methods
    }
}
