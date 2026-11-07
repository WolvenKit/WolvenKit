using System;

namespace WolvenKit.Common;

/// <summary>
/// Resolves raw file extensions and their aliases to a canonical import format.
/// </summary>
public static class RawFileFormatParser
{
    public static bool TryParse(string? extension, out ERawFileFormat format)
    {
        var normalized = extension?.TrimStart('.').ToLowerInvariant();
        normalized = normalized switch
        {
            "jpeg" or "jpe" => "jpg",
            "tif" => "tiff",
            _ => normalized
        };

        // Enum.TryParse also accepts numbers and comma-separated values, neither
        // of which is a file extension.
        return Enum.TryParse(normalized, out format)
            && Enum.IsDefined(format)
            && string.Equals(format.ToString(), normalized, StringComparison.Ordinal);
    }
}
