using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save;

public class ReactionSystem : INodeData
{
    public byte[] Data { get; set; }
}

public class ReactionSystemParser : INodeParser
{
    public static string NodeName => Constants.NodeNames.REACTION_SYSTEM;

    public void Read(BinaryReader reader, NodeEntry node)
    {
        var data = new ReactionSystem();

        data.Data = reader.ReadBytes(node.DataSize - 4);

        node.Value = data;
    }

    public void Write(NodeWriter writer, NodeEntry node)
    {
        var value = (ReactionSystem)node.Value;

        writer.Write(value.Data);
    }
}
