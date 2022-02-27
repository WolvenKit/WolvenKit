using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save;

public class SaveNode
{
    public string Name { get; set; }

    public byte[] DataBytes { get; set; } = Array.Empty<byte>();
    public IParseableBuffer Data { get; set; }

    public List<SaveNode> Children { get; set; } = new();

    public byte[] TrailingDataBytes { get; set; } = Array.Empty<byte>();
    public IParseableBuffer TrailingData { get; set; }

    public override string ToString() => Name;
}
