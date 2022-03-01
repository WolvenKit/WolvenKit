using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save
{
    public class CustomArray : IParseableBuffer
    {
        public List<ushort> Unknown { get; set; }

        public CustomArray()
        {
            Unknown = new List<ushort>();
        }
    }


    public class CustomArrayParser : INodeParser
    {
        public static string NodeName => Constants.NodeNames.CUSTOM_ARRAY;

        public void Read(BinaryReader reader, NodeEntry node)
        {
            var data = new CustomArray();
            var entryCount = reader.ReadUInt32();
            for (int i = 0; i < entryCount; i++)
            {
                data.Unknown.Add(reader.ReadUInt16());
            }

            node.Value = data;
        }

        public void Write(NodeWriter writer, NodeEntry node) => throw new NotImplementedException();
    }

}
