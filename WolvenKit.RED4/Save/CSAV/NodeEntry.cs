namespace WolvenKit.RED4.Save;

public class NodeEntry
{
    public int Id { get; set; }
    public int NextId { get; set; }
    public int ChildId { get; set; }
    public string Name { get; set; }
    public int Offset { get; set; }
    public int Size { get; set; }
    public INodeData Value { get; set; }
    public bool IsChild { get; set; }
    public bool IsFirstChild { get; set; }
    public int DataSize { get; set; }
    public int TrailingSize { get; set; }
    public bool WritesOwnTrailingSize { get; set; }
    public int SizeChange { get; set; }
    public List<NodeEntry> Children { get; set; }
    private NodeEntry _nextNode;

    public NodeEntry? Parent { get; set; }
    public NodeEntry? PreviousNode { get; set; }
    public NodeEntry? NextNode { get; set; }
    public bool ReadByParent { get; set; } = false;

    public NodeEntry()
    {
        WritesOwnTrailingSize = true;
        Children = new List<NodeEntry>();
    }

    public void AddChild(NodeEntry child)
    {
        child.IsChild = true;
        if (Children.Count == 0)
        {
            child.IsFirstChild = true;
        }
        Children.Add(child);
        child.Parent = this;
    }

    public override string ToString()
    {
        var s = $"[{Id}] {Name}";

        // TODO: Make this generic or something
        if (Value is InventoryHelper.ItemData)
        {
            s = $"[{Id}] {Value}";
        }

        return s;
    }
}
