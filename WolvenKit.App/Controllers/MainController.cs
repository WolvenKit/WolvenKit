using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WolvenKit.App
{
    using Bundles;
    using Cache;
    using Common;
    using Common.Services;
    using CR2W;
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

        private static string ManagerCacheDir => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "ManagerCache");

        public static string WorkDir => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "tmp_workdir");

        //private static string DepotZipPath => Path.Combine(ManagerCacheDir, "Depot.zip");
        public static string XBMDumpPath => Path.Combine(ManagerCacheDir, "__xbmdump_3768555366.csv");

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
        private static string GetManagerPath(EManagerType type)
        {
            switch (type)
            {
                case EManagerType.BundleManager: return Path.Combine(ManagerCacheDir, "bundle_cache.json");
                case EManagerType.CollisionManager: return Path.Combine(ManagerCacheDir, "collision_cache.json");
                case EManagerType.SoundManager: return Path.Combine(ManagerCacheDir, "sound_cache.json");
                case EManagerType.W3StringManager: return Path.Combine(ManagerCacheDir, "string_cache.bin");
                case EManagerType.TextureManager: return Path.Combine(ManagerCacheDir, "texture_cache.json");
                case EManagerType.Max:
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
        private static string GetManagerVersion(EManagerType type)
        {
            switch (type)
            {
                case EManagerType.BundleManager: return BundleManager.SerializationVersion;
                case EManagerType.CollisionManager: return WolvenKit.Cache.CollisionManager.SerializationVersion;
                case EManagerType.SoundManager: return WolvenKit.Cache.SoundManager.SerializationVersion;
                case EManagerType.W3StringManager: return W3Strings.W3StringManager.SerializationVersion;
                case EManagerType.TextureManager: return WolvenKit.Cache.TextureManager.SerializationVersion;
                case EManagerType.Max:
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }


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
                    var curversion = GetManagerVersion(e);

                    if (savedversions != curversion)
                    {
                        if (File.Exists(GetManagerPath(e)))
                            File.Delete(GetManagerPath(e));
                    }
                }

                //multithread these
                var loadStringsManagerTask = LoadStringsManager();
                var loadBundleManagerTask = LoadBundleManager();
                var loadTextureManagerTask = LoadTextureManager();
                var loadCollisionManagerTask = LoadCollisionManager();
                var loadSoundManagerTask = LoadSoundManager();
                var loadSpeechManagerTask = LoadSpeechManager();
                var tasks = new List<Task>
                {
                    loadStringsManagerTask,
                    loadBundleManagerTask,
                    loadTextureManagerTask,
                    loadCollisionManagerTask,
                    loadSoundManagerTask,
                    loadSpeechManagerTask,
                };
                await Task.WhenAny(tasks);


                //await Task.Run(() => LoadStringsManager());
                //await Task.Run(() => LoadBundleManager());
                //await Task.Run(() => LoadTextureManager());
                //await Task.Run(() => LoadCollisionManager());
                //await Task.Run(() => LoadSoundManager());
                //await Task.Run(() => LoadSpeechManager());


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

        private async Task LoadStringsManager()
        {
            loadStatus = "Loading string manager";
            #region Load string manager
            var sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            if (W3StringManager == null)
            {
                try
                {
                    if (File.Exists(GetManagerPath(EManagerType.W3StringManager)) && new FileInfo(GetManagerPath(EManagerType.W3StringManager)).Length > 0)
                    {
                        using (var file = File.Open(GetManagerPath(EManagerType.W3StringManager), FileMode.Open))
                        {
                            W3StringManager = ProtoBuf.Serializer.Deserialize<W3StringManager>(file);
                        }
                    }
                    else
                    {
                        W3StringManager = new W3StringManager();
                        W3StringManager.Load(Configuration.TextLanguage, Path.GetDirectoryName(Configuration.ExecutablePath));
                        Directory.CreateDirectory(ManagerCacheDir);
                        using (var file = File.Open(GetManagerPath(EManagerType.W3StringManager), FileMode.Create))
                        {
                            ProtoBuf.Serializer.Serialize(file, W3StringManager);
                        }

                        Configuration.ManagerVersions[(int)EManagerType.W3StringManager] = W3StringManager.SerializationVersion;
                    }
                }
                catch (System.Exception)
                {
                    if (File.Exists(GetManagerPath(EManagerType.W3StringManager)))
                        File.Delete(GetManagerPath(EManagerType.W3StringManager));
                    W3StringManager = new W3StringManager();
                    W3StringManager.Load(Configuration.TextLanguage, Path.GetDirectoryName(Configuration.ExecutablePath));
                }
            }

            var i = sw.ElapsedMilliseconds;
            sw.Stop();
            #endregion
        }

        private async Task LoadBundleManager()
        {
            loadStatus = "Loading bundle manager!";
            #region Load bundle manager
            if (BundleManager == null)
            {
                try
                {
                    if (File.Exists(GetManagerPath(EManagerType.BundleManager)))
                    {
                        using (StreamReader file = File.OpenText(GetManagerPath(EManagerType.BundleManager)))
                        {
                            JsonSerializer serializer = new JsonSerializer();
                            serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                            serializer.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
                            serializer.TypeNameHandling = TypeNameHandling.Auto;
                            BundleManager = (BundleManager)serializer.Deserialize(file, typeof(BundleManager));
                        }
                    }
                    else
                    {
                        BundleManager = new BundleManager();
                        BundleManager.LoadAll(Path.GetDirectoryName(Configuration.ExecutablePath));
                        File.WriteAllText(GetManagerPath(EManagerType.BundleManager), JsonConvert.SerializeObject(BundleManager, Formatting.None, new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                            PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                            TypeNameHandling = TypeNameHandling.Auto
                        }));
                        Configuration.ManagerVersions[(int)EManagerType.BundleManager] = BundleManager.SerializationVersion;
                    }
                }
                catch (System.Exception ex)
                {
                    if (File.Exists(GetManagerPath(EManagerType.BundleManager)))
                        File.Delete(GetManagerPath(EManagerType.BundleManager));
                    BundleManager = new BundleManager();
                    BundleManager.LoadAll(Path.GetDirectoryName(Configuration.ExecutablePath));
                }
            }
            #endregion
        }

        private async Task LoadTextureManager()
        {
            loadStatus = "Loading texture manager!";
            #region Load texture manager
            if (TextureManager == null)
            {
                try
                {
                    if (File.Exists(GetManagerPath(EManagerType.TextureManager)))
                    {
                        using (StreamReader file = File.OpenText(GetManagerPath(EManagerType.TextureManager)))
                        {
                            JsonSerializer serializer = new JsonSerializer();
                            serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                            serializer.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
                            serializer.TypeNameHandling = TypeNameHandling.Auto;
                            TextureManager = (TextureManager)serializer.Deserialize(file, typeof(TextureManager));
                        }
                    }
                    else
                    {
                        TextureManager = new TextureManager();
                        TextureManager.LoadAll(Path.GetDirectoryName(Configuration.ExecutablePath));
                        File.WriteAllText(GetManagerPath(EManagerType.TextureManager), JsonConvert.SerializeObject(TextureManager, Formatting.None, new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                            PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                            TypeNameHandling = TypeNameHandling.Auto
                        }));
                        Configuration.ManagerVersions[(int)EManagerType.TextureManager] = TextureManager.SerializationVersion;
                    }
                }
                catch (System.Exception)
                {
                    if (File.Exists(GetManagerPath(EManagerType.TextureManager)))
                        File.Delete(GetManagerPath(EManagerType.TextureManager));
                    TextureManager = new TextureManager();
                    TextureManager.LoadAll(Path.GetDirectoryName(Configuration.ExecutablePath));
                }
            }
            #endregion
        }

        private async Task LoadCollisionManager()
        {
            loadStatus = "Loading collision manager!";
            #region Load collision manager
            if (CollisionManager == null)
            {
                try
                {
                    if (File.Exists(GetManagerPath(EManagerType.CollisionManager)))
                    {
                        using (StreamReader file = File.OpenText(GetManagerPath(EManagerType.CollisionManager)))
                        {
                            JsonSerializer serializer = new JsonSerializer();
                            serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                            serializer.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
                            serializer.TypeNameHandling = TypeNameHandling.Auto;
                            CollisionManager = (CollisionManager)serializer.Deserialize(file, typeof(CollisionManager));
                        }
                    }
                    else
                    {
                        CollisionManager = new CollisionManager();
                        CollisionManager.LoadAll(Path.GetDirectoryName(Configuration.ExecutablePath));
                        File.WriteAllText(GetManagerPath(EManagerType.CollisionManager), JsonConvert.SerializeObject(CollisionManager, Formatting.None, new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                            PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                            TypeNameHandling = TypeNameHandling.Auto
                        }));
                        Configuration.ManagerVersions[(int)EManagerType.CollisionManager] = CollisionManager.SerializationVersion;
                    }
                }
                catch (System.Exception)
                {
                    if (File.Exists(GetManagerPath(EManagerType.CollisionManager)))
                        File.Delete(GetManagerPath(EManagerType.CollisionManager));
                    CollisionManager = new CollisionManager();
                    CollisionManager.LoadAll(Path.GetDirectoryName(Configuration.ExecutablePath));
                }
            }
            #endregion
        }

        private async Task LoadSoundManager()
        {
            loadStatus = "Loading sound manager!";
            #region Load sound manager
            if (SoundManager == null)
            {
                try
                {
                    if (File.Exists(GetManagerPath(EManagerType.SoundManager)))
                    {
                        using (StreamReader file = File.OpenText(GetManagerPath(EManagerType.SoundManager)))
                        {
                            JsonSerializer serializer = new JsonSerializer();
                            serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                            serializer.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
                            serializer.TypeNameHandling = TypeNameHandling.Auto;
                            SoundManager = (SoundManager)serializer.Deserialize(file, typeof(SoundManager));
                        }
                    }
                    else
                    {
                        SoundManager = new SoundManager();
                        SoundManager.LoadAll(Path.GetDirectoryName(Configuration.ExecutablePath));
                        File.WriteAllText(GetManagerPath(EManagerType.SoundManager), JsonConvert.SerializeObject(SoundManager, Formatting.None, new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                            PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                            TypeNameHandling = TypeNameHandling.Auto
                        }));
                        Configuration.ManagerVersions[(int)EManagerType.SoundManager] = SoundManager.SerializationVersion;
                    }
                }
                catch (System.Exception ex)
                {
                    if (File.Exists(GetManagerPath(EManagerType.SoundManager)))
                        File.Delete(GetManagerPath(EManagerType.SoundManager));
                    SoundManager = new SoundManager();
                    SoundManager.LoadAll(Path.GetDirectoryName(Configuration.ExecutablePath));
                }
            }
            #endregion
        }

        private async Task LoadSpeechManager()
        {
            loadStatus = "Loading speech manager!";
            #region Load speech manager
            if (SpeechManager == null)
            {
                SpeechManager = new SpeechManager();
                SpeechManager.LoadAll(Path.GetDirectoryName(Configuration.ExecutablePath));
            }
            #endregion
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
