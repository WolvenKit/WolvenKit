using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using DynamicData;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.Common.Tools.Oodle;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;
using WolvenKit.MVVM.Model.ProjectManagement.Project;
using WolvenKit.RED4.CR2W.Types;
using WolvenKit.RED4.TweakDB;

namespace WolvenKit.Functionality.Controllers
{
    public class RED4Controller : ReactiveObject, IGameController
    {
        #region fields

        public const string GameVersion = "1.3.0";

        private readonly ILoggerService _loggerService;
        private readonly IProjectManager _projectManager;
        private readonly ISettingsManager _settingsManager;
        private readonly IHashService _hashService;
        private readonly IModTools _modTools;
        private readonly IArchiveManager _archiveManager;

        private readonly SourceList<RedFileSystemModel> _rootCache;

        #endregion

        public RED4Controller(ILoggerService loggerService,
            IProjectManager projectManager,
            ISettingsManager settingsManager,
            IHashService hashService,
            IModTools modTools,
            IArchiveManager gameArchiveManager
            )
        {
            _loggerService = loggerService;
            _projectManager = projectManager;
            _settingsManager = settingsManager;
            _hashService = hashService;
            _modTools = modTools;
            _archiveManager = gameArchiveManager;

            _rootCache = new SourceList<RedFileSystemModel>();
        }

        #region Properties

        [Reactive] public bool IsManagerLoaded { get; set; }

        //public IObservable<IChangeSet<RedDirectoryViewModel, ulong>> ConnectHierarchy() => _rootCache.Connect();
        public IObservable<IChangeSet<RedFileSystemModel>> ConnectHierarchy() => _rootCache.Connect();

        #endregion Properties

        #region Methods

        public Task HandleStartup()
        {
            if (!OodleLoadLib.Load(_settingsManager.GetRED4OodleDll()))
            {
                throw new FileNotFoundException($"oo2ext_7_win64.dll not found.");
            }

            var todo = new List<Func<IArchiveManager>>()
            {
                LoadArchiveManager,
            };
            Parallel.ForEach(todo, _ => Task.Run(_));
            return Task.CompletedTask;
        }

        private IArchiveManager LoadArchiveManager()
        {
            if (_archiveManager != null && IsManagerLoaded)
            {
                return _archiveManager;
            }

            _loggerService.Info("Loading archive Manager ... ");
            //var chachePath = Path.Combine(ISettingsManager.GetAppData(), "archive_cache.bin");
            try
            {
                //if (File.Exists(chachePath))
                //{
                //    var sw = new Stopwatch();
                //    sw.Start();

                //    using var file = File.OpenRead(chachePath);
                //    ArchiveManager = Serializer.Deserialize<ArchiveManager>(file);

                //    sw.Stop();
                //    var ms = sw.ElapsedMilliseconds;

                //    if (!ArchiveManager.GameVersion.Equals(GameVersion))
                //    {
                //        throw new NotSupportedException(ArchiveManager.GameVersion.ToString());
                //    }
                //}
                //else
                {
                    var sw = new Stopwatch();
                    sw.Start();

                    _archiveManager.LoadAll(new FileInfo(_settingsManager.CP77ExecutablePath));

                    sw.Stop();
                    var ms = sw.ElapsedMilliseconds;

                    //using var file = File.Create(chachePath);
                    //Serializer.Serialize(file, ArchiveManager);

                    //_settingsManager.ManagerVersions[(int)EManagerType.ArchiveManager] =
                    //    ArchiveManager.SerializationVersion;
                }
            }
            catch (Exception e)
            {
                _loggerService.Log(e.Message);
                throw;


                //ArchiveManager = new ArchiveManager(_hashService) /*{ GameVersion = GameVersion }*/;
                //ArchiveManager.LoadAll(new FileInfo(_settingsManager.CP77ExecutablePath));

                //using var file = File.Create(chachePath);
                //Serializer.Serialize(file, ArchiveManager);

                //_settingsManager.ManagerVersions[(int)EManagerType.ArchiveManager] =
                //    ArchiveManager.SerializationVersion;
            }
            finally
            {
                IsManagerLoaded = true;
                _loggerService.Success("Finished loading archive manager.");
            }
            
            _rootCache.Edit(innerCache =>
            {
                innerCache.Clear();
                //innerCache.AddOrUpdate(ArchiveManager.RootNode);
                innerCache.Add(_archiveManager.RootNode);
            });

            return _archiveManager;
        }

        public List<string> GetAvaliableClasses() => CR2WTypeManager.AvailableTypes.ToList();

