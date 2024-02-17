using System.Runtime.InteropServices;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.CR2W;

[StructLayout(LayoutKind.Explicit, Size = 16)]
public struct CR2WEmbeddedInfo
{
    [FieldOffset(0)]
    public uint importIndex;

    [FieldOffset(4)]
    public uint chunkIndex;

    [FieldOffset(8)]
    public ulong pathHash;
}

public class CR2WEmbedded : ICR2WEmbeddedFile, IEquatable<CR2WEmbedded>
{
    public ResourcePath FileName { get; set; }
    public RedBaseClass Content { get; set; }

    public bool Equals(CR2WEmbedded? other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        if (!Equals(FileName, other.FileName))
        {
            return false;
        }

        if (!Equals(Content, other.Content))
        {
            return false;
        }

        return true;
    }

    public override bool Equals(object? obj)
    {
        if (obj is CR2WEmbedded cObj)
        {
            return Equals(cObj);
        }

        return false;
    }

    public override int GetHashCode() => HashCode.Combine(FileName, Content);
}