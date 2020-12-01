using MLib.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace WolvenKit.App.Services
{
    public class SettingsManager : ISettingsManager
    {

        /// <summary>
		/// Gets the internal name and Uri source for all available themes.
		/// </summary>
		[XmlIgnore]
        public IThemeInfos Themes { get; private set; }

        public string ExecutablePath { get; set; }
        public string[] ManagerVersions { get; set; } = new string[(int)EManagerType.Max];
        public string TextLanguage { get; set; }

        /// <summary>
        /// Hidden default constructor.
        /// </summary>
        public SettingsManager()
		{



			
		}


        public static string ConfigurationPath
        {
            get
            {
                var path = AppDomain.CurrentDomain.BaseDirectory;
                var filename = Path.GetFileNameWithoutExtension(path);
                var dir = Path.GetDirectoryName(path);
                return Path.Combine(dir ?? "", filename + "_config_n.xml");
            }
        }

        public void Save()
        {
            var ser = new XmlSerializer(typeof(Configuration));
            var stream = new FileStream(ConfigurationPath, FileMode.Create, FileAccess.Write);
            ser.Serialize(stream, this);
            stream.Close();
        }

        public static SettingsManager Load()
        {
            SettingsManager config;
            try
            {
                if (File.Exists(ConfigurationPath) && new FileInfo(ConfigurationPath).Length != 0)
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


    }
}
