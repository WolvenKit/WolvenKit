using System.Diagnostics;
using System.Globalization;

namespace WolvenKit.RED4.Types;

[RED("CRUID")]
[DebuggerDisplay("{_value}", Type = "CRUID")]
public readonly struct CRUID : IRedPrimitive<ulong>, IEquatable<CRUID>, IRedInteger
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly ulong _value;

    private CRUID(ulong value)
    {
        _value = value;
    }

    public static implicit operator CRUID(ulong value) => new(value);
    public static implicit operator ulong(CRUID value) => value._value;


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

        return Equals((CRUID)obj);
    }

    public bool Equals(CRUID other) => Equals(_value, other._value);

    public override string ToString() => _value.ToString();
    public string ToString(CultureInfo cultureInfo) => _value.ToString(cultureInfo);
}