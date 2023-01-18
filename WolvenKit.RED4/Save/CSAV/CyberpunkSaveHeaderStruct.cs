using System.Runtime.InteropServices;

namespace WolvenKit.RED4.Save;

[StructLayout(LayoutKind.Explicit, Size = 21)]
public struct CyberpunkSaveHeaderStruct
{
    [FieldOffset(0)]
    public uint saveVersion;

    [FieldOffset(4)]
    public uint gameVersion;

    [FieldOffset(8)]
    public byte padding;

    [FieldOffset(9)]
    public ulong timeStamp;

    [FieldOffset(17)]
    public uint archiveVersion;
}
