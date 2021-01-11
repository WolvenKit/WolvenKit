using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Catel.IoC;
using CP77.CR2W.Archive;
using Newtonsoft.Json;
using ProtoBuf;
using WolvenKit.Common;

namespace WolvenKit.Controllers
{
    using Services;
    using Bundles;
    using Cache;
    using Common.Services;
    using W3Speech;
    using W3Strings;
    public class Tw3Controller : GameControllerBase
    {
        private static BundleManager bundleManager;
        private static W3StringManager w3StringManager;
        private static TextureManager textureManager;
        private static CollisionManager collisionManager;
        private static SoundManager soundManager;
        private static SpeechManager speechManager;



        public static BundleManager LoadBundleManager()
        {
            var _settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
            var _logger = ServiceLocator.Default.ResolveType<ILoggerService>();

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
                        bundleManager = (BundleManager)serializer.Deserialize(file, typeof(BundleManager));
                    }
                }
                else
                {
                    bundleManager = new BundleManager();
                    bundleManager.LoadAll(Path.GetDirectoryName(_settings.ExecutablePath));
                    File.WriteAllText(Tw3Controller.GetManagerPath(EManagerType.BundleManager), JsonConvert.SerializeObject(bundleManager, Formatting.None, new JsonSerializerSettings()
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
                bundleManager = new BundleManager();
                bundleManager.LoadAll(Path.GetDirectoryName(_settings.ExecutablePath));
            }
            _logger.LogString("Finished loading Bundle Manager.", Logtype.Success);
            return bundleManager;
        }
        public static W3StringManager LoadStringsManager()
        {
            var _settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
            var _logger = ServiceLocator.Default.ResolveType<ILoggerService>();

            _logger.LogString("Loading Strings Manager ... ", Logtype.Important);
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
                    w3StringManager.Load(_settings.TextLanguage, Path.GetDirectoryName(_settings.ExecutablePath));
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
                    File.Delete(Tw3Controller.GetManagerPath(EManagerType.W3StringManager));
                w3StringManager = new W3StringManager();
                w3StringManager.Load(_settings.TextLanguage, Path.GetDirectoryName(_settings.ExecutablePath));
            }
            _logger.LogString("Finished loading Strings Manager.", Logtype.Success);
            return w3StringManager;

        }
        public static TextureManager LoadTextureManager()
        {
            var _settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
            var _logger = ServiceLocator.Default.ResolveType<ILoggerService>();

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
                        textureManager = (TextureManager)serializer.Deserialize(file, typeof(TextureManager));
                    }
                }
                else
                {
                    textureManager = new TextureManager();
                    textureManager.LoadAll(Path.GetDirectoryName(_settings.ExecutablePath));
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
                    File.Delete(Tw3Controller.GetManagerPath(EManagerType.TextureManager));
                textureManager = new TextureManager();
                textureManager.LoadAll(Path.GetDirectoryName(_settings.ExecutablePath));
            }
            _logger.LogString("Finished loading Texture Manager.", Logtype.Success);

            return textureManager;
        }
        public static CollisionManager LoadCollisionManager()
        {
            var _settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
            var _logger = ServiceLocator.Default.ResolveType<ILoggerService>();

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
                        collisionManager = (CollisionManager)serializer.Deserialize(file, typeof(CollisionManager));
                    }
                }
                else
                {
                    collisionManager = new CollisionManager();
                    collisionManager.LoadAll(Path.GetDirectoryName(_settings.ExecutablePath));
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
                    File.Delete(Tw3Controller.GetManagerPath(EManagerType.CollisionManager));
                collisionManager = new CollisionManager();
                collisionManager.LoadAll(Path.GetDirectoryName(_settings.ExecutablePath));
            }
            _logger.LogString("Finished loading Collision Manager.", Logtype.Success);

            return collisionManager;
        }
        public static SoundManager LoadSoundManager()
        {
            var _settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
            var _logger = ServiceLocator.Default.ResolveType<ILoggerService>();

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
                        soundManager = (SoundManager)serializer.Deserialize(file, typeof(SoundManager));
                    }
                }
                else
                {
                    soundManager = new SoundManager();
                    soundManager.LoadAll(Path.GetDirectoryName(_settings.ExecutablePath));
                    File.WriteAllText(Tw3Controller.GetManagerPath(EManagerType.SoundManager), JsonConvert.SerializeObject(soundManager, Formatting.None, new JsonSerializerSettings()
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
                soundManager = new SoundManager();
                soundManager.LoadAll(Path.GetDirectoryName(_settings.ExecutablePath));
            }
            _logger.LogString("Finished loading Sound Manager.", Logtype.Success);

            return soundManager;
        }
        public static SpeechManager LoadSpeechManager()
        {
            var _settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
            var _logger = ServiceLocator.Default.ResolveType<ILoggerService>();

            _logger.LogString("Loading Speech Manager ... ", Logtype.Important);
            speechManager = new SpeechManager();
            speechManager.LoadAll(Path.GetDirectoryName(_settings.ExecutablePath));
            _logger.LogString("Finished loading Speech Manager.", Logtype.Success);

            return speechManager;
        }

        public override List<IGameArchiveManager> GetArchiveManagersManagers()
        {
            return new ()
            {
                bundleManager,
                textureManager,
                collisionManager,
                soundManager,
                speechManager
            };
        }

        public override void HandleStartup()
        {
            List<Func<IGameArchiveManager>> todo = new List<Func<IGameArchiveManager>>()
            {
                LoadBundleManager,
                LoadTextureManager,
                LoadCollisionManager,
                LoadSoundManager,
                LoadSpeechManager
            };
            Parallel.ForEach(todo, _ => Task.Run(_));
        }
    }
}
