using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Catel.IoC;
using Catel.Linq;
using CP77.CR2W;
using CP77.CR2W.Types;
using Newtonsoft.Json;
using Orc.ProjectManagement;
using WolvenKit.Common;
using WolvenKit.Model;

namespace WolvenKit.Controllers
{
    using Services;
    using Bundles;
    using Cache;
    using Common.Services;
    using W3Speech;
    using W3Strings;
    using CP77.CR2W.Archive;

    public class Cp77Controller : GameControllerBase
    {
        private static ArchiveManager archiveManager { get; set; } = new ArchiveManager();

        public ArchiveManager LoadArchiveManager()
        {
            var _settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
            var _logger = ServiceLocator.Default.ResolveType<ILoggerService>();

            if (!File.Exists(_settings.CP77ExecutablePath))
            {
                _logger.LogString("Settings are not properly set up, archive manager cannot be loaded.", Logtype.Error);
                return null;
            }
            _logger.LogString("Loading archive manager... ", Logtype.Important);
            try
            {
                if (File.Exists(Cp77Controller.GetManagerPath(EManagerType.ArchiveManager)))
                {
                    using (StreamReader file = File.OpenText(Cp77Controller.GetManagerPath(EManagerType.ArchiveManager)))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                        serializer.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
                        serializer.TypeNameHandling = TypeNameHandling.Auto;
                        archiveManager = (ArchiveManager)serializer.Deserialize(file, typeof(ArchiveManager));
                    }
                }
                else
                {
                    archiveManager = new ArchiveManager();
                    archiveManager.LoadAll(Path.GetDirectoryName(_settings.CP77ExecutablePath));
                    File.WriteAllText(Cp77Controller.GetManagerPath(EManagerType.ArchiveManager), JsonConvert.SerializeObject(archiveManager, Formatting.None, new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                        PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                        TypeNameHandling = TypeNameHandling.Auto
                    }));
                    _settings.ManagerVersions[(int)EManagerType.ArchiveManager] = ArchiveManager.SerializationVersion;
                }
            }
            catch (Exception)
            {
                if (File.Exists(GetManagerPath(EManagerType.ArchiveManager)))
                    File.Delete(GetManagerPath(EManagerType.ArchiveManager));
                archiveManager = new ArchiveManager();
                archiveManager.LoadAll(Path.GetDirectoryName(_settings.CP77ExecutablePath));
            }
            _logger.LogString("Finished loading archive manager.", Logtype.Success);
            return archiveManager;
        }

        public override List<IGameArchiveManager> GetArchiveManagersManagers()
        {
            return new()
            {
                archiveManager
            };
        }

        public override List<string> GetAvaliableClasses()
        {
            return CR2WTypeManager.AvailableTypes.ToList();
        }

        public override void HandleStartup()
        {
            List<Func<IGameArchiveManager>> todo = new List<Func<IGameArchiveManager>>()
            {
                LoadArchiveManager,
            };
            Parallel.ForEach(todo, _ => Task.Run(_));
            RegisterServices();
        }

        private static void RegisterServices()
        {
            if (ServiceLocator.Default.IsTypeRegistered<IWolvenkitFileService>())
            {
                ServiceLocator.Default.RemoveType<IWolvenkitFileService>();
            }
            ServiceLocator.Default.RegisterType<IWolvenkitFileService, Cp77FileService>();
        }

        public override Task<bool> PackAndInstallProject()
        {
            var _loggerService = ServiceLocator.Default.ResolveType<ILoggerService>();
            var _projectService = ServiceLocator.Default.ResolveType<IProjectManager>();
            var cp77proj = _projectService.ActiveProject as Cp77Project;
            if (cp77proj == null)
            {
                _loggerService.LogString("Cannot pack nor install project (project not present/not CP77 project).", Logtype.Error);
                return Task.FromResult(false);
            }
            _loggerService.LogString("Rebuilding necessary files...", Logtype.Normal);
            CP77.CR2W.ModTools.Recombine(new DirectoryInfo(cp77proj.ModDirectory), true, true, true, true, true, true);
            _loggerService.LogString("Rebuilding done, packing files into archive(s)...", Logtype.Normal);
            CP77.CR2W.ModTools.Pack(new DirectoryInfo(cp77proj.ModDirectory),
                new DirectoryInfo(cp77proj.PackedModDirectory));
            _loggerService.LogString("Packing complete.", Logtype.Important);
            InstallMod();
            return Task.FromResult(true);
        }

        public override Task<bool> PackageMod()
        {
            //TODO: Create wkpackage from the mod
            return Task.FromResult(true);
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
                    XDocument log = XDocument.Load(ActiveMod.ProjectDirectory + "\\install_log.xml");
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
                    _logger.LogString("Failed to install mod. Packed directory does not exist. Check packing options.", Logtype.Important);
                    return;
                }

                var packedmoddir = Path.Combine(ActiveMod.ProjectDirectory, "packed", "Mods");
                if (Directory.Exists(packedmoddir))
                    fileroot.Add(Commonfunctions.DirectoryCopy(packedmoddir, MainController.Get().Configuration.GameModDir, true));

                var packeddlcdir = Path.Combine(ActiveMod.ProjectDirectory, "packed", "DLC");
                if (Directory.Exists(packeddlcdir))
                    fileroot.Add(Commonfunctions.DirectoryCopy(packeddlcdir, MainController.Get().Configuration.GameDlcDir, true));


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
    }
}
