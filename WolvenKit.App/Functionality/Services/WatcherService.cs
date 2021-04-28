using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Catel;
using Catel.IoC;
using DynamicData;
using Orc.ProjectManagement;
using ReactiveUI;
using Splat;
using WolvenKit.Common.FNV1A;
using WolvenKit.Models;
using WolvenKit.MVVM.Model.ProjectManagement.Project;
using WolvenKit.ViewModels.Editor.Basic;

namespace WolvenManager.App.Services
{
    /// <summary>
    /// This service watches certain locations in the game files and notifies changes
    /// </summary>
    public class WatcherService : IWatcherService
    {
        #region fields

        private readonly SourceCache<FileModel, ulong> _files = new(_ => _.Hash);
        public IObservableCache<FileModel, ulong> Files => _files;

        private readonly IProjectManager _projectManager;
        private EditorProject ActiveMod => _projectManager.ActiveProject as EditorProject;

        private FileSystemWatcher _modsWatcher;

        #endregion

        public WatcherService()
        {
            _projectManager = ServiceLocator.Default.ResolveType<IProjectManager>();

            _projectManager.ProjectActivatedAsync += async delegate(object sender, ProjectUpdatedEventArgs args)
            {
                await ProjectManagerOnProjectActivatedAsync(sender, args);
            } ;
            _projectManager.ProjectClosedAsync += ProjectManagerOnProjectClosedAsync;
        }

        private Task ProjectManagerOnProjectClosedAsync(object sender, ProjectEventArgs e)
        {
            UnwatchLocation();
            return Task.CompletedTask;
        }

        private async Task ProjectManagerOnProjectActivatedAsync(object sender, ProjectUpdatedEventArgs e)
        {
            WatchLocation(ActiveMod.FileDirectory);
            await RefreshAsync();
            return;
        }


        private void WatchLocation(string location)
        {
            if (ActiveMod == null)
            {
                return;
            }

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
            _modsWatcher.EnableRaisingEvents = false;

            _modsWatcher.Created -= OnChanged;
            _modsWatcher.Changed -= OnChanged;
            _modsWatcher.Deleted -= OnChanged;
            _modsWatcher.Renamed -= OnRenamed;
            _modsWatcher.EnableRaisingEvents = false;
        }

        public bool IsSuspended { get; set; }


        /// <summary>
        /// initial refresh
        /// </summary>
        public async Task RefreshAsync() => await Task.Run(DetectProjectFiles);

        private void DetectProjectFiles()
        {
            var allFiles = Directory
                    .GetFileSystemEntries(ActiveMod.FileDirectory, "*", SearchOption.AllDirectories)
                ;

            _files.Edit(innerList =>
            {
                innerList.Clear();
                innerList.AddOrUpdate(allFiles.Select(_ => new FileModel(_)));
            });
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
                    _files.AddOrUpdate(new FileModel(e.FullPath));
                    break;
                }
                case WatcherChangeTypes.Deleted:
                    var hash = FNV1A64HashAlgorithm.HashString(FileModel.GetRelativeName(e.FullPath));
                    _files.Remove(hash);
                    break;
                case WatcherChangeTypes.Renamed:
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
