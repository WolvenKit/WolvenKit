using System.Collections.Concurrent;
using System.Collections.Generic;
using WolvenKit.App.Models;
using WolvenKit.App.Models.ProjectManagement.Project;

namespace WolvenKit.App.Services;

public interface IWatcherService
{
    public DispatchedObservableCollection<FileSystemModel> FileTree { get; }
    public DispatchedObservableCollection<FileSystemModel> FileList { get; }
    public ConcurrentDictionary<string, FileSystemModel> FileLookup { get; }
    Dictionary<string, bool> ExpansionStateDictionary { get; set; }

    public void Refresh();

    public void ForceStop();

    public void Suspend();
    public void Resume();

    public void UnwatchProject(Cp77Project? project);
    public void WatchProject(Cp77Project project);

    public bool IsWatcherStopped { get; }

    bool? GetExpansionStateOrNull(string relPath);
}
