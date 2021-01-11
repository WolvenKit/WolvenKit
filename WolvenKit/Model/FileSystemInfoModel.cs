//
// https://medium.com/@mikependon/designing-a-wpf-treeview-file-explorer-565a3f13f6f2
//

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Catel.Data;
using Catel.IoC;
using Catel.MVVM;
using Orc.ProjectManagement;
using WolvenKit.Common.Extensions;
using WolvenKit.Model.Project;

namespace WolvenKit.Model
{
    [Model]
    public class FileSystemInfoModel : ObservableObject
    {
        public enum ECustomImageKeys
        {
            OpenDirImageKey, //= "<ODIR>";
            ClosedDirImageKey, //= "<CDIR>";
            ModImageKey, //= "<MOD>";
            DlcImageKey, //= "<DLC>";
            DlcCookedImageKey, //= "<DLCC>";
            DlcUncookedImageKey, //= "<DLCU>";
            ModCookedImageKey, //= "<MODC>";
            ModUncookedImageKey, //= "<MODU>";
            RawImageKey, //= "<RAW>";
            RadishImageKey,
            RawModImageKey,
            RawDlcImageKey
        }

        #region fields

        
        private readonly IProjectManager _projectManager;
        private readonly FileSystemInfoModel _parent;

        #endregion

        #region constructors

        //public FileSystemInfoModel(FileSystemInfo info)
        //    : this(info, null)
        //{
        //}

        public  FileSystemInfoModel(FileSystemInfo fileSystemInfo, FileSystemInfoModel parent)
        {
            if (this is DummyFileSystemObjectInfo)
            {
                return;
            }

            Children = new ObservableCollection<FileSystemInfoModel>();
            FileSystemInfo = fileSystemInfo;
            _parent = parent;
            _projectManager = ServiceLocator.Default.ResolveType<IProjectManager>();

            if (FileSystemInfo is DirectoryInfo)
            {
                AddDummy();
            }

            PropertyChanged += new PropertyChangedEventHandler(FileSystemObjectInfo_PropertyChanged);
        }

        #endregion

        #region events

        public event EventHandler RequestRefresh;

        public event EventHandler BeforeExpand;

        public event EventHandler AfterExpand;

        public event EventHandler BeforeExplore;

        public event EventHandler AfterExplore;

        
        public void RaiseRequestRefresh() => RequestRefresh?.Invoke(this, EventArgs.Empty);

        private void RaiseBeforeExpand() => BeforeExpand?.Invoke(this, EventArgs.Empty);

        private void RaiseAfterExpand() => AfterExpand?.Invoke(this, EventArgs.Empty);

        private void RaiseBeforeExplore() => BeforeExplore?.Invoke(this, EventArgs.Empty);

        private void RaiseAfterExplore() => AfterExplore?.Invoke(this, EventArgs.Empty);

        #endregion

        #region eventHandlers

        void FileSystemObjectInfo_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (FileSystemInfo is DirectoryInfo)
            {
                if (string.Equals(e.PropertyName, "IsExpanded", StringComparison.CurrentCultureIgnoreCase))
                {
                    RaiseBeforeExpand();
                    if (IsExpanded)
                    {
                        if (HasDummy())
                        {
                            RaiseBeforeExplore();
                            RemoveDummy();
                            ExploreDirectories();
                            ExploreFiles();
                            RaiseAfterExplore();
                        }
                    }
                    RaiseAfterExpand();
                }
            }
        }

        #endregion

        #region properties

        private bool _isExpanded;
        public bool IsExpanded
        {
            get => _isExpanded;
            set
            {
                if (value != _isExpanded)
                {
                    _isExpanded = value;
                    this.RaisePropertyChanged(nameof(IsExpanded));
                }

                // Expand all the way up to the root.
                if (_isExpanded && _parent != null)
                    _parent.IsExpanded = true;
            }
        }

        private bool _isSelected;
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

        public bool IsDirectory => FileSystemInfo is DirectoryInfo;
        public bool IsFile => FileSystemInfo is FileInfo;

        public string Extension => GetFileExtension();
        public string Name => FileSystemInfo.Name;
        public string FullName => FileSystemInfo.FullName;

        private ObservableCollection<FileSystemInfoModel> _children;
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

        


