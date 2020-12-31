using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WolvenKit.Common.Model
{
    public class CP77Mod : EditorProjectData, ICloneable
    {
        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public string ProjectDirectory => Path.Combine(Path.GetDirectoryName(FileName), Name);

        #region Directories
        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public string BackupDirectory
        {
            get
            {
                var dir = Path.Combine(ProjectDirectory, "_backups");
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);
                return dir;
            }
        }

        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public string RecyclebinDirectory
        {
            get
            {
                var dir = Path.Combine(ProjectDirectory, "_recyclebin");
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);
                return dir;
            }
        }

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
        public string ModUncookedDirectory
        {
            get
            {
                if (!Directory.Exists(Path.Combine(ModDirectory, EProjectFolders.Uncooked.ToString())))
                    Directory.CreateDirectory(Path.Combine(ModDirectory, EProjectFolders.Uncooked.ToString()));
                return Path.Combine(ModDirectory, EProjectFolders.Uncooked.ToString());
            }
        }
        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public string ModCookedDirectory
        {
            get
            {
                if (!Directory.Exists(Path.Combine(ModDirectory, EProjectFolders.Cooked.ToString())))
                    Directory.CreateDirectory(Path.Combine(ModDirectory, EProjectFolders.Cooked.ToString()));
                return Path.Combine(ModDirectory, EProjectFolders.Cooked.ToString());
            }
        }
        #endregion

        #region DLC-level Dirs
        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public string DlcUncookedDirectory
        {
            get
            {
                if (!Directory.Exists(Path.Combine(DlcDirectory, EProjectFolders.Uncooked.ToString())))
                    Directory.CreateDirectory(Path.Combine(DlcDirectory, EProjectFolders.Uncooked.ToString()));
                return Path.Combine(DlcDirectory, EProjectFolders.Uncooked.ToString());
            }
        }
        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public string DlcCookedDirectory
        {
            get
            {
                if (!Directory.Exists(Path.Combine(DlcDirectory, EProjectFolders.Cooked.ToString())))
                    Directory.CreateDirectory(Path.Combine(DlcDirectory, EProjectFolders.Cooked.ToString()));
                return Path.Combine(DlcDirectory, EProjectFolders.Cooked.ToString());
            }
        }
        #endregion

        #region RAW-level Dirs
        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public string RawModDirectory
        {
            get
            {
                if (!Directory.Exists(Path.Combine(RawDirectory, "Mod")))
                    Directory.CreateDirectory(Path.Combine(RawDirectory, "Mod"));
                return Path.Combine(RawDirectory, "Mod");
            }
        }
        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public string RawDlcDirectory
        {
            get
            {
                if (!Directory.Exists(Path.Combine(RawDirectory, "DLC")))
                    Directory.CreateDirectory(Path.Combine(RawDirectory, "DLC"));
                return Path.Combine(RawDirectory, "DLC");
            }
        }
        #endregion

        #region Cooked and Packed Directories
        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public string CookedModDirectory
        {
            get
            {
                var dir = Path.Combine(ProjectDirectory, "cooked", "Mods", $"mod{Name}", "content");
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);
                return dir;
            }
        }
        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public string PackedModDirectory
        {
            get
            {
                var dir = Path.Combine(ProjectDirectory, "packed", "Mods", $"mod{Name}", "content");
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);
                return dir;
            }
        }
        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public string CookedDlcDirectory
        {
            get
            {
                if (string.IsNullOrEmpty(GetDlcName()))
                {
                    return null;
                }
                var dir = Path.Combine(ProjectDirectory, "cooked", "DLC", GetDlcName(), "content");
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);
                return dir;
            }
        }
        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public string PackedDlcDirectory
        {
            get
            {
                if (string.IsNullOrEmpty(GetDlcName()))
                {
                    return null;
                }
                var dir = Path.Combine(ProjectDirectory, "packed", "DLC", GetDlcName(), "content");
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);
                return dir;
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
                return Directory.EnumerateFiles(FileDirectory, "*", SearchOption.AllDirectories)
                    .Select(file => file.Substring(FileDirectory.Length + 1))
                    .ToList();
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
                return Directory.EnumerateFiles(ModDirectory, "*", SearchOption.AllDirectories)
                    .Select(file => file.Substring(ModDirectory.Length + 1))
                    .ToList();
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
        [Description("The name of your mod.")]
        public string Author { get; set; }

        [Category("About")]
        [Description("The name of your mod.")]
        public string Email { get; set; }

        [Browsable(false)]
        [Category("About")]
        [Description("The version of your mod. It's a string so 0.1-ALPHA and such is possible.")]
        public string Version { get; set; } = "0.62";

        public object Clone()
        {
            var clone = new Common.W3Mod
            {
                Name = Name,
                Author = Author,
                Email = Email,
                Version = Version,
                FileName = FileName,
                LastOpenedFiles = LastOpenedFiles
            };
            return clone;
        }

        public override void CreateDefaultDirectories()
        {
            // create top-level directories
            _ = ModDirectory;
            _ = DlcDirectory;
            _ = RawDirectory;
            _ = RadishDirectory;

            // create mod-level directories
            _ = ModUncookedDirectory;
            _ = ModCookedDirectory;

            // create dlc-level directories
            _ = DlcUncookedDirectory;
            _ = DlcCookedDirectory;

            // create raw-level directories
            _ = RawModDirectory;
            _ = RawDlcDirectory;
        }


        /// <summary>
        /// Returns the first relative folder path in the ActiveMod/dlc directory
        /// Does not support multiple DLC
        /// </summary>
        /// <returns></returns>
        public string GetDlcName()
        {
            if (!string.IsNullOrEmpty(GetDlcCookedRelativePath()))
                return GetDlcCookedRelativePath();
            if (!string.IsNullOrEmpty(GetDlcUncookedRelativePath()))
                return GetDlcUncookedRelativePath();
            return "";
        }

        /// <summary>
        /// Returns the first folder name in the DlcCookedDirectory.
        /// Does not support multiple dlc
        /// </summary>
        /// <returns></returns>
        public string GetDlcCookedRelativePath()
        {
            string relpath = "";
            var di = new DirectoryInfo(DlcCookedDirectory);
            if (di.Exists && di.GetDirectories().Any())
            {
                // support older projects
                if (di.GetDirectories().Any(_ => _.Name == "dlc"))
                {
                    var subdi = di.GetDirectories().First(_ => _.Name == "dlc");
                    if (subdi.Exists && subdi.GetDirectories().Any())
                    {
                        relpath = subdi.GetDirectories().First().FullName;
                        return relpath.Substring(DlcCookedDirectory.Length + 5);
                    }
                    else
                    {
                        return "";
                    }
                }
                else
                    relpath = di.GetDirectories().First().FullName;
                return relpath.Substring(DlcCookedDirectory.Length + 1);
            }
            return relpath;
        }

        /// <summary>
        /// Returns the first folder name in the DlcUncookedDirectory.
        /// Does not support multiple dlc
        /// </summary>
        /// <returns></returns>
        public string GetDlcUncookedRelativePath()
        {
            string relpath = "";
            var di = new DirectoryInfo(DlcUncookedDirectory);
            if (di.Exists && di.GetDirectories().Any())
            {
                // support older projects
                if (di.GetDirectories().Any(_ => _.Name == "dlc"))
                {
                    var subdi = di.GetDirectories().First(_ => _.Name == "dlc");
                    if (subdi.Exists && subdi.GetDirectories().Any())
                    {
                        relpath = subdi.GetDirectories().First().FullName;
                        return relpath.Substring(DlcUncookedDirectory.Length + 5);
                    }
                    else
                    {
                        return "";
                    }
                }
                else
                    relpath = di.GetDirectories().First().FullName;
                return relpath.Substring(DlcUncookedDirectory.Length + 1);
            }
            return relpath;
        }
    }
}
