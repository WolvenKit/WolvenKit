using WolvenKit.RED4.Save.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save;

public class WardrobeSystemClothingSets : INodeData
{
    public uint Unknown1 { get; set; }
    public List<WardrobeSystemClothingSet> Sets { get; set; } = new();
}

public class WardrobeSystemClothingSet
{
    public uint Unknown1 { get; set; } // always 6, itemCount?
    public uint Unknown2 { get; set; } // always 16
    public byte Unknown3 { get; set; }
    public List<WardrobeSystemClothingSetItem> Items { get; set; } = new();
    public byte[] Unknown4 { get; set; }
    public uint Unknown5 { get; set; }
}

public class WardrobeSystemClothingSetItem
{
    public TweakDBID Unknown1 { get; set; }
    public uint Unknown2 { get; set; } // same as WardrobeSystemEntry?
    public ushort Unknown3 { get; set; } // same as WardrobeSystemEntry?
    public ushort Unknown4 { get; set; } // same as WardrobeSystemEntry?
    public uint Unknown5 { get; set; }
    public byte Unknown6 { get; set; }
}

public class WardrobeSystemClothingSetsParser : INodeParser
{
    public static string NodeName => Constants.NodeNames.WARDROBE_SYSTEM_CLOTHING_SETS;

    public void Read(BinaryReader reader, NodeEntry node)
    {
        var data = new WardrobeSystemClothingSets();

        var cnt = reader.ReadByte();
        data.Unknown1 = reader.ReadUInt32();

        // size = 0x8E per set
        for (int i = 0; i < cnt; i++)
        {
            var set = new WardrobeSystemClothingSet();

            set.Unknown1 = reader.ReadUInt32();
            set.Unknown2 = reader.ReadUInt32();
            set.Unknown3 = reader.ReadByte();

            // size = 0x15 per item
            for (int j = 0; j < 6; j++)
            {
                var item = new WardrobeSystemClothingSetItem();
                item.Unknown1 = reader.ReadUInt64();
                item.Unknown2 = reader.ReadUInt32();
                item.Unknown3 = reader.ReadUInt16();
                item.Unknown4 = reader.ReadUInt16();
                item.Unknown5 = reader.ReadUInt32();
                item.Unknown6 = reader.ReadByte();

                set.Items.Add(item);
            }

            set.Unknown4 = reader.ReadBytes(3);
            set.Unknown5 = reader.ReadUInt32();

            data.Sets.Add(set);
        }

        node.Value = data;
    }

    public void Write(NodeWriter writer, NodeEntry node)
    {
        var data = (WardrobeSystemClothingSets)node.Value;

        writer.Write((byte)data.Sets.Count);
        writer.Write(data.Unknown1);

        foreach (var set in data.Sets)
        {
            writer.Write(set.Unknown1);
            writer.Write(set.Unknown2);
            writer.Write(set.Unknown3);

            foreach (var item in set.Items)
            {
                writer.Write((ulong)item.Unknown1);
                writer.Write(item.Unknown2);
                writer.Write(item.Unknown3);
                writer.Write(item.Unknown4);
                writer.Write(item.Unknown5);
                writer.Write(item.Unknown6);
            }

            writer.Write(set.Unknown4);
            writer.Write(set.Unknown5);
        }
    }
}
