using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.IO;

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
        public static string NodeName => Constants.NodeNames.MUSIC_SYSTEM;

        public void Read(BinaryReader reader, NodeEntry node)
        {
            var data = new MusicSystem();
            data.Unknown1 = reader.ReadLengthPrefixedString();
            if (data.Unknown1 != "None")
            {
                data.Unknown2 = reader.ReadLengthPrefixedString();
                data.Unknown3 = reader.ReadByte();
                data.Unknown4 = reader.ReadLengthPrefixedString();
                data.Unknown5 = reader.ReadLengthPrefixedString();
                data.Unknown6 = reader.ReadUInt16();
                data.Unknown7 = reader.ReadLengthPrefixedString();
                data.Unknown8 = reader.ReadUInt32();
            }

            node.Value = data;
        }

        public void Write(NodeWriter writer, NodeEntry node) => throw new NotImplementedException();
    }

}
