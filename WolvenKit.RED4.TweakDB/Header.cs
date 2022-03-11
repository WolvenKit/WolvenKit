using System.Runtime.InteropServices;

namespace WolvenKit.RED4.TweakDB;

[StructLayout(LayoutKind.Explicit, Size = 28)]
public struct Header
{
    [FieldOffset(0)]
    public int blobVersion;

    [FieldOffset(4)]
    public int parserVersion;

    [FieldOffset(8)]
    public uint recordChecksum;

    [FieldOffset(12)]
    public int flatsOffset;

    [FieldOffset(16)]
    public int recordsOffset;

    [FieldOffset(20)]
    public int queriesOffset;

    [FieldOffset(24)]
    public int groupTagsOffset;
}
