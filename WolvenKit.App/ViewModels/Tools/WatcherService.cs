using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using DynamicData;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models;
using WolvenKit.App.Models.ProjectManagement.Project;
using ReactiveUI;
using WolvenKit.App.Services;
using WolvenKit.Core.Exceptions;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.App.ViewModels.Tools;

public partial class ProjectExplorerViewModel
{
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
        private readonly Func<string, bool> _getDesiredExpansionState;
        private string _projectDirectory = string.Empty;
        private FileSystemModel? _projectFileSystemModel;

        private readonly FileSystemWatcher _modsWatcher;

        private readonly object _modLoadingLock = new();
        private readonly object _batchLock = new();

        private Task? _updateTask;
        private CancellationTokenSource _updateThreadCancellationTokenSource = new();
        private Task? _batchUpdateTask;
        private CancellationTokenSource _batchUpdateThreadCancellationTokenSource = new();

        private CancellationTokenSource? _fileLoggingCts;

        private readonly ConcurrentQueue<FileSystemEventArgsWrapper> _fileChanges = new();
        private readonly ConcurrentQueue<FileSystemEventArgsWrapper> _batchFileChanges = new();

        private readonly ConcurrentDictionary<string, FileSystemModel> _fileLookup = new();

        public ConcurrentDictionary<string, FileSystemModel> FileLookup => _fileLookup;

        private readonly ConcurrentDictionary<string, FileSystemEventArgsWrapper> _fileProcessing = new();

        // TODO: This is never read from, can it be cleaned out?
        private readonly ConcurrentDictionary<string, long> _removedFiles = new();

        private readonly CompositeDisposable _disposables = new();

        // The grids bind to the GridGuard's clone projection, not to these. These are the DOMAIN
        // models the watcher builds and the rest of the app mutates freely. After each domain
        // mutation the watcher calls _guard.Project*(...) so the shim updates the clones the grids
        // actually show — that indirection is what keeps the wild mutations off the Syncfusion grids.
        private readonly GridGuard _guard;

        private readonly DispatchedObservableCollection<FileSystemModel> _fileList = new();
        private readonly DispatchedObservableCollection<FileSystemModel> _fileTree = new();

        public DispatchedObservableCollection<FileSystemModel> FileList => _fileList;
        public DispatchedObservableCollection<FileSystemModel> FileTree => _fileTree;


        private static readonly List<string> s_ignoredExtensions =
        [
            "tmp",
            "pdnsave",
            "bak", // photoshop
            "blend@", // Blender temp files
            "blend1", // Blender temp files
        ];

        public Guid CompletionTimer = Guid.NewGuid();

        private static bool HasIgnoredExtension(string? fileName)
        {
            var fileExtension = Path.GetExtension(fileName)?.ToUpper();
            return fileExtension is not null && s_ignoredExtensions.Any(partial =>
                fileExtension.Contains(partial, StringComparison.OrdinalIgnoreCase));
        }

        public WatcherState _watcherState = WatcherState.NoProject;

        public WatcherState WatcherState => _watcherState;

        #endregion

        public WatcherService(Func<string, bool> getDesiredExpansionState, ILoggerService? loggerService, IProjectEvents projectEvents, GridGuard guard)
        {
            _loggerService = loggerService;
            _getDesiredExpansionState = getDesiredExpansionState;
            _guard = guard;

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

            projectEvents.FilesImported
                .ObserveOn(RxApp.MainThreadScheduler)
                .Subscribe(OnFilesImported)
                .DisposeWith(_disposables);
        }

