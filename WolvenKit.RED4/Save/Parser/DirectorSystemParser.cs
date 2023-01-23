using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save;

public class DirectorSystem : INodeData
{
    // counter?
    public uint Unknown1 { get; set; }
    public string Unknown2 { get; set; }
    // null terminator?
    public byte Unknown3 { get; set; }
    public string Unknown4 { get; set; }
    public uint Unknown5 { get; set; }
}


public class DirectorSystemParser : INodeParser
{
    public static string NodeName => Constants.NodeNames.DIRECTOR_SYSTEM;

    public void Read(BinaryReader reader, NodeEntry node)
    {
        var data = new DirectorSystem();
        data.Unknown1 = reader.ReadUInt32();
        data.Unknown2 = reader.ReadLengthPrefixedString();
        data.Unknown3 = reader.ReadByte();
        data.Unknown4 = reader.ReadLengthPrefixedString();
        data.Unknown5 = reader.ReadUInt32();

        node.Value = data;
    }

    public void Write(NodeWriter writer, NodeEntry node)
    {
        var data = (DirectorSystem)node.Value;

        writer.Write(data.Unknown1);
        writer.WriteLengthPrefixedString(data.Unknown2);
        writer.Write(data.Unknown3);
        writer.WriteLengthPrefixedString(data.Unknown4);
        writer.Write(data.Unknown5);
    }
}