using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryItemDataWrapper : IScriptable
	{
		[Ordinal(0)] 
		[RED("ItemData")] 
		public gameInventoryItemData ItemData
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		[Ordinal(1)] 
		[RED("SortData")] 
		public gameInventoryItemSortData SortData
		{
			get => GetPropertyValue<gameInventoryItemSortData>();
			set => SetPropertyValue<gameInventoryItemSortData>(value);
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
			ItemData = new gameInventoryItemData { ID = new gameItemID(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, Empty = true, IsAvailable = true, PositionInBackpack = uint.MaxValue, IsRequirementMet = true, IsEquippable = true, Requirement = new gameSItemStackRequirementData { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new gameSItemStackRequirementData { StatType = Enums.gamedataStatType.Invalid }, EquipRequirements = new(), Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new gameInventoryItemSortData() };
			SortData = new gameInventoryItemSortData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
