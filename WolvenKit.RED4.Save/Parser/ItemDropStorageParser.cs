using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save
{
    public class ItemDropStorage : INodeData
    {
        public string Unk1 { get; set; }
        public byte[] Unk2 { get; set; }
        public bool Unk3 { get; set; }

        // Vector4?
        public float Unk4 { get; set; }
        public float Unk5 { get; set; }
        public float Unk6 { get; set; }
        public float Unk7 { get; set; }

        public List<InventoryHelper.ItemData> Items { get; set; } = new();
    }


    public class ItemDropStorageParser : INodeParser
    {
        public static string NodeName => Constants.NodeNames.ITEM_DROP_STORAGE;

        public void Read(BinaryReader reader, NodeEntry node)
        {
            var data = new ItemDropStorage();

            reader.ReadUInt32(); // nodeId
            data.Unk1 = reader.ReadLengthPrefixedString();
            data.Unk2 = reader.ReadBytes(16);
            data.Unk3 = reader.ReadBoolean();
            data.Unk4 = reader.ReadSingle();
            data.Unk5 = reader.ReadSingle();
            data.Unk6 = reader.ReadSingle();
            data.Unk7 = reader.ReadSingle();

            var cnt = reader.ReadUInt32();
            for (int i = 0; i < cnt; i++)
            {
                node.Children[i].ReadByParent = true;

                var nextItemHeader = InventoryHelper.ReadNextItemEntry(reader);

                reader.ReadUInt32(); // nodeId
                var item = InventoryHelper.ReadItemData(reader);

                if (!nextItemHeader.Equals(item))
                {
                    throw new InvalidDataException($"Expected next item to be '{nextItemHeader}' but found '{item}'");
                }

                data.Items.Add(item);
            }

            node.Value = data;
        }

        public void Write(NodeWriter writer, NodeEntry node) => Write(writer, (ItemDropStorage)node.Value);

        public void Write(NodeWriter writer, ItemDropStorage value)
        {
            writer.WriteLengthPrefixedString(value.Unk1);
            writer.Write(value.Unk2);
            writer.Write(value.Unk3);
            writer.Write(value.Unk4);
            writer.Write(value.Unk5);
            writer.Write(value.Unk6);
            writer.Write(value.Unk7);

            writer.Write(value.Items.Count);
            foreach (var itemData in value.Items)
            {
                var nextItemEntry = new InventoryHelper.NextItemEntry
                {
                    ItemTdbId = itemData.ItemTdbId,
                    Header = itemData.Header
                };

                InventoryHelper.WriteNextItemEntry(writer, nextItemEntry);

                var subNode = new NodeEntry
                {
                    Name = "itemData",
                    Value = itemData,
                };
                writer.Write(subNode);
            }
        }
    }

}
