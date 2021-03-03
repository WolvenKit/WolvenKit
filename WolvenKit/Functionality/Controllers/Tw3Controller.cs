using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Catel.IoC;
using Catel.Linq;
using Newtonsoft.Json;
using ProtoBuf;
using WolvenKit.Bundles;
using WolvenKit.Cache;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Services;
using WolvenKit.Common.Wcc;
using WolvenKit.CR2W.Types;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal;
using WolvenKit.MVVM.Model;
using WolvenKit.W3Speech;
using WolvenKit.W3Strings;
using WolvenKit.Wwise;
using WolvenKit.Wwise.Wwise;

namespace WolvenKit.Functionality.Controllers
{
    public class Tw3Controller : GameControllerBase
    {
        #region Fields

        private static BundleManager bundleManager;
        private static CollisionManager collisionManager;
        private static SoundManager soundManager;
        private static SpeechManager speechManager;
        private static TextureManager textureManager;
        private static W3StringManager w3StringManager;

        #endregion Fields



        #region Methods

        public static BundleManager LoadBundleManager()
        {
            var _settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
            var _logger = ServiceLocator.Default.ResolveType<ILoggerService>();

            _logger.LogString("Loading bundle manager... ", Logtype.Important);
            try
            {
                if (File.Exists(Tw3Controller.GetManagerPath(EManagerType.BundleManager)))
                {
                    using (var file = File.OpenText(Tw3Controller.GetManagerPath(EManagerType.BundleManager)))
                    {
                        var serializer = new JsonSerializer
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                            PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                            TypeNameHandling = TypeNameHandling.Auto
                        };
                        bundleManager = (BundleManager)serializer.Deserialize(file, typeof(BundleManager));
                    }
                }
                else
                {
                    bundleManager = new BundleManager();
                    bundleManager.LoadAll(Path.GetDirectoryName(_settings.W3ExecutablePath));
                    using (var writer = new StreamWriter(
                        new FileStream(Tw3Controller.GetManagerPath(EManagerType.BundleManager), FileMode.Open)))
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
                if (File.Exists(GetManagerPath(EManagerType.BundleManager)))
                {
                    File.Delete(GetManagerPath(EManagerType.BundleManager));
                }

                bundleManager = new BundleManager();
                bundleManager.LoadAll(Path.GetDirectoryName(_settings.W3ExecutablePath));
            }
            _logger.LogString("Finished loading bundle manager.", Logtype.Success);
            return bundleManager;
        }

        public static CollisionManager LoadCollisionManager()
        {
            var _settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
            var _logger = ServiceLocator.Default.ResolveType<ILoggerService>();

            _logger.LogString("Loading collision manager... ", Logtype.Important);
            try
            {
                if (File.Exists(Tw3Controller.GetManagerPath(EManagerType.CollisionManager)))
                {
                    using (var file = File.OpenText(Tw3Controller.GetManagerPath(EManagerType.CollisionManager)))
                    {
                        var serializer = new JsonSerializer
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                            PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                            TypeNameHandling = TypeNameHandling.Auto
                        };
                        collisionManager = (CollisionManager)serializer.Deserialize(file, typeof(CollisionManager));
                    }
                }
                else
                {
                    collisionManager = new CollisionManager();
                    collisionManager.LoadAll(Path.GetDirectoryName(_settings.W3ExecutablePath));
                    File.WriteAllText(Tw3Controller.GetManagerPath(EManagerType.CollisionManager), JsonConvert.SerializeObject(collisionManager, Formatting.None, new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                        PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                        TypeNameHandling = TypeNameHandling.Auto
                    }));
                    _settings.ManagerVersions[(int)EManagerType.CollisionManager] = CollisionManager.SerializationVersion;
                }
            }
            catch (System.Exception)
            {
                if (File.Exists(Tw3Controller.GetManagerPath(EManagerType.CollisionManager)))
                {
                    File.Delete(Tw3Controller.GetManagerPath(EManagerType.CollisionManager));
                }

                collisionManager = new CollisionManager();
                collisionManager.LoadAll(Path.GetDirectoryName(_settings.W3ExecutablePath));
            }
            _logger.LogString("Finished loading collision manager.", Logtype.Success);

