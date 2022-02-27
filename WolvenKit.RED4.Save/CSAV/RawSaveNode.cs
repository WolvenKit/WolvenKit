namespace WolvenKit.RED4.Save;

public class RawSaveNode
{
    public string Name { get; set; }
    public int NextId { get; set; } = -1;
    public int ChildId { get; set; } = -1;
    public int Offset { get; set; }
    public int Size { get; set; }

    public int Id { get; set; }
    public RawSaveNode? NextNode { get; set; }
    public RawSaveNode? Parent { get; set; }
    public List<RawSaveNode> Children { get; set; } = new();
    
    public int DataSize { get; set; }
    public byte[] Data { get; set; }

    public int TrailingSize { get; set; }
    public byte[] TrailingData { get; set; }
}
