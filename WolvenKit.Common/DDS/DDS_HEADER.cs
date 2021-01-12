using System.Runtime.InteropServices;

namespace WolvenKit.Common.Tools.DDS
{
    [StructLayout(LayoutKind.Explicit, Size = 124)]
    public struct DDS_HEADER
    {
        [FieldOffset(0)]
        public uint dwSize;
        [FieldOffset(4)]
        public uint dwFlags;
        [FieldOffset(8)]
        public uint dwHeight;
        [FieldOffset(12)]
        public uint dwWidth;
        [FieldOffset(16)]
        public uint dwPitchOrLinearSize;
        [FieldOffset(20)]
        public uint dwDepth;
        [FieldOffset(24)]
        public uint dwMipMapCount;
        [FieldOffset(28)]
        public uint dwReserved1;// = new uint[11];
        [FieldOffset(32)]
        public uint dwReserved2;// = new uint[11];
        [FieldOffset(36)]
        public uint dwReserved3;// = new uint[11];
        [FieldOffset(40)]
        public uint dwReserved4;// = new uint[11];
        [FieldOffset(44)]
        public uint dwReserved5;// = new uint[11];
        [FieldOffset(48)]
        public uint dwReserved6;// = new uint[11];
        [FieldOffset(52)]
        public uint dwReserved7;// = new uint[11];
        [FieldOffset(56)]
        public uint dwReserved8;// = new uint[11];
        [FieldOffset(60)]
        public uint dwReserved9;// = new uint[11];
        [FieldOffset(64)]
        public uint dwReserved10;// = new uint[11];
        [FieldOffset(68)]
        public uint dwReserved11;// = new uint[11];
        [FieldOffset(72)]
        public DDS_PIXELFORMAT ddspf;
        [FieldOffset(104)]
        public uint dwCaps;
        [FieldOffset(108)]
        public uint dwCaps2;
        [FieldOffset(112)]
        public uint dwCaps3;
        [FieldOffset(116)]
        public uint dwCaps4;
        [FieldOffset(120)]
        public uint dwReserved12;
    }





}
