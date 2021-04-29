using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace WolvenKit.Common.Model
{
    public abstract class EditorProjectData : ObservableObject
    {
        #region Fields

        [Browsable(false)]
        public List<string> LastOpenedFiles;

        #endregion Fields

        #region Properties

        [Category("About")]
        [Description("The name of the mod author.")]
        public string Author { get; set; }

        [Category("About")]
        [Description("An e-mail address to contact the author with.")]
        public string Email { get; set; }

        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public string FileName { get; set; }

        [Category("About")]
        [Description("The name of your mod.")]
        public string Name { get; set; }

        [XmlIgnore]
        [ReadOnly(true)]
        [Browsable(false)]
        public string ProjectDirectory => Path.Combine(Path.GetDirectoryName(FileName), Name);

        [Browsable(false)]
        [Category("About")]
        [Description("The mod version. Alphanumeric values (0.1-alpha etc.) are possible.")]
        public string Version { get; set; } = "0.62";

        #endregion Properties

        #region Methods

        public abstract void CreateDefaultDirectories();

        #endregion Methods

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

        #region Top-level Dirs

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

        #endregion Top-level Dirs

        #region Mod-level Dirs

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

        #endregion Mod-level Dirs

        #region DLC-level Dirs

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

        #endregion DLC-level Dirs

        #region RAW-level Dirs

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

        #endregion RAW-level Dirs

        #region Cooked and Packed Directories

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

        #endregion Cooked and Packed Directories

        #endregion Directories

        #region Files

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

        #endregion Files

        public abstract string GetDlcCookedRelativePath();

        public abstract string GetDlcName();

        public abstract string GetDlcUncookedRelativePath();
    }
}
