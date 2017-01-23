using System.IO;

namespace W3Edit.CR2W
{
    public class CR2WHeaderBlock6
    {
        public uint crc;
        public uint size;
        public uint size2;
        public uint unk1;
        public uint unk2;
        public uint unk3;

        public CR2WHeaderBlock6()
        {
        }

        public CR2WHeaderBlock6(BinaryReader file)
        {
            Read(file);
        }

        public void Read(BinaryReader file)
        {
            unk1 = file.ReadUInt32();
            unk2 = file.ReadUInt32();
            unk3 = file.ReadUInt32();
            size = file.ReadUInt32();
            size2 = file.ReadUInt32();
            crc = file.ReadUInt32();
        }

        public void Write(BinaryWriter file)
        {
            file.Write(unk1);
            file.Write(unk2);
            file.Write(unk3);
            file.Write(size);
            file.Write(size2);
            file.Write(crc);
        }
    }
}