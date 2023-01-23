using System.Runtime.InteropServices;

namespace WolvenKit.RED4.Archive.Buffer;

[StructLayout(LayoutKind.Explicit, Size = 60)]
public struct TilesBufferHeader
{
    [FieldOffset(0)]
    public uint vand;

    [FieldOffset(4)]
    public uint uk1;

    [FieldOffset(8)]
    public uint tileX;

    [FieldOffset(12)]
    public uint tileY;

    [FieldOffset(16)]
    public uint uk2;

    [FieldOffset(20)]
    public uint uk3;

    [FieldOffset(24)]
    public uint count1;

    [FieldOffset(28)]
    public uint count2;

    [FieldOffset(32)]
    public uint count3;

    [FieldOffset(36)]
    public uint count4;

    [FieldOffset(40)]
    public uint count5;

    [FieldOffset(44)]
    public uint count6;

    [FieldOffset(48)]
    public uint count7;

    [FieldOffset(52)]
    public uint count8;

    [FieldOffset(56)]
    public uint count9;

}