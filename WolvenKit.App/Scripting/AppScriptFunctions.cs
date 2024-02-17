using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.ClearScript;
using WolvenKit.App.Controllers;
using WolvenKit.App.Extensions;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common;
using WolvenKit.Common.Conversion;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Interfaces;
using WolvenKit.Modkit.Scripting;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.JSON;
using WolvenKit.RED4.Types;
using EFileReadErrorCodes = WolvenKit.RED4.Archive.IO.EFileReadErrorCodes;

namespace WolvenKit.App.Scripting;

/// <summary>
/// TODO
/// </summary>
public class AppScriptFunctions : ScriptFunctions
{
    private readonly IProjectManager _projectManager;
    private readonly IWatcherService _watcherService;
    private readonly IModTools _modTools;
    private readonly ImportExportHelper _importExportHelper;
    private readonly IGameControllerFactory _gameController;
    private readonly GeometryCacheService _geometryCacheService;

    public AppViewModel? AppViewModel;

    public AppScriptFunctions(
        ILoggerService loggerService,
        IProjectManager projectManager,
        IArchiveManager archiveManager,
        Red4ParserService parserService,
        IWatcherService watcherService,
        IModTools modTools,
        ImportExportHelper importExportHelper,
        IGameControllerFactory gameController,
        GeometryCacheService geometryCacheService)
        : base(loggerService, archiveManager, parserService)
    {
        _projectManager = projectManager;
        _watcherService = watcherService;
        _modTools = modTools;
        _importExportHelper = importExportHelper;
        _gameController = gameController;
        _geometryCacheService = geometryCacheService;
    }

    /// <summary>
    /// Turn on/off updates to the project tree, useful for when making lots of changes to the project structure.
    /// </summary>
    /// <param name="suspend">bool for if updates are suspended</param>
    public void SuspendFileWatcher(bool suspend)
    {
        if (_watcherService != null && _watcherService.IsSuspended != suspend)
        {
            _watcherService.IsSuspended = suspend;
        }
    }

    /// <summary>
    /// Add the specified cr2w file to the project from the game archives.
    /// </summary>
    /// <param name="path">The file to write to</param>
    /// <param name="cr2w">File to be saved</param>
    public virtual void SaveToProject(string path, CR2WFile cr2w)
    {
        if (_projectManager.ActiveProject is null)
        {
            return;
        }
        SaveAs(Path.Combine(_projectManager.ActiveProject.ModDirectory, path), s =>
        {
            using FileStream fs = new(s, FileMode.Create);
            using var writer = new CR2WWriter(fs) { LoggerService = _loggerService };
            writer.WriteFile(cr2w);
        });
    }

    /// <summary>
    /// Add the specified gameFile file to the project from the game archives.
    /// </summary>
    /// <param name="path">The file to write to</param>
    /// <param name="gameFile">File to be saved</param>
    public virtual void SaveToProject(string path, IGameFile gameFile)
    {
        if (_projectManager.ActiveProject is null)
        {
            return;
        }
        SaveAs(Path.Combine(_projectManager.ActiveProject.ModDirectory, path), s =>
        {
            using FileStream fs = new(s, FileMode.Create);
            gameFile.Extract(fs);
        });
    }

    /// <summary>
    /// Save the specified text to the specified path in the raw folder
    /// </summary>
    /// <param name="path">The file to write to</param>
    /// <param name="content">The string to write to the file</param>
    public virtual void SaveToRaw(string path, string content)
    {
        if (_projectManager.ActiveProject is null)
        {
            return;
        }
        SaveAs(Path.Combine(_projectManager.ActiveProject.RawDirectory, path), s => File.WriteAllText(s, content));
    }

    /// <summary>
    /// Save the specified text to the specified path in the resources folder
    /// </summary>
    /// <param name="path">The file to write to</param>
    /// <param name="content">The string to write to the file</param>
    public virtual void SaveToResources(string path, string content)
    {
        if (_projectManager.ActiveProject is null)
        {
            return;
        }
        SaveAs(Path.Combine(_projectManager.ActiveProject.ResourcesDirectory, path), s => File.WriteAllText(s, content));
    }

