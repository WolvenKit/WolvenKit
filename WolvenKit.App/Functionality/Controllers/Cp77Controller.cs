using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;
using Catel.IoC;
using CP77.CR2W;
using ProtoBuf;
using WolvenKit.Bundles;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Common.Tools.Oodle;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.MVVM.Model.ProjectManagement.Project;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.RED4.CR2W.Types;
using WolvenKit.ViewModels.Editor;
using ModTools = WolvenKit.Modkit.RED4.ModTools;

namespace WolvenKit.Functionality.Controllers
{
    public class Cp77Controller : IGameController
    {
        private readonly ILoggerService _loggerService;
        private readonly IProjectManager _projectManager;
        private readonly ISettingsManager _settingsManager;
        private readonly ModTools _modTools;
        private readonly IHashService _hashService;




        public Cp77Controller(ILoggerService loggerService,
            IProjectManager projectManager,
            ISettingsManager settingsManager,
            IHashService hashService,
            ModTools modTools
            )
        {
            _loggerService = loggerService;
            _projectManager = projectManager;
            _settingsManager = settingsManager;
            _hashService = hashService;
            _modTools = modTools;
        }

        #region Properties

        private static ArchiveManager ArchiveManager { get; set; }

        #endregion Properties

        #region Methods

        public Task HandleStartup()
        {
            var dir = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            var destFileName = Path.Combine(dir, "oo2ext_7_win64.dll");
            if (!OodleLoadLib.Load(destFileName))
            {
                throw new MissingCompressionException($"oo2ext_7_win64.dll not found in {dir}");
            }

            var todo = new List<Func<IGameArchiveManager>>()
            {
                LoadArchiveManager,
            };
            Parallel.ForEach(todo, _ => Task.Run(_));
            return Task.CompletedTask;
        }

        public List<IGameArchiveManager> GetArchiveManagersManagers(bool loadmods) =>
            new()
            {
                ArchiveManager
            };

        private ArchiveManager LoadArchiveManager()
        {
            var assetBrowserViewModel = (AssetBrowserViewModel)ServiceLocator.Default.ResolveType(typeof(AssetBrowserViewModel));
            assetBrowserViewModel.LoadVisibility = Visibility.Visible;

            if (!File.Exists(_settingsManager.CP77ExecutablePath))
            {
                _loggerService.Error("Settings are not set up properly... can't load the archive manager... ");
                return null;
            }
            _loggerService.Info("Loading archive Manager ... ");
            var chachePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archive_cache.bin");
            try
            {

                if (File.Exists(chachePath))
                {
                    using var file = File.OpenRead(chachePath);
                    ArchiveManager = Serializer.Deserialize<ArchiveManager>(file);
                }
                else
                {
                    ArchiveManager = new ArchiveManager(_hashService);
                    ArchiveManager.LoadAll(Path.GetDirectoryName(_settingsManager.CP77ExecutablePath));

                    using var file = File.Create(chachePath);
                    Serializer.Serialize(file, ArchiveManager);

                    _settingsManager.ManagerVersions[(int)EManagerType.ArchiveManager] = ArchiveManager.SerializationVersion;
                }
            }
            catch (Exception e)
            {
                _loggerService.Log(e.Message);
                ArchiveManager = new ArchiveManager(_hashService);
                ArchiveManager.LoadAll(Path.GetDirectoryName(_settingsManager.CP77ExecutablePath));

                using var file = File.Create(chachePath);
                Serializer.Serialize(file, ArchiveManager);

                _settingsManager.ManagerVersions[(int)EManagerType.ArchiveManager] = ArchiveManager.SerializationVersion;
            }
            _loggerService.Info("Finished loading archive manager.");

            //start LOAD INDICATOR
            // StaticReferences.GlobalStatusBar.LoadingString = "loading";
            // init asset browser here after the manager has loaded
            //var assetBrowserViewModel = (AssetBrowserViewModel)ServiceLocator.Default.ResolveType(typeof(AssetBrowserViewModel));
            assetBrowserViewModel.ReInit(false);

            return ArchiveManager;
        }


        public List<string> GetAvaliableClasses() => CR2WTypeManager.AvailableTypes.ToList();



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

        public Task<bool> PackAndInstallProject()
        {

            if (_projectManager.ActiveProject is not Cp77Project cp77Proj)
            {
                _loggerService.Error("Can't pack nor install project (no project/not cyberpunk project)!");
                return Task.FromResult(false);
            }

            // rebuilding is done manually in the import/export util
            //_loggerService.Info("Rebuilding necessary files....");
            //_modTools.Recombine(new DirectoryInfo(cp77Proj.ModDirectory), true, true, true, true);
            //_loggerService.Info("Rebuilding done, packing files into archive(s)....");


            _modTools.Pack(new DirectoryInfo(cp77Proj.ModDirectory),
                new DirectoryInfo(cp77Proj.PackedModDirectory));
            _loggerService.Info("Packing complete!");
            InstallMod();
            return Task.FromResult(true);
        }

        public void InstallMod()
        {
            var activeMod = _projectManager.ActiveProject;

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
                    _loggerService.Error("Failed to install the mod! The packed directory doesn't exist! You forgot to tick any of the packing options?");
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
                _loggerService.Info(activeMod.Name + " installed!" + "\n");
            }
            catch (Exception ex)
            {
                //If we screwed up something. Log it.
                _loggerService.Error(ex + "\n");
            }
        }

        public void AddToMod(IGameFile file)
        {
            var project = _projectManager.ActiveProject;
            NotificationHelper.Growl.Info($"Added file: {file.Name} to project: {project.Name} ");

            switch (project.GameType)
            {
                case GameType.Witcher3:
                {
                    if (project is Tw3Project witcherProject)
                    {
                        var diskPathInfo = new FileInfo(Path.Combine(witcherProject.ModCookedDirectory, file.Name));
                        if (diskPathInfo.Directory == null)
                        {
                            break;
                        }

                        Directory.CreateDirectory(diskPathInfo.Directory.FullName);
                        using var fs = new FileStream(diskPathInfo.FullName, FileMode.Create);
                        file.Extract(fs);
                    }
                    break;
                }
                case GameType.Cyberpunk2077:
                {
                    if (project is Cp77Project cyberpunkProject)
                    {
                        var diskPathInfo = new FileInfo(Path.Combine(cyberpunkProject.ModDirectory, file.Name));
                        if (diskPathInfo.Directory == null)
                        {
                            break;
                        }

                        Directory.CreateDirectory(diskPathInfo.Directory.FullName);
                        using var fs = new FileStream(diskPathInfo.FullName, FileMode.Create);
                        file.Extract(fs);
                    }

                    break;
                }
                default:
                    break;
            }
        }

        #endregion Methods
    }
}
