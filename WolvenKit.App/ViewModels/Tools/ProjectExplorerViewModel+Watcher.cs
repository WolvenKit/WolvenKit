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

    private readonly ILoggerService? _loggerService;

    private string _projectDirectory = string.Empty;
    private FileSystemModel? _projectFileSystemModel;

    private readonly FileSystemWatcher _modsWatcher;

    private readonly object _refreshLock = new();

    private Task? _updateTask;
    private CancellationTokenSource _updateThreadCancellationTokenSource = new();

    private readonly ConcurrentQueue<FileSystemEventArgsWrapper> _fileChanges = new();
    private readonly ConcurrentQueue<FileSystemEventArgsWrapper> _batchFileChanges = new();

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

    private bool _isWatcherStopped;

    public bool IsWatcherStopped => _isWatcherStopped;

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

    public void WatchProject(Cp77Project project)
    {
        _projectDirectory = project.FileDirectory;
        _projectFileSystemModel = new FileSystemModel(null, FileSystemModel.ProjectDirName, _projectDirectory, true);

        WatchLocation();
        Refresh();
    }

    public void Resume()
    {
        lock (_watcherStateLock)
        {
            switch (_watcherState, _suspendQueue.Count)
            {
                // happy path
                case (WatcherState.Suspended, > 0):
                    _ = _suspendQueue.TryDequeue(out _);

                    if (_suspendQueue.Count == 0)
                    {
                        InternalResume();
                    }

                    return;

                case (WatcherState.Loading, > 0):
                    _ = _suspendQueue.TryDequeue(out _);

                    if (_suspendQueue.Count == 0)
                    {
                        InternalResume();
                    }
                    else
                    {
                        _watcherState = WatcherState.Suspended;
                        _modsWatcher.EnableRaisingEvents = false;
                        _loggerService?.Debug(
                            $"Load finished with {_suspendQueue.Count} suspend token(s) remaining; staying suspended.");
                    }

                    return;

                // resuming while active has no effect
                case (WatcherState.Active, 0):
                    _loggerService?.Debug(
                        $"FileWatcher confirmed active with no pending operations.");
                    return;

                default:
                    _loggerService?.Debug(
                        $"Ignoring unbalanced resume: watcher state was {_watcherState} with {_suspendQueue.Count} suspends on the queue.");
                    return;
            }
        }


        void InternalResume()
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
    }

    public void UnwatchProject(Cp77Project? project)
    {
        _isWatcherStopped = true;
        UnwatchLocation();
    }

    private void WatchLocation()
    {
        _modsWatcher.Path = _projectDirectory;
        _modsWatcher.EnableRaisingEvents = true;
    }

    private void UnwatchLocation()
    {
        _modsWatcher.EnableRaisingEvents = false;

        ForceStop();
        Clear();
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
            if (e.NextRetryTime > timestamp)
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
                e.NextRetryTime = timestamp + 100;
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

            if (!_fileLookup.TryGetValue(e.FullPath, out var item))
            {
                if (_watcherState == WatcherState.NoProject && _fileProcessing.ContainsKey(e.FullPath))
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
                var oldFullPathNormalized = (!Directory.Exists(renamedEventArgs.FullPath))
                    ? renamedEventArgs.OldFullPath
                    : Path.GetFullPath(renamedEventArgs.OldFullPath)
                        .TrimEnd(Path.DirectorySeparatorChar,
                            Path.AltDirectorySeparatorChar);

                if (!key.StartsWith(oldFullPathNormalized))
                {
                    continue;
                }

                if (key != oldFullPathNormalized && !key[oldFullPathNormalized.Length..].StartsWith('\\'))
                {
                    // we've matched \my\dir to \my\dir2 because it has substring "\my\dir" so continue
                    continue;
                }

                var newKey = renamedEventArgs.FullPath + key[oldFullPathNormalized.Length..];
                if (!_fileLookup.TryRemove(key, out var item) || !_fileLookup.TryAdd(newKey, item))
                {
                    throw new Exception();
                }

                if (key != oldFullPathNormalized)
                {
                    continue;
                }

                var newName = renamedEventArgs.Name.Split(Path.DirectorySeparatorChar)[^1];
                item.Rename(newName);
            }
        }

        void Delete(FileSystemEventArgsWrapper e)
        {
            if (string.IsNullOrEmpty(e.FullPath))
            {
                throw new TodoException();
            }

            if (_fileLookup.TryRemove(e.FullPath, out var item))
            {
                RefreshAfter(() => RemoveModel(item, e.EventAddedAt), false);
            }
            else
                {
                _removedFiles.TryAdd(e.FullPath, e.EventAddedAt);
            }
        }
    }

    private void BatchUpdate(CancellationToken cancellationToken)
    {
        var batch = new List<FileSystemEventArgsWrapper>();
        var stopwatch = Stopwatch .StartNew();

        while (true)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                break;
            }

            while (_batchFileChanges.TryDequeue(out var e))
            {
                // temporary until we support batch ops for others
                if (e.ChangeType != WatcherChangeTypes.Created)
                {
                    break;
                }

                if (cancellationToken.IsCancellationRequested)
                {
                    break;
                }

                _fileProcessing.TryAdd(e.FullPath, e);
                var extension = Path.GetExtension(e.Name);

                if (!string.IsNullOrEmpty(extension) && HasIgnoredExtension(e.Name))
                {
                    continue;
                }

                batch.Add(e);
            }

            if (batch.Count == 0)
            {
                _removedFiles.Clear();
                Thread.Sleep(50);
                continue;
            }

            try
            {
                ApplyBatch(batch, cancellationToken);
            }
            catch (Exception ex)
            {
                _loggerService?.Error($"ProjectExplorer: batch processing failed. {ex.Message}");
            }
            finally
            {
                if (stopwatch.ElapsedMilliseconds > 500)
                {
                    stopwatch.Restart();
                }
                batch.Clear();
            }
        }

        void ApplyBatch(List<FileSystemEventArgsWrapper> batch, CancellationToken ct)
        {
            var created = new List<FileSystemModel>();
            //var deleted = new List<string>();
            //var changed = new List<FileSystemModel>();

            foreach (var e in batch)
            {
                ct.ThrowIfCancellationRequested();

                try
                {
                    switch (e.ChangeType)
                    {
                        case WatcherChangeTypes.Created:
                            DispatcherHelper.RunOnMainThread(() =>
                            {
                                lock (_batchLock)
                                {
                                    var parent = FindParentModel(e.FullPath);
                                    var newItem = CreateFromScratch(parent, e);
                                    if (newItem != null)
                                    {
                                        if (parent != null && !parent.Children.Contains(newItem) && !_fileLookup.ContainsKey(e.FullPath))
                                        {
                                            parent.Children.Add(newItem);
                                            created.Add(newItem);
                                            _fileLookup.TryAdd(e.FullPath, newItem);
                                        }
                                        _fileProcessing.TryRemove(e.FullPath, out _);
                                    }
                                }
                            });
                            break;
                    }
                }
                catch (Exception ex)
                {
                    if (e.Name is not null && !s_backupFilePartials.Any(p => e.Name.Contains(p)))
                    {
                        _loggerService?.Error($"Project Explorer: error processing {e.Name}: {ex.Message}");
                    }
                }

                FileSystemModel? FindParentModel(string fullPath)
                {
                    if (string.IsNullOrEmpty(fullPath))
                        return null;

                    var parentPath = Path.GetDirectoryName(fullPath);
                    if (string.IsNullOrEmpty(parentPath))
                        return null;

                    return _fileLookup.TryGetValue(parentPath, out var parent)
                        ? parent
                        : null;
                }
            }

            DispatcherHelper.RunOnMainThread(() =>
            {
                FileList.AddRange(created);
                if (FileTree.Count < 3)
                {
                    FileTree.AddRange(created);
                }


            }, DispatcherPriority.Background);
        }
    }

    public void Refresh()
    {
        lock (_refreshLock)
        {
            InternalRefresh();
        }
    }

    private void Clear()
    {
        _fileChanges.Clear();
        _batchFileChanges.Clear();
        _fileLookup.Clear();
        FileTree.Clear();
        FileList.Clear();
    }

    private void InternalRefresh()
    {
        if (string.IsNullOrEmpty(_projectDirectory))
        {
            return;
        }

        ForceStop();
        Clear();

        var allFiles = new DirectoryInfo(_projectDirectory).GetFileSystemInfos("*", SearchOption.AllDirectories);
        foreach (var fileSystemInfo in allFiles)
        {
            var name = fileSystemInfo.FullName[(_projectDirectory.Length + 1)..];
            _fileChanges.Enqueue(new FileSystemEventArgsWrapper(new FileSystemEventArgs(WatcherChangeTypes.Created, _projectDirectory, name)));
        }

        _updateThreadCancellationTokenSource = new CancellationTokenSource();
        _updateTask = Task.Factory.StartNew(() => Update(_updateThreadCancellationTokenSource.Token), _updateThreadCancellationTokenSource.Token);

        _modsWatcher.EnableRaisingEvents = true;
    }

    public void ForceStop()
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
        // See Resume() for why this is locked.
        lock (_watcherStateLock)
        {
            if (_suspendQueue.IsEmpty)
            {
                _suspendQueue.Enqueue(new SuspendToken());
                _loggerService?.Debug("Stopping file system watcher in mod folder.");
                _modsWatcher.EnableRaisingEvents = false;
                _watcherState = WatcherState.Suspended;
                return;
            }

            // Nested suspend (including while Loading): keep existing load/suspend tokens and
            // add another so a later Resume (or load-completion Resume) does not go Active until
            // every suspend is balanced. Always reflect Suspended to callers.
            _modsWatcher.EnableRaisingEvents = false;
            _suspendQueue.Enqueue(new SuspendToken());
            if (_watcherState is WatcherState.Loading or WatcherState.Active or WatcherState.Error)
            {
                _watcherState = WatcherState.Suspended;
            }
        }
    }

    private void OnRenamed(object sender, RenamedEventArgs e) => _fileChanges.Enqueue(new FileSystemEventArgsWrapper(e));

    private void OnChanged(object sender, FileSystemEventArgs e)
    {
        if (e.ChangeType == WatcherChangeTypes.Created)
        {
            _batchFileChanges.Enqueue(new FileSystemEventArgsWrapper(e));
        }
        else
        {
            _fileChanges.Enqueue(new FileSystemEventArgsWrapper(e));
        }
    }

    private class FileSystemEventArgsWrapper
    {
        public FileSystemEventArgsWrapper(FileSystemEventArgs fileSystemEventArgs)
        {
            Args = fileSystemEventArgs;
        }

        public uint MaxRetryCount => 5;

        /// <summary>
        /// Delay in milliseconds between retries.
        /// </summary>
        public uint RetryDelay => 100;

        public FileSystemEventArgs Args { get; }

        public string? Name => Args.Name;
        public string FullPath => Args.FullPath;
        public WatcherChangeTypes ChangeType => Args.ChangeType;

        /// <summary>
        /// The number of times that a Create event has been checked
        /// to see if we received a corresponding Delete event that
        /// would indicate the Create event should be discarded.
        /// </summary>
        public int RetryCount { get; set; }

        /// <summary>
        /// We will not recheck for a corresponding Delete event until
        /// the `NextRetryTime`, at which point, we'll check and set a
        /// future `NextRetryTime` unless at the `MaxRetryCount`.
        /// </summary>
        public long NextRetryTime { get; set; }

        /// <summary>
        /// The timestamp in milliseconds at which the app received
        /// the wrapped event from Windows File System.
        /// </summary>
        public long EventAddedAt { get; } = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    }
}
