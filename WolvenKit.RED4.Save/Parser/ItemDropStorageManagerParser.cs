using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.Save
{
    public class ItemDropStorageManager : IParseableBuffer
    {
        public List<ItemDropStorage> ItemDropStorages { get; set; } = new();
    }

    public class ItemDropStorageManagerParser : INodeParser
    {
        public static string NodeName => Constants.NodeNames.ITEM_DROP_STORAGE_MANAGER;

        public void Read(SaveNode node)
        {
            //

            using var ms = new MemoryStream(node.DataBytes);
            using var br = new BinaryReader(ms);
            var data = new ItemDropStorageManager();

            var parser = new ItemDropStorageParser();

            var cnt = br.ReadInt32();
            for (int i = 0; i < cnt; i++)
            {
                parser.Read(node.Children[i]);
                data.ItemDropStorages.Add((ItemDropStorage)node.Children[i].Data);
            }

            node.Data = data;
        }

        public SaveNode Write() => throw new NotImplementedException();
    }
}
