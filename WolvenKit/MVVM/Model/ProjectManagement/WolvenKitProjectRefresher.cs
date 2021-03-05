using System.IO;
using Catel;
using Catel.IoC;
using Orc.ProjectManagement;

namespace WolvenKit.MVVM.Model.ProjectManagement
{
    public class WolvenKitProjectRefresher : ProjectRefresherBase
    {
        #region fields

        private DirectoryInfo _dataLocation;
        private FileSystemWatcher _fileSystemWatcher;

        #endregion fields

        #region ctors

        public WolvenKitProjectRefresher(string location = "")
            : base(location)
        {
            Argument.IsNotNullOrWhitespace(() => location);

            ValidateLocation(location);

            IsEnabled = true;
        }

        #endregion ctors

        #region methods

        protected override void SubscribeToLocation(string location)
        {
            ValidateLocation(location);

            _fileSystemWatcher = new FileSystemWatcher(_dataLocation.FullName, "*")
            {
                NotifyFilter = NotifyFilters.LastWrite,
                IncludeSubdirectories = true
            };

            _fileSystemWatcher.Created += OnFileSystemWatcherChanged;
            _fileSystemWatcher.Changed += OnFileSystemWatcherChanged;
            _fileSystemWatcher.EnableRaisingEvents = true;
        }

        protected override void UnsubscribeFromLocation(string location)
        {
            _fileSystemWatcher.EnableRaisingEvents = false;

            _fileSystemWatcher.Created -= OnFileSystemWatcherChanged;
            _fileSystemWatcher.Changed -= OnFileSystemWatcherChanged;
            _fileSystemWatcher = null;
        }

        private void OnFileSystemWatcherChanged(object sender, FileSystemEventArgs e)
        {
            if (IsSuspended)
            {
                return;
            }

            var fileSystemWatcher = _fileSystemWatcher;
            using (new DisposableToken(this,
                x => fileSystemWatcher.EnableRaisingEvents = false,
                x => fileSystemWatcher.EnableRaisingEvents = true))
            {
                RaiseUpdated(e.FullPath);

                fileSystemWatcher.EnableRaisingEvents = true;
            }
        }

        private bool ValidateLocation(string location)
        {
            var projectManager = ServiceLocator.Default.ResolveType<IProjectManager>();

            // all wkit projects have a folder with the same name
            var projectInfo = new FileInfo(location);
            if (projectInfo.Directory == null)
            {
                return false;
            }
            var projectName = Path.GetFileNameWithoutExtension(location);

            _dataLocation =
                new DirectoryInfo(Path.Combine(projectInfo.Directory.FullName, projectName));
            if (!_dataLocation.Exists)
            {
                Directory.CreateDirectory(_dataLocation.FullName);
            }

            return true;
        }

        #endregion methods
    }
}