        public Task<bool> PackageMod()
        {
            throw new NotImplementedException();


            //var pwm = ServiceLocator.Default.ResolveType<Models.Wizards.PublishWizardModel>();
            //var headerBackground = System.Drawing.Color.FromArgb(
            //    pwm.HeaderBackground.A,
            //    pwm.HeaderBackground.R,
            //    pwm.HeaderBackground.G,
            //    pwm.HeaderBackground.B
            //);
            //var iconBackground = System.Drawing.Color.FromArgb(
            //    pwm.IconBackground.A,
            //    pwm.IconBackground.R,
            //    pwm.IconBackground.G,
            //    pwm.IconBackground.B
            //);
            //var author = Tuple.Create<string, string, string, string, string, string>(
            //    _projectManager.ActiveProject.Author, null, pwm.WebsiteLink, pwm.FacebookLink, pwm.TwitterLink, pwm.YoutubeLink
            //);
            //var package = Common.Model.Packaging.WKPackage.CreateModAssembly(
            //    _projectManager.ActiveProject.Version,
            //    _projectManager.ActiveProject.Name,
            //    author,
            //    pwm.Description,
            //    pwm.LargeDescription,
            //    pwm.License,
            //    (headerBackground, pwm.UseBlackText, iconBackground).ToTuple(),
            //    new List<System.Xml.Linq.XElement> { }
            //);

            //return Task.FromResult(true);
        }

        /// <summary>
        /// packs redengine files in the mod project and installs it into the game mod directory
        /// </summary>
        /// <returns></returns>
        public Task<bool> PackAndInstallProject()
        {
            if (_projectManager.ActiveProject is not Cp77Project cp77Proj)
            {
                _loggerService.Error("Can't pack nor install project (no project/not cyberpunk project)!");
                return Task.FromResult(false);
            }

            try
            {
                Directory.Delete(cp77Proj.PackedModDirectory, true);
            }
            catch
            {

            }

            // pack mod
            var modfiles = Directory.GetFiles(cp77Proj.ModDirectory, "*", SearchOption.AllDirectories);
            if (modfiles.Any())
            {
                _modTools.Pack(
                    new DirectoryInfo(cp77Proj.ModDirectory),
                    new DirectoryInfo(cp77Proj.PackedModDirectory),
                    $"mod{cp77Proj.Name}");
                _loggerService.Info("Packing complete!");
            }

            // compile tweak files
            CompileTweakFiles(cp77Proj);

            InstallMod();

            return Task.FromResult(true);
        }

        private void CompileTweakFiles(Cp77Project cp77Proj)
        {
            var tweakFiles = Directory.GetFiles(cp77Proj.TweakDirectory, "*.tweak", SearchOption.AllDirectories);
            foreach (var f in tweakFiles)
            {
                var json = File.ReadAllText(f);
                var filename = Path.GetFileNameWithoutExtension(f) + ".bin";
                var outPath = Path.Combine(cp77Proj.PackedTweakDirectory, filename);

                if (RED4.TweakDB.Serialization.Serialization.TryParseJsonFlatsDict(json, out var dict))
                {
                    var db = new TweakDB();
                    foreach (var (key, value) in dict)
                    {
                        db.Add(key, value);
                    }
                    db.Save(outPath);
                }
            }
        }

        /// <summary>
        /// Copies the contents of the "packed" folder into the game mod directory
        /// </summary>
        public void InstallMod()
        {
            var activeMod = _projectManager.ActiveProject;
            var logPath = Path.Combine(activeMod.ProjectDirectory, "install_log.xml");

            try
            {
                //Check if we have installed this mod before. If so do a little cleanup.
                if (File.Exists(logPath))
                {
                    var log = XDocument.Load(logPath);
                    var dirs = log.Root.Element("Files")?.Descendants("Directory").ToList();
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
                    File.Delete(logPath);
                }

                var installlog = new XDocument(
                    new XElement("InstalLog",
                        new XAttribute("Project", activeMod.Name),
                        new XAttribute("Build_date", DateTime.Now.ToString())
                        ));
                var fileroot = new XElement("Files");

                //Copy and log the files.
                var packedmoddir = activeMod.PackedRootDirectory;
                if (!Directory.Exists(packedmoddir))
                {
                    _loggerService.Error("Failed to install the mod! The packed directory doesn't exist!");
                    return;
                }

                fileroot.Add(Commonfunctions.DirectoryCopy(packedmoddir, _settingsManager.GetRED4GameRootDir(), true));

                //var packeddlcdir = Path.Combine(ActiveMod.ProjectDirectory, "packed", "DLC");
                //if (Directory.Exists(packeddlcdir))
                //    fileroot.Add(Commonfunctions.DirectoryCopy(packeddlcdir, MainController.Get().Configuration.CP77GameDlcDir, true));

                installlog.Root.Add(fileroot);
                installlog.Save(logPath);
                _loggerService.Info(activeMod.Name + " installed!" + "\n");
            }
            catch (Exception ex)
            {
                //If we screwed up something. Log it.
                _loggerService.Error(ex + "\n");
            }
        }

        public void AddToMod(ulong hash)
        {
            var file = _archiveManager.LookupFile(hash);
            if (file != null)
            {
                AddToMod(file);
            } 
        }

        public void AddToMod(IGameFile file)
        {
            var project = _projectManager.ActiveProject;
            switch (project.GameType)
            {
                case GameType.Witcher3:
                {
                    //if (project is Tw3Project witcherProject)
                    //{
                    //    var diskPathInfo = new FileInfo(Path.Combine(witcherProject.ModCookedDirectory, file.Name));
                    //    if (diskPathInfo.Directory == null)
                    //    {
                    //        break;
                    //    }

                    //    Directory.CreateDirectory(diskPathInfo.Directory.FullName);
                    //    using var fs = new FileStream(diskPathInfo.FullName, FileMode.Create);
                    //    file.Extract(fs);
                    //}
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
