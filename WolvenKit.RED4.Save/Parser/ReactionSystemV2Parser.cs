using WolvenKit.RED4.Save.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save;

public class ReactionSystemV2 : INodeData
{
    public byte[] Data { get; set; }
}

public class ReactionSystemV2Parser : INodeParser
{
    public static string NodeName => Constants.NodeNames.REACTION_SYSTEM_V2;

    public void Read(BinaryReader reader, NodeEntry node)
    {
        var data = new ReactionSystemV2();

        data.Data = reader.ReadBytes(node.DataSize - 4);

        node.Value = data;
    }

    public void Write(NodeWriter writer, NodeEntry node)
    {
        var value = (ReactionSystemV2)node.Value;

        writer.Write(value.Data);
    }
}
