using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Catel.IoC;
using Catel.Logging;

using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.CR2W;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.MVVM.Model.ProjectManagement.Project
{
    public sealed class Cp77Project : EditorProject, ICloneable
    {
        #region fields

        private readonly ILog _logger;
        private readonly ISettingsManager _settings;
        private Task initializeTask;

        #endregion fields

        #region Constructors

        public Cp77Project(string location) : base(location)
        {
            _settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
            _logger = LogManager.GetCurrentClassLogger();
            if (File.Exists(location))
            {
                Load(location);
            }
        }

        public Cp77Project() : base("")
        {
        }

        #endregion Constructors

        #region properties

        public override bool IsInitialized => initializeTask?.Status == TaskStatus.RanToCompletion;

        public override void Load(string path)
        {
            using var lf = new FileStream(path, FileMode.Open, FileAccess.Read);
            var ser = new XmlSerializer(typeof(CP77Mod));
            var obj = (CP77Mod)ser.Deserialize(lf);
            Name = obj.Name;
            Version = obj.Version;
            Author = obj.Author;
            Email = obj.Email;
            GameType = GameType.Cyberpunk2077;
            Data = obj;
            Data.FileName = path;
        }

        public override void Save(string path)
        {
            if (path == null)
                path = Location;
            using var sf = new FileStream(path, FileMode.Create, FileAccess.Write);
            var ser = new XmlSerializer(typeof(CP77Mod));
            ser.Serialize(sf, (CP77Mod)Data);
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

        #endregion Top-level Dirs

        #region Cooked and Packed Directories

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
                var dir = Path.Combine(ProjectDirectory, "packed", "archive", "pc", "dlc", $"mod{Name}");
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
                var dir = Path.Combine(ProjectDirectory, "packed", "archive", "pc", "mod", $"mod{Name}");
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
                    .Select(file => file[(DlcDirectory.Length + 1)..])
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
                    .Select(file => file[(ModDirectory.Length + 1)..])
                    .ToList();
            }
        }

        #endregion Files

        #endregion properties

        #region methods

        // TODO: debug
        public override void Check() => _logger.Error($"{initializeTask.Status.ToString()}");

        public void CreateDefaultDirectories()
        {
            // create top-level directories
            _ = ModDirectory;
            _ = DlcDirectory;
        }

        /// <summary>
        /// Returns the first relative folder path in the ActiveMod/dlc directory
        /// Does not support multiple DLC
        /// </summary>
        /// <returns></returns>
        public string GetDlcName() => $"dlc{Name}";

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

        private Task InitializeAsync()
        {
            ILog _logger = LogManager.GetCurrentClassLogger();
            // Hash all filepaths
            _logger.Info("Starting additional tasks...");
            var relativepaths = ModFiles
                .Select(_ => _[(_.IndexOf(Path.DirectorySeparatorChar) + 1)..])
                .ToList();
            Cr2wResourceManager.Get().RegisterAndWriteCustomPaths(relativepaths);

            // register all custom classes
            CR2WManager.Init(FileDirectory, MainController.Get().Logger);
            _logger.Info("Finished additional tasks...");

            NotificationHelper.Growl.Success($"Project {Name} has finished loading.");

            return Task.CompletedTask;
        }

        #endregion methods

        #region Methods

        public object Clone()
        {
            var clone = new Cp77Project()
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
