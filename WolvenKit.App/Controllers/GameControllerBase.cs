using System;
using System.IO;
using System.Threading.Tasks;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal;

namespace WolvenKit.Functionality.Controllers
{
    public interface IGameController
    {
        #region Methods
        public void AddToMod(ulong hash);
        public void AddToMod(IGameFile file);

        public static string GetManagerPath(EManagerType type)
        {
            var path = type switch
            {
                EManagerType.BundleManager => Path.Combine(ISettingsManager.GetManagerCacheDir(), "bundle_cache.json"),
                EManagerType.CollisionManager => Path.Combine(ISettingsManager.GetManagerCacheDir(),
                    "collision_cache.json"),
                EManagerType.SoundManager => Path.Combine(ISettingsManager.GetManagerCacheDir(), "sound_cache.json"),
                EManagerType.W3StringManager => Path.Combine(ISettingsManager.GetManagerCacheDir(), "string_cache.bin"),
                EManagerType.TextureManager => Path.Combine(ISettingsManager.GetManagerCacheDir(),
                    "texture_cache.json"),
                EManagerType.ArchiveManager => Path.Combine(ISettingsManager.GetManagerCacheDir(), "archive_cache.bin"),
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };



            return path;
        }

        //public static string GetManagerVersion(EManagerType type) =>
        //    type switch
        //    {
        //        EManagerType.BundleManager => BundleManager.SerializationVersion,
        //        EManagerType.CollisionManager => CollisionManager.SerializationVersion,
        //        EManagerType.SoundManager => SoundManager.SerializationVersion,
        //        EManagerType.W3StringManager => W3StringManager.SerializationVersion,
        //        EManagerType.TextureManager => TextureManager.SerializationVersion,
        //        EManagerType.ArchiveManager => ArchiveManager.SerializationVersion,
        //        EManagerType.Max => throw new ArgumentOutOfRangeException(nameof(type), type, null),
        //        _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        //    };

        //public List<string> GetAvaliableClasses();

        public Task HandleStartup();

        public Task<bool> PackAndInstallProject();

        public Task<bool> PackAndInstallRunProject();

        public Task<bool> HotInstallProject();

        Task<bool> PackProject();

        void InstallMod();

        #endregion Methods
    }
}
