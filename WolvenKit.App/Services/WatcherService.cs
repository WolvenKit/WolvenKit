using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.Common;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.App.Services;

public class FileSystemModel : INotifyPropertyChanged
{
    public const string ProjectDirName = "<ProjectDir>";

    private string _fileSizeStr = null!;
    private long _fileSize;
    
    [Browsable(false)] public FileSystemModel? Parent { get; }

    public string Name { get; }
    [Browsable(false)] public string RawRelativePath { get; private set; }
    [Display(Name = "Relative Path")] public string GameRelativePath { get; private set; } = null!;
    [Display(Name = "System Path")] public string FullName { get; private set; } = null!;
    
    [Browsable(false)] public ulong Hash { get; private set; }
    [Display(Name = "Hash")] public string HashStr { get; private set; } = "0";

    [Browsable(false)]
    public long FileSize
    {
        get => _fileSize;
        private set => SetField(ref _fileSize, value);
    }

    [Display(Name = "File Size")]
    public string FileSizeStr
    {
        get => _fileSizeStr;
        private set => SetField(ref _fileSizeStr, value);
    }

    public string Extension { get; } = "default";

    [Browsable(false)] public bool IsExpanded { get; set; }
    [Browsable(false)] public DispatchedObservableCollection<FileSystemModel> Children { get; } = new();
    [Browsable(false)] public bool IsDirectory { get; }

    public FileSystemModel(FileSystemModel? parent, string name, string relativePath, bool isDirectory)
    {
        Parent = parent;
        Name = name;
        RawRelativePath = relativePath;
        IsDirectory = isDirectory;

        GetMetadata();

        if (IsDirectory)
        {
            Extension = ECustomImageKeys.OpenDirImageKey.ToString();
            if (relativePath.Equals("archive", StringComparison.CurrentCultureIgnoreCase))
            {
                Extension = Constants.ModDirectoryTop;
            }
            else if(relativePath.Equals("raw", StringComparison.CurrentCultureIgnoreCase))
            {
                Extension = Constants.RawDirectoryTop;
            }
            else if (relativePath.Equals("resources", StringComparison.CurrentCultureIgnoreCase))
            {
                Extension = Constants.ResourceDirectoryTop;
            }
            else if (Parent != null)
            {
                Extension = Parent.Extension;
            }
        }
        else
        {
            Extension = Path.GetExtension(Name).TrimStart('.');

            UpdateFileInfo();
        }

        Children.CollectionChanged += Children_OnCollectionChanged;
    }

    private void Children_OnCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        IsExpanded = Children.Count > 0;
    }

    public void UpdateFileInfo()
    {
        FileSize = new FileInfo(FullName).Length;
        FileSizeStr = GetFileSizeStr(FileSize);
    }

    private void GetMetadata()
    {
        var hashParts = new List<string>();

        var root = this;
        var current = this;
        while (current != null)
        {
            if (current.Parent?.Name != ProjectDirName && current.Name != ProjectDirName)
            {
                hashParts.Add(current.Name);
            }

            root = current;
            current = current.Parent;
        }
        hashParts.Reverse();

        GameRelativePath = string.Join(ResourcePath.DirectorySeparatorChar, hashParts);
        FullName = Path.Combine(root.RawRelativePath, RawRelativePath);

        if (Parent?.Extension == Constants.ModDirectoryTop)
        {
            if (Parent.RawRelativePath == "archive" && ulong.TryParse(Path.GetFileNameWithoutExtension(Name), out var hash))
            {
                Hash = hash;
            }
            else
            {
                Hash = ResourcePath.CalculateHash(GameRelativePath);
            }

            HashStr = Hash.ToString();
        }
    }

    public static string GetFileSizeStr(long fileSize)
    {
        string[] sizes = ["B", "KB", "MB", "GB", "TB"];
        double len = fileSize;
        var order = 0;
        while (len >= 1024 && order++ < sizes.Length - 1)
        {
            len /= 1024;
        }

        return string.Format(CultureInfo.InvariantCulture, "{0:0.##} {1}", len, sizes[order]);
    }

    #region INotifyPropertyChanged

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value))
        {
            return false;
        }

        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }

    #endregion
}

