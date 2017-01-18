using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Edit.W3Strings
{
    public class W3StringBlock1
    {
        public UInt32 str_id;
        public UInt32 offset;
        public UInt32 strlen;

        public string str;


        public W3StringBlock1()
        {

        }

        public W3StringBlock1(BinaryReader stream, UInt32 magic)
        {
            Read(stream, magic);
        }

        public void Read(BinaryReader stream, UInt32 magic)
        {
            var str_id_n = stream.ReadUInt32();
            str_id = (str_id_n ^ magic);
            offset = stream.ReadUInt32();
            strlen = stream.ReadUInt32();
        }

        public void Write(BinaryWriter stream, UInt32 magic)
        {
            var str_id_n = (UInt32)(str_id ^ magic);

            stream.Write(str_id_n);
            stream.Write(offset);
            stream.Write(strlen);
        }

        public bool Modified { get; set; }
    }
}
