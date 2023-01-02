using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Reactive;
using Microsoft.ClearScript;
using MoreLinq;
using Splat;
using WolvenKit.App.ViewModels.Exporters;
using WolvenKit.Common;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Services;
using WolvenKit.Modkit.Scripting;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;

namespace WolvenKit.App.Helpers;

public class WKitUIScripting : WKitScripting
{
    private readonly IProjectManager _projectManager;

    public WKitUIScripting(ILoggerService loggerService)
        : base(loggerService) => _projectManager = Locator.Current.GetService<IProjectManager>();

    public void SuspendFileWatcher(bool suspend)
    {
        var watcherService = Locator.Current.GetService<IWatcherService>();
        if (watcherService != null && watcherService.IsSuspended != suspend)
        {
            watcherService.IsSuspended = suspend;
            if (!suspend)
            {
                watcherService.RefreshAsync(_projectManager.ActiveProject);
            }
        }
    }

    public virtual void SaveToProject(string path, CR2WFile cr2w) =>
        SaveAs(Path.Combine(_projectManager.ActiveProject.ModDirectory, path), s =>
        {
            using FileStream fs = new(s, FileMode.Create);
            using var writer = new CR2WWriter(fs);
            writer.WriteFile(cr2w);
        });

    public virtual void SaveToProject(string path, IGameFile gameFile) =>
        SaveAs(Path.Combine(_projectManager.ActiveProject.ModDirectory, path), s =>
        {
            using FileStream fs = new(s, FileMode.Create);
            gameFile.Extract(fs);
        });

    public virtual void SaveToRaw(string path, string content) =>
        SaveAs(Path.Combine(_projectManager.ActiveProject.RawDirectory, path), s => File.WriteAllText(s, content));

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

    private T ParseExportSettings<T>(ScriptObject scriptSettingsObject) where T : ExportArgs, new()
    {
        // find all of the matching scriptable properties the script provided
        var exportArgs = new T();
        exportArgs.GetType().GetProperties()
            .Where(_ =>
            {
                var includeProp = Attribute.IsDefined(_, typeof(WkitScriptAccess));
                if (includeProp)
                {
                    var scriptAccess = (WkitScriptAccess)Attribute.GetCustomAttribute(_, typeof(WkitScriptAccess));
                    includeProp &= scriptSettingsObject.PropertyNames.Contains(scriptAccess.ScriptName);
                }

                return includeProp;
            })
            .ForEach(prop =>
            {
                // now set their value
                var scriptAccess = (WkitScriptAccess)Attribute.GetCustomAttribute(prop, typeof(WkitScriptAccess));
                if (prop.PropertyType.IsEnum)
                {
                    Enum.TryParse(prop.PropertyType, scriptSettingsObject[scriptAccess.ScriptName].ToString(), out var val);
                    prop.SetValue(exportArgs, val);
                }
                else
                {
                    prop.SetValue(exportArgs, scriptSettingsObject[scriptAccess.ScriptName]);
                }
            });

        return exportArgs;
    }

    public void ExportFiles(dynamic exportList, dynamic exportSettings = null)
    {
        // dynamic type checking
        // TODO: mix in hashes (V8 doesn't have a ulong equivalent though)
        switch (exportList)
        {
            case IList list:
                foreach (var item in list)
                {
                    if (item is not string)
                    {
                        throw new Exception($"Unexpected datatype found for {nameof(exportList)}. Expected string or string[].");
                    }
                }
                break;
            case string exportString:
                exportList = new string[] { exportString };
                break;
            case FileEntry fileEntry:
                exportList = new string[] { fileEntry.FileName };
                break;
            case null:
                throw new ArgumentNullException(nameof(exportList));
            default:
                throw new Exception($"Unexpected datatype found for {nameof(exportList)}. Expected string or string[].");
        }

        // get the export view model and clear the items
        var expVM = Locator.Current.GetService<TextureExportViewModel>();
        expVM.Items.ForEach(_ => _.IsChecked = false);

        // handle any settings if we have them
        // TODO: clean this up a bit to auto handle all export types instead of manually checking
        switch (exportSettings)
        {
            case ScriptObject settings:
                if (settings["Mesh"] is ScriptObject meshSettings)
                {
                    var exportArgs = ParseExportSettings<MeshExportArgs>(meshSettings);

                    // set the export settings for meshes in the vm
                    expVM.Items.Where(_ => _.Properties.GetType() == typeof(MeshExportArgs))
                        .ForEach(_ => _.Properties = exportArgs);
                }
                if (settings["Xbm"] is ScriptObject xbmSettings)
                {
                    var exportArgs = ParseExportSettings<XbmExportArgs>(xbmSettings);

                    // set the export settings for images in the vm
                    expVM.Items.Where(_ => _.Properties.GetType() == typeof(XbmExportArgs))
                        .ForEach(_ => _.Properties = exportArgs);
                }
                if (settings["Opus"] is ScriptObject opusSettings)
                {
                    var exportArgs = ParseExportSettings<OpusExportArgs>(opusSettings);

                    // set the export settings for opus files in the vm
                    expVM.Items.Where(_ => _.Properties.GetType() == typeof(OpusExportArgs))
                        .ForEach(_ => _.Properties = exportArgs);
                }
                if (settings["Wem"] is ScriptObject wemSettings)
                {
                    var exportArgs = ParseExportSettings<WemExportArgs>(wemSettings);

                    // set the export settings for wems in the vm
                    expVM.Items.Where(_ => _.Properties.GetType() == typeof(WemExportArgs))
                        .ForEach(_ => _.Properties = exportArgs);
                }
                if (settings["MorphTarget"] is ScriptObject morphTargetSettings)
                {
                    var exportArgs = ParseExportSettings<MorphTargetExportArgs>(morphTargetSettings);

                    // set the export settings for morphtargets in the vm
                    expVM.Items.Where(_ => _.Properties.GetType() == typeof(MorphTargetExportArgs))
                        .ForEach(_ => _.Properties = exportArgs);
                }
                if (settings["MlMask"] is ScriptObject mlMaskSettings)
                {
                    var exportArgs = ParseExportSettings<MlmaskExportArgs>(mlMaskSettings);

                    // set the export settings for mlmasks in the vm
                    expVM.Items.Where(_ => _.Properties.GetType() == typeof(MlmaskExportArgs))
                        .ForEach(_ => _.Properties = exportArgs);
                }
                if (settings["Animation"] is ScriptObject animationSettings)
                {
                    var exportArgs = ParseExportSettings<AnimationExportArgs>(animationSettings);

                    // set the export settings for animations in the vm
                    expVM.Items.Where(_ => _.Properties.GetType() == typeof(AnimationExportArgs))
                        .ForEach(_ => _.Properties = exportArgs);
                }
                break;
            default:
                _loggerService.Warning("Unknown type found for ExportFiles settings. The settings used in the Export Tool will be used.");
                break;
        }

        // loop over each item to export and export the item
        foreach (var exportItem in exportList)
        {
            if (exportItem is string exportPath)
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
                        exportPath = Path.Combine(_projectManager.ActiveProject.ModDirectory, exportPath);
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
                expVM.Items.Where(_ => _.FullName.EndsWith(exportPath, StringComparison.InvariantCultureIgnoreCase))
                    .ForEach(_ => _.IsChecked = true);
            }
        }

        // export all the checked items if we have any
        if (expVM.Items.Any(_ => _.IsChecked))
        {
            expVM.ProcessSelectedCommand.Execute(Unit.Default);
        }
    }
}