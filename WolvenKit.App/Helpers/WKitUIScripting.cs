using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Windows;
using Microsoft.ClearScript;
using WolvenKit.App.Factories;
using WolvenKit.App.Interaction;
using WolvenKit.App.Services;
using WolvenKit.Common;
using WolvenKit.Common.Conversion;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Modkit.Scripting;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.JSON;
using EFileReadErrorCodes = WolvenKit.RED4.Archive.IO.EFileReadErrorCodes;

namespace WolvenKit.App.Helpers;

/// <summary>
/// TODO
/// </summary>
public class WKitUIScripting : WKitScripting
{
    private readonly IProjectManager _projectManager;
    private readonly IWatcherService _watcherService;
    private readonly IPaneViewModelFactory _paneViewModelFactory;

    public WKitUIScripting(
        IPaneViewModelFactory paneViewModelFactory,
        ILoggerService loggerService, 
        IProjectManager projectManager, 
        IArchiveManager archiveManager, 
        Red4ParserService parserService, 
        IWatcherService watcherService) 
        : base(loggerService, archiveManager, parserService)
    {
        _projectManager = projectManager;
        _watcherService = watcherService;
        _paneViewModelFactory = paneViewModelFactory;
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
    /// Save the specified file to the project raw folders, in either json or CR2W
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
    /// Loads the specified game file from the project files rather than game archives.
    /// </summary>
    /// <param name="path">The file to open for reading</param>
    /// <param name="type">The type of the object which is returned. Can be "cr2w" or "json"</param>
    /// <returns></returns>
    public virtual object? LoadGameFileFromProject(string path, string type)
    {
        if (_projectManager.ActiveProject == null)
        {
            _loggerService.Error("No project loaded");
            return null;
        }

        foreach (var file in Directory.EnumerateFiles(_projectManager.ActiveProject.ModDirectory, "*.*", SearchOption.AllDirectories))
        {
            var relPath = Path.GetRelativePath(_projectManager.ActiveProject.ModDirectory, file);
            if (relPath == path)
            {
                using var fs = File.Open(file, FileMode.Open);
                using var cr = new CR2WReader(fs);

                if (cr.ReadFile(out var cr2wFile) != EFileReadErrorCodes.NoError)
                {
                    _loggerService.Error($"\"{relPath}\" is not a CR2W file");
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
        if (_projectManager.ActiveProject == null)
        {
            _loggerService.Error("No project loaded");
            return null;
        }

        foreach (var file in Directory.EnumerateFiles(_projectManager.ActiveProject.RawDirectory, "*.*", SearchOption.AllDirectories))
        {
            var relPath = Path.GetRelativePath(_projectManager.ActiveProject.RawDirectory, file);
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
        // find all of the matching scriptable properties the script provided
        var exportArgs = new T();
        var s = exportArgs.GetType().GetProperties()
            .Where(x =>
            {
                var includeProp = Attribute.IsDefined(x, typeof(WkitScriptAccess));
                if (includeProp)
                {
                    if (Attribute.GetCustomAttribute(x, typeof(WkitScriptAccess)) is WkitScriptAccess scriptAccess)
                    {
                        includeProp &= scriptSettingsObject.PropertyNames.Contains(scriptAccess.ScriptName);
                    }
                }

                return includeProp;
            });

        foreach (var prop in s)
        {
            // now set their value
            if (Attribute.GetCustomAttribute(prop, typeof(WkitScriptAccess)) is WkitScriptAccess scriptAccess)
            {
                if (prop.PropertyType.IsEnum)
                {
                    Enum.TryParse(prop.PropertyType, scriptSettingsObject[scriptAccess.ScriptName].ToString(), out var val);
                    prop.SetValue(exportArgs, val);
                }
                else
                {
                    prop.SetValue(exportArgs, scriptSettingsObject[scriptAccess.ScriptName]);
                }
            }
        }

        return exportArgs;
    }

    /// <summary>
    /// Exports a list of files as you would with the export tool.
    /// </summary>
    /// <param name="exportList"></param>
    /// <param name="exportSettings"></param>
    /// <exception cref="Exception"></exception>
    /// <exception cref="ArgumentNullException"></exception>
    public async void ExportFiles(dynamic exportList, dynamic? exportSettings = null)
    {
        List<string> internalExportList;

        // dynamic type checking
        // TODO: mix in hashes (V8 doesn't have a ulong equivalent though)
        switch (exportList)
        {
            case IList list:
                internalExportList = new List<string>();
                foreach (var item in list)
                {
                    if (item is not string str)
                    {
                        throw new Exception($"Unexpected datatype found for {nameof(exportList)}. Expected string or string[].");
                    }
                    internalExportList.Add(str);
                }
                break;
            case string exportString:
                internalExportList = new List<string> { exportString };
                break;
            case FileEntry fileEntry:
                internalExportList = new List<string> { fileEntry.FileName };
                break;
            case null:
                throw new ArgumentNullException(nameof(exportList));
            default:
                throw new Exception($"Unexpected datatype found for {nameof(exportList)}. Expected string or string[].");
        }

        // get the export view model and clear the items
        var expVM = _paneViewModelFactory.ExportViewModel();
        await expVM.RefreshCommand.ExecuteAsync(null);

        foreach (var item in expVM.Items)
        {
            item.IsChecked = false;
        }

        // handle any settings if we have them
        // TODO: clean this up a bit to auto handle all export types instead of manually checking
        switch (exportSettings)
        {
            case ScriptObject settings:
                if (settings["Mesh"] is ScriptObject meshSettings)
                {
                    var exportArgs = ParseExportSettings<MeshExportArgs>(meshSettings);

                    // set the export settings for meshes in the vm
                    foreach (var x in expVM.Items.Where(_ => _.Properties.GetType() == typeof(MeshExportArgs)))
                    {
                        x.Properties = exportArgs;
                    }
                }
                if (settings["Xbm"] is ScriptObject xbmSettings)
                {
                    var exportArgs = ParseExportSettings<XbmExportArgs>(xbmSettings);

                    // set the export settings for images in the vm
                    foreach (var x in expVM.Items.Where(_ => _.Properties.GetType() == typeof(XbmExportArgs)))
                    {
                        x.Properties = exportArgs;
                    }
                }
                if (settings["Opus"] is ScriptObject opusSettings)
                {
                    var exportArgs = ParseExportSettings<OpusExportArgs>(opusSettings);

                    // set the export settings for opus files in the vm
                    foreach (var x in expVM.Items.Where(_ => _.Properties.GetType() == typeof(OpusExportArgs)))
                    {
                        x.Properties = exportArgs;
                    }
                }
                if (settings["Wem"] is ScriptObject wemSettings)
                {
                    var exportArgs = ParseExportSettings<WemExportArgs>(wemSettings);

                    // set the export settings for wems in the vm
                    foreach (var x in expVM.Items.Where(_ => _.Properties.GetType() == typeof(WemExportArgs)))
                    {
                        x.Properties = exportArgs;
                    }
                }
                if (settings["MorphTarget"] is ScriptObject morphTargetSettings)
                {
                    var exportArgs = ParseExportSettings<MorphTargetExportArgs>(morphTargetSettings);

                    // set the export settings for morphtargets in the vm
                    foreach (var x in expVM.Items.Where(_ => _.Properties.GetType() == typeof(MorphTargetExportArgs)))
                    {
                        x.Properties = exportArgs;
                    }
                }
                if (settings["MlMask"] is ScriptObject mlMaskSettings)
                {
                    var exportArgs = ParseExportSettings<MlmaskExportArgs>(mlMaskSettings);

                    // set the export settings for mlmasks in the vm
                    foreach (var x in expVM.Items.Where(_ => _.Properties.GetType() == typeof(MlmaskExportArgs)))
                    {
                        x.Properties = exportArgs;
                    }
                }
                if (settings["Animation"] is ScriptObject animationSettings)
                {
                    var exportArgs = ParseExportSettings<AnimationExportArgs>(animationSettings);

                    // set the export settings for animations in the vm
                    foreach (var x in expVM.Items.Where(_ => _.Properties.GetType() == typeof(AnimationExportArgs)))
                    {
                        x.Properties = exportArgs;
                    }
                }
                break;
            default:
                _loggerService.Warning("Unknown type found for ExportFiles settings. The settings used in the Export Tool will be used.");
                break;
        }

        // loop over each item to export and export the item
        foreach (var exportItem in internalExportList)
        {
            if (exportItem is { } exportPath)
            {
                if (exportPath.Length == 0)
                {
                    continue;
                }

                // check extension is exportable
                var uncookExts = Enum.GetNames(typeof(ECookedFileFormat));
                var ext = Path.GetExtension(exportPath).Replace(".", "");
                if (!uncookExts.Any(_ => _.Equals(ext, StringComparison.InvariantCultureIgnoreCase)))
                {
                    _loggerService.Warning($"{exportPath} does not contain a valid export extension. Skipping.");
                    continue;
                }

                // we possibly have a relative path, so convert it to the project path
                if (!Path.IsPathFullyQualified(exportPath))
                {
                    if (_projectManager.IsProjectLoaded)
                    {
                        exportPath = Path.Combine(_projectManager.ActiveProject.NotNull().ModDirectory, exportPath);
                    }
                    else
                    {
                        _loggerService.Warning($"{exportPath} is a relative path and therefore cannot be resolved with an unloaded project. Skipping.");
                        continue;
                    }
                }

                if (!Path.Exists(exportPath))
                {
                    _loggerService.Warning($"{exportPath} could not be found. Skipping.");
                    continue;
                }

                // Set the item to be checked
                foreach (var item in expVM.Items.Where(_ => _.BaseFile.EndsWith(exportPath, StringComparison.InvariantCultureIgnoreCase)))
                {
                    item.IsChecked = true;
                }
            }
        }

        // export all the checked items if we have any
        if (expVM.Items.Any(_ => _.IsChecked))
        {
            await expVM.ProcessSelectedCommand.ExecuteAsync(Unit.Default);
        }
    }

    /// <summary>
    /// Check if file exists in the project
    /// </summary>
    /// <param name="path">file path to check</param>
    /// <returns></returns>
    public virtual bool FileExistsInProject(string path)
    {
        if (string.IsNullOrEmpty(path))
        {
            return false;
        }

        if (!ulong.TryParse(path, out var hash))
        {
            hash = FNV1A64HashAlgorithm.HashString(path);
        }

        return FileExistsInProject(hash);
    }

    /// <summary>
    /// Check if file exists in the project
    /// </summary>
    /// <param name="hash">hash value to be checked</param>
    /// <returns></returns>
    public virtual bool FileExistsInProject(ulong hash)
    {
        if (hash == 0)
        {
            return false;
        }

        if (_projectManager.ActiveProject == null)
        {
            return false;
        }

        var projectArchive = _projectManager.ActiveProject.AsArchive();
        foreach (var (fileHash, _) in projectArchive.Files)
        {
            if (fileHash == hash)
            {
                return true;
            }
        }

        return false;
    }

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
}