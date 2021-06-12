using System;
using System.IO;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

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

        public static DirectoryInfo GetParent(this FileSystemInfo fsi) => fsi.IsDirectory() ? (fsi as DirectoryInfo).Parent : (fsi as FileInfo).Directory;

        public static bool IsDirectory(this FileSystemInfo fsi)
        {
            var b1 = fsi != null && (fsi.Attributes & FileAttributes.Directory) == FileAttributes.Directory;
            var b2 = fsi switch
            {
                DirectoryInfo => true,
                _ => false
            };
            if (b1 != b2)
            {
                throw new DirectoryNotFoundException();
            }
            else
            {
                return b1;
            }
        }

        public static string TrimmedExtension(this FileInfo fi) => fi.Extension.TrimStart('.');

        #endregion Methods
    }
}
