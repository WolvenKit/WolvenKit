using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Models;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.App.ViewModels.Tools;

public partial class ProjectExplorerViewModel
{
    #region fields
    /// <summary>
    /// WatcherService is an internal class of ProjectExplorerViewModel.
    ///
    /// There's three fundamental things WatcherService does:
    ///    1. Owns & manages changes to data models FileList and FileTree that are state of ProjectExplorerViewModel.
    ///       This includes building and populating these models when WatchProject is called.
    ///    2. While not "suspended", monitor OS file system events from _modsWatcher & add change events update queues.
    ///    3. Subscribe to IProjectEvents change sets coming from other parts of the app to bypass the need
    ///       to rely on file system events for large batches of changes.
    ///    4. Run background jobs Update & BatchUpdate that dequeue file change events and update the FileList/Tree.
    ///        * Update checks _fileChanges and processes individual Changed, Renamed, and Deleted events one at a time.
    ///        * BatchUpdate checks _batchFileChanges and processes batches of Add events in groups for performance.
    ///
    /// Due to flakiness with file system events, various parts of the app currently suspend/stop the monitoring of
    /// file system events in order to make broad changes in the mod directory, then they call "Refresh" to reload the
    /// whole project from disk.
    /// </summary>
    internal partial class WatcherService : ObservableObject
    {
        #region fields

    private readonly ILoggerService? _loggerService;

    private string _projectDirectory = string.Empty;
    private FileSystemModel? _projectFileSystemModel;

    private readonly FileSystemWatcher _modsWatcher;

    private readonly object _modLoadingLock = new();

    private Task? _updateTask;
    private CancellationTokenSource _updateThreadCancellationTokenSource = new();

    private readonly ConcurrentQueue<FileSystemEventArgsWrapper> _fileChanges = new();

    public ConcurrentDictionary<string, FileSystemModel> FileLookup { get; } = new();
    private readonly ConcurrentDictionary<string, FileSystemModel> _fileLookup = new();
    private readonly ConcurrentDictionary<string, long> _removedFiles = new();

    [ObservableProperty]
    private DispatchedObservableCollection<FileSystemModel> _fileList = new();

    [ObservableProperty]
    private DispatchedObservableCollection<FileSystemModel> _fileTree = new();

    private static readonly List<string> s_ignoredExtensions =
    [
        "tmp",
        "pdnsave",
        "bak", // photoshop
        "blend@", // Blender temp files
        "blend1", // Blender temp files
    ];

    private static bool HasIgnoredExtension(string? fileName)
    {
        var fileExtension = Path.GetExtension(fileName)?.ToUpper();
        return fileExtension is not null && s_ignoredExtensions.Any(partial =>
            fileExtension.Contains(partial, StringComparison.OrdinalIgnoreCase));
    }

    private WatcherState _watcherState;

    public WatcherState WatcherState => _watcherState;

    #endregion

    public WatcherService(ILoggerService? loggerService)
    {
        _loggerService = loggerService;

        _modsWatcher = new FileSystemWatcher
        {
            Filter = "*",
            NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.Attributes | NotifyFilters.DirectoryName,
            IncludeSubdirectories = true
        };
        _modsWatcher.Created += OnChanged;
        _modsWatcher.Changed += OnChanged;
        _modsWatcher.Deleted += OnChanged;
        _modsWatcher.Renamed += OnRenamed;
    }

    public void ResumeWatcher_AndLoadProject()
    {
        Locked_LoadModProjectFileStructure();
        Resume();
    }

    public void StartWatcher_AndLoadProject(Cp77Project project, Action? completion = null)
    {
        _projectDirectory = project.FileDirectory;
        _projectFileSystemModel = new FileSystemModel(null, FileSystemModel.ProjectDirName, _projectDirectory, true);
        ResumeWatcher_AndLoadProject();
    }

