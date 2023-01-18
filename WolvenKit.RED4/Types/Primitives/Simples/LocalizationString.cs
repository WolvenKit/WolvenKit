namespace WolvenKit.RED4.Types;

public class LocalizationString : IRedPrimitive, IEquatable<LocalizationString>
{
    public ulong Unk1 { get; set; }
    public string Value { get; set; }

    public bool Equals(LocalizationString other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        return Unk1 == other.Unk1 && Value == other.Value;
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

        return Equals((LocalizationString)obj);
    }

    public override int GetHashCode() => HashCode.Combine(Unk1, Value);
}