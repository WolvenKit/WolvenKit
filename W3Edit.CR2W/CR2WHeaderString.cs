using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Edit.CR2W
{
    public class CR2WHeaderString
    {
        public UInt32 offset;
        public UInt32 crc;

        public string str;

        public CR2WHeaderString()
        {
        }

        public CR2WHeaderString(BinaryReader file)
        {
            Read(file);
        }

        public void Read(BinaryReader file)
        {
            offset = file.ReadUInt32();
            crc = file.ReadUInt32();
        }

        public void ReadString(BinaryReader file, long baseoffset)
        {
            var pos = file.BaseStream.Position;

            file.BaseStream.Seek(offset + baseoffset, SeekOrigin.Begin);
            str = file.ReadCR2WString();
            file.BaseStream.Seek(pos, SeekOrigin.Begin);
        }

        public void Write(BinaryWriter file)
        {
            file.Write(offset);
            file.Write(crc);
        }
    }
}
