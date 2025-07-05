using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemDisplayHoldEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("itemData")] 
		public gameInventoryItemData ItemData
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		[Ordinal(1)] 
		[RED("display")] 
		public CWeakHandle<InventoryItemDisplayController> Display
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemDisplayController>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemDisplayController>>(value);
		}

		[Ordinal(2)] 
		[RED("uiInventoryItem")] 
		public CHandle<UIInventoryItem> UiInventoryItem
		{
			get => GetPropertyValue<CHandle<UIInventoryItem>>();
			set => SetPropertyValue<CHandle<UIInventoryItem>>(value);
		}

		[Ordinal(3)] 
		[RED("displayContextData")] 
		public CWeakHandle<ItemDisplayContextData> DisplayContextData
		{
			get => GetPropertyValue<CWeakHandle<ItemDisplayContextData>>();
			set => SetPropertyValue<CWeakHandle<ItemDisplayContextData>>(value);
		}

		[Ordinal(4)] 
		[RED("actionName")] 
		public CHandle<inkActionName> ActionName
		{
			get => GetPropertyValue<CHandle<inkActionName>>();
			set => SetPropertyValue<CHandle<inkActionName>>(value);
		}

		public ItemDisplayHoldEvent()
		{
			ItemData = new gameInventoryItemData { ID = new gameItemID(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, Empty = true, IsAvailable = true, PositionInBackpack = uint.MaxValue, IsRequirementMet = true, IsEquippable = true, Requirement = new gameSItemStackRequirementData { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new gameSItemStackRequirementData { StatType = Enums.gamedataStatType.Invalid }, EquipRequirements = new(), Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new gameInventoryItemSortData() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
