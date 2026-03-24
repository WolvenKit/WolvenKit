using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace WolvenKit.Core.Services;

/// <summary>
/// Provides helper methods for validating and sanitizing file paths and names for both in archive and the general OS
/// </summary>
public static class FilepathValidationTools
{
    #region OperatingSystem

    /// <summary>
    /// A set of characters that are considered invalid in operating system file paths.
    /// </summary>
    public static readonly HashSet<char> InvalidOsCharacters = new(Path.GetInvalidPathChars());

    /// <summary>
    /// A regular expression pattern that matches invalid path traversal sequences (any string consisting of only dots and or spaces with more than 3 dots).
    /// </summary>
    private static readonly Regex InvalidPathTraversal = new Regex(@"^(?=(?:[^.]*\.){3,})[. ]+$");

    /// <summary>
    /// Validates whether the given file path conforms to operating system standards by checking
    /// for invalid characters, invalid path traversal, and ensuring no sections are empty or
    /// improperly formatted (e.g., containing dots and spaces only).
    /// </summary>
    /// <param name="filepath">The file path to validate.</param>
    /// <returns>Returns true if the file path is valid, according to operating system standards; otherwise, false.</returns>
    /// <remarks>Considers a filepath where the last segment consists of a path traversal as invalid even if it is valid from the operating systems perspective</remarks>
    public static bool IsOsFilePathValid(string filepath)
    {
        var normalizedFilepathParts = NormalizeFilePath(filepath).Split(Path.DirectorySeparatorChar);
        return normalizedFilepathParts.All(part => !string.IsNullOrEmpty(part) &&
                                                   part.All(c => !InvalidOsCharacters.Contains(c)) &&
                                                   !InvalidPathTraversal.IsMatch(part) &&
                                                   part == part.Trim()) &&
               !IsOnlyDotsAndSpaces.IsMatch(normalizedFilepathParts.Last());
    }

    /// <summary>
    /// Validates whether the given file name conforms to operating system standards by ensuring that
    /// it does not contain invalid characters, does not represent a path traversal, and has only one segment
    /// without directory separators.
    /// </summary>
    /// <param name="filename">The file name to validate.</param>
    /// <returns>Returns true if the file name is valid, according to operating system standards; otherwise, false.</returns>
    public static bool IsOsFileNameValid(string filename) => IsOsFilePathValid(filename) &&
                                                             NormalizeFilePath(filename)
                                                                 .Split(Path.DirectorySeparatorChar).Length == 1;

    /// <summary>
    /// Sanitizes a file path by replacing invalid characters, trimming whitespace, and
    /// eliminating empty segments. Ensures the resulting path conforms to operating system standards.
    /// </summary>
    /// <param name="filepath">The file path to sanitize.</param>
    /// <param name="replacement">The string to replace invalid characters with. Defaults to an empty string.</param>
    /// <returns>Returns a sanitized file path, with invalid characters replaced and empty segments removed.</returns>
    /// <remarks>Despite path traversal being technically a valid filepath as the last element, this method sanitizes it  away as it is not a valid filename</remarks>
    public static string SanitizeOsFilePath(string filepath, string replacement = "")
    {
        var normalizedFilepath = NormalizeFilePath(filepath);

        List<string> parts = normalizedFilepath.Split(Path.DirectorySeparatorChar)
            .Select(part => string.Concat(part.Trim()
                .SelectMany(c => InvalidOsCharacters.Contains(c) ? replacement : c.ToString())))
            .Select(part => InvalidPathTraversal.IsMatch(part) ? part.Replace(".", replacement) : part)
            .Where(partSanitized => !string.IsNullOrEmpty(partSanitized))
            .ToList();

        if (parts.Count != 0)
        {
            parts[parts.Count] = IsOnlyDotsAndSpaces.IsMatch(parts.Last()) ? parts.Last().Replace(".", replacement) : parts.Last();
            if (string.IsNullOrEmpty(parts.Last()))
            {
                parts.RemoveAt(parts.Count);
            }
        }

        return string.Join(Path.DirectorySeparatorChar.ToString(), parts);
    }

    /// <summary>
    /// Sanitizes a file name by removing or replacing characters that are invalid for operating system file names.
    /// If the input contains path separators, only the last segment is retained and all preceding segments are discarded.
    /// </summary>
    /// <param name="filename">The file name to sanitize.</param>
    /// <param name="replacement">The string to replace invalid characters in the file name. Defaults to an empty string.</param>
    /// <returns>Returns the sanitized file name with invalid characters removed or replaced.</returns>
    public static string SanitizeOsFileName(string filename, string replacement = "")
        => SanitizeOsFilePath(filename, replacement).Split(Path.DirectorySeparatorChar).Last();

