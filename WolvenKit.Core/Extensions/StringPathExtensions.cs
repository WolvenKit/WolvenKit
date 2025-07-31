using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using WolvenKit.Common;

namespace WolvenKit.Interfaces.Extensions
{
    public static partial class StringPathExtensions
    {
        // https://stackoverflow.com/a/3695190
        public static void EnsureFolderExists(this string path)
        {
            var directoryName = Path.GetDirectoryName(path);
            // If path is a file name only, directory name will be an empty string
            if (!string.IsNullOrEmpty(directoryName))
            {
                // Create all directories on the path that don't already exist
                Directory.CreateDirectory(directoryName);
            }
        }


        public static (string, bool, EProjectFolders) GetModRelativePath(this string fullpath,
            string activeModFileDirectory)
        {
            var relativePath = fullpath[(activeModFileDirectory.Length + 1)..];
            bool isDLC;
            var projectfolder = EProjectFolders.Cooked;

            if (relativePath.StartsWith("DLC\\"))
            {
                isDLC = true;
            }
            else if (relativePath.StartsWith("Mod\\"))
            {
                isDLC = false;
            }
            else
            {
                throw new NotImplementedException();
            }

            relativePath = relativePath[4..];

            if (relativePath.StartsWith(EProjectFolders.Cooked.ToString()))
            {
                relativePath = relativePath[(EProjectFolders.Cooked.ToString().Length + 1)..];
                projectfolder = EProjectFolders.Cooked;
            }

            if (relativePath.StartsWith(EProjectFolders.Uncooked.ToString()))
            {
                relativePath = relativePath[(EProjectFolders.Uncooked.ToString().Length + 1)..];
                projectfolder = EProjectFolders.Uncooked;
            }
            else if (relativePath.StartsWith(EArchiveType.SoundCache.ToString()))
            {
                relativePath = relativePath[(EArchiveType.SoundCache.ToString().Length + 1)..];
            }
            else if (relativePath.StartsWith(EArchiveType.Speech.ToString()))
            {
                relativePath = relativePath[(EArchiveType.Speech.ToString().Length + 1)..];
            }

            return (relativePath, isDLC, projectfolder);
        }

        /// <summary>
        /// Generates redengine friendly file path. 
        /// </summary>
        public static string ToFilePath(this string target) => string.Join(Path.DirectorySeparatorChar,
            target.Split(Path.DirectorySeparatorChar).Select(s => s.ToFileName()));

        /// <summary>
        /// Generates redengine friendly file name 
        /// </summary>
        public static string ToFileName(this string target) =>
            new string(target.Where(c => !Path.GetInvalidFileNameChars().Contains(c)).ToArray()).Trim()
                .Replace(" ", "_").ToLower();

        /// <summary>
        /// Sanitizes a file path by splitting it into segments and joining them on either a forward or backward slash
        /// </summary>
        /// <param name="target">String to run this on (this., it's an extension method)</param>
        /// <param name="useForwardSlashes">Use forward slashes instead of <see cref="Path.DirectorySeparatorChar"/>?</param>
        public static string SanitizeFilePath(this string target, bool useForwardSlashes = false)
        {
            var stringPartials = PathSeparatorRegex().Split(target);
            var directorySeparator = useForwardSlashes ? "/" : Path.DirectorySeparatorChar.ToString();

            return string.Join(directorySeparator, stringPartials);
        }

        /// <summary>
        /// Checks if a file path has two extensions, e.g. "file.mlsetup.json"
        /// </summary>
        public static bool HasTwoExtensions(this string filePath) => Path.GetFileName(filePath).Split('.').Length > 2;

        /// <summary>
        /// Regular expression for file path separators, forward or backward slashes
        /// </summary>
        [GeneratedRegex(@"[\\/]+")]
        private static partial Regex PathSeparatorRegex();
    }
}