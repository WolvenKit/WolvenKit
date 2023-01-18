using System.Runtime.InteropServices;

namespace WolvenKit.RED4.TweakDB;

[StructLayout(LayoutKind.Explicit, Size = 0x20)]
internal struct FileHeader
{
    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct FileOffsets
    {
        [FieldOffset(0x0)]
        public uint Flats;

        [FieldOffset(0x4)]
        public uint Records;

        [FieldOffset(0x8)]
        public uint Queries;

        [FieldOffset(0xC)]
        public uint GroupTags;
    };

    [FieldOffset(0x0)]
    public uint Magic;

    [FieldOffset(0x4)]
    public uint BlobVersion;

    [FieldOffset(0x8)]
    public uint ParserVersion;

    [FieldOffset(0xC)]
    public uint RecordsChecksum;

    [FieldOffset(0x10)]
    public FileOffsets Offsets;
}