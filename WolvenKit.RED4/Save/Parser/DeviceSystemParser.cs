using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save;

public class DeviceSystemParser : INodeParser
{
    public static string NodeName => Constants.NodeNames.DEVICE_SYSTEM;

    public void Read(BinaryReader reader, NodeEntry node)
    {
        ParserHelper.ReadChildren(reader, node);
    }

    public void Write(NodeWriter writer, NodeEntry node)
    {
        foreach (var child in node.Children)
        {
            writer.Write(child);
        }
    }
}