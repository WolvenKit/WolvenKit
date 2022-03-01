using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save
{
    public class DeviceSystemParser : INodeParser
    {
        // public static string NodeName => Constants.NodeNames.DEVICE_SYSTEM;

        public void Read(BinaryReader reader, NodeEntry node)
        {
            throw new NotImplementedException();
            //using var ms = new MemoryStream(node.DataBytes);
            //using var br = new BinaryReader(ms);
            //ParserUtils.ParseChildren(node.Children, reader, parsers);
        }

        public void Write(NodeWriter writer, NodeEntry node) => throw new NotImplementedException();
    }

}
