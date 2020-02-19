using System;
using System.IO;

namespace WolvenKit.CR2W
{
    public class CR2WBuffer
    {
        public uint crc;
        public uint size;
        public uint memsize;
        public uint flags;
        public uint index;
        public uint offset;

        public CR2WBuffer()
        {
        }

        public CR2WBuffer(BinaryReader file)
        {
            Read(file);
        }

        public void Read(BinaryReader file)
        {
            flags = file.ReadUInt32();
            index = file.ReadUInt32();
            offset = file.ReadUInt32();
            size = file.ReadUInt32();
            memsize = file.ReadUInt32();
            crc = file.ReadUInt32();
        }

        public void Write(BinaryWriter file)
        {
            file.Write(flags);
            file.Write(index);
            file.Write(offset);
            file.Write(size);
            file.Write(memsize);
            file.Write(crc);
        }

        internal CR2WBufferHeader ToCR2WBuffer()
        {
            return new CR2WBufferHeader()
            {
                flags = flags,
                index = index,
                offset = offset,
                diskSize = size,
                memSize = memsize,
                crc32 = crc
            };
        }
    }
}