using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Cache.DDS
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct DDS_PIXELFORMAT
    {
        [FieldOffset(0)]
        public uint dwSize;
        [FieldOffset(4)]
        public uint dwFlags;
        [FieldOffset(8)]
        public uint dwFourCC;
        [FieldOffset(12)]
        public uint dwRGBBitCount;
        [FieldOffset(16)]
        public uint dwRBitMask;
        [FieldOffset(20)]
        public uint dwGBitMask;
        [FieldOffset(24)]
        public uint dwBBitMask;
        [FieldOffset(28)]
        public uint dwABitMask;


    };
}
