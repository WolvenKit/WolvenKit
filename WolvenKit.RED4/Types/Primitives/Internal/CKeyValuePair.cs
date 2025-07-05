namespace WolvenKit.RED4.Types;

public sealed class CKeyValuePair : IRedType, IEquatable<CKeyValuePair>, IRedCloneable
{
    public CKeyValuePair(CName key, IRedType value)
    {
        Key = key;
        Value = value;
    }

    public CName Key { get; set; }
    public IRedType Value { get; set; }

    public bool Equals(CKeyValuePair? other)
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

    public override bool Equals(object? obj)
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

        return Equals((CKeyValuePair)obj);
    }

    public override int GetHashCode() => HashCode.Combine(Key, Value);

    public object ShallowCopy()
    {
        return MemberwiseClone();
    }

    public object DeepCopy()
    {
        IRedType otherValue;
        if (Value is IRedCloneable cl)
        {
            otherValue = (IRedType)cl.DeepCopy();
        }
        else
        {
            otherValue = Value;
        }
        return new CKeyValuePair(Key, otherValue);

    }
}
