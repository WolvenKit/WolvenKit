using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;
using ReactiveUI;
using Splat;
using WolvenKit.App.Models;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.RED4.Compiled;
using WolvenKit.Common.Services;
using WolvenKit.Core.Compression;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Functionality.Services;
using WolvenKit.Helpers;
using WolvenKit.Interaction;
using WolvenKit.Models;
using WolvenKit.ProjectManagement.Project;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.Functionality.Controllers
{
    public class RED4Controller : ReactiveObject, IGameController
    {
        #region fields

        public const string GameVersion = "1.6.0";

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

        public async Task HandleStartup()
        {
            if (!_initialized)
            {
                _initialized = true;
                _progressService.IsIndeterminate = true;

                // load archives
                await LoadArchiveManager();

                // requires oodle
                InitializeBk();

                _progressService.IsIndeterminate = false;
                _progressService.Completed();
            }
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
                using MemoryStream ms = new();
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
                using MemoryStream ms = new();
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

        private Task LoadArchiveManager() =>
            Task.Run(() =>
            {
                if (_archiveManager != null && _archiveManager.IsManagerLoaded)
                {
                    return;
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
            });

        #region Packing

        public bool PackProjectHot()
        {
            var hotdirectory = Path.Combine(_settingsManager.GetRED4GameRootDir(), "archive", "pc", "hot");

            // create hot directory
            if (!Directory.Exists(hotdirectory))
            {
                Directory.CreateDirectory(hotdirectory);
                _loggerService.Info($"Created hot directory at {hotdirectory}");
            }

            // pack mod
            var modfiles = Directory.GetFiles(_projectManager.ActiveProject.ModDirectory, "*", SearchOption.AllDirectories);
            if (modfiles.Any())
            {
                _modTools.Pack(
                    new DirectoryInfo(_projectManager.ActiveProject.ModDirectory),
                    new DirectoryInfo(hotdirectory),
                    _projectManager.ActiveProject.Name);
                _loggerService.Info("Hot archive installation complete!");
            }
            _loggerService.Success($"{_projectManager.ActiveProject.Name} packed into {hotdirectory}");
            _notificationService.Success($"{_projectManager.ActiveProject.Name} packed into {hotdirectory}");

            return true;
        }


        /// <summary>
        /// Pack mod with options
        /// </summary>
        /// <returns></returns>
        public async Task<bool> LaunchProject(LaunchProfile options)
        {
            _progressService.IsIndeterminate = true;

            // checks
            if (_projectManager.ActiveProject is not Cp77Project cp77Proj)
            {
                _progressService.IsIndeterminate = false;
                _loggerService.Error("Cannot pack project (no project/not cyberpunk project)!");
                _notificationService.Error("Cannot pack project (no project/not cyberpunk project)!");
                return false;
            }
            if (!options.IsRedmod && Directory.EnumerateFileSystemEntries(cp77Proj.SoundDirectory).Any())
            {
                _loggerService.Warning("This project contains custom sound files but is packed as legacy mod!");
                _notificationService.Warning($"This project contains custom sound files and needs to be packed as a REDmod!");

                _progressService.IsIndeterminate = false;
                return false;
            }

            // cleanup
            if (!await Task.Run(() => Cleanup(cp77Proj, options)))
            {
                _progressService.IsIndeterminate = false;
                _loggerService.Error("Cleanup failed, aborting.");
                _notificationService.Error("Cleanup failed, aborting.");
                return false;
            }
            _loggerService.Success($"{cp77Proj.Name} files cleaned up.");


            // copy files to packed dir
            // pack archives
            if (!await Task.Run(() => PackArchives(cp77Proj, options)))
            {
                _progressService.IsIndeterminate = false;
                _loggerService.Error("Packing archives failed, aborting.");
                _notificationService.Error("Packing archives failed, aborting.");
                return false;
            }
            _loggerService.Success($"{cp77Proj.Name} archives packed into {cp77Proj.GetPackedArchiveDirectory(options.IsRedmod)}");

            // pack tweakXL files
            if (!PackTweakXlFiles(cp77Proj))
            {
                _progressService.IsIndeterminate = false;
                _loggerService.Error("Packing tweakXL files failed, aborting.");
                _notificationService.Error("Packing tweakXL files failed, aborting.");
                return false;
            }
            _loggerService.Success($"{cp77Proj.Name} tweakXL files packed into {cp77Proj.PackedTweakDirectory}");

            // pack archiveXL files
            if (!PackArchiveXlFiles(cp77Proj, options))
            {
                _progressService.IsIndeterminate = false;
                _loggerService.Error("Packing archiveXL files failed, aborting.");
                _notificationService.Error("Packing archiveXL files failed, aborting.");
                return false;
            }
            _loggerService.Success($"{cp77Proj.Name} archiveXL files packed into {cp77Proj.GetPackedArchiveDirectory(options.IsRedmod)}");


            // pack redmod files
            if (options.IsRedmod)
            {
                if (!PackRedmodFiles(cp77Proj))
                {
                    _progressService.IsIndeterminate = false;
                    _loggerService.Error("Packing redmod files failed, aborting.");
                    _notificationService.Error("Packing redmod files failed, aborting.");
                    return false;
                }
                _loggerService.Success($"{cp77Proj.Name} redmod files packed into {cp77Proj.PackedRedModDirectory}");
            }

            if (!options.Install)
            {
                _notificationService.Success($"{cp77Proj.Name} packed!");
            }

            // backup
            if (options.CreateBackup)
            {
                if (!BackupMod(cp77Proj))
                {
                    _progressService.IsIndeterminate = false;
                    _loggerService.Error("Creating backup failed, aborting.");
                    _notificationService.Error("Creating backup failed, aborting.");
                    return false;
                }
            }


            // install files
            if (options.Install)
            {
                if (!InstallMod(cp77Proj))
                {
                    _progressService.IsIndeterminate = false;
                    _loggerService.Error("Installing mod failed, aborting.");
                    _notificationService.Error("Installing mod failed, aborting.");
                    return false;
                }
                _loggerService.Success($"{cp77Proj.Name} installed!");
                _notificationService.Success($"{cp77Proj.Name} installed!");
            }


            // deploy redmod
            if (options.DeployWithRedmod)
            {
                if (!await DeployRedmod())
                {
                    _progressService.IsIndeterminate = false;
                    _loggerService.Error("Redmod deploy failed, aborting.");
                    _notificationService.Error("Redmod deploy failed, aborting.");
                    return false;
                }
                _loggerService.Success($"{_projectManager.ActiveProject.Name} Redmod deployed!");
            }

            _progressService.IsIndeterminate = false;

            // launch game
            if (options.LaunchGame)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = _settingsManager.GetRED4GameLaunchCommand(),
                    Arguments = options.GameArguments ?? "",
                    ErrorDialog = true,
                    UseShellExecute = true,
                });
            }

            return true;
        }

        private bool Cleanup(Cp77Project cp77Proj, LaunchProfile options)
        {
            var result = false;
            // legacy
            result = SafeDirectoryDelete(cp77Proj.GetPackedArchiveDirectory(!options.IsRedmod), true);
            result = SafeDirectoryDelete(Path.Combine(cp77Proj.PackedRootDirectory, "archive"), true);

            // tweakXL
            result = SafeDirectoryDelete(cp77Proj.PackedTweakDirectory, true);

            // redmod
            result = SafeFileDelete(Path.Combine(cp77Proj.PackedRedModDirectory, "info.json"));
            result = SafeDirectoryDelete(cp77Proj.PackedSoundsDirectory, true);
            result = SafeDirectoryDelete(cp77Proj.GetPackedArchiveDirectory(options.IsRedmod), true);
            result = SafeDirectoryDelete(Path.Combine(cp77Proj.PackedRootDirectory, "mods"), true);

            return result;
        }

        private bool SafeDirectoryDelete(string path, bool recursive = true)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    Directory.Delete(path, recursive);
                }
                return true;
            }
            catch (Exception e)
            {
                _loggerService.Error(e);
                return false;
            }
        }

        private bool SafeFileDelete(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                return true;
            }
            catch (Exception e)
            {
                _loggerService.Error(e);
                return false;
            }
        }

        private bool PackArchives(Cp77Project cp77Proj, LaunchProfile options)
        {
            var modfiles = Directory.GetFiles(cp77Proj.ModDirectory, "*", SearchOption.AllDirectories);
            if (modfiles.Any())
            {
                _modTools.Pack(
                    new DirectoryInfo(cp77Proj.ModDirectory),
                    new DirectoryInfo(cp77Proj.GetPackedArchiveDirectory(options.IsRedmod)),
                    cp77Proj.Name);
            }

            return true;
        }
        private static bool PackTweakXlFiles(Cp77Project cp77Proj)
        {
            var tweakFiles = Directory.GetFiles(cp77Proj.ResourcesDirectory, "*.yaml", SearchOption.AllDirectories);
            foreach (var f in tweakFiles)
            {
                if (!Directory.Exists(cp77Proj.PackedTweakDirectory))
                {
                    Directory.CreateDirectory(cp77Proj.PackedTweakDirectory);
                }
                var filename = Path.GetFileName(f);
                var outPath = Path.Combine(cp77Proj.PackedTweakDirectory, filename);
                File.Copy(f, outPath, true);
            }
            return true;
        }
        private static bool PackArchiveXlFiles(Cp77Project cp77Proj, LaunchProfile options)
        {
            var archiveXlFiles = Directory.GetFiles(cp77Proj.ResourcesDirectory, "*.xl", SearchOption.AllDirectories);
            foreach (var f in archiveXlFiles)
            {
                var outDirectory = cp77Proj.GetPackedArchiveDirectory(options.IsRedmod);
                if (!Directory.Exists(outDirectory))
                {
                    Directory.CreateDirectory(outDirectory);
                }
                var filename = Path.GetFileName(f);
                var outPath = Path.Combine(outDirectory, filename);
                File.Copy(f, outPath, true);
            }
            return true;
        }
        private bool PackRedmodFiles(Cp77Project cp77Proj)
        {
            // sounds
            PackSoundFiles();

            // tweaks
            // TODO

            // scripts
            // TODO

            // write info.json file if it not exists
            var modInfoJsonPath = Path.Combine(cp77Proj.PackedRedModDirectory, "info.json");
            if (!File.Exists(modInfoJsonPath))
            {
                JsonSerializerOptions jsonoptions = new()
                {
                    WriteIndented = true,
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                };
                var jsonString = JsonSerializer.Serialize(cp77Proj.GetInfo(), jsonoptions);
                File.WriteAllText(modInfoJsonPath, jsonString);
            }

            return true;
        }
        private void PackSoundFiles()
        {
            // nothing to pack if no info.json file exists
            var path = Path.Combine(_projectManager.ActiveProject.PackedRedModDirectory, "info.json");
            if (!File.Exists(path))
            {
                return;
            }

            // read info
            var modProj = _projectManager.ActiveProject;
            List<string> files = new();
            try
            {
                JsonSerializerOptions options = new()
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

        private bool BackupMod(Cp77Project cp77Proj)
        {
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
                return false;
            }

            _loggerService.Success($"{cp77Proj.Name} zip available at {zipPath}");
            return true;
        }

        private bool InstallMod(Cp77Project activeMod)
        {
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

                XDocument installlog = new(
                    new XElement("InstalLog",
                        new XAttribute("Project", activeMod.Name),
                        new XAttribute("Build_date", DateTime.Now.ToString())
                        ));
                XElement fileroot = new("Files");

                //Copy and log the files.
                var packedmoddir = activeMod.PackedRootDirectory;
                if (!Directory.Exists(packedmoddir))
                {
                    _loggerService.Error("Failed to install the mod! The packed directory doesn't exist!");
                    return false;
                }

                fileroot.Add(Commonfunctions.DirectoryCopy(packedmoddir, _settingsManager.GetRED4GameRootDir(), true));

                //var packeddlcdir = Path.Combine(ActiveMod.ProjectDirectory, "packed", "DLC");
                //if (Directory.Exists(packeddlcdir))
                //    fileroot.Add(Commonfunctions.DirectoryCopy(packeddlcdir, MainController.Get().Configuration.CP77GameDlcDir, true));

                installlog.Root.Add(fileroot);
                installlog.Save(logPath);


            }
            catch (Exception ex)
            {
                //If we screwed up something. Log it.
                _loggerService.Error(ex);
                return false;
            }

            return true;
        }

        private Task<bool> DeployRedmod()
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
                var args = $"deploy -root=\"{_settingsManager.GetRED4GameRootDir()}\"";

                _loggerService.Info($"WorkDir: {redmodPath}");
                _loggerService.Info($"Running commandlet: {args}");
                var workingDir = Path.Combine(_settingsManager.GetRED4GameRootDir(), "tools", "redmod", "bin");
                return ProcessUtil.RunProcessAsync(redmodPath, args, workingDir);
            }

            return Task.FromResult(true);
        }

        #endregion

        public async Task AddFileToModModal(ulong hash)
        {
            var file = _archiveManager.Lookup(hash);
            if (file.HasValue)
            {
                await AddFileToModModal(file.Value);
            }
        }

        public async Task AddFileToModModal(IGameFile file)
        {
            FileInfo diskPathInfo = new(Path.Combine(_projectManager.ActiveProject.ModDirectory, file.Name));
            if (diskPathInfo.Exists)
            {
                var response = await Interactions.ShowMessageBoxAsync(
                    $"File exists in project. Overwrite existing file?",
                    "Add file",
                    WMessageBoxButtons.YesNo);

                switch (response)
                {
                    case WMessageBoxResult.Yes:
                    {
                        await Task.Run(() => AddToMod(file));
                        break;
                    }
                }
            }
            else
            {
                await Task.Run(() => AddToMod(file));
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
            switch (_projectManager.ActiveProject.GameType)
            {
                case GameType.Cyberpunk2077:
                {
                    var fileName = file.Name;
                    if (file.Name == file.Key.ToString() && file.GuessedExtension != null)
                    {
                        fileName += file.GuessedExtension;
                    }

                    FileInfo diskPathInfo = new(Path.Combine(_projectManager.ActiveProject.ModDirectory, fileName));
                    if (diskPathInfo.Directory == null)
                    {
                        break;
                    }

                    if (File.Exists(diskPathInfo.FullName))
                    {
                        using FileStream fs = new(diskPathInfo.FullName, FileMode.Create);
                        file.Extract(fs);
                        _loggerService.Info($"Overwrote existing file with game file: {file.Name}");
                    }
                    else
                    {
                        Directory.CreateDirectory(diskPathInfo.Directory.FullName);
                        try
                        {
                            using FileStream fs = new(diskPathInfo.FullName, FileMode.Create);
                            file.Extract(fs);
                            _loggerService.Info($"Added game file to project: {file.Name}");
                        }
                        catch (Exception ex)
                        {
                            File.Delete(diskPathInfo.FullName);
                            _loggerService.Error(ex);
                        }

                    }

                    break;
                }
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
