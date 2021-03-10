//
// https://medium.com/@mikependon/designing-a-wpf-treeview-file-explorer-565a3f13f6f2
//

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using Catel.IoC;
using Catel.MVVM;
using Orc.ProjectManagement;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.MVVM.Model.ProjectManagement.Project;
using ObservableObject = Catel.Data.ObservableObject;

namespace WolvenKit.Models
{
    [Model]
    public class FileSystemInfoModel : ObservableObject, ISelectableTreeViewItemModel
    {
        #region Classes

        private class UpdateToken : FileSystemInfoModel
        {
            #region Constructors

            public UpdateToken(FileSystemInfoModel parent)
                : base(new DirectoryInfo("DummyFileSystemObjectInfo"), parent)
            {
            }

            #endregion Constructors
        }

        #endregion Classes

        #region fields

        private readonly IProjectManager _projectManager;
        private object _childrenLock = new();

        #endregion fields

        #region constructors

        public FileSystemInfoModel(FileSystemInfo fileSystemInfo, FileSystemInfoModel parent)
        {
            if (this is UpdateToken)
            {
                return;
            }

            Children = new ObservableCollection<FileSystemInfoModel>();
            Application.Current.Dispatcher.BeginInvoke(new Action(() => BindingOperations.EnableCollectionSynchronization(Children, _childrenLock)));

            FileSystemInfo = fileSystemInfo;
            Parent = parent;
            _projectManager = ServiceLocator.Default.ResolveType<IProjectManager>();

            if (FileSystemInfo is DirectoryInfo)
            {
                AddUpdateToken();
            }

            PropertyChanged += FileSystemObjectInfo_PropertyChanged;
        }

        #endregion constructors

        #region properties

        private ObservableCollection<FileSystemInfoModel> _children;
        private FileSystemInfo _fileSystemInfo;
        private bool _isExpanded;
        private bool _isSelected;

        public ObservableCollection<FileSystemInfoModel> Children
        {
            get => _children;
            set
            {
                if (_children != value)
                {
                    var oldValue = _children;
                    _children = value;
                    RaisePropertyChanged(() => Children, oldValue, value);
                }
            }
        }

        public string Extension => GetFileExtension();

        public FileSystemInfo FileSystemInfo
        {
            get => _fileSystemInfo;
            set
            {
                if (_fileSystemInfo != value)
                {
                    var oldValue = _fileSystemInfo;
                    _fileSystemInfo = value;
                    RaisePropertyChanged(() => FileSystemInfo, oldValue, value);
                }
            }
        }

        public string FullName => FileSystemInfo.FullName;
        public bool IsDirectory => FileSystemInfo is DirectoryInfo;

        public bool IsExpanded
        {
            get => _isExpanded;
            set
            {
                if (value != _isExpanded)
                {
                    _isExpanded = value;
                    RaisePropertyChanged(nameof(IsExpanded));
                }

                // Expand all the way up to the root.
                if (_isExpanded && Parent != null)
                {
                    Parent.IsExpanded = true;
                }
            }
        }

