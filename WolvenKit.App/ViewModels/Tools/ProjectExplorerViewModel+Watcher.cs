using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.App.ViewModels.Tools;

public partial class ProjectExplorerViewModel
{
    #region fields

    private string _projectDirectory = string.Empty;
    private FileSystemModel? _projectFileSystemModel;
    private FileSystemWatcher _modsWatcher = null!;

    private readonly object _refreshLock = new();

    private Task? _updateTask;
    private CancellationTokenSource _updateThreadCancellationTokenSource = new();

    private readonly ConcurrentQueue<FileSystemEventArgsWrapper> _fileChanges = new();

    private ConcurrentDictionary<string, FileSystemModel> FileLookup { get; } = new();

    private readonly ConcurrentDictionary<string, FileSystemModel> _fileLookup = new();
    private readonly ConcurrentDictionary<string, long> _removedFiles = new();

    private static readonly List<string> s_ignoredExtensions =
    [
        "tmp",
        "pdnsave",
        "bak", // photoshop
        "blend@", // Blender temp files
        "blend1", // Blender temp files
    ];

    private static readonly List<string> s_backupFilePartials =
    [
        "_tmp", ".bak", ".bkp"
    ];

    private static bool HasIgnoredExtension(string? fileName)
    {
        var fileExtension = Path.GetExtension(fileName)?.ToUpper();
        return fileExtension is not null && s_ignoredExtensions.Any(partial =>
            fileExtension.Contains(partial, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>How often a create event is retried while its file doesn't exist on disk yet.</summary>
    private const int MaxCreateRetries = 10;

    /// <summary>Delay between those retries, in milliseconds.</summary>
    private const int CreateRetryDelayMs = 100;

    private static long NowMs() => DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

    private bool _isWatcherStopped;

    private bool IsWatcherStopped => _isWatcherStopped;

    #endregion

    #region Constructor

    /// <summary>
    /// Initializes the `_modsWatcher`.
    /// </summary>
    private void InitializeProjectWatcher()
    {
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

    #endregion

    #region Start / Resume / Watch / Unwatch Methods

    private void WatchProject(Cp77Project project)
    {
        _projectDirectory = project.FileDirectory;
        _projectFileSystemModel = new FileSystemModel(null, FileSystemModel.ProjectDirName, _projectDirectory, true);

        if (File.Exists(project.InterfaceProjectTreeStatePath))
        {
            ExpansionStateDictionary =
                JsonSerializer.Deserialize<Dictionary<string, bool>>(
                    File.ReadAllText(project.InterfaceProjectTreeStatePath)) ?? [];
        }
        else
        {
            ExpansionStateDictionary = [];
        }

        WatchLocation();
        RefreshWatcher();
    }

    public void Suspend() => _modsWatcher.EnableRaisingEvents = false;

    public void Resume() => _modsWatcher.EnableRaisingEvents = true;

    internal void UnwatchProject(Cp77Project? project)
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

    #endregion

    #region file watching

    private void Update(CancellationToken cancellationToken)
    {
        // Number of delayed events we've put back in a row without processing anything.
        // Used to sleep instead of busy-spinning when the queue only holds delayed retries.
        var deferredInARow = 0;

        while (true)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                break;
            }

            if (!_fileChanges.TryDequeue(out var e))
            {
                _removedFiles.Clear();
                deferredInARow = 0;

                Thread.Sleep(100);
                continue;
            }

            // Delayed retry whose time hasn't come yet: put it back. If everything in the queue is
            // waiting, sleep a little instead of spinning through it at 100% CPU.
            if (e.Ticks > NowMs())
            {
                _fileChanges.Enqueue(e);

                if (++deferredInARow >= _fileChanges.Count)
                {
                    deferredInARow = 0;
                    Thread.Sleep(10);
                }

                continue;
            }

            deferredInARow = 0;

            var extension = Path.GetExtension(e.Name);
            if (!string.IsNullOrEmpty(extension) && (HasIgnoredExtension(e.Name) && e.ChangeType != WatcherChangeTypes.Renamed))
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
            if (HasIgnoredExtension(e.Name))
            {
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

            // Create event was sent but the file isn't there (yet). It may still be in the middle of being
            // written, so retry a few times with a delay. If it never shows up, it was a short-lived file
            // (e.g. a temp file that got renamed or deleted right away): drop the event.
            if (!File.Exists(e.FullPath) && !Directory.Exists(e.FullPath))
            {
                if (e.RetryCount >= MaxCreateRetries)
                {
                    return;
                }

                e.Ticks = NowMs() + CreateRetryDelayMs;
                e.RetryCount++;

                _fileChanges.Enqueue(e);
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

                if (parent == null)
                {
                    continue;
                }

                if (!parent.Children.Contains(current))
                {
                    parent.Children.Add(current);
                }

                ExpandParentsOf(parent);
            }

            void ExpandParentsOf(FileSystemModel dir)
            {
                // Stop below the project root model: its RawRelativePath is the absolute project path.
                var paths = new List<string>();
                for (var d = dir; d is not null && !ReferenceEquals(d, _projectFileSystemModel); d = d.Parent)
                {
                    paths.Add(d.RawRelativePath);
                }

                if (paths.Count == 0)
                {
                    return;
                }

                // ExpansionStateDictionary is a plain Dictionary that the UI thread reads and serializes,
                // so only write to it there. Capture the instance: if a different project gets loaded
                // before this runs, its dictionary must not receive our paths.
                var state = ExpansionStateDictionary;
                DispatcherHelper.RunOnMainThread(() =>
                {
                    if (!ReferenceEquals(state, ExpansionStateDictionary))
                    {
                        return;
                    }

                    foreach (var path in paths)
                    {
                        if (state.TryGetValue(path, out var isExpanded) && isExpanded)
                        {
                            continue;
                        }

                        state[path] = true;
                        // Mark dirty, or the auto-expansion only reaches disk if the user also
                        // happens to expand/collapse something by hand.
                        _hasUnsavedFileTreeChanges = true;
                    }
                });
            }

            if (current is not null)
            {
                OnFileMaterialized?.Invoke(current);
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
                _fileChanges.Enqueue(new FileSystemEventArgsWrapper(new FileSystemEventArgs(WatcherChangeTypes.Created, _projectDirectory, renamedEventArgs.Name)));
                return;
            }

            var oldName = renamedEventArgs.OldName;
            var newName = renamedEventArgs.Name;

            if (!_fileLookup.TryGetValue(oldName, out var renamedModel))
            {
                // We never knew the old name (e.g. a temp file an external tool wrote and then renamed
                // before its create event got processed). Just add whatever is there now.
                EnqueueCreated(newName);
                return;
            }

            // Files, top-level folders, moves into another folder, and renames onto a name we already
            // track: drop the old node and add the new path from scratch.
            if (!renamedModel.IsDirectory
                || renamedModel.Parent is null
                || ReferenceEquals(renamedModel.Parent, _projectFileSystemModel)
                || _fileLookup.ContainsKey(newName)
                || !string.Equals(Path.GetDirectoryName(oldName), Path.GetDirectoryName(newName), StringComparison.Ordinal))
            {
                EnqueueDeleted(oldName);
                EnqueueCreated(newName);
                return;
            }

            // Directory renamed in place: re-key the directory and everything below it,
            // then rename the model (Rename() updates the children's paths recursively).
            var oldPrefix = oldName + Path.DirectorySeparatorChar;
            foreach (var key in _fileLookup.Keys.ToList())
            {
                if (key != oldName && !key.StartsWith(oldPrefix, StringComparison.Ordinal))
                {
                    continue;
                }

                var newKey = newName + key[oldName.Length..];
                if (_fileLookup.TryRemove(key, out var item))
                {
                    _fileLookup[newKey] = item;
                }
            }

            renamedModel.Rename(Path.GetFileName(newName));
        }

        void EnqueueCreated(string name) =>
            _fileChanges.Enqueue(new FileSystemEventArgsWrapper(
                new FileSystemEventArgs(WatcherChangeTypes.Created, _projectDirectory, name)));

        void EnqueueDeleted(string name) =>
            _fileChanges.Enqueue(new FileSystemEventArgsWrapper(
                new FileSystemEventArgs(WatcherChangeTypes.Deleted, _projectDirectory, name)));

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

    private void ForceStop()
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

    private void OnRenamed(object sender, RenamedEventArgs e) => _fileChanges.Enqueue(new FileSystemEventArgsWrapper(e));

    private void OnChanged(object sender, FileSystemEventArgs e) => _fileChanges.Enqueue(new FileSystemEventArgsWrapper(e));

    #endregion file watching

    #region filesystem loading

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

        public long EventAddedAt { get; } = NowMs();
    }

    public void RefreshWatcher()
    {
        lock (_refreshLock)
        {
            InternalRefreshWatcher();
        }
    }

    private void InternalRefreshWatcher()
    {
        if (string.IsNullOrEmpty(_projectDirectory))
        {
            // On first app launch, there's no project yet.
            return;
        }

        ForceStop();
        Clear();
        PopulateFiles();

        _updateThreadCancellationTokenSource = new CancellationTokenSource();
        _updateTask = Task.Factory.StartNew(() => Update(_updateThreadCancellationTokenSource.Token), _updateThreadCancellationTokenSource.Token);

        _modsWatcher.EnableRaisingEvents = true;
    }

    private void Clear()
    {
        _fileChanges.Clear();
        _fileLookup.Clear();
        FileTree.Clear();
        FileList.Clear();
    }

    private void PopulateFiles()
    {
        var allFiles = new DirectoryInfo(_projectDirectory)
            .GetFileSystemInfos("*", SearchOption.AllDirectories)
            .ToList();

        var entries = allFiles
            .Select(info => new Entry(
                info.FullName[(_projectDirectory.Length + 1)..],
                info.Attributes.HasFlag(FileAttributes.Directory)))
            .ToList();

        // Shortest-first guarantees a node's parent is already in _fileLookup when we reach it.
        entries.Sort((a, b) => a.RawRelPath.Length.CompareTo(b.RawRelPath.Length));
        FileList.SuppressNotification = true;
        WeakReferenceMessenger.Default.Send(new ChalkboardService.WillStartLoadingProjectFiles());

        try
        {
            foreach (var entry in entries)
            {
                LinkNode(entry);
            }
        }
        finally
        {
            FileList.SuppressNotification = false;
            WeakReferenceMessenger.Default.Send(new ChalkboardService.DidFinishLoadingProjectFiles());
        }
    }

    private readonly record struct Entry(string RawRelPath, bool IsDirectory);

    /// <summary>
    /// Make a FileSystemModel and put it in the tree. Must run single-threaded.
    /// </summary>
    private void LinkNode(Entry entry)
    {
        if (_fileLookup.ContainsKey(entry.RawRelPath))
        {
            return;
        }

        var parentPath = Path.GetDirectoryName(entry.RawRelPath);
        var parent = string.IsNullOrEmpty(parentPath)
            ? _projectFileSystemModel
            : _fileLookup[parentPath];

        var model = new FileSystemModel(
            parent,
            Path.GetFileName(entry.RawRelPath),
            entry.RawRelPath,
            entry.IsDirectory);

        if (!_fileLookup.TryAdd(entry.RawRelPath, model))
        {
            return;
        }

        if (!entry.IsDirectory)
        {
            FileList.Add(model);
        }

        if (string.IsNullOrEmpty(parentPath))
        {
            FileTree.Add(model);
        }
        else if (parent is { } parentModel)
        {
            parentModel.Children.Add(model);
        }
    }

    #endregion
}
