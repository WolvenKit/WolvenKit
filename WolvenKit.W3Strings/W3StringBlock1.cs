using System.IO;

namespace WolvenKit.W3Strings
{
    public class W3StringBlock1
    {
        public uint offset;
        public string str;
        public uint str_id;
        public uint strlen;

        public W3StringBlock1()
        {
        }

        public W3StringBlock1(BinaryReader stream, uint magic)
        {
            Read(stream, magic);
        }

        public bool Modified { get; set; }

        public void Read(BinaryReader stream, uint magic)
        {
            var str_id_n = stream.ReadUInt32();
            str_id = (str_id_n ^ magic);
            offset = stream.ReadUInt32();
            strlen = stream.ReadUInt32();
        }

        public void Write(BinaryWriter stream, uint magic)
        {
            var str_id_n = str_id ^ magic;

            stream.Write(str_id_n);
            stream.Write(offset);
            stream.Write(strlen);
        }
    }
}