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
		[RED("uiInventoryItem")] 
		public CHandle<UIInventoryItem> UiInventoryItem
		{
			get => GetPropertyValue<CHandle<UIInventoryItem>>();
			set => SetPropertyValue<CHandle<UIInventoryItem>>(value);
		}

		[Ordinal(2)] 
		[RED("displayContextData")] 
		public CWeakHandle<ItemDisplayContextData> DisplayContextData
		{
			get => GetPropertyValue<CWeakHandle<ItemDisplayContextData>>();
			set => SetPropertyValue<CWeakHandle<ItemDisplayContextData>>(value);
		}

		[Ordinal(3)] 
		[RED("actionName")] 
		public CHandle<inkActionName> ActionName
		{
			get => GetPropertyValue<CHandle<inkActionName>>();
			set => SetPropertyValue<CHandle<inkActionName>>(value);
		}

		public ItemDisplayHoldEvent()
		{
			ItemData = new() { ID = new(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, Empty = true, IsAvailable = true, PositionInBackpack = 4294967295, IsRequirementMet = true, IsEquippable = true, Requirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirements = new(), Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
