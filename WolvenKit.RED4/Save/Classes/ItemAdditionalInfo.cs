using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save.Classes;

public class ItemAdditionalInfo : IEquatable<ItemAdditionalInfo>
{
    public TweakDBID LootItemPoolId { get; set; }
    public uint Unknown2 { get; set; }
    public float RequiredLevel { get; set; }

    public bool Equals(ItemAdditionalInfo? other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        return LootItemPoolId.Equals(other.LootItemPoolId) && Unknown2 == other.Unknown2 && RequiredLevel.Equals(other.RequiredLevel);
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

        return Equals((ItemAdditionalInfo)obj);
    }

    public override int GetHashCode() => HashCode.Combine(LootItemPoolId, Unknown2, RequiredLevel);
}