using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using WolvenKit.Common.Model;

namespace WolvenKit.Common
{
    public class W3Mod : ICloneable
    {
        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public string ProjectDirectory => Path.Combine(Path.GetDirectoryName(FileName), Name);

        #region Directories
        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public string FileDirectory
        {
            get
            {
                var dir = Path.Combine(ProjectDirectory, "files");
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);
                return dir;
            }
        }

        #region Top-level Dirs
        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public string ModDirectory
        {
            get
            {
                var dir = Path.Combine(FileDirectory, "Mod");
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);
                return dir;
            }
        }

        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public string DlcDirectory
        {
            get
            {
                var dir = Path.Combine(FileDirectory, "DLC");
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);
                return dir;
            }
        }

        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public string RawDirectory
        {
            get
            {
                var dir = Path.Combine(FileDirectory, "Raw");
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);
                return dir;
            }
        }

        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public string RadishDirectory
        {
            get
            {
                var dir = Path.Combine(ProjectDirectory, "files", "Radish");
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);
                return dir;
            }
        }
        #endregion

        #region Mod-level Dirs
        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public string TextureCacheDirectory
        {
            get
            {
                if (!Directory.Exists(Path.Combine(ModDirectory, EBundleType.TextureCache.ToString())))
                    Directory.CreateDirectory(Path.Combine(ModDirectory, EBundleType.TextureCache.ToString()));
                return Path.Combine(ModDirectory, EBundleType.TextureCache.ToString());
            }
        }
        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public string CollisionCacheDirectory
        {
            get
            {
                if (!Directory.Exists(Path.Combine(ModDirectory, EBundleType.CollisionCache.ToString())))
                    Directory.CreateDirectory(Path.Combine(ModDirectory, EBundleType.CollisionCache.ToString()));
                return Path.Combine(ModDirectory, EBundleType.CollisionCache.ToString());
            }
        }
        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public string BundleDirectory
        {
            get
            {
                if (!Directory.Exists(Path.Combine(ModDirectory, EBundleType.Bundle.ToString())))
                    Directory.CreateDirectory(Path.Combine(ModDirectory, EBundleType.Bundle.ToString()));
                return Path.Combine(ModDirectory, EBundleType.Bundle.ToString());
            }
        }
        #endregion


        #endregion



        #region Files
        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public List<string> Files
        {
            get
            {
                if (!Directory.Exists(FileDirectory))
                {
                    Directory.CreateDirectory(FileDirectory);
                }
                return Directory.EnumerateFiles(FileDirectory, "*", SearchOption.AllDirectories).Select(file => file.Substring(FileDirectory.Length + 1)).ToList();
            }
        }

        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public List<string> ModFiles
        {
            get
            {
                if (!Directory.Exists(ModDirectory))
                {
                    Directory.CreateDirectory(ModDirectory);
                }
                return Directory.EnumerateFiles(ModDirectory, "*", SearchOption.AllDirectories).Select(file => file.Substring(ModDirectory.Length + 1)).ToList();
            }
        }

        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public List<string> DLCFiles
        {
            get
            {
                if (!Directory.Exists(DlcDirectory))
                {
                    Directory.CreateDirectory(DlcDirectory);
                }
                return Directory.EnumerateFiles(DlcDirectory, "*", SearchOption.AllDirectories).Select(file => file.Substring(DlcDirectory.Length + 1)).ToList();
            }
        }

        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public List<string> RawFiles
        {
            get
            {
                if (!Directory.Exists(RawDirectory))
                {
                    Directory.CreateDirectory(RawDirectory);
                }
                return Directory.EnumerateFiles(RawDirectory, "*", SearchOption.AllDirectories).Select(file => file.Substring(RawDirectory.Length + 1)).ToList();
            }
        }

        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public List<string> RadishFiles
        {
            get
            {
                if (!Directory.Exists(RadishDirectory))
                {
                    Directory.CreateDirectory(RadishDirectory);
                }
                return Directory.EnumerateFiles(RadishDirectory, "*", SearchOption.AllDirectories).Select(file => file.Substring(RadishDirectory.Length + 1)).ToList();
            }
        }
        #endregion


        [Browsable(false)] 
        public List<string> LastOpenedFiles;


        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public string FileName { get; set; }

        [Category("About")]
        [Description("The name of your mod.")]
        public string Name { get; set; }
        [Category("About")]
        [Description("The version of your mod. It's a string so 0.1-ALPHA and such is possible.")]
        public string version { get; set; }

        public object Clone()
        {
            var clone = new W3Mod();
            clone.Name = Name;
            clone.FileName = FileName;
            clone.version = version;
            clone.LastOpenedFiles = LastOpenedFiles;
            return clone;
        }

        public void CreateDefaultDirectories()
        {
            // create top-level directories
            _ = ModDirectory;
            _ = DlcDirectory;
            _ = RawDirectory;
            _ = RadishDirectory;

            // create mod-level directories
            _ = TextureCacheDirectory;
            _ = CollisionCacheDirectory;
            _ = BundleDirectory;
        }
    }
}