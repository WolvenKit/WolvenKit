using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.Save
{
    public class DirectorSystem : IParseableBuffer
    {
        // counter?
        public uint Unknown1 { get; set; }
        public string Unknown2 { get; set; }
        // null terminator?
        public byte Unknown3 { get; set; }
        public string Unknown4 { get; set; }
        public uint Unknown5 { get; set; }
    }


    public class DirectorSystemParser : INodeParser
    {
        public static string NodeName => Constants.NodeNames.DIRECTOR_SYSTEM;

        public void Read(SaveNode node)
        {
            using var ms = new MemoryStream(node.DataBytes);
            using var br = new BinaryReader(ms);
            var data = new DirectorSystem();
            data.Unknown1 = br.ReadUInt32();
            data.Unknown2 = br.ReadLengthPrefixedString();
            data.Unknown3 = br.ReadByte();
            data.Unknown4 = br.ReadLengthPrefixedString();
            data.Unknown5 = br.ReadUInt32();
            node.Data = data;
        }

        public SaveNode Write() => throw new NotImplementedException();
    }

}
