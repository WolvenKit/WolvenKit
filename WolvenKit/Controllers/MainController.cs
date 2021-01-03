using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Catel.IoC;
using Microsoft.CodeAnalysis.CSharp;
using WolvenKit.Controllers;
using WolvenKit.Services;

namespace WolvenKit
{
    using Bundles;
    using Cache;
    using Common;
    using Common.Services;
    using CR2W;
    using ProtoBuf;
    using System.Diagnostics;
    using System.IO.Compression;
    using System.Reflection;
    using W3Strings;
    using WolvenKit.Common.Model;
    using WolvenKit.Common.Wcc;
    using WolvenKit.CR2W.Types;
    using WolvenKit.W3Speech;

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
        private static MainController mainController;

        private MainController()
        {
        }

        public static MainController Get()
        {
            if (mainController == null)
            {
                mainController = new MainController
                {
                    Configuration = Configuration.Load(),
                    Logger = new LoggerService()
                };
            }

            return mainController;
        }

        #region Fields


        public string InitialModProject { get; set; } = "";
        public string InitialWKP { get; set; } = "";
        public string InitialFilePath { get; set; } = "";
        #endregion

        #region Properties
        public Configuration Configuration { get; private set; }
        public W3Mod ActiveMod { get; set; }
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
        public W3StringManager W3StringManager { get; private set; }


        private BundleManager BundleManager { get; set; }
        private BundleManager ModBundleManager { get; set; }

        public SoundManager SoundManager { get; private set; }
        private SoundManager ModSoundManager { get; set; }

        public TextureManager TextureManager { get; private set; }
        private TextureManager ModTextureManager { get; set; }

        private CollisionManager CollisionManager { get; set; }
        private CollisionManager ModCollisionManager { get; set; }

        private SpeechManager SpeechManager { get; set; }

        public List<IWitcherArchiveManager> GetManagers(bool loadmods)
        {
            var managers = new List<IWitcherArchiveManager>();
            var exeDir = Path.GetDirectoryName(Configuration.ExecutablePath);

            if (loadmods)
            {
                ModBundleManager = new BundleManager();
                ModBundleManager.LoadModsBundles(Configuration.GameModDir, Configuration.GameDlcDir);
                managers.Add(MainController.Get().ModBundleManager);

                ModTextureManager = new TextureManager();
                ModTextureManager.LoadModsBundles(Configuration.GameModDir, Configuration.GameDlcDir);
                managers.Add(MainController.Get().ModTextureManager);

                ModSoundManager = new SoundManager();
                ModSoundManager.LoadModsBundles(Configuration.GameModDir, Configuration.GameDlcDir);
                managers.Add(MainController.Get().ModSoundManager);

                ModCollisionManager = new CollisionManager();
                ModCollisionManager.LoadModsBundles(Configuration.GameModDir, Configuration.GameDlcDir);
                managers.Add(MainController.Get().ModCollisionManager);
            }
            else
            {
                if (MainController.Get().BundleManager != null) 
                    managers.Add(MainController.Get().BundleManager);
                if (MainController.Get().SoundManager != null) 
                    managers.Add(MainController.Get().SoundManager);
                if (MainController.Get().TextureManager != null) 
                    managers.Add(MainController.Get().TextureManager);
                if (MainController.Get().CollisionManager != null) 
                    managers.Add(MainController.Get().CollisionManager);
                if (MainController.Get().SpeechManager != null) 
                    managers.Add(MainController.Get().SpeechManager);
            }

            return managers;
        }

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

        public static string ManagerCacheDir => Tw3Controller.ManagerCacheDir;
        public static string WorkDir => Tw3Controller.WorkDir;
        public static string XBMDumpPath => Tw3Controller.XBMDumpPath;
        public static string GetManagerPath(EManagerType type) => Tw3Controller.GetManagerPath(type);
        public static string GetManagerVersion(EManagerType type) => Tw3Controller.GetManagerVersion(type);

