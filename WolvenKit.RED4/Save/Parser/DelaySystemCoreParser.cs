using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save;

public class DelaySystemCore : INodeData
{
    public uint Unk1 { get; set; }
}

public class DelaySystemCoreParser : INodeParser
{
    public void Read(BinaryReader reader, NodeEntry node)
    {
        node.Value = new DelaySystemCore
        {
            Unk1 = reader.ReadUInt32()
        };
    }

    public void Write(NodeWriter writer, NodeEntry node)
    {
        var value = (DelaySystemCore)node.Value;

        writer.Write(value.Unk1);
    }
}
