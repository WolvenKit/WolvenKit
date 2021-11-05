using WolvenKit.Common.Model.Cr2w;
using WolvenKit.RED4.CR2W;

namespace WolvenKit.Common.Conversion
{
    public class RedBufferDto
    {
        public uint Flags { get; set; }
        public uint Index { get; set; }

        // public uint Offset { get; set; }
        // public uint DiskSize { get; set; }
        // public uint MemSize { get; set; }
        // public uint Crc32 { get; set; }

        public RedBufferDto()
        {

        }

        public RedBufferDto(ICR2WBuffer cr2WBuffer)
        {
            Flags = cr2WBuffer.Flags;
            Index = cr2WBuffer.Index;
            // Offset = cr2WBuffer.Offset;
            // DiskSize = cr2WBuffer.DiskSize;
            // MemSize = cr2WBuffer.MemSize;
            // Crc32 = cr2WBuffer.Crc32;
        }

        public ICR2WBuffer ToRedBuffer() =>
            new CR2WBufferWrapper(new CR2WBuffer()
            {
                flags = Flags,
                index = Index,
                // offset = Offset,
                // diskSize = DiskSize,
                // memSize = MemSize,
                // crc32 = Crc32,
            });
    }
}
