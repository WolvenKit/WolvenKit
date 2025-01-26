using System.Diagnostics;
using System.Globalization;

namespace WolvenKit.RED4.Types;

[RED("Double")]
[DebuggerDisplay("{_value,nq}", Type = "CDouble")]
public readonly struct CDouble : IRedPrimitive<double>, IComparable, IComparable<CDouble>, IEquatable<CDouble>, IRedInteger
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly double _value;

    private CDouble(double value)
    {
        _value = value;
    }

    public static implicit operator CDouble(double value) => new(value);
    public static implicit operator double(CDouble value) => value._value;

    public static CDouble operator +(CDouble objA, CDouble objB) => new(objA._value + objB._value);
    public static CDouble operator -(CDouble objA, CDouble objB) => new(objA._value + objB._value);
    public static CDouble operator *(CDouble objA, CDouble objB) => new(objA._value + objB._value);
    public static CDouble operator /(CDouble objA, CDouble objB) => new(objA._value + objB._value);


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

        return Equals((CDouble)obj);
    }

    public bool Equals(CDouble other) => Equals(_value, other._value);

    public override string ToString() => _value.ToString("G17");
    public string ToString(CultureInfo cultureInfo) => _value.ToString("G17", cultureInfo);

    #region IComparable, IComparable<CDouble>

    public int CompareTo(object? value)
    {
        if (value == null)
        {
            return 1;
        }
        if (value is CDouble d)
        {
            return CompareTo(d);
        }
        throw new ArgumentException("Value is not a CDouble", nameof(value));
    }

    public int CompareTo(CDouble value)
    {
        if (_value < value)
        {
            return -1;
        }

        if (_value > value)
        {
            return 1;
        }

        if (_value == value._value)
        {
            return 0;
        }

        if (double.IsNaN(_value))
        {
            return double.IsNaN(value._value) ? 0 : -1;
        }

        return 1;
    }

    #endregion
}