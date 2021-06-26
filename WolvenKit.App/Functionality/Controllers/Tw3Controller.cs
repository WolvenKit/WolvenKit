using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;
using Catel.IoC;
using DynamicData;
using Newtonsoft.Json;
using WolvenKit.Functionality.Services;
using ProtoBuf;
using WolvenKit.Bundles;
using WolvenKit.Cache;
using WolvenKit.Common;
using WolvenKit.Common.Exceptions;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;
using WolvenKit.Common.Wcc;
using WolvenKit.Functionality.WKitGlobal;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.Models;
using WolvenKit.Modkit.RED3;
using WolvenKit.MVVM.Model;
using WolvenKit.MVVM.Model.ProjectManagement.Project;
using WolvenKit.RED3.CR2W;
using WolvenKit.RED3.CR2W.Types;
using WolvenKit.ViewModels.Editor;
using WolvenKit.W3Speech;
using WolvenKit.W3Strings;
using WolvenKit.Wwise;
using WolvenKit.Wwise.Wwise;

namespace WolvenKit.Functionality.Controllers
{
    /// <summary>
    /// Service, should live in singleton scope?
    /// </summary>
    public class Tw3Controller : IGameController
    {
        #region Fields

        private BundleManager bundleManager;
        private CollisionManager collisionManager;
        private SoundManager soundManager;
        private SpeechManager speechManager;
        private TextureManager textureManager;
        private W3StringManager w3StringManager;

        private readonly IProjectManager _projectManager;
        private readonly ILoggerService _loggerService;
        private readonly ISettingsManager _settings;
        private readonly Red3ModTools _modtools;

        private const string db_dlcfiles = "db_dlcfiles";
        private const string db_dlctextures = "db_dlctextures";
        private const string db_modfiles = "db_modfiles";
        private const string db_modtextures = "db_modtextures";

        #endregion Fields

        public Tw3Controller(
            IProjectManager projectManager,
            ILoggerService loggerService,
            ISettingsManager settings,
            Red3ModTools modtools
        )
        {
            _projectManager = projectManager;
            _loggerService = loggerService;
            _settings = settings;
            _modtools = modtools;
        }

        #region Methods

        public async Task HandleStartup()
        {
            var assetBrowserViewModel = (AssetBrowserViewModel)ServiceLocator.Default.ResolveType(typeof(AssetBrowserViewModel));
            assetBrowserViewModel.LoadVisibility = Visibility.Visible;

            //await Task.Run( LoadStringsManager);
            LoadStringsManager();

            //var todo = new List<Func<IGameArchiveManager>>()
            //{
            //    LoadBundleManager,
            //    LoadTextureManager,
            //    LoadCollisionManager,
            //    LoadSoundManager,
            //    LoadSpeechManager
            //};
            //Parallel.ForEach(todo, _ => Task.Run(_));


            LoadBundleManager();
            LoadTextureManager();
            LoadCollisionManager();
            LoadSoundManager();
            LoadSpeechManager();

            assetBrowserViewModel.ReInit(false);

            await Task.CompletedTask;
        }

        void logGenericErrors()
        {
            if (!File.Exists(_settings.W3ExecutablePath))
                _loggerService.Error("Did you forget to set the The Witcher 3 exe path?");
        }

        //private async Task InitializeAsync()
        //{


        //    // Hash all filepaths
        //    Logger.Info("Starting additional tasks...");
        //    var relativepaths = ModFiles
        //        .Select(_ => _[(_.IndexOf(Path.DirectorySeparatorChar) + 1)..])
        //        .ToList();
        //    Cr2wResourceManager.Get().RegisterAndWriteCustomPaths(relativepaths);

        //    // register all custom classes
        //    CR2WManager.Init(FileDirectory);
        //    Logger.Info("Finished additional tasks...");

        //    NotificationHelper.Growl.Success($"Project {Name} has finished loading.");
        //}

        #region Managers

        private W3StringManager LoadStringsManager()
        {
            _loggerService.Info("Loading strings manager ... ");
            try
            {
                if (File.Exists(IGameController.GetManagerPath(EManagerType.W3StringManager)) && new FileInfo(IGameController.GetManagerPath(EManagerType.W3StringManager)).Length > 0)
                {
                    using var file = File.Open(IGameController.GetManagerPath(EManagerType.W3StringManager), FileMode.Open);
                    w3StringManager = Serializer.Deserialize<W3StringManager>(file);
                }
                else
                {
                    w3StringManager = new W3StringManager();
                    w3StringManager.Load(_settings.TextLanguage, Path.GetDirectoryName(_settings.W3ExecutablePath));
                    Directory.CreateDirectory(ISettingsManager.GetManagerCacheDir());
                    using (var file = File.Open(IGameController.GetManagerPath(EManagerType.W3StringManager), FileMode.Create))
                    {
                        Serializer.Serialize(file, w3StringManager);
                    }

                    _settings.ManagerVersions[(int)EManagerType.W3StringManager] = W3StringManager.SerializationVersion;
                }
            }
            catch (Exception)
            {
                if (File.Exists(IGameController.GetManagerPath(EManagerType.W3StringManager)))
                {
                    File.Delete(IGameController.GetManagerPath(EManagerType.W3StringManager));
                }

                w3StringManager = new W3StringManager();
                try
                {
                    w3StringManager.Load(_settings.TextLanguage, Path.GetDirectoryName(_settings.W3ExecutablePath));
                    _loggerService.Info("Finished loading strings manager.");
                }
                catch (Exception)
                {
                    _loggerService.Error("Fatal error happened during loading strings manager.");
                    logGenericErrors();
                }
            }
            return w3StringManager;
        }

