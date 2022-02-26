using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.Save
{
    public class ContainerManagerLootSlotAvailability : IParseableBuffer
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
        public void Read(SaveNode node)
        {
            using var ms = new MemoryStream(node.DataBytes);
            using var br = new BinaryReader(ms);
            var data = new ContainerManagerLootSlotAvailability();
            var entryCount = br.ReadVLQInt32();
            for (int i = 0; i < entryCount; i++)
            {
                var entry = new ContainerManagerLootSlotAvailability.Entry();

                entry.CNameHash = br.ReadUInt64();

                data.Entries.Add(entry);
            }

            foreach (var entry in data.Entries)
            {
                entry.Unknown1 = br.ReadByte();
            }
            node.Data = data;

        }
    }

}