        public bool IsFile => FileSystemInfo is FileInfo;

        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                if (_isSelected != value)
                {
                    var oldValue = _isSelected;
                    _isSelected = value;
                    RaisePropertyChanged(() => IsSelected, oldValue, value);
                }
            }
        }

        public string Name => FileSystemInfo.Name;
        public FileSystemInfoModel Parent { get; }

        #endregion properties

        #region events

        public event EventHandler AfterExpand;

        public event EventHandler AfterExplore;

        public event EventHandler BeforeExpand;

        public event EventHandler BeforeExplore;

        public event EventHandler RequestRefresh;

        public void RaiseRequestRefresh() => RequestRefresh?.Invoke(this, EventArgs.Empty);

        private void RaiseAfterExpand() => AfterExpand?.Invoke(this, EventArgs.Empty);

        private void RaiseAfterExplore() => AfterExplore?.Invoke(this, EventArgs.Empty);

        private void RaiseBeforeExpand() => BeforeExpand?.Invoke(this, EventArgs.Empty);

        private void RaiseBeforeExplore() => BeforeExplore?.Invoke(this, EventArgs.Empty);

        #endregion events

        #region methods

        public void CollapseChildren(bool recursive)
        {
            IsExpanded = false;
            foreach (var info in Children)
            {
                info.IsExpanded = false;
                info.CollapseChildren(recursive);
            }
        }

        public void ExpandChildren(bool recursive)
        {
            IsExpanded = true;
            foreach (var info in Children)
            {
                info.IsExpanded = true;
                info.ExpandChildren(recursive);
            }
        }

        public Task ReloadSync()
        {
            if (Children.Count > 0)
            {
                lock (_childrenLock)
                {
                    Children.Clear();
                }
            }
            AddDirectories();
            AddFiles();

            return Task.CompletedTask;
        }

        private void AddDirectories()
        {
            if (FileSystemInfo is not DirectoryInfo directoryInfo)
            {
                return;
            }

            var directories = directoryInfo.GetDirectories();
            foreach (var directory in directories.OrderBy(d => d.Name))
            {
                if ((directory.Attributes & FileAttributes.System) != FileAttributes.System &&
                    (directory.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                {
                    var fileSystemObject = new FileSystemInfoModel(directory, this);
                    fileSystemObject.BeforeExplore += FileSystemObject_BeforeExplore;
                    fileSystemObject.AfterExplore += FileSystemObject_AfterExplore;
                    fileSystemObject.RequestRefresh += FileSystemObject_RequestRefresh;

                    lock (_childrenLock)
                    {
                        Children.Add(fileSystemObject);
                    }
                }
            }
        }

        private void AddFiles()
        {
            if (FileSystemInfo is not DirectoryInfo directoryInfo)
            {
                return;
            }

            var files = directoryInfo.GetFiles();
            foreach (var file in files.OrderBy(d => d.Name))
            {
                if ((file.Attributes & FileAttributes.System) != FileAttributes.System &&
                    (file.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                {
                    var fileSystemObject = new FileSystemInfoModel(file, this);
                    fileSystemObject.RequestRefresh += FileSystemObject_RequestRefresh;

                    lock (_childrenLock)
                    {
                        Children.Add(fileSystemObject);
                    }
                }
            }
        }

        private void AddUpdateToken()
        {
            lock (_childrenLock)
            {
                Children.Add(new UpdateToken(this));
            }
        }

        private void FileSystemObject_AfterExplore(object sender, EventArgs e) => RaiseAfterExplore();

        private void FileSystemObject_BeforeExplore(object sender, EventArgs e) => RaiseBeforeExplore();

        /// <summary>
        /// Exectuted when a RequestRefresh event is raised in one of the children
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileSystemObject_RequestRefresh(object sender, EventArgs e)
        {
            if (Parent == null || sender is not FileSystemInfoModel oldModel)
            {
                return;
            }

            // Update Model
            IsExpanded = false;
            if (Children.Count > 0)
            {
                lock (_childrenLock)
                {
                    Children.Clear();
                }
            }

            AddUpdateToken();
            IsExpanded = true;

            //expand child with sender name
            //TODO: make this better?
            var oldNode = Children.FirstOrDefault(_ => _.FullName == oldModel.FullName);
            if (oldNode != null)
            {
                oldNode.IsExpanded = true;
            }
        }

        private void FileSystemObjectInfo_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (!IsDirectory)
            {
                return;
            }

            switch (e.PropertyName)
            {
                case nameof(IsExpanded):
                    RaiseBeforeExpand();
                    if (IsExpanded)
                    {
                        if (HasDummy())
                        {
                            RaiseBeforeExplore();
                            RemoveDummy();
                            AddDirectories();
                            AddFiles();
                            RaiseAfterExplore();
                        }
                    }
                    RaiseAfterExpand();

                    break;

                default:
                    break;
            }
        }

        private UpdateToken GetDummy() => Children.OfType<UpdateToken>().FirstOrDefault();

        private string GetFileExtension()
        {
            var node = FileSystemInfo;
            if (node is DirectoryInfo)
            {
                if (_projectManager.ActiveProject is Tw3Project tw3Project)
                {
                    // check for base dirs
                    if (node.FullName == tw3Project.ModDirectory)
                    {
                        return nameof(ECustomImageKeys.ModImageKey);
                    }

                    if (node.FullName == tw3Project.ModCookedDirectory)
                    {
                        return nameof(ECustomImageKeys.ModCookedImageKey);
                    }

                    if (node.FullName == tw3Project.ModUncookedDirectory)
                    {
                        return nameof(ECustomImageKeys.ModUncookedImageKey);
                    }

                    if (node.FullName == tw3Project.DlcDirectory)
                    {
                        return nameof(ECustomImageKeys.DlcImageKey);
                    }

                    if (node.FullName == tw3Project.DlcCookedDirectory)
                    {
                        return nameof(ECustomImageKeys.DlcCookedImageKey);
                    }

                    if (node.FullName == tw3Project.DlcUncookedDirectory)
                    {
                        return nameof(ECustomImageKeys.DlcUncookedImageKey);
                    }

                    if (node.FullName == tw3Project.RawDirectory)
                    {
                        return nameof(ECustomImageKeys.RawImageKey);
                    }

                    if (node.FullName == tw3Project.RawModDirectory)
                    {
                        return nameof(ECustomImageKeys.RawModImageKey);
                    }

                    if (node.FullName == tw3Project.RawDlcDirectory)
                    {
                        return nameof(ECustomImageKeys.RawDlcImageKey);
                    }

                    if (node.FullName == tw3Project.RadishDirectory)
                    {
                        return nameof(ECustomImageKeys.RadishImageKey);
                    }
                }

                return IsExpanded
                    ? nameof(ECustomImageKeys.OpenDirImageKey)
                    : nameof(ECustomImageKeys.ClosedDirImageKey);
            }
            else
            {
                return (node as FileInfo)?.Extension;
            }
        }

        private bool HasDummy() => GetDummy() != null;

        private void RemoveDummy()
        {
            lock (_childrenLock)
            {
                Children.Remove(GetDummy());
            }
        }

        #endregion methods
    }
}
