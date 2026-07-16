using System;
using System.Reflection;
using System.Text.Json.Serialization;
using Semver;
using WolvenKit.Core;
using WolvenKit.RED4.Types;

namespace WolvenKit.Common.Conversion;

public sealed class DataTypes
{
    public const string Custom = "Custom";
    public const string CR2W = "CR2W";
    public const string CR2WFlat = "CR2WFlat";
}

public class JsonHeader
{
    public SemVersion WolvenKitVersion { get; set; } = CommonFunctions.GetAssemblyVersion(ResolveVersionAssembly());
    public SemVersion WKitJsonVersion { get; set; } = SemVersion.Parse(Constants.RedJsonVersion, SemVersionStyles.Strict);
    public int GameVersion { get; set; } = (int)Enums.gameGameVersion.Current;
    public string ExportedDateTime { get; set; } = DateTime.UtcNow.ToString("o");
    public string DataType { get; set; } = DataTypes.Custom;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string? ArchiveFileName { get; set; }

    /// <summary>
    /// Prefer a WolvenKit assembly for the version stamp. Under test hosts (Rider/VS),
    /// <see cref="Assembly.GetEntryAssembly"/> is the runner and its InformationalVersion is
    /// often a non-SemVer four-part string with +commit metadata.
    /// </summary>
    private static Assembly ResolveVersionAssembly()
    {
        var entry = Assembly.GetEntryAssembly();
        if (entry?.GetName().Name is { } entryName
            && entryName.StartsWith("WolvenKit", StringComparison.OrdinalIgnoreCase))
        {
            return entry;
        }

        foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
        {
            var name = asm.GetName().Name;
            if (name is "WolvenKit" or "WolvenKit.App" or "WolvenKit.CLI")
            {
                return asm;
            }
        }

        return typeof(JsonHeader).Assembly;
    }
}
