using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Edit.W3Strings
{
    public class W3StringBlock2
    {
        public UInt32 unk1;
        public UInt32 str_id;

        public W3StringBlock2()
        {

        }

        public W3StringBlock2(BinaryReader stream, UInt32 magic)
        {
            Read(stream, magic);
        }

        public void Read(BinaryReader stream, UInt32 magic)
        {
            unk1 = stream.ReadUInt32();

            var str_id_n = stream.ReadUInt32();
            //1106107 = 2032334632 ^ 2033325971
            str_id = (str_id_n ^ magic);
        }

        public void Write(BinaryWriter stream, UInt32 magic)
        {
            stream.Write(unk1);
            //2032334632 = 1106107 ^ 2033325971
            var str_id_n = (UInt32)(str_id ^ magic);
            stream.Write(str_id_n);
        }
    }
}
