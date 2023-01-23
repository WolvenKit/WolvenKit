using System.Diagnostics;
using System.Globalization;

namespace WolvenKit.RED4.Types;

[RED("Uint8")]
[DebuggerDisplay("{_value,nq}", Type = "CUInt8")]
public readonly struct CUInt8 : IRedPrimitive<byte>, IEquatable<CUInt8>, IRedInteger
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly byte _value;

    private CUInt8(byte value)
    {
        _value = value;
    }

    public static implicit operator CUInt8(byte value) => new(value);
    public static implicit operator byte(CUInt8 value) => value._value;

    public static CUInt8 operator +(CUInt8 objA, CUInt8 objB) => new((byte)(objA._value + objB._value));
    public static CUInt8 operator -(CUInt8 objA, CUInt8 objB) => new((byte)(objA._value - objB._value));
    public static CUInt8 operator *(CUInt8 objA, CUInt8 objB) => new((byte)(objA._value * objB._value));
    public static CUInt8 operator /(CUInt8 objA, CUInt8 objB) => new((byte)(objA._value / objB._value));


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

        return Equals((CUInt8)obj);
    }

    public bool Equals(CUInt8 other) => Equals(_value, other._value);

    public byte ToByte()
    {
        return _value;
    }

    public override string ToString() => _value.ToString();
    public string ToString(CultureInfo cultureInfo) => _value.ToString(cultureInfo);
}