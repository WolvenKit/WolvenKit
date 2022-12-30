using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Reactive;
using MoreLinq;
using Splat;
using WolvenKit.App.ViewModels.Exporters;
using WolvenKit.Common;
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

    public void ExportFiles(dynamic exportList)
    {
        // dynamic type checking
        // TODO: mix in hashes (V8 doesn't have a ulong equivalent though)
        switch (exportList)
        {
            case IList list:
                foreach(var item in list)
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

        if (expVM.Items.Any(_ => _.IsChecked))
        {
            expVM.ProcessSelectedCommand.Execute(Unit.Default);
        }
    }
}