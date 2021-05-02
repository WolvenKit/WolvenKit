using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Catel.IoC;
using Catel.Logging;
using CP77.CR2W;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.RED4.CR2W.Types;
using Newtonsoft.Json;
using WolvenKit.Functionality.Services;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.WKitGlobal;
using WolvenKit.MVVM.Model.ProjectManagement.Project;
using WolvenKit.ViewModels.Editor;

namespace WolvenKit.Functionality.Controllers
{
    public class Cp77Controller : GameControllerBase
    {
        #region Properties

        private static ArchiveManager ArchiveManager { get; set; } = new ArchiveManager();

        #endregion Properties

        #region Methods

        public override List<IGameArchiveManager> GetArchiveManagersManagers() =>
            new()
            {
                ArchiveManager
            };

        public override List<string> GetAvaliableClasses() => CR2WTypeManager.AvailableTypes.ToList();

        public override Task HandleStartup()
        {
            RegisterServices();

            var todo = new List<Func<IGameArchiveManager>>()
            {
                LoadArchiveManager,
            };
            Parallel.ForEach(todo, _ => Task.Run(_));
            return Task.CompletedTask;
        }

        public override Task<bool> PackageMod()
            => base.PackageMod();

        public override Task<bool> PackAndInstallProject()
        {
            ILog logger = LogManager.GetCurrentClassLogger();
            var projectService = ServiceLocator.Default.ResolveType<IProjectManager>();
            if (projectService.ActiveProject is not Cp77Project cp77Proj)
            {
                logger.Error("Can't pack nor install project (no project/not cyberpunk project)!");
                return Task.FromResult(false);
            }
            logger.Info("Rebuilding necessary files....");
            ModTools.Recombine(new DirectoryInfo(cp77Proj.ModDirectory), true, true, true, true, true, true);
            logger.Info("Rebuilding done, packing files into archive(s)....");
            ModTools.Pack(new DirectoryInfo(cp77Proj.ModDirectory),
                new DirectoryInfo(cp77Proj.PackedModDirectory));
            logger.Info("Packing complete!");
            InstallMod();
            return Task.FromResult(true);
        }

        private static void InstallMod()
        {
            var activeMod = MainController.Get().ActiveMod;
            ILog logger = LogManager.GetCurrentClassLogger();
            try
            {
                //Check if we have installed this mod before. If so do a little cleanup.
                if (File.Exists(activeMod.ProjectDirectory + "\\install_log.xml"))
                {
                    var log = XDocument.Load(activeMod.ProjectDirectory + "\\install_log.xml");
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
                            if (d.Attribute("Path") != null
                                && Directory.Exists(d.Attribute("Path").Value)
                                && !Directory.GetFiles(d.Attribute("Path").Value, "*", SearchOption.AllDirectories).Any())
                            {
                                Directory.Delete(d.Attribute("Path").Value, true);
                                Debug.WriteLine("Directory delete: " + d.Attribute("Path").Value);
                            }
                        }
                    }
                    //Delete the old install log. We will make a new one so this is not needed anymore.
                    File.Delete(activeMod.ProjectDirectory + "\\install_log.xml");
                }
                var installlog = new XDocument(new XElement("InstalLog", new XAttribute("Project", activeMod.Name), new XAttribute("Build_date", DateTime.Now.ToString())));
                var fileroot = new XElement("Files");
                //Copy and log the files.
                if (!Directory.Exists(Path.Combine(activeMod.ProjectDirectory, "packed")))
                {
                    logger.Error("Failed to install the mod! The packed directory doesn't exist! You forgot to tick any of the packing options?");
                    return;
                }

                //TODO: fix this once we have mod support
                /*var packedmoddir = Path.Combine(ActiveMod.ProjectDirectory, "packed", "Mods");
                if (Directory.Exists(packedmoddir))
                    fileroot.Add(Commonfunctions.DirectoryCopy(packedmoddir, MainController.Get().Configuration.CP77GameModDir, true));

                var packeddlcdir = Path.Combine(ActiveMod.ProjectDirectory, "packed", "DLC");
                if (Directory.Exists(packeddlcdir))
                    fileroot.Add(Commonfunctions.DirectoryCopy(packeddlcdir, MainController.Get().Configuration.CP77GameDlcDir, true));*/

                installlog.Root.Add(fileroot);
                //Save the log.
                installlog.Save(activeMod.ProjectDirectory + "\\install_log.xml");
                logger.Info(activeMod.Name + " installed!" + "\n");
            }
            catch (Exception ex)
            {
                //If we screwed up something. Log it.
                logger.Error(ex + "\n");
            }
        }

        private static ArchiveManager LoadArchiveManager()
        {
            var settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
            ILog logger = LogManager.GetCurrentClassLogger();

            if (!File.Exists(settings.CP77ExecutablePath))
            {
                logger.Error("Settings are not set up properly... can't load the archive manager... ");
                return null;
            }
            logger.Info("Loading archive Manager ... ");
            try
            {
                var chachePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archive_cache.bin");
                if (File.Exists(chachePath))
                {
                    using var file = File.OpenText(chachePath);
                    //var serializer = new JsonSerializer
                    //{
                    //    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    //    PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                    //    TypeNameHandling = TypeNameHandling.Auto
                    //};
                    //ArchiveManager = (ArchiveManager)serializer.Deserialize(file, typeof(ArchiveManager));

                }
                else
                {
                    ArchiveManager = new ArchiveManager();
                    ArchiveManager.LoadAll(Path.GetDirectoryName(settings.CP77ExecutablePath));
                    //File.WriteAllText(chachePath, JsonConvert.SerializeObject(ArchiveManager, Formatting.None, new JsonSerializerSettings()
                    //{
                    //    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    //    PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                    //    TypeNameHandling = TypeNameHandling.Auto
                    //}));

                    settings.ManagerVersions[(int)EManagerType.ArchiveManager] = ArchiveManager.SerializationVersion;
                }
            }
            catch (Exception e)
            {
                logger.Error("------------------------- Finished loading archive manager.");
                throw;
                

                if (File.Exists(GetManagerPath(EManagerType.ArchiveManager)))
                {
                    File.Delete(GetManagerPath(EManagerType.ArchiveManager));
                }

                ArchiveManager = new ArchiveManager();
                ArchiveManager.LoadAll(Path.GetDirectoryName(settings.CP77ExecutablePath));
            }
            logger.Info("Finished loading archive manager.");

            //start LOAD INDICATOR
            // StaticReferences.GlobalStatusBar.LoadingString = "loading";
            // init asset browser here after the manager has loaded
            var assetBrowserViewModel = (AssetBrowserViewModel)ServiceLocator.Default.ResolveType(typeof(AssetBrowserViewModel));
            assetBrowserViewModel.ReInit(false);

            return ArchiveManager;
        }

        private static void RegisterServices()
        {
            if (ServiceLocator.Default.IsTypeRegistered<IWolvenkitFileService>())
            {
                ServiceLocator.Default.RemoveType<IWolvenkitFileService>();
            }
            ServiceLocator.Default.RegisterType<IWolvenkitFileService, Cp77FileService>();
        }

        #endregion Methods
    }
}
