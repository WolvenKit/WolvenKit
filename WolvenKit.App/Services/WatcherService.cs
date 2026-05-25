using System;
using System.Collections;
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
using WolvenKit.App.Helpers;
using WolvenKit.App.Models;
using WolvenKit.App.Models.ProjectManagement.Project;
using ReactiveUI;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.App.Services;

/// <summary>
/// This service watches certain locations in the game files and notifies changes
/// </summary>
public partial class WatcherService : ObservableObject, IWatcherService
{
    #region fields

    private readonly ILoggerService? _loggerService;

    private string _projectDirectory = string.Empty;
    private FileSystemModel? _projectFileSystemModel;

    private readonly FileSystemWatcher _modsWatcher;

    private readonly object _refreshLock = new();

    private Task? _updateTask;
    private CancellationTokenSource _updateThreadCancellationTokenSource = new();
    private Task? _batchUpdateTask;
    private CancellationTokenSource _batchUpdateThreadCancellationTokenSource = new();

    private readonly ConcurrentQueue<FileSystemEventArgsWrapper> _fileChanges = new();
    private readonly ConcurrentQueue<FileSystemEventArgsWrapper> _batchFileChanges = new();

    private readonly ConcurrentDictionary<string, FileSystemModel> _fileLookup = new();
    private readonly ConcurrentDictionary<string, FileSystemEventArgsWrapper> _fileProcessing = new();
    private readonly ConcurrentDictionary<string, long> _removedFiles = new();

    private readonly IProjectEvents _projectEvents;
    private CompositeDisposable _disposables = new();

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

    public WatcherService(ILoggerService? loggerService, IProjectEvents projectEvents)
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

        _projectEvents = projectEvents;
        _projectEvents.FilesImported
            .ObserveOn(RxApp.MainThreadScheduler)
            .Subscribe(OnFilesImported)
            .DisposeWith(_disposables);
    }

    public void WatchProject(Cp77Project project)
    {
        _projectDirectory = project.FileDirectory;
        _projectFileSystemModel = new FileSystemModel(null, FileSystemModel.ProjectDirName, _projectDirectory, true);
        Refresh();
        WatchLocation();
        _loggerService?.Debug($"Now watching project: {project.FileDirectory} ({FileList.Count} files");
    }

    public void Resume() => _modsWatcher.EnableRaisingEvents = true;

    public void UnwatchProject(Cp77Project? project)
    {
        _isWatcherStopped = true;
        UnwatchLocation();
    }

    private void WatchLocation()
    {
        _modsWatcher.Path = _projectDirectory;
        _modsWatcher.EnableRaisingEvents = true;
        MonitorFileUpdates();
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
                        // Create(e);
                        // break;
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

            if (!_fileLookup.TryGetValue(e.Name, out var item))
            {
                if (!_isWatcherStopped && _fileProcessing.ContainsKey(e.FullPath))
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

                    _fileLookup.TryRemove(subModel.RawRelativePath, out _);
                    FileList.Remove(subModel);
                }
            }
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

    private void InternalRefresh() {
        Clear();

        if (_projectFileSystemModel == null)
        {
            throw new Exception("Project file system model is missing.");
        }

        var (flatListReturn, treeRoot) = BuildFullFileStructure();

        if (flatListReturn.Count != 0)
        {
            FileList.ReplaceAll(flatListReturn);
        }

        FileTree.ReplaceAll((treeRoot != null)
            ? treeRoot.Children
            : Array.Empty<FileSystemModel>());

        (List<FileSystemModel> FlatList, FileSystemModel? TreeRoot) BuildFullFileStructure()
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
    }

    /// <summary>
    /// Kick off monitoring of file system events.
    /// </summary>
    private void MonitorFileUpdates()
    {
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

        if (_batchUpdateTask != null)
        {
            _batchUpdateThreadCancellationTokenSource.Cancel();
            if (!_batchUpdateTask.IsCanceled && !_batchUpdateTask.Wait(1000))
            {
                throw new Exception();
            }
        }
    }

    public void Suspend() => _modsWatcher.EnableRaisingEvents = false;

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
                            var parent = FindParentModel(e.FullPath);
                            var newItem = CreateFromScratch(parent, e);
                            if (newItem != null)
                            {
                                parent?.Children.Add(newItem);
                                created.Add(newItem);
                                _fileLookup.TryAdd(e.FullPath, newItem);
                                _fileProcessing.TryRemove(e.FullPath, out _);
                            }
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
            var model = new FileSystemModel(parent, name, relativePath, isDirectory);
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
        ForceStop();

        var files = msg.Files;
        var batch = new List<FileSystemModel>();

        foreach (var file in files)
        {
            var gameRelativePath = file.FileName;
            var fullPath = Path.Combine(_projectDirectory, "archive", gameRelativePath);
            var fileInfo = new FileInfo(fullPath);
            var fileName = fileInfo.Name;
            var parentDirInfo = Directory.GetParent(fullPath);
            var parentPath = parentDirInfo!.FullName;

            if (_fileLookup.TryGetValue(parentPath, out var parent))
            {
                var fileSystemModel = new FileSystemModel(parent, fileName, fullPath, false);
                parent.Children.Add(fileSystemModel);
                _fileLookup.TryAdd(fullPath, fileSystemModel);
                batch.Add(fileSystemModel);
                continue;
            }

            var parentDirs = new Stack<DirectoryInfo>();
            var currentLevel = Directory.GetParent(fullPath)!;

            while (currentLevel.Name != "archive")
            {
                parentDirs.Push(currentLevel);
                currentLevel = currentLevel.Parent!;
            }

            var parentModel = _fileLookup[Path.Combine(_projectDirectory, "archive")]!;

            while (parentDirs.Count > 0)
            {
                var current = parentDirs.Pop();

                if (_fileLookup.TryGetValue(current.FullName, out var currentModel))
                {
                    parentModel = currentModel;
                    continue;
                }

                // Make the directory if needed. (Does nothing if already exists.)
                current.Create();
                var newCurrentModel = new FileSystemModel(parentModel, current.Name, current.FullName, true);
                parentModel.Children.Add(newCurrentModel);
                _fileLookup.TryAdd(current.FullName, newCurrentModel);
                batch.Add(newCurrentModel);
                parentModel = newCurrentModel;
            }

            var newFileModel = new FileSystemModel(parentModel, fileName, fullPath, false);
            parentModel.Children.Add(newFileModel);
            _fileLookup.TryAdd(fullPath, newFileModel);
            batch.Add(newFileModel);
        }

        DispatcherHelper.RunOnMainThread(() =>
        {
            FileList.AddRange(batch);
        }, DispatcherPriority.Background);

        Resume();

        var fileList = "";
        foreach (var file in files)
        {
            fileList += $"Added file to project: {file.FileName}\r\n";
        };

        _loggerService?.Info(fileList);
    }
}
