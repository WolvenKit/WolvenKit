using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.DDS
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
