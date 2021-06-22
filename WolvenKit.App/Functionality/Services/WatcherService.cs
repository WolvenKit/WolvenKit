using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DynamicData;
using ReactiveUI;
using WolvenKit.Common.FNV1A;
using WolvenKit.Models;
using WolvenKit.MVVM.Model.ProjectManagement.Project;

namespace WolvenKit.Functionality.Services
{
    /// <summary>
    /// This service watches certain locations in the game files and notifies changes
    /// </summary>
    public class WatcherService : ReactiveObject, IWatcherService
    {
        #region fields

        private readonly SourceCache<FileModel, ulong> _files = new(_ => _.Hash);
        public IObservableCache<FileModel, ulong> Files => _files;

        private readonly IProjectManager _projectManager;

        private FileSystemWatcher _modsWatcher;

        public FileModel LastSelect { get; set; }

        //private readonly ReadOnlyObservableCollection<FileViewModel> _bindingModel;
        //public IObservable<IChangeSet<FileViewModel>> Connect() => _bindingModel.ToObservableChangeSet();

        #endregion

        public WatcherService(IProjectManager projectManager)
        {
            _projectManager = projectManager;

            _projectManager.WhenAnyValue(_ => _.IsProjectLoaded).Subscribe(async loaded =>
            {
                if (loaded)
                {
                    WatchLocation(_projectManager.ActiveProject.FileDirectory);
                    await RefreshAsync(_projectManager.ActiveProject);
                }
                else
                {
                    UnwatchLocation();
                }

            });
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
        public async Task RefreshAsync(EditorProject proj) => await Task.Run(() => DetectProjectFiles(proj));

        private void DetectProjectFiles(EditorProject proj)
        {
            var allFiles = Directory
                    .GetFileSystemEntries(proj.FileDirectory, "*", SearchOption.AllDirectories)
                ;

            _files.Edit(innerList =>
            {
                innerList.Clear();
                innerList.AddOrUpdate(allFiles.Select(_ => new FileModel(_)));
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

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (IsSuspended)
            {
                return;
            }

            switch (e.ChangeType)
            {
                case WatcherChangeTypes.Created:
                {
                    LastSelect = new FileModel(e.FullPath);
                    _files.AddOrUpdate(LastSelect);
                    break;
                }
                case WatcherChangeTypes.Deleted:
                    var hash = FNV1A64HashAlgorithm.HashString(FileModel.GetRelativeName(e.FullPath));
                    _files.Edit(inner =>
                    {
                        inner.RemoveKeys(GetChildrenKeysRecursive(hash));
                        inner.Remove(hash);
                    });
                    break;
                case WatcherChangeTypes.Renamed:
                    _files.AddOrUpdate(new FileModel(e.FullPath));
                    break;
                case WatcherChangeTypes.All:
                    break;
                case WatcherChangeTypes.Changed:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnRenamed(object sender, RenamedEventArgs e)
        {

        }



    }
}
