using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save.Classes;

[Flags]
public enum ItemStructure : byte
{
    None     = 0,
    Extended = 1,
    Quantity = 2
}

public class ItemInfo : IEquatable<ItemInfo>
{
    public gameItemID ItemId { get; set; }
    public ItemStructure ItemStructure { get; set; }

    public byte Kind =>
        (byte)ItemStructure switch
        {
            1 => 2,
            2 => 1,
            3 => 0,
            _ => (byte)(ItemId.RngSeed != 2 ? 2 : 1)
        };

    public bool Equals(ItemInfo? other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        return ItemId.Equals(other.ItemId) && ItemStructure == other.ItemStructure;
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

        return Equals((ItemInfo)obj);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = ItemId.GetHashCode();
            hashCode = (hashCode * 397) ^ ItemStructure.GetHashCode();
            return hashCode;
        }
    }

    public static bool operator ==(ItemInfo? left, ItemInfo? right) => Equals(left, right);

    public static bool operator !=(ItemInfo? left, ItemInfo? right) => !Equals(left, right);
}