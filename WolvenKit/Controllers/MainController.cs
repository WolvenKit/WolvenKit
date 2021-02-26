using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Catel.IoC;
using Orc.ProjectManagement;
using WolvenKit.Model;

namespace WolvenKit
{
    using Controllers;
    using Services;

    using Bundles;
    using Cache;
    using Common;
    using Common.Services;
    using CR2W;
    using W3Strings;
    using Common.Model;
    using Common.Wcc;
    using CR2W.Types;
    using W3Speech;

    public enum EProjectStatus
    {
        Idle,
        Ready,
        Busy,
        Errored
    }

    public enum EUpdateChannel
    {
        Stable,
        //Beta,
        Nightly,
    }

    /// <summary>
    /// Supervisor of all subsystem managers. Singleton.
    /// </summary>
    public class MainController : ObservableObject, ILocalizedStringSource
    {
        private static MainController s_mainController;
        private static GameControllerBase s_gameController;

        private MainController()
        {
        }

        public static MainController Get()
        {
            if (s_mainController != null)
            {
                return s_mainController;
            }

            s_mainController = new MainController
            {
                Configuration = Configuration.Load(),
                Logger = new LoggerService(),
            };
            s_gameController = new MockGameController();

            return s_mainController;
        }

        public static async Task SetGame(GameControllerBase controller)
        {
            s_gameController = controller;
            await controller.HandleStartup();
        }

        public static GameControllerBase GetGame() => s_gameController;

        #region Fields


        public string InitialModProject { get; set; } = "";
        public string InitialWKP { get; set; } = "";
        public string InitialFilePath { get; set; } = "";
        #endregion

        #region Properties
        public Configuration Configuration { get; private set; }
        public EditorProjectData ActiveMod { get; set; }
        public WccLite WccHelper { get; set; }
        public List<HashDump> Hashdumplist { get; set; }
        /// <summary>
        /// Shows if there are unsaved changes in the project.
        /// </summary>
        public bool ProjectUnsaved = false;

        private EProjectStatus _projectstatus = EProjectStatus.Idle;
        public EProjectStatus ProjectStatus
        {
            get => _projectstatus;
            set => SetField(ref _projectstatus, value, nameof(ProjectStatus));
        }

        private int _statusProgress = 0;
        public int StatusProgress
        {
            get => _statusProgress;
            set => SetField(ref _statusProgress, value, nameof(StatusProgress));
        }

        private string _loadstatus = "Loading...";
        public string loadStatus
        {
            get => _loadstatus;
            set => SetField(ref _loadstatus, value, nameof(loadStatus));
        }

        private bool _loaded = false;
        public bool Loaded
        {
            get => _loaded;
            set => SetField(ref _loaded, value, nameof(Loaded));
        }
        #endregion

        #region Archive Managers

        //TODO: Implement mod loading, it's not a priority atm so I left it out but we should support it.
        public List<IGameArchiveManager> GetManagers(bool loadmods) => s_gameController.GetArchiveManagersManagers();

        #endregion

        #region Logging
        public LoggerService Logger { get; private set; }

        private KeyValuePair<string, Logtype> _logMessage = new KeyValuePair<string, Logtype>("", Logtype.Normal);
        public KeyValuePair<string, Logtype> LogMessage
        {
            get => _logMessage;
            set => SetField(ref _logMessage, value, nameof(LogMessage));
        }
        /// <summary>
        /// Queues a string for logging in the main window.
        /// </summary>
        /// <param name="msg">The message to log.</param>
        /// <param name="type">The type of the log. Not needed.</param>
        public void QueueLog(string msg, Logtype type = Logtype.Normal)
        {
            LogMessage = new KeyValuePair<string, Logtype>(msg, type);
        }

        /// <summary>
        /// Use this for threadsafe logging.
        /// </summary>
        /// <param name="value"></param>
        public static void LogString(string value, Logtype logtype = Logtype.Normal)
        {
            if (Get().Logger != null)
                Get().Logger.LogString(value, logtype);
        }

        /// <summary>
        /// Use this for delegate logging. ???
        /// </summary>
        /// <param name="value"></param>
        public static void LogString(object sender, string value)
        {
            if (Get().Logger != null)
                Get().Logger.LogString(value, Logtype.Normal);
        }

