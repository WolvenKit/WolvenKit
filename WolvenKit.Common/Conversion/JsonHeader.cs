using System;
using System.Text.Json.Serialization;
using Semver;

namespace WolvenKit.Common.Conversion;

public sealed class DataTypes
{
    public const string Custom = "Custom";
    public const string CR2W = "CR2W";
    public const string CR2WFlat = "CR2WFlat";
}

public class JsonHeader
{
    public SemVersion WolvenKitVersion { get; set; } = "8.5.0";
    public SemVersion WKitJsonVersion { get; set; } = "0.0.1";
    public string ExportedDateTime { get; set; } = DateTime.UtcNow.ToString("o");
    public string DataType { get; set; } = DataTypes.Custom;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string ArchiveFileName { get; set; }
}
