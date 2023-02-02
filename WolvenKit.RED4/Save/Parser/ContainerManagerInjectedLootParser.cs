using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save;

public class ContainerManagerInjectedLoot : INodeData
{
    public List<Entry> Entries { get; set; }
    public byte[] TrailingBytes { get; set; }
    public ContainerManagerInjectedLoot()
    {
        Entries = new List<Entry>();
        TrailingBytes = Array.Empty<byte>();
    }

    public class Entry
    {
        public ulong EntityId { get; set; }
        public List<SubEntry> Entries { get; set; }

        public Entry()
        {
            Entries = new List<SubEntry>();
        }
    }

    public class SubEntry
    {
        public TweakDBID ItemTbdId { get; set; }
        public byte Unknown2 { get; set; }
        public uint Unknown3 { get; set; }
        public byte Unknown4 { get; set; }
        public byte Unknown5 { get; set; }
        public byte Unknown6 { get; set; }
    }
}


public class ContainerManagerInjectedLootParser : INodeParser
{
    public static string NodeName => Constants.NodeNames.CONTAINER_MANAGER_INJECTED_LOOT;

    public void Read(BinaryReader reader, NodeEntry node)
    {
        var result = new ContainerManagerInjectedLoot();
        var entryCount = reader.ReadVLQInt32();

        for (int i = 0; i < entryCount; i++)
        {
            result.Entries.Add(new ContainerManagerInjectedLoot.Entry { EntityId = reader.ReadUInt64() });
        }

        foreach (var entry in result.Entries)
        {
            entry.Entries = new List<ContainerManagerInjectedLoot.SubEntry>();

            var subEntryCount = reader.ReadByte();
            for (int i = 0; i < subEntryCount; i++)
            {
                var subEntry = new ContainerManagerInjectedLoot.SubEntry();

                subEntry.ItemTbdId = reader.ReadUInt64();
                subEntry.Unknown2 = reader.ReadByte();
                subEntry.Unknown3 = reader.ReadUInt32();
                subEntry.Unknown4 = reader.ReadByte();
                subEntry.Unknown5 = reader.ReadByte();
                subEntry.Unknown6 = reader.ReadByte();

                entry.Entries.Add(subEntry);
            }
        }

        int trailingSize = node.Size - ((int)reader.BaseStream.Position - node.Offset);
        result.TrailingBytes = reader.ReadBytes(trailingSize);
        node.Value = result;
    }

    public void Write(NodeWriter writer, NodeEntry node)
    {
        var data = (ContainerManagerInjectedLoot)node.Value;

        writer.WriteVLQInt32(data.Entries.Count);
        foreach (var entry in data.Entries)
        {
            writer.Write(entry.EntityId);
        }

        foreach (var entry in data.Entries)
        {
            writer.Write((byte)entry.Entries.Count);
            foreach (var subEntry in entry.Entries)
            {
                var hash = (ulong)subEntry.ItemTbdId;
                writer.Write(hash);
                writer.Write(subEntry.Unknown2);
                writer.Write(subEntry.Unknown3);
                writer.Write(subEntry.Unknown4);
                writer.Write(subEntry.Unknown5);
                writer.Write(subEntry.Unknown6);
            }
        }
        writer.Write(data.TrailingBytes);
    }
}