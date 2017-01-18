using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Edit.CR2W
{
    public class CR2WHeaderData
    {
        public UInt32 offset;
        public UInt32 size;
        public UInt32 crc;

        public CR2WHeaderData()
        {

        }

        public CR2WHeaderData(BinaryReader file)
        {
            Read(file);
        }

        public void Read(BinaryReader file)
        {
            offset = file.ReadUInt32();
            size = file.ReadUInt32();
            crc = file.ReadUInt32();
        }

        public void Write(BinaryWriter file)
        {
            if (size == 0)
            {
                offset = 0;
                crc = 0;
            }

            file.Write(offset);
            file.Write(size);
            file.Write(crc);
        }
    }
}