    public void Resume()
    {
        if (_projectDirectory == "")
        {
            throw new Exception("No project directory to resume watching!.");
        }
        _loggerService?.Debug($"Resuming monitoring of file system events in project: {_projectDirectory}.");
        _modsWatcher.Path = _projectDirectory;
        _modsWatcher.IncludeSubdirectories = true;
        _modsWatcher.EnableRaisingEvents = true;
        _watcherState = WatcherState.Active;
    }

    /// <summary>
    ///  Does the following:
    ///     1. Suspend the OS file watcher.
    ///     2. Sets _watcherState to `noProject`
    ///     3. Clears the _projectDirectory & _projectFileSystemModel vars.
    ///     4. Stops background polling for things added to the update batches.
    ///     5. Clears lookup caches, batches, and data models.
    ///
    /// This must be called before performing anything that sends a Reset for
    /// FileList or FileTree collections.
    /// </summary>
    public void UnwatchProject()
    {
        Suspend();
        _watcherState = WatcherState.NoProject;
        _projectDirectory = "";
        _projectFileSystemModel = null;
        _loggerService?.Debug($"Closing the current mod and clearing file lists and background tasks.");
        StopBackgroundPolling();
    }

    private static readonly List<string> s_backupFilePartials =
    [
        "_tmp", ".bak", ".bkp"
    ];

    /// <summary>
    /// Processes file system events saved to the _fileChanges queue.
    /// The only ones Update cares about in that queue are change/rename/remove.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <exception cref="Exception"></exception>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    /// <exception cref="TodoException"></exception>
    private void Update(CancellationToken cancellationToken)
    {
        while (true)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                break;
            }

            if (!_fileChanges.TryDequeue(out var e))
            {
                _removedFiles.Clear();

                Thread.Sleep(100);
                continue;
            }

            var extension = Path.GetExtension(e.Name);
            if (!string.IsNullOrEmpty(extension) && HasIgnoredExtension(e.Name))
            {
                continue;
            }

