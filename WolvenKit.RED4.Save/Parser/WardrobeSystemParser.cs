using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save;

public class WardrobeSystem : INodeData
{
    public List<WardrobeSystemEntry> Entries { get; set; }

    public WardrobeSystem()
    {
        Entries = new List<WardrobeSystemEntry>();
    }
}

public class WardrobeSystemEntry : INodeData
{
    public string Unknown1 { get; set; }
    public TweakDBID Unknown2 { get; set; } // gameItemID.id? 
    public uint Unknown3 { get; set; } // gameItemID.rngSeed? 
    public ushort Unknown4 { get; set; }
    public ushort Unknown5 { get; set; }
}

public class WardrobeSystemParser : INodeParser
{
    public static string NodeName => Constants.NodeNames.WARDROBE_SYSTEM;

    public void Read(BinaryReader reader, NodeEntry node)
    {
        var data = new WardrobeSystem();

        var cnt = reader.ReadInt32();
        for (int i = 0; i < cnt; i++)
        {
            var entry = new WardrobeSystemEntry();
            entry.Unknown1 = reader.ReadLengthPrefixedString();
            entry.Unknown2 = reader.ReadUInt64();
            entry.Unknown3 = reader.ReadUInt32();
            entry.Unknown4 = reader.ReadUInt16();
            entry.Unknown5 = reader.ReadUInt16();

            data.Entries.Add(entry);
        }

        node.Value = data;
    }

    public void Write(NodeWriter writer, NodeEntry node)
    {
        var data = (WardrobeSystem)node.Value;

        writer.Write(data.Entries.Count);
        foreach (var entry in data.Entries)
        {
            writer.WriteLengthPrefixedString(entry.Unknown1);
            writer.Write((ulong)entry.Unknown2);
            writer.Write(entry.Unknown3);
            writer.Write(entry.Unknown4);
            writer.Write(entry.Unknown5);
        }
    }
}
