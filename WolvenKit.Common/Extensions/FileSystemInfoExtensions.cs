using System;
using System.IO;
using System.Linq;

namespace WolvenKit.Common.Extensions
{
    public static class FileSystemInfoExtensions
    {
        #region Methods

        public static void CopyToAndCreate(this FileInfo fi, string destinationpath, bool overwrite = false)
        {
            try
            {
                var did = Path.GetDirectoryName(destinationpath);
                Directory.CreateDirectory(did);
                fi.CopyTo(destinationpath, overwrite);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DirectoryInfo GetParent(this FileSystemInfo fsi)
        {
            if (fsi.IsDirectory())
                return (fsi as DirectoryInfo).Parent;
            else
                return (fsi as FileInfo).Directory;
        }

        public static bool HasFilesOrFolders(this FileSystemInfo fsi)
        {
            if (!fsi.Exists)
                return false;
            if (!fsi.IsDirectory())
                return false;
            var di = fsi as DirectoryInfo;
            try
            {
                return ((di.GetFiles() != null && di.GetFiles().Any()) || (di.GetDirectories() != null && di.GetDirectories().Any()));
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool IsDirectory(this FileSystemInfo fsi)
        {
            return fsi != null && (fsi.Attributes & FileAttributes.Directory) == FileAttributes.Directory;
        }

        #endregion Methods
    }
}
