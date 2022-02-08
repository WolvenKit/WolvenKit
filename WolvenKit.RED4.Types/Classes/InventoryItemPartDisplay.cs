using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryItemPartDisplay : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("PartIconImage")] 
		public inkImageWidgetReference PartIconImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("Rarity")] 
		public inkWidgetReference Rarity
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("TexturePartName")] 
		public CName TexturePartName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("attachmentData")] 
		public InventoryItemAttachments AttachmentData
		{
			get => GetPropertyValue<InventoryItemAttachments>();
			set => SetPropertyValue<InventoryItemAttachments>(value);
		}

		public InventoryItemPartDisplay()
		{
			PartIconImage = new();
			Rarity = new();
			AttachmentData = new() { ItemData = new() { Empty = true, ID = new(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, IsAvailable = true, PositionInBackpack = 4294967295, IsRequirementMet = true, IsEquippable = true, Requirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new() { StatType = Enums.gamedataStatType.Invalid }, Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new() } };
		}
	}
}