        /// <summary>
        /// Initializes the archive managers in an async thread
        /// </summary>
        /// <returns></returns>
        public async Task Initialize()
        {
            try
            {
                // add a mechanism to update individual cache managers 
                for (var j = 0; j < Configuration.ManagerVersions.Length; j++)
                {
                    var savedversions = Configuration.ManagerVersions[j];
                    var e = (EManagerType)j;
                    var curversion = Tw3Controller.GetManagerVersion(e);

                    if (savedversions != curversion)
                    {
                        if (File.Exists(Tw3Controller.GetManagerPath(e)))
                            File.Delete(Tw3Controller.GetManagerPath(e));
                    }
                }

                //multithread these
#if NET48
                BundleManager = BundleManager ?? await Task.Run(() => Tw3Controller.LoadBundleManager());
                W3StringManager = W3StringManager ?? await Task.Run(() => Tw3Controller.LoadStringsManager());
                TextureManager = TextureManager ?? await Task.Run(() => Tw3Controller.LoadTextureManager());
                CollisionManager = CollisionManager ?? await Task.Run(() => Tw3Controller.LoadCollisionManager());
                SoundManager = SoundManager ?? await Task.Run(() => Tw3Controller.LoadSoundManager());
                SpeechManager = SpeechManager ?? await Task.Run(() => Tw3Controller.LoadSpeechManager());
#elif NETCOREAPP
                BundleManager ??= await Task.Run(() => Tw3Controller.LoadBundleManager());
                W3StringManager ??= await Task.Run(() => Tw3Controller.LoadStringsManager());
                TextureManager ??= await Task.Run(() => Tw3Controller.LoadTextureManager());
                CollisionManager ??= await Task.Run(() => Tw3Controller.LoadCollisionManager());
                SoundManager ??= await Task.Run(() => Tw3Controller.LoadSoundManager());
                SpeechManager ??= await Task.Run(() => Tw3Controller.LoadSpeechManager());
#endif


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
                // create pathhashes if they don't already exist
                var fi = new FileInfo(Cr2wResourceManager.pathashespath);
                if (!fi.Exists)
                {
                    foreach (string item in BundleManager.FileList.Select(_ => _.Name).Distinct())
                    {
                        Cr2wResourceManager.Get().RegisterVanillaPath(item);
                    }
                    Cr2wResourceManager.Get().WriteVanilla();
                }

                #endregion                

                loadStatus = "Loaded";

                
                WccHelper = new WccLite(MainController.Get().Configuration.WccLite, Logger);

                mainController.Loaded = true;
            }
            catch (Exception ex)
            {
                mainController.Loaded = false;
                System.Console.WriteLine(ex.Message);
            }
        }

        

        /// <summary>
        /// Useful function for blindly importing a file.
        /// </summary>
        /// <param name="name">The name of the file.</param>
        /// <param name="archive">The manager to search for the file in.</param>
        /// <returns></returns>
        public static List<byte[]> ImportFile(string name,IWitcherArchiveManager archive)
        {
            List<byte[]> ret = new List<byte[]>();
            archive.FileList.ToList().Where(x => x.Name.Contains(name)).ToList().ForEach(x =>
            {
                using (var ms = new MemoryStream())
                {
                    x.Extract(ms);
                    ret.Add(ms.ToArray());
                }
            });
            return ret;
        }

        public string GetLocalizedString(uint val)
        {
            return W3StringManager.GetString(val);
        }

        public void UpdateWccHelper(string wccLite)
        {
            if(WccHelper == null)
            {
                mainController.WccHelper = new WccLite(wccLite, mainController.Logger);
            }
            WccHelper.UpdatePath(wccLite);
        }

        public void ReloadStringManager()
        {
            W3StringManager.Load(Configuration.TextLanguage, Path.GetDirectoryName(Configuration.ExecutablePath), true);
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
