using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models;
using WolvenKit.Modkit.RED4.Project;
using WolvenKit.App.Services;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Services;
using WolvenKit.Core.Exceptions;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Helpers;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Pools;

namespace WolvenKit.App.Controllers;

public class RED4Controller : ObservableObject, IGameController
{
    #region fields

    public const string GameVersion = "1.6.1";

    private readonly ILoggerService _loggerService;
    private readonly INotificationService _notificationService;
    private readonly IProjectManager _projectManager;
    private readonly ISettingsManager _settingsManager;
    private readonly IHashService _hashService;
    private readonly IModTools _modTools;
    private readonly IAppArchiveManager _archiveManager;
    private readonly IProgressService<double> _progressService;
    private readonly IPluginService _pluginService;
    private readonly Red4ParserService _parserService;
    private readonly IModifierViewStateService _modifierService;

    #endregion

    public RED4Controller(
        ILoggerService loggerService,
        INotificationService notificationService,
        IProjectManager projectManager,
        ISettingsManager settingsManager,
        IHashService hashService,
        IModTools modTools,
        IAppArchiveManager gameArchiveManager,
        IProgressService<double> progressService,
        IPluginService pluginService,
        IModifierViewStateService modifierService,
        Red4ParserService parserService)
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
        _modifierService = modifierService;
        _parserService = parserService;
    }

    public async Task HandleStartup()
    {
        await LoadArchiveManagerAsync();
    }

    // TODO: Move this somewhere else
    private void LoadCustomHashes()
    {
        ResourcePath physMatLibPath = "base\\physics\\physicsmaterials.physmatlib";
        ResourcePath presetPath = "engine\\physics\\collision_presets.json";

        var physMatLib = _archiveManager.Lookup(physMatLibPath);
        if (physMatLib.HasValue)
        {
            using MemoryStream ms = new();
            physMatLib.Value.Extract(ms);
            ms.Position = 0;

            if (_parserService.TryReadRed4File(ms, out var file))
            {
                var root = (physicsMaterialLibraryResource)file.RootChunk;

                foreach (var physMat in root.MaterialNames)
                {
                    if (!physMat.IsResolvable)
                    {
                        continue;
                    }

                    CNamePool.AddOrGetHash(physMat.GetResolvedText()!);
                }
            }
        }

        var preset = _archiveManager.Lookup(presetPath);
        if (preset.HasValue)
        {
            using MemoryStream ms = new();
            preset.Value.Extract(ms);
            ms.Position = 0;

            if (_parserService.TryReadRed4File(ms, out var file))
            {
                var root = (JsonResource)file.RootChunk;
                var res = (physicsCollisionPresetsResource)root.Root.Chunk.NotNull();

                foreach (var presetEntry in res.Presets)
                {
                    if (presetEntry is not { Name: { IsResolvable: true } name })
                    {
                        continue;
                    }

                    CNamePool.AddOrGetHash(name.GetResolvedText()!);
                }
            }
        }
    }

    private Guid _loadingCompletion = Guid.NewGuid();

    private void EnableLoadingMode()
    {
        _loadingCompletion = DispatcherHelper.StartRepeatingAction(
            () =>
            {
                _progressService.IsIndeterminate = true;
                _progressService.Status = EStatus.Running;
            },
            TimeSpan.FromMilliseconds(100),
            DisableLoadingMode
        );
    }

    private void DisableLoadingMode()
    {
        _progressService.IsIndeterminate = false;
        _progressService.Status = EStatus.Ready;
        DispatcherHelper.StopRepeatingAction(_loadingCompletion);
    }

    /// <summary>
    /// Loads the basegame + EP1 archives on a background thread.
    /// While loading, a 100ms repeating timer forces the global ProgressService
    /// into Running/Indeterminate state. This mitigates the problem that there is
    /// only a single global "Ready/Running" state — other code can (and does)
    /// call Completed() or set IsIndeterminate=false while this long job is still
    /// in progress.
    /// </summary>
    private async Task LoadArchiveManagerAsync()
    {
        // Fast path checks — do NOT start the loading indicator if there's nothing to do.
        if (_archiveManager.IsManagerLoaded)
        {
            return;
        }

        if (_settingsManager.CP77ExecutablePath is null)
        {
            _loggerService.Warning("Cyberpunk 2077 executable path is not set. Skipping Archive Manager load.");
            return;
        }

        EnableLoadingMode();

        try
        {
            await Task.Run(() =>
            {
                // Keep priority low so the UI stays responsive during the (potentially long)
                // first-time scan of dozens of large .archive files.
                Thread.CurrentThread.Priority = ThreadPriority.BelowNormal;
                Thread.CurrentThread.IsBackground = true;

                _loggerService.Info("Loading Archive Manager ... ");

                _archiveManager.LoadGameArchives(new FileInfo(_settingsManager.CP77ExecutablePath));

                // Custom hash population needs the archives to be loaded, so do it here on the same thread.
                LoadCustomHashes();
            });

            _loggerService.Success("Finished loading Archive Manager.");
        }
        catch (Exception e)
        {
            _loggerService.Error(e);
            throw;
        }
        finally
        {
            // Always stop the heartbeat timer and release the progress indicator.
            DisableLoadingMode();
            LoadCustomHashes();
        }
    }

    #region Packing

    public async Task<bool> InstallProjectHotAsync()
    {
        if (_projectManager.ActiveProject is not Cp77Project currentProject)
        {
            return false;
        }

        // check if plugin is installed
        if (!_pluginService.IsInstalled(EPlugin.redhottools))
        {
            _notificationService.Error("The Red Hot Tools plugin is not installed and is needed for this functionality.\nYou can install the plugin from the WolvenKit settings,");
        }

        var hotDirectory = Path.Combine(_settingsManager.GetRED4GameRootDir(), "archive", "pc", "hot");

        // create hot directory
        if (!Directory.Exists(hotDirectory))
        {
            Directory.CreateDirectory(hotDirectory);
            _loggerService.Info($"Created hot directory at {hotDirectory}");
        }

        var gameDirectoryInfo = new DirectoryInfo(_settingsManager.GetRED4GameRootDir());
        var packedDirectoryInfo = new DirectoryInfo(currentProject.PackedRootDirectory);

        if (!await PackProjectFilesAsync(new LaunchProfile { Install = true }, currentProject))
        {
            return false;
        }

        if (!_modTools.InstallFiles(packedDirectoryInfo, gameDirectoryInfo, true))
        {
            return false;
        }

        // Clean all residual files
        CleanAll();

        _loggerService.Success($"{currentProject.ModName} packed into {hotDirectory}");
        _notificationService.Success($"{currentProject.ModName} packed into {hotDirectory}");

        return true;
    }

    /// <summary>
    /// cleans the packed directory
    /// </summary>
    /// <returns></returns>
    public bool CleanAll(bool isPostBuild = false)
    {
        _progressService.IsIndeterminate = true;
        // checks
        if (_projectManager.ActiveProject is not Cp77Project cp77Proj)
        {
            var errorMessage = "Cannot perform clean all on project (no project/not cyberpunk project)!";
            _progressService.IsIndeterminate = false;
            _loggerService.Error(errorMessage);
            _notificationService.Error(errorMessage);
            return false;
        }

        // perform cleanup
        if (!cp77Proj.CleanPackedDirectory(_loggerService))
        {
            var errorMessage = "An error occured during clean all. Some files may not be removed.";
            _progressService.IsIndeterminate = false;
            _loggerService.Error(errorMessage);
            _notificationService.Error(errorMessage);
            return false;
        }

        _progressService.IsIndeterminate = false;

        var successMessage = $"{cp77Proj.Name} packed directory all cleaned.";
        _loggerService.Success(successMessage);
        _notificationService.Success(successMessage);

        return true;
    }

    private static bool IsCDPRScript(string fileName)
    {
        return Path.GetExtension(fileName) switch
        {
            ".script" or ".ws" => true,
            _ => false,
        };
    }

    /// <summary>
    /// Pack mod with options
    /// </summary>
    /// <returns></returns>
    public async Task<bool> LaunchProjectAsync(LaunchProfile options)
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

        if (!options.IsRedmod && Directory.EnumerateFiles(cp77Proj.SoundDirectory).Any())
        {
            _loggerService.Warning("This project contains custom sound files but is packed as legacy mod!");
            _notificationService.Warning($"This project contains custom sound files and needs to be packed as a REDmod!");

            //_progressService.IsIndeterminate = false;
            //return false;
        }
        if (!options.IsRedmod && Directory.EnumerateFiles(cp77Proj.ResourcesDirectory).Any(x => IsCDPRScript(x)))
        {
            _loggerService.Warning("This project contains script files but is packed as legacy mod!");
            _notificationService.Warning($"This project contains script files and needs to be packed as a REDmod!");

            //_progressService.IsIndeterminate = false;
            //return false;
        }

        // backup
        if (options.CreateBackup && !cp77Proj.CreateZip(_loggerService, true))
        {
            _progressService.IsIndeterminate = false;
            _loggerService.Error("Creating backup failed, aborting.");
            _notificationService.Error("Creating backup failed, aborting.");
            return false;
        }

        // cleanup
        if (options.CleanAll && !await Task.Run(() => cp77Proj.CleanPackedDirectory(_loggerService)))
        {
            _progressService.IsIndeterminate = false;
            _loggerService.Error("Cleanup failed, aborting.");
            _notificationService.Error("Cleanup failed, aborting.");
            return false;
        }

        // CleanAll will return true when the options disable it, so check here
        if (options.CleanAll)
        {
            _loggerService.Info($"{cp77Proj.Name} files cleaned up.");
        }

        // Pack it up
        if (!await PackProjectFilesAsync(options, cp77Proj))
        {
            return false;
        }

        // backup
        if (options.CreateZipFile && !cp77Proj.CreateZip(_loggerService, false))
        {
            _progressService.IsIndeterminate = false;
            _loggerService.Error("Failed to bundle up your .archive, aborting.");
            _notificationService.Error("Creating backup failed, aborting.");
            return false;
        }

        // Now install it
        if (options.Install && !await InstallProjectFiles(options, cp77Proj))
        {
            return false;
        }

        if (options.CleanAllPostBuild && !await Task.Run(() => cp77Proj.CleanPackedDirectory(_loggerService)))
        {
            _loggerService.Warning("Failed to clean your project after build. The next build might fail.");
        }

        _progressService.IsIndeterminate = false;

        // launch game
        if (!options.LaunchGame)
        {
            return true;
        }

        if (_settingsManager.GetRED4GameLaunchCommand() is not string launchCommand || string.IsNullOrEmpty(launchCommand))
        {
            throw new WolvenKitException(0x5001, "No game executable set");
        }

        var arguments = $"{_settingsManager.GetRED4GameLaunchOptions()} {options.GameArguments ?? ""}";

        // Shift prevents save game load (CET doesn't initialize
        if (!_modifierService.IsShiftKeyPressed && options.LoadLastSave && ISettingsManager.GetLastSaveName() is string lastSavegame)
        {
            arguments = $"{arguments} -save={lastSavegame}";
        }
        else if (!_modifierService.IsShiftKeyPressed && options.LoadSaveName is string savegame)
        {
            arguments = $"{arguments} -save={savegame}";
        }

        // -save can come from the launch options, or from the user settings
        if (arguments.Contains("-save"))
        {
            _loggerService.Warning("Warning: Loading a save via start-up options may break CET entity spawn!");
        }
        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = launchCommand,
                Arguments = arguments,
                ErrorDialog = true,
                UseShellExecute = true,
            });
        }
        catch (Exception)
        {
            throw new WolvenKitException(0x5002, "Failed to launch game executable");
        }

        return true;
    }

    /// <summary>
    /// At this point, all necessary files should be present inside ModDir/packed. This method only copies them to the game dir.
    /// </summary>
    private async Task<bool> InstallProjectFiles(LaunchProfile options, Cp77Project cp77Proj)
    {
        if (!options.Install)
        {
            _notificationService.Success($"{cp77Proj.Name} packed!");
            return true;
        }

        var installPath = options.DeployWithRedmod ? $"mods/{cp77Proj.ModName}" : "archive/pc/mod";

        if (!InstallMod(cp77Proj))
        {
            _progressService.IsIndeterminate = false;
            _loggerService.Error("Installing mod failed, aborting.");
            _notificationService.Error("Installing mod failed, aborting.");
            return false;
        }

        _notificationService.Success($"{cp77Proj.Name} installed!");

        var successString = options.DeployWithRedmod ? "deployed as REDmod" : "installed";
        _loggerService.Success($"{cp77Proj.Name} {successString} to {_settingsManager.GetRED4GameRootDir()}/{installPath}");

        if (!options.DeployWithRedmod || await DeployRedmod())
        {
            return true;
        }

        _progressService.IsIndeterminate = false;
        _loggerService.Error("Redmod deploy failed, aborting.");
        _notificationService.Error("Redmod deploy failed, aborting.");
        return false;


    }

    /// <summary>
    /// This method will move everything into ModDirectory/packed.
    /// </summary>
    private async Task<bool> PackProjectFilesAsync(LaunchProfile options, Cp77Project cp77Proj)
    {
        // Delete empty directories (do not mirror in CLI)
        cp77Proj.DeleteEmptyFolders(_loggerService);

        if (!await Task.Run(() => cp77Proj.PackProject(_modTools, _loggerService, options.IsRedmod)))
        {
            _progressService.IsIndeterminate = false;
            _loggerService.Error("Packing project failed, aborting.");
            _notificationService.Error("Packing project failed, aborting.");
            return false;
        }

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
                if (log is null || log.Root is null)
                {
                    return false;
                }

                var dirs = log.Root.Element("Files")?.Descendants("Directory").ToList();
                if (dirs != null)
                {
                    //Loop throught dirs and delete the old files in them.
                    foreach (var d in dirs)
                    {
                        foreach (var f in d.Elements("file").Where(f => File.Exists(f.Value)))
                        {
                            try
                            {
                                File.Delete(f.Value);
                            }
                            catch (IOException)
                            {
                                _loggerService.Error(
                                    "Failed to delete old file. Is Cyberpunk still running in the background?.");
                                return false;
                            }

                            Debug.WriteLine("File deleted: " + f.Value);
                        }
                    }
                    //Delete the empty directories.
                    foreach (var path in dirs.Select(el => el.Attribute("Path")?.Value)
                                 .OfType<string>()
                                 .Where(Directory.Exists))
                    {
                        if (Directory.GetFiles(path, "*", SearchOption.AllDirectories).Any())
                        {
                            continue;
                        }

                        Directory.Delete(path, true);
                        Debug.WriteLine("Directory deleted: " + path);

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

            if (installlog.Root is null)
            {
                return false;
            }

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

        var redmodPath = Path.Combine(_settingsManager.GetRED4GameRootDir(), "tools", "redmod");
        var executablePath = Path.Combine(redmodPath, "bin", "redMod.exe");
        if (!File.Exists(executablePath))
        {
            return Task.FromResult(false);
        }

        var rttiSchemaPath = Path.Combine(redmodPath, "metadata.json");
        var args = $"deploy -root=\"{_settingsManager.GetRED4GameRootDir()}\"";

        var workingDir = Path.Combine(redmodPath, "bin");
        _loggerService.Info($"WorkDir: {workingDir}");
        _loggerService.Info($"Running commandlet: {args}");
        return ProcessUtil.RunProcessAsync(executablePath, args, workingDir);

    }

    #endregion

    /// <Inheritdoc />
    public async Task<bool> AddFileToModModalAsync(ulong hash)
    {
        var scope = _archiveManager.IsModBrowserActive ? ArchiveManagerScope.Mods : ArchiveManagerScope.Basegame;
        return await AddFileToModModalAsync(hash, scope);
    }

    /// <Inheritdoc />
    public async Task<bool> AddFileToModModalAsync(ulong hash, ArchiveManagerScope searchScope)
    {
        var file = _archiveManager.Lookup(hash);
        return file.HasValue && await AddFileToModModalAsync(file.Value, searchScope);
    }

    /// <Inheritdoc />
    public async Task<bool> AddFileToModModalAsync(IGameFile file)
    {
        var scope = _archiveManager.IsModBrowserActive ? ArchiveManagerScope.Mods : ArchiveManagerScope.Basegame;
        return await AddFileToModModalAsync(file, scope);
    }

    /// <Inheritdoc />
    public async Task<bool> AddFileToModModalAsync(IGameFile file, ArchiveManagerScope searchScope)
    {
        if (_projectManager.ActiveProject is null)
        {
            return false;
        }

        FileInfo diskPathInfo = new(Path.Combine(_projectManager.ActiveProject.ModDirectory, file.Name));
        if (diskPathInfo.Exists)
        {
            var response = await Interactions.ShowMessageBoxAsync(
                $"File exists in project. Overwrite existing file?",
                "Add file",
                WMessageBoxButtons.YesNo);

            switch (response)
            {
                case WMessageBoxResult.OK:
                case WMessageBoxResult.Yes:
                {
                    await Task.Run(() => AddToMod(file));
                    break;
                }

                case WMessageBoxResult.None:
                    break;
                case WMessageBoxResult.Cancel:
                    break;
                case WMessageBoxResult.No:
                    break;
                case WMessageBoxResult.Custom:
                    break;
                default:
                    break;
            }
        }
        else
        {
            await Task.Run(() => AddToMod(file));
        }

        return true;
    }

    public async Task AddToModAsync(IList<IGameFile> files)
    {
        var progress = 0;

        _progressService.IsIndeterminate = false;
        _progressService.Report(0);

        var total = files.Count;

        if (total > 0)
        {
            // Limit concurrency for disk I/O (extraction + writes). Unbounded parallelism
            // often saturates the disk and ends up slower + spams the UI thread.
            var dop = Math.Min(8, Math.Max(1, Environment.ProcessorCount / 2));

            await Parallel.ForEachAsync(
                files,
                new ParallelOptions { MaxDegreeOfParallelism = dop },
                (file, token) =>
                {
                    token.ThrowIfCancellationRequested();
                    AddToMod(file);
                    var current = Interlocked.Increment(ref progress);
                    var reportInterval = Math.Max(1, total / 50);

                    if (current % reportInterval == 0 || current == total)
                    {
                        _progressService.Report(current / (float)total);
                    }

                    return ValueTask.CompletedTask;
                });

            var report = "";

            foreach (var file in files)
            {
                report += $"Added game file to project: {file.Name}\r\n";
            }

            _loggerService.Info(report);
        }

        _progressService.Completed();
    }


    /// <Inheritdoc />
    public bool AddToMod(ulong hash)
    {
        var scope = _archiveManager.IsModBrowserActive ? ArchiveManagerScope.Mods : ArchiveManagerScope.Basegame;
        return AddToMod(hash, scope);
    }

    /// <Inheritdoc />
    public bool AddToMod(ulong hash, ArchiveManagerScope searchScope)
    {
        var file = _archiveManager.Lookup(hash, searchScope);
        return file.HasValue && AddToMod(file.Value, searchScope);
    }

    /// <Inheritdoc />
    public bool AddToMod(IGameFile file)
    {
        var scope = _archiveManager.IsModBrowserActive ? ArchiveManagerScope.Mods : ArchiveManagerScope.Basegame;
        return AddToMod(file, scope);
    }

    /// <Inheritdoc />
    public bool AddToMod(IGameFile file, ArchiveManagerScope searchScope)
    {
        if (_projectManager.ActiveProject is null)
        {
            return false;
        }

        if (Cp77Project.GameType is not GameType.Cyberpunk2077)
        {
            throw new WolvenKitException(-1, "This doesn't seem to be a Cyberpunk project!");
        }

        var fileName = file.Name;
        if (file.Name == file.Key.ToString() && file.GuessedExtension != null)
        {
            fileName += file.GuessedExtension;
        }

        FileInfo diskPathInfo = new(Path.Combine(_projectManager.ActiveProject.ModDirectory, fileName));
        if (diskPathInfo.Directory == null)
        {
            return false;
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
            }
            catch (Exception ex)
            {
                File.Delete(diskPathInfo.FullName);
                _loggerService.Error(ex);
            }

        }

        return true;
    }
}
