using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive;
using MoreLinq;
using Splat;
using WolvenKit.Common;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Services;
using WolvenKit.Modkit.Scripting;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.App.Helpers;

public class WKitUIScripting : WKitScripting
{
    private readonly IProjectManager _projectManager;

    public WKitUIScripting(ILoggerService loggerService) : base(loggerService) => _projectManager = Locator.Current.GetService<IProjectManager>();

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
        SaveAs(Path.Combine(_projectManager.ActiveProject.RawDirectory, path), s =>
        {
            File.WriteAllText(s, content);
        });

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

    public void ExportFiles(dynamic relPaths)
    {
        if (relPaths is null)
        {
            throw new ArgumentNullException(nameof(relPaths));
        }
        else if (relPaths is string)
        {
            // since relPaths is dynamic we can support string, or string[]
            // this converts a single string to an array (thanks JavaScript)
            relPaths = new string[] { relPaths };
        }
        else
        {
            try
            {
                // this will catch exceptions with the (IList) conversion
                // Cast<string> is lazy and  will be caught later
                relPaths = ((IList)relPaths).Cast<string>();
            }
            catch (InvalidCastException ice)
            {
                _loggerService.Error("Unexpected data type found for argument \"relPaths\" in \"ExportFiles\".");
                _loggerService.Error(ice.Message);
            }
            catch (Exception e)
            {
                _loggerService.Error(e);
            }
        }

        var watcherService = Locator.Current.GetService<IWatcherService>();
        var impExpVM = Locator.Current.GetService<AppViewModel>().ImportExportToolVM;

        impExpVM.IsExportsSelected = true;
        impExpVM.IsImportsSelected = false;

        // unset every item in ExportItems
        foreach (var expItem in impExpVM.ExportableItems)
        {
            expItem.IsChecked = false;
        }

        try
        {
            var uncookExts = Enum.GetNames(typeof(ECookedFileFormat));
            foreach (var relPath in relPaths)
            {
                var filePath = Path.Combine(_projectManager.ActiveProject.ModDirectory, (string)relPath);
                var ext = Path.GetExtension(filePath).Replace(".", "");
                if (!File.Exists(filePath))
                {
                    _loggerService.Info($"{relPath} could not be found.");
                    continue;
                }
                if (!uncookExts.Any(e => e == ext))
                {
                    _loggerService.Info($"{relPath} is not an exportable CR2W file.");
                    continue;
                }

                // Set the item to be checked
                impExpVM.ExportableItems.Where(_ => _.FullName == filePath)
                    .ForEach(_ => _.IsChecked = true);
            }
            impExpVM.ProcessSelectedCommand.Execute(Unit.Default);
        }
        catch (InvalidCastException ice)
        {
            _loggerService.Error("Unexpected data type found for argument \"relPaths\" in \"ExportFiles\".");
            _loggerService.Error(ice.Message);
        }
        catch (Exception e)
        {
            _loggerService.Error(e);
        }
    }
}