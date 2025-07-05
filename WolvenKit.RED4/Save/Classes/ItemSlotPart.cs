using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save.Classes;

public class ItemSlotPart : IItemInfoProvider
{
    public ItemInfo ItemInfo { get; set; }
    public string AppearanceName { get; set; }
    public TweakDBID AttachmentSlotTdbId { get; set; }
    public List<ItemSlotPart> Children { get; set; } = new();
    public uint Unknown2 { get; set; }
    public ItemAdditionalInfo ItemAdditionalInfo { get; set; }
}