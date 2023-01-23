using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemDisplayClickEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("itemData")] 
		public gameInventoryItemData ItemData
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		[Ordinal(1)] 
		[RED("displayContext")] 
		public CEnum<gameItemDisplayContext> DisplayContext
		{
			get => GetPropertyValue<CEnum<gameItemDisplayContext>>();
			set => SetPropertyValue<CEnum<gameItemDisplayContext>>(value);
		}

		[Ordinal(2)] 
		[RED("display")] 
		public CWeakHandle<InventoryItemDisplayController> Display
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemDisplayController>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemDisplayController>>(value);
		}

		[Ordinal(3)] 
		[RED("isBuybackStack")] 
		public CBool IsBuybackStack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("toggleVisibilityRequest")] 
		public CBool ToggleVisibilityRequest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("transmogItem")] 
		public gameItemID TransmogItem
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(6)] 
		[RED("uiInventoryItem")] 
		public CHandle<UIInventoryItem> UiInventoryItem
		{
			get => GetPropertyValue<CHandle<UIInventoryItem>>();
			set => SetPropertyValue<CHandle<UIInventoryItem>>(value);
		}

		[Ordinal(7)] 
		[RED("displayContextData")] 
		public CWeakHandle<ItemDisplayContextData> DisplayContextData
		{
			get => GetPropertyValue<CWeakHandle<ItemDisplayContextData>>();
			set => SetPropertyValue<CWeakHandle<ItemDisplayContextData>>(value);
		}

		[Ordinal(8)] 
		[RED("evt")] 
		public CHandle<inkPointerEvent> Evt
		{
			get => GetPropertyValue<CHandle<inkPointerEvent>>();
			set => SetPropertyValue<CHandle<inkPointerEvent>>(value);
		}

		[Ordinal(9)] 
		[RED("actionName")] 
		public CHandle<inkActionName> ActionName
		{
			get => GetPropertyValue<CHandle<inkActionName>>();
			set => SetPropertyValue<CHandle<inkActionName>>(value);
		}

		public ItemDisplayClickEvent()
		{
			ItemData = new() { ID = new(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, Empty = true, IsAvailable = true, PositionInBackpack = 4294967295, IsRequirementMet = true, IsEquippable = true, Requirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirements = new(), Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new() };
			TransmogItem = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