        public void ResumeWatcher_AndLoadProject()
        {
            Suspend();
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
                            throw new Exception($"Tried to create file ${e.FullPath} outside of batch update.");
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

            void Changed(FileSystemEventArgsWrapper e)
            {
                if (string.IsNullOrEmpty(e.Name))
                {
                    throw new TodoException();
                }

                var lookup = e.FullPath.Substring(_projectDirectory.Length + 1);

                if (!_fileLookup.TryGetValue(lookup, out var item))
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
                _guard.ProjectUpdateFileInfo(item);
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
                    // Capture the clone key before the rename changes FullName, then project it.
                    var oldFullName = item.FullName;
                    item.Rename(newName);
                    _guard.ProjectRename(item, oldFullName);
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
                    RemoveModel(item, e.EventAddedAt);
                }
                else
                {
                    _removedFiles.TryAdd(e.FullPath, e.EventAddedAt);
                }
            }
        }

        private void RemoveModel(FileSystemModel model, long removedAt = 0)
        {
            if (model == null) return;

            _fileLookup.TryRemove(model.FullName, out _);

            if (FileTree.Contains(model))
                FileTree.Remove(model);
            if (FileList.Contains(model))
                FileList.Remove(model);

            RemoveChildModels(model);

            if (model.Parent != null && model.Parent.Children.Contains(model))
                model.Parent.Children.Remove(model);

            if (removedAt != 0)
                _removedFiles.TryAdd(model.FullName, removedAt);

            // Mirror the removal onto the grid-bound clone subtree.
            _guard.ProjectRemove(model);
        }

        private void RemoveChildModels(FileSystemModel model)
        {
            var children = model.Children.ToList();
            foreach (var subModel in children)
            {
                RemoveChildModels(subModel);

                _fileLookup.Remove(subModel.FullName, out _);
                if (FileList.Contains(subModel))
                    FileList.Remove(subModel);
            }
        }

        internal void RemoveItems(IEnumerable<FileSystemModel> items)
        {
            foreach (var item in items)
            {
                if (item == null) continue;
                // `item` is usually a grid clone (it came from the grid's SelectedItems). Resolve it
                // to the domain model of the same path so RemoveModel operates on real domain state;
                // RemoveModel then projects the removal back onto the clones.
                var domain = _fileLookup.TryGetValue(item.FullName, out var d) ? d : item;
                RemoveModel(domain, DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond);
            }
        }

        private void Locked_LoadModProjectFileStructure()
        {
            lock (_modLoadingLock)
            {
                LoadModProjectFileStructure();
            }
        }

        private void LoadModProjectFileStructure()
        {
            if (_projectFileSystemModel == null)
            {
                // On first app launch, there's no project yet.
                return;
            }

            _watcherState = WatcherState.Loading;

            void Clear()
            {
                _loggerService?.Debug("Clearing all file changes and project data sources.");

                _fileChanges.Clear();
                _batchFileChanges.Clear();
                _fileLookup.Clear();
                FileTree.Clear();
                FileList.Clear();
            }

            Clear();

            Task.Run(() =>
            {
                var (flatListReturn, treeRoot) = BuildFullFileStructure();

                DispatcherHelper.RunOnMainThread(() =>
                {
                    if (flatListReturn.Count != 0)
                    {
                        FileList.AddRange(flatListReturn);
                    }

                    FileTree.AddRange((treeRoot != null)
                        ? treeRoot.Children
                        : Array.Empty<FileSystemModel>());

                    // Project the freshly built domain tree onto the grid-bound clones.
                    _guard.ProjectReset(flatListReturn, treeRoot?.Children.ToList() ?? new List<FileSystemModel>());

                    DispatcherHelper.StopRepeatingAction(CompletionTimer);
                    StartBackgroundPolling();
                    _watcherState = WatcherState.Active;
                });
            });
        }

        private (List<FileSystemModel> FlatList, FileSystemModel? TreeRoot) BuildFullFileStructure()
        {
            var flatList = new List<FileSystemModel>(10000);
            var rootModel = _projectFileSystemModel ?? new FileSystemModel(null, FileSystemModel.ProjectDirName, _projectDirectory, true);
            var stack = new Stack<(DirectoryInfo Dir, FileSystemModel Parent)>();
            stack.Push((new DirectoryInfo(rootModel.FullName), rootModel));

            while (stack.Count > 0)
            {
                var (dir, parent) = stack.Pop();

                try
                {
                    // dir
                    foreach (var subDir in dir.EnumerateDirectories("*", SearchOption.TopDirectoryOnly))
                    {
                        if (IsIgnoredPath(subDir.FullName))
                            continue;

                        var wrapper = new FileSystemEventArgsWrapper(new FileSystemEventArgs(WatcherChangeTypes.Created,
                            subDir.Parent?.FullName ?? "", subDir.Name));

                        var dirModel = CreateFromScratch(parent, wrapper);

                        if (dirModel != null)
                        {
                            if (dirModel.FullName != rootModel.FullName)
                                flatList.Add(dirModel);
                            parent.Children.Add(dirModel);
                            _fileLookup.TryAdd(dirModel.FullName, dirModel);
                            stack.Push((subDir, dirModel));
                        }
                    }

                    // file
                    foreach (var file in dir.EnumerateFiles("*", SearchOption.TopDirectoryOnly))
                    {
                        if (IsIgnoredPath(file.FullName))
                            continue;

                        var fileModel = CreateFromScratch(parent, new FileSystemEventArgsWrapper(new FileSystemEventArgs(
                            WatcherChangeTypes.Created,
                            file.DirectoryName ?? "", file.Name)));

                        if (fileModel != null)
                        {
                            flatList.Add(fileModel);
                            parent.Children.Add(fileModel);
                            _fileLookup[fileModel.FullName] = fileModel;
                        }
                    }
                }
                catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
                {
                    _loggerService?.Warning($"Access denied on {dir.FullName}");
                }
            }

            return (flatList, rootModel);
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

            _batchUpdateThreadCancellationTokenSource = new CancellationTokenSource();
            _batchUpdateTask = Task.Factory.StartNew(
                () => BatchUpdate(_batchUpdateThreadCancellationTokenSource.Token),
                _batchUpdateThreadCancellationTokenSource.Token,
                TaskCreationOptions.LongRunning,
                TaskScheduler.Default);

            ResetFileLoggingToken();
        }

        private void ResetFileLoggingToken()
        {
            _fileLoggingCts?.Cancel();
            _fileLoggingCts?.Dispose();
            _fileLoggingCts = new CancellationTokenSource();
        }

        private void StopBackgroundPolling()
        {
            _loggerService?.Debug("Suspending file system watcher and cancelling file tree update listeners.");
            StopBackgroundPollingInternal();
            CancelFileLoggingToken();
        }

        /// <summary>
        /// Internal implementation that actually cancels and waits for the background tasks.
        /// Called from both public Stop and defensively from Start.
        /// </summary>
        private void StopBackgroundPollingInternal()
        {
            // Cancel update task
            if (_updateTask != null)
            {
                try
                {
                    _updateThreadCancellationTokenSource.Cancel();
                    // Best-effort wait so the loop can exit its Sleep and observe the token.
                    _updateTask.Wait(TimeSpan.FromMilliseconds(250));
                }
                catch (AggregateException) { /* task cancelled, expected */ }
                finally
                {
                    _updateTask = null;
                    _updateThreadCancellationTokenSource.Dispose();
                    _updateThreadCancellationTokenSource = new CancellationTokenSource();
                }
            }

            // Cancel batch update task
            if (_batchUpdateTask != null)
            {
                try
                {
                    _batchUpdateThreadCancellationTokenSource.Cancel();
                    _batchUpdateTask.Wait(TimeSpan.FromMilliseconds(250));
                }
                catch (AggregateException) { /* task cancelled, expected */ }
                finally
                {
                    _batchUpdateTask = null;
                    _batchUpdateThreadCancellationTokenSource.Dispose();
                    _batchUpdateThreadCancellationTokenSource = new CancellationTokenSource();
                }
            }
        }

        public void Suspend()
        {
            _loggerService?.Debug("Stopping file system watcher in mod folder.");
            _modsWatcher.EnableRaisingEvents = false;
            _watcherState = WatcherState.Suspended;
        }

        private void CancelFileLoggingToken()
        {
            _fileLoggingCts?.Cancel();
            _fileLoggingCts?.Dispose();
            _fileLoggingCts = null;
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

            public FileSystemEventArgs Args { get; }

            public string? Name => Args.Name;
            public string FullPath => Args.FullPath;
            public WatcherChangeTypes ChangeType => Args.ChangeType;

            public int RetryCount { get; set; }
            public long Ticks { get; set; }

            public long EventAddedAt { get; } = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
        }

        private void BatchUpdate(CancellationToken cancellationToken)
        {
            var batch = new List<FileSystemEventArgsWrapper>(64);
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

                    _guard.ProjectAdd(created);

                }, DispatcherPriority.Background);
            }
        }

        /// <summary>
        /// Creates a FileSystemMoodel from a FileSystemEventArgsWrapper and parent.
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private FileSystemModel? CreateFromScratch(FileSystemModel? parent, FileSystemEventArgsWrapper e)
        {
            if (parent == null && e.Name != _projectDirectory && e.Name != "archive" && e.Name != "raw" && e.Name != "resources")
            {
                return null;
            }

            if (string.IsNullOrEmpty(e.FullPath))
                return null;

            var fullPath = e.FullPath;

            if (IsIgnoredPath(fullPath))
                return null;

            try
            {
                var isDirectory = Directory.Exists(fullPath);
                var relativePath = fullPath[(_projectDirectory.Length + 1)..];
                var name = Path.GetFileName(e.FullPath);

                bool desiredExpansion = isDirectory && _getDesiredExpansionState(relativePath);
                var model = new FileSystemModel(parent, name, relativePath, isDirectory, desiredExpansion);
                return model;
            }
            catch (Exception ex)
            {
                _loggerService?.Warning($"Failed to create FileSystemModel for {fullPath}: {ex.Message}");
                return null;
            }
        }

        private bool IsIgnoredPath(string fullPath)
        {
            if (string.IsNullOrWhiteSpace(fullPath)) return true;

            var fileName = Path.GetFileName(fullPath);
            return HasIgnoredExtension(fileName)
                   || s_backupFilePartials.Any(p => fileName.Contains(p, StringComparison.OrdinalIgnoreCase))
                   || fileName.StartsWith(".");
        }

        /// <summary>
        /// Subscriber to published lists of files being added by other objects.
        /// Bypasses the need for monitoring file system events for performance.
        /// </summary>
        /// <param name="msg"></param>
        private void OnFilesImported(FilesImportedMessage msg)
        {
            var gameFiles = msg.GameFiles;
            var rawFiles = msg.RawFiles;

            var batch = new List<FileSystemModel>();

            foreach (var file in gameFiles)
            {
                var gameRelativePath = file.FileName;
                var fullPath = Path.Combine(_projectDirectory, "archive", gameRelativePath);
                var fileInfo = new FileInfo(fullPath);
                CreateFileAndAllNeededDirectories(FileDestination.Archive, fileInfo, batch);
            }

            foreach (var file in rawFiles)
            {
                CreateFileAndAllNeededDirectories(FileDestination.Raw, file, batch);
            }

            FileList.AddRange(batch);
            _guard.ProjectAdd(batch);
            Resume();

            // Log added files in the background to avoid hanging the UI on very large imports.
            LogBatchAddedFiles(batch);
        }

        /// <summary>
        /// Logs a large number of added files in the background.
        /// Chunks the list, logs alphabetically, uses a low-priority background task with light debouncing,
        /// and ends with a summary count.
        /// </summary>
        private void LogBatchAddedFiles(List<FileSystemModel> addedFiles)
        {
            if (_loggerService == null || addedFiles.Count == 0)
                return;

            // Capture the token at the start to avoid races if the CTS is replaced mid-operation
            var token = _fileLoggingCts?.Token ?? CancellationToken.None;

            Task.Factory.StartNew(async () =>
            {
                try
                {
                    token.ThrowIfCancellationRequested();

                    // Sort alphabetically for consistent logging order
                    var sortedNames = addedFiles
                        .Where(file => !file.IsDirectory)
                        .Select(f => f.FullName)
                        .OrderBy(name => name, StringComparer.OrdinalIgnoreCase)
                        .ToList();

                    const int chunkSize = 100;
                    int total = sortedNames.Count;

                    for (int i = 0; i < sortedNames.Count; i += chunkSize)
                    {
                        token.ThrowIfCancellationRequested();

                        var chunk = sortedNames.Skip(i).Take(chunkSize);
                        var message = string.Join(Environment.NewLine,
                            chunk.Select(name => $"Added file to project: {name}"));

                        _loggerService.Info(message);

                        // Light debouncing / pacing so we don't flood the logger during very large imports
                        await Task.Delay(60, token);
                    }

                    token.ThrowIfCancellationRequested();
                    _loggerService.Info($"Added {total} files to the project via batch import.");
                }
                catch (OperationCanceledException)
                {
                    // Expected when project is unwatched during a large batch import
                }
                catch (Exception ex)
                {
                    _loggerService?.Warning($"Error while logging batch import details: {ex.Message}");
                }
            },
            token,
            TaskCreationOptions.LongRunning,
            TaskScheduler.Default);
        }

        private enum FileDestination
        {
            Archive,
            Raw,
            Resources
        }

        private void CreateFileAndAllNeededDirectories(FileDestination fileDestination, FileInfo file, List<FileSystemModel> batch)
        {
            var destination = "";

            switch (fileDestination)
            {
                case FileDestination.Archive:
                    destination = "archive";
                    break;
                case FileDestination.Raw:
                    destination = "raw";
                    break;
                default:
                    destination = "";
                    break;
            }

            var fullPath = file.FullName;
            var fileName = file.Name;
            var parentDirInfo = Directory.GetParent(fullPath);
            var parentPath = parentDirInfo!.FullName;
            var rawRelativePath = fullPath.Substring(_projectDirectory.Length + 1);

            if (_fileLookup.TryGetValue(parentPath, out var parent))
            {
                if (!parent.Children.Any(m => m.FullName == fullPath) && !_fileLookup.ContainsKey(fullPath))
                {
                    var fileSystemModel = new FileSystemModel(parent, fileName, rawRelativePath, false);
                    parent.Children.Add(fileSystemModel);
                    _fileLookup.TryAdd(fullPath, fileSystemModel);
                    batch.Add(fileSystemModel);
                }
                return;
            }

            var parentDirs = new Stack<DirectoryInfo>();
            var currentLevel = Directory.GetParent(fullPath)!;

            while (currentLevel.Name != destination)
            {
                parentDirs.Push(currentLevel);
                currentLevel = currentLevel.Parent!;
            }

            var lookupKey = Path.Combine(_projectDirectory, destination);

            if (!_fileLookup.TryGetValue(lookupKey, out var parentModel))
            {
                throw new WolvenKitException(987, $"Filed to find needed directory ${lookupKey}. " +
                                                  "This means the file system is in an inconsistent state. " +
                                                  "Please close and reload WolvenKit. ");

            }

            while (parentDirs.Count > 0)
            {
                var current = parentDirs.Pop();
                var lookup = current.FullName.Substring(_projectDirectory.Length + 1);

                if (_fileLookup.TryGetValue(lookup, out var currentModel))
                {
                    parentModel = currentModel;
                    continue;
                }

                // Make the directory if needed. (Does nothing if already exists.)
                current.Create();
                var currentRawRelativePath = current.FullName.Substring(_projectDirectory.Length + 1);
                if (!_fileLookup.ContainsKey(current.FullName))
                {
                    var newCurrentModel = new FileSystemModel(parentModel, current.Name, currentRawRelativePath, true);
                    parentModel.Children.Add(newCurrentModel);
                    _fileLookup.TryAdd(current.FullName, newCurrentModel);
                    batch.Add(newCurrentModel);
                    parentModel = newCurrentModel;
                }
                else
                {
                    parentModel = _fileLookup[current.FullName];
                }
            }

            if (!_fileLookup.ContainsKey(fullPath))
            {
                var newFileModel = new FileSystemModel(parentModel, fileName, rawRelativePath, false);
                batch.Add(newFileModel);
                parentModel.Children.Add(newFileModel);
                _fileLookup.TryAdd(fullPath, newFileModel);
            }
        }
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
        Active,
        Loading,
        Error
    }
}