            return collisionManager;
        }

        public static SoundManager LoadSoundManager()
        {
            var _settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
            var _logger = ServiceLocator.Default.ResolveType<ILoggerService>();

            _logger.LogString("Loading sound manager... ", Logtype.Important);
            try
            {
                if (File.Exists(Tw3Controller.GetManagerPath(EManagerType.SoundManager)))
                {
                    using (var file = File.OpenText(Tw3Controller.GetManagerPath(EManagerType.SoundManager)))
                    {
                        var serializer = new JsonSerializer
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                            PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                            TypeNameHandling = TypeNameHandling.Auto
                        };
                        soundManager = (SoundManager)serializer.Deserialize(file, typeof(SoundManager));
                    }
                }
                else
                {
                    soundManager = new SoundManager();
                    soundManager.LoadAll(Path.GetDirectoryName(_settings.W3ExecutablePath));
                    File.WriteAllText(Tw3Controller.GetManagerPath(EManagerType.SoundManager), JsonConvert.SerializeObject(soundManager, Formatting.None, new JsonSerializerSettings()
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
                if (File.Exists(GetManagerPath(EManagerType.SoundManager)))
                {
                    File.Delete(GetManagerPath(EManagerType.SoundManager));
                }

                soundManager = new SoundManager();
                soundManager.LoadAll(Path.GetDirectoryName(_settings.W3ExecutablePath));
            }
            _logger.LogString("Finished loading sound manager.", Logtype.Success);

            return soundManager;
        }

        public static SpeechManager LoadSpeechManager()
        {
            var _settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
            var _logger = ServiceLocator.Default.ResolveType<ILoggerService>();

            _logger.LogString("Loading speech manager ... ", Logtype.Important);
            speechManager = new SpeechManager();
            speechManager.LoadAll(Path.GetDirectoryName(_settings.W3ExecutablePath));
            _logger.LogString("Finished loading speech manager.", Logtype.Success);

            return speechManager;
        }

        public static W3StringManager LoadStringsManager()
        {
            var _settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
            var _logger = ServiceLocator.Default.ResolveType<ILoggerService>();

            _logger.LogString("Loading strings manager ... ", Logtype.Important);
            try
            {
                if (File.Exists(Tw3Controller.GetManagerPath(EManagerType.W3StringManager)) && new FileInfo(Tw3Controller.GetManagerPath(EManagerType.W3StringManager)).Length > 0)
                {
                    using (var file = File.Open(Tw3Controller.GetManagerPath(EManagerType.W3StringManager), FileMode.Open))
                    {
                        w3StringManager = Serializer.Deserialize<W3StringManager>(file);
                    }
                }
                else
                {
                    w3StringManager = new W3StringManager();
                    w3StringManager.Load(_settings.TextLanguage, Path.GetDirectoryName(_settings.W3ExecutablePath));
                    Directory.CreateDirectory(Tw3Controller.ManagerCacheDir);
                    using (var file = File.Open(Tw3Controller.GetManagerPath(EManagerType.W3StringManager), FileMode.Create))
                    {
                        Serializer.Serialize(file, w3StringManager);
                    }

                    _settings.ManagerVersions[(int)EManagerType.W3StringManager] = W3StringManager.SerializationVersion;
                }
            }
            catch (System.Exception)
            {
                if (File.Exists(Tw3Controller.GetManagerPath(EManagerType.W3StringManager)))
                {
                    File.Delete(Tw3Controller.GetManagerPath(EManagerType.W3StringManager));
                }

                w3StringManager = new W3StringManager();
                w3StringManager.Load(_settings.TextLanguage, Path.GetDirectoryName(_settings.W3ExecutablePath));
            }
            _logger.LogString("Finished loading strings manager.", Logtype.Success);
            return w3StringManager;
        }

        public static TextureManager LoadTextureManager()
        {
            var _settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
            var _logger = ServiceLocator.Default.ResolveType<ILoggerService>();

            _logger.LogString("Loading texture manager... ", Logtype.Important);
            try
            {
                if (File.Exists(Tw3Controller.GetManagerPath(EManagerType.TextureManager)))
                {
                    using (var file = File.OpenText(Tw3Controller.GetManagerPath(EManagerType.TextureManager)))
                    {
                        var serializer = new JsonSerializer
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                            PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                            TypeNameHandling = TypeNameHandling.Auto
                        };
                        textureManager = (TextureManager)serializer.Deserialize(file, typeof(TextureManager));
                    }
                }
                else
                {
                    textureManager = new TextureManager();
                    textureManager.LoadAll(Path.GetDirectoryName(_settings.W3ExecutablePath));
                    File.WriteAllText(Tw3Controller.GetManagerPath(EManagerType.TextureManager), JsonConvert.SerializeObject(textureManager, Formatting.None, new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                        PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                        TypeNameHandling = TypeNameHandling.Auto
                    }));
                    _settings.ManagerVersions[(int)EManagerType.TextureManager] = TextureManager.SerializationVersion;
                }
            }
            catch (System.Exception)
            {
                if (File.Exists(Tw3Controller.GetManagerPath(EManagerType.TextureManager)))
                {
                    File.Delete(Tw3Controller.GetManagerPath(EManagerType.TextureManager));
                }

                textureManager = new TextureManager();
                textureManager.LoadAll(Path.GetDirectoryName(_settings.W3ExecutablePath));
            }
            _logger.LogString("Finished loading texture manager.", Logtype.Success);

            return textureManager;
        }

        public override List<IGameArchiveManager> GetArchiveManagersManagers() => new()
        {
            bundleManager,
            textureManager,
            collisionManager,
            soundManager,
            speechManager
        };

        public override List<string> GetAvaliableClasses() => CR2WTypeManager.AvailableTypes.ToList();

        //TODO: make this async Tasks?
        public override async Task HandleStartup()
        {
            var todo = new List<Func<IGameArchiveManager>>()
            {
                LoadBundleManager,
                LoadTextureManager,
                LoadCollisionManager,
                LoadSoundManager,
                LoadSpeechManager
            };
            Parallel.ForEach(todo, _ => Task.Run(_));
            await Task.CompletedTask;
        }

        public override Task<bool> PackageMod() =>
            //TODO: Create wkpackage from the mod
            Task.FromResult(true);

        public override async Task<bool> PackAndInstallProject()
        {
            var ActiveMod = MainController.Get().ActiveMod;
            var _logger = ServiceLocator.Default.ResolveType<ILoggerService>();
            if (ActiveMod == null)
            {
                return false;
            }

            if (Process.GetProcessesByName("Witcher3").Length != 0)
            {
                _logger.LogString("Please ensure the game is not running before editing the files.", Logtype.Error);
                return false;
            }

            var packsettings = new WolvenKit.Common.Model.WitcherPackSettings();
            if (packsettings != null)
            {
                MainController.Get().ProjectStatus = EProjectStatus.Busy;
                MainController.Get().StatusProgress = 0;

                //IsToolStripBtnPackEnabled = false;

                //SaveAllFiles();

                //Create the dirs. So script only mods don't die.
                Directory.CreateDirectory(ActiveMod.PackedModDirectory);
                if (!string.IsNullOrEmpty(ActiveMod.GetDlcName()))
                {
                    Directory.CreateDirectory(ActiveMod.PackedDlcDirectory);
                }

                //------------------------PRE COOKING------------------------------------//
                // have a check if somehow users forget to add a dlc folder in their dlc :(
                // but have files inform them that it just not gonna work
                var initialDlcCheck = true;
                if (ActiveMod.DLCFiles.Any() && string.IsNullOrEmpty(ActiveMod.GetDlcName()))
                {
                    _logger.LogString("Files in your DLC directory must be structured as such: dlc\\DLCNAME\\files. DLC will not be packed.", Logtype.Error);
                    initialDlcCheck = false;
                }

                #region Pre Cooking

                //Handle strings.
                //if (packsettings.Strings.Item1 || packsettings.Strings.Item2)
                {
                    //m_windowFactory.RequestStringsGUI(); TODO
                }

                // Cleanup Directories
                WccHelper.CleanupDirectories();

                // Create Virtial Links
                WccHelper.CreateVirtualLinks();

                // analyze files in dlc
                var statusanalyzedlc = -1;

                var seedfile = Path.Combine(ActiveMod.ProjectDirectory, @"cooked", $"seed_dlc{ActiveMod.Name}.files");

                if (initialDlcCheck)
                {
                    if (Directory.GetFiles(ActiveMod.DlcDirectory, "*", SearchOption.AllDirectories).Any())
                    {
                        _logger.LogString($"======== Analyzing DLC files ======== \n", Logtype.Important);
                        if (Directory.GetFiles(ActiveMod.DlcDirectory, "*.reddlc", SearchOption.AllDirectories).Any())
                        {
                            var reddlcfile = Directory.GetFiles(ActiveMod.DlcDirectory, "*.reddlc", SearchOption.AllDirectories).FirstOrDefault();
                            var analyze = new Wcc_lite.analyze()
                            {
                                Analyzer = analyzers.r4dlc,
                                Out = seedfile,
                                reddlc = reddlcfile
                            };
                            statusanalyzedlc *= await Task.Run(() => MainController.Get().WccHelper.RunCommand(analyze));

                            if (statusanalyzedlc == 0)
                            {
                                _logger.LogString("DLC analysis failed, creating fallback seedfiles. \n", Logtype.Error);
                                WccHelper.CreateFallBackSeedFile(seedfile);
                            }
                        }
                        else
                        {
                            _logger.LogString("No reddlc found, creating fallback seedfiles. \n", Logtype.Error);
                            WccHelper.CreateFallBackSeedFile(seedfile);
                        }
                    }
                }

                #endregion Pre Cooking

                MainController.Get().StatusProgress = 5;

                //------------------------- COOKING -------------------------------------//

                #region Cooking

                var statusCook = -1;

                // cook uncooked files
                var taskCookCol = Task.Run(() => WccHelper.Cook());
                await taskCookCol.ContinueWith(antecedent =>
                {
                    //Logger.LogString($"Cooking Collision ended with status: {antecedent.Result}", Logtype.Important);
                    statusCook = antecedent.Result;
                });
                if (statusCook == 0)
                {
                    _logger.LogString("Cooking collision finished with errors. \n", Logtype.Error);
                }

                #endregion Cooking

                MainController.Get().StatusProgress = 15;

                //------------------------- POST COOKING --------------------------------//

                #region Copy Cooked Files

                // copy mod files from Archive (cooked files) to \cooked
                if (Directory.GetFiles(ActiveMod.ModCookedDirectory, "*", SearchOption.AllDirectories).Any())
                {
                    _logger.LogString($"======== Adding cooked mod files ======== \n", Logtype.Important);
                    try
                    {
                        var di = new DirectoryInfo(ActiveMod.ModCookedDirectory);
                        var files = di.GetFiles("*", SearchOption.AllDirectories);
                        _logger.LogString($"Found {files.Length} files in {di.FullName}. \n");
                        foreach (var fi in files)
                        {
                            var relpath = fi.FullName[(ActiveMod.ModCookedDirectory.Length + 1)..];
                            var newpath = Path.Combine(ActiveMod.CookedModDirectory, relpath);

                            if (File.Exists(newpath))
                            {
                                _logger.LogString($"Duplicate cooked file found in {newpath}. Overwriting. \n", Logtype.Important);
                                File.Delete(newpath);
                            }

                            fi.CopyToAndCreate(newpath);
                            _logger.LogString($"Copied file to cooked directory: {fi.FullName}. \n", Logtype.Normal);
                        }
                    }
                    catch (Exception)
                    {
                        _logger.LogString("Copying cooked mod files finished with errors. \n", Logtype.Error);
                    }
                    finally
                    {
                        _logger.LogString("Finished succesfully. \n", Logtype.Success);
                    }
                }

                // copy dlc files from Archive (cooked files) to \cooked
                if (Directory.GetFiles(ActiveMod.DlcCookedDirectory, "*", SearchOption.AllDirectories).Any())
                {
                    _logger.LogString($"======== Adding cooked DLC files ======== \n", Logtype.Important);
                    try
                    {
                        var di = new DirectoryInfo(ActiveMod.DlcCookedDirectory);
                        var files = di.GetFiles("*", SearchOption.AllDirectories);
                        _logger.LogString($"Found {files.Length} files in {di.FullName}. \n");
                        foreach (var fi in files)
                        {
                            var relpath = fi.FullName[(ActiveMod.DlcCookedDirectory.Length + 1)..];
                            var newpath = Path.Combine(ActiveMod.CookedDlcDirectory, relpath);

                            if (File.Exists(newpath))
                            {
                                _logger.LogString($"Duplicate cooked file found {newpath}. Overwriting. \n", Logtype.Important);
                                File.Delete(newpath);
                            }

                            fi.CopyToAndCreate(newpath);
                            _logger.LogString($"Copied file to cooked directory: {fi.FullName}. \n", Logtype.Normal);
                        }
                    }
                    catch (Exception)
                    {
                        _logger.LogString("Copying cooked DLC files finished with errors. \n", Logtype.Error);
                    }
                    finally
                    {
                        _logger.LogString("Finished succesfully. \n", Logtype.Success);
                    }
                }

                #endregion Copy Cooked Files

                MainController.Get().StatusProgress = 20;

                //------------------------- PACKING -------------------------------------//

                #region Packing

                var statusPack = -1;

                //Handle bundle packing.
                if (packsettings.dlcPackBundles || packsettings.modPackBundles)
                {
                    // packing
                    //if (statusCookCol * statusCookTex != 0)
                    {
                        var t = WccHelper.Pack(packsettings.modPackBundles, packsettings.dlcPackBundles);
                        await t.ContinueWith(antecedent =>
                        {
                            //Logger.LogString($"Packing Bundles ended with status: {antecedent.Result}", Logtype.Important);
                            statusPack = (int)antecedent.Status;
                        });
                        if (statusPack == 0)
                        {
                            _logger.LogString("Packing bundles finished with errors. \n", Logtype.Error);
                        }
                    }
                    //else
                    //    Logger.LogString("Cooking assets failed. No bundles will be packed!\n", Logtype.Error);
                }

                #endregion Packing

                MainController.Get().StatusProgress = 40;

                //------------------------ METADATA -------------------------------------//

                #region Metadata

                //Handle metadata generation.
                var statusMetaData = -1;

                if (packsettings.modGenMetadata || packsettings.dlcGenMetadata)
                {
                    if (statusPack == 1)
                    {
                        var t = WccHelper.CreateMetaData(packsettings.modGenMetadata,
                            packsettings.dlcGenMetadata);
                        await t.ContinueWith(antecedent =>
                        {
                            statusMetaData = antecedent.Result;
                            //Logger.LogString($"Creating metadata ended with status: {statusMetaData}", Logtype.Important);
                        });
                        if (statusMetaData == 0)
                        {
                            _logger.LogString("Generating metadata finished with errors. \n", Logtype.Error);
                        }
                    }
                    else
                    {
                        _logger.LogString("Packing bundles failed. No metadata will be generated.\n", Logtype.Error);
                    }
                }

                #endregion Metadata

                MainController.Get().StatusProgress = 50;

                //------------------------ POST COOKING ---------------------------------//

                //---------------------------- CACHES -----------------------------------//

                #region Buildcache

                var statusCol = -1;
                var statusTex = -1;

                //Generate collision cache
                if (packsettings.modGenCollCache || packsettings.dlcGenCollCache)
                {
                    var t = WccHelper.GenerateCache(EArchiveType.CollisionCache, packsettings.modGenCollCache,
                        packsettings.dlcGenCollCache);
                    await t.ContinueWith(antecedent =>
                    {
                        statusCol = antecedent.Result;
                        //Logger.LogString($"Building collision cache ended with status: {statusCol}", Logtype.Important);
                    });
                    if (statusCol == 0)
                    {
                        _logger.LogString("Collision cache built with errors. \n", Logtype.Error);
                    }
                }

                //Handle texture caching
                if (packsettings.modGenTexCache || packsettings.dlcGenTexCache)
                {
                    var t = WccHelper.GenerateCache(EArchiveType.TextureCache, packsettings.modGenTexCache, packsettings.dlcGenTexCache);
                    await t.ContinueWith(antecedent =>
                    {
                        statusTex = antecedent.Result;
                        //Logger.LogString($"Building texture cache ended with status: {statusTex}", Logtype.Important);
                    });
                    if (statusTex == 0)
                    {
                        _logger.LogString("Texture cache built with errors. \n", Logtype.Error);
                    }
                }

                //Handle sound caching
                if (packsettings.modSound || packsettings.dlcSound)
                {
                    if (packsettings.modSound)
                    {
                        var soundmoddir = Path.Combine(ActiveMod.ModDirectory, EArchiveType.SoundCache.ToString());

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
                                        MainController.Get().Logger.LogString("Imported " + bnk.Path + " for rebuilding with the modded wem files!");
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
                            _logger.LogString("Rebuilt modded bnk" + bnk, Logtype.Success);
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
                                    Path.Combine(ActiveMod.PackedModDirectory, @"soundspc.cache"));
                            _logger.LogString("Modded sound cache generated.\n", Logtype.Important);
                        }
                        else
                        {
                            _logger.LogString("Modded sound cache not generated.\n", Logtype.Important);
                        }
                    }

                    if (packsettings.dlcSound)
                    {
                        var sounddlcdir = Path.Combine(ActiveMod.DlcDirectory, EArchiveType.SoundCache.ToString());

                        //Create dlc soundspc.cache
                        if (Directory.Exists(sounddlcdir) && new DirectoryInfo(sounddlcdir)
                            .GetFiles("*.*", SearchOption.AllDirectories).Any(file => file.Name.ToLower().EndsWith("wem") || file.Name.ToLower().EndsWith("bnk")))
                        {
                            SoundCache.Write(
                                new DirectoryInfo(sounddlcdir)
                                    .GetFiles("*.*", SearchOption.AllDirectories)
                                    .Where(file => file.Name.ToLower().EndsWith("wem") || file.Name.ToLower().EndsWith("bnk")).ToList().Select(x => x.FullName).ToList(),
                                Path.Combine(ActiveMod.PackedDlcDirectory, @"soundspc.cache"));
                            _logger.LogString("DLC sound cache generated.\n", Logtype.Important);
                        }
                        else
                        {
                            _logger.LogString("DLC sound cache not generated.\n", Logtype.Important);
                        }
                    }
                }

                #endregion Buildcache

                MainController.Get().StatusProgress = 60;

                //---------------------------- SCRIPTS ----------------------------------//

                #region Scripts

                var packscriptsMod = packsettings.modScripts;
                var packscriptsdlc = packsettings.dlcScripts;
                //Handle mod scripts
                if (packscriptsMod && Directory.Exists(Path.Combine(ActiveMod.ModDirectory, "scripts")) && Directory.GetFiles(Path.Combine(ActiveMod.ModDirectory, "scripts"), "*.*", SearchOption.AllDirectories).Any())
                {
                    if (!Directory.Exists(Path.Combine(ActiveMod.ModDirectory, "scripts")))
                    {
                        Directory.CreateDirectory(Path.Combine(ActiveMod.ModDirectory, "scripts"));
                    }
                    //Now Create all of the directories
                    foreach (var dirPath in Directory.GetDirectories(Path.Combine(ActiveMod.ModDirectory, "scripts"), "*.*",
                        SearchOption.AllDirectories))
                    {
                        Directory.CreateDirectory(dirPath.Replace(Path.Combine(ActiveMod.ModDirectory, "scripts"), Path.Combine(ActiveMod.PackedModDirectory, "scripts")));
                    }

                    //Copy all the files & Replaces any files with the same name
                    foreach (var newPath in Directory.GetFiles(Path.Combine(ActiveMod.ModDirectory, "scripts"), "*.*",
                        SearchOption.AllDirectories))
                    {
                        File.Copy(newPath, newPath.Replace(Path.Combine(ActiveMod.ModDirectory, "scripts"), Path.Combine(ActiveMod.PackedModDirectory, "scripts")), true);
                    }
                }

                //Handle the DLC scripts
                if (packscriptsdlc && Directory.Exists(Path.Combine(ActiveMod.DlcDirectory, "scripts")) && Directory.GetFiles(Path.Combine(ActiveMod.DlcDirectory, "scripts"), "*.*", SearchOption.AllDirectories).Any())
                {
                    if (!Directory.Exists(Path.Combine(ActiveMod.DlcDirectory, "scripts")))
                    {
                        Directory.CreateDirectory(Path.Combine(ActiveMod.DlcDirectory, "scripts"));
                    }
                    //Now Create all of the directories
                    foreach (var dirPath in Directory.GetDirectories(Path.Combine(ActiveMod.DlcDirectory, "scripts"), "*.*",
                        SearchOption.AllDirectories))
                    {
                        Directory.CreateDirectory(dirPath.Replace(Path.Combine(ActiveMod.DlcDirectory, "scripts"), Path.Combine(ActiveMod.PackedDlcDirectory, "scripts")));
                    }

                    //Copy all the files & Replaces any files with the same name
                    foreach (var newPath in Directory.GetFiles(Path.Combine(ActiveMod.DlcDirectory, "scripts"), "*.*",
                        SearchOption.AllDirectories))
                    {
                        File.Copy(newPath, newPath.Replace(Path.Combine(ActiveMod.DlcDirectory, "scripts"), Path.Combine(ActiveMod.PackedDlcDirectory, "scripts")), true);
                    }
                }

                #endregion Scripts

                MainController.Get().StatusProgress = 80;

                //---------------------------- STRINGS ----------------------------------//

                #region Strings

                //Copy the generated w3strings
                if (packsettings.modStrings || packsettings.dlcStrings)
                {
                    var files = Directory.GetFiles((ActiveMod.ProjectDirectory + "\\strings")).Where(s => Path.GetExtension(s) == ".w3strings").ToList();

                    if (packsettings.modStrings)
                    {
                        files.ForEach(x => File.Copy(x, Path.Combine(ActiveMod.PackedDlcDirectory, Path.GetFileName(x))));
                    }

                    if (packsettings.dlcStrings)
                    {
                        files.ForEach(x => File.Copy(x, Path.Combine(ActiveMod.PackedModDirectory, Path.GetFileName(x))));
                    }
                }

                #endregion Strings

                MainController.Get().StatusProgress = 90;

                //---------------------------- FINALIZE ---------------------------------//

                InstallMod();

                //Report that we are done
                MainController.Get().StatusProgress = 100;
                MainController.Get().ProjectStatus = EProjectStatus.Ready;
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void InstallMod()
        {
            var ActiveMod = MainController.Get().ActiveMod;
            var _logger = ServiceLocator.Default.ResolveType<ILoggerService>();
            try
            {
                //Check if we have installed this mod before. If so do a little cleanup.
                if (File.Exists(ActiveMod.ProjectDirectory + "\\install_log.xml"))
                {
                    var log = XDocument.Load(ActiveMod.ProjectDirectory + "\\install_log.xml");
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
                                    if (!(Directory.GetFiles(d.Attribute("Path").Value, "*", SearchOption.AllDirectories).Any()))
                                    {
                                        Directory.Delete(d.Attribute("Path").Value, true);
                                        Debug.WriteLine("Directory delete: " + d.Attribute("Path").Value);
                                    }
                                }
                            }
                        }
                    }
                    //Delete the old install log. We will make a new one so this is not needed anymore.
                    File.Delete(ActiveMod.ProjectDirectory + "\\install_log.xml");
                }
                var installlog = new XDocument(new XElement("InstalLog", new XAttribute("Project", ActiveMod.Name), new XAttribute("Build_date", DateTime.Now.ToString())));
                var fileroot = new XElement("Files");
                //Copy and log the files.
                if (!Directory.Exists(Path.Combine(ActiveMod.ProjectDirectory, "packed")))
                {
                    _logger.LogString("Failed to install mod. Packed directory does not exist! Check packing options.", Logtype.Important);
                    return;
                }

                var packedmoddir = Path.Combine(ActiveMod.ProjectDirectory, "packed", "Mods");
                if (Directory.Exists(packedmoddir))
                {
                    fileroot.Add(Commonfunctions.DirectoryCopy(packedmoddir, MainController.Get().Configuration.W3GameModDir, true));
                }

                var packeddlcdir = Path.Combine(ActiveMod.ProjectDirectory, "packed", "DLC");
                if (Directory.Exists(packeddlcdir))
                {
                    fileroot.Add(Commonfunctions.DirectoryCopy(packeddlcdir, MainController.Get().Configuration.W3GameDlcDir, true));
                }

                installlog.Root.Add(fileroot);
                //Save the log.
                installlog.Save(ActiveMod.ProjectDirectory + "\\install_log.xml");
                _logger.LogString(ActiveMod.Name + " installed!" + "\n", Logtype.Success);
            }
            catch (Exception ex)
            {
                //If we screwed up something. Log it.
                _logger.LogString(ex.ToString() + "\n", Logtype.Error);
            }
        }

        #endregion Methods
    }
}
