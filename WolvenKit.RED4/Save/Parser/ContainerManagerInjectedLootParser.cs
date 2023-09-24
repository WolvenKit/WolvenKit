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
        public TweakDBID Unknown1 { get; set; }
        public uint Unknown2 { get; set; }
        public uint Unknown3 { get; set; }
        public List<string> Unknown4 { get; set; } = new();
        public TweakDBID Unknown5 { get; set; }
        public ulong Unknown6 { get; set; }
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

                subEntry.Unknown1 = reader.ReadUInt64();
                subEntry.Unknown2 = reader.ReadUInt32();
                subEntry.Unknown3 = reader.ReadUInt32();

                var cnt = reader.ReadByte();
                for (int j = 0; j < cnt; j++)
                {
                    subEntry.Unknown4.Add(reader.ReadLengthPrefixedString());
                }

                subEntry.Unknown5 = reader.ReadUInt64();
                subEntry.Unknown6 = reader.ReadUInt64();

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
                writer.Write((ulong)subEntry.Unknown1);
                writer.Write(subEntry.Unknown2);
                writer.Write(subEntry.Unknown3);
                
                writer.Write((byte)subEntry.Unknown4.Count);
                foreach (var str in subEntry.Unknown4)
                {
                    writer.WriteLengthPrefixedString(str);
                }

                writer.Write((ulong)subEntry.Unknown5);
                writer.Write(subEntry.Unknown6);
            }
        }
        writer.Write(data.TrailingBytes);
    }
}