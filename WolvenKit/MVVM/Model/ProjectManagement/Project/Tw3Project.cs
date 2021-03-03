using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Catel.IoC;
using WolvenKit.Bundles;
using WolvenKit.Cache;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.CR2W;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.W3Speech;
using WolvenKit.W3Strings;

namespace WolvenKit.MVVM.Model.ProjectManagement.Project
{
    public sealed class Tw3Project : EditorProject, ICloneable
    {
        #region fields

        private readonly ILoggerService _logger;
        private readonly ISettingsManager _settings;
        private BundleManager BundleManager;
        private CollisionManager CollisionManager;
        private Task initializeTask;

        private SoundManager SoundManager;
        private TextureManager TextureManager;
        private W3StringManager W3StringManager;
        private SpeechManager SpeechManager { get; set; }

        #endregion fields



        #region Constructors

        public Tw3Project(string location) : base(location)
        {
            _settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
            _logger = ServiceLocator.Default.ResolveType<ILoggerService>();
            if (File.Exists(location))
            {
                Load(location);
            }
        }

        public Tw3Project() : base("")
        {
        }

        #endregion Constructors

        #region properties

        public override bool IsInitialized => initializeTask?.Status == TaskStatus.RanToCompletion;

        public override void Load(string path)
        {
            using (var lf = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                var ser = new XmlSerializer(typeof(W3Mod));
                var obj = (W3Mod)ser.Deserialize(lf);
                Name = obj.Name;
                Version = obj.Version;
                Author = obj.Author;
                Email = obj.Email;
                GameType = GameType.Witcher3;
                Data = obj;
                Data.FileName = path;
            }
        }

        public override void Save(string path)
        {
            using (var sf = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                var ser = new XmlSerializer(typeof(W3Mod));
                ser.Serialize(sf, (W3Mod)Data);
            }
        }

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
                {
                    Directory.CreateDirectory(dir);
                }

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
                {
                    Directory.CreateDirectory(dir);
                }

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
                {
                    Directory.CreateDirectory(dir);
                }

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
                {
                    Directory.CreateDirectory(dir);
                }

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
                {
                    Directory.CreateDirectory(dir);
                }

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
                {
                    Directory.CreateDirectory(Path.Combine(ModDirectory, EProjectFolders.Cooked.ToString()));
                }

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
                {
                    Directory.CreateDirectory(Path.Combine(ModDirectory, EProjectFolders.Uncooked.ToString()));
                }

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
                {
                    Directory.CreateDirectory(Path.Combine(DlcDirectory, EProjectFolders.Cooked.ToString()));
                }

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
                {
                    Directory.CreateDirectory(Path.Combine(DlcDirectory, EProjectFolders.Uncooked.ToString()));
                }

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
                {
                    Directory.CreateDirectory(Path.Combine(RawDirectory, "DLC"));
                }

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
                {
                    Directory.CreateDirectory(Path.Combine(RawDirectory, "Mod"));
                }

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
                {
                    Directory.CreateDirectory(dir);
                }

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
                {
                    Directory.CreateDirectory(dir);
                }

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
                {
                    Directory.CreateDirectory(dir);
                }

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
                {
                    Directory.CreateDirectory(dir);
                }

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
                return Directory.EnumerateFiles(DlcDirectory, "*", SearchOption.AllDirectories)
                    .Select(file => file.Substring(DlcDirectory.Length + 1))
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
                return Directory.EnumerateFiles(RadishDirectory, "*", SearchOption.AllDirectories)
                    .Select(file => file.Substring(RadishDirectory.Length + 1))
                    .ToList();
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
                return Directory.EnumerateFiles(RawDirectory, "*", SearchOption.AllDirectories)
                    .Select(file => file.Substring(RawDirectory.Length + 1))
                    .ToList();
            }
        }

        #endregion Files

        #endregion properties

        #region methods

        // TODO: debug
        public override void Check() => _logger.LogString($"{initializeTask.Status.ToString()}", Logtype.Error);

        public void CreateDefaultDirectories()
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
        /// Returns the first folder name in the DlcCookedDirectory.
        /// Does not support multiple dlc
        /// </summary>
        /// <returns></returns>
        public string GetDlcCookedRelativePath()
        {
            var relpath = "";
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
                {
                    relpath = di.GetDirectories().First().FullName;
                }

                return relpath.Substring(DlcCookedDirectory.Length + 1);
            }
            return relpath;
        }

        /// <summary>
        /// Returns the first relative folder path in the ActiveMod/dlc directory
        /// Does not support multiple DLC
        /// </summary>
        /// <returns></returns>
        public string GetDlcName()
        {
            if (!string.IsNullOrEmpty(GetDlcCookedRelativePath()))
            {
                return GetDlcCookedRelativePath();
            }

            if (!string.IsNullOrEmpty(GetDlcUncookedRelativePath()))
            {
                return GetDlcUncookedRelativePath();
            }

            return "";
        }

        /// <summary>
        /// Returns the first folder name in the DlcUncookedDirectory.
        /// Does not support multiple dlc
        /// </summary>
        /// <returns></returns>
        public string GetDlcUncookedRelativePath()
        {
            var relpath = "";
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
                {
                    relpath = di.GetDirectories().First().FullName;
                }

                return relpath.Substring(DlcUncookedDirectory.Length + 1);
            }
            return relpath;
        }

        public sealed override Task Initialize()
        {
            // if initializeTask is null
            if (initializeTask == null)
            {
                initializeTask = Task.Run(() => InitializeAsync());
            }
            else
            {
                // TODO: needed?
                if (initializeTask.IsCompleted == false &&
                    initializeTask.Status != TaskStatus.Running &&
                    initializeTask.Status != TaskStatus.WaitingToRun &&
                    initializeTask.Status != TaskStatus.WaitingForActivation)
                {
                }
                else
                {
                }
            }

            return initializeTask;
        }

        private async Task InitializeAsync()
        {
            BundleManager ??= await Task.Run(() => Tw3Controller.LoadBundleManager()).ConfigureAwait(false);
            W3StringManager ??= await Task.Run(() => Tw3Controller.LoadStringsManager()).ConfigureAwait(false);
            TextureManager ??= await Task.Run(() => Tw3Controller.LoadTextureManager()).ConfigureAwait(false);
            CollisionManager ??= await Task.Run(() => Tw3Controller.LoadCollisionManager()).ConfigureAwait(false);
            SoundManager ??= await Task.Run(() => Tw3Controller.LoadSoundManager()).ConfigureAwait(false);
            SpeechManager ??= await Task.Run(() => Tw3Controller.LoadSpeechManager()).ConfigureAwait(false);

            // Hash all filepaths
            _logger.LogString("Starting additional tasks...", Logtype.Important);
            var relativepaths = ModFiles
                .Select(_ => _.Substring(_.IndexOf(Path.DirectorySeparatorChar) + 1))
                .ToList();
            Cr2wResourceManager.Get().RegisterAndWriteCustomPaths(relativepaths);

            // register all custom classes
            CR2WManager.Init(FileDirectory, MainController.Get().Logger);
            _logger.LogString("Finished additional tasks...", Logtype.Success);

            NotificationHelper.Growl.Success($"Project {Name} has finished loading.");
        }

        #endregion methods



        #region Methods

        public object Clone()
        {
            var clone = new Tw3Project()
            {
                Name = Name,
                Author = Author,
                Email = Email,
                Version = Version,
                Location = Location
            };
            return clone;
        }

        public override string ToString() => Location;

        #endregion Methods
    }
}
