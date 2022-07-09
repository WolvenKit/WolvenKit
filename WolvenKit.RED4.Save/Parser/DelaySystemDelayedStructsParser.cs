using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save;

public class DelaySystemDelayedStructs : INodeData
{
    public byte[] Raw { get; set; }
}

public class DelaySystemDelayedStructsParser : INodeParser
{
    public void Read(BinaryReader reader, NodeEntry node)
    {
        node.Value = new DelaySystemDelayedStructs
        {
            Raw = reader.ReadBytes(node.DataSize - 4)
        };
    }

    public void Write(NodeWriter writer, NodeEntry node)
    {
        var value = (DelaySystemDelayedStructs)node.Value;

        writer.Write(value.Raw);
    }
}
