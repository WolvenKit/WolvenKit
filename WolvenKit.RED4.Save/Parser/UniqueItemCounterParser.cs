using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.Save
{
    public class UniqueItemCounter : IParseableBuffer
    {
        public ushort Count { get; set; }
    }


    public class UniqueItemCounterParser : INodeParser
    {
        public static string NodeName => Constants.NodeNames.UNIQUE_ITEM_COUNTER;

        public void Read(SaveNode node)
        {
            using var ms = new MemoryStream(node.DataBytes);
            using var br = new BinaryReader(ms);
            var data = new UniqueItemCounter();
            data.Count = br.ReadUInt16();
            node.Data = data;
        }

        public SaveNode Write() => throw new NotImplementedException();
    }

}
