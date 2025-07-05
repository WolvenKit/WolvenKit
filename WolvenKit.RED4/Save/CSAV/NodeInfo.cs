using System.Diagnostics;

namespace WolvenKit.RED4.Save;

[DebuggerDisplay("{Name}")]
public class NodeInfo
{
    public string Name { get; set; }
    public int NextId { get; set; }
    public int ChildId { get; set; }
    public int Offset { get; set; }
    public int Size { get; set; }
}
