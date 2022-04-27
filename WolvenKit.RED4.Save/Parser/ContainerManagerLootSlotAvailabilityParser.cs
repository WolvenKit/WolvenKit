using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save
{
    public class ContainerManagerLootSlotAvailability : INodeData
    {
        public List<Entry> Entries { get; set; }

        public ContainerManagerLootSlotAvailability()
        {
            Entries = new List<Entry>();
        }

        public class Entry
        {
            public ulong CNameHash { get; set; }
            public byte Unknown1 { get; set; }
        }
    }


    public class ContainerManagerLootSlotAvailabilityParser : INodeParser
    {
        public static string NodeName => Constants.NodeNames.CONTAINER_MANAGER_LOOT_SLOT_AVAILABILITY;

        public void Read(BinaryReader reader, NodeEntry node)
        {
            var data = new ContainerManagerLootSlotAvailability();
            var entryCount = reader.ReadVLQInt32();
            for (int i = 0; i < entryCount; i++)
            {
                var entry = new ContainerManagerLootSlotAvailability.Entry();

                entry.CNameHash = reader.ReadUInt64();

                data.Entries.Add(entry);
            }

            foreach (var entry in data.Entries)
            {
                entry.Unknown1 = reader.ReadByte();
            }

            node.Value = data;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (ContainerManagerLootSlotAvailability)node.Value;

            writer.WriteVLQInt32(data.Entries.Count);
            foreach (var entry in data.Entries)
            {
                writer.Write(entry.CNameHash);
            }

            foreach (var entry in data.Entries)
            {
                writer.Write(entry.Unknown1);
            }
        }
    }

}
