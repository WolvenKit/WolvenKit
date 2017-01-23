using System.IO;

namespace W3Edit.W3Strings
{
    public class W3StringBlock2
    {
        public uint str_id;
        public uint unk1;

        public W3StringBlock2()
        {
        }

        public W3StringBlock2(BinaryReader stream, uint magic)
        {
            Read(stream, magic);
        }

        public void Read(BinaryReader stream, uint magic)
        {
            unk1 = stream.ReadUInt32();

            var str_id_n = stream.ReadUInt32();
            //1106107 = 2032334632 ^ 2033325971
            str_id = (str_id_n ^ magic);
        }

        public void Write(BinaryWriter stream, uint magic)
        {
            stream.Write(unk1);
            //2032334632 = 1106107 ^ 2033325971
            var str_id_n = str_id ^ magic;
            stream.Write(str_id_n);
        }
    }
}