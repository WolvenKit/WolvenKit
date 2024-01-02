using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save;

public class ContainerManagerNPCLootBagsVer2 : INodeData
{
    public List<Entry> Entries { get; set; }

    public ContainerManagerNPCLootBagsVer2()
    {
        Entries = new List<Entry>();
    }

    public class Entry
    {
        public string Unk_BaseClassName { get; set; }
        public byte[] Unknown2 { get; set; }
        public List<Item> Items { get; set; }
        public ulong EntityId { get; set; }

        public Entry(string baseClassName)
        {
            Unk_BaseClassName = baseClassName;
            Unknown2 = Array.Empty<byte>();
            Items = new List<Item>();
        }
    }

    public class Item
    {
        public TweakDBID Unk1_ItemTbdId { get; set; }
        public uint Unk1_Seed { get; set; }
        public uint Unk2_Counter { get; set; }
        public TweakDBID Unk2_ItemTbdId { get; set; }
        public uint Unk2_Seed { get; set; }
    }
}

//Broken
public class ContainerManagerNPCLootBagsVer2Parser : INodeParser
{
    // TODO
    //public static string NodeName => Constants.NodeNames.CONTAINER_MANAGER_NPC_LOOT_BAGS_VER2;

    public void Read(BinaryReader reader, NodeEntry node)
    {
        var result = new ContainerManagerNPCLootBagsVer2();
        var entryCount = reader.ReadVLQInt32();
        for (int i = 0; i < entryCount; i++)
        {
            var entry = new ContainerManagerNPCLootBagsVer2.Entry(reader.ReadLengthPrefixedString());
            entry.Unknown2 = reader.ReadBytes(12);

            var subCount = reader.ReadByte();
            for (int j = 0; j < subCount; j++)
            {
                var subEntry = new ContainerManagerNPCLootBagsVer2.Item();
                subEntry.Unk1_ItemTbdId = reader.ReadUInt64();
                subEntry.Unk1_Seed = reader.ReadUInt32();
                subEntry.Unk2_Counter = reader.ReadUInt32();
                subEntry.Unk2_ItemTbdId = reader.ReadUInt64();
                subEntry.Unk2_Seed = reader.ReadUInt32();

                entry.Items.Add(subEntry);
            }

            entry.EntityId = reader.ReadUInt64();

            result.Entries.Add(entry);
        }

        int readSize = node.Size - ((int)reader.BaseStream.Position - node.Offset);

        node.Value = result;
    }

    public void Write(NodeWriter writer, NodeEntry node)
    {
        var data = (ContainerManagerNPCLootBagsVer2)node.Value;

        writer.WriteVLQInt32(data.Entries.Count);
        foreach (var entry in data.Entries)
        {
            writer.WriteLengthPrefixedString(entry.Unk_BaseClassName);
            writer.Write(entry.Unknown2);
            writer.Write((byte)entry.Items.Count);
            foreach (var item in entry.Items)
            {
                writer.Write((ulong)item.Unk1_ItemTbdId);
                writer.Write(item.Unk1_Seed);
                writer.Write(item.Unk2_Counter);
                writer.Write((ulong)item.Unk2_ItemTbdId);
                writer.Write(item.Unk2_Seed);
            }
            writer.Write(entry.EntityId);
        }
    }
}