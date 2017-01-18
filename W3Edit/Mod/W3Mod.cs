using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace W3Edit.Mod
{
    public class W3Mod
    {
        [XmlIgnore]
        public string FileName { 
            get; 
            set; 
        }

        [XmlIgnore]
        public string Directory
        {
            get
            {
                return Path.Combine(Path.GetDirectoryName(FileName), Name);
            }
        }

        [XmlIgnore]
        public string FileDirectory
        {
            get
            {
                return Path.Combine(Directory, "files");
            }
        }

        public string Name { get; set; }

        [XmlIgnore]
        public List<string> Files
        {
            get
            {
                var list = new List<string>();

                if(!System.IO.Directory.Exists(FileDirectory))
                {
                    System.IO.Directory.CreateDirectory(FileDirectory);
                }

                var allFiles = System.IO.Directory.GetFiles(FileDirectory, "*", SearchOption.AllDirectories);
                foreach (var file in allFiles)
                {
                    // Relative paths
                    list.Add(file.Substring(FileDirectory.Length + 1));
                }

                return list;
            }
        }

        public bool InstallAsDLC { get; set; }
    }
}
