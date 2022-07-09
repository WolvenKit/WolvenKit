using WolvenKit.RED4.Save.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save;

public class DefaultRepresentation : INodeData
{
    public byte[] HeaderBlob { get; set; }
    public byte[] TrailingBlob { get; set; }
    public NodeEntry Node { get; set; }
}

public class DefaultParser : INodeParser
{
    public void Read(BinaryReader reader, NodeEntry node)
    {
        var result = new DefaultRepresentation();
        result.HeaderBlob = reader.ReadBytes(node.DataSize - 4);

        ParserHelper.ReadChildren(reader, node);

        result.TrailingBlob = reader.ReadBytes(node.TrailingSize);

        result.Node = node;

        node.Value = result;
    }

    public void Write(NodeWriter writer, NodeEntry node)
    {
        var value = (DefaultRepresentation)node.Value;
        writer.Write(value.HeaderBlob);
        foreach(var child in node.Children)
        {
            writer.Write(child);
        }
        writer.Write(value.TrailingBlob);   
    }
}
