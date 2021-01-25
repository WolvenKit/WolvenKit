using MLib.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Catel.IoC;
using Catel.MVVM;
using WolvenKit.Commands;

namespace WolvenKit.Services
{
    public class SettingsManager : ISettingsManager
    {
        #region fields

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

        public string W3ExecutablePath { get; set; }
        public string CP77ExecutablePath { get; set; }
        public string WccLitePath { get; set; }

        public string GameModDir { get; set; }
        public string GameDlcDir { get; set; }

        public string DepotPath { get; set; }

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
