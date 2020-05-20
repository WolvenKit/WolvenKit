using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WolvenKit.Radish.Model
{
    public class RadishConfig
    {
        public RadishConfig()
        {

        }
        public static string ConfigurationPath
        {
            get
            {
                var path = Application.ExecutablePath;
                var filename = Path.GetFileNameWithoutExtension(path);
                var dir = Path.GetDirectoryName(path);
                return Path.Combine(dir ?? "", filename + "_radishconfig.xml");
            }
        }
        public List<RadishWorkflow> Workflows { get; set; } = new List<RadishWorkflow>();

        public void Save()
        {
            // serialize workflows
            var ser = new XmlSerializer(typeof(RadishConfig));
            var stream = new FileStream(RadishConfig.ConfigurationPath, FileMode.Create, FileAccess.Write);
            ser.Serialize(stream, this);
            stream.Close();
        }

        public static RadishConfig Load()
        {
            if (File.Exists(ConfigurationPath) && new FileInfo(ConfigurationPath).Length != 0)
            {
                var ser = new XmlSerializer(typeof(RadishConfig));
                var stream = new FileStream(ConfigurationPath, FileMode.Open, FileAccess.Read);
                var config = (RadishConfig)ser.Deserialize(stream);
                stream.Close();
                return config;
            }

            // Defaults
            return new RadishConfig
            {

            };
        }
    }
}
