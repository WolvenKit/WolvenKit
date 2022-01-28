using System;

namespace WolvenKit.RED4.Types;

public sealed class CKeyValuePair : IRedType, IEquatable<CKeyValuePair>
{
    public CKeyValuePair(CName key, IRedType value)
    {
        Key = key;
        Value = value;
    }

    public CName Key { get; set; }
    public IRedType Value { get; set; }

    public bool Equals(CKeyValuePair other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        if (!Equals(Key, other.Key))
        {
            return false;
        }

        if (!Equals(Value, other.Value))
        {
            return false;
        }

        return true;
    }

    public override bool Equals(object obj)
    {
        if (obj is CKeyValuePair cObj)
        {
            return Equals(cObj);
        }

        return false;
    }

    public override int GetHashCode() => HashCode.Combine(Key, Value);
}
