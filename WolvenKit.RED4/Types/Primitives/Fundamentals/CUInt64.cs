using System.Diagnostics;
using System.Globalization;

namespace WolvenKit.RED4.Types;

[RED("Uint64")]
[DebuggerDisplay("{_value,nq}", Type = "CUInt64")]
public readonly struct CUInt64 : IRedPrimitive<ulong>, IEquatable<CUInt64>, IRedInteger
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly ulong _value;

    private CUInt64(ulong value)
    {
        _value = value;
    }

    public static implicit operator CUInt64(ulong value) => new(value);
    public static implicit operator ulong(CUInt64 value) => value._value;

    public static CUInt64 operator +(CUInt64 objA, CUInt64 objB) => new(objA._value + objB._value);
    public static CUInt64 operator -(CUInt64 objA, CUInt64 objB) => new(objA._value - objB._value);
    public static CUInt64 operator *(CUInt64 objA, CUInt64 objB) => new(objA._value * objB._value);
    public static CUInt64 operator /(CUInt64 objA, CUInt64 objB) => new(objA._value / objB._value);


    public override int GetHashCode() => _value.GetHashCode();

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj))
        {
            return false;
        }

        if (obj.GetType() != this.GetType())
        {
            return false;
        }

        return Equals((CUInt64)obj);
    }

    public bool Equals(CUInt64 other) => Equals(_value, other._value);

    public override string ToString() => _value.ToString();
    public string ToString(CultureInfo cultureInfo) => _value.ToString(cultureInfo);
}