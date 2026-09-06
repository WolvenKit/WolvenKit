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

        #region Archive Specific Extensions

        /// <summary>
        /// Validates whether the given file path conforms to operating system and archive standards.
        /// Wrapper method for <see cref="FilepathValidationTools.IsArchiveFilePathValid(string)"/> exposing
        /// functionality as an extension method.
        /// </summary>
        /// <param name="target">The file path to validate.</param>
        /// <returns>Returns true if the file path is valid, according to operating system and archive standards; otherwise, false.</returns>
        /// <remarks>Path traversal is explicitly disallowed.</remarks>
        public static bool IsArchiveFilePathValid(this string target) => FilepathValidationTools.IsArchiveFilePathValid(target);

        /// <summary>
        /// Validates whether the given file name conforms to operating system and archive standards and does not contain directories.
        /// Wrapper method for <see cref="FilepathValidationTools.IsArchiveFileNameValid(string)"/> exposing functionality
        /// as an extension method.
        /// </summary>
        /// <param name="target">The file name to validate.</param>
        /// <returns>Returns true if the file name is valid, according to operating system and archive standards; otherwise, false.</returns>
        /// <remarks>Path traversal is explicitly disallowed.</remarks>
        public static bool IsArchiveFileNameValid(this string target) => FilepathValidationTools.IsArchiveFileNameValid(target);

        /// <summary>
        /// Sanitizes a file path ensuring the resulting path conforms to operating system and archive standards.
        /// Wrapper method for <see cref="FilepathValidationTools.SanitizeArchiveFilePath(string, string)"/> exposing
        /// functionality as an extension method.
        /// </summary>
        /// <param name="target">The file path to sanitize.</param>
        /// <param name="useForwardSlashes">If true, forward slashes are used instead of the directory separator provided by the OS.</param>
        /// <returns>Returns a sanitized file path, with invalid characters replaced and empty segments removed.</returns>
        /// <remarks>Path traversal is explicitly disallowed.</remarks>
        public static string ToArchiveFilePath(this string target, bool useForwardSlashes = false)
        {
            var fp = FilepathValidationTools.SanitizeArchiveFilePath(target);
            return useForwardSlashes ? fp.Replace(Path.DirectorySeparatorChar, '/') : fp;
        }

        /// <summary>
        /// Sanitizes a file name ensuring the resulting name conforms to operating system and archive standards.
        /// If the input contains path separators, only the last segment is retained and all preceding segments are discarded.
        /// Wrapper method for <see cref="FilepathValidationTools.SanitizeArchiveFileName(string, string)"/> exposing
        /// functionality as an extension method.
        /// </summary>
        /// <param name="target">The file name to sanitize.</param>
        /// <returns>Returns the sanitized file name with invalid characters replaced.</returns>
        public static string ToArchiveFileName(this string target) => FilepathValidationTools.SanitizeArchiveFileName(target);

        #endregion

        #region OS Specific Extensions

        /// <summary>
        /// Validates whether the given file path conforms to operating system standards.
        /// Wrapper method for <see cref="FilepathValidationTools.IsOsFilePathValid(string)"/> exposing functionality
        /// as an extension method.
        /// </summary>
        /// <param name="target">The file path to validate.</param>
        /// <returns>Returns true if the file path is valid, according to operating system standards; otherwise, false.</returns>
        /// <remarks>Considers a filepath where the last segment consists of a path traversal as invalid even if it is valid from the operating systems' perspective.</remarks>
        public static bool IsOsFilePathValid(this string target) => FilepathValidationTools.IsOsFilePathValid(target);

        /// <summary>
        /// Validates whether the given file name conforms to operating system standards and does not contain directories.
        /// Wrapper method for <see cref="FilepathValidationTools.IsOsFileNameValid(string)"/> exposing functionality
        /// as an extension method.
        /// </summary>
        /// <param name="target">The file name to validate.</param>
        /// <returns>Returns true if the file name is valid, according to operating system standards; otherwise, false.</returns>
        public static bool IsOsFileNameValid(this string target) => FilepathValidationTools.IsOsFileNameValid(target);

        /// <summary>
        /// Sanitizes a file path ensuring the resulting path conforms to operating system standards.
        /// Wrapper method for <see cref="FilepathValidationTools.SanitizeOsFilePath(string, string)"/> exposing functionality
        /// as an extension method.
        /// </summary>
        /// <param name="target">The file path to sanitize.</param>
        /// <param name="useForwardSlashes">If true, forward slashes are used instead of the directory separator provided by the OS.</param>
        /// <returns>Returns a sanitized file path, with invalid characters replaced and empty segments removed.</returns>
        /// <remarks>Despite path traversal being accepted by Windows as the last element of a filepath, this method sanitizes it away as it is not a valid filename.</remarks>
        public static string ToOsFilePath(this string target, bool useForwardSlashes = false)
        {
            var fp = FilepathValidationTools.SanitizeOsFilePath(target);
            return useForwardSlashes ? fp.Replace(Path.DirectorySeparatorChar, '/') : fp;
        }

        /// <summary>
        /// Sanitizes a file name ensuring the resulting name conforms to operating system standards.
        /// If the input contains path separators, only the last segment is retained and all preceding segments are discarded.
        /// Wrapper method for <see cref="FilepathValidationTools.SanitizeOsFileName(string, string)"/> exposing functionality
        /// as an extension method.
        /// </summary>
        /// <param name="target">The file name to sanitize.</param>
        /// <returns>Returns the sanitized file name with invalid characters replaced.</returns>
        public static string ToOsFileName(this string target) => FilepathValidationTools.SanitizeOsFileName(target);

        #endregion

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
    }
}
