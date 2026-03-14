using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WolvenKit.Core.Services;

/// <summary>
/// Provides helper methods for validating and sanitizing OS file paths. Does not enforce archive file path rules. For Validating archive file paths, use <ref cref="ArchiveFilepathTools"/>.
/// </summary>
public class OsFilepathTools
{
    /// <summary>
    /// A set of characters that are considered invalid in operating system file paths.
    /// This collection is initialized with the invalid path characters as defined
    /// by the .NET framework's <see cref="Path.GetInvalidPathChars"/>.
    /// </summary>
    public static readonly HashSet<char> InvalidCharacters = new(Path.GetInvalidPathChars());

    /// <summary>
    /// Determines whether the specified file path is valid by ensuring that it does not contain invalid characters
    /// and does not have empty directory paths.
    /// </summary>
    /// <param name="filepath">The file path to validate.</param>
    /// <returns>True if the file path is valid; otherwise, false.</returns>
    public static bool IsFilePathValid(string filepath)
    {
        var normalizedFilepath = NormalizeFilePath(filepath);
        return normalizedFilepath.Split(Path.DirectorySeparatorChar).All(part => !string.IsNullOrEmpty(part) && part.All(c => !InvalidCharacters.Contains(c)));
    }

    /// <summary>
    /// Determines whether the specified file path is valid by ensuring that it does not contain invalid characters
    /// and does not contain subdirectories.
    /// </summary>
    /// <param name="filename">The file name to be validated.</param>
    /// <returns>True if the file name is valid; otherwise, false.</returns>
    public static bool IsFileNameValid(string filename)
    {
        var normalizedFilepath = NormalizeFilePath(filename);
        var parts = normalizedFilepath.Split(Path.DirectorySeparatorChar);
        return parts.Length == 1 && !string.IsNullOrEmpty(parts[0]) && parts[0].All(c => !InvalidCharacters.Contains(c));
    }

    /// <summary>
    /// Sanitizes the provided file path by the Operating System's rules for file paths.
    /// Invalid characters are replaced with the specified replacement string. Empty path segments are removed.
    /// </summary>
    /// <param name="filepath">The file path to be sanitized.</param>
    /// <param name="replacement">The string used to replace invalid characters in the file path. Defaults to an empty string if not specified.</param>
    /// <returns>
    /// A sanitized file path with invalid characters replaced and empty segments removed,
    /// or an empty string if no valid content could be extracted from the input.
    /// Callers should validate the return value if an empty result is not acceptable in their context.
    /// </returns>
    public static string SanitizeFilePath(string filepath, string replacement = "")
    {
        var normalizedFilepath = NormalizeFilePath(filepath);

        List<string> parts = normalizedFilepath.Split(Path.DirectorySeparatorChar)
            .Select(part => string.Concat(part.ToLowerInvariant()
                .Trim()
                .SelectMany(c => InvalidCharacters.Contains(c) ? replacement : c.ToString())))
            .Where(partSanitized => !string.IsNullOrEmpty(partSanitized))
            .ToList();

        return string.Join(Path.DirectorySeparatorChar.ToString(), parts);
    }

    /// <summary>
    /// Sanitizes the provided file name by ensuring all parts of the name contain only valid characters.
    /// Invalid characters are replaced with the specified replacement string.
    /// If the input contains path separators, only the last segment is retained and all preceding segments are discarded.
    /// </summary>
    /// <param name="filename">The file name to be sanitized.</param>
    /// <param name="replacement">The string used to replace invalid characters in the file name. Defaults to an empty string if not specified.</param>
    /// <returns>
    /// A sanitized file name with invalid characters replaced and empty segments removed,
    /// or an empty string if no valid content could be extracted from the input.
    /// Callers should validate the return value if an empty result is not acceptable in their context.
    /// </returns>
    public static string SanitizeFileName(string filename, string replacement = "")
        => SanitizeFilePath(filename, replacement).Split(Path.DirectorySeparatorChar).Last();

    private static string NormalizeFilePath(string filepath)
    {
        return filepath.Replace("/", Path.DirectorySeparatorChar.ToString())
            .Replace(@"\", Path.DirectorySeparatorChar.ToString());
    }
}
