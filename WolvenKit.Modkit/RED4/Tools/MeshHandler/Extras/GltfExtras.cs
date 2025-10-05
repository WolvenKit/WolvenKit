using System.Text.Json.Serialization;

namespace WolvenKit.Modkit.RED4.Tools.MeshHandler.Extras;

public class GltfExtras
{
    [JsonPropertyName("exporterVersion")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int ExporterVersion { get; set; } = 0;

    [JsonPropertyName("experimentalMergedMeshes")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool ExperimentalMergedMeshes { get; set; } = false;
}

public class BoneExtras
{
    [JsonPropertyName("epsilon")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public float Epsilon { get; set; }

    [JsonPropertyName("lod")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public byte Lod { get; set; }
}
