using System;
using System.IO;
using Splat;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Services;
using WolvenKit.Modkit.Scripting;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;

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
}