    private void SaveAs(string path, Action<string> action)
    {
        FileInfo diskPathInfo = new(path);
        if (diskPathInfo.Directory == null)
        {
            return;
        }

        if (!File.Exists(diskPathInfo.FullName))
        {
            Directory.CreateDirectory(diskPathInfo.Directory.FullName);
        }

        try
        {
            action(diskPathInfo.FullName);
        }
        catch (Exception ex)
        {
            File.Delete(diskPathInfo.FullName);
            _loggerService.Error(ex);
        }
    }

    /// <summary>
    /// Loads the content of a text file from resources
    /// </summary>
    /// <param name="path">The relative path of the text file</param>
    /// <returns>The content or null</returns>
    public virtual string? LoadFromResources(string path)
    {
        if (_projectManager.ActiveProject is null)
        {
            return null;
        }

        var fullPath = Path.Combine(_projectManager.ActiveProject.ResourcesDirectory, path);
        if (!File.Exists(fullPath))
        {
            return null;
        }

        return File.ReadAllText(fullPath);
    }

    /// <summary>
    /// Loads the specified game file from the project files rather than game archives.
    /// </summary>
    /// <param name="path">The file to open for reading</param>
    /// <param name="type">The type of the object which is returned. Can be "cr2w" or "json"</param>
    /// <returns></returns>
    public virtual object? LoadGameFileFromProject(string path, string type)
    {
        if (_archiveManager.ProjectArchive is not FileSystemArchive projectArchive)
        {
            _loggerService.Error("No project loaded");
            return null;
        }

        foreach (var (_, gameFile) in projectArchive.Files)
        {
            if (gameFile.FileName != path)
            {
                continue;
            }

            using var ms = new MemoryStream();
            gameFile.Extract(ms);
            ms.Position = 0;
            
            using var cr = new CR2WReader(ms);

            if (cr.ReadFile(out var cr2wFile) != EFileReadErrorCodes.NoError)
            {
                _loggerService.Error($"\"{gameFile.FileName}\" is not a CR2W file");
                return null;
            }

            if (type == "cr2w")
            {
                return cr2wFile;
            }

            if (type == "json")
            {
                var dto = new RedFileDto(cr2wFile!);
                return RedJsonSerializer.Serialize(dto);
            }

            _loggerService.Error($"Unsupported load type \"{type}\"");
            return null;
        }

        return null;
    }

    /// <summary>
    /// Loads the specified json file from the project raw files rather than game archives.
    /// </summary>
    /// <param name="path">The file to open for reading</param>
    /// <param name="type">The type of the object which is returned. Can be "cr2w" or "json"</param>
    /// <returns></returns>
    public virtual object? LoadRawJsonFromProject(string path, string type)
    {
        if (_archiveManager.ProjectArchive is not FileSystemArchive projectArchive)
        {
            _loggerService.Error("No project loaded");
            return null;
        }

        foreach (var file in Directory.EnumerateFiles(projectArchive.Project.RawDirectory, "*.*", SearchOption.AllDirectories))
        {
            var relPath = Path.GetRelativePath(projectArchive.Project.RawDirectory, file);
            if (relPath == path)
            {
                var json = File.ReadAllText(file);

                if (type == "json")
                {
                    return json;
                }

                if (type == "cr2w")
                {
                    var ser = RedJsonSerializer.Deserialize<RedFileDto>(json);
                    if (ser == null)
                    {
                        _loggerService.Error($"Could not parse \"{file}\"");
                        return null;
                    }
                    return ser.Data;
                }

                _loggerService.Error($"Unsupported load type \"{type}\"");
                return null;
            }
        }

        return null;
    }

