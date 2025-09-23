using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using WolvenKit.Common;

namespace WolvenKit.Interfaces.Extensions
{
    public static partial class StringPathExtensions
    {
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
        /// Is this a file path without invalid characters?
        /// </summary>
        public static bool IsSaneFilePath(this string target) =>
            target.All(c => !Path.GetInvalidPathChars().Contains(c));

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
        /// Checks if the file path has a given extension. Fuzzy matching (see examples below)
        /// </summary>
        /// <param name="filePath">The file path</param>
        /// <param name="fileExtension">fileExtension (e.g. '.yaml' or '.yml')</param>
        /// <example>
        /// <code>
        /// file.mesh.json  => true for .json, .mesh, and .mesh.json
        /// file.yaml       => true for .yaml and .yml
        /// </code>
        /// </example>
        public static bool HasFileExtension(this string filePath, string fileExtension)
        {
            var targetExtension = fileExtension.StartsWith('.') ? fileExtension : "." + fileExtension;
            var targetFileName = filePath.EndsWith(".json") && !fileExtension.Contains(".json")
                ? filePath.Replace(".json", "")
                : filePath;

            return targetExtension switch
            {
                ".yaml" or ".yml" => targetFileName.Contains(".yaml", StringComparison.OrdinalIgnoreCase) ||
                                     targetFileName.Contains(".yml", StringComparison.OrdinalIgnoreCase),
                _ => targetFileName.Contains(targetExtension, StringComparison.OrdinalIgnoreCase)
            };
        }

        /// <summary>
        /// Regular expression for file path separators, forward or backward slashes
        /// </summary>
        [GeneratedRegex(@"[\\/]+")]
        private static partial Regex PathSeparatorRegex();
    }
}
