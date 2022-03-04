using System;
using System.Diagnostics;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.TweakDB.Types;

[RED("gamedataLocKeyWrapper")]
[DebuggerDisplay("{_value,nq}", Type = "LocKey")]
public readonly struct LocKey : IRedPrimitive<LocKey>, IEquatable<LocKey>, IRedInteger
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly ulong _value;

    private LocKey(ulong value)
    {
        _value = value;
    }

    public static implicit operator LocKey(ulong value) => new(value);
    public static implicit operator ulong(LocKey value) => value._value;

    public bool Equals(LocKey other) => _value == other._value;

    public override bool Equals(object obj) => obj is LocKey other && Equals(other);

    public override int GetHashCode() => _value.GetHashCode();

    public static bool operator ==(LocKey left, LocKey right) => left.Equals(right);

    public static bool operator !=(LocKey left, LocKey right) => !left.Equals(right);

    public override string ToString() => $"{_value} <LocKey 0x{_value:X}>";
}
