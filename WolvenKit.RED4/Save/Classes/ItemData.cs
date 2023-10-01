namespace WolvenKit.RED4.Save.Classes;

[Flags]
public enum ItemFlag : byte
{
    IsQuestItem = 1,
    IsNotUnequippable = 2
}

public class ItemData : INodeData, IItemInfoProvider
{
    public ItemInfo ItemInfo { get; set; }
    public ItemFlag Flags { get; set; }
    public uint CreationTime { get; set; }

    public uint Quantity { get; set; } = 1;

    public ItemAdditionalInfo? ItemAdditionalInfo { get; set; }
    public ItemSlotPart? ItemSlotPart { get; set; }

    public bool HasQuantity() =>
        ItemInfo.ItemStructure.HasFlag(ItemStructure.Quantity) ||
        (ItemInfo.ItemStructure == ItemStructure.None && ItemInfo.ItemId.RngSeed == 2);

    public bool HasExtendedData() =>
        ItemInfo.ItemStructure.HasFlag(ItemStructure.Extended) ||
        (ItemInfo.ItemStructure == ItemStructure.None && ItemInfo.ItemId.RngSeed != 2);

    public bool IsQuantityOnly() => HasQuantity() && !HasExtendedData();
    public bool IsExtendedOnly() => !HasQuantity() && HasExtendedData();
}