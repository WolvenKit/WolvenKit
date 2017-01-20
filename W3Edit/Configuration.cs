using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace W3Edit
{
    public class Configuration
    {
        ~Configuration()
        {
            Save();
        }

        public static string ConfigurationPath
        {
            get
            {
                var path = Application.ExecutablePath;
                var filename = Path.GetFileNameWithoutExtension(path);
                var dir = Path.GetDirectoryName(path);
                return Path.Combine(dir, filename + "_config.xml");
            }
        }

        public void Save()
        {
            var ser = new XmlSerializer(typeof(Configuration));
            var stream = new FileStream(ConfigurationPath, FileMode.Create, FileAccess.Write);
            ser.Serialize(stream, this);
            stream.Close();
        }

        public static Configuration Load()
        {
            if (File.Exists(ConfigurationPath))
            {
                var ser = new XmlSerializer(typeof(Configuration));
                var stream = new FileStream(ConfigurationPath, FileMode.Open, FileAccess.Read);
                var config = (Configuration)ser.Deserialize(stream);
                stream.Close();

                return config;
            }

            // Defaults
            return new Configuration()
            {
                TextLanguage = "en",
                VoiceLanguage = "en",
                EnableFlowTreeEditor = true,
            };
        }

        /// <summary>
        ///  Configuration values
        /// </summary>
        public string ExecutablePath { get; set; }

        public string TextLanguage { get; set; }

        public string VoiceLanguage { get; set; }

        public string WCC_Lite { get; set; }

        public System.Drawing.Size MainSize { get; set; }

        public string InitialModDirectory { get; set; }

        public string InitialFileDirectory { get; set; }

        public bool EnableFlowTreeEditor { get; set; }

        public System.Drawing.Point MainLocation { get; set; }

        public FormWindowState MainState { get; set; }

        public string InitialExportDirectory { get; set; }
    }
}
