using MLib.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Catel.IoC;
using Catel.MVVM;
using WolvenKit.Commands;
using Catel.Data;

namespace WolvenKit.Services
{
    public class SettingsManager : ModelBase, ISettingsManager
    {
        #region fields

        private string _executablePath = "";
        private string _wccLitePath = "";
        private string _gameModDir = "";
        private string _gameDlcDir = "";
        private string _depotPath = "";

        private static string ConfigurationPath
        {
            get
            {
                var path = AppDomain.CurrentDomain.BaseDirectory;
                var filename = Path.GetFileNameWithoutExtension(path);
                var dir = Path.GetDirectoryName(path);
                return Path.Combine(dir ?? "", filename + "_config_n.xml");
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

        public string ExecutablePath
        {
            get => _executablePath;
            set
            {
                _executablePath = value;
                RaisePropertyChanged(nameof(ExecutablePath));
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

        public string GameModDir
        {
            get => _gameModDir;
            set
            {
                _gameModDir = value;
                RaisePropertyChanged(nameof(GameModDir));
            }
        }
        public string GameDlcDir
        {
            get => _gameDlcDir;
            set
            {
                _gameDlcDir = value;
                RaisePropertyChanged(nameof(GameDlcDir));
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

        public string[] ManagerVersions { get; set; } = new string[(int)EManagerType.Max];
        public string TextLanguage { get; set; }

        #endregion

        #region methods

        public void Save()
        {
            var ser = new XmlSerializer(typeof(SettingsManager));
            var stream = new FileStream(ConfigurationPath, FileMode.Create, FileAccess.Write);
            ser.Serialize(stream, this);
            stream.Close();
        }

        public static SettingsManager Load()
        {
            SettingsManager config;
            try
            {
                if (File.Exists(ConfigurationPath))
                {
                    var ser = new XmlSerializer(typeof(SettingsManager));
                    
                    using (var stream = new FileStream(ConfigurationPath, FileMode.Open, FileAccess.Read))
                    {
                        config = (SettingsManager) ser.Deserialize(stream);
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
            catch (Exception ex)
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
