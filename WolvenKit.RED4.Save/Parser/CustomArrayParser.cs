using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;

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

        public void Read(SaveNode node)
        {
            using var ms = new MemoryStream(node.DataBytes);
            using var br = new BinaryReader(ms);
            var data = new CustomArray();
            var entryCount = br.ReadUInt32();
            for (int i = 0; i < entryCount; i++)
            {
                data.Unknown.Add(br.ReadUInt16());
            }
            node.Data = data;

        }

        public SaveNode Write() => throw new NotImplementedException();
    }

}
