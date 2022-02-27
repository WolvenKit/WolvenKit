using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.Save
{
    public class DeviceSystemParser : INodeParser
    {
        // public static string NodeName => Constants.NodeNames.DEVICE_SYSTEM;

        public void Read(SaveNode node)
        {
            throw new NotImplementedException();
            //using var ms = new MemoryStream(node.DataBytes);
            //using var br = new BinaryReader(ms);
            //ParserUtils.ParseChildren(node.Children, reader, parsers);
        }

        public SaveNode Write() => throw new NotImplementedException();
    }

}
