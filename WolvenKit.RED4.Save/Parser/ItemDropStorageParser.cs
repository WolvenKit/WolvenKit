using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.Save
{
    public class ItemDropStorage : IParseableBuffer
    {
    }


    public class ItemDropStorageParser : INodeParser
    {
        public void Read(SaveNode node)
        {
            using var ms = new MemoryStream(node.DataBytes);
            using var br = new BinaryReader(ms);
            var data = new ClassName();
            node.Data = data;
        }
    }

}
