using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;
using ReactiveUI;
using Splat;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Services;
using WolvenKit.Core.Compression;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Functionality.Services;
using WolvenKit.Helpers;
using WolvenKit.Models;
using WolvenKit.ProjectManagement.Project;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.Functionality.Controllers
{
    public class RED4Controller : ReactiveObject, IGameController
    {
        #region fields

        public const string GameVersion = "1.5.0";

        private readonly ILoggerService _loggerService;
        private readonly INotificationService _notificationService;
        private readonly IProjectManager _projectManager;
        private readonly ISettingsManager _settingsManager;
        private readonly IHashService _hashService;
        private readonly IModTools _modTools;
        private readonly IArchiveManager _archiveManager;
        private readonly IProgressService<double> _progressService;
        private readonly IPluginService _pluginService;

        private bool _initialized = false;

        #endregion

        public RED4Controller(
            ILoggerService loggerService,
            INotificationService notificationService,
            IProjectManager projectManager,
            ISettingsManager settingsManager,
            IHashService hashService,
            IModTools modTools,
            IArchiveManager gameArchiveManager,
            IProgressService<double> progressService,
            IPluginService pluginService
            )
        {
            _notificationService = notificationService;
            _loggerService = loggerService;
            _projectManager = projectManager;
            _settingsManager = settingsManager;
            _hashService = hashService;
            _modTools = modTools;
            _archiveManager = gameArchiveManager;
            _progressService = progressService;
            _pluginService = pluginService;
        }

        #region Methods

        public Task HandleStartup()
        {
            if (!_initialized)
            {
                _initialized = true;

                // load archives
                var todo = new List<Func<IArchiveManager>>()
                {
                    LoadArchiveManager,
                };
                Parallel.ForEach(todo, _ => Task.Run(_));

                // requires oodle
                InitializeBk();

            }

            return Task.CompletedTask;
        }

        // TODO: Move this somewhere else
        private void LoadCustomHashes()
        {
            var parser = Locator.Current.GetService<Red4ParserService>();

            CName physMatLibPath = "base\\physics\\physicsmaterials.physmatlib";
            CName presetPath = "engine\\physics\\collision_presets.json";

            var physMatLib = _archiveManager.Lookup(physMatLibPath);
            if (physMatLib.HasValue)
            {
                using var ms = new MemoryStream();
                physMatLib.Value.Extract(ms);
                ms.Position = 0;

                if (parser.TryReadRed4File(ms, out var file))
                {
                    var root = (physicsMaterialLibraryResource)file.RootChunk;

                    foreach (var physMat in root.Unk1)
                    {
                        _hashService.AddCustom(physMat);
                    }
                }
            }

            var preset = _archiveManager.Lookup(presetPath);
            if (preset.HasValue)
            {
                using var ms = new MemoryStream();
                preset.Value.Extract(ms);
                ms.Position = 0;

                if (parser.TryReadRed4File(ms, out var file))
                {
                    var root = (JsonResource)file.RootChunk;
                    var res = (physicsCollisionPresetsResource)root.Root.Chunk;

                    foreach (var presetEntry in res.Presets)
                    {
                        _hashService.AddCustom(presetEntry.Name);
                    }
                }
            }
        }

        private void InitializeBk()
        {
            string[] binkhelpers = { @"Resources\Media\t1.kark", @"Resources\Media\t2.kark", @"Resources\Media\t3.kark", @"Resources\Media\t4.kark", @"Resources\Media\t5.kark" };

            if (string.IsNullOrEmpty(_settingsManager.GetRED4GameRootDir()))
            {
                Trace.WriteLine("That worked to cancel Loading oodle! :D");
                return;
            }

            foreach (var path in binkhelpers)
            {
                switch (path)
                {
                    case @"Resources\Media\t1.kark":
                        if (!File.Exists(Path.Combine(ISettingsManager.GetWorkDir(), "test.exe")))
                        {
                            _ = Oodle.OodleTask(path, Path.Combine(ISettingsManager.GetWorkDir(), "test.exe"), true,
                                false);
                        }

                        break;

                    case @"Resources\Media\t2.kark":
                        if (!File.Exists(Path.Combine(ISettingsManager.GetWorkDir(), "testconv.exe")))
                        {
                            _ = Oodle.OodleTask(path, Path.Combine(ISettingsManager.GetWorkDir(), "testconv.exe"), true,
                                false);
                        }

                        break;

                    case @"Resources\Media\t3.kark":
                        if (!File.Exists(Path.Combine(ISettingsManager.GetWorkDir(), "testc.exe")))
                        {
                            _ = Oodle.OodleTask(path, Path.Combine(ISettingsManager.GetWorkDir(), "testc.exe"), true,
                                false);
                        }

                        break;

                    case @"Resources\Media\t4.kark":
                        if (!File.Exists(Path.Combine(ISettingsManager.GetWorkDir(), "radutil.dll")))
                        {
                            _ = Oodle.OodleTask(path, Path.Combine(ISettingsManager.GetWorkDir(), "radutil.dll"), true,
                                false);
                        }

                        break;

                    case @"Resources\Media\t5.kark":
                        if (!File.Exists(Path.Combine(ISettingsManager.GetWorkDir(), "bink2make.dll")))
                        {
                            _ = Oodle.OodleTask(path, Path.Combine(ISettingsManager.GetWorkDir(), "bink2make.dll"), true,
                                false);
                        }

                        break;
                }
            }
        }

        private IArchiveManager LoadArchiveManager()
        {
            if (_archiveManager != null && _archiveManager.IsManagerLoaded)
            {
                return _archiveManager;
            }

            _loggerService.Info("Loading Archive Manager ... ");
            try
            {
                _archiveManager.LoadGameArchives(new FileInfo(_settingsManager.CP77ExecutablePath));
            }
            catch (Exception e)
            {
                _loggerService.Error(e);
                throw;
            }
            finally
            {
                _loggerService.Success("Finished loading Archive Manager.");
            }

            LoadCustomHashes();

#pragma warning disable 162
            return _archiveManager;
#pragma warning restore 162
        }

        /// <summary>
        /// packs redengine files in the mod project and installs it into the game mod directory
        /// </summary>
        /// <returns></returns>
        public async Task<bool> PackAndInstallProject()
        {
            if (_projectManager.ActiveProject is not Cp77Project cp77Proj)
            {
                _loggerService.Error("Can't pack project (no project/not cyberpunk project)!");
                return false;
            }

            _progressService.IsIndeterminate = true;

            if (!PackProject())
            {
                _progressService.IsIndeterminate = false;
                return false;
            }

            InstallMod();

            if (cp77Proj.IsRedMod && cp77Proj.ExecuteDeploy)
            {
                await DeployRedmod();
            }

            _progressService.IsIndeterminate = false;
            return true;
        }

        public async Task<bool> PackAndInstallRunProject()
        {
            if (_projectManager.ActiveProject is not Cp77Project cp77Proj)
            {
                _loggerService.Error("Can't pack project (no project/not cyberpunk project)!");
                return false;
            }

            _progressService.IsIndeterminate = true;

            if (!PackProjectNoBackup())
            {
                _progressService.IsIndeterminate = false;
                return false;
            }

            InstallMod();

            if (cp77Proj.IsRedMod && cp77Proj.ExecuteDeploy)
            {
                await DeployRedmod();
            }

            _progressService.IsIndeterminate = false;
            return true;
        }

        public bool HotInstallProject()
        {
            _progressService.IsIndeterminate = true;

            if (!PackProjectHot())
            {
                _progressService.IsIndeterminate = false;
                return false;
            }

            _progressService.IsIndeterminate = false;

            return true;
        }

        public Task<bool> DeployRedmod()
        {
            if (!_pluginService.IsInstalled(EPlugin.redmod))
            {
                return Task.FromResult(false);
            }

            // compile with redmod
            var redmodPath = Path.Combine(_settingsManager.GetRED4GameRootDir(), "tools", "redmod", "bin", "redMod.exe");
            if (File.Exists(redmodPath))
            {
                var rttiSchemaPath = Path.Combine(_settingsManager.GetRED4GameRootDir(), "tools", "redmod", "metadata.json");
                var args = $"deploy -root=\"{_settingsManager.GetRED4GameRootDir()}\" -rttiSchemaPath=\"{rttiSchemaPath}\"";

                _loggerService.Info($"WorkDir: {redmodPath}");
                _loggerService.Info($"Running commandlet: {args}");
                return ProcessUtil.RunProcessAsync(redmodPath, args);
            }

            return Task.FromResult(true);
        }

        public List<string> GetModFiles()
        {
            if (_projectManager.ActiveProject is not Cp77Project cp77Proj)
            {
                _loggerService.Error("Can't pack project (no project/not cyberpunk project)!");
                return new List<string>();
            }

            return cp77Proj.ModFiles;
        }

        /// <summary>
        /// pack mod to mod workspace folder
        /// </summary>
        /// <returns></returns>
        public bool PackProject()
        {

            if (_projectManager.ActiveProject is not Cp77Project cp77Proj)
            {
                _loggerService.Error("Can't pack project (no project/not cyberpunk project)!");
                return false;
            }

            // cleanup
            try
            {
                var archives = Directory.GetFiles(cp77Proj.PackedArchiveDirectory, "*.archive");
                foreach (var archive in archives)
                {
                    File.Delete(archive);
                }
            }
            catch (Exception e)
            {
                _loggerService.Error(e);
            }

            // pack mod
            var modfiles = Directory.GetFiles(cp77Proj.ModDirectory, "*", SearchOption.AllDirectories);
            if (modfiles.Any())
            {
                _modTools.Pack(
                    new DirectoryInfo(cp77Proj.ModDirectory),
                    new DirectoryInfo(cp77Proj.PackedArchiveDirectory),
                    cp77Proj.Name);
                _loggerService.Info("Packing archives complete!");
            }
            _loggerService.Success($"{cp77Proj.Name} packed into {cp77Proj.PackedArchiveDirectory}");


            // compile tweak files
            CompileTweakFiles(cp77Proj);

            if (cp77Proj.IsRedMod)
            {
                DeploySoundFiles();

                // write info.json file if it not exists
                var modInfoJsonPath = Path.Combine(cp77Proj.PackedModDirectory, "info.json");
                if (!File.Exists(modInfoJsonPath))
                {
                    var options = new JsonSerializerOptions
                    {
                        WriteIndented = true,
                        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                    };
                    var jsonString = JsonSerializer.Serialize(cp77Proj.GetInfo(), options);
                    File.WriteAllText(modInfoJsonPath, jsonString);
                }
            }
            else
            {
                if (Directory.EnumerateFileSystemEntries(cp77Proj.SoundDirectory).Any())
                {
                    _loggerService.Warning("This project contains custom sound files but is packed as legacy mod!");
                }
            }

            // create mod zip file
            var zipPathRoot = new DirectoryInfo(cp77Proj.PackedRootDirectory).Parent.FullName;
            var zipPath = Path.Combine(zipPathRoot, $"{cp77Proj.Name}.zip");
            try
            {
                if (File.Exists(zipPath))
                {
                    File.Delete(zipPath);
                }
                ZipFile.CreateFromDirectory(cp77Proj.PackedRootDirectory, zipPath);
            }
            catch (Exception e)
            {
                _loggerService.Error(e);
            }
            _loggerService.Success($"{cp77Proj.Name} zip available at {zipPath}");

            return true;
        }

        private void DeploySoundFiles()
        {
            var path = Path.Combine(_projectManager.ActiveProject.PackedModDirectory, "info.json");
            if (!File.Exists(path))
            {
                return;
            }

            // read info
            var modProj = _projectManager.ActiveProject as Cp77Project;
            var files = new List<string>();
            try
            {
                // clean packed sounds dir
                foreach (var f in Directory.GetFiles(modProj.PackedSoundsDirectory))
                {
                    File.Delete(f);
                }

                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    IgnoreReadOnlyProperties = true,
                };
                var info = JsonSerializer.Deserialize<ModInfo>(File.ReadAllText(path), options);
                foreach (var e in info.CustomSounds)
                {
                    if (!string.IsNullOrEmpty(e.File))
                    {
                        files.Add(e.File);

                        var rawFile = Path.Combine(modProj.SoundDirectory, e.File);
                        var packedFile = Path.Combine(modProj.PackedSoundsDirectory, e.File);
                        if (File.Exists(rawFile))
                        {
                            File.Copy(rawFile, packedFile, true);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                _loggerService.Error(e);
            }
        }

        public bool PackProjectNoBackup()
        {

            if (_projectManager.ActiveProject is not Cp77Project cp77Proj)
            {
                _loggerService.Error("Can't pack project (no project/not cyberpunk project)!");
                return false;
            }

            // cleanup
            try
            {
                var archives = Directory.GetFiles(cp77Proj.PackedArchiveDirectory, "*.archive");
                foreach (var archive in archives)
                {
                    File.Delete(archive);
                }
            }
            catch (Exception e)
            {
                _loggerService.Error(e);
            }

            // pack mod
            var modfiles = Directory.GetFiles(cp77Proj.ModDirectory, "*", SearchOption.AllDirectories);
            if (modfiles.Any())
            {
                _modTools.Pack(
                    new DirectoryInfo(cp77Proj.ModDirectory),
                    new DirectoryInfo(cp77Proj.PackedArchiveDirectory),
                    cp77Proj.Name);
                _loggerService.Info("Packing archives complete!");
            }
            _loggerService.Success($"{cp77Proj.Name} packed into {cp77Proj.PackedArchiveDirectory}");


            // compile tweak files
            CompileTweakFiles(cp77Proj);

            if (cp77Proj.IsRedMod)
            {
                DeploySoundFiles();

                // write info.json file if it not exists
                var modInfoJsonPath = Path.Combine(cp77Proj.PackedModDirectory, "info.json");
                if (!File.Exists(modInfoJsonPath))
                {
                    var options = new JsonSerializerOptions
                    {
                        WriteIndented = true,
                        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                    };
                    var jsonString = JsonSerializer.Serialize(cp77Proj.GetInfo(), options);
                    File.WriteAllText(modInfoJsonPath, jsonString);
                }
            }
            else
            {
                if (Directory.EnumerateFileSystemEntries(cp77Proj.SoundDirectory).Any())
                {
                    _loggerService.Warning("This project contains custom sound files but is packed as legacy mod!");
                }
            }

            return true;
        }

        public bool PackProjectHot()
        {

            if (_projectManager.ActiveProject is not Cp77Project cp77Proj)
            {
                _loggerService.Error("Can't pack project (no project/not cyberpunk project)!");
                return false;
            }

            var hotdirectory = Path.Combine(_settingsManager.GetRED4GameRootDir(), "archive", "pc", "hot");

            // create hot directory
            if (!Directory.Exists(hotdirectory))
            {
                Directory.CreateDirectory(hotdirectory);
                _loggerService.Info($"Created hot directory at {hotdirectory}");
            }

            // pack mod
            var modfiles = Directory.GetFiles(cp77Proj.ModDirectory, "*", SearchOption.AllDirectories);
            if (modfiles.Any())
            {
                _modTools.Pack(
                    new DirectoryInfo(cp77Proj.ModDirectory),
                    new DirectoryInfo(hotdirectory),
                    cp77Proj.Name);
                _loggerService.Info("Hot archive installation complete!");
            }
            _loggerService.Success($"{cp77Proj.Name} packed into {hotdirectory}");

            return true;
        }

        private void CompileTweakFiles(Cp77Project cp77Proj)
        {
            try
            {
                Directory.Delete(cp77Proj.PackedTweakDirectory, true);
            }
            catch (Exception e)
            {
                _loggerService.Error(e);
            }

            var tweakFiles = Directory.GetFiles(cp77Proj.TweakDirectory, "*.yaml", SearchOption.AllDirectories);
            foreach (var f in tweakFiles)
            {
                var folder = Path.GetDirectoryName(Path.GetRelativePath(cp77Proj.TweakDirectory, f));
                var outDirectory = Path.Combine(cp77Proj.PackedTweakDirectory, folder);
                if (!Directory.Exists(outDirectory))
                {
                    Directory.CreateDirectory(outDirectory);
                }
                var filename = Path.GetFileName(f);
                var outPath = Path.Combine(outDirectory, filename);
                File.Copy(f, outPath, true);
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

                _loggerService.Success($"{activeMod.Name} installed!");
                _notificationService.Success($"{activeMod.Name} installed!");
            }
            catch (Exception ex)
            {
                //If we screwed up something. Log it.
                _loggerService.Error(ex);
            }
        }

        public void AddToMod(ulong hash)
        {
            var file = _archiveManager.Lookup(hash);
            if (file.HasValue)
            {
                AddToMod(file.Value);
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
                        var fileName = file.Name;
                        if (file.Name == file.Key.ToString() && file.GuessedExtension != null)
                        {
                            fileName += file.GuessedExtension;
                        }

                        var diskPathInfo = new FileInfo(Path.Combine(cyberpunkProject.ModDirectory, fileName));
                        if (diskPathInfo.Directory == null)
                        {
                            break;
                        }

                        if (File.Exists(diskPathInfo.FullName))
                        {
                            if (MessageBox.Show($"The file {file.Name} already exists in project - overwrite it with game file?", $"Confirm overwrite: {file.Name}", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                            {
                                using var fs = new FileStream(diskPathInfo.FullName, FileMode.Create);
                                file.Extract(fs);
                                _loggerService.Success($"Overwrote existing file with game file: {file.Name}");
                            }
                            else
                            {
                                _loggerService.Info($"Declined to overwrite existing file: {file.Name}");
                            }
                        }
                        else
                        {
                            Directory.CreateDirectory(diskPathInfo.Directory.FullName);
                            using var fs = new FileStream(diskPathInfo.FullName, FileMode.Create);
                            file.Extract(fs);
                            _loggerService.Success($"Added game file to project: {file.Name}");
                        }
                    }

                    break;
                }
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        #endregion Methods
    }
}
