using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.Save
{
    public class ItemDropStorageManager : IParseableBuffer
    {
    }

    public class ItemDropStorageManagerParser : INodeParser
    {
        public void Read(SaveNode node)
        {
            throw new NotImplementedException();
            //using var ms = new MemoryStream(node.DataBytes);
            //using var br = new BinaryReader(ms);
            //var data = new ItemDropStorageManager();
            //node.Data = data;
        }
    }
}
