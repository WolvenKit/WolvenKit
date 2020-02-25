using System.IO;

namespace WolvenKit.CR2W
{
    public class CR2WHeaderData
    {
        public uint crc;
        public uint offset;
        public uint size;

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