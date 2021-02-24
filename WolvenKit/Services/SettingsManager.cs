using MLib.Interfaces;
using System;
using System.IO;
using System.Xml.Serialization;
using Catel.IoC;
using Catel.MVVM;
using WolvenKit.Commands;
using Catel.Data;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WolvenKit.Services
{
    public class SettingsManager : ValidatableModelBase, ISettingsManager
    {
        #region fields

        private string _w3ExecutablePath = "";
        private string _cp77ExecutablePath = "";
        private string _wccLitePath = "";
        //private string _gameModDir = "";
        //private string _gameDlcDir = "";
        private string _depotPath = "";
        private System.Windows.Media.ImageBrush _profileImageBrush;

        private static string ConfigurationPath
        {
            get
            {
                var path = AppDomain.CurrentDomain.BaseDirectory;
                var filename = Path.GetFileNameWithoutExtension(path);
                var dir = Path.GetDirectoryName(path);
                return Path.Combine(dir ?? "", filename + "_config_n.json");
            }
        }

        private static string ImagePath
        {
            get
            {
                var path = AppDomain.CurrentDomain.BaseDirectory;
                var filename = Path.GetFileNameWithoutExtension(path);
                var dir = Path.GetDirectoryName(path);
                return Path.Combine(dir ?? "", filename + "_profile_image.png");
            }
        }

        #endregion

        #region constructors

        /// <summary>
        /// Default constructor.
        /// </summary>
        public SettingsManager()
        {




        }

        #endregion

        #region properties

        /// <summary>
        /// Gets the internal name and Uri source for all available themes.
        /// </summary>
        [XmlIgnore]
        public IThemeInfos Themes { get; private set; }

        public bool CheckForUpdates { get; set; }

        public string W3ExecutablePath
        {
            get => _w3ExecutablePath;
            set
            {
                _w3ExecutablePath = value;
                RaisePropertyChanged(nameof(W3ExecutablePath));
            }
        }
        public string CP77ExecutablePath
        {
            get => _cp77ExecutablePath;
            set
            {
                _cp77ExecutablePath = value;
                RaisePropertyChanged(nameof(CP77ExecutablePath));
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

        public string DepotPath
        {
            get =>_depotPath;
            set
            {
                _depotPath = value;
                RaisePropertyChanged(nameof(DepotPath));
            }
        }

        /// <summary>
        /// Gets/Sets the author's profile image brush.
        /// </summary>
        public System.Windows.Media.ImageBrush ProfileImageBrush
        {
            get => _profileImageBrush;
            set
            {
                _profileImageBrush = value;
                RaisePropertyChanged(nameof(ProfileImageBrush));
            }
        }

        public static bool FirstTimeSetupForUser { get; set; } = true;

        public string[] ManagerVersions { get; set; } = new string[(int)EManagerType.Max];
        public string TextLanguage { get; set; }

        #endregion

        #region methods

        public void Save()
        {
            var src = (System.Windows.Media.Imaging.BitmapSource)ProfileImageBrush?.ImageSource;
            if (src != null)
            {
                using (var fs1 = new FileStream(ImagePath, FileMode.OpenOrCreate))
                {
                    var frame = System.Windows.Media.Imaging.BitmapFrame.Create(src);
                    var enc = new System.Windows.Media.Imaging.PngBitmapEncoder();
                    enc.Frames.Add(frame);
                    enc.Save(fs1);
                }
            }

            File.WriteAllText(ConfigurationPath,
                JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    PreserveReferencesHandling = PreserveReferencesHandling.None,
                    TypeNameHandling = TypeNameHandling.None
                }));
        }

        public static SettingsManager Load()
        {
            SettingsManager config;
            try
            {
                if (File.Exists(ConfigurationPath))
                {
                    config = JsonConvert.DeserializeObject<SettingsManager>(File.ReadAllText(ConfigurationPath));
                    FirstTimeSetupForUser = false;
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
                var curversion = MainController.GetManagerVersion(e);

                if (savedversions != curversion)
                {
                    if (File.Exists(MainController.GetManagerPath(e)))
                        File.Delete(MainController.GetManagerPath(e));
                }
            }

            return config;
        }

        #endregion

    }
}
