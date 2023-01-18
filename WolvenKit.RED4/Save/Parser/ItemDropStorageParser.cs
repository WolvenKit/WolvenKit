using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save;

public class ItemDropStorage : INodeData
{
    public string Unk1 { get; set; }
    public byte[] Unk2 { get; set; }

    public Vector4 Unk3 { get; set; }

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

        data.Unk2 = reader.ReadBytes(17);

        data.Unk3 = new Vector4()
        {
            X = reader.ReadSingle(),
            Y = reader.ReadSingle(),
            Z = reader.ReadSingle(),
            W = reader.ReadSingle()
        };

        var cnt = reader.ReadUInt32();
        for (int i = 0; i < cnt; i++)
        {
            node.Children[i].ReadByParent = true;

            var nextItemHeader = InventoryHelper.ReadHeaderThing(reader);

            reader.ReadUInt32(); // nodeId
            var item = InventoryHelper.ReadItemData(reader);

            if (!nextItemHeader.Equals(item.Header))
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
        writer.Write(value.Unk3.X);
        writer.Write(value.Unk3.Y);
        writer.Write(value.Unk3.Z);
        writer.Write(value.Unk3.W);

        writer.Write(value.Items.Count);
        foreach (var itemData in value.Items)
        {
            InventoryHelper.WriteHeaderThing(writer, itemData.Header);

            var subNode = new NodeEntry
            {
                Name = "itemData",
                Value = itemData,
            };
            writer.Write(subNode);
        }
    }
}