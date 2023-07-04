using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace WolvenKit.RED4.Types;

[RED("TweakDBID")]
public readonly struct TweakDBID : IRedPrimitive<ulong>, IEquatable<TweakDBID>
{
    public static TweakDBID Empty = 0;

    private readonly ulong _hash;


    private TweakDBID(ulong value) => _hash = value;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public int Length => (int)(_hash >> 32);

    public string? ResolvedText => GetResolvedText();
    public string? GetResolvedText() => TweakDBIDPool.ResolveHash(_hash);
    public bool IsResolvable => TweakDBIDPool.ResolveHash(_hash) != null;

    public bool TryGetResolvedText([NotNullWhen(true)] out string? result)
    {
        result = TweakDBIDPool.ResolveHash(_hash);
        return result != null;
    }

    public static implicit operator TweakDBID(string value) => new(TweakDBIDPool.AddOrGetHash(value));
    public static implicit operator string?(TweakDBID value) => value.GetResolvedText();

    public static implicit operator TweakDBID(ulong value) => new(value);
    public static implicit operator ulong(TweakDBID value) => value._hash;

    public static bool operator ==(TweakDBID a, TweakDBID b) => Equals(a, b);
    public static bool operator !=(TweakDBID a, TweakDBID b) => !(a == b);

    public bool Equals(TweakDBID other) => Equals(_hash, other._hash);

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj))
        {
            return false;
        }

        if (obj.GetType() != GetType())
        {
            return false;
        }

        return Equals((TweakDBID)obj);
    }

    public override int GetHashCode() => _hash.GetHashCode();

    public override string ToString() => $"{GetResolvedText()} <TweakDBID 0x{_hash:X8}:0x{Length:X2} / {_hash}:{Length}>";
}