            try
            {
                switch (e.ChangeType)
                {
                    case WatcherChangeTypes.Created:
                        Create(e);
                        break;
                    case WatcherChangeTypes.Deleted:
                        Delete(e);
                        break;
                    case WatcherChangeTypes.Changed:
                        Changed(e);
                        break;
                    case WatcherChangeTypes.Renamed:
                        Renamed(e);
                        break;
                    case WatcherChangeTypes.All:
                        throw new Exception();
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            catch (Exception)
            {
                if (e.Name is not null && !s_backupFilePartials.Any(partial => e.Name.Contains(partial)))
                {
                    _loggerService?.Error($"Project Explorer: something went wrong while changing {e.Name}. You can try a manual refresh.");
                }
            }
        }

        void Create(FileSystemEventArgsWrapper e)
        {
            var timestamp = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

            if (HasIgnoredExtension(e.Name))
            {
                return;
            }

            // Check if delay has passed
            if (e.Ticks > timestamp)
            {
                _fileChanges.Enqueue(e);
                return;
            }

            if (_removedFiles.TryGetValue(e.FullPath, out var eventAddedAt))
            {
                // File got removed again before the create event was processed. Skip it
                if (e.EventAddedAt < eventAddedAt)
                {
                    return;
                }
            }

            // Create event was sent but file doesn't exist yet?!?! Don't know why. Just requeue with delay
            if (!File.Exists(e.FullPath) && !Directory.Exists(e.FullPath))
            {
                e.Ticks = timestamp + 100;
                e.RetryCount++;

                _fileChanges.Enqueue(e);
                return;
            }

            if (e.RetryCount > 10)
            {
                // If it still doesn't work after 10 retries... idk
                _loggerService?.Warning($"Project explorer: Failed adding {e.Name}. You can try a manual refresh.");
                return;
            }

            var projectPath = e.FullPath[(_projectDirectory.Length + 1)..];
            if (_fileLookup.ContainsKey(projectPath))
            {
                return;
            }

            var pathParts = projectPath.Split(Path.DirectorySeparatorChar);

            FileSystemModel? current = null;
            var parent = _projectFileSystemModel;
            for (var i = 0; i < pathParts.Length; i++)
            {
                var part = pathParts[i];

                var tmpParentPath = Path.Combine(pathParts[..i]);
                var tmpPath = Path.Combine(pathParts[..(i + 1)]);

                if (!string.IsNullOrEmpty(tmpParentPath))
                {
                    parent = _fileLookup[tmpParentPath];
                }

                if (_fileLookup.TryGetValue(tmpPath, out current))
                {
                    continue;
                }

                var isDirectory = true;
                if (i == pathParts.Length - 1)
                {
                    var attr = File.GetAttributes(e.FullPath);
                    isDirectory = attr.HasFlag(FileAttributes.Directory);
                }

                current = new FileSystemModel(parent, part, tmpPath, isDirectory);
                if (!current.IsDirectory)
                {
                    FileList.Add(current);
                }

                if (!_fileLookup.TryAdd(tmpPath, current))
                {
                    continue;
                }

                if (string.IsNullOrEmpty(tmpParentPath))
                {
                    FileTree.Add(current);
                }

                if (parent != null && !parent.Children.Contains(current))
                {
                    parent.Children.Add(current);
                }
            }

            if (current is not { IsDirectory: true })
            {
                return;
            }

            var children = Directory.GetFileSystemEntries(current.FullName, "*", SearchOption.AllDirectories);
            foreach (var child in children)
            {
                var name = child[(_projectDirectory.Length + 1)..];
                if (!_fileLookup.ContainsKey(name))
                {
                    _fileChanges.Enqueue(
                        new FileSystemEventArgsWrapper(new FileSystemEventArgs(WatcherChangeTypes.Created, _projectDirectory, name)));
                }
            }
        }

        void Changed(FileSystemEventArgsWrapper e)
        {
            if (string.IsNullOrEmpty(e.Name))
            {
                throw new TodoException();
            }

            if (!_fileLookup.TryGetValue(e.Name, out var item))
            {
                if (!_isWatcherStopped)
                {
                    _loggerService?.Warning($"Failed to refresh {e.Name}. This is just a UI glitch!");
                }
                return;
            }

            if (item.IsDirectory)
            {
                return;
            }

            item.UpdateFileInfo();
        }

        void Renamed(FileSystemEventArgsWrapper e)
        {
            if (e.Args is not RenamedEventArgs renamedEventArgs)
            {
                throw new Exception();
            }

            if (string.IsNullOrEmpty(renamedEventArgs.OldName) || string.IsNullOrEmpty(renamedEventArgs.Name))
            {
                throw new Exception();
            }

            if (Path.GetExtension(renamedEventArgs.OldName).Equals(".tmp", StringComparison.InvariantCultureIgnoreCase))
            {
                _batchFileChanges.Enqueue(new FileSystemEventArgsWrapper(new FileSystemEventArgs(WatcherChangeTypes.Created, _projectDirectory, renamedEventArgs.Name)));
                return;
            }

            foreach (var key in _fileLookup.Keys)
            {
                if (!key.StartsWith(renamedEventArgs.OldName))
                {
                    continue;
                }

                var newKey = renamedEventArgs.Name + key.Substring(renamedEventArgs.OldName.Length);
                if (!_fileLookup.TryRemove(key, out var item) || !_fileLookup.TryAdd(newKey, item))
                {
                    throw new Exception();
                }

                if (key != renamedEventArgs.OldName)
                {
                    continue;
                }

                var newName = renamedEventArgs.Name.Split(Path.DirectorySeparatorChar)[^1];
                item.Rename(newName);
            }
        }

        void Delete(FileSystemEventArgsWrapper e)
        {
            if (string.IsNullOrEmpty(e.Name))
            {
                throw new TodoException();
            }

            if (_fileLookup.TryRemove(e.Name, out var item))
            {
                FileTree.Remove(item);
                FileList.Remove(item);

                ClearChildren(item);

                item.Parent?.Children.Remove(item);
            }

            _removedFiles.TryAdd(e.FullPath, e.EventAddedAt);

            void ClearChildren(FileSystemModel model)
            {
                foreach (var subModel in model.Children)
                {
                    ClearChildren(subModel);

                    _fileLookup.Remove(subModel.RawRelativePath, out _);
                    FileList.Remove(subModel);
                }
            }
        }
    }

