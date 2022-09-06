using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuantityPickerPopupCloseData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("choosenQuantity")] 
		public CInt32 ChoosenQuantity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(8)] 
		[RED("itemData")] 
		public gameInventoryItemData ItemData
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
		[RED("isBuyback")] 
		public CBool IsBuyback
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public QuantityPickerPopupCloseData()
		{
			ItemData = new() { ID = new(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, Empty = true, IsAvailable = true, PositionInBackpack = 4294967295, IsRequirementMet = true, IsEquippable = true, Requirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirements = new(), Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
