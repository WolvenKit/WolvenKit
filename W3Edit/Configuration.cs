using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace W3Edit
{
    public class Configuration
    {
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

        /// <summary>
        ///     Configuration values
        /// </summary>
        public string ExecutablePath { get; set; }

        public string TextLanguage { get; set; }
        public string VoiceLanguage { get; set; }
        public string WccLite { get; set; }
        public Size MainSize { get; set; }
        public string InitialModDirectory { get; set; }
        public string InitialFileDirectory { get; set; }
        public Point MainLocation { get; set; }
        public FormWindowState MainState { get; set; }
        public string InitialExportDirectory { get; set; }

        ~Configuration()
        {
            Save();
        }

        public void Save()
        {
            var ser = new XmlSerializer(typeof (Configuration));
            var stream = new FileStream(ConfigurationPath, FileMode.Create, FileAccess.Write);
            ser.Serialize(stream, this);
            stream.Close();
        }

        public static Configuration Load()
        {
            if (File.Exists(ConfigurationPath))
            {
                var ser = new XmlSerializer(typeof (Configuration));
                var stream = new FileStream(ConfigurationPath, FileMode.Open, FileAccess.Read);
                var config = (Configuration) ser.Deserialize(stream);
                stream.Close();

                return config;
            }

            // Defaults
            return new Configuration
            {
                TextLanguage = "en",
                VoiceLanguage = "en",
            };
        }
    }
}