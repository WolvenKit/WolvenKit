using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save;

public class DirectorSystem : INodeData
{
    public List<DirectorSystemClass1> Unknown1 { get; set; } = new();
}

public class DirectorSystemClass1
{
    public string Unknown1 { get; set; }
    public byte Unknown2 { get; set; }
    public string Unknown3 { get; set; }
    public uint Unknown4 { get; set; }
}


public class DirectorSystemParser : INodeParser
{
    public static string NodeName => Constants.NodeNames.DIRECTOR_SYSTEM;

    public void Read(BinaryReader reader, NodeEntry node)
    {
        var data = new DirectorSystem();

        var cnt = reader.ReadUInt32();
        for (var i = 0; i < cnt; i++)
        {
            data.Unknown1.Add(new DirectorSystemClass1
            {
                Unknown1 = reader.ReadLengthPrefixedString(),
                Unknown2 = reader.ReadByte(),
                Unknown3 = reader.ReadLengthPrefixedString(),
                Unknown4 = reader.ReadUInt32()
            });
        }

        node.Value = data;
    }

    public void Write(NodeWriter writer, NodeEntry node)
    {
        var data = (DirectorSystem)node.Value;

        writer.Write(data.Unknown1.Count);
        foreach (var val in data.Unknown1)
        {
            writer.WriteLengthPrefixedString(val.Unknown1);
            writer.Write(val.Unknown2);
            writer.WriteLengthPrefixedString(val.Unknown3);
            writer.Write(val.Unknown4);
        }
    }
}