        /// <summary>
        /// Use this for threadsafe progress updates.
        /// </summary>
        /// <param name="value"></param>
        public static void LogProgress(int value)
        {
            if (Get().Logger != null)
                Get().Logger.LogProgress(value);
        }
        #endregion

        #region Methods

        public static string ManagerCacheDir => GameControllerBase.ManagerCacheDir;
        public static string WorkDir => GameControllerBase.WorkDir;
        public static string XBMDumpPath => GameControllerBase.XBMDumpPath;
        public static string GetManagerPath(EManagerType type) => GameControllerBase.GetManagerPath(type);
        public static string GetManagerVersion(EManagerType type) => GameControllerBase.GetManagerVersion(type);

        /// <summary>
        /// Initializes the archive managers in an async thread
        /// </summary>
        /// <returns></returns>
        public Task Initialize()
        {
            try
            {
                // add a mechanism to update individual cache managers 
                for (var j = 0; j < Configuration.ManagerVersions.Length; j++)
                {
                    var savedversions = Configuration.ManagerVersions[j];
                    var e = (EManagerType)j;
                    var curversion = GameControllerBase.GetManagerVersion(e);

                    if (savedversions != curversion && File.Exists(GameControllerBase.GetManagerPath(e)))
                    {
                        File.Delete(GameControllerBase.GetManagerPath(e));
                    }
                }

                //multithread these
                s_gameController.HandleStartup();



                loadStatus = "Loading depot manager!";
                #region Load depot manager
                // check if r4depot exists
                if (!Directory.Exists(Configuration.DepotPath))
                {
                    DirectoryInfo wccDir = new FileInfo(Configuration.WccLite).Directory.Parent.Parent;
                    if (!wccDir.Exists)
                        throw new Exception("Wcc_lite is not specified.");

                    string wcc_r4data = Path.Combine(wccDir.FullName, "r4data");
                    if (!Directory.Exists(wcc_r4data))
                        Directory.CreateDirectory(wcc_r4data);  //create an empty depot
                    Configuration.DepotPath = wcc_r4data;
                    Configuration.Save();
                }

                // undbundle some engine files?

                
                #endregion

                loadStatus = "Loading path hashes!";
                #region PathHasManager
                //TODO: Figure out something for this! Probably should be inside the bundle manager
                // create pathhashes if they don't already exist
                /*var fi = new FileInfo(Cr2wResourceManager.pathashespath);
                if (!fi.Exists)
                {
                    foreach (string item in BundleManager.FileList.Select(_ => _.Name).Distinct())
                    {
                        Cr2wResourceManager.Get().RegisterVanillaPath(item);
                    }
                    Cr2wResourceManager.Get().WriteVanilla();
                }*/

                #endregion                

                loadStatus = "Loaded";

                
                WccHelper = new WccLite(MainController.Get().Configuration.WccLite, Logger);

                s_mainController.Loaded = true;
            }
            catch (Exception ex)
            {
                s_mainController.Loaded = false;
                Console.WriteLine(ex.Message);
            }
            
            return Task.CompletedTask;
        }

        

        /// <summary>
        /// Useful function for blindly importing a file.
        /// </summary>
        /// <param name="name">The name of the file.</param>
        /// <param name="archive">The manager to search for the file in.</param>
        /// <returns></returns>
        public static List<byte[]> ImportFile(string name,IGameArchiveManager archive)
        {
            var ret = new List<byte[]>();
            archive.FileList.ToList().Where(x => x.Name.Contains(name)).ToList().ForEach(x =>
            {
                using var ms = new MemoryStream();
                x.Extract(ms);
                ret.Add(ms.ToArray());
            });
            return ret;
        }

        public string GetLocalizedString(uint val)
        {
            //TODO: Idk what to do with this
            //return W3StringManager.GetString(val);
            return "";
        }

        public void UpdateWccHelper(string wccLite)
        {
            if(WccHelper == null)
            {
                s_mainController.WccHelper = new WccLite(wccLite, s_mainController.Logger);
            }
            WccHelper.UpdatePath(wccLite);
        }

        public void ReloadStringManager()
        {
            //TODO: Idk what to do with this
            //W3StringManager.Load(Configuration.TextLanguage, Path.GetDirectoryName(Configuration.ExecutablePath), true);
        }

        protected bool SetField<T>(ref T field, T value, string propertyName)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        #endregion

    }
}
