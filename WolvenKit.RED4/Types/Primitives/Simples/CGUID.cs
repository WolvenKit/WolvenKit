using System.Diagnostics;

namespace WolvenKit.RED4.Types;

[RED("CGUID")]
[DebuggerDisplay("{_value,nq}", Type = "CGuid")]
public readonly struct CGuid : IRedPrimitive<Guid>, IEquatable<CGuid>
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly Guid _value;

    private CGuid(byte[] value)
    {
        _value = new(value);
    }

    private CGuid(Guid value)
    {
        _value = value;
    }

    public static implicit operator CGuid(byte[] value) => new(value);
    public static implicit operator byte[](CGuid value) => value._value.ToByteArray();


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

        return Equals((CGuid)obj);
    }

    public bool Equals(CGuid other) => Equals(_value, other._value);
}