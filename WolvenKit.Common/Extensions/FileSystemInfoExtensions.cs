using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Common.Extensions
{
    public static class FileSystemInfoExtensions
    {
        public static bool IsDirectory(this FileSystemInfo fsi)
        {
            return (fsi.Attributes & FileAttributes.Directory) == FileAttributes.Directory;
        }

        public static bool HasFilesOrFolders(this FileSystemInfo fsi)
        {
            if (!fsi.IsDirectory())
                return false;
            var di = fsi as DirectoryInfo;
            return (di.GetFiles().Any() || di.GetDirectories().Any());
        }

        public static DirectoryInfo GetParent(this FileSystemInfo fsi)
        {
            if (fsi.IsDirectory())
                return (fsi as DirectoryInfo).Parent;
            else
                return (fsi as FileInfo).Directory;
        }
    }
}
