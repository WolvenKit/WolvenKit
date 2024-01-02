using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save;

public class UniqueItemCounter : INodeData
{
    public ushort Count { get; set; }
    public uint? CyberwareUpgradeSeed { get; set; }
}


public class UniqueItemCounterParser : INodeParser
{
    public static string NodeName => Constants.NodeNames.UNIQUE_ITEM_COUNTER;

    public void Read(BinaryReader reader, NodeEntry node)
    {
        var data = new UniqueItemCounter();
        
        data.Count = reader.ReadUInt16();
        if (node.TrailingSize == 4)
        {
            data.CyberwareUpgradeSeed = reader.ReadUInt32();
        }

        node.Value = data;
    }

    public void Write(NodeWriter writer, NodeEntry node)
    {
        var data = (UniqueItemCounter)node.Value;

        writer.Write(data.Count);
        if (data.CyberwareUpgradeSeed.HasValue)
        {
            writer.Write(data.CyberwareUpgradeSeed.Value);
        }
    }
}