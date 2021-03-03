using System;
using System.IO;
using System.Xml.Serialization;
using WolvenKit.Common.DDS;
using WolvenKit.Functionality.WKitGlobal;

namespace WolvenKit.Functionality.Controllers
{
    public class Configuration
    {
        #region Destructors

        ~Configuration()
        {
            Save();
        }

        #endregion Destructors



        #region Properties

        public static string ConfigurationPath
        {
            get
            {
                var path = AppDomain.CurrentDomain.BaseDirectory;
                var filename = Path.GetFileNameWithoutExtension(path);
                var dir = Path.GetDirectoryName(path);
                return Path.Combine(dir ?? "", filename + "_config.xml");
            }
        }

        public string CP77ExePath { get; set; }

        [XmlIgnore]
        public string CP77GameContentDir => Path.Combine(CP77GameRootDir, "content");

        [XmlIgnore]
        public string CP77GameRootDir => Path.Combine(CP77ExePath, @"..\..\..\");

        public string DepotPath { get; set; }

        public string InitialExportDirectory { get; set; }

        public string InitialFileDirectory { get; set; }

        public string InitialModDirectory { get; set; }

        public bool IsAutoInstallModsDisabled { get; set; }

        public bool IsWelcomeFormDisabled { get; set; }

        public string[] ManagerVersions { get; set; } = new string[(int)EManagerType.Max];

        public string TextLanguage { get; set; }

        public EUncookExtension UncookExtension { get; set; }

        public EUpdateChannel UpdateChannel { get; set; }

        public string VoiceLanguage { get; set; }

        /// <summary>
        ///     Configuration values
        /// </summary>
        public string W3ExePath { get; set; }

        [XmlIgnore]
        public string W3GameContentDir => Path.Combine(W3GameRootDir, "content");

        [XmlIgnore]
        public string W3GameDlcDir => Path.Combine(W3GameRootDir, "DLC");

        [XmlIgnore]
        public string W3GameModDir => Path.Combine(W3GameRootDir, "Mods");

        [XmlIgnore]
        public string W3GameRootDir => Path.Combine(W3ExePath, @"..\..\..\");

        public string WccLite { get; set; }

        #endregion Properties



        #region Methods

        public static Configuration Load()
        {
            try
            {
                if (File.Exists(ConfigurationPath) && new FileInfo(ConfigurationPath).Length != 0)
                {
                    var ser = new XmlSerializer(typeof(Configuration));
                    var stream = new FileStream(ConfigurationPath, FileMode.Open, FileAccess.Read);
                    var config = (Configuration)ser.Deserialize(stream);
                    stream.Close();
                    return config;
                }
            }
            catch (Exception)
            {
            }

            // Defaults
            return new Configuration
            {
                TextLanguage = "en",
                VoiceLanguage = "en",
            };
        }

        public void Save()
        {
            var ser = new XmlSerializer(typeof(Configuration));
            var stream = new FileStream(ConfigurationPath, FileMode.Create, FileAccess.Write);
            ser.Serialize(stream, this);
            stream.Close();
        }

        #endregion Methods
    }
}
