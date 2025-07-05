using WolvenKit.RED4.Save.Classes;
using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save;

public class Inventory : INodeData
{
    public List<SubInventory> SubInventories { get; set; } = new();
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

    public void Write(NodeWriter writer, NodeEntry node)
    {
        var parser = ParserHelper.GetParser(Constants.NodeNames.ITEM_DATA);
        if (parser == null)
        {
            throw new NotImplementedException(Constants.NodeNames.ITEM_DATA);
        }

        var value = (Inventory)node.Value;

        writer.Write(value.SubInventories.Count);
        foreach (var subInventory in value.SubInventories)
        {
            writer.Write(subInventory.InventoryId);
            writer.Write(subInventory.Items.Count);
            foreach (var itemData in subInventory.Items)
            {
                InventoryHelper.WriteItemInfo(writer, itemData.ItemInfo);

                var subNode = new NodeEntry
                {
                    Name = "itemData",
                    Value = itemData,
                };
                writer.Write(subNode);
            }
        }
    }

    #region Reader

    private SubInventory ReadSubInventory(BinaryReader reader, NodeEntry node, int offset)
    {
        var subInventory = new SubInventory();
        subInventory.InventoryId = reader.ReadUInt64();

        var parser = ParserHelper.GetParser(Constants.NodeNames.ITEM_DATA);
        if (parser == null)
        {
            throw new NotImplementedException(Constants.NodeNames.ITEM_DATA);
        }

        var cnt = reader.ReadUInt32();

        for (int i = 0; i < cnt; i++)
        {
            var nextItemHeader = InventoryHelper.ReadItemInfo(reader);

            reader.ReadUInt32(); // nodeId
            parser.Read(reader, node.Children[offset + i]);

            var item = (ItemData)node.Children[offset + i].Value;

            if (!nextItemHeader.Equals(item.ItemInfo))
            {
                throw new InvalidDataException($"Expected next item to be '{nextItemHeader}' but found '{item}'");
            }

            subInventory.Items.Add(item);
        }

        return subInventory;
    }

    #endregion
}