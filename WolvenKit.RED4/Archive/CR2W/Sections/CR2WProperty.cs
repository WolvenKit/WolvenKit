using System.Runtime.InteropServices;

namespace WolvenKit.RED4.Archive.CR2W;

[StructLayout(LayoutKind.Explicit, Size = 16)]
public struct CR2WPropertyInfo
{
    [FieldOffset(0)]
    public ushort className;

    [FieldOffset(2)]
    public ushort classFlags;

    [FieldOffset(4)]
    public ushort propertyName;

    [FieldOffset(6)]
    public ushort propertyFlags;

    [FieldOffset(8)]
    public ulong hash;
}

public class CR2WProperty : ICR2WProperty
{

}