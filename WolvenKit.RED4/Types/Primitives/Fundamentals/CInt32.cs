using System.Diagnostics;
using System.Globalization;

namespace WolvenKit.RED4.Types;

[RED("Int32")]
[DebuggerDisplay("{_value,nq}", Type = "CInt32")]
public readonly struct CInt32 : IRedPrimitive<int>, IEquatable<CInt32>, IRedInteger
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
}