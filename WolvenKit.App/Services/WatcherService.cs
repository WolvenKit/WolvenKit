using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DynamicData;
using ReactiveUI;
using WolvenKit.Models;
using WolvenKit.ProjectManagement.Project;

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

        #endregion

        public WatcherService(IProjectManager projectManager)
        {
            _projectManager = projectManager;

            _projectManager.WhenAnyValue(_ => _.IsProjectLoaded).Subscribe(async loaded =>
            {
                if (loaded)
                {
                    WatchLocation(_projectManager.ActiveProject.ProjectDirectory);
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
                    .GetFileSystemEntries(proj.ProjectDirectory, "*", SearchOption.AllDirectories)
                ;

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

        public FileModel GetFileModelFromHash(ulong hash)
        {
            var lookup = _files.Items.ToLookup(x => x.Hash);

            return lookup[hash].FirstOrDefault();
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (IsSuspended)
            {
                return;
            }

            if (Path.GetExtension(e.Name).ToUpper().Equals(".PDNSAVE", StringComparison.Ordinal) ||
                Path.GetExtension(e.Name).ToUpper().Equals(".TMP", StringComparison.Ordinal
                )
                )
            {
                return;
            }

            switch (e.ChangeType)
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
            if (IsSuspended)
            {
                return;
            }

            if (Path.GetExtension(e.Name).ToUpper().Equals(".TMP", StringComparison.Ordinal) ||
                Path.GetExtension(e.OldName).ToUpper().Equals(".TMP", StringComparison.Ordinal) ||
                Path.GetExtension(e.Name).ToUpper().Equals(".PDNSAVE", StringComparison.Ordinal) ||
                Path.GetExtension(e.OldName).ToUpper().Equals(".PDNSAVE", StringComparison.Ordinal)
                )
            {
                return;
            }

            switch (e.ChangeType)
            {
                case WatcherChangeTypes.Renamed:
                {
                    var key = FileModel.GenerateKey(e.OldFullPath, _projectManager.ActiveProject);
                    _files.RemoveKey(key);
                    _files.AddOrUpdate(new FileModel(e.FullPath, _projectManager.ActiveProject));
                    break;
                }

            }

        }



    }
}
