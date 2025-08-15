using System.Diagnostics;
using System.Globalization;

namespace WolvenKit.RED4.Types;

[RED("Int8")]
[DebuggerDisplay("{_value,nq}", Type = "CInt8")]
public readonly struct CInt8 : IRedPrimitive<sbyte>, IComparable, IComparable<CInt8>, IEquatable<CInt8>, IRedInteger
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly sbyte _value;

    private CInt8(sbyte value)
    {
        _value = value;
    }

    public static implicit operator CInt8(sbyte value) => new(value);
    public static implicit operator sbyte(CInt8 value) => value._value;

    public static CInt8 operator +(CInt8 objA, CInt8 objB) => new((sbyte)(objA._value + objB._value));
    public static CInt8 operator -(CInt8 objA, CInt8 objB) => new((sbyte)(objA._value - objB._value));
    public static CInt8 operator *(CInt8 objA, CInt8 objB) => new((sbyte)(objA._value * objB._value));
    public static CInt8 operator /(CInt8 objA, CInt8 objB) => new((sbyte)(objA._value / objB._value));


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

        return Equals((CInt8)obj);
    }

    public bool Equals(CInt8 other) => Equals(_value, other._value);

    public override string ToString() => _value.ToString();
    public string ToString(CultureInfo cultureInfo) => _value.ToString(cultureInfo);

    #region IComparable, IComparable<CInt8>

    public int CompareTo(object? value)
    {
        if (value == null)
        {
            return 1;
        }
        if (value is CInt8 i)
        {
            return CompareTo(i);
        }
        throw new ArgumentException("Value is not a CInt8", nameof(value));
    }

    public int CompareTo(CInt8 value) => _value - value._value;

    #endregion IComparable, IComparable<CInt8>
}