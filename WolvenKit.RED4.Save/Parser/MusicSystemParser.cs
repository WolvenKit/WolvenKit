using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.Save
{
    public class MusicSystem : IParseableBuffer
    {
        public string Unknown1 { get; set; }
        public string Unknown2 { get; set; }
        public byte Unknown3 { get; set; }
        public string Unknown4 { get; set; }
        public string Unknown5 { get; set; }
        public ushort Unknown6 { get; set; }
        public string Unknown7 { get; set; }
        public uint Unknown8 { get; set; }
    }


    public class MusicSystemParser : INodeParser
    {
        public void Read(SaveNode node)
        {
            using var ms = new MemoryStream(node.DataBytes);
            using var br = new BinaryReader(ms);
            var data = new MusicSystem();
            data.Unknown1 = br.ReadLengthPrefixedString();
            if (data.Unknown1 != "None")
            {
                data.Unknown2 = br.ReadLengthPrefixedString();
                data.Unknown3 = br.ReadByte();
                data.Unknown4 = br.ReadLengthPrefixedString();
                data.Unknown5 = br.ReadLengthPrefixedString();
                data.Unknown6 = br.ReadUInt16();
                data.Unknown7 = br.ReadLengthPrefixedString();
                data.Unknown8 = br.ReadUInt32();
            }
            node.Data = data;
        }
    }

}
