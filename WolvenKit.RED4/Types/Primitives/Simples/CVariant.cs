namespace WolvenKit.RED4.Types;

[RED("Variant")]
public class CVariant : IRedPrimitive, IEquatable<CVariant>
{
    public IRedType Value { get; set; }

    public bool Equals(CVariant other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        return Equals(Value, other.Value);
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

        return Equals((CVariant)obj);
    }

    public override int GetHashCode() => (Value != null ? Value.GetHashCode() : 0);
}