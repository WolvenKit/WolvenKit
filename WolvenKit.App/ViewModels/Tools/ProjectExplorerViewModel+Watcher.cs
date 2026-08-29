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
                ExpansionStateDictionary[dir.RawRelativePath] = true;

                if (dir.Parent != null)
                {
                    ExpandParentsOf(dir.Parent);
                }
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

            if (!_fileLookup.TryGetValue(renamedEventArgs.OldName, out var renamedModel))
            {
                _loggerService?.Warning($"Renamed file was not in the database: {renamedEventArgs.OldName}. Recommend to restart WolvenKit.");
                return;
            }

            if (!renamedModel.IsDirectory)
            {
                _fileChanges.Enqueue(new FileSystemEventArgsWrapper(
                    new FileSystemEventArgs(WatcherChangeTypes.Deleted, _projectDirectory, renamedEventArgs.OldName)));
                return;
            }

            foreach (var key in _fileLookup.Keys)
            {
                if (!key.StartsWith(renamedEventArgs.OldName + Path.DirectorySeparatorChar))
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

        public long EventAddedAt { get; } = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
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
