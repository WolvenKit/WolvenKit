using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WolvenKit.Common.Model;

namespace WolvenKit
{
    public partial class frmMain : Form
    {
        #region FileSystemWatcher
        // https://stackoverflow.com/a/6944516
        private List<string> filePaths;
        private ReaderWriterLockSlim rwlock;
        private System.Timers.Timer processTimer;
        //private string watchedPath;
        private void InitFileSystemWatcher()
        {
            watcher = new FileSystemWatcher();

            this.watcher.EnableRaisingEvents = true;
            this.watcher.IncludeSubdirectories = true;
            this.watcher.NotifyFilter = ((System.IO.NotifyFilters)((((System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.DirectoryName)
                                                                     | System.IO.NotifyFilters.LastWrite)
                                                                    | System.IO.NotifyFilters.LastAccess)));
            this.watcher.SynchronizingObject = this;
            this.watcher.Created += new System.IO.FileSystemEventHandler(this.Watcher_FileCreated);
            this.watcher.Deleted += new System.IO.FileSystemEventHandler(this.FileChanges_Detected);
            this.watcher.Renamed += new System.IO.RenamedEventHandler(this.FileRenames_Detected);

            watcher.Error += Watcher_Error;
            watcher.Path = ActiveMod.FileDirectory;
        }

        private void Watcher_Error(object sender, ErrorEventArgs e)
        {
            // Watcher crashed. Re-init.
            InitFileSystemWatcher();
        }

        private void Watcher_FileCreated(object sender, FileSystemEventArgs e)
        {
            try
            {
                rwlock.EnterWriteLock();
                filePaths.Add(e.FullPath);

                if (processTimer == null)
                {
                    // First file, start timer.
                    processTimer = new System.Timers.Timer(2000);
                    processTimer.Elapsed += ProcessQueue;
                    processTimer.Start();
                }
                else
                {
                    // Subsequent file, reset timer.
                    processTimer.Stop();
                    processTimer.Start();
                }
            }
            finally
            {
                rwlock.ExitWriteLock();
            }
        }

        private void ProcessQueue(object sender, System.Timers.ElapsedEventArgs args)
        {
            try
            {
                System.Console.WriteLine("Processing queue, " + filePaths.Count + " files created:");
                rwlock.EnterReadLock();
                foreach (string filePath in filePaths)
                {
                    System.Console.WriteLine(filePath);
                }
                filePaths.Clear();
            }
            finally
            {
                if (processTimer != null)
                {
                    processTimer.Stop();
                    processTimer.Dispose();
                    processTimer = null;
                }
                rwlock.ExitReadLock();
                OnFileChange(this, new RequestFilesChangeArgs(filePaths));
            }
        }

        //protected virtual void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        if (rwlock != null)
        //        {
        //            rwlock.Dispose();
        //            rwlock = null;
        //        }
        //        if (watcher != null)
        //        {
        //            watcher.EnableRaisingEvents = false;
        //            watcher.Dispose();
        //            watcher = null;
        //        }
        //    }
        //}

        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}


        private List<string> cachedFileSystemInfos;

        public void PauseMonitoring()
        {
            cachedFileSystemInfos = ActiveMod.Files;
            watcher.EnableRaisingEvents = false;
        }

        public void ResumeMonitoring()
        {
            if (ActiveMod != null)
            {
                watcher.Path = ActiveMod.FileDirectory;
                watcher.SynchronizingObject = this;
                watcher.EnableRaisingEvents = true;
                ModExplorer?.UpdateTreeView(true);

                var n_cachedFileSystemInfos = ActiveMod.Files;
                var addedfiles = n_cachedFileSystemInfos.Except(cachedFileSystemInfos);
                var removedfiles = cachedFileSystemInfos.Except(n_cachedFileSystemInfos);

                OnFileChange(this, new RequestFilesChangeArgs(addedfiles.Concat(removedfiles).Distinct().ToList()));
            }
        }
        private void FileRenames_Detected(object sender, RenamedEventArgs e)
        {
            switch (e.ChangeType)
            {
                case WatcherChangeTypes.Renamed:
                    {
                        ModExplorer?.UpdateTreeView(true, e.OldFullPath);
                        break;
                    }
                default:
                    throw new NotImplementedException();
            }

            OnFileChange(this, new RequestFilesChangeArgs(e.FullPath));
        }
        private void FileChanges_Detected(object sender, FileSystemEventArgs e)
        {
            switch (e.ChangeType)
            {
                case WatcherChangeTypes.Deleted:
                    {
                        ModExplorer?.UpdateTreeView(true, e.FullPath);
                        break;
                    }
                case WatcherChangeTypes.Renamed:
                    {
                        if (e is RenamedEventArgs re)
                            ModExplorer?.UpdateTreeView(true, re.OldFullPath);
                        break;
                    }
                default:
                    throw new NotImplementedException();
            }

            OnFileChange(this, new RequestFilesChangeArgs(e.FullPath));
        }
        #endregion

    }
}
