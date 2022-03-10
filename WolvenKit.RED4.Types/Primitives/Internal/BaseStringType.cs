using System;
using System.Diagnostics;

namespace WolvenKit.RED4.Types;

public class BaseStringType : IRedPrimitive<string>, IEquatable<BaseStringType>, IComparable<BaseStringType>, IComparable
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    protected readonly string _value;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public int Length => _value.Length;

    internal BaseStringType() { }
    protected BaseStringType(string value)
    {
        _value = value;
    }

    public static implicit operator BaseStringType(string value) => new(value);
    public static implicit operator string(BaseStringType value) => value._value;

    public int CompareTo(object value)
    {
        if (value == null)
        {
            return 1;
        }

        if (!(value is BaseStringType other))
        {
            throw new ArgumentException();
        }

        return _value.CompareTo(other);
    }

    public int CompareTo(BaseStringType other) => string.Compare(_value, other);
    public bool Equals(BaseStringType other) => string.Equals(_value, other?._value);
}
