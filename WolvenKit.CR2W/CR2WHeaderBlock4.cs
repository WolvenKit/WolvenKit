using System.IO;

namespace WolvenKit.CR2W
{
    public class CR2WHeaderBlock4
    {
        public uint unk1;
        public uint unk2;
        public uint unk3;
        public uint unk4;

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