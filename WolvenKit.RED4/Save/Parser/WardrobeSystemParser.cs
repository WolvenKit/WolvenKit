using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.Classes;
using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save;

public class WardrobeSystem : INodeData
{
    public List<WardrobeSystemEntry> Entries { get; set; }

    public WardrobeSystem()
    {
        Entries = new List<WardrobeSystemEntry>();
    }
}

public class WardrobeSystemEntry : INodeData
{
    public string AppearanceName { get; set; }
    public ItemInfo ItemId { get; set; }
}

public class WardrobeSystemParser : INodeParser
{
    public static string NodeName => Constants.NodeNames.WARDROBE_SYSTEM;

    public void Read(BinaryReader reader, NodeEntry node)
    {
        var data = new WardrobeSystem();

        var cnt = reader.ReadInt32();
        for (int i = 0; i < cnt; i++)
        {
            var entry = new WardrobeSystemEntry();
            entry.AppearanceName = reader.ReadLengthPrefixedString();
            entry.ItemId = InventoryHelper.ReadItemInfo(reader);

            data.Entries.Add(entry);
        }

        node.Value = data;
    }

    public void Write(NodeWriter writer, NodeEntry node)
    {
        var data = (WardrobeSystem)node.Value;

        writer.Write(data.Entries.Count);
        foreach (var entry in data.Entries)
        {
            writer.WriteLengthPrefixedString(entry.AppearanceName);
            InventoryHelper.WriteItemInfo(writer, entry.ItemId);
        }
    }
}
