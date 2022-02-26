using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save;

public class SaveNode
{
    public string Name { get; set; }

    public byte[] DataBytes { get; set; }
    public IParseableBuffer Data { get; set; }

    public List<SaveNode> Children { get; set; } = new();

    public byte[] TrailingDataBytes { get; set; }
    public IParseableBuffer TrailingData { get; set; }
}
