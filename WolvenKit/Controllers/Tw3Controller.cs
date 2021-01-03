using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Catel.IoC;
using Newtonsoft.Json;
using ProtoBuf;

namespace WolvenKit.Controllers
{
    using Services;
    using Bundles;
    using Cache;
    using Common.Services;
    using W3Speech;
    using W3Strings;
    public static class Tw3Controller
    {
        public static string GetManagerPath(EManagerType type)
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
        public static string GetManagerVersion(EManagerType type)
        {
            switch (type)
            {
                case EManagerType.BundleManager: return BundleManager.SerializationVersion;
                case EManagerType.CollisionManager: return CollisionManager.SerializationVersion;
                case EManagerType.SoundManager: return SoundManager.SerializationVersion;
                case EManagerType.W3StringManager: return W3StringManager.SerializationVersion;
                case EManagerType.TextureManager: return TextureManager.SerializationVersion;
                case EManagerType.Max:
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

        public static string ManagerCacheDir => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "ManagerCache");
        public static string WorkDir => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "tmp_workdir");
        //private static string DepotZipPath => Path.Combine(ManagerCacheDir, "Depot.zip");
        public static string XBMDumpPath => Path.Combine(ManagerCacheDir, "__xbmdump_3768555366.csv");


        public static BundleManager LoadBundleManager()
        {
            var _settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
            var _logger = ServiceLocator.Default.ResolveType<ILoggerService>();
            BundleManager BundleManager;

            _logger.LogString("Loading Bundle Manager ... ", Logtype.Important);
            try
            {
                if (File.Exists(Tw3Controller.GetManagerPath(EManagerType.BundleManager)))
                {
                    using (StreamReader file = File.OpenText(Tw3Controller.GetManagerPath(EManagerType.BundleManager)))
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
                    BundleManager.LoadAll(Path.GetDirectoryName(_settings.ExecutablePath));
                    File.WriteAllText(Tw3Controller.GetManagerPath(EManagerType.BundleManager), JsonConvert.SerializeObject(BundleManager, Formatting.None, new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                        PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                        TypeNameHandling = TypeNameHandling.Auto
                    }));
                    _settings.ManagerVersions[(int)EManagerType.BundleManager] = BundleManager.SerializationVersion;
                }
            }
            catch (System.Exception ex)
            {
                if (File.Exists(Tw3Controller.GetManagerPath(EManagerType.BundleManager)))
                    File.Delete(Tw3Controller.GetManagerPath(EManagerType.BundleManager));
                BundleManager = new BundleManager();
                BundleManager.LoadAll(Path.GetDirectoryName(_settings.ExecutablePath));
            }
            _logger.LogString("Finished loading Bundle Manager.", Logtype.Success);
            return BundleManager;
        }
        public static W3StringManager LoadStringsManager()
        {
            var _settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
            var _logger = ServiceLocator.Default.ResolveType<ILoggerService>();
            W3StringManager W3StringManager;

            _logger.LogString("Loading Strings Manager ... ", Logtype.Important);
            try
            {
                if (File.Exists(Tw3Controller.GetManagerPath(EManagerType.W3StringManager)) && new FileInfo(Tw3Controller.GetManagerPath(EManagerType.W3StringManager)).Length > 0)
                {
                    using (var file = File.Open(Tw3Controller.GetManagerPath(EManagerType.W3StringManager), FileMode.Open))
                    {
                        W3StringManager = Serializer.Deserialize<W3StringManager>(file);
                    }
                }
                else
                {
                    W3StringManager = new W3StringManager();
                    W3StringManager.Load(_settings.TextLanguage, Path.GetDirectoryName(_settings.ExecutablePath));
                    Directory.CreateDirectory(Tw3Controller.ManagerCacheDir);
                    using (var file = File.Open(Tw3Controller.GetManagerPath(EManagerType.W3StringManager), FileMode.Create))
                    {
                        Serializer.Serialize(file, W3StringManager);
                    }

                    _settings.ManagerVersions[(int)EManagerType.W3StringManager] = W3StringManager.SerializationVersion;
                }
            }
            catch (System.Exception)
            {
                if (File.Exists(Tw3Controller.GetManagerPath(EManagerType.W3StringManager)))
                    File.Delete(Tw3Controller.GetManagerPath(EManagerType.W3StringManager));
                W3StringManager = new W3StringManager();
                W3StringManager.Load(_settings.TextLanguage, Path.GetDirectoryName(_settings.ExecutablePath));
            }
            _logger.LogString("Finished loading Strings Manager.", Logtype.Success);
            return W3StringManager;

        }
        public static TextureManager LoadTextureManager()
        {
            var _settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
            var _logger = ServiceLocator.Default.ResolveType<ILoggerService>();
            TextureManager TextureManager;

            _logger.LogString("Loading Texture Manager ... ", Logtype.Important);
            try
            {
                if (File.Exists(Tw3Controller.GetManagerPath(EManagerType.TextureManager)))
                {
                    using (StreamReader file = File.OpenText(Tw3Controller.GetManagerPath(EManagerType.TextureManager)))
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
                    TextureManager.LoadAll(Path.GetDirectoryName(_settings.ExecutablePath));
                    File.WriteAllText(Tw3Controller.GetManagerPath(EManagerType.TextureManager), JsonConvert.SerializeObject(TextureManager, Formatting.None, new JsonSerializerSettings()
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
                    File.Delete(Tw3Controller.GetManagerPath(EManagerType.TextureManager));
                TextureManager = new TextureManager();
                TextureManager.LoadAll(Path.GetDirectoryName(_settings.ExecutablePath));
            }
            _logger.LogString("Finished loading Texture Manager.", Logtype.Success);

            return TextureManager;
        }
        public static CollisionManager LoadCollisionManager()
        {
            var _settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
            var _logger = ServiceLocator.Default.ResolveType<ILoggerService>();
            CollisionManager CollisionManager;

            _logger.LogString("Loading Collision Manager ... ", Logtype.Important);
            try
            {
                if (File.Exists(Tw3Controller.GetManagerPath(EManagerType.CollisionManager)))
                {
                    using (StreamReader file = File.OpenText(Tw3Controller.GetManagerPath(EManagerType.CollisionManager)))
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
                    CollisionManager.LoadAll(Path.GetDirectoryName(_settings.ExecutablePath));
                    File.WriteAllText(Tw3Controller.GetManagerPath(EManagerType.CollisionManager), JsonConvert.SerializeObject(CollisionManager, Formatting.None, new JsonSerializerSettings()
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
                    File.Delete(Tw3Controller.GetManagerPath(EManagerType.CollisionManager));
                CollisionManager = new CollisionManager();
                CollisionManager.LoadAll(Path.GetDirectoryName(_settings.ExecutablePath));
            }
            _logger.LogString("Finished loading Collision Manager.", Logtype.Success);

            return CollisionManager;
        }
        public static SoundManager LoadSoundManager()
        {
            var _settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
            var _logger = ServiceLocator.Default.ResolveType<ILoggerService>();
            SoundManager SoundManager;

            _logger.LogString("Loading Sound Manager ... ", Logtype.Important);
            try
            {
                if (File.Exists(Tw3Controller.GetManagerPath(EManagerType.SoundManager)))
                {
                    using (StreamReader file = File.OpenText(Tw3Controller.GetManagerPath(EManagerType.SoundManager)))
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
                    SoundManager.LoadAll(Path.GetDirectoryName(_settings.ExecutablePath));
                    File.WriteAllText(Tw3Controller.GetManagerPath(EManagerType.SoundManager), JsonConvert.SerializeObject(SoundManager, Formatting.None, new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                        PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                        TypeNameHandling = TypeNameHandling.Auto
                    }));
                    _settings.ManagerVersions[(int)EManagerType.SoundManager] = SoundManager.SerializationVersion;
                }
            }
            catch (System.Exception ex)
            {
                if (File.Exists(Tw3Controller.GetManagerPath(EManagerType.SoundManager)))
                    File.Delete(Tw3Controller.GetManagerPath(EManagerType.SoundManager));
                SoundManager = new SoundManager();
                SoundManager.LoadAll(Path.GetDirectoryName(_settings.ExecutablePath));
            }
            _logger.LogString("Finished loading Sound Manager.", Logtype.Success);

            return SoundManager;
        }
        public static SpeechManager LoadSpeechManager()
        {
            var _settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
            var _logger = ServiceLocator.Default.ResolveType<ILoggerService>();
            SpeechManager SpeechManager;

            _logger.LogString("Loading Speech Manager ... ", Logtype.Important);
            SpeechManager = new SpeechManager();
            SpeechManager.LoadAll(Path.GetDirectoryName(_settings.ExecutablePath));
            _logger.LogString("Finished loading Speech Manager.", Logtype.Success);

            return SpeechManager;
        }

    }
}
