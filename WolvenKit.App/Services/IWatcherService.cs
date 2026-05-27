using WolvenKit.App.Models;
using WolvenKit.App.Models.ProjectManagement.Project;

namespace WolvenKit.App.Services;

public interface IWatcherService
{
    /// <summary>
    /// Data model representing the current files and folders hierarchically of the mod directory.
    /// </summary>
    public DispatchedObservableCollection<FileSystemModel> FileTree { get; }

    /// <summary>
    /// Data model representing the files (not folders) of the mod directory in a flat list.
    /// </summary>
    public DispatchedObservableCollection<FileSystemModel> FileList { get; }

    /// <summary>
    /// Instructs the WatcherService to stop all file monitoring, clear the existing data models,
    /// then rebuild those data models from disk, then begin monitoring for file system changes again.
    /// </summary>
    public void Refresh();

    // TODO: Get rid of this method and just use UnwatchProject or Suspend.
    public void ForceStop();

    /// <summary>
    /// Tells the OS-level API to stop sending file system events to the WatcherService temporarily.
    /// This should be called before performing operations that may add files to the project and data model
    /// via another pathway.
    /// </summary>
    public void Suspend();

    /// <summary>
    /// Tells the OS-level API to stop sending file system events to the WatcherService temporarily.
    /// This should be called after performing operations that may add files to the project and data model
    /// via another pathway. Such methods should already call this automatically.
    /// </summary>
    public void Resume();

    /// <summary>
    /// Returns the data models to a state similar to app launch: no active project, no files in the data models
    /// that represent mod directories, no active file system event watcher, and no background tasks polling for
    /// file system events from the OS. Any such active processes are killed by this method.
    /// </summary>
    /// <param name="project"></param>
    public void UnwatchProject(Cp77Project? project);

    /// <summary>
    /// Populates the data models FileTree and FileList for the mod directory from disk and begins tracking any
    /// file system events to automatically add files to the project. Establishes background processes to poll for
    /// such file system events and remains ready to receive published events to add files to the active project.
    /// </summary>
    /// <param name="project"></param>
    public void WatchProject(Cp77Project project);

    // TODO: Migrate this to "WatcherState" with "NoProject" "Suspended" and "Active" states.
    public bool IsWatcherStopped { get; }

}
