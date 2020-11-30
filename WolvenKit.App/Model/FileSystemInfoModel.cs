using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Catel.IoC;
using Orc.ProjectManagement;
using WolvenKit.Common.Extensions;

namespace WolvenKit.App.Model
{
    


    public abstract class FileSystemInfoModel
    {
        protected readonly FileSystemInfo _fileSystemInfo;
        private readonly IProjectManager _projectManager;

        protected FileSystemInfoModel(FileSystemInfo fileSystemInfo)
        {
            _fileSystemInfo = fileSystemInfo;
            _projectManager = ServiceLocator.Default.ResolveType<IProjectManager>();
        }

        public string Extension => GetFileExtension();
        public bool IsExpanded { get; set; }


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

    public class DirectoryInfoModel : FileSystemInfoModel
    {
        public DirectoryInfoModel(DirectoryInfo directoryInfo) : base(directoryInfo) { }

        public string Name => _fileSystemInfo.Name;

        public IEnumerable<FileSystemInfoModel> Children
        {
            get
            {
                var children = new List<FileSystemInfoModel>();
                foreach (var fileSystemInfo in (_fileSystemInfo as DirectoryInfo).GetFileSystemInfos())
                {
                    switch (fileSystemInfo)
                    {
                        case DirectoryInfo di:
                            children.Add(new DirectoryInfoModel(di));
                            break;
                        case FileInfo fi:
                            children.Add(new FileInfoModel(fi));
                            break;
                    }
                }

                return children;
            }
        }
    }

    public class FileInfoModel : FileSystemInfoModel
    {
        public FileInfoModel(FileInfo fileInfo) : base(fileInfo) { }

        public string Name => _fileSystemInfo.Name;
    }
}
