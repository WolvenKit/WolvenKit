using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save
{
    public class RadioSystem : INodeData
    {
        public string Unknown { get; set; }
    }


    public class RadioSystemParser : INodeParser
    {
        public static string NodeName => Constants.NodeNames.RADIO_SYSTEM;

        public void Read(BinaryReader reader, NodeEntry node)
        {
            var data = new RadioSystem();
            data.Unknown = reader.ReadLengthPrefixedString();

            node.Value = data;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (RadioSystem)node.Value;

            writer.WriteLengthPrefixedString(data.Unknown);
        }
    }

}
