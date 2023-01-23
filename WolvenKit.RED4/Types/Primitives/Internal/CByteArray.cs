using System.Diagnostics;

namespace WolvenKit.RED4.Types;

[DebuggerDisplay("{_value,nq}", Type = "CByteArray")]
public sealed class CByteArray : IRedPrimitive<byte[]>, IEquatable<CByteArray>
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly byte[] _value;

    public CByteArray()
    {
        _value = Array.Empty<byte>();
    }

    private CByteArray(byte[] data)
    {
        _value = data;
    }

    public static implicit operator CByteArray(byte[] value) => new(value);
    public static implicit operator byte[](CByteArray value) => value._value;

    public bool Equals(CByteArray other) => Equals(_value.Length, other._value.Length) && _value.SequenceEqual(other._value);

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj))
        {
            return false;
        }

        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (obj.GetType() != this.GetType())
        {
            return false;
        }

        return Equals((CByteArray)obj);
    }

    public override int GetHashCode() => (_value != null ? _value.GetHashCode() : 0);
}