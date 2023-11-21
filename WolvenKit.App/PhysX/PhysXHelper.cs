using System.IO;

namespace WolvenKit.App.PhysX;

public class PhysXHeader
{
    public PhysXHeader(string type1, string type2, bool mismatch, uint version)
    {
        Type1 = type1;
        Type2 = type2;
        Mismatch = mismatch;
        Version = version;
    }

    public string Type1 { get; }
    public string Type2 { get; }
    public bool Mismatch { get; }
    public uint Version { get; }
}

public static class PhysXHelper
{
    public static PhysXHeader ReadHeader(BinaryReader br)
    {
        var type1 = new string(br.ReadChars(3));
        var mismatch = (br.ReadByte() & 1) != 1; // endianness
        var type2 = new string(br.ReadChars(4));
        var version = br.ReadUInt32();

        return new PhysXHeader(type1, type2, mismatch, version);
    }
}