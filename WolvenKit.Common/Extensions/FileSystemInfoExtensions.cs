using System;
using System.IO;

namespace WolvenKit.Common.Extensions
{
    public static class FileSystemInfoExtensions
    {
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
            return b1 != b2 ? throw new DirectoryNotFoundException() : b1;
        }

        public static string TrimmedExtension(this FileInfo fi) => fi.Extension.TrimStart('.');

        public static string GetRelativePath(this FileInfo fi, DirectoryInfo baseDir)
        {
            if (fi.FullName.Contains(baseDir.FullName))
            {

            }

            var rel = fi.FullName[(baseDir.FullName.Length + 1)..];


            return fi.FullName.Contains(baseDir.FullName)
                ? fi.FullName[(baseDir.FullName.Length + 1)..]
                : "";
        }

    }
}
