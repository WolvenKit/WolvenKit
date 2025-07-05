namespace WolvenKit.RED4.Save;

public class CyberpunkSaveFile
{
    public const uint MAGIC = 0x43534156; // "CSAV"
    public const uint NODE = 0x4e4f4445; // "NODE"
    public const uint DONE = 0x444F4E45; // "DONE"

    public CyberpunkSaveHeaderStruct FileHeader { get; set; }
    public Compression.Settings CompressionSettings { get; set; }
    public List<NodeEntry> Nodes { get; set; } = new();
}