    /// <summary>
    /// Retrieves a list of files from the project
    /// </summary>
    /// <param name="folderType">string parameter folderType = "archive" or "raw"</param>
    /// <returns></returns>
    public List<string> GetProjectFiles(string folderType)
    {
        var result = new List<string>();

        if (_projectManager.ActiveProject == null)
        {
            _loggerService.Error("No project loaded");
            return result;
        }

        string baseFolder;

        switch (folderType)
        {
            case "archive":
                baseFolder = _projectManager.ActiveProject.ModDirectory;
                break;

            case "raw":
                baseFolder = _projectManager.ActiveProject.RawDirectory;
                break;

            default:
                _loggerService.Error($"Unsupported folder type \"{folderType}\"");
                return result;
        }

        foreach (var file in Directory.GetFiles(baseFolder, "*.*", SearchOption.AllDirectories))
        {
            result.Add(Path.GetRelativePath(baseFolder, file));
        }

        return result;
    }

    private T ParseExportSettings<T>(ScriptObject scriptSettingsObject) where T : ExportArgs, new()
    {
        var exportArgs = new T();
        foreach (var prop in exportArgs.GetType().GetProperties())
        {
            if (scriptSettingsObject.PropertyNames.Contains(prop.Name))
            {
                SetValue(prop, exportArgs, prop.Name);
            }

            if (Attribute.GetCustomAttribute(prop, typeof(WkitScriptAccess)) is WkitScriptAccess scriptAccess && scriptSettingsObject.PropertyNames.Contains(scriptAccess.ScriptName))
            {
                SetValue(prop, exportArgs, scriptAccess.ScriptName);
            }
        }
        return exportArgs;

        void SetValue(PropertyInfo prop, object instance, string name)
        {
            if (prop.PropertyType.IsEnum)
            {
                prop.SetValue(exportArgs, Enum.Parse(prop.PropertyType, (string)scriptSettingsObject[name]));
            }
            else if (prop.PropertyType == typeof(List<FileEntry>))
            {
                if (scriptSettingsObject[name] is not IList lstValue)
                {
                    _loggerService.Error($"Setting \"{name}\" needs to be a array of strings");
                    throw new NotSupportedException();
                }

                var lst = new List<FileEntry>();

                foreach (var entry in lstValue)
                {
                    if (entry is not string entryStr)
                    {
                        _loggerService.Error($"Setting \"{name}\" needs to be a array of strings");
                        throw new NotSupportedException();
                    }

                    ResourcePath resourcePath;
                    if (ulong.TryParse(entryStr, out var entryStrHash))
                    {
                        resourcePath = entryStrHash;
                    }
                    else
                    {
                        resourcePath = entryStr;
                    }

                    var fileEntry = _archiveManager.Archives.Items
                        .SelectMany(x => x.Files.Values)
                        .Cast<FileEntry>()
                        .FirstOrDefault(x => x.NameHash64 == resourcePath);

                    if (fileEntry is not { })
                    {
                        _loggerService.Warning($"File \"{entryStr}\" could not be found. Skipping");
                        continue;
                    }

                    lst.Add(fileEntry);
                }

                prop.SetValue(exportArgs, lst);
            }
            else
            {
                prop.SetValue(exportArgs, scriptSettingsObject[name]);
            }
        }
    }

    private GlobalExportArgs GetGlobalExportArgs(ScriptObject settings)
    {
        var result = new GlobalExportArgs();

        if (settings["Common"] is ScriptObject commonSettings)
        {
            result.Register(ParseExportSettings<CommonExportArgs>(commonSettings));
        }

        if (settings["MorphTarget"] is ScriptObject morphTargetSettings)
        {
            result.Register(ParseExportSettings<MorphTargetExportArgs>(morphTargetSettings));
        }

        if (settings["MlMask"] is ScriptObject mlMaskSettings)
        {
            result.Register(ParseExportSettings<MlmaskExportArgs>(mlMaskSettings));
        }

        if (settings["Xbm"] is ScriptObject xbmSettings)
        {
            result.Register(ParseExportSettings<XbmExportArgs>(xbmSettings));
        }

        if (settings["Mesh"] is ScriptObject meshSettings)
        {
            result.Register(ParseExportSettings<MeshExportArgs>(meshSettings));
        }

        if (settings["Animation"] is ScriptObject animationSettings)
        {
            result.Register(ParseExportSettings<AnimationExportArgs>(animationSettings));
        }

        if (settings["Wem"] is ScriptObject wemSettings)
        {
            result.Register(ParseExportSettings<WemExportArgs>(wemSettings));
        }

        if (settings["Opus"] is ScriptObject opusSettings)
        {
            result.Register(ParseExportSettings<OpusExportArgs>(opusSettings));
        }

        if (settings["Entity"] is ScriptObject entitySettings)
        {
            result.Register(ParseExportSettings<EntityExportArgs>(entitySettings));
        }

        if (settings["InkAtlas"] is ScriptObject inkAtlasSettings)
        {
            result.Register(ParseExportSettings<InkAtlasExportArgs>(inkAtlasSettings));
        }

        if (settings["Fnt"] is ScriptObject fntSettings)
        {
            result.Register(ParseExportSettings<FntExportArgs>(fntSettings));
        }

        return result;
    }

