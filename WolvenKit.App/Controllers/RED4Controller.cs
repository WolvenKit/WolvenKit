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
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models;
using WolvenKit.App.Models.ProjectManagement.Project;
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

    private bool _initialized = false;

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
        if (!_initialized)
        {
            _initialized = true;
            _progressService.IsIndeterminate = true;

            // load archives
            await LoadArchiveManager();

            _progressService.IsIndeterminate = false;
            _progressService.Completed();
        }
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

    private Task LoadArchiveManager()
    {
        return Task.Run(() =>
        {
            if (_archiveManager.IsManagerLoaded)
            {
                return;
            }
            if (_settingsManager.CP77ExecutablePath is null)
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
        if (!Cleanup(cp77Proj, new LaunchProfile() { CleanAll = true }, isPostBuild))
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

    private static bool IsSpecialExtension(string fileName)
    {
        return Path.GetExtension(fileName) switch
        {
            ".xl" or ".script" or ".ws" or ".tweak" => true,
            _ => false,
        };
    }
    private static bool IsCDPRScript(string fileName)
    {
        return Path.GetExtension(fileName) switch
        {
            ".script" or ".ws" => true,
            _ => false,
        };
    }

    private static List<string> GetArchiveXlFiles(Cp77Project cp77Proj) =>
        Directory.EnumerateFiles(cp77Proj.ResourcesDirectory, "*.xl", SearchOption.AllDirectories).ToList();

    private static List<string> GetResourceFiles(Cp77Project cp77Proj) => Directory
        .EnumerateFiles(cp77Proj.ResourcesDirectory, "*.*", SearchOption.AllDirectories)
        .Where(name => !IsSpecialExtension(name))
        .Where(x => Path.GetFileName(x) != "info.json").ToList();

    private static List<string> GetREDmodScriptFiles(Cp77Project cp77Proj)
    {
        var absolutePath = Path.Combine(cp77Proj.ResourcesDirectory, "scripts");
        if (!Directory.Exists(absolutePath))
        {
            return [];
        }

        return Directory
            .EnumerateFiles(absolutePath, "*.*", SearchOption.AllDirectories)
            .Where(IsCDPRScript).ToList();
    }

    private static List<string> GetREDmodTweakFiles(Cp77Project cp77Proj)
    {
        var absolutePath = Path.Combine(cp77Proj.ResourcesDirectory, "tweaks");
        if (!Directory.Exists(absolutePath))
        {
            return [];
        }

        return Directory.EnumerateFiles(absolutePath, "*.tweak",
            SearchOption.AllDirectories).ToList();
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
        if (options.CreateBackup && !CreateZipfile(cp77Proj, true))
        {
            _progressService.IsIndeterminate = false;
            _loggerService.Error("Creating backup failed, aborting.");
            _notificationService.Error("Creating backup failed, aborting.");
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
        if (options.CreateZipFile && !CreateZipfile(cp77Proj, false))
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

        if (options.CleanAllPostBuild && !await Task.Run(() => Cleanup(cp77Proj, options, true)))
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
        // NOTE: this implementation is partially duplicated in "WolvenKit.Modkit\RED4\Build.cs".
        //       Changing the code below should be mirrored there too.
        
        // copy files to packed dir
        // pack archives
        var archives = Directory.EnumerateFiles(cp77Proj.ModDirectory, "*", SearchOption.AllDirectories).ToList();
        if (archives.Count != 0)
        {
            var invalidFiles = archives
                .Select(f => Path.GetRelativePath(cp77Proj.ModDirectory, f))
                .Where(f => f.Any(char.IsUpper) || f.Any(char.IsWhiteSpace)).ToList();
            if (invalidFiles.Count != 0)
            {
                _loggerService.Error("Capital letters and/or whitespaces found (this may cause issues):");
                foreach (var filePath in invalidFiles)
                {
                    _loggerService.Error($"\t {filePath}");
                }
            }
            
            if (!await Task.Run(() => PackArchives(cp77Proj, options)))
            {
                _progressService.IsIndeterminate = false;
                _loggerService.Error("Packing archives failed, aborting.");
                _notificationService.Error("Packing archives failed, aborting.");
                return false;
            }

            _loggerService.Info($"{cp77Proj.Name} archives packed into {cp77Proj.GetPackedArchiveDirectory(options.IsRedmod)}");
        }

        // pack archiveXL files
        var files = GetArchiveXlFiles(cp77Proj);
        if (files.Count != 0)
        {
            if (!PackArchiveXlFiles(cp77Proj, files, options))
            {
                _progressService.IsIndeterminate = false;
                _loggerService.Error("Packing archiveXL files failed, aborting.");
                _notificationService.Error("Packing archiveXL files failed, aborting.");
                return false;
            }

            _loggerService.Info($"{cp77Proj.Name} archiveXL files packed into {cp77Proj.GetPackedArchiveDirectory(options.IsRedmod)}");
        }

        // pack generic resources excluding script and tweak files
        files = GetResourceFiles(cp77Proj);
        if (files.Count != 0)
        {
            if (!PackResources(cp77Proj, files))
            {
                _progressService.IsIndeterminate = false;
                _loggerService.Error("Packing other resource files failed, aborting.");
                _notificationService.Error("Packing other resource files failed, aborting.");
                return false;
            }

            _loggerService.Info($"{cp77Proj.Name} resource files packed into {cp77Proj.PackedRootDirectory}");
        }

        // pack redmod files
        if (!options.IsRedmod)
        {
            return true;
        }

        if (!PackRedmodFiles(cp77Proj))
        {
            _progressService.IsIndeterminate = false;
            _loggerService.Error("Packing redmod files failed, aborting.");
            _notificationService.Error("Packing redmod files failed, aborting.");
            return false;
        }

        _loggerService.Info($"{cp77Proj.Name} redmod files packed into {cp77Proj.PackedRedModDirectory}");
        return true;
    }

    private bool Cleanup(Cp77Project cp77Proj, LaunchProfile options, bool isPostBuild = false)
    {
        if (!options.CleanAll && !(isPostBuild && options.CleanAllPostBuild))
        {
            return true;
        }

        var result = true; //base condition -- if packed/ is already empty, then the command is 'successful'.

        //top level directories
        var dirs = Directory.GetDirectories(cp77Proj.PackedRootDirectory, "*", SearchOption.TopDirectoryOnly);
        for (var i = 0; i < dirs.Count(); i++)
        {
            result = SafeDirectoryDelete(dirs[i], true);
        }

        //top level files
        var files = Directory.GetFiles(cp77Proj.PackedRootDirectory, "*", SearchOption.TopDirectoryOnly);
        for (var i = 0; i < files.Count(); i++)
        {
            result = SafeFileDelete(files[i]);
        }

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

    private bool PackArchives(Cp77Project cp77Proj, LaunchProfile options) => 
        _modTools.Pack(new DirectoryInfo(cp77Proj.ModDirectory), new DirectoryInfo(cp77Proj.GetPackedArchiveDirectory(options.IsRedmod)), cp77Proj.ModName);

    private static bool PackResources(Cp77Project cp77Proj, IEnumerable<string> files)
    {
        //All such files goes into the root of the cp77Proj.PackedRootDirectory
        foreach (var file in files)
        {
            var fileName = Path.GetFileName(file);
            var fileRelativeDir = Path.GetRelativePath(cp77Proj.ResourcesDirectory, Path.GetDirectoryName(file).NotNull());
            var fileOutputDir = Path.Combine(cp77Proj.PackedRootDirectory, fileRelativeDir);
            var fileOutputPath = Path.Combine(fileOutputDir, fileName);
            if (!Directory.Exists(fileOutputDir))
            {
                Directory.CreateDirectory(fileOutputDir);
            }

            // copy files, with overwriting
            File.Copy(file, fileOutputPath, true);
        }
        return true;
    }
    
    private static bool PackArchiveXlFiles(Cp77Project cp77Proj, IEnumerable<string> archiveXlFiles, LaunchProfile options)
    {
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
        // write info.json file if it not exists
        var modinfo = Path.Combine(cp77Proj.PackedRedModDirectory, "info.json");

        if (File.Exists(modinfo))
        {
            File.Delete(modinfo);
        }

        if (!File.Exists(modinfo))
        {
            JsonSerializerOptions jsonoptions = new()
            {
                WriteIndented = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            var jsonString = JsonSerializer.Serialize(cp77Proj.GetInfo(), jsonoptions);
            File.WriteAllText(modinfo, jsonString);
        }

        // sounds
        if (PackSoundFiles())
        {
            _loggerService.Info($"{cp77Proj.Name} redmod sound files packed into {cp77Proj.PackedRedModDirectory}");
        }

        // tweaks
        var files = GetREDmodTweakFiles(cp77Proj);
        if (files.Count != 0)
        {
            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file);
                var fileRelativeDir = Path.GetRelativePath(cp77Proj.ResourcesDirectory, Path.GetDirectoryName(file).NotNull());
                var fileOutputDir = Path.Combine(cp77Proj.PackedRedModDirectory, fileRelativeDir);
                var fileOutputPath = Path.Combine(fileOutputDir, fileName);
                if (!Directory.Exists(fileOutputDir))
                {
                    Directory.CreateDirectory(fileOutputDir);
                }

                // copy files, with overwriting
                File.Copy(file, fileOutputPath, true);
            }
            _loggerService.Info($"{cp77Proj.Name} redmod tweak files packed into {cp77Proj.PackedRedModDirectory}");
        }

        // scripts
        files = GetREDmodScriptFiles(cp77Proj);
        if (files.Count != 0)
        {
            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file);
                var fileRelativeDir = Path.GetRelativePath(cp77Proj.ResourcesDirectory, Path.GetDirectoryName(file).NotNull());
                var fileOutputDir = Path.Combine(cp77Proj.PackedRedModDirectory, fileRelativeDir);
                var fileOutputPath = Path.Combine(fileOutputDir, fileName);
                if (!Directory.Exists(fileOutputDir))
                {
                    Directory.CreateDirectory(fileOutputDir);
                }

                // copy files, with overwriting
                File.Copy(file, fileOutputPath, true);
            }
        }

        _loggerService.Info($"{cp77Proj.Name} redmod script files packed into {cp77Proj.PackedRedModDirectory}");

        return true;
    }
    
    private bool PackSoundFiles()
    {
        if (_projectManager.ActiveProject is null)
        {
            return false;
        }

        // nothing to pack if no info.json file exists
        var path = Path.Combine(_projectManager.ActiveProject.PackedRedModDirectory, "info.json");
        if (!File.Exists(path))
        {
            return false;
        }

        // read info
        var modProj = _projectManager.ActiveProject;
        List<string> files = new();
        try
        {
            JsonSerializerOptions options = new()
            {
                WriteIndented = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                IgnoreReadOnlyProperties = true,
            };
            var info = JsonSerializer.Deserialize<ModInfo>(File.ReadAllText(path), options).NotNull();
            if (info.CustomSounds.Count == 0)
            {
                // nothing to do
                return false;
            }

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
            return false;
        }

        return true;
    }

    private bool CreateZipfile(Cp77Project cp77Proj, bool isBackup)
    {
        var zipPathRoot = new DirectoryInfo(cp77Proj.PackedRootDirectory).Parent?.FullName;
        if (zipPathRoot is null)
        {
            return false;
        }

        var suffix = isBackup ? "_previousBuild" : "";
        var zipPath = Path.Combine(zipPathRoot, $"{cp77Proj.Name}{suffix}.zip");
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
        _loggerService.Info($"{cp77Proj.Name} zip available at {zipPath}");
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
                        var p = d.Attribute("Path");
                        if (p is not null)
                        {
                            if (Directory.Exists(p.Value) && !Directory.GetFiles(p.Value, "*", SearchOption.AllDirectories).Any())
                            {
                                Directory.Delete(p.Value, true);
                                Debug.WriteLine("Directory delete: " + p.Value);
                            }
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
                _loggerService.Info($"Added game file to project: {file.Name}");
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
