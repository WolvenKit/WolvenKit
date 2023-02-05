using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using DynamicData;
using WolvenKit.App.Models;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.Core.Extensions;

namespace WolvenKit.App.Services;

/// <summary>
/// This service watches certain locations in the game files and notifies changes
/// </summary>
public class WatcherService : ObservableObject, IWatcherService
{
    #region fields

    private readonly SourceCache<FileModel, ulong> _files = new(_ => _.Hash);
    public IObservableCache<FileModel, ulong> Files => _files;

    private readonly IProjectManager _projectManager;

    private FileSystemWatcher? _modsWatcher;

    public FileModel? LastSelect { get; set; }

    private readonly Timer _timer;
    private const int s_waitTime = 100;

    private readonly List<string> _ignoredExtensions = new()
    {
        ".TMP",
        ".PDNSAVE"
    };

    #endregion

    public WatcherService(IProjectManager projectManager)
    {
        _projectManager = projectManager;
        _projectManager.PropertyChanged += ProjectManager_PropertyChanged;

        _timer = new Timer(OnTimer);
    }

    // HACK remove after e3 -S. Eberoth
    private async void OnTimer(object? state)
    {
        _timer.Change(-1, -1);

        await RefreshAsync(_projectManager.ActiveProject);
    }

    private async void ProjectManager_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName ==  nameof(IProjectManager.IsProjectLoaded))
        {
            if (_projectManager.IsProjectLoaded)
            {
                WatchLocation(_projectManager.ActiveProject.NotNull().ProjectDirectory);
                await RefreshAsync(_projectManager.ActiveProject);
            }
            else
            {
                UnwatchLocation();
            }
        }
    }

    private void WatchLocation(string location)
    {
        _modsWatcher = new FileSystemWatcher(location, "*")
        {
            NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.Attributes | NotifyFilters.DirectoryName,
            IncludeSubdirectories = true
        };
        _modsWatcher.Created += OnChanged;
        _modsWatcher.Changed += OnChanged;
        _modsWatcher.Deleted += OnChanged;
        _modsWatcher.Renamed += OnRenamed;
        _modsWatcher.EnableRaisingEvents = true;
    }

    private void UnwatchLocation()
    {
        if (_modsWatcher == null)
        {
            return;
        }

        _modsWatcher.EnableRaisingEvents = false;

        _modsWatcher.Created -= OnChanged;
        _modsWatcher.Changed -= OnChanged;
        _modsWatcher.Deleted -= OnChanged;
        _modsWatcher.Renamed -= OnRenamed;
        _modsWatcher.EnableRaisingEvents = false;

        //_files.Clear();
    }

    public bool IsSuspended { get; set; }


    /// <summary>
    /// initial refresh
    /// </summary>
    public async Task RefreshAsync(Cp77Project? proj)
    {
        if (proj == null)
        {
            return;
        }

        await Task.Run(() => DetectProjectFiles(proj));
    }

    private void DetectProjectFiles(Cp77Project proj)
    {
        var allFiles = Directory.GetFileSystemEntries(proj.ProjectDirectory, "*", SearchOption.AllDirectories);

        _files.Edit(innerList =>
        {
            innerList.Clear();
            innerList.AddOrUpdate(allFiles.Select(_ => new FileModel(_, proj)));
        });
    }

    private IEnumerable<ulong> GetChildrenKeysRecursive(ulong key)
    {
        var x = new List<ulong>();
        var lookup = _files.Items.ToLookup(x => x.ParentHash);

        foreach (var fileModel in lookup[key])
        {
            x.Add(fileModel.Hash);
            x.AddRange(GetChildrenKeysRecursive(fileModel.Hash));
        }
        return x;
    }

    public FileModel? GetFileModelFromHash(ulong hash)
    {
        var lookup = _files.Items.ToLookup(x => x.Hash);

        return lookup[hash].FirstOrDefault();
    }

    private void OnChanged(object sender, FileSystemEventArgs e)
    {
        if (_projectManager.ActiveProject is null)
        {
            return;
        }

        if (IsSuspended)
        {
            return;
        }

        var extension = Path.GetExtension(e.Name);
        if (!string.IsNullOrEmpty(extension) && _ignoredExtensions.Contains(extension))
        {
            return;
        }

        _timer.Change(s_waitTime, -1);

        /*switch (e.ChangeType)
        {
            case WatcherChangeTypes.Created:
            {
                try
                {
                    LastSelect = new FileModel(e.FullPath, _projectManager.ActiveProject);
                    _files.AddOrUpdate(LastSelect);
                }
                catch (Exception)
                {
                    // reading too fast?
                }
                break;
            }
            case WatcherChangeTypes.Deleted:
            {
                var key = FileModel.GenerateKey(e.FullPath, _projectManager.ActiveProject);
                _files.Edit(inner =>
                {
                    inner.RemoveKeys(GetChildrenKeysRecursive(key));
                    inner.Remove(key);
                });
                break;
            }
            case WatcherChangeTypes.All:
                break;
            case WatcherChangeTypes.Changed:
                break;
            case WatcherChangeTypes.Renamed:
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }*/
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnRenamed(object sender, RenamedEventArgs e)
    {
        if (_projectManager.ActiveProject is null)
        {
            return;
        }

        if (IsSuspended)
        {
            return;
        }

        var extension = Path.GetExtension(e.Name);
        if (!string.IsNullOrEmpty(extension) && _ignoredExtensions.Contains(extension))
        {
            return;
        }

        _timer.Change(s_waitTime, -1);

        /*var extension = Path.GetExtension(e.Name);
        if (string.IsNullOrEmpty(extension))
        {
            return;
        }

        var newIsTempFile = extension.ToUpper().Equals(".TMP", StringComparison.Ordinal) || extension.ToUpper().Equals(".PDNSAVE", StringComparison.Ordinal);
        switch (e.ChangeType)
        {
            case WatcherChangeTypes.Renamed:
            {
                var key = FileModel.GenerateKey(e.OldFullPath, _projectManager.ActiveProject);
                _files.RemoveKey(key);

                if (!newIsTempFile)
                {
                    _files.AddOrUpdate(new FileModel(e.FullPath, _projectManager.ActiveProject));
                }
                break;
            }

            case WatcherChangeTypes.Created:
                break;
            case WatcherChangeTypes.Deleted:
                break;
            case WatcherChangeTypes.Changed:
                break;
            case WatcherChangeTypes.All:
                break;
            default:
                break;
        }*/
    }
}
