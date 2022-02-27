using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.Save
{
    public class RadioSystem : IParseableBuffer
    {
        public string Unknown { get; set; }
    }


    public class RadioSystemParser : INodeParser
    {
        public void Read(SaveNode node)
        {
            using var ms = new MemoryStream(node.DataBytes);
            using var br = new BinaryReader(ms);
            var data = new RadioSystem();
            data.Unknown = br.ReadLengthPrefixedString();
            node.Data = data;
        }
    }

}
