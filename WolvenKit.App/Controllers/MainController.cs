using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace WolvenKit.App
{
    using Bundles;
    using Cache;
    using Common;
    using Common.Services;
    using CR2W;
    using System.IO.Compression;
    using System.Security.Cryptography;
    using W3Strings;
    using WolvenKit.Common.Model;
    using WolvenKit.Common.Wcc;
    using WolvenKit.W3Speech;

    public class MainController : ObservableObject, ILocalizedStringSource
    {
        private static MainController mainController;

        private MainController() { }

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
        public const string ManagerCacheDir = "ManagerCache";
        public const string WorkDir = "tmp_workdir";
        public const string DepotZipPath = "ManagerCache\\Depot.zip";
        public const string XBMDumpPath = "ManagerCache\\__xbmdump_3768555366.csv";
        public string InitialModProject = "";
        public string InitialWKP = "";
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

        private string _projectstatus = "Idle";
        public string ProjectStatus
        {
            get => _projectstatus;
            set => SetField(ref _projectstatus, value, nameof(ProjectStatus));
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
        private SoundManager soundManager;
        private SoundManager modsoundmanager;
        private BundleManager bundleManager;
        private BundleManager modbundleManager;
        private TextureManager textureManager;
        private CollisionManager collisionManager;
        private TextureManager modTextureManager;
        private W3StringManager w3StringManager;
        private SpeechManager speechManager;

        //Public getters
        public W3StringManager W3StringManager => w3StringManager;

      

        public BundleManager BundleManager => bundleManager;
        public BundleManager ModBundleManager => modbundleManager;
        public SoundManager SoundManager => soundManager;
        public SoundManager ModSoundManager => modsoundmanager;
        public TextureManager TextureManager => textureManager;
        public TextureManager ModTextureManager => modTextureManager;
        public CollisionManager CollisionManager => collisionManager;
        public SpeechManager SpeechManager => speechManager;

        //public Dictionary<string, MemoryMappedFile> mmfs = new Dictionary<string, MemoryMappedFile>();

        public List<IWitcherArchive> GetManagers(bool loadmods)
        {
            var managers = new List<IWitcherArchive>();
            var exeDir = Path.GetDirectoryName(Configuration.ExecutablePath);

            if (loadmods)
            {
                if (MainController.Get().ModBundleManager != null)
                {
                    MainController.Get().ModBundleManager.LoadModsBundles(exeDir); // load mods added after WK was started
                    managers.Add(MainController.Get().ModBundleManager);
                }
                if (MainController.Get().ModSoundManager != null)
                {
                    MainController.Get().ModSoundManager.LoadModsBundles(exeDir);
                    managers.Add(MainController.Get().ModSoundManager);
                }
                if (MainController.Get().ModTextureManager != null)
                {
                    MainController.Get().ModTextureManager.LoadModsBundles(exeDir);
                    managers.Add(MainController.Get().ModTextureManager);
                }
            }
            else
            {
                if (MainController.Get().BundleManager != null) managers.Add(MainController.Get().BundleManager);
                if (MainController.Get().SoundManager != null) managers.Add(MainController.Get().SoundManager);
                if (MainController.Get().TextureManager != null) managers.Add(MainController.Get().TextureManager);
                if (MainController.Get().CollisionManager != null) managers.Add(MainController.Get().CollisionManager);
                if (MainController.Get().SpeechManager != null) managers.Add(MainController.Get().SpeechManager);
            }

            return managers;
        }

        #endregion

        #region Logging
        public LoggerService Logger { get; set; }

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
        public static void LogString(string value, Logtype logtype)
        {
            if (Get().Logger != null)
                Get().Logger.LogString(value, logtype);
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
        /// <summary>
        /// Initializes the archive managers in an async thread
        /// </summary>
        /// <returns></returns>
        public async Task Initialize()
        {
            try
            {
                loadStatus = "Loading string manager";
                #region Load string manager
                var sw = new System.Diagnostics.Stopwatch();
                sw.Start();
                if (w3StringManager == null)
                {
                    try
                    {
                        if (File.Exists(Path.Combine(ManagerCacheDir, "string_cache.bin")) && new FileInfo(Path.Combine(ManagerCacheDir, "string_cache.bin")).Length > 0)
                        {
                            using (var file = File.Open(Path.Combine(ManagerCacheDir, "string_cache.bin"), FileMode.Open))
                            {
                                w3StringManager = ProtoBuf.Serializer.Deserialize<W3StringManager>(file);
                            }
                        }
                        else
                        {
                            w3StringManager = new W3StringManager();
                            w3StringManager.Load(Configuration.TextLanguage, Path.GetDirectoryName(Configuration.ExecutablePath));
                            Directory.CreateDirectory(ManagerCacheDir);
                            using (var file = File.Open(Path.Combine(ManagerCacheDir, "string_cache.bin"), FileMode.Create))
                            {
                                ProtoBuf.Serializer.Serialize(file, w3StringManager);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        if (File.Exists(Path.Combine(ManagerCacheDir, "string_cache.bin")))
                            File.Delete(Path.Combine(ManagerCacheDir, "string_cache.bin"));
                        w3StringManager = new W3StringManager();
                        w3StringManager.Load(Configuration.TextLanguage, Path.GetDirectoryName(Configuration.ExecutablePath));
                    }
                }

                var i = sw.ElapsedMilliseconds;
                sw.Stop();
                #endregion

                loadStatus = "Loading bundle manager!";
                #region Load bundle manager
                if (bundleManager == null)
                {
                    try
                    {
                        if (File.Exists(Path.Combine(ManagerCacheDir, "bundle_cache.json")))
                        {
                            using (StreamReader file = File.OpenText(Path.Combine(ManagerCacheDir, "bundle_cache.json")))
                            {
                                JsonSerializer serializer = new JsonSerializer();
                                serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                                serializer.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
                                serializer.TypeNameHandling = TypeNameHandling.Auto;
                                bundleManager = (BundleManager)serializer.Deserialize(file, typeof(BundleManager));
                            }
                        }
                        else
                        {
                            bundleManager = new BundleManager();
                            bundleManager.LoadAll(Path.GetDirectoryName(Configuration.ExecutablePath));
                            File.WriteAllText(Path.Combine(ManagerCacheDir, "bundle_cache.json"), JsonConvert.SerializeObject(bundleManager, Formatting.None, new JsonSerializerSettings()
                            {
                                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                                TypeNameHandling = TypeNameHandling.Auto
                            }));
                        }
                    }
                    catch (System.Exception)
                    {
                        if (File.Exists(Path.Combine(ManagerCacheDir, "bundle_cache.json")))
                            File.Delete(Path.Combine(ManagerCacheDir, "bundle_cache.json"));
                        bundleManager = new BundleManager();
                        bundleManager.LoadAll(Path.GetDirectoryName(Configuration.ExecutablePath));
                    }
                }
                #endregion
                loadStatus = "Loading mod bundle manager!";
                #region Load mod bundle manager
                if (modbundleManager == null)
                {
                    modbundleManager = new BundleManager();
                    modbundleManager.LoadModsBundles(Path.GetDirectoryName(Configuration.ExecutablePath));
                }
                #endregion

                loadStatus = "Loading texture manager!";
                #region Load texture manager
                if (textureManager == null)
                {
                    try
                    {
                        if (File.Exists(Path.Combine(ManagerCacheDir, "texture_cache.json")))
                        {
                            using (StreamReader file = File.OpenText(Path.Combine(ManagerCacheDir, "texture_cache.json")))
                            {
                                JsonSerializer serializer = new JsonSerializer();
                                serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                                serializer.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
                                serializer.TypeNameHandling = TypeNameHandling.Auto;
                                textureManager = (TextureManager)serializer.Deserialize(file, typeof(TextureManager));
                            }
                        }
                        else
                        {
                            textureManager = new TextureManager();
                            textureManager.LoadAll(Path.GetDirectoryName(Configuration.ExecutablePath));
                            File.WriteAllText(Path.Combine(ManagerCacheDir, "texture_cache.json"), JsonConvert.SerializeObject(textureManager, Formatting.None, new JsonSerializerSettings()
                            {
                                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                                TypeNameHandling = TypeNameHandling.Auto
                            }));
                        }
                    }
                    catch (System.Exception)
                    {
                        if (File.Exists(Path.Combine(ManagerCacheDir, "texture_cache.json")))
                            File.Delete(Path.Combine(ManagerCacheDir, "texture_cache.json"));
                        textureManager = new TextureManager();
                        textureManager.LoadAll(Path.GetDirectoryName(Configuration.ExecutablePath));
                    }
                }
                #endregion

                loadStatus = "Loading collision manager!";
                #region Load collision manager
                if (collisionManager == null)
                {
                    try
                    {
                        if (File.Exists(Path.Combine(ManagerCacheDir, "collision_cache.json")))
                        {
                            using (StreamReader file = File.OpenText(Path.Combine(ManagerCacheDir, "collision_cache.json")))
                            {
                                JsonSerializer serializer = new JsonSerializer();
                                serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                                serializer.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
                                serializer.TypeNameHandling = TypeNameHandling.Auto;
                                collisionManager = (CollisionManager)serializer.Deserialize(file, typeof(CollisionManager));
                            }
                        }
                        else
                        {
                            collisionManager = new CollisionManager();
                            collisionManager.LoadAll(Path.GetDirectoryName(Configuration.ExecutablePath));
                            File.WriteAllText(Path.Combine(ManagerCacheDir, "collision_cache.json"), JsonConvert.SerializeObject(collisionManager, Formatting.None, new JsonSerializerSettings()
                            {
                                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                                TypeNameHandling = TypeNameHandling.Auto
                            }));
                        }
                    }
                    catch (System.Exception)
                    {
                        if (File.Exists(Path.Combine(ManagerCacheDir, "collision_cache.json")))
                            File.Delete(Path.Combine(ManagerCacheDir, "collision_cache.json"));
                        collisionManager = new CollisionManager();
                        collisionManager.LoadAll(Path.GetDirectoryName(Configuration.ExecutablePath));
                    }
                }
                #endregion

                loadStatus = "Loading speech manager!";
                #region Load speech manager
                if (speechManager == null)
                {
                    speechManager = new SpeechManager();
                    speechManager.LoadAll(Path.GetDirectoryName(Configuration.ExecutablePath));
                }
                #endregion

                loadStatus = "Loading mod texure manager!";
                #region Load mod texture manager
                if (modTextureManager == null)
                {
                    modTextureManager = new TextureManager();
                    modTextureManager.LoadModsBundles(Path.GetDirectoryName(Configuration.ExecutablePath));
                }
                #endregion

                loadStatus = "Loading sound manager!";
                #region Load sound manager
                if (soundManager == null)
                {
                    try
                    {
                        if (File.Exists(Path.Combine(ManagerCacheDir, "sound_cache.json")))
                        {
                            using (StreamReader file = File.OpenText(Path.Combine(ManagerCacheDir, "sound_cache.json")))
                            {
                                JsonSerializer serializer = new JsonSerializer();
                                serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                                serializer.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
                                serializer.TypeNameHandling = TypeNameHandling.Auto;
                                soundManager = (SoundManager)serializer.Deserialize(file, typeof(SoundManager));
                            }
                        }
                        else
                        {
                            soundManager = new SoundManager();
                            soundManager.LoadAll(Path.GetDirectoryName(Configuration.ExecutablePath));
                            File.WriteAllText(Path.Combine(ManagerCacheDir, "sound_cache.json"), JsonConvert.SerializeObject(soundManager, Formatting.None, new JsonSerializerSettings()
                            {
                                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                                TypeNameHandling = TypeNameHandling.Auto
                            }));
                        }
                    }
                    catch (System.Exception)
                    {
                        if (File.Exists(Path.Combine(ManagerCacheDir, "sound_cache.json")))
                            File.Delete(Path.Combine(ManagerCacheDir, "sound_cache.json"));
                        soundManager = new SoundManager();
                        soundManager.LoadAll(Path.GetDirectoryName(Configuration.ExecutablePath));
                    }
                }
                #endregion

                loadStatus = "Loading mod sound manager!";
                #region Load mod sound manager
                if (modsoundmanager == null)
                {
                    modsoundmanager = new SoundManager();
                    modsoundmanager.LoadModsBundles(Path.GetDirectoryName(Configuration.ExecutablePath));
                }
                #endregion

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

                var fi = new FileInfo(DepotZipPath);
                if (!fi.Exists)
                    throw new Exception("Shipped Depot not found: Depot.zip");

                // check if any new files are in the shipped zip that aren't in the r4depot
                // and extract if yes
                List<ZipArchiveEntry> entries = ZipFile.OpenRead(DepotZipPath).Entries.ToList();
                foreach (ZipArchiveEntry entry in entries)
                {
                    var filepath = Path.Combine(Configuration.DepotPath, entry.FullName);
                    // if directory
                    if (string.IsNullOrEmpty(entry.Name))
                    {
                        if (!Directory.Exists(filepath))
                            Directory.CreateDirectory(filepath);
                    }
                    else
                    {
                        if (!File.Exists(filepath))
                            entry.ExtractToFile(filepath);
                    }
                }
                #endregion

                loadStatus = "Loading path hashes!";
                #region PathHasManager
                // create pathhashes if they don't already exist
                fi = new FileInfo(Cr2wResourceManager.pathashespath);
                if (!fi.Exists)
                {
                    foreach (IWitcherFile item in BundleManager.FileList)
                    {
                        Cr2wResourceManager.Get().RegisterVanillaPath(item.Name);
                    }
                    Cr2wResourceManager.Get().WriteVanilla();
                }

                #endregion



                loadStatus = "Loaded";

                
                WccHelper = new WccLite(MainController.Get().Configuration.WccLite, Logger);

                mainController.Loaded = true;
            }
            catch (Exception e)
            {
                mainController.Loaded = false;
                System.Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// Useful function for blindly importing a file.
        /// </summary>
        /// <param name="name">The name of the file.</param>
        /// <param name="archive">The manager to search for the file in.</param>
        /// <returns></returns>
        public static List<byte[]> ImportFile(string name,IWitcherArchive archive)
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
