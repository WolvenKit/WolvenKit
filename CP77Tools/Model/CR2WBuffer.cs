using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace WolvenKit.CR2W
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct CR2WBuffer
    {
        [FieldOffset(0)]
        public uint flags;

        [FieldOffset(4)]
        public uint index;

        [FieldOffset(8)]
        public uint offset;

        [FieldOffset(12)]
        public uint diskSize;

        [FieldOffset(16)]
        public uint memSize;

        [FieldOffset(20)]
        public uint crc32;
    }
    
    
}