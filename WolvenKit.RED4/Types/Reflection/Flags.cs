namespace WolvenKit.RED4.Types;

public class Flags : IEquatable<Flags>
{
    public static readonly Flags Empty = new(Array.Empty<int>());

    private int[] _value;
    private int _index = -1;

    public Flags(int[] value)
    {
        _value = value;
    }

    public Flags(int[] value, int index)
    {
        _value = value;
        _index = index;
    }

    public int Current => _value[_index];

    public bool MoveNext()
    {
        if (_index + 1 >= _value.Length)
        {
            return false;
        }

        _index++;
        return true;
    }

    public Flags Clone() => new(_value.ToArray(), _index);

    public bool Equals(Flags other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        return _value.SequenceEqual(other._value) && _index == other._index;
    }

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

        return Equals((Flags)obj);
    }

    public override int GetHashCode()
    {
        var ha = _value.Aggregate(_value.Length, (current, val) => unchecked(current * 314159 + val));
        return HashCode.Combine(ha, _index);
    }
}