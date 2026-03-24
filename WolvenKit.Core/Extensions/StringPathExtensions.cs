using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using WolvenKit.Common;
using WolvenKit.Core.Services;

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
        /// Sanitizes a file path ensuring the resulting path conforms to operating system and archive standards.
        /// Wrapper method for <see cref="FilepathValidationTools.SanitizeArchiveFilePath(string, string)"/> exposing
        /// functionality as an extension method.
        /// </summary>
        /// <param name="target">The file path to sanitize.</param>
        /// <returns>Returns a sanitized file path, with invalid characters replaced and empty segments removed.</returns>
        /// <remarks>Path traversal is explicitly disallowed.</remarks>
        public static string ToFilePath(this string target) => FilepathValidationTools.SanitizeArchiveFilePath(target, "-");

        /// <summary>
        /// Sanitizes a file name ensuring the resulting name conforms to operating system and archive standards.
        /// If the input contains path separators, only the last segment is retained and all preceding segments are discarded.
        /// Wrapper method for <see cref="FilepathValidationTools.SanitizeArchiveFileName(string, string)"/> exposing
        /// functionality as an extension method.
        /// </summary>
        /// <param name="target">The file name to sanitize.</param>
        /// <returns>Returns the sanitized file name with invalid characters replaced.</returns>
        public static string ToFileName(this string target) => FilepathValidationTools.SanitizeArchiveFileName(target, "-");

        /// <summary>
        /// Validates whether the given file path conforms to operating system and archive standards.
        /// Wrapper method for <see cref="FilepathValidationTools.IsArchiveFilePathValid(string)"/> exposing
        /// functionality as an extension method.
        /// </summary>
        /// <param name="target">The file path to validate.</param>
        /// <returns>Returns true if the file path is valid, according to operating system and archive standards; otherwise, false.</returns>
        /// <remarks>Path traversal is explicitly disallowed.</remarks>
        public static bool IsFilePathValid(this string target) => FilepathValidationTools.IsArchiveFilePathValid(target);

        /// <summary>
        /// Sanitizes a file path ensuring the resulting path conforms to operating system and archive standards.
        /// Extension method for <see cref="FilepathValidationTools.SanitizeArchiveFilePath(string, string)"/>
        /// exoposing functionality as an extension method as well as optionally replacing the path separator with a
        /// forward slash.
        /// </summary>
        /// <param name="target">The file path to sanitize.</param>
        /// <param name="useForwardSlashes">Use forward slashes instead of <see cref="Path.DirectorySeparatorChar"/>?</param>
        /// <returns>Returns a sanitized file path, with invalid characters replaced and empty segments removed.</returns>
        /// <remarks>Path traversal is explicitly disallowed.</remarks>
        public static string SanitizeFilePath(this string target, bool useForwardSlashes = false)
        {
            var fp = FilepathValidationTools.SanitizeArchiveFilePath(target);
            return useForwardSlashes ? fp.Replace(Path.DirectorySeparatorChar, '/') : fp;
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

            return targetExtension switch
            {
                ".yaml" or ".yml" => filePath.Contains(".yaml", StringComparison.OrdinalIgnoreCase) ||
                                     filePath.Contains(".yml", StringComparison.OrdinalIgnoreCase),
                _ => filePath.Contains(targetExtension, StringComparison.OrdinalIgnoreCase)
            };
        }

        /// <summary>
        /// Regular expression for file path separators, forward or backward slashes
        /// </summary>
        [GeneratedRegex(@"[\\/]+")]
        private static partial Regex PathSeparatorRegex();
    }
}
