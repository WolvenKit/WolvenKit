using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Edit.CR2W
{
    public class CR2WHeaderBlock4
    {
        public UInt32 unk1;
        public UInt32 unk2;
        public UInt32 unk3;
        public UInt32 unk4;

        public CR2WHeaderBlock4()
        {
        }


        public CR2WHeaderBlock4(BinaryReader file)
        {
            Read(file);
        }

        public void Read(BinaryReader file)
        {
            unk1 = file.ReadUInt32();
            unk2 = file.ReadUInt32();
            unk3 = file.ReadUInt32();
            unk4 = file.ReadUInt32();
        }

        public void Write(BinaryWriter file)
        {
            file.Write(unk1);
            file.Write(unk2);
            file.Write(unk3);
            file.Write(unk4);
        }
    }
}
