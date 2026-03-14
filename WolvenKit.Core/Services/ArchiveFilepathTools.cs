using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WolvenKit.Core.Services;

/// <summary>
/// Provides helper methods for validating and sanitizing archive file paths, as such paths provided should be relative from the archives root.
/// </summary>
public static class ArchiveFilepathTools
{
    /// <summary>
    /// A set of valid characters that can be used in archive file paths.
    /// This includes lowercase letters, numbers, underscores, dots, forward slashes,
    /// and backslashes.
    /// </summary>
    public static readonly HashSet<char>　ValidCharacters = new("abcdefghijklmnopqrstuvwxyz0123456789_./\\");

    /// <summary>
    /// Validates whether the given file path is valid, according to specific criteria.
    /// A valid file path cannot contain invalid characters and must not have empty directory paths.
    /// </summary>
    /// <param name="filepath">The file path to be validated.</param>
    /// <returns>True if the file path is valid; otherwise, false.</returns>
    public static bool IsFilePathValid(string filepath)
    {
        var normalizedFilepath = NormalizeFilePath(filepath);
        return normalizedFilepath.Split(Path.DirectorySeparatorChar).All(part => !string.IsNullOrEmpty(part) && part.All(c => ValidCharacters.Contains(c)));
    }

    /// <summary>
    /// Sanitizes the provided file path by ensuring all parts of the path contain only valid characters.
    /// Invalid characters are replaced with the specified replacement string. Empty path segments are removed.
    /// </summary>
    /// <param name="filepath">The file path to be sanitized.</param>
    /// <param name="replacement">The string used to replace invalid characters in the file path.</param>
    /// <returns>A sanitized file path with invalid characters replaced and empty segments removed.</returns>
    public static string SanitizeFilePath(string filepath, string replacement = "")
    {
        var normalizedFilepath = NormalizeFilePath(filepath);

        List<string> parts = normalizedFilepath.Split(Path.DirectorySeparatorChar)
            .Select(part => string.Concat(part.ToLowerInvariant()
                .Trim()
                .Select(c => c == ' ' ? '_' : c)
                .SelectMany(c => ValidCharacters.Contains(c) ? c.ToString() : replacement)))
            .Where(partSanitized => !string.IsNullOrEmpty(partSanitized))
            .ToList();

        return string.Join(Path.DirectorySeparatorChar.ToString(), parts);
    }

    private static string NormalizeFilePath(string filepath)
    {
        return filepath.Replace("/", Path.DirectorySeparatorChar.ToString())
            .Replace(@"\", Path.DirectorySeparatorChar.ToString());
    }

}
