using System.Diagnostics;
using System.Globalization;

namespace WolvenKit.RED4.Types;

[RED("Int64")]
[DebuggerDisplay("{_value,nq}", Type = "CInt64")]
public readonly struct CInt64 : IRedPrimitive<long>, IComparable, IComparable<CInt64>, IEquatable<CInt64>, IRedInteger
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly long _value;

    private CInt64(long value)
    {
        _value = value;
    }

    public static implicit operator CInt64(long value) => new(value);
    public static implicit operator long(CInt64 value) => value._value;

    public static CInt64 operator +(CInt64 objA, CInt64 objB) => new(objA._value + objB._value);
    public static CInt64 operator -(CInt64 objA, CInt64 objB) => new(objA._value - objB._value);
    public static CInt64 operator *(CInt64 objA, CInt64 objB) => new(objA._value * objB._value);
    public static CInt64 operator /(CInt64 objA, CInt64 objB) => new(objA._value / objB._value);


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

        return Equals((CInt64)obj);
    }

    public bool Equals(CInt64 other) => Equals(_value, other._value);

    public override string ToString() => _value.ToString();
    public string ToString(CultureInfo cultureInfo) => _value.ToString(cultureInfo);

    #region IComparable, IComparable<CInt64>

    public int CompareTo(object? value)
    {
        if (value == null)
        {
            return 1;
        }
        if (value is CInt64 i)
        {
            return CompareTo(i);
        }
        throw new ArgumentException("Value is not a CInt64", nameof(value));
    }

    public int CompareTo(CInt64 value)
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

    #endregion IComparable, IComparable<CInt64>
}