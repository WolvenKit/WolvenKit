using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.Save
{
    public class ContainerManagerNPCLootBagsVer2 : IParseableBuffer
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

            public Entry()
            {
                Items = new List<Item>();
            }
        }

        public class Item
        {
            public TweakDBID Unk1_ItemTbdId { get; set; }
            public uint Unk1_Seed { get; set; }
            public ushort Unk2_Counter { get; set; }
            public TweakDBID Unk2_ItemTbdId { get; set; }
            public uint Unk2_Seed { get; set; }
        }
    }


    public class ContainerManagerNPCLootBagsVer2Parser : INodeParser
    {
        // public static string NodeName => Constants.NodeNames.CONTAINER_MANAGER_NPC_LOOT_BAGS_VER2;

        public void Read(SaveNode node)
        {
            throw new NotImplementedException();
            //using var ms = new MemoryStream(node.DataBytes);
            //using var br = new BinaryReader(ms);
            //var data = new ContainerManagerNPCLootBagsVer2();
            //var entryCount = br.ReadVLQInt32();
            //for (int i = 0; i < entryCount; i++)
            //{
            //    var entry = new ContainerManagerNPCLootBagsVer2.Entry();
            //    entry.Unk_BaseClassName = br.ReadLengthPrefixedString();
            //    entry.Unknown2 = br.ReadBytes(12);

            //    var subCount = br.ReadByte();
            //    for (int j = 0; j < subCount; j++)
            //    {
            //        var subEntry = new ContainerManagerNPCLootBagsVer2.Item();
            //        subEntry.Unk1_ItemTbdId = br.ReadTweakDbId();
            //        subEntry.Unk1_Seed = br.ReadUInt32();
            //        subEntry.Unk2_Counter = br.ReadUInt16();
            //        subEntry.Unk2_ItemTbdId = br.ReadTweakDbId();
            //        subEntry.Unk2_Seed = br.ReadUInt32();

            //        entry.Items.Add(subEntry);
            //    }

            //    entry.EntityId = br.ReadUInt64();

            //    data.Entries.Add(entry);
            //}
            //node.Data = data;

        }

        public SaveNode Write() => throw new NotImplementedException();
    }

}
