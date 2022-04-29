using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;
using System.Diagnostics;
using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save
{
    public class ItemDataParser : INodeParser
    {
        public static string NodeName => Constants.NodeNames.ITEM_DATA;

        public void Read(BinaryReader reader, NodeEntry node)
        {
            node.Value = InventoryHelper.ReadItemData(reader);
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var value = (InventoryHelper.ItemData)node.Value;

            InventoryHelper.WriteItemData(writer, value);
        }
    }

}
