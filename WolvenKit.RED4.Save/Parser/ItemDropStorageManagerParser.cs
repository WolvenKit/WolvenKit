using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save
{
    public class ItemDropStorageManager : IParseableBuffer
    {
        public List<ItemDropStorage> ItemDropStorages { get; set; } = new();
    }

    public class ItemDropStorageManagerParser : INodeParser
    {
        //public static string NodeName => Constants.NodeNames.ITEM_DROP_STORAGE_MANAGER;

        public void Read(BinaryReader reader, NodeEntry node)
        {
            var data = new ItemDropStorageManager();

            var parser = new ItemDropStorageParser();

            var cnt = reader.ReadInt32();
            for (int i = 0; i < cnt; i++)
            {
                parser.Read(reader, node.Children[i]);
                data.ItemDropStorages.Add((ItemDropStorage)node.Children[i].Value);
            }

            node.Value = data;
        }

        public void Write(NodeWriter writer, NodeEntry node) => throw new NotImplementedException();
    }
}
