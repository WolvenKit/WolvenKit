using System.Runtime.InteropServices;

namespace WolvenKit.RED4.Archive.CR2W
{
    #region Header Structs

    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public struct CR2WFileHeader
    {
        [FieldOffset(0)]
        public uint version;

        [FieldOffset(4)]
        public uint flags;

        [FieldOffset(8)]
        public ulong timeStamp;

        [FieldOffset(16)]
        public uint buildVersion;

        [FieldOffset(20)]
        public uint objectsEnd;

        [FieldOffset(24)]
        public uint buffersEnd;

        [FieldOffset(28)]
        public uint crc32;

        [FieldOffset(32)]
        public uint numChunks;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct CR2WTable
    {
        [FieldOffset(0)]
        public uint offset;

        [FieldOffset(4)]
        public uint itemCount;

        [FieldOffset(8)]
        public uint crc32;
    }

    #endregion Header Structs
}
