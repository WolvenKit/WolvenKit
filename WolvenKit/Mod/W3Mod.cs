using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace WolvenKit.Mod
{
    public class W3Mod : ICloneable
    {
        [XmlIgnore]
        public string FileName { get; set; }

        [XmlIgnore]
        public string Directory
        {
            get { return Path.Combine(Path.GetDirectoryName(FileName), Name); }
        }

        [XmlIgnore]
        public string FileDirectory
        {
            get { return Path.Combine(Directory, "files"); }
        }

        public string Name { get; set; }

        [XmlIgnore]
        public List<string> Files
        {
            get
            {
                if (!System.IO.Directory.Exists(FileDirectory))
                {
                    System.IO.Directory.CreateDirectory(FileDirectory);
                }
                return System.IO.Directory.EnumerateFiles(FileDirectory, "*", SearchOption.AllDirectories)
                                        .Select(file => file.Substring(FileDirectory.Length + 1)).ToList();
            }
        }

        public bool InstallAsDLC { get; set; }

        public object Clone()
        {
            var clone = new W3Mod();
            clone.Name = Name;
            clone.InstallAsDLC = InstallAsDLC;
            clone.FileName = FileName;
            return clone;
        }
    }
}