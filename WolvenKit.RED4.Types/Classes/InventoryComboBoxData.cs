using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryComboBoxData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("Message")] 
		public CString Message
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("ItemsToDisplay")] 
		public CArray<InventoryItemData> ItemsToDisplay
		{
			get => GetPropertyValue<CArray<InventoryItemData>>();
			set => SetPropertyValue<CArray<InventoryItemData>>(value);
		}

		[Ordinal(2)] 
		[RED("ShowUnequipButton")] 
		public CBool ShowUnequipButton
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("ShowcaseItem")] 
		public InventoryItemData ShowcaseItem
		{
			get => GetPropertyValue<InventoryItemData>();
			set => SetPropertyValue<InventoryItemData>(value);
		}

		[Ordinal(4)] 
		[RED("DisplayShowcase")] 
		public CBool DisplayShowcase
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("ForceDouble")] 
		public CBool ForceDouble
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public InventoryComboBoxData()
		{
			ItemsToDisplay = new();
			ShowcaseItem = new() { Empty = true, ID = new(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, IsAvailable = true, PositionInBackpack = 4294967295, IsRequirementMet = true, IsEquippable = true, Requirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new() { StatType = Enums.gamedataStatType.Invalid }, Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new() };
		}
	}
}
