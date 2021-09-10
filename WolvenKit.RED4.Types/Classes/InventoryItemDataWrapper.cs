using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryItemDataWrapper : IScriptable
	{
		[Ordinal(0)] 
		[RED("ItemData")] 
		public InventoryItemData ItemData
		{
			get => GetPropertyValue<InventoryItemData>();
			set => SetPropertyValue<InventoryItemData>(value);
		}

		[Ordinal(1)] 
		[RED("SortData")] 
		public InventoryItemSortData SortData
		{
			get => GetPropertyValue<InventoryItemSortData>();
			set => SetPropertyValue<InventoryItemSortData>(value);
		}

		[Ordinal(2)] 
		[RED("HasSortDataBuilt")] 
		public CBool HasSortDataBuilt
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public InventoryItemDataWrapper()
		{
			ItemData = new() { Empty = true, ID = new(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, IsAvailable = true, PositionInBackpack = 4294967295, IsRequirementMet = true, IsEquippable = true, Requirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new() { StatType = Enums.gamedataStatType.Invalid }, Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new() };
			SortData = new();
		}
	}
}
