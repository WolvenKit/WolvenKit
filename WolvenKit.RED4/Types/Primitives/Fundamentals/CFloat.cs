using System.Diagnostics;
using System.Globalization;

namespace WolvenKit.RED4.Types;

[RED("Float")]
[DebuggerDisplay("{_value,nq}", Type = "CFloat")]
public readonly struct CFloat : IRedPrimitive<float>, IComparable, IComparable<CFloat>, IEquatable<CFloat>, IRedInteger
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly float _value;

    private CFloat(float value)
    {
        _value = value;
    }

    public static implicit operator CFloat(float value) => new(value);
    public static implicit operator float(CFloat value) => value._value;

    public static CFloat operator +(CFloat objA, CFloat objB) => new(objA._value + objB._value);
    public static CFloat operator -(CFloat objA, CFloat objB) => new(objA._value - objB._value);
    public static CFloat operator *(CFloat objA, CFloat objB) => new(objA._value * objB._value);
    public static CFloat operator /(CFloat objA, CFloat objB) => new(objA._value / objB._value);


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

        return Equals((CFloat)obj);
    }

    public bool Equals(CFloat other) => Equals(BitConverter.SingleToInt32Bits(_value), BitConverter.SingleToInt32Bits(other._value));

    public override string ToString() => _value.ToString("G9");
    public string ToString(CultureInfo cultureInfo) => _value.ToString("G9", cultureInfo);

    #region IComparable, IComparable<CFloat>

    public int CompareTo(object? value)
    {
        if (value == null)
        {
            return 1;
        }
        if (value is CFloat f)
        {
            return CompareTo(f);
        }
        throw new ArgumentException("Value is not a CFloat", nameof(value));
    }

    public int CompareTo(CFloat value)
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

        if (float.IsNaN(_value))
        {
            return float.IsNaN(value._value) ? 0 : -1;
        }

        return 1;
    }

    #endregion IComparable, IComparable<CFloat>
}