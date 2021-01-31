using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CP77.CR2W.Archive;
using WolvenKit.Bundles;
using WolvenKit.Cache;
using WolvenKit.Common;
using WolvenKit.W3Strings;

namespace WolvenKit.Controllers
{
    public abstract class GameControllerBase
    {
        public static string ManagerCacheDir => Path.Combine(AppContext.BaseDirectory, "ManagerCache");
        public static string WorkDir => Path.Combine(AppContext.BaseDirectory, "tmp_workdir");
        public static string XBMDumpPath => Path.Combine(ManagerCacheDir, "__xbmdump_3768555366.csv");

        public abstract List<IGameArchiveManager> GetArchiveManagersManagers();

        public abstract void HandleStartup();

        public static string GetManagerPath(EManagerType type)
        {
            switch (type)
            {
                case EManagerType.BundleManager: return Path.Combine(ManagerCacheDir, "bundle_cache.json");
                case EManagerType.CollisionManager: return Path.Combine(ManagerCacheDir, "collision_cache.json");
                case EManagerType.SoundManager: return Path.Combine(ManagerCacheDir, "sound_cache.json");
                case EManagerType.W3StringManager: return Path.Combine(ManagerCacheDir, "string_cache.bin");
                case EManagerType.TextureManager: return Path.Combine(ManagerCacheDir, "texture_cache.json");
                case EManagerType.ArchiveManager: return Path.Combine(ManagerCacheDir, "archive_cache.json");
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
                case EManagerType.ArchiveManager: return ArchiveManager.SerializationVersion;
                case EManagerType.Max:
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}
