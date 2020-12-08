using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Linq;

namespace WolvenKit.CR2W
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct CR2WEmbedded
    {
        [FieldOffset(0)]
        public uint importIndex;        // updated on cr2w write

        [FieldOffset(4)]
        public uint path;               // updated on cr2w write

        [FieldOffset(8)]
        public ulong pathHash;          // updated on cr2w write

        [FieldOffset(16)]
        public uint dataOffset;         // updated on data write

        [FieldOffset(20)]
        public uint dataSize;           // updated on data write
    }

    
}