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
    using CP77.CR2W.Archive;

    public static class Cp77Controller
    {

        public static string ManagerCacheDir => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "ManagerCache");
        public static string WorkDir => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "tmp_workdir");
        //private static string DepotZipPath => Path.Combine(ManagerCacheDir, "Depot.zip");
        public static string XBMDumpPath => Path.Combine(ManagerCacheDir, "__xbmdump_3768555366.csv");


        public static ArchiveManager LoadArchiveManager()
        {
            var _settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
            var _logger = ServiceLocator.Default.ResolveType<ILoggerService>();
            ArchiveManager archiveManager;

            _logger.LogString("Loading Archive Manager ... ", Logtype.Important);
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
                        archiveManager = (ArchiveManager)serializer.Deserialize(file, typeof(BundleManager));
                    }
                }
                else
                {
                    archiveManager = new ArchiveManager();
                    archiveManager.LoadAll(Path.GetDirectoryName(_settings.ExecutablePath));
                    File.WriteAllText(Tw3Controller.GetManagerPath(EManagerType.BundleManager), JsonConvert.SerializeObject(archiveManager, Formatting.None, new JsonSerializerSettings()
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
                archiveManager = new ArchiveManager();
                archiveManager.LoadAll(Path.GetDirectoryName(_settings.ExecutablePath));
            }
            _logger.LogString("Finished loading Bundle Manager.", Logtype.Success);
            return archiveManager;
        }
    }
}
