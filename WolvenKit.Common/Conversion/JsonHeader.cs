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
    public SemVersion WolvenKitVersion { get; } = CommonFunctions.GetAssemblyVersion(Assembly.GetEntryAssembly());
    public SemVersion WKitJsonVersion { get; } = SemVersion.Parse("0.0.1", SemVersionStyles.Strict);
    public int GameVersion { get; } = (int)Enums.gameGameVersion.Current;
    public string ExportedDateTime { get; } = DateTime.UtcNow.ToString("o");
    public string DataType { get; set; } = DataTypes.Custom;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string ArchiveFileName { get; set; }
}
