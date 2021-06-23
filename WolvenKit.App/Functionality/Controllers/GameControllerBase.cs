using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.Bundles;
using WolvenKit.Cache;
using WolvenKit.Common;
using WolvenKit.Functionality.WKitGlobal;
using WolvenKit.W3Strings;
using Catel.IoC;

namespace WolvenKit.Functionality.Controllers
{
    public interface IGameController
    {
        #region Properties

        private static string WKitAppData = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "REDModding","WolvenKit");

        public static string ManagerCacheDir => Path.Combine(WKitAppData, "Config");
        public static string WorkDir => Path.Combine(WKitAppData, "tmp_workdir");
        public static string XBMDumpPath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "__xbmdump_3768555366.csv");

        #endregion Properties

        #region Methods

        public void AddToMod(IGameFile file);

        public static string GetManagerPath(EManagerType type) =>
            type switch
            {
                EManagerType.BundleManager => Path.Combine(ManagerCacheDir, "bundle_cache.json"),
                EManagerType.CollisionManager => Path.Combine(ManagerCacheDir, "collision_cache.json"),
                EManagerType.SoundManager => Path.Combine(ManagerCacheDir, "sound_cache.json"),
                EManagerType.W3StringManager => Path.Combine(ManagerCacheDir, "string_cache.bin"),
                EManagerType.TextureManager => Path.Combine(ManagerCacheDir, "texture_cache.json"),
                EManagerType.ArchiveManager => Path.Combine(ManagerCacheDir, "archive_cache.json"),
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };

        public static string GetManagerVersion(EManagerType type) =>
            type switch
            {
                EManagerType.BundleManager => BundleManager.SerializationVersion,
                EManagerType.CollisionManager => CollisionManager.SerializationVersion,
                EManagerType.SoundManager => SoundManager.SerializationVersion,
                EManagerType.W3StringManager => W3StringManager.SerializationVersion,
                EManagerType.TextureManager => TextureManager.SerializationVersion,
                EManagerType.ArchiveManager => ArchiveManager.SerializationVersion,
                EManagerType.Max => throw new ArgumentOutOfRangeException(nameof(type), type, null),
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };

        public List<string> GetAvaliableClasses();

        public Task HandleStartup();

        public Task<bool> PackAndInstallProject();

        #endregion Methods

        List<IGameArchiveManager> GetArchiveManagers(bool loadmods);
        Task<bool> PackageMod();
        void InstallMod();
    }
}
