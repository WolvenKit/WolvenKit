using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuantityPickerPopupData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("maxValue")] 
		public CInt32 MaxValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(8)] 
		[RED("gameItemData")] 
		public gameInventoryItemData GameItemData
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		[Ordinal(9)] 
		[RED("inventoryItem")] 
		public CWeakHandle<UIInventoryItem> InventoryItem
		{
			get => GetPropertyValue<CWeakHandle<UIInventoryItem>>();
			set => SetPropertyValue<CWeakHandle<UIInventoryItem>>(value);
		}

		[Ordinal(10)] 
		[RED("actionType")] 
		public CEnum<QuantityPickerActionType> ActionType
		{
			get => GetPropertyValue<CEnum<QuantityPickerActionType>>();
			set => SetPropertyValue<CEnum<QuantityPickerActionType>>(value);
		}

		[Ordinal(11)] 
		[RED("vendor")] 
		public CWeakHandle<gameObject> Vendor
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(12)] 
		[RED("isBuyback")] 
		public CBool IsBuyback
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("sendQuantityChangedEvent")] 
		public CBool SendQuantityChangedEvent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public QuantityPickerPopupData()
		{
			GameItemData = new() { ID = new(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, Empty = true, IsAvailable = true, PositionInBackpack = 4294967295, IsRequirementMet = true, IsEquippable = true, Requirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirements = new(), Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