    /// <summary>
    /// Exports a list of files as you would with the export tool.
    /// </summary>
    /// <param name="fileList"></param>
    /// <param name="defaultSettings"></param>
    /// <param name="blocking"></param>
    public void ExportFiles(IList fileList, ScriptObject? defaultSettings = null)
    {
        if (_projectManager.ActiveProject is not { } proj)
        {
            _loggerService.Error("No project loaded");
            return;
        }

        var fileDict = new Dictionary<FileInfo, GlobalExportArgs>();
        foreach (var entry in fileList)
        {
            if (entry is IList settingsPair)
            {
                if (settingsPair is [string filePath1])
                {
                    AddFile(filePath1, defaultSettings);
                    continue;
                }

                if (settingsPair is [string filePath2, ScriptObject settings])
                {
                    AddFile(filePath2, settings);
                    continue;
                }
            }

            if (entry is string fileStr)
            {
                AddFile(fileStr, defaultSettings);
                continue;
            }

            _loggerService.Warning($"\"{entry}\" is not a valid entry");
        }

        Parallel.ForEach(fileDict, (kvp) =>
        {
            if (kvp.Value.Get<MeshExportArgs>().MeshExporter == MeshExporterType.REDmod)
            {
                Task.Run(() => _importExportHelper.Export(new DirectoryInfo(proj.ModDirectory), kvp.Key, new DirectoryInfo(proj.RawDirectory), kvp.Value.Get<MeshExportArgs>()));
            }
            else
            {
                Task.Run(() => _importExportHelper.Export(kvp.Key, kvp.Value, new DirectoryInfo(proj.ModDirectory), new DirectoryInfo(proj.RawDirectory)));
            }
        });

        void AddFile(string filePath, ScriptObject? settings = null)
        {
            var fileInfo = new FileInfo(Path.Combine(proj.ModDirectory, filePath));
            if (!fileInfo.Exists)
            {
                _loggerService.Warning($"\"{filePath}\" doesn't exists in the project. Skipping");
                return;
            }

            if (!Enum.TryParse<ECookedFileFormat>(Path.GetExtension(filePath).TrimStart('.'), out var ext))
            {
                _loggerService.Warning($"Exporting \"{ext}\" files isn't supported. Skipping");
                return;
            }

            var globalExport = settings != null ? GetGlobalExportArgs(settings) : new GlobalExportArgs();
            _importExportHelper.Finalize(globalExport);

            fileDict.Add(fileInfo, globalExport);
        }
    }

    /// <summary>
    /// Loads a file from the project using either a file path or hash
    /// </summary>
    /// <param name="path">The path of the file to retrieve</param>
    /// <param name="openAs">The output format (OpenAs.GameFile, OpenAs.CR2W or OpenAs.Json)</param>
    /// <returns></returns>
    public virtual object? GetFileFromProject(string path, OpenAs openAs)
    {
        if (string.IsNullOrEmpty(path))
        {
            return null;
        }

        if (!ulong.TryParse(path, out var hash))
        {
            hash = FNV1A64HashAlgorithm.HashString(path);
        }

        return GetFileFromProject(hash, openAs);
    }

