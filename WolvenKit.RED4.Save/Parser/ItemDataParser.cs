using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;
using System.Diagnostics;

namespace WolvenKit.RED4.Save
{
    public class ItemData : IParseableBuffer
    {
    }


    public class ItemDataParser : INodeParser
    {
        public void Read(SaveNode node)
        {
            throw new NotImplementedException();
            //using var ms = new MemoryStream(node.DataBytes);
            //using var br = new BinaryReader(ms);
            //var data = new ItemData();
            //node.Data = data;
        }
    }

}
