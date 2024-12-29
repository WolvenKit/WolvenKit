using WolvenKit.Common.FNV1A;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Helpers;
internal static class HashHelper
{
    /// <summary>
    /// Calculates the FNV1A64 hash of a file path string. Used for "addToMod" and lookups.
    /// </summary>
    /// <param name="filePath"></param>
    /// <returns></returns>
    public static ulong CalculateDepotPathHash(string? filePath) => filePath is null ? 0 : FNV1A64HashAlgorithm.HashString(filePath);

    /// <summary>
    /// Calculates the FNV1A64 hash of a resource path. Used for "addToMod" and lookups.
    /// </summary>
    /// <param name="resourcePath"></param>
    /// <returns></returns>
    public static ulong CalculateDepotPathHash(ResourcePath resourcePath) => CalculateDepotPathHash(resourcePath.GetResolvedText());


    /// <summary>
    /// Returns the TweakDB hash in the format of 0x00000000, 00
    /// </summary>
    /// <param name="tweakDbEntryName"></param>
    /// <returns></returns>
    public static string GetTweakDbId(string tweakDbEntryName)

    {
        var hexValue = TweakDBID.CalculateHash(tweakDbEntryName).ToString("X16");
        return $"0x{hexValue[^8..]}, {int.Parse(hexValue[^10..8], System.Globalization.NumberStyles.HexNumber)}";
    }
    


}
