using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;
using System.Diagnostics;

namespace WolvenKit.RED4.Save
{
    public class ItemDataParser : INodeParser
    {
        public static string NodeName => Constants.NodeNames.ITEM_DATA;

        public void Read(SaveNode node)
        {
            using var ms = new MemoryStream(node.DataBytes);
            using var br = new BinaryReader(ms);

            node.Data = InventoryHelper.ReadItemData(br);
        }

        public SaveNode Write() => throw new NotImplementedException();
    }

}
