using System.Collections.Concurrent;
using WolvenKit.App.Models;
using WolvenKit.Modkit.RED4.Project;

namespace WolvenKit.App.Services;

public interface IWatcherService
{
    public DispatchedObservableCollection<FileSystemModel> FileTree { get; }
    public DispatchedObservableCollection<FileSystemModel> FileList { get; }
    public ConcurrentDictionary<string, FileSystemModel> FileLookup { get; }

    public void Refresh();

    public void ForceStop();

    public void Suspend();
    public void Resume();

    public void UnwatchProject(Cp77Project? project);
    public void WatchProject(Cp77Project project);

    public bool IsWatcherStopped { get; }

}
