using System.Runtime.InteropServices;

namespace WolvenKit.Common.Tools.DDS
{
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct DDS_HEADER_DXT10
    {
        [FieldOffset(0)]
        public DXGI_FORMAT dxgiFormat;
        [FieldOffset(4)]
        public D3D10_RESOURCE_DIMENSION resourceDimension;
        [FieldOffset(8)]
        public uint miscFlag;
        [FieldOffset(12)]
        public uint arraySize;
        [FieldOffset(16)]
        public uint miscFlags2;
    }








}
