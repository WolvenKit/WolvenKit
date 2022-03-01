using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save
{
    public class Inventory : IParseableBuffer
    {
        public List<InventoryHelper.SubInventory> SubInventories { get; set; } = new();
    }


    public class InventoryParser : INodeParser
    {
        public static string NodeName => Constants.NodeNames.INVENTORY;

        public void Read(BinaryReader reader, NodeEntry node)
        {
            var data = new Inventory();

            var offset = 0;
            var cnt = reader.ReadInt32();

            for (int i = 0; i < cnt; i++)
            {
                var subInventory = ReadSubInventory(reader, node, offset);
                data.SubInventories.Add(subInventory);
                offset += subInventory.Items.Count;
            }

            node.Value = data;
        }

        public void Write(NodeWriter writer, NodeEntry node) => throw new NotImplementedException();

        #region Reader

        private InventoryHelper.SubInventory ReadSubInventory(BinaryReader reader, NodeEntry node, int offset)
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
                ParserHelper.ReadNode(reader, node.Children[offset + i]);
                var item = (InventoryHelper.ItemData)node.Children[offset + i].Value;

                if (!nextItemHeader.Equals(item))
                {
                    throw new InvalidDataException($"Expected next item to be '{nextItemHeader}' but found '{item}'");
                }

                subInventory.Items.Add(item);

                if (i < cnt - 1)
                {
                    nextItemHeader = InventoryHelper.ReadNextItemEntry(reader);
                }
            }

            return subInventory;
        }

        #endregion
    }

}
