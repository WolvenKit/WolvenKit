using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.Save
{
    public class DeviceSystemParser : INodeParser
    {
        public void Read(SaveNode node)
        {
            throw new NotImplementedException();
            //using var ms = new MemoryStream(node.DataBytes);
            //using var br = new BinaryReader(ms);
            //ParserUtils.ParseChildren(node.Children, reader, parsers);
        }
    }

}
