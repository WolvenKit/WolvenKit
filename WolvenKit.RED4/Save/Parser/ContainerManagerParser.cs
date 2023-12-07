using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save;

public class ContainerManager : INodeData
{
    public List<Entry> Entries { get; set; }

    public ContainerManager()
    {
        Entries = new List<Entry>();
    }

    public class Entry
    {
        public ulong CNameHash { get; set; }
        public ushort Unknown1 { get; set; }
        public byte Unknown2 { get; set; }
    }
}


public class ContainerManagerParser : INodeParser
{
    public static string NodeName => Constants.NodeNames.CONTAINER_MANAGER;

    public void Read(BinaryReader reader, NodeEntry node)
    {
        var data = new ContainerManager();
        var entryCount = reader.ReadUInt32();
        for (int i = 0; i < entryCount; i++)
        {
            var entry = new ContainerManager.Entry();

            entry.CNameHash = reader.ReadUInt64();
            entry.Unknown1 = reader.ReadUInt16();
            entry.Unknown2 = reader.ReadByte();
            data.Entries.Add(entry);
        }

        node.Value = data;
    }

    public void Write(NodeWriter writer, NodeEntry node)
    {
        var data = (ContainerManager)node.Value;

        writer.Write(data.Entries.Count);
        foreach (var entry in data.Entries)
        {
            writer.Write(entry.CNameHash);
            writer.Write(entry.Unknown1);
            writer.Write(entry.Unknown2);
        }
    }
}