    #endregion

    #region Archive

    /// <summary>
    /// A set of characters that are considered valid for file paths and names within an archive context.
    /// Consisting of lowercase letters, numbers, underscores, dashes, dots, forward slashes, and backslashes.
    /// </summary>
    public static readonly HashSet<char>　ValidArchiveCharacters = new("abcdefghijklmnopqrstuvwxyz0123456789_./\\-");

    /// <summary>
    /// Validates whether the given file path is suitable for use within an archive by ensuring it adheres to both
    /// operating system standards and archive-specific character constraints.
    /// Path traversal is explicitly disallowed.
    /// </summary>
    /// <param name="filepath">The file path to validate against archive-specific criteria.</param>
    /// <returns>Returns true if the file path is valid for use in an archive; otherwise, false.</returns>
    public static bool IsArchiveFilePathValid(string filepath) => IsOsFilePathValid(filepath) &&
                                                                  filepath.All(c => ValidArchiveCharacters.Contains(c)) &&
                                                                  NormalizeFilePath(filepath)
                                                                      .Split(Path.DirectorySeparatorChar)
                                                                      .All(p => !IsOnlyDotsAndSpaces.IsMatch(p));

    /// <summary>
    /// Validates whether the given file name conforms to archive standards by ensuring that
    /// it does not contain invalid characters, does not represent a path traversal, and only
    /// includes characters permitted for archived file names.
    /// </summary>
    /// <param name="filename">The file name to validate.</param>
    /// <returns>Returns true if the file name is valid for use in archives; otherwise, false.</returns>
    public static bool IsArchiveFileNameValid(string filename) => IsOsFileNameValid(filename) &&
                                                                  filename.All(c => ValidArchiveCharacters.Contains(c));

    /// <summary>
    /// Sanitizes the given file path for use in the archive by normalizing the path, replacing invalid characters,
    /// and ensuring compatibility with predefined archive file path standards.
    /// </summary>
    /// <param name="filepath">The file path to sanitize.</param>
    /// <param name="replacement">The string to replace invalid characters in the file path. Defaults to an empty string.</param>
    /// <returns>Returns the sanitized file path as a string, which complies with archive file path standards.</returns>
    public static string SanitizeArchiveFilePath(string filepath, string replacement = "")
    {
        var osSanitizedFilepath = SanitizeOsFilePath(filepath, replacement);

        List<string> parts = osSanitizedFilepath.Split(Path.DirectorySeparatorChar)
            .Select(part => string.Concat(part.ToLowerInvariant()
                .Select(c => c == ' ' ? '_' : c)
                .SelectMany(c => ValidArchiveCharacters.Contains(c) ? c.ToString() : replacement)))
            .Where(partSanitized => !string.IsNullOrEmpty(partSanitized))
            .Where(partSanitized => !IsOnlyDotsAndSpaces.IsMatch(partSanitized))
            .ToList();

        return string.Join(Path.DirectorySeparatorChar.ToString(), parts);
    }

    /// <summary>
    /// Sanitizes the given file name for use in the archive by replacing invalid characters
    /// and ensuring compatibility with predefined archive file path standards.
    /// If the input contains path separators, only the last segment is retained and all preceding segments are discarded.
    /// </summary>
    /// <param name="filename">The file name to sanitize.</param>
    /// <param name="replacement">The string replacement for any invalid characters found in the file name.
    /// Defaults to an empty string if not specified.</param>
    /// <returns>Returns the sanitized file name as a string, ensuring it is compliant with archive-specific rules.</returns>
    public static string SanitizeArchiveFileName(string filename, string replacement = "")
        => SanitizeArchiveFilePath(filename, replacement).Split(Path.DirectorySeparatorChar).Last();

    #endregion

    #region Generic

    /// <summary>
    /// A regular expression pattern that matches strings consisting only of dots and spaces.
    /// </summary>
    private static readonly Regex IsOnlyDotsAndSpaces = new Regex(@"^[. ]+$");

    private static string NormalizeFilePath(string filepath)
    {
        return filepath.Replace("/", Path.DirectorySeparatorChar.ToString())
            .Replace(@"\", Path.DirectorySeparatorChar.ToString());
    }

    #endregion
}
