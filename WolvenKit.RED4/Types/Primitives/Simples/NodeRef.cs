using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using WolvenKit.Common.FNV1A;
using WolvenKit.RED4.Types.Pools;

namespace WolvenKit.RED4.Types;

[RED("NodeRef")]
[DebuggerDisplay("{_hash}", Type = "NodeRef")]
public readonly struct NodeRef : IRedString, IRedPrimitive<NodeRef>, IEquatable<NodeRef>, IComparable<NodeRef>, IComparable
{
    public static NodeRef Empty = 0;

    private readonly ulong _hash;


    private NodeRef(ulong value) => _hash = value;

    public string? GetResolvedText() => NodeRefPool.ResolveHash(_hash);
    public bool IsResolvable => NodeRefPool.ResolveHash(_hash) != null;

    public bool TryGetResolvedText([NotNullWhen(true)] out string? result)
    {
        result = NodeRefPool.ResolveHash(_hash);
        return result != null;
    }

    public static implicit operator NodeRef(string value) => new(NodeRefPool.AddOrGetHash(value));
    public static implicit operator string?(NodeRef value) => value.GetResolvedText();

    public static implicit operator NodeRef(ulong value) => new(value);
    public static implicit operator ulong(NodeRef value) => value._hash;

    public static bool operator ==(NodeRef a, NodeRef b) => Equals(a, b);
    public static bool operator !=(NodeRef a, NodeRef b) => !(a == b);

    public ulong GetRedHash() => _hash;

    public int CompareTo(object? value)
    {
        if (value == null)
        {
            return 1;
        }

        if (!(value is NodeRef other))
        {
            throw new ArgumentException();
        }

        return this.CompareTo(other);
    }

    public int CompareTo(NodeRef other)
    {
        var strA = GetResolvedText();
        var strB = other.GetResolvedText();

        if (strA != null && strB != null)
        {
            return string.Compare(strA, strB, StringComparison.InvariantCulture);
        }

        return _hash.CompareTo(other._hash);
    }

    public override int GetHashCode() => _hash.GetHashCode();

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj))
        {
            return false;
        }

        if (obj.GetType() != this.GetType())
        {
            return false;
        }

        return Equals((NodeRef)obj);
    }

    public bool Equals(NodeRef other)
    {
        if (!Equals(_hash, other._hash))
        {
            return false;
        }

        return true;
    }

    public static ulong CalculateHash(string nodeRef) =>
        FNV1A64HashAlgorithm.HashStringWithoutAliases(nodeRef);

    /// <summary>
    /// Hashes a node ref straight from its UTF-8 bytes, allocating nothing.
    /// </summary>
    public static ulong CalculateHashUtf8(ReadOnlySpan<byte> utf8) =>
        Ascii.IsValid(utf8)
            ? FNV1A64HashAlgorithm.HashStringWithoutAliasesAscii(utf8)
            : CalculateHash(Encoding.UTF8.GetString(utf8));

    public string? GetString() => this;
    public override string ToString() => TryGetResolvedText(out var text) ? text : _hash.ToString();
}
