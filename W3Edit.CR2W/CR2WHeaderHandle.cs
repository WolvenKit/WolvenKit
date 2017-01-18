using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Edit.CR2W
{
    public class CR2WHeaderHandle
    {
        public UInt32 offset;
        public UInt16 filetype;
        public UInt16 flags;

        public string str;


        public CR2WHeaderHandle()
        {
        }

        public CR2WHeaderHandle(BinaryReader file)
        {
            Read(file);
        }

        public void Read(BinaryReader file)
        {
            offset = file.ReadUInt32();
            filetype = file.ReadUInt16();
            flags = file.ReadUInt16();
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
            file.Write(filetype);
            file.Write(flags);
        }
    }
}
