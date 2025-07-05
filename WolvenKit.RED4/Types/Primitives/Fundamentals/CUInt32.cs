using System.Diagnostics;
using System.Globalization;

namespace WolvenKit.RED4.Types;

[RED("Uint32")]
[DebuggerDisplay("{_value,nq}", Type = "CUInt32")]
public readonly struct CUInt32 : IRedPrimitive<uint>, IComparable, IComparable<CUInt32>, IEquatable<CUInt32>, IRedInteger
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly uint _value;

    private CUInt32(uint value)
    {
        _value = value;
    }

    public static implicit operator CUInt32(uint value) => new(value);
    public static implicit operator uint(CUInt32 value) => value._value;

    public static CUInt32 operator +(CUInt32 objA, CUInt32 objB) => new(objA._value + objB._value);
    public static CUInt32 operator -(CUInt32 objA, CUInt32 objB) => new(objA._value - objB._value);
    public static CUInt32 operator *(CUInt32 objA, CUInt32 objB) => new(objA._value * objB._value);
    public static CUInt32 operator /(CUInt32 objA, CUInt32 objB) => new(objA._value / objB._value);


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

        return Equals((CUInt32)obj);
    }

    public bool Equals(CUInt32 other) => Equals(_value, other._value);

    public override string ToString() => _value.ToString();
    public string ToString(CultureInfo cultureInfo) => _value.ToString(cultureInfo);

    #region IComparable, IComparable<CUInt32>

    public int CompareTo(object? value)
    {
        if (value == null)
        {
            return 1;
        }
        if (value is CUInt32 i)
        {
            return CompareTo(i);
        }
        throw new ArgumentException("Value is not a CUInt32", nameof(value));
    }

    public int CompareTo(CUInt32 value)
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

    #endregion IComparable, IComparable<CUInt32>
}