        private BundleManager LoadBundleManager()
        {
            _loggerService.Info("Loading bundle manager... ");
            try
            {
                if (File.Exists(IGameController.GetManagerPath(EManagerType.BundleManager)))
                {
                    using var file = File.OpenText(IGameController.GetManagerPath(EManagerType.BundleManager));
                    var serializer = new JsonSerializer
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                        PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                        TypeNameHandling = TypeNameHandling.Auto
                    };
                    bundleManager = (BundleManager)serializer.Deserialize(file, typeof(BundleManager));
                }
                else
                {
                    bundleManager = new BundleManager();
                    bundleManager.LoadAll(Path.GetDirectoryName(_settings.W3ExecutablePath));
                    using (var writer = new StreamWriter(
                        new FileStream(IGameController.GetManagerPath(EManagerType.BundleManager), FileMode.Open)))
                    {
                        writer.Write(JsonConvert.SerializeObject(bundleManager, Formatting.None, new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                            PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                            TypeNameHandling = TypeNameHandling.Auto
                        }));
                    }
                    _settings.ManagerVersions[(int)EManagerType.BundleManager] = BundleManager.SerializationVersion;
                }
            }
            catch (Exception)
            {
                if (File.Exists(IGameController.GetManagerPath(EManagerType.BundleManager)))
                {
                    File.Delete(IGameController.GetManagerPath(EManagerType.BundleManager));
                }

                bundleManager = new BundleManager();
                try
                {
                    bundleManager.LoadAll(Path.GetDirectoryName(_settings.W3ExecutablePath));
                    _loggerService.Info("Finished loading bundle manager.");
                }
                catch (Exception)
                {
                    _loggerService.Error("Fatal error happened during loading bundle manager.");
                    logGenericErrors();
                }
            }
            return bundleManager;
        }

        private CollisionManager LoadCollisionManager()
        {
            _loggerService.Info("Loading collision manager... ");
            try
            {
                if (File.Exists(IGameController.GetManagerPath(EManagerType.CollisionManager)))
                {
                    using var file = File.OpenText(IGameController.GetManagerPath(EManagerType.CollisionManager));
                    var serializer = new JsonSerializer
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                        PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                        TypeNameHandling = TypeNameHandling.Auto
                    };
                    collisionManager = (CollisionManager)serializer.Deserialize(file, typeof(CollisionManager));
                }
                else
                {
                    collisionManager = new CollisionManager();
                    collisionManager.LoadAll(Path.GetDirectoryName(_settings.W3ExecutablePath));
                    File.WriteAllText(IGameController.GetManagerPath(EManagerType.CollisionManager), JsonConvert.SerializeObject(collisionManager, Formatting.None, new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                        PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                        TypeNameHandling = TypeNameHandling.Auto
                    }));
                    _settings.ManagerVersions[(int)EManagerType.CollisionManager] = CollisionManager.SerializationVersion;
                }
            }
            catch (Exception)
            {
                if (File.Exists(IGameController.GetManagerPath(EManagerType.CollisionManager)))
                {
                    File.Delete(IGameController.GetManagerPath(EManagerType.CollisionManager));
                }

                try
                {
                    collisionManager = new CollisionManager();
                    collisionManager.LoadAll(Path.GetDirectoryName(_settings.W3ExecutablePath));
                    _loggerService.Info("Finished loading collision manager.");
                }
                catch (Exception)
                {
                    _loggerService.Error("Fatal error happened during loading collision manager.");
                    logGenericErrors();
                }
            }

            return collisionManager;
        }

        private SoundManager LoadSoundManager()
        {
            _loggerService.Info("Loading sound manager... ");
            try
            {
                if (File.Exists(IGameController.GetManagerPath(EManagerType.SoundManager)))
                {
                    using var file = File.OpenText(IGameController.GetManagerPath(EManagerType.SoundManager));
                    var serializer = new JsonSerializer
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                        PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                        TypeNameHandling = TypeNameHandling.Auto
                    };
                    soundManager = (SoundManager)serializer.Deserialize(file, typeof(SoundManager));
                }
                else
                {
                    soundManager = new SoundManager();
                    soundManager.LoadAll(Path.GetDirectoryName(_settings.W3ExecutablePath));
                    File.WriteAllText(IGameController.GetManagerPath(EManagerType.SoundManager), JsonConvert.SerializeObject(soundManager, Formatting.None, new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                        PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                        TypeNameHandling = TypeNameHandling.Auto
                    }));
                    _settings.ManagerVersions[(int)EManagerType.SoundManager] = SoundManager.SerializationVersion;
                }
            }
            catch (Exception)
            {
                if (File.Exists(IGameController.GetManagerPath(EManagerType.SoundManager)))
                {
                    File.Delete(IGameController.GetManagerPath(EManagerType.SoundManager));
                }

                try
                {
                    soundManager = new SoundManager();
                    soundManager.LoadAll(Path.GetDirectoryName(_settings.W3ExecutablePath));
                    _loggerService.Info("Finished loading sound manager.");
                }
                catch (Exception)
                {
                    _loggerService.Error("Fatal error happened during loading sound manager.");
                    logGenericErrors();
                }
            }

            return soundManager;
        }

        private SpeechManager LoadSpeechManager()
        {
            _loggerService.Info("Loading speech manager ... ");
            speechManager = new SpeechManager();
            try
            {
                speechManager.LoadAll(Path.GetDirectoryName(_settings.W3ExecutablePath));
                _loggerService.Info("Finished loading speech manager.");
            }
            catch (Exception)
            {
                _loggerService.Error("Fatal error happened during loading speech manager.");
                if (!File.Exists(_settings.W3ExecutablePath))
                    _loggerService.Error("Did you forget to set the The Witcher 3 exe path?");
            }

            return speechManager;
        }

        private TextureManager LoadTextureManager()
        {

            _loggerService.Info("Loading texture manager... ");
            try
            {
                if (File.Exists(IGameController.GetManagerPath(EManagerType.TextureManager)))
                {
                    using var file = File.OpenText(IGameController.GetManagerPath(EManagerType.TextureManager));
                    var serializer = new JsonSerializer
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                        PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                        TypeNameHandling = TypeNameHandling.Auto
                    };
                    textureManager = (TextureManager)serializer.Deserialize(file, typeof(TextureManager));
                }
                else
                {
                    textureManager = new TextureManager();
                    textureManager.LoadAll(Path.GetDirectoryName(_settings.W3ExecutablePath));
                    File.WriteAllText(IGameController.GetManagerPath(EManagerType.TextureManager), JsonConvert.SerializeObject(textureManager, Formatting.None, new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                        PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                        TypeNameHandling = TypeNameHandling.Auto
                    }));
                    _settings.ManagerVersions[(int)EManagerType.TextureManager] = TextureManager.SerializationVersion;
                }
            }
            catch (Exception)
            {
                if (File.Exists(IGameController.GetManagerPath(EManagerType.TextureManager)))
                {
                    File.Delete(IGameController.GetManagerPath(EManagerType.TextureManager));
                }

                try
                {
                    textureManager = new TextureManager();
                    textureManager.LoadAll(Path.GetDirectoryName(_settings.W3ExecutablePath));
                    _loggerService.Info("Finished loading texture manager.");
                }
                catch (Exception)
                {
                    _loggerService.Error("Fatal error during loading texture manager.");
                    logGenericErrors();
                }
            }

            return textureManager;
        }

        public IObservable<IChangeSet<GameFileTreeNode, string>> ConnectHierarchy() => throw new NotImplementedException();

        public List<IGameArchiveManager> GetArchiveManagers(bool loadmods) => new()
        {
            bundleManager,
            textureManager,
            collisionManager,
            soundManager,
            speechManager
        };

        #endregion


        public Task<bool> PackageMod()
        {
            var pwm = ServiceLocator.Default.ResolveType<Models.Wizards.PublishWizardModel>();
            var headerBackground = System.Drawing.Color.FromArgb(
                pwm.HeaderBackground.A,
                pwm.HeaderBackground.R,
                pwm.HeaderBackground.G,
                pwm.HeaderBackground.B
            );
            var iconBackground = System.Drawing.Color.FromArgb(
                pwm.IconBackground.A,
                pwm.IconBackground.R,
                pwm.IconBackground.G,
                pwm.IconBackground.B
            );
            var author = Tuple.Create<string, string, string, string, string, string>(
                _projectManager.ActiveProject.Author, null, pwm.WebsiteLink, pwm.FacebookLink, pwm.TwitterLink, pwm.YoutubeLink
            );
            var package = Common.Model.Packaging.WKPackage.CreateModAssembly(
                _projectManager.ActiveProject.Version,
                _projectManager.ActiveProject.Name,
                author,
                pwm.Description,
                pwm.LargeDescription,
                pwm.License,
                (headerBackground, pwm.UseBlackText, iconBackground).ToTuple(),
                new List<System.Xml.Linq.XElement> { }
            );

            return Task.FromResult(true);
        }

        public void AddToMod(IGameFile file) => throw new NotImplementedException();

        public List<string> GetAvaliableClasses() => CR2WTypeManager.AvailableTypes.ToList();

        public async Task<bool> PackAndInstallProject()
        {
            if (_projectManager.ActiveProject == null)
            {
                return false;
            }
            if (_projectManager.ActiveProject is not Tw3Project w3Project)
            {
                throw new GameMismatchException(nameof(Tw3Project), _projectManager.ActiveProject.GetType().Name);
            }

            if (Process.GetProcessesByName("Witcher3").Length != 0)
            {
                _loggerService.Error("Please ensure the game is not running before editing the files.");
                return false;
            }
            if (_projectManager?.ActiveProject is not Tw3Project tw3p)
            {
                return false;
            }

            WitcherPackSettings packsettings = tw3p.PackSettings;
            if (packsettings != null)
            {
                //ProjectStatus = EProjectStatus.Busy;
                //StatusProgress = 0;

                //IsToolStripBtnPackEnabled = false;

                //SaveAllFiles();

                //Create the dirs. So script only mods don't die.
                Directory.CreateDirectory(_projectManager.ActiveProject.PackedModDirectory);
                if (!string.IsNullOrEmpty(w3Project.GetDlcName()))
                {
                    Directory.CreateDirectory(tw3p.PackedDlcDirectory);
                }

                //------------------------PRE COOKING------------------------------------//
                // have a check if somehow users forget to add a dlc folder in their dlc :(
                // but have files inform them that it just not gonna work
                var initialDlcCheck = true;
                if (tw3p.DLCFiles.Any() && string.IsNullOrEmpty(w3Project.GetDlcName()))
                {
                    _loggerService.Error("Files in your DLC directory must be structured as such: dlc\\DLCNAME\\files. DLC will not be packed.");
                    initialDlcCheck = false;
                }

                #region Pre Cooking

                //Handle strings.
                //if (packsettings.Strings.Item1 || packsettings.Strings.Item2)
                {
                    //m_windowFactory.RequestStringsGUI(); TODO
                }

                // Cleanup Directories
                CleanupDirectories();

                // Create Virtial Links
                CreateVirtualLinks();

                // analyze files in dlc
                var statusanalyzedlc = -1;

                var seedfile = Path.Combine(_projectManager.ActiveProject.ProjectDirectory, @"cooked", $"seed_dlc{_projectManager.ActiveProject.Name}.files");

                if (initialDlcCheck)
                {
                    if (Directory.GetFiles(tw3p.DlcDirectory, "*", SearchOption.AllDirectories).Any())
                    {
                        _loggerService.Info($"======== Analyzing DLC files ======== \n");
                        if (Directory.GetFiles(tw3p.DlcDirectory, "*.reddlc", SearchOption.AllDirectories).Any())
                        {
                            var reddlcfile = Directory.GetFiles(tw3p.DlcDirectory, "*.reddlc", SearchOption.AllDirectories).FirstOrDefault();
                            var analyze = new Wcc_lite.analyze()
                            {
                                Analyzer = analyzers.r4dlc,
                                Out = seedfile,
                                reddlc = reddlcfile
                            };
                            statusanalyzedlc *= await Task.Run(() => RunCommand(analyze));

                            if (statusanalyzedlc == 0)
                            {
                                _loggerService.Error("DLC analysis failed, creating fallback seedfiles. \n");
                                CreateFallBackSeedFile(seedfile);
                            }
                        }
                        else
                        {
                            _loggerService.Error("No reddlc found, creating fallback seedfiles. \n");
                            CreateFallBackSeedFile(seedfile);
                        }
                    }
                }

                #endregion Pre Cooking

                //MainController.Get().StatusProgress = 5;

                //------------------------- COOKING -------------------------------------//

                #region Cooking

                var statusCook = -1;

                // cook uncooked files
                var taskCookCol = Task.Run(() => Cook());
                await taskCookCol.ContinueWith(antecedent =>
                    //Logger.LogString($"Cooking Collision ended with status: {antecedent.Result}", Logtype.Important);
                    statusCook = antecedent.Result);
                if (statusCook == 0)
                {
                    _loggerService.Error("Cooking collision finished with errors. \n");
                }

                #endregion Cooking

                //MainController.Get().StatusProgress = 15;

                //------------------------- POST COOKING --------------------------------//

                #region Copy Cooked Files

                // copy mod files from Archive (cooked files) to \cooked
                if (Directory.GetFiles(w3Project.ModCookedDirectory, "*", SearchOption.AllDirectories).Any())
                {
                    _loggerService.Info($"======== Adding cooked mod files ======== \n");
                    try
                    {
                        var di = new DirectoryInfo(w3Project.ModCookedDirectory);
                        var files = di.GetFiles("*", SearchOption.AllDirectories);
                        _loggerService.Info($"Found {files.Length} files in {di.FullName}. \n");
                        foreach (var fi in files)
                        {
                            var relpath = fi.FullName[(w3Project.ModCookedDirectory.Length + 1)..];
                            var newpath = Path.Combine(w3Project.CookedModDirectory, relpath);

                            if (File.Exists(newpath))
                            {
                                _loggerService.Info($"Duplicate cooked file found in {newpath}. Overwriting. \n");
                                File.Delete(newpath);
                            }

                            fi.CopyToAndCreate(newpath);
                            _loggerService.Info($"Copied file to cooked directory: {fi.FullName}. \n");
                        }
                    }
                    catch (Exception)
                    {
                        _loggerService.Error("Copying cooked mod files finished with errors. \n");
                    }
                    finally
                    {
                        _loggerService.Info("Finished succesfully. \n");
                    }
                }

                // copy dlc files from Archive (cooked files) to \cooked
                if (Directory.GetFiles(w3Project.DlcCookedDirectory, "*", SearchOption.AllDirectories).Any())
                {
                    _loggerService.Info($"======== Adding cooked DLC files ======== \n");
                    try
                    {
                        var di = new DirectoryInfo(w3Project.DlcCookedDirectory);
                        var files = di.GetFiles("*", SearchOption.AllDirectories);
                        _loggerService.Info($"Found {files.Length} files in {di.FullName}. \n");
                        foreach (var fi in files)
                        {
                            var relpath = fi.FullName[(w3Project.DlcCookedDirectory.Length + 1)..];
                            var newpath = Path.Combine(w3Project.CookedDlcDirectory, relpath);

                            if (File.Exists(newpath))
                            {
                                _loggerService.Warning($"Duplicate cooked file found {newpath}. Overwriting. \n");
                                File.Delete(newpath);
                            }

                            fi.CopyToAndCreate(newpath);
                            _loggerService.Info($"Copied file to cooked directory: {fi.FullName}. \n");
                        }
                    }
                    catch (Exception)
                    {
                        _loggerService.Error("Copying cooked DLC files finished with errors. \n");
                    }
                    finally
                    {
                        _loggerService.Info("Finished succesfully. \n");
                    }
                }

                #endregion Copy Cooked Files

                //MainController.Get().StatusProgress = 20;

                //------------------------- PACKING -------------------------------------//

                #region Packing

                var statusPack = -1;

                //Handle bundle packing.
                if (packsettings.dlcPackBundles || packsettings.modPackBundles)
                {
                    // packing
                    //if (statusCookCol * statusCookTex != 0)
                    {
                        var t = Pack(packsettings.modPackBundles, packsettings.dlcPackBundles);
                        await t.ContinueWith(antecedent =>
                            //Logger.LogString($"Packing Bundles ended with status: {antecedent.Result}", Logtype.Important);
                            statusPack = (int)antecedent.Status);
                        if (statusPack == 0)
                        {
                            _loggerService.Error("Packing bundles finished with errors. \n");
                        }
                    }
                    //else
                    //    Logger.LogString("Cooking assets failed. No bundles will be packed!\n", Logtype.Error);
                }

                #endregion Packing

                //MainController.Get().StatusProgress = 40;

                //------------------------ METADATA -------------------------------------//

                #region Metadata

                //Handle metadata generation.
                var statusMetaData = -1;

                if (packsettings.modGenMetadata || packsettings.dlcGenMetadata)
                {
                    if (statusPack == 1)
                    {
                        var t = CreateMetaData(packsettings.modGenMetadata,
                            packsettings.dlcGenMetadata);
                        await t.ContinueWith(antecedent => statusMetaData = antecedent.Result);
                        if (statusMetaData == 0)
                        {
                            _loggerService.Error("Generating metadata finished with errors. \n");
                        }
                    }
                    else
                    {
                        _loggerService.Error("Packing bundles failed. No metadata will be generated.\n");
                    }
                }

                #endregion Metadata

                //MainController.Get().StatusProgress = 50;

                //------------------------ POST COOKING ---------------------------------//

                //---------------------------- CACHES -----------------------------------//

                #region Buildcache

                var statusCol = -1;
                var statusTex = -1;

                //Generate collision cache
                if (packsettings.modGenCollCache || packsettings.dlcGenCollCache)
                {
                    var t = GenerateCache(EArchiveType.CollisionCache, packsettings.modGenCollCache,
                        packsettings.dlcGenCollCache);
                    await t.ContinueWith(antecedent => statusCol = antecedent.Result);
                    if (statusCol == 0)
                    {
                        _loggerService.Error("Collision cache built with errors. \n");
                    }
                }

                //Handle texture caching
                if (packsettings.modGenTexCache || packsettings.dlcGenTexCache)
                {
                    var t = GenerateCache(EArchiveType.TextureCache, packsettings.modGenTexCache, packsettings.dlcGenTexCache);
                    await t.ContinueWith(antecedent => statusTex = antecedent.Result);
                    if (statusTex == 0)
                    {
                        _loggerService.Error("Texture cache built with errors. \n");
                    }
                }

                //Handle sound caching
                if (packsettings.modSound || packsettings.dlcSound)
                {
                    if (packsettings.modSound)
                    {
                        var soundmoddir = Path.Combine(_projectManager.ActiveProject.ModDirectory, EArchiveType.SoundCache.ToString());

                        // We need to have the original soundcache's so we can rebuild them when packing the mod
                        foreach (var wem in Directory.GetFiles(soundmoddir, "*.wem", SearchOption.AllDirectories))
                        {
                            // Get the file id so we can search for the parent soundcache
                            var id = Path.GetFileNameWithoutExtension(SoundCache.GetIDFromPath(wem));

                            // Find the parent bank
                            foreach (var bnk in SoundCache.info.Banks)
                            {
                                if (bnk.IncludedFullFiles.Any(x => x.Id == id) || bnk.IncludedPrefetchFiles.Any(x => x.Id == id))
                                {
                                    if (!File.Exists(Path.Combine(soundmoddir, bnk.Path)))
                                    {
                                        //TODO: Fix this somehow
                                        //var bytes = MainController.ImportFile(bnk.Path, MainController.Get().SoundManager);
                                        //File.WriteAllBytes(Path.Combine(soundmoddir, bnk.Path), bytes[0].ToArray());
                                        _loggerService.Log("Imported " + bnk.Path + " for rebuilding with the modded wem files!");
                                    }
                                    break;
                                }
                            }
                        }

                        foreach (var bnk in Directory.GetFiles(soundmoddir, "*.bnk", SearchOption.AllDirectories))
                        {
                            var bank = new Soundbank(bnk);
                            bank.readFile();
                            bank.read_wems(soundmoddir);
                            bank.rebuild_data();
                            File.Delete(bnk);
                            bank.build_bnk(bnk);
                            _loggerService.Info("Rebuilt modded bnk" + bnk);
                        }

                        //Create mod soundspc.cache
                        if (Directory.Exists(soundmoddir) &&
                        new DirectoryInfo(soundmoddir)
                        .GetFiles("*.*", SearchOption.AllDirectories)
                        .Where(file => file.Name.ToLower().EndsWith("wem") || file.Name.ToLower().EndsWith("bnk")).Any())
                        {
                            SoundCache.Write(
                                new DirectoryInfo(soundmoddir)
                                    .GetFiles("*.*", SearchOption.AllDirectories)
                                    .Where(file => file.Name.ToLower().EndsWith("wem") || file.Name.ToLower().EndsWith("bnk"))
                                    .ToList().Select(x => x.FullName).ToList(),
                                    Path.Combine(_projectManager.ActiveProject.PackedModDirectory, @"soundspc.cache"));
                            _loggerService.Info("Modded sound cache generated.\n");
                        }
                        else
                        {
                            _loggerService.Info("Modded sound cache not generated.\n");
                        }
                    }

                    if (packsettings.dlcSound)
                    {
                        var sounddlcdir = Path.Combine(tw3p.DlcDirectory, EArchiveType.SoundCache.ToString());

                        //Create dlc soundspc.cache
                        if (Directory.Exists(sounddlcdir) && new DirectoryInfo(sounddlcdir)
                            .GetFiles("*.*", SearchOption.AllDirectories).Any(file => file.Name.ToLower().EndsWith("wem") || file.Name.ToLower().EndsWith("bnk")))
                        {
                            SoundCache.Write(
                                new DirectoryInfo(sounddlcdir)
                                    .GetFiles("*.*", SearchOption.AllDirectories)
                                    .Where(file => file.Name.ToLower().EndsWith("wem") || file.Name.ToLower().EndsWith("bnk")).ToList().Select(x => x.FullName).ToList(),
                                Path.Combine(tw3p.PackedDlcDirectory, @"soundspc.cache"));
                            _loggerService.Info("DLC sound cache generated.\n");
                        }
                        else
                        {
                            _loggerService.Info("DLC sound cache not generated.\n");
                        }
                    }
                }

                #endregion Buildcache

                //MainController.Get().StatusProgress = 60;

                //---------------------------- SCRIPTS ----------------------------------//

                #region Scripts

                var packscriptsMod = packsettings.modScripts;
                var packscriptsdlc = packsettings.dlcScripts;
                //Handle mod scripts
                if (packscriptsMod && Directory.Exists(Path.Combine(_projectManager.ActiveProject.ModDirectory, "scripts")) && Directory.GetFiles(Path.Combine(_projectManager.ActiveProject.ModDirectory, "scripts"), "*.*", SearchOption.AllDirectories).Any())
                {
                    if (!Directory.Exists(Path.Combine(_projectManager.ActiveProject.ModDirectory, "scripts")))
                    {
                        Directory.CreateDirectory(Path.Combine(_projectManager.ActiveProject.ModDirectory, "scripts"));
                    }
                    //Now Create all of the directories
                    foreach (var dirPath in Directory.GetDirectories(Path.Combine(_projectManager.ActiveProject.ModDirectory, "scripts"), "*.*",
                        SearchOption.AllDirectories))
                    {
                        Directory.CreateDirectory(dirPath.Replace(Path.Combine(_projectManager.ActiveProject.ModDirectory, "scripts"), Path.Combine(_projectManager.ActiveProject.PackedModDirectory, "scripts")));
                    }

                    //Copy all the files & Replaces any files with the same name
                    foreach (var newPath in Directory.GetFiles(Path.Combine(_projectManager.ActiveProject.ModDirectory, "scripts"), "*.*",
                        SearchOption.AllDirectories))
                    {
                        File.Copy(newPath, newPath.Replace(Path.Combine(_projectManager.ActiveProject.ModDirectory, "scripts"), Path.Combine(_projectManager.ActiveProject.PackedModDirectory, "scripts")), true);
                    }
                }

                //Handle the DLC scripts
                if (packscriptsdlc && Directory.Exists(Path.Combine(tw3p.DlcDirectory, "scripts")) && Directory.GetFiles(Path.Combine(tw3p.DlcDirectory, "scripts"), "*.*", SearchOption.AllDirectories).Any())
                {
                    if (!Directory.Exists(Path.Combine(tw3p.DlcDirectory, "scripts")))
                    {
                        Directory.CreateDirectory(Path.Combine(tw3p.DlcDirectory, "scripts"));
                    }
                    //Now Create all of the directories
                    foreach (var dirPath in Directory.GetDirectories(Path.Combine(tw3p.DlcDirectory, "scripts"), "*.*",
                        SearchOption.AllDirectories))
                    {
                        Directory.CreateDirectory(dirPath.Replace(Path.Combine(tw3p.DlcDirectory, "scripts"), Path.Combine(tw3p.PackedDlcDirectory, "scripts")));
                    }

                    //Copy all the files & Replaces any files with the same name
                    foreach (var newPath in Directory.GetFiles(Path.Combine(tw3p.DlcDirectory, "scripts"), "*.*",
                        SearchOption.AllDirectories))
                    {
                        File.Copy(newPath, newPath.Replace(Path.Combine(tw3p.DlcDirectory, "scripts"), Path.Combine(tw3p.PackedDlcDirectory, "scripts")), true);
                    }
                }

                #endregion Scripts

                //MainController.Get().StatusProgress = 80;

                //---------------------------- STRINGS ----------------------------------//

                #region Strings

                //Copy the generated w3strings
                if (packsettings.modStrings || packsettings.dlcStrings)
                {
                    var files = Directory.GetFiles(_projectManager.ActiveProject.ProjectDirectory + "\\strings").Where(s => Path.GetExtension(s) == ".w3strings").ToList();

                    if (packsettings.modStrings)
                    {
                        files.ForEach(x => File.Copy(x, Path.Combine(tw3p.PackedDlcDirectory, Path.GetFileName(x))));
                    }

                    if (packsettings.dlcStrings)
                    {
                        files.ForEach(x => File.Copy(x, Path.Combine(_projectManager.ActiveProject.PackedModDirectory, Path.GetFileName(x))));
                    }
                }

                #endregion Strings

                //MainController.Get().StatusProgress = 90;

                //---------------------------- FINALIZE ---------------------------------//

                InstallMod();

                //Report that we are done
                //MainController.Get().StatusProgress = 100;
                //MainController.Get().ProjectStatus = EProjectStatus.Ready;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void InstallMod()
        {
            try
            {
                //Check if we have installed this mod before. If so do a little cleanup.
                if (File.Exists(_projectManager.ActiveProject.ProjectDirectory + "\\install_log.xml"))
                {
                    var log = XDocument.Load(_projectManager.ActiveProject.ProjectDirectory + "\\install_log.xml");
                    var dirs = log.Root.Element("Files")?.Descendants("Directory");
                    if (dirs != null)
                    {
                        //Loop throught dirs and delete the old files in them.
                        foreach (var d in dirs)
                        {
                            foreach (var f in d.Elements("file"))
                            {
                                if (File.Exists(f.Value))
                                {
                                    File.Delete(f.Value);
                                    Debug.WriteLine("File delete: " + f.Value);
                                }
                            }
                        }
                        //Delete the empty directories.
                        foreach (var d in dirs)
                        {
                            if (d.Attribute("Path") != null)
                            {
                                if (Directory.Exists(d.Attribute("Path").Value))
                                {
                                    if (!Directory.GetFiles(d.Attribute("Path").Value, "*", SearchOption.AllDirectories).Any())
                                    {
                                        Directory.Delete(d.Attribute("Path").Value, true);
                                        Debug.WriteLine("Directory delete: " + d.Attribute("Path").Value);
                                    }
                                }
                            }
                        }
                    }
                    //Delete the old install log. We will make a new one so this is not needed anymore.
                    File.Delete(_projectManager.ActiveProject.ProjectDirectory + "\\install_log.xml");
                }
                var installlog = new XDocument(new XElement("InstalLog", new XAttribute("Project", _projectManager.ActiveProject.Name), new XAttribute("Build_date", DateTime.Now.ToString())));
                var fileroot = new XElement("Files");
                //Copy and log the files.
                if (!Directory.Exists(Path.Combine(_projectManager.ActiveProject.ProjectDirectory, "packed")))
                {
                    _loggerService.Info("Failed to install mod. Packed directory does not exist! Check packing options.");
                    return;
                }

                var packedmoddir = Path.Combine(_projectManager.ActiveProject.ProjectDirectory, "packed", "Mods");
                if (Directory.Exists(packedmoddir))
                {
                    fileroot.Add(Commonfunctions.DirectoryCopy(packedmoddir, _settings.GetW3GameModDir(), true));
                }

                var packeddlcdir = Path.Combine(_projectManager.ActiveProject.ProjectDirectory, "packed", "DLC");
                if (Directory.Exists(packeddlcdir))
                {
                    fileroot.Add(Commonfunctions.DirectoryCopy(packeddlcdir, _settings.GetW3GameDlcDir(), true));
                }

                installlog.Root.Add(fileroot);
                //Save the log.
                installlog.Save(_projectManager.ActiveProject.ProjectDirectory + "\\install_log.xml");
                _loggerService.Info(_projectManager.ActiveProject.Name + " installed!" + "\n");
            }
            catch (Exception ex)
            {
                //If we screwed up something. Log it.
                _loggerService.Error(ex.ToString() + "\n");
            }
        }


        #region Methods

        /// <summary>
        /// Always call this first to clean the directories.
        /// </summary>
        public void CleanupDirectories()
        {
            // cleanup packed folders
            CleanupInner(Path.Combine(_projectManager.ActiveProject.ProjectDirectory, "packed"));

            // cleanup cooked folders
            CleanupInner(Path.Combine(_projectManager.ActiveProject.ProjectDirectory, "cooked"));

            // delete existing cook dbs
            var dlc_files_db = Path.Combine(Path.GetFullPath(_projectManager.ActiveProject.ProjectDirectory), db_dlcfiles);
            var dlc_tex_db = Path.Combine(Path.GetFullPath(_projectManager.ActiveProject.ProjectDirectory), db_dlctextures);
            var mod_files_db = Path.Combine(Path.GetFullPath(_projectManager.ActiveProject.ProjectDirectory), db_modfiles);
            var mod_tex_db = Path.Combine(Path.GetFullPath(_projectManager.ActiveProject.ProjectDirectory), db_modtextures);
            if (Directory.Exists(dlc_files_db))
            {
                Directory.Delete(dlc_files_db, true);
            }

            Directory.CreateDirectory(dlc_files_db);
            if (Directory.Exists(dlc_tex_db))
            {
                Directory.Delete(dlc_tex_db, true);
            }

            Directory.CreateDirectory(dlc_tex_db);
            if (Directory.Exists(mod_files_db))
            {
                Directory.Delete(mod_files_db, true);
            }

            Directory.CreateDirectory(mod_files_db);
            if (Directory.Exists(mod_tex_db))
            {
                Directory.Delete(mod_tex_db, true);
            }

            Directory.CreateDirectory(mod_tex_db);

            #region Directory cleanup

            void CleanupInner(string path)
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                else
                {
                    var di = new DirectoryInfo(path);
                    foreach (var file in di.GetFiles())
                    {
                        file.Delete();
                    }
                    foreach (var dir in di.GetDirectories())
                    {
                        dir.Delete(true);
                    }
                }
            }

            #endregion Directory cleanup
        }

        /// <summary>
        /// Cooks Files in the ModProject's folders (Bunde, TextureCache etc...)
        /// </summary>
        /// <returns></returns>
        public async Task<int> Cook()
        {
            if (_projectManager.ActiveProject is not Tw3Project w3Project)
            {
                throw new GameMismatchException(nameof(Tw3Project), _projectManager.ActiveProject.GetType().Name);
            }

            var dlc_files_db = Path.Combine(Path.GetFullPath(_projectManager.ActiveProject.ProjectDirectory), db_dlcfiles);
            //string dlc_tex_db = Path.Combine(Path.GetFullPath(_projectManager.ActiveProject.ProjectDirectory), db_dlctextures);
            var mod_files_db = Path.Combine(Path.GetFullPath(_projectManager.ActiveProject.ProjectDirectory), db_modfiles);
            //string mod_tex_db = Path.Combine(Path.GetFullPath(_projectManager.ActiveProject.ProjectDirectory), db_modtextures);

            var finished = 1;

            // Cook Mod files

            if (Directory.Exists(w3Project.ModUncookedDirectory) && Directory.GetFiles(w3Project.ModUncookedDirectory, "*", SearchOption.AllDirectories).Any()
                                                                 && !string.IsNullOrEmpty(w3Project.CookedModDirectory))
            {
                finished *= await Task.Run(() => CookInternal(w3Project.ModUncookedDirectory, w3Project.CookedModDirectory));

                if (!string.IsNullOrEmpty(w3Project.CookedModDirectory))
                {
                    var moddb = new FileInfo(Path.Combine(w3Project.CookedModDirectory, "cook.db"));
                    if (moddb.Exists)
                    {
                        moddb.MoveTo(Path.Combine(mod_files_db, "cook.db"));
                    }
                }
            }

            // Cook DLC files
            if (Directory.Exists(w3Project.DlcUncookedDirectory) && Directory.GetFiles(w3Project.DlcUncookedDirectory, "*", SearchOption.AllDirectories).Any()
                                                                 && !string.IsNullOrEmpty(w3Project.CookedDlcDirectory))
            {
                finished *= await Task.Run(() => CookInternal(w3Project.DlcUncookedDirectory, w3Project.CookedDlcDirectory, true));

                if (!string.IsNullOrEmpty(w3Project.CookedDlcDirectory))
                {
                    var dlcdb = new FileInfo(Path.Combine(w3Project.CookedDlcDirectory, "cook.db"));
                    if (dlcdb.Exists)
                    {
                        dlcdb.MoveTo(Path.Combine(dlc_files_db, "cook.db"));
                    }
                }
            }

            return finished == 0 ? 0 : 1;

            async Task<int> CookInternal(string dir_uncooked, string dir_cooked, bool dlc = false)
            {
                var type = dlc ? "Dlc" : "Mod";

                try
                {
                    if (Directory.Exists(dir_uncooked) && Directory.GetFiles(dir_uncooked, "*", SearchOption.AllDirectories).Any())
                    {
                        _loggerService.LogString($"======== Cooking {type} ======== \n", Logtype.Important);
                        //ProjectStatus = $"Cooking {type}";

                        if (!Directory.Exists(dir_cooked))
                        {
                            Directory.CreateDirectory(dir_cooked);
                        }

                        var cook = new Wcc_lite.cook()
                        {
                            Platform = platform.pc,
                            outdir = dir_cooked,
                        };

                        if (dlc)
                        {
                            cook.trimdir = $"dlc\\{w3Project.GetDlcName()}";
                            var seeddir = Path.Combine(_projectManager.ActiveProject.ProjectDirectory, @"cooked", $"seed_dlc{_projectManager.ActiveProject.Name}.files");
                            cook.seed = seeddir;
                        }
                        else
                        {
                            cook.mod = dir_uncooked;
                            cook.basedir = dir_uncooked; //cfg.DepotPath?
                        }

                        return await Task.Run(() => RunCommand(cook));
                    }
                    else
                    {
                        return -1;
                    }
                }
                catch (DirectoryNotFoundException)
                {
                    _loggerService.LogString($"{type} folder not found. {type} won't be cooked. \n", Logtype.Important);
                    return -1;
                }
                catch (Exception ex)
                {
                    _loggerService.LogString(ex.ToString() + "\n", Logtype.Error);
                    return 0;
                }
            }
        }

        /// <summary>
        /// Manually creates a seedfile for cooking
        /// </summary>
        /// <param name="seedfile"></param>
        public void CreateFallBackSeedFile(string seedfile)
        {
            if (_projectManager.ActiveProject is not Tw3Project w3Project)
            {
                throw new GameMismatchException(nameof(Tw3Project), _projectManager.ActiveProject.GetType().Name);
            }
            if (File.Exists(seedfile))
            {
                File.Delete(seedfile);
            }

            var uncookeddlcdir = new DirectoryInfo(w3Project.DlcUncookedDirectory);
            if (uncookeddlcdir.Exists)
            {
                using (var fs = new FileStream(seedfile, FileMode.Create, FileAccess.Write))
                using (var sr = new StreamWriter(fs, Encoding.Default))
                {
                    sr.WriteLine("{");
                    sr.WriteLine("\t\"files\": [");

                    var files = uncookeddlcdir.GetFiles("*", SearchOption.AllDirectories);
                    for (var i = 0; i < files.Length; i++)
                    {
                        var file = files[i];
                        var relpath = $"{file.FullName[(uncookeddlcdir.FullName.Length + 1)..]}";
                        if (!relpath.StartsWith("dlc\\"))
                        {
                            relpath = $"dlc\\{relpath}";
                        }

                        relpath = relpath.Replace("\\", "\\\\");
                        sr.WriteLine("\t\t{");
                        sr.WriteLine($"\t\t\t\"path\": \"{relpath}\",");
                        sr.WriteLine($"\t\t\t\"bundle\": \"blob\"");
                        if (i < files.Length - 1)
                        {
                            sr.WriteLine("\t\t},");
                        }
                        else
                        {
                            sr.WriteLine("\t\t}");
                        }
                    }

                    sr.WriteLine("\t]");
                    sr.WriteLine("}");
                }
                _loggerService.LogString($"Fallback seedfile created: {seedfile}. \n", Logtype.Success);
            }
        }

        /// <summary>
        /// Create metadata.store file
        /// </summary>
        /// <param name="packmod"></param>
        /// <param name="dlcmod"></param>
        /// <returns></returns>
        public async Task<int> CreateMetaData(bool packmod, bool dlcmod)
        {
            if (_projectManager?.ActiveProject is not Tw3Project tw3p)
            {
                return 0;
            }

            var finished = 1;

            if (packmod && Directory.Exists(_projectManager.ActiveProject.PackedModDirectory))
            {
                finished *= await Task.Run(() => CreateMetaDataInternal(_projectManager.ActiveProject.PackedModDirectory));
            }

            if (dlcmod && Directory.Exists(tw3p.PackedDlcDirectory))
            {
                finished *= await Task.Run(() => CreateMetaDataInternal(tw3p.PackedDlcDirectory, true));
            }

            return finished == 0 ? 0 : 1;

            async Task<int> CreateMetaDataInternal(string outDir, bool dlc = false)
            {
                var type = dlc ? "Dlc" : "Mod";

                try
                {
                    //We only pack this if we have bundles.
                    if (Directory.GetFiles(outDir, "*.bundle", SearchOption.AllDirectories).Any())
                    {
                        _loggerService.LogString($"======== Packing {type} metadata ======== \n", Logtype.Important);
                        //ProjectStatus = $"Packing {type} metadata";

                        var metadata = new Wcc_lite.metadatastore()
                        {
                            Directory = outDir
                        };

                        return await Task.Run(() => RunCommand(metadata));
                    }
                    else
                    {
                        return -1;
                    }
                }
                catch (DirectoryNotFoundException)
                {
                    //AddOutput($"{type} wasn't bundled. Metadata won't be generated. \n", Logtype.Important);
                    _loggerService.LogString($"{type} wasn't bundled. Metadata won't be generated. \n", Logtype.Important);
                    return -1;
                }
                catch (Exception ex)
                {
                    //AddOutput(ex.ToString() + "\n", Logtype.Error);
                    _loggerService.LogString(ex.ToString() + "\n", Logtype.Error);
                    return 0;
                }
            }
        }

        /// <summary>
        /// Creates virtual links (mklink junction) between the project dlc folder
        /// and the modkit r4Data/dlc folder
        /// </summary>
        public void CreateVirtualLinks()
        {
            if (_projectManager.ActiveProject is not Tw3Project w3Project)
            {
                throw new GameMismatchException(nameof(Tw3Project), _projectManager.ActiveProject.GetType().Name);
            }
            if (string.IsNullOrEmpty(w3Project.GetDlcName()))
            {
                return;
            }

            if (string.IsNullOrEmpty(w3Project.GetDlcUncookedRelativePath()))
            {
                return;
            }

            // hack to determine if older project
            var r4link = Path.Combine(_settings.DepotPath, "dlc", w3Project.GetDlcName());
            var projlink = Path.Combine(w3Project.DlcUncookedDirectory, w3Project.GetDlcUncookedRelativePath());
            if (new DirectoryInfo(w3Project.DlcUncookedDirectory).GetDirectories().Any(_ => _.Name == "dlc"))
            {
                projlink = Path.Combine(w3Project.DlcUncookedDirectory, "dlc", w3Project.GetDlcUncookedRelativePath());
            }

            if (Directory.Exists(r4link))
            {
                Directory.Delete(r4link);
            }
            if (!Directory.Exists(r4link))
            {
                var args = $"/c mklink /J \"{r4link}\" \"{projlink}\"";
                var startInfo = new ProcessStartInfo("cmd.exe", args)
                {
                    WindowStyle = ProcessWindowStyle.Minimized
                };
                Process.Start(startInfo);

                _loggerService.LogString($"Links {r4link} <<==>> {projlink} succesfully created.", Logtype.Success);
            }
        }

        /// <summary>
        /// Call wcc buildcache over the uncooked directories
        /// IN: \\CollisionCache, cooked\\Mods\\mod\\cook.db, OUT: packed\\Mods\\mod
        /// </summary>
        /// <param name="cachetype"></param>
        /// <param name="packmod"></param>
        /// <param name="packdlc"></param>
        /// <returns></returns>
        public async Task<int> GenerateCache(EArchiveType cachetype, bool packmod, bool packdlc)
        {
            if (_projectManager.ActiveProject is not Tw3Project w3Project)
            {
                throw new GameMismatchException(nameof(Tw3Project), _projectManager.ActiveProject.GetType().Name);
            }
            //const string db_dlcfiles = "db_dlcfiles";
            //const string db_dlctextures = "db_dlctextures";
            //const string db_modfiles = "db_modfiles";
            //const string db_modtextures = "db_modtextures";

            var dlc_files_db = Path.Combine(Path.GetFullPath(_projectManager.ActiveProject.ProjectDirectory), "db_dlcfiles");
            var mod_files_db = Path.Combine(Path.GetFullPath(_projectManager.ActiveProject.ProjectDirectory), "db_modfiles");
            var moddbfile = Path.Combine(mod_files_db, "cook.db");
            var dlcdbfile = Path.Combine(dlc_files_db, "cook.db");
            var modbasedir = w3Project.ModUncookedDirectory;
            var dlcbasedir = _settings.DepotPath;

            var cbuilder = cachebuilder.textures;
            var filename = "";

            switch (cachetype)
            {
                case EArchiveType.TextureCache:
                {
                    cbuilder = cachebuilder.textures;
                    filename = "texture.cache";
                }
                break;

                case EArchiveType.CollisionCache:
                {
                    cbuilder = cachebuilder.physics;
                    filename = "collision.cache";
                }
                break;

                default:
                    throw new NotImplementedException();
            }

            var finished = 1;

            if (packmod)
            {
                finished *= await Task.Run(() => GenerateCacheInternal(_projectManager.ActiveProject.PackedModDirectory, moddbfile, modbasedir));
            }

            if (packdlc)
            {
                finished *= await Task.Run(() => GenerateCacheInternal(w3Project.PackedDlcDirectory, dlcdbfile, dlcbasedir, true));
            }

            return finished == 0 ? 0 : 1;

            async Task<int> GenerateCacheInternal(string packDir, string dbfile, string basedir, bool dlc = false)
            {
                var type = dlc ? "Dlc" : "Mod";
                try
                {
                    // check if a cook.db exists for that
                    if (File.Exists(dbfile))
                    {
                        _loggerService.LogString($"======== Generating {type} {cachetype} cache ======== \n", Logtype.Important);
                        //ProjectStatus = $"Generating {type} {cachetype} cache";

                        var buildcache = new Wcc_lite.buildcache()
                        {
                            Platform = platform.pc,
                            builder = cbuilder,
                            basedir = basedir,
                            DataBase = dbfile,
                            Out = $"{packDir}\\{filename}"
                        };
                        return await Task.Run(() => RunCommand(buildcache));
                    }
                    else
                    {
                        return -1;
                    }
                }
                catch (DirectoryNotFoundException)
                {
                    _loggerService.LogString($"{type} {cachetype} folder not found. {type} {cachetype} won't be generated. \n", Logtype.Important);
                    return -1;
                }
                catch (Exception ex)
                {
                    _loggerService.LogString(ex.ToString() + "\n", Logtype.Error);
                    return 0;
                }
            }
        }

        /// <summary>
        /// Packs the bundles for the DLC and the Mod.
        /// </summary>
        /// <param name="packmod"></param>
        /// <param name="packdlc"></param>
        /// <returns></returns>
        public async Task<int> Pack(bool packmod, bool packdlc)
        {
            if (_projectManager.ActiveProject is not Tw3Project w3Project)
            {
                throw new GameMismatchException(nameof(Tw3Project), _projectManager.ActiveProject.GetType().Name);
            }
            var finished = 1;

            if (packmod && Directory.Exists(w3Project.CookedModDirectory) && Directory.Exists(_projectManager.ActiveProject.PackedModDirectory))
            {
                finished *= await Task.Run(() => PackBundleInternal(w3Project.CookedModDirectory, _projectManager.ActiveProject.PackedModDirectory));
            }

            if (packdlc && Directory.Exists(w3Project.CookedDlcDirectory) && Directory.Exists(w3Project.PackedDlcDirectory))
            {
                finished *= await Task.Run(() => PackBundleInternal(w3Project.CookedDlcDirectory, w3Project.PackedDlcDirectory, true));
            }

            return finished == 0 ? 0 : 1;

            async Task<int> PackBundleInternal(string inputDir, string outputDir, bool dlc = false)
            {
                var type = dlc ? "Dlc" : "Mod";
                try
                {
                    if (Directory.Exists(inputDir) && Directory.GetFiles(inputDir, "*", SearchOption.AllDirectories).Any())
                    {
                        _loggerService.LogString($"======== Packing {type} bundles ======== \n", Logtype.Important);
                        //ProjectStatus = $"Packing {type} bundles";

                        var pack = new Wcc_lite.pack()
                        {
                            Directory = inputDir,
                            Outdir = outputDir
                        };
                        return await Task.Run(() => RunCommand(pack));
                    }
                    else
                    {
                        return -1;
                    }
                }
                catch (DirectoryNotFoundException)
                {
                    _loggerService.LogString($"{type} Archive directory not found. Bundles will not be packed for {type}. \n", Logtype.Important);
                    return -1;
                }
                catch (Exception ex)
                {
                    _loggerService.LogString(ex.ToString() + "\n", Logtype.Error);
                    return 0;
                }
            }
        }

        #endregion Methods

        #region Wcc Tasks

        /// <summary>
        /// Adds all file dependencies (cr2w imports) to a specified folder
        /// retaining relative paths
        /// </summary>
        /// <param name="importfilepath"></param>
        /// <param name="recursive"></param>
        /// <param name="silent"></param>
        /// <param name="alternateOutDirectory"></param>
        /// <returns></returns>
        public async Task AddAllImportsAsync(string importfilepath,
            bool recursive = false, bool silent = false, string alternateOutDirectory = "", bool logonly = false)
        {
            if (_projectManager.ActiveProject is not Tw3Project w3Project)
            {
                throw new GameMismatchException(nameof(Tw3Project), _projectManager.ActiveProject.GetType().Name);
            }
            if (!File.Exists(importfilepath))
            {
                return;
            }

            var relativepath = "";
            var isDLC = false;
            var projectFolder = EProjectFolders.Uncooked;
            if (string.IsNullOrWhiteSpace(alternateOutDirectory))
            {
                (relativepath, isDLC, projectFolder) = importfilepath.GetModRelativePath(_projectManager.ActiveProject.FileDirectory);
            }
            else
            {
                relativepath = importfilepath[(alternateOutDirectory.Length + 1)..];
            }

            var importslist = new List<ICR2WImport>();
            var bufferlist = new List<ICR2WBuffer>();
            bool hasinternalBuffer;

            using (var fs = new FileStream(importfilepath, FileMode.Open, FileAccess.Read))
            using (var reader = new BinaryReader(fs))
            {
                var cr2w = new CR2WFile();
                (importslist, hasinternalBuffer, bufferlist) = cr2w.ReadImportsAndBuffers(reader);
            }

            // add imports
            foreach (var import in importslist)
            {
                var filename = Path.GetFileName(import.DepotPathStr);
                if (logonly)
                {
                    _loggerService.LogString(filename, Logtype.Important);
                }

                var path = UnbundleFile(import.DepotPathStr, isDLC, projectFolder, EArchiveType.Bundle, alternateOutDirectory, false, silent);
                // If unbundled file is xbm, also extract tga from texturecache
                if (Path.GetExtension(import.DepotPathStr) == ".xbm")
                {
                    UnbundleFile(import.DepotPathStr, isDLC, EProjectFolders.Raw, EArchiveType.TextureCache, alternateOutDirectory, false, silent);
                }

                if (string.IsNullOrWhiteSpace(path))
                {
                    _loggerService.LogString($"Did not unbundle {filename}, import is missing.", Logtype.Error);
                }
                else
                {
                    // recursively add all 1st order dependencies :Gp:
                    if (recursive)
                    {
                        await AddAllImportsAsync(path, true, silent, alternateOutDirectory, logonly);
                    }
                }
            }

            // add buffers
            if (hasinternalBuffer)
            {
                _loggerService.LogString($"{Path.GetFileName(importfilepath)} has internal buffers. If you need external buffers, unbundle them manually.", Logtype.Important);
            }
            else
            {
                // unbundle external buffers
                foreach (var buffer in bufferlist)
                {
                    var index = buffer;
                    var bufferpath = $"{relativepath}.{index}.buffer";
                    var bufferName = $"{Path.GetFileName(relativepath)}.{index}.buffer";

                    var path = UnbundleFile(bufferpath, isDLC, projectFolder, EArchiveType.Bundle, alternateOutDirectory, false, silent);
                    if (string.IsNullOrWhiteSpace(path))
                    {
                        _loggerService.LogString($"Did not unbundle {bufferName}, import is missing.", Logtype.Error);
                    }
                }
            }

            //if (success && !silent)
            //    Logger.LogString($"Succesfully imported all dependencies.", Logtype.Success);
        }

        /// <summary>
        /// Unbundles a file with the given relativepath from either the Game or the Mod BundleManager
        /// and adds it to the depot, optionally copying to the project
        /// </summary>
        /// <param name="relativePath"></param>
        /// <param name="projectFolder"></param>
        /// <param name="bundleType"></param>
        /// <param name="alternateOutDirectory"></param>
        /// <param name="loadmods"></param>
        /// <param name="silent"></param>
        /// <returns></returns>
        public string UnbundleFile(string relativePath, bool isDlc, EProjectFolders projectFolder, EArchiveType bundleType = EArchiveType.Bundle, string alternateOutDirectory = "", bool loadmods = false, bool silent = false)
        {
            if (_projectManager.ActiveProject is not Tw3Project w3Project)
            {
                throw new GameMismatchException(nameof(Tw3Project), _projectManager.ActiveProject.GetType().Name);
            }
            var extension = Path.GetExtension(relativePath);
            var filename = Path.GetFileName(relativePath);

            // Jato said not to add textures to an fbx
            // so I am keeping meshes violet :)
            //if (extension == ".xbm" && bundleType == EBundleType.Archive)
            //{
            //    //var uncookTask = Task.Run(() => UncookFileToPath(relativePath, isDLC, alternateOutDirectory));
            //    //Task.WaitAll(uncookTask);
            //    //return relativePath;
            //    UnbundleFile(relativePath, isDLC, projectFolder, EBundleType.TextureCache, alternateOutDirectory,
            //        loadmods, silent);
            //}
            var manager = GetArchiveManagers(loadmods).FirstOrDefault(_ => _.TypeName == bundleType);

            if (manager != null && manager.Items.Any(x => x.Value.Any(y => y.Name == relativePath)))
            {
                var archives = manager.FileList
                    .Where(x => x.Name == relativePath)
                    .Select(y => new KeyValuePair<string, IGameFile>(y.Archive.ArchiveAbsolutePath, y))
                    .ToList();

                // Extract
                try
                {
                    // if more than one archive get the last
                    var archive = archives.Last().Value;

                    var newpath = "";
                    if (string.IsNullOrWhiteSpace(alternateOutDirectory))
                    {
                        switch (projectFolder)
                        {
                            case EProjectFolders.Cooked:
                                newpath = Path.Combine(isDlc
                                    ? w3Project.DlcCookedDirectory
                                    : w3Project.ModCookedDirectory, relativePath);
                                break;

                            case EProjectFolders.Uncooked:
                                newpath = Path.Combine(isDlc
                                    ? w3Project.DlcUncookedDirectory
                                    : w3Project.ModUncookedDirectory, relativePath);
                                break;

                            case EProjectFolders.Raw:
                                newpath = Path.Combine(isDlc
                                    ? w3Project.RawDlcDirectory
                                    : w3Project.RawModDirectory, relativePath);
                                break;

                            default:
                                break;
                        }
                    }
                    else
                    {
                        newpath = Path.Combine(alternateOutDirectory, relativePath);
                    }

                    if (string.IsNullOrWhiteSpace(newpath))
                    {
                        return "";
                    }

                    // for xbms check if a file with the current export extensions exists
                    if (!File.Exists(newpath) && (extension != ".xbm" || !File.Exists(Path.ChangeExtension(newpath,
                        imageformat.tga.ToString()))))
                    {
                        using (var fs = new FileStream(newpath, FileMode.Create))
                        {
                            archive.Extract(fs);
                        }
                        if (!silent)
                        {
                            _loggerService.LogString($"Succesfully unbundled {filename}.", Logtype.Success);
                        }
                    }
                    //else
                    //    if (!silent) Logger.LogString($"File already exists in mod project: {filename}.", Logtype.Success);
                    return newpath;
                }
                catch (Exception ex)
                {
                    _loggerService.LogString(ex.ToString(), Logtype.Error);
                    return "";
                }
            }

            return "";
        }



        /// <summary>
        ///
        /// </summary>
        /// <param name="folder"></param>
        /// <param name="outfolder"></param>
        /// <param name="file"></param>
        /// <returns></returns>
        public async Task DumpFile(string folder, string outfolder, string file = "")
        {
            //ProjectStatus = EProjectStatus.Busy;
            WCC_Command cmd = null;
            try
            {
                if (file == "")
                {
                    cmd = new Wcc_lite.dumpfile()
                    {
                        Dir = folder,
                        Out = outfolder
                    };
                }
                else
                {
                    cmd = new Wcc_lite.dumpfile()
                    {
                        File = file,
                        Out = outfolder
                    };
                }
                await Task.Run(() => RunCommand(cmd));
            }
            catch (Exception ex)
            {
                _loggerService.LogString(ex.ToString() + "\n", Logtype.Error);
            }

            //ProjectStatus = EProjectStatus.Ready;
        }

        /// <summary>
        /// Exports an existing file in the ModProject (w2mesh, redcloth) to the modProject
        /// </summary>
        /// <param name="fullpath"></param>
        /// <returns></returns>
        public async Task ExportFileToMod(string fullpath)
        {
            if (_projectManager.ActiveProject is not Tw3Project w3Project)
            {
                throw new GameMismatchException(nameof(Tw3Project), _projectManager.ActiveProject.GetType().Name);
            }
            var workDir = Path.GetFullPath($"{ISettingsManager.GetWorkDir()}_export");
            if (!Directory.Exists(workDir))
            {
                Directory.CreateDirectory(workDir);
            }


            Directory.Delete(workDir, true);

            // check if physical file exists
            if (!File.Exists(fullpath))
            {
                _loggerService.LogString($"File to export does not exist {fullpath}.", Logtype.Error);
                return;
            }

            // check if the extension matches an exportable format
            var importedExtension = Path.GetExtension(fullpath).TrimStart('.');
            EImportable exportedExtension;
            try
            {
                exportedExtension = REDTypes.ExportExtensionToRawExtension((EExportable)Enum.Parse(typeof(EExportable), importedExtension));
            }
            catch (Exception)
            {
                _loggerService.LogString($"Not an exportable filetype: {importedExtension}.", Logtype.Error);
                return;
            }

            // get relative path
            (var relativePath, var isDLC, var projectFolder) = fullpath.GetModRelativePath(_projectManager.ActiveProject.FileDirectory);
            var exportpath = isDLC
                ? Path.Combine(w3Project.RawDirectory, "DLC", relativePath)
                : Path.Combine(w3Project.RawDirectory, "Mod", relativePath);
            exportpath = Path.ChangeExtension(exportpath, exportedExtension.ToString());

            // add all imports to

            //string workDir = "";                                            // add to mod
            //string workDir = Configuration.DepotPath;  // r4depot

            await AddAllImportsAsync(fullpath, true, true, workDir);

            // copy the w2mesh and all imports to the depot
            var depotInfo = new FileInfo(Path.Combine(workDir, relativePath));
            var uncookedInfo = new FileInfo(fullpath);
            uncookedInfo.CopyToAndCreate(depotInfo.FullName, true);

            // export with wcc_lite
            if (!string.IsNullOrEmpty(relativePath) && !string.IsNullOrEmpty(exportpath))
            {
                // uncook the folder
                var export = new Wcc_lite.export()
                {
                    File = relativePath,
                    Out = exportpath,
                    Depot = workDir
                };
                await Task.Run(() => RunCommand(export));

                if (File.Exists(exportpath))
                {
                    _loggerService.LogString($"Successfully exported {relativePath}.", Logtype.Success);
                }
                else
                {
                    _loggerService.LogString($"Did not export {relativePath}.", Logtype.Error);
                }
            }
        }

        /// <summary>
        /// Deprecated, Use the Modkit instead
        /// Kept for a neat hack tricking wcc_lite into dumping individual files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public async void RequestWccliteFileDumpfile(object sender, RequestFileOpenArgs e)
        {
            var filename = e.File;
            if (!File.Exists(filename) && !Directory.Exists(filename))
            {
                return;
            }
            // We dump an individual file with wcclite dumpfile
            if (File.Exists(filename))
            {
                // '\\?\' is a neutral win32 path prefix. It hacks wcc_lite into dumping individual files.
                // This string will get input again, further down the line, in wcc_command.GetVariables
                // Windows paths and string management... This one is more than stupid, it is an horror. \\FIXME if you can.
                await DumpFile("", @"\\?\", filename);
            }
            //Wcclite recursively dumps CR2Ws in a directory.
            else if (Directory.Exists(filename))
            {
                var dir = filename;
                await DumpFile(dir, dir);
            }
        }


        /// <summary>
        /// Uncooks a single file to a temp directory
        /// </summary>
        /// <param name="relativePath"></param>
        /// <param name="newpath"></param>
        /// <param name="indir"></param>
        /// <returns></returns>
        public async Task<int> UncookFileToPath(string basedir, string relativePath, bool isDLC, string alternateOutDirectory = "")
        {
            if (_projectManager.ActiveProject is not Tw3Project w3Project)
            {
                throw new GameMismatchException(nameof(Tw3Project), _projectManager.ActiveProject.GetType().Name);
            }
            #region Unbundle relative file directory to temp dir

            // create temporary uncooked directory
            var outdir = Path.GetFullPath(ISettingsManager.GetWorkDir());
            if (Directory.Exists(outdir))
            {
                Directory.Delete(outdir, true);
            }

            Directory.CreateDirectory(outdir);

            var di = new DirectoryInfo(outdir);

            // try get uncook extension from settings
            var imgfmt = imageformat.tga;

            var relativeParentDir = Path.GetDirectoryName(relativePath);

            // uncook the folder with wcc
            // check if mod or vanilla file
            var indir = isDLC
                ? Path.GetFullPath(_settings.GetW3GameDlcDir())
                : Path.GetFullPath(_settings.W3ExecutablePath);
            if (basedir.Contains(Path.GetFullPath(_settings.GetW3GameModDir())))
            {
                indir = basedir;
            }

            var wccuncook = new Wcc_lite.uncook()
            {
                InputDirectory = indir,
                OutputDirectory = outdir,
                TargetDirectory = relativeParentDir,
                Imgfmt = imgfmt,
                //UncookExtensions = Path.GetExtension(newpath).TrimStart('.'),
            };
            await Task.Run(() => RunCommand(wccuncook));

            #endregion Unbundle relative file directory to temp dir

            #region Move file to outdir

            // move uncooked file to mod project
            var newpath = "";
            // if an alternative dir is set, move there
            // otherwise move to mod
            if (string.IsNullOrWhiteSpace(alternateOutDirectory))
            {
                newpath = isDLC
                    ? Path.Combine(w3Project.DlcUncookedDirectory, $"dlc{_projectManager.ActiveProject.Name}", relativePath)
                    : Path.Combine(w3Project.ModUncookedDirectory, relativePath);
            }
            else
            {
                newpath = Path.Combine(alternateOutDirectory, relativePath);
            }

            if (string.IsNullOrWhiteSpace(newpath))
            {
                return 0;
            }

            var addedFilesCount = 0;
            var fis = di.GetFiles("*", SearchOption.AllDirectories);
            foreach (var f in fis)
            {
                if (f.Name != Path.GetFileName(relativePath))
                {
                    continue;
                }

                try
                {
                    if (File.Exists(newpath))
                    {
                        File.Delete(newpath);
                    }

                    f.CopyToAndCreate(newpath);

                    addedFilesCount++;
                }
                catch (Exception)
                {
                    _loggerService.LogString("Unable to move uncooked file to ModProject, perhaps a file of that name is currently open in Wkit.", Logtype.Error);
                }
            }

            #endregion Move file to outdir

            // Logging
            _loggerService.LogString($"Moved {addedFilesCount} files to project.", Logtype.Important);
            if (addedFilesCount > 0)
            {
                _loggerService.LogString($"Successfully uncooked {addedFilesCount} files.", Logtype.Success);
            }
            else
            {
                _loggerService.LogString($"Wcc_lite is unable to uncook this file.", Logtype.Error);
            }

            return addedFilesCount;
        }

        #endregion Wcc Tasks

        #region Methods

        /// <summary>
        /// runs wcc_lite with specified command
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public async Task<int> RunCommand(WCC_Command cmd)
        {
            string args = cmd.Arguments;
            return await Task.Run(() => RunCommand(cmd.Name, args));
        }

        /// <summary>
        /// Runs wcc_lite with specified arguments
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        private int RunCommand(string cmdName, string args)
        {
            EWccStatus status = EWccStatus.NotRun;
            using (Process process = new Process())
            {
                try
                {
                    _loggerService.LogString($"-----------------------------------------------------", Logtype.Important);
                    _loggerService.LogString($"WCC_TASK: {args}", Logtype.Important);

                    process.StartInfo.FileName = _settings.WccLitePath;
                    process.StartInfo.WorkingDirectory = Path.GetDirectoryName(_settings.WccLitePath);
                    process.StartInfo.Arguments = args;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.CreateNoWindow = true;

                    using (AutoResetEvent outputWaitHandle = new AutoResetEvent(false))
                    {
                        process.OutputDataReceived += (sender, e) =>
                        {
                            if (e.Data == null)
                            {
                                outputWaitHandle.Close();
                                //Handle Errors
                                //if (Logger.ErrorLog.Any(x => x.Flag == WccLogFlag.WLF_Error) &&
                                //    Logger.ErrorLog.Any(x => x.Value.Contains("WCC operation failed.")))
                                //{
                                //    Logger.LogString("Did not complete.\r\n", Logtype.Error);
                                //    status = EWccStatus.NotRun;
                                //}
                                //else if (Logger.ErrorLog.Any(x => x.Flag == WccLogFlag.WLF_Error))
                                //{
                                //    Logger.LogString("Finished with errors.\r\n", Logtype.Error);
                                //    status = EWccStatus.Error;
                                //}
                                //else if (Logger.ErrorLog.Any(x => x.Flag == WccLogFlag.WLF_Warning))
                                //{
                                //    Logger.LogString("Finished with warnings.\r\n", Logtype.Important);
                                //    status = EWccStatus.Finished;
                                //}
                                //else
                                //{
                                //    Logger.LogString("Finished succesfully.\r\n", Logtype.Success);
                                //    status = EWccStatus.Finished;
                                //}
                            }
                            else
                            {
                                //Logger.LogExtended(SystemLogFlag.SLF_Interpretable, ToolLogFlag.TLF_Wcc, cmdName, $"{e.Data}");

                                Logtype wkitflag = Logtype.Wcc;
                                //if (Logger.ErrorLog.Count > 0)
                                //{
                                //    var flag = Logger.ErrorLog.Last().Flag;
                                //    switch (flag)
                                //    {
                                //        case WccLogFlag.WLF_Error:
                                //            wkitflag = Logtype.Error;
                                //            break;

                                //        case WccLogFlag.WLF_Warning:
                                //            wkitflag = Logtype.Important;
                                //            break;

                                //        case WccLogFlag.WLF_Default:
                                //        case WccLogFlag.WLF_Info:
                                //        default:
                                //            break;
                                //    }
                                //}

                                _loggerService.LogString(e.Data, wkitflag);
                            }
                        };

                        process.Start();
                        process.BeginOutputReadLine();
                        process.WaitForExit();
                    }
                    if (status != EWccStatus.NotRun)
                        return 1;
                    else
                        return 0;
                }
                catch (Exception ex)
                {
                    _loggerService.LogString(ex.ToString(), Logtype.Error);
                    throw;
                }
            }
        }

        #endregion Methods


        #endregion Methods
    }
}