    private void Locked_LoadModProjectFileStructure()
    {
        lock (_modLoadingLock)
        {
            LoadModProjectFileStructure();
        }
    }
    void Clear()
    {
        _loggerService?.Debug("Clearing all file changes and project data sources.");

        _fileChanges.Clear();
        _batchFileChanges.Clear();
        _fileLookup.Clear();
        FileTree.Clear();
        FileList.Clear();
    }

    private void LoadModProjectFileStructure()
    {
        if (string.IsNullOrEmpty(_projectDirectory))
        {
            // On first app launch, there's no project yet.
            return;
        }

        Clear();

        var allFiles = new DirectoryInfo(_projectDirectory).GetFileSystemInfos("*", SearchOption.AllDirectories);
        foreach (var fileSystemInfo in allFiles)
        {
            var name = fileSystemInfo.FullName[(_projectDirectory.Length + 1)..];
            _fileChanges.Enqueue(new FileSystemEventArgsWrapper(new FileSystemEventArgs(WatcherChangeTypes.Created, _projectDirectory, name)));
        }

    private void StartBackgroundPolling()
    {
        // Always ensure any previous polling tasks are fully stopped first.
        // This is the single choke point that prevents duplicate long-running tasks.
        StopBackgroundPollingInternal();

        _updateThreadCancellationTokenSource = new CancellationTokenSource();
        _updateTask = Task.Factory.StartNew(
            () => Update(_updateThreadCancellationTokenSource.Token),
            _updateThreadCancellationTokenSource.Token,
            TaskCreationOptions.LongRunning,
            TaskScheduler.Default);

        ResetFileLoggingToken();
    }

    private void StopBackgroundPolling()
    {
        _modsWatcher.EnableRaisingEvents = false;

        if (_updateTask != null)
        {
            _updateThreadCancellationTokenSource.Cancel();
            if (!_updateTask.IsCanceled && !_updateTask.Wait(1000))
            {
                throw new Exception();
            }
        }
    }
    
    public void Suspend()
    {
        _loggerService?.Debug("Stopping file system watcher in mod folder.");
        _modsWatcher.EnableRaisingEvents = false;
        _watcherState = WatcherState.Suspended;
    }


    private void OnRenamed(object sender, RenamedEventArgs e) => _fileChanges.Enqueue(new FileSystemEventArgsWrapper(e));

    private void OnChanged(object sender, FileSystemEventArgs e) => _fileChanges.Enqueue(new FileSystemEventArgsWrapper(e));

    private class FileSystemEventArgsWrapper
    {
        public FileSystemEventArgsWrapper(FileSystemEventArgs fileSystemEventArgs)
        {
            Args = fileSystemEventArgs;
        }

        public FileSystemEventArgs Args { get; }

        public string? Name => Args.Name;
        public string FullPath => Args.FullPath;
        public WatcherChangeTypes ChangeType => Args.ChangeType;

        public int RetryCount { get; set; }
        public long Ticks { get; set; }

        public long EventAddedAt { get; } = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    }
/// <summary>
/// NoProject: there is no active mod loaded up.
/// Suspended: there is a mod loaded up, but Windows file system events are being ignored.
/// Active: there is a mod loaded up, and the Watcher is monitoring for file system events.
/// </summary>
public enum WatcherState
{
    NoProject,
    Suspended,
    Active
}
}