    /// <summary>
    /// Loads a file from the project using either a file path or hash
    /// </summary>
    /// <param name="hash">The hash of the file to retrieve</param>
    /// <param name="openAs">The output format (OpenAs.GameFile, OpenAs.CR2W or OpenAs.Json)</param>
    /// <returns></returns>
    public virtual object? GetFileFromProject(ulong hash, OpenAs openAs)
    {
        if (hash == 0)
        {
            return null;
        }

        if (_projectManager.ActiveProject == null)
        {
            return null;
        }

        IGameFile? targetFile = null;

        if (_archiveManager.ProjectArchive is not FileSystemArchive projectArchive)
        {
            throw new Exception();
        }

        foreach (var (fileHash, file) in projectArchive.Files)
        {
            if (fileHash == hash)
            {
                targetFile = file;
                break;
            }
        }

        if (targetFile == null)
        {
            return null;
        }

        return ConvertGameFile(targetFile, openAs);
    }

    /// <summary>
    /// Loads a file from the project or archive (in this order) using either a file path or hash
    /// </summary>
    /// <param name="path">The path of the file to retrieve</param>
    /// <param name="openAs">The output format (OpenAs.GameFile, OpenAs.CR2W or OpenAs.Json)</param>
    /// <returns></returns>
    public virtual object? GetFile(string path, OpenAs openAs)
    {
        if (string.IsNullOrEmpty(path))
        {
            return null;
        }

        if (!ulong.TryParse(path, out var hash))
        {
            hash = FNV1A64HashAlgorithm.HashString(path);
        }

        return GetFile(hash, openAs);
    }

    /// <summary>
    /// Loads a file from the project or archive (in this order) using either a file path or hash
    /// </summary>
    /// <param name="hash">The hash of the file to retrieve</param>
    /// <param name="openAs">The output format (OpenAs.GameFile, OpenAs.CR2W or OpenAs.Json)</param>
    /// <returns></returns>
    public virtual object? GetFile(ulong hash, OpenAs openAs)
    {
        var file = GetFileFromProject(hash, openAs);
        if (file != null)
        {
            return file;
        }

        file = GetFileFromArchive(hash, openAs);
        if (file != null)
        {
            return file;
        }

        return null;
    }

    /// <summary>
    /// Check if file exists in the project
    /// </summary>
    /// <param name="path">file path to check</param>
    /// <returns></returns>
    public virtual bool FileExistsInProject(string path) => GetFileFromProject(path, OpenAs.GameFile) != null;

    /// <summary>
    /// Check if file exists in the project
    /// </summary>
    /// <param name="hash">hash value to be checked</param>
    /// <returns></returns>
    public virtual bool FileExistsInProject(ulong hash) => GetFileFromProject(hash, OpenAs.GameFile) != null;

    /// <summary>
    /// Check if file exists in either the game archives or the project
    /// </summary>
    /// <param name="path">file path to check</param>
    /// <returns></returns>
    public virtual bool FileExists(string path)
    {
        if (string.IsNullOrEmpty(path))
        {
            return false;
        }

        if (!ulong.TryParse(path, out var hash))
        {
            hash = FNV1A64HashAlgorithm.HashString(path);
        }

        return FileExists(hash);
    }

    /// <summary>
    /// Check if file exists in either the game archives or the project
    /// </summary>
    /// <param name="hash">hash value to be checked</param>
    /// <returns></returns>
    public virtual bool FileExists(ulong hash)
    {
        if (FileExistsInProject(hash))
        {
            return true;
        }

        if (FileExistsInArchive(hash))
        {
            return true;
        }

        return false;
    }

    /// <summary>
    /// Displays a message box
    /// </summary>
    /// <param name="text">A string that specifies the text to display.</param>
    /// <param name="caption">A string that specifies the title bar caption to display.</param>
    /// <param name="image">A WMessageBoxImage value that specifies the icon to display.</param>
    /// <param name="buttons">A WMessageBoxButtons value that specifies which buttons to display.</param>
    /// <returns>A WMessageBoxResult value that specifies the result the message box button that was clicked by the user returned.</returns>
    public virtual WMessageBoxResult ShowMessageBox(string text, string caption, WMessageBoxImage image, WMessageBoxButtons buttons)
    {
        var response = WMessageBoxResult.None;
        Application.Current.Dispatcher.Invoke(() =>
        {
            response = Interactions.ShowConfirmation((text, caption, image, buttons));
        });
        return response;
    }

