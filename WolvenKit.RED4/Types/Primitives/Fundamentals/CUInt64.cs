using System.Diagnostics;
using System.Globalization;

namespace WolvenKit.RED4.Types;

[RED("Uint64")]
[DebuggerDisplay("{_value,nq}", Type = "CUInt64")]
public readonly struct CUInt64 : IRedPrimitive<ulong>, IComparable, IComparable<CUInt64>, IEquatable<CUInt64>, IRedInteger
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

        return Equals((CUInt64)obj);
    }

    public bool Equals(CUInt64 other) => Equals(_value, other._value);

    public override string ToString() => _value.ToString();
    public string ToString(CultureInfo cultureInfo) => _value.ToString(cultureInfo);

    #region IComparable, IComparable<CUInt64>

    public int CompareTo(object? value)
    {
        if (value == null)
        {
            return 1;
        }
        if (value is CUInt64 u)
        {
            return CompareTo(u);
        }
        throw new ArgumentException("Value is not a CUInt64", nameof(value));
    }

    public int CompareTo(CUInt64 value)
    {
        if (_value < value)
        {
            return -1;
        }

        if (_value > value)
        {
            return 1;
        }

        return 0;
    }

    #endregion IComparable, IComparable<CUInt64>
}