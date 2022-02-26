using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;
namespace WolvenKit.RED4.Save
{
    public class ContainerManagerInjectedLoot : IParseableBuffer
    {
        public List<Entry> Entries { get; set; }

        public ContainerManagerInjectedLoot()
        {
            Entries = new List<Entry>();
        }

        public class Entry
        {
            public ulong EntityId { get; set; }
            public List<SubEntry> Entries { get; set; }
        }

        public class SubEntry
        {
            public TweakDBID ItemTbdId { get; set; }
            public byte Unknown2 { get; set; }
            public uint Unknown3 { get; set; }
            public byte Unknown4 { get; set; }
        }
    }


    public class ContainerManagerInjectedLootParser : INodeParser
    {
        public void Read(SaveNode node)
        {
            throw new NotImplementedException();
            //using var ms = new MemoryStream(node.DataBytes);
            //using var br = new BinaryReader(ms);
            //var data = new ContainerManagerInjectedLoot();
            //var entryCount = br.ReadVLQInt32();

            //for (int i = 0; i < entryCount; i++)
            //{
            //    data.Entries.Add(new ContainerManagerInjectedLoot.Entry { EntityId = br.ReadUInt64() });
            //}

            //foreach (var entry in data.Entries)
            //{
            //    entry.Entries = new List<ContainerManagerInjectedLoot.SubEntry>();

            //    var subEntryCount = br.ReadByte();
            //    for (int i = 0; i < subEntryCount; i++)
            //    {
            //        var subEntry = new ContainerManagerInjectedLoot.SubEntry();

            //        //subEntry.ItemTbdId = br.ReadTweakDbId();
            //        subEntry.Unknown2 = br.ReadByte();
            //        subEntry.Unknown3 = br.ReadUInt32();
            //        subEntry.Unknown4 = br.ReadByte();

            //        entry.Entries.Add(subEntry);
            //    }
            //}
            //node.Data = data;

        }
    }

}
