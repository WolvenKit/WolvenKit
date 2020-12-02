using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Catel.Data;
using Catel.IoC;
using Orc.ProjectManagement;
using WolvenKit.Common.Extensions;

namespace WolvenKit.App.Model
{
    


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

        private readonly FileSystemInfo _fileSystemInfo;
        private readonly IProjectManager _projectManager;
        private readonly FileSystemInfoModel _parent;

        public FileSystemInfoModel(FileSystemInfo info)
            : this(info, null)
        {
        }

        private FileSystemInfoModel(FileSystemInfo fileSystemInfo, FileSystemInfoModel parent)
        {
            _fileSystemInfo = fileSystemInfo;
            _parent = parent;
            _projectManager = ServiceLocator.Default.ResolveType<IProjectManager>();

            List<FileSystemInfoModel> list = new List<FileSystemInfoModel>();
            if (_fileSystemInfo is DirectoryInfo directoryInfo)
                foreach (var child in directoryInfo.GetFileSystemInfos()) 
                    list.Add(new FileSystemInfoModel(child, this));

            _children = new List<FileSystemInfoModel>(list);
        }


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

        public bool IsSelected { get; set; }

        public string Extension => GetFileExtension();
        public string Name => _fileSystemInfo.Name;
        public string FullName => _fileSystemInfo.FullName;

        private readonly IEnumerable<FileSystemInfoModel> _children = new List<FileSystemInfoModel>();
        public IEnumerable<FileSystemInfoModel> Children => _children;

        public IEnumerable<FileSystemInfoModel> AllChildren => Children.Concat(Children.SelectMany(_ => _.AllChildren));

        //public IEnumerable<FileSystemInfoModel> Children => _fileSystemInfo is DirectoryInfo di
        //    ? di.GetFileSystemInfos().Select(_ => new FileSystemInfoModel(_, this))
        //    : new List<FileSystemInfoModel>();


        public void ExpandChildren(bool recursive)
        {
            foreach (var info in Children)
            {
                info.IsExpanded = true;
                info.ExpandChildren(recursive);
            }
        }
        public void CollapseChildren(bool recursive)
        {
            foreach (var info in Children)
            {
                info.IsExpanded = false;
                info.CollapseChildren(recursive);
            }
        }

        private string GetFileExtension()
        {
            
            

            var node = _fileSystemInfo;
            if (node.IsDirectory())
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
    }
}
