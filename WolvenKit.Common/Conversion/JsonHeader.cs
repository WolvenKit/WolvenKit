using System;
using System.Text.Json.Serialization;

namespace WolvenKit.Common.Conversion;

public class JsonHeader
{
    public string WolvenKitVersion { get; set; } = "8.5.0";
    public string WKitJsonVersion { get; set; } = "0.0.1";
    public string ExportedDateTime { get; set; } = DateTime.UtcNow.ToString("o");

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string ArchiveFileName { get; set; }
}
