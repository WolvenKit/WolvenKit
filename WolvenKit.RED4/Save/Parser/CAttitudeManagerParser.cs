using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save;

public class CAttitudeManager : INodeData
{
    public List<CAttitudeManagerEntry> Entries { get; set; }
    public byte[] Unknown2 { get; set; }

    public CAttitudeManager()
    {
        Entries = new List<CAttitudeManagerEntry>();
    }
}

public class CAttitudeManagerEntry
{
    public ulong Unk_Hash1 { get; set; }
    public uint Unknown2 { get; set; }
}

public class CAttitudeManagerParser : INodeParser
{
    public static string NodeName => Constants.NodeNames.C_ATTITUDE_MANAGER;

    public void Read(BinaryReader reader, NodeEntry node)
    {
        var entryCount = reader.ReadUInt32();
        var data = new CAttitudeManager();
        for (var i = 0; i < entryCount; i++)
        {
            var entry = new CAttitudeManagerEntry();
            entry.Unk_Hash1 = reader.ReadUInt64();
            entry.Unknown2 = reader.ReadUInt32();

            data.Entries.Add(entry);
        }
        data.Unknown2 = reader.ReadBytes(18);

        node.Value = data;
    }

    public void Write(NodeWriter writer, NodeEntry node)
    {
        var data = (CAttitudeManager)node.Value;

        writer.Write(data.Entries.Count);
        foreach (var entry in data.Entries)
        {
            writer.Write(entry.Unk_Hash1);
            writer.Write(entry.Unknown2);
        }
        writer.Write(data.Unknown2);
    }
}