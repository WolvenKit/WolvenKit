using System.Diagnostics;
using System.Globalization;

namespace WolvenKit.RED4.Types;

[RED("Int32")]
[DebuggerDisplay("{_value,nq}", Type = "CInt32")]
public readonly struct CInt32 : IRedPrimitive<int>, IComparable, IComparable<CInt32>, IEquatable<CInt32>, IRedInteger
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly int _value;

    private CInt32(int value)
    {
        _value = value;
    }

    public static implicit operator CInt32(int value) => new(value);
    public static implicit operator int(CInt32 value) => value._value;

    public static CInt32 operator +(CInt32 objA, CInt32 objB) => new(objA._value + objB._value);
    public static CInt32 operator -(CInt32 objA, CInt32 objB) => new(objA._value - objB._value);
    public static CInt32 operator *(CInt32 objA, CInt32 objB) => new(objA._value * objB._value);
    public static CInt32 operator /(CInt32 objA, CInt32 objB) => new(objA._value / objB._value);


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

        return Equals((CInt32)obj);
    }

    public bool Equals(CInt32 other) => Equals(_value, other._value);

    public override string ToString() => _value.ToString();
    public string ToString(CultureInfo cultureInfo) => _value.ToString(cultureInfo);

    #region IComparable, IComparable<CInt32>

    public int CompareTo(object? value)
    {
        if (value == null)
        {
            return 1;
        }
        if (value is CInt32 i)
        {
            return CompareTo(i);
        }
        throw new ArgumentException("Value is not a CInt32", nameof(value));
    }

    public int CompareTo(CInt32 value)
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

    #endregion IComparable, IComparable<CInt32>
}