    /// <summary>
    /// Extracts a file from the base archive and adds it to the project
    /// </summary>
    /// <param name="path">Path of the game file</param>
    public virtual void Extract(string path)
    {
        if (string.IsNullOrEmpty(path))
        {
            return;
        }

        if (!ulong.TryParse(path, out var hash))
        {
            hash = FNV1A64HashAlgorithm.HashString(path);
        }

        _gameController.GetController().AddToMod(hash);
    }

    /// <summary>
    /// Gets the current active document from the docking manager
    /// </summary>
    /// <returns></returns>
    public virtual ScriptDocumentWrapper? GetActiveDocument()
    {
        if (AppViewModel?.ActiveDocument == null)
        {
            return null;
        }

        return new ScriptDocumentWrapper(AppViewModel.ActiveDocument, AppViewModel);
    }

    /// <summary>
    /// Gets all documents from the docking manager
    /// </summary>
    /// <returns></returns>
    public virtual IList<ScriptDocumentWrapper>? GetDocuments()
    {
        if (AppViewModel == null)
        {
            return null;
        }

        var result = new List<ScriptDocumentWrapper>();
        foreach (var dockElement in AppViewModel.DockedViews)
        {
            if (dockElement is IDocumentViewModel documentViewModel)
            {
                result.Add(new ScriptDocumentWrapper(documentViewModel, AppViewModel));
            }
        }

        return result;
    }

    /// <summary>
    /// Opens a file in WolvenKit
    /// </summary>
    /// <param name="path">Path to the file</param>
    /// <returns>Returns true if the file was opened, otherwise it returns false</returns>
    public virtual bool OpenDocument(string path)
    {
        if (string.IsNullOrEmpty(path))
        {
            return false;
        }

        if (AppViewModel == null)
        {
            return false;
        }

        if (File.Exists(path))
        {
            AppViewModel.RequestFileOpen(path);
            return true;
        }

        var hash = FNV1A64HashAlgorithm.HashString(path);
        var archiveFile = _archiveManager.Lookup(hash);
        if (archiveFile.HasValue)
        {
            DispatcherHelper.RunOnMainThread(() => AppViewModel.OpenRedFileCommand.SafeExecute(archiveFile.Value));
            return true;
        }

        return false;
    }

    /// <summary>
    /// Opens an archive game file
    /// </summary>
    /// <param name="gameFile">The game file to open</param>
    public virtual void OpenDocument(IGameFile gameFile)
    {
        if (AppViewModel == null)
        {
            return;
        }

        DispatcherHelper.RunOnMainThread(() => AppViewModel.OpenRedFileCommand.SafeExecute(gameFile));
    }

    /// <summary>
    /// Exports an geometry_cache entry
    /// </summary>
    /// <param name="sectorHashStr">Sector hash as string</param>
    /// <param name="entryHashStr">Entry hash as string</param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public virtual string? ExportGeometryCacheEntry(string sectorHashStr, string entryHashStr)
    {
        if (!ulong.TryParse(sectorHashStr, out var sectorHash))
        {
            _loggerService.Error($"\"{nameof(sectorHashStr)}\" needs to be a ulong");
            throw new Exception();
        }

        if (!ulong.TryParse(entryHashStr, out var entryHash))
        {
            _loggerService.Error($"\"{nameof(entryHashStr)}\" needs to be a ulong");
            throw new Exception();
        }

        var cacheEntry = _geometryCacheService.GetEntry(sectorHash, entryHash);
        if (cacheEntry == null)
        {
            _loggerService.Info("Cache entry not found!");
            return null;
        }

        return JsonSerializer.Serialize((object)cacheEntry, new JsonSerializerOptions { IncludeFields = true, WriteIndented = true });
    }
}