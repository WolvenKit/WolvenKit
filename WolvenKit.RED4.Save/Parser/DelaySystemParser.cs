using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save;

public class DelaySystemParser : INodeParser
{
    public static string NodeName => Constants.NodeNames.DELAY_SYSTEM;

    public void Read(BinaryReader reader, NodeEntry node)
    {
        node.Children[0].ReadByParent = true;
        reader.ReadInt32();
        new DelaySystemCoreParser().Read(reader, node.Children[0]);

        node.Children[1].ReadByParent = true;
        reader.ReadInt32();
        new DelaySystemDelayedStructsParser().Read(reader, node.Children[1]);
    }

    public void Write(NodeWriter writer, NodeEntry node)
    {
        writer.Write(node.Children[0], new DelaySystemCoreParser());
        writer.Write(node.Children[1], new DelaySystemDelayedStructsParser());
    }
}
