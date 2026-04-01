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
    /// Validates whether the given file path conforms to operating system standards.
    /// </summary>
    /// <param name="filepath">The file path to validate.</param>
    /// <returns>Returns true if the file path is valid, according to operating system standards; otherwise, false.</returns>
    /// <remarks>Considers a filepath where the last segment consists of a path traversal as invalid even if it is valid from the operating systems' perspective.</remarks>
    public static bool IsOsFilePathValid(string filepath)
    {
        var normalizedFilepathParts = NormalizeFilePath(filepath).Split(Path.DirectorySeparatorChar);
        return normalizedFilepathParts.All(part => !string.IsNullOrEmpty(part) &&
                                                   part.All(c => !InvalidOsCharacters.Contains(c)) &&
                                                   !InvalidPathTraversal.IsMatch(part) &&
                                                   part == part.Trim() &&
                                                   (part == part.TrimEnd('.') || part == "..")) &&
               !IsOnlyDotsAndSpaces.IsMatch(normalizedFilepathParts.Last());
    }

    /// <summary>
    /// Validates whether the given file name conforms to operating system standards and does not contain directories.
    /// </summary>
    /// <param name="filename">The file name to validate.</param>
    /// <returns>Returns true if the file name is valid, according to operating system standards; otherwise, false.</returns>
    public static bool IsOsFileNameValid(string filename) => IsOsFilePathValid(filename) &&
                                                             NormalizeFilePath(filename)
                                                                 .Split(Path.DirectorySeparatorChar).Length == 1;

    /// <summary>
    /// Sanitizes a file path ensuring the resulting path conforms to operating system standards.
    /// </summary>
    /// <param name="filepath">The file path to sanitize.</param>
    /// <param name="replacement">The string to replace invalid characters with. Defaults to an empty string.</param>
    /// <returns>Returns a sanitized file path, with invalid characters replaced and empty segments removed.</returns>
    /// <remarks>Despite path traversal being accepted by Windows as the last element of a filepath, this method sanitizes it away as it is not a valid filename.</remarks>
    public static string SanitizeOsFilePath(string filepath, string replacement = "")
    {
        var normalizedFilepath = NormalizeFilePath(filepath);

        var parts = normalizedFilepath.Split(Path.DirectorySeparatorChar)
            .Select(part => string.Concat(part.Trim()
                .SelectMany(c => InvalidOsCharacters.Contains(c) ? replacement : c.ToString())))
            .Select(part => InvalidPathTraversal.IsMatch(part) ? part.Replace(".", replacement) : part)
            .Select(part => part == ".." ? part : part.TrimEnd('.'))
            .Where(partSanitized => !string.IsNullOrEmpty(partSanitized))
            .ToList();

        if (parts.Count == 0)
        {
            return string.Join(Path.DirectorySeparatorChar.ToString(), parts);
        }

        if (IsOnlyDotsAndSpaces.IsMatch(parts.Last()))
        {
            parts[^1] = parts.Last().Replace(".", replacement);
        }

        if (string.IsNullOrEmpty(parts.Last()))
        {
            parts.RemoveAt(parts.Count - 1);
        }

        return string.Join(Path.DirectorySeparatorChar.ToString(), parts);
    }

    /// <summary>
    /// Sanitizes a file name ensuring the resulting name conforms to operating system standards.
    /// If the input contains path separators, only the last segment is retained and all preceding segments are discarded.
    /// </summary>
    /// <param name="filename">The file name to sanitize.</param>
    /// <param name="replacement">The string to replace invalid characters in the file name. Defaults to an empty string.</param>
    /// <returns>Returns the sanitized file name with invalid characters replaced.</returns>
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
    /// Validates whether the given file path conforms to operating system and archive standards.
    /// </summary>
    /// <param name="filepath">The file path to validate.</param>
    /// <returns>Returns true if the file path is valid, according to operating system and archive standards; otherwise, false.</returns>
    /// <remarks>Path traversal is explicitly disallowed.</remarks>
    public static bool IsArchiveFilePathValid(string filepath) => IsOsFilePathValid(filepath) &&
                                                                  filepath.All(c => ValidArchiveCharacters.Contains(c)) &&
                                                                  NormalizeFilePath(filepath)
                                                                      .Split(Path.DirectorySeparatorChar)
                                                                      .All(p => !IsOnlyDotsAndSpaces.IsMatch(p));

    /// <summary>
    /// Validates whether the given file name conforms to operating system and archive standards and does not contain directories.
    /// </summary>
    /// <param name="filename">The file name to validate.</param>
    /// <returns>Returns true if the file name is valid, according to operating system and archive standards; otherwise, false.</returns>
    /// <remarks>Path traversal is explicitly disallowed.</remarks>
    public static bool IsArchiveFileNameValid(string filename) => IsOsFileNameValid(filename) &&
                                                                  filename.All(c => ValidArchiveCharacters.Contains(c));

    /// <summary>
    /// Sanitizes a file path ensuring the resulting path conforms to operating system and archive standards.
    /// </summary>
    /// <param name="filepath">The file path to sanitize.</param>
    /// <param name="replacement">The string to replace invalid characters with. Defaults to an empty string.</param>
    /// <returns>Returns a sanitized file path, with invalid characters replaced and empty segments removed.</returns>
    /// <remarks>Path traversal is explicitly disallowed.</remarks>
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
    /// Sanitizes a file name ensuring the resulting name conforms to operating system and archive standards.
    /// If the input contains path separators, only the last segment is retained and all preceding segments are discarded.
    /// </summary>
    /// <param name="filename">The file name to sanitize.</param>
    /// <param name="replacement">The string to replace invalid characters in the file name. Defaults to an empty string.</param>
    /// <returns>Returns the sanitized file name with invalid characters replaced.</returns>
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