        private FileSystemInfo _fileSystemInfo;
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
        #endregion

        #region methods

        private void AddDummy() => Children.Add(new DummyFileSystemObjectInfo(this));

        private bool HasDummy() => GetDummy() != null;

        private DummyFileSystemObjectInfo GetDummy() => Children.OfType<DummyFileSystemObjectInfo>().FirstOrDefault();

        private void RemoveDummy() => Children.Remove(GetDummy());

        private void ExploreDirectories()
        {
            if (FileSystemInfo is DirectoryInfo directoryInfo)
            {
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

                        Children.Add(fileSystemObject);
                    }
                }
            }
        }

        private void ExploreFiles()
        {
            if (FileSystemInfo is DirectoryInfo directoryInfo)
            {
                var files = directoryInfo.GetFiles();
                foreach (var file in files.OrderBy(d => d.Name))
                {
                    if ((file.Attributes & FileAttributes.System) != FileAttributes.System &&
                        (file.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                    {
                        var fileSystemObject = new FileSystemInfoModel(file, this);
                        fileSystemObject.RequestRefresh += FileSystemObject_RequestRefresh;

                        Children.Add(fileSystemObject);
                    }
                }
            }
        }

        private void FileSystemObject_RequestRefresh(object sender, EventArgs e)
        {
            if (_parent == null)
                return;
            
            // TODO
            /*_parent.*/IsExpanded = false;
            /*_parent?.*/Children.Clear();
            /*_parent?.*/AddDummy();
            /*_parent.*/IsExpanded = true;
        }

        private void FileSystemObject_AfterExplore(object sender, EventArgs e) => RaiseAfterExplore();

        private void FileSystemObject_BeforeExplore(object sender, EventArgs e) => RaiseBeforeExplore();

        

        public void ExpandChildren(bool recursive)
        {
            IsExpanded = true;
            foreach (var info in Children)
            {
                info.IsExpanded = true;
                info.ExpandChildren(recursive);
            }
        }

        public void CollapseChildren(bool recursive)
        {
            IsExpanded = false;
            foreach (var info in Children)
            {
                info.IsExpanded = false;
                info.CollapseChildren(recursive);
            }
        }

        private string GetFileExtension()
        {
            var node = FileSystemInfo;
            if (node as DirectoryInfo != null)
            {
                if (_projectManager.ActiveProject is Tw3Project tw3Project)
                {
                    // check for base dirs
                    if (node.FullName == tw3Project.ModDirectory)
                        return ECustomImageKeys.ModImageKey.ToString();
                    if (node.FullName == tw3Project.ModCookedDirectory)
                        return ECustomImageKeys.ModCookedImageKey.ToString();
                    if (node.FullName == tw3Project.ModUncookedDirectory)
                        return ECustomImageKeys.ModUncookedImageKey.ToString();

                    if (node.FullName == tw3Project.DlcDirectory)
                        return ECustomImageKeys.DlcImageKey.ToString();
                    if (node.FullName == tw3Project.DlcCookedDirectory)
                        return ECustomImageKeys.DlcCookedImageKey.ToString();
                    if (node.FullName == tw3Project.DlcUncookedDirectory)
                        return ECustomImageKeys.DlcUncookedImageKey.ToString();

                    if (node.FullName == tw3Project.RawDirectory)
                        return ECustomImageKeys.RawImageKey.ToString();
                    if (node.FullName == tw3Project.RawModDirectory)
                        return ECustomImageKeys.RawModImageKey.ToString();
                    if (node.FullName == tw3Project.RawDlcDirectory)
                        return ECustomImageKeys.RawDlcImageKey.ToString();

                    if (node.FullName == tw3Project.RadishDirectory)
                        return ECustomImageKeys.RadishImageKey.ToString();
                }
                

                return IsExpanded
                    ? ECustomImageKeys.OpenDirImageKey.ToString()
                    : ECustomImageKeys.ClosedDirImageKey.ToString();
            }
            else
                return (node as FileInfo)?.Extension;
        }

        #endregion
    }

    internal class DummyFileSystemObjectInfo : FileSystemInfoModel
    {
        public DummyFileSystemObjectInfo(FileSystemInfoModel parent)
            : base(new DirectoryInfo("DummyFileSystemObjectInfo"), parent)
        {
        }
    }
}
