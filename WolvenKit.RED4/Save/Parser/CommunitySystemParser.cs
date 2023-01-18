using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save;

public class CommunitySystem : INodeData
{
    public List<ulong> Unk_HashList { get; set; }
    public byte[] TrailingBytes { get; set; }

    public CommunitySystem()
    {
        Unk_HashList = new List<ulong>();
    }
}


public class CommunitySystemParser : INodeParser
{
    public static string NodeName => Constants.NodeNames.COMMUNITY_SYSTEM;

    public void Read(BinaryReader reader, NodeEntry node)
    {
        var data = new CommunitySystem();
        var entryCount = reader.ReadUInt32();
        for (int i = 0; i < entryCount; i++)
        {
            data.Unk_HashList.Add(reader.ReadUInt64());
        }
        int trailingSize = node.Size - ((int)reader.BaseStream.Position - node.Offset);
        data.TrailingBytes = reader.ReadBytes(trailingSize);

        node.Value = data;
    }

    public void Write(NodeWriter writer, NodeEntry node)
    {
        var data = (CommunitySystem)node.Value;

        writer.Write(data.Unk_HashList.Count);
        foreach (var entry in data.Unk_HashList)
        {
            writer.Write(entry);
        }
        writer.Write(data.TrailingBytes);
    }
}