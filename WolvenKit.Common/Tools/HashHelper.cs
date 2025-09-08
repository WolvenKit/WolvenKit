using WolvenKit.Common.FNV1A;
using WolvenKit.Interfaces.Extensions;

namespace WolvenKit.Common.Tools;

public static class HashHelper
{
    /// <summary>
    /// Calculates the FNV1A64 hash of a file path string. Used for "addToMod" and lookups.
    /// </summary>
    /// <param name="filePath"></param>
    /// <returns></returns>
    public static ulong CalculateDepotPathHash(string? filePath) =>
        filePath is null ? 0 : FNV1A64HashAlgorithm.HashString(filePath.SanitizeFilePath());
}
