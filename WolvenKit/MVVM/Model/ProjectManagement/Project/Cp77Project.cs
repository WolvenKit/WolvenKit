using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Catel.IoC;
using CP77.Common;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.Bundles;
using WolvenKit.Cache;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.CR2W;
using WolvenKit.W3Speech;
using WolvenKit.W3Strings;
using CP77.CR2W.Archive;
using HandyControl.Controls;
using System.Windows;
using System.Windows.Threading;
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Model
{
    public sealed class Cp77Project : EditorProject, ICloneable
    {

        #region fields
        private readonly ISettingsManager _settings;
        private readonly ILoggerService _logger;
        private Task initializeTask;


        #endregion

        public Cp77Project(string location) : base(location)
        {
            _settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
            _logger = ServiceLocator.Default.ResolveType<ILoggerService>();
            if (File.Exists(location))
                Load(location);
        }

        public Cp77Project() : base("") { }



        #region properties
        public override void Save(string path)
        {
            using (var sf = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                var ser = new XmlSerializer(typeof(CP77Mod));
                ser.Serialize(sf, (CP77Mod)this.Data);
            }
        }

        public override void Load(string path)
        {
            using (var lf = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                var ser = new XmlSerializer(typeof(CP77Mod));
                var obj = (CP77Mod)ser.Deserialize(lf);
                this.Name = obj.Name;
                this.Version = obj.Version;
                this.Author = obj.Author;
                this.Email = obj.Email;
                this.GameType = GameType.Cyberpunk2077;
                this.Data = obj;
                this.Data.FileName = path;
            }
        }

        public override bool IsInitialized => initializeTask?.Status == TaskStatus.RanToCompletion;



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

        #endregion

        #region Cooked and Packed Directories
        
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
                return Directory.EnumerateFiles(DlcDirectory, "*", SearchOption.AllDirectories)
                    .Select(file => file.Substring(DlcDirectory.Length + 1))
                    .ToList();
            }
        }
        #endregion

        #endregion

        #region methods
        // TODO: debug
        public override void Check() => _logger.LogString($"{initializeTask.Status.ToString()}", Logtype.Error);

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

            return Task.CompletedTask;
        }





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

        

        #endregion


        public override string ToString()
        {
            return Location;
        }

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
    }
}
