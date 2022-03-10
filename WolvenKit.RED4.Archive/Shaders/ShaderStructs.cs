using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.RED4.Archive.Shaders
{
    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public struct ShaderCacheFooter
    {
        [FieldOffset(0)]
        public uint shaderCount;

        [FieldOffset(4)]
        public uint extraCount;

        [FieldOffset(8)]
        public uint notherCount;

        [FieldOffset(12)]
        public uint uk1;

        [FieldOffset(16)]
        public uint uk2;

        [FieldOffset(20)]
        public uint uk3;

        [FieldOffset(24)]
        public uint onemorePostfix;

        [FieldOffset(28)]
        public uint struct2Count;

        [FieldOffset(32)]
        public ulong shadersSize;

        [FieldOffset(40)]
        public ulong extrasSize;

        [FieldOffset(48)]
        public ulong notherSize;

        [FieldOffset(56)]
        public ulong struct2Size;

        [FieldOffset(64)]
        public ulong onemoreSize;

        [FieldOffset(72)]
        public ulong extraOffset;

        [FieldOffset(80)]
        public ulong notherOffset;

        [FieldOffset(88)]
        public ulong onemoreOffset;

        [FieldOffset(96)]
        public ulong struct2Offset;

        [FieldOffset(104)]
        public uint rdhs;

        [FieldOffset(108)]
        public uint ten;
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct ShaderCacheShader
    {
        [FieldOffset(0)]
        public ulong GUID;

        [FieldOffset(8)]
        public ulong paramsGUID;

        [FieldOffset(16)]
        public uint shaderSize;

    }
}
