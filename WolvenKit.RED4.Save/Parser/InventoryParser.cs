using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.Save
{
    public class Inventory : IParseableBuffer
    {
        public List<InventoryHelper.SubInventory> SubInventories { get; set; } = new();
    }


    public class InventoryParser : INodeParser
    {
        public static string NodeName => Constants.NodeNames.INVENTORY;

        public void Read(SaveNode node)
        {
            using var ms = new MemoryStream(node.DataBytes);
            using var reader = new BinaryReader(ms);
            var data = new Inventory();

            var offset = 0;
            var cnt = reader.ReadInt32();

            var subReader = reader;
            for (int i = 0; i < cnt; i++)
            {
                var subInventory = ReadSubInventory(subReader, node, offset);
                data.SubInventories.Add(subInventory);
                offset += subInventory.Items.Count;
                subReader = new BinaryReader(new MemoryStream(node.Children[offset - 1].TrailingDataBytes));
            }

            node.Data = data;
        }

        public SaveNode Write() => throw new NotImplementedException();

        #region Reader

        private InventoryHelper.SubInventory ReadSubInventory(BinaryReader reader, SaveNode node, int offset)
        {
            var subInventory = new InventoryHelper.SubInventory();
            subInventory.InventoryId = reader.ReadUInt64();

            var parser = ParserHelper.GetParser(Constants.NodeNames.ITEM_DATA);
            if (parser == null)
            {
                throw new NotImplementedException(Constants.NodeNames.ITEM_DATA);
            }

            var cnt = reader.ReadUInt32();
            var nextItemHeader = InventoryHelper.ReadNextItemEntry(reader);

            for (int i = 0; i < cnt; i++)
            {
                parser.Read(node.Children[offset + i]);
                var item = (InventoryHelper.ItemData)node.Children[offset + i].Data;

                if (!nextItemHeader.Equals(item))
                {
                    throw new InvalidDataException($"Expected next item to be '{nextItemHeader}' but found '{item}'");
                }

                subInventory.Items.Add(item);

                if (i < cnt - 1)
                {
                    nextItemHeader = InventoryHelper.ReadNextItemEntry(node.Children[offset + i].TrailingDataBytes);
                }
            }

            return subInventory;
        }

        #endregion
    }

}