/// <summary>
/// This service watches certain locations in the game files and notifies changes
/// </summary>
public partial class WatcherService : ObservableObject, IWatcherService
{
    #region fields

    private string _projectDirectory = string.Empty;
    private FileSystemModel? _projectFileSystemModel;

    private FileSystemWatcher _modsWatcher;

    private readonly object _refreshLock = new();

    private Task? _updateTask;
    private CancellationTokenSource _updateThreadCancellationTokenSource = new();

    private readonly ManualResetEventSlim _eventStopper = new();

    private readonly ConcurrentQueue<FileSystemEventArgs> _fileChanges = new();

    private readonly ConcurrentDictionary<string, FileSystemModel> _fileLookup = new();

    [ObservableProperty]
    private DispatchedObservableCollection<FileSystemModel> _fileList = new();

    [ObservableProperty]
    private DispatchedObservableCollection<FileSystemModel> _fileTree = new();

    private readonly List<string> _ignoredExtensions = new()
    {
        ".TMP",
        ".PDNSAVE"
    };

    #endregion

    public WatcherService()
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

    public void WatchProject(Cp77Project project)
    {
        _projectDirectory = project.FileDirectory;
        _projectFileSystemModel = new FileSystemModel(null, FileSystemModel.ProjectDirName, _projectDirectory, true);

        WatchLocation();
        Refresh();
    }

    public void UnwatchProject(Cp77Project project) => UnwatchLocation();

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
                Thread.Sleep(100);
                continue;
            }

            var extension = Path.GetExtension(e.Name);
            if (!string.IsNullOrEmpty(extension) && _ignoredExtensions.Contains(extension.ToUpper()))
            {
                continue;
            }

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
                    throw new Exception();
                case WatcherChangeTypes.All:
                    throw new Exception();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        void Create(FileSystemEventArgs e)
        {
            var projectPath = e.FullPath[(_projectDirectory.Length + 1)..];
            var pathParts = projectPath.Split(Path.DirectorySeparatorChar);

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

                if (_fileLookup.TryGetValue(tmpPath, out var current))
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

                if (_fileLookup.TryAdd(tmpPath, current))
                {
                    if (string.IsNullOrEmpty(tmpParentPath))
                    {
                        FileTree.Add(current);
                    }

                    if (parent != null && !parent.Children.Contains(current))
                    {
                        parent.Children.Add(current);
                    }
                }
            }
        }

        void Changed(FileSystemEventArgs e)
        {
            if (string.IsNullOrEmpty(e.Name) || !_fileLookup.TryGetValue(e.Name, out var item))
            {
                throw new TodoException();
            }

            if (item.IsDirectory)
            {
                return;
            }

            item.UpdateFileInfo();
        }

        void Delete(FileSystemEventArgs e)
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
        _fileLookup.Clear();
        FileTree.Clear();
        FileList.Clear();
    }

    private void InternalRefresh()
    {
        ForceStop();
        Clear();

        var allFiles = new DirectoryInfo(_projectDirectory).GetFileSystemInfos("*", SearchOption.AllDirectories);
        foreach (var fileSystemInfo in allFiles)
        {
            var name = fileSystemInfo.FullName[(_projectDirectory.Length + 1)..];
            _fileChanges.Enqueue(new FileSystemEventArgs(WatcherChangeTypes.Created, _projectDirectory, name));
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
            if (!_updateTask.Wait(1000))
            {
                throw new Exception();
            }
        }
    }

    private void OnRenamed(object sender, RenamedEventArgs e)
    {
        var oldDirectory = e.OldFullPath;
        if (e.OldName != null)
        {
            oldDirectory = e.OldFullPath[..e.OldFullPath.LastIndexOf(e.OldName, StringComparison.Ordinal)];
        }
        OnChanged(sender, new FileSystemEventArgs(WatcherChangeTypes.Deleted, oldDirectory, e.OldName));

        var directory = e.FullPath;
        if (e.Name != null)
        {
            directory = e.FullPath[..e.FullPath.LastIndexOf(e.Name, StringComparison.Ordinal)];
        }
        OnChanged(sender, new FileSystemEventArgs(WatcherChangeTypes.Created, directory, e.Name));
    }

    private void OnChanged(object sender, FileSystemEventArgs e) => _fileChanges.Enqueue(e);
}
