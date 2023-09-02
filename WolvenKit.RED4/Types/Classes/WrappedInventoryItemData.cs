using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WrappedInventoryItemData : IScriptable
	{
		[Ordinal(0)] 
		[RED("ItemData")] 
		public gameInventoryItemData ItemData
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		[Ordinal(1)] 
		[RED("ComparisonState")] 
		public CEnum<gameItemComparisonState> ComparisonState
		{
			get => GetPropertyValue<CEnum<gameItemComparisonState>>();
			set => SetPropertyValue<CEnum<gameItemComparisonState>>(value);
		}

		[Ordinal(2)] 
		[RED("IsNew")] 
		public CBool IsNew
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("ItemTemplate")] 
		public CUInt32 ItemTemplate
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("DisplayContext")] 
		public CEnum<gameItemDisplayContext> DisplayContext
		{
			get => GetPropertyValue<CEnum<gameItemDisplayContext>>();
			set => SetPropertyValue<CEnum<gameItemDisplayContext>>(value);
		}

		[Ordinal(5)] 
		[RED("NotificationListener")] 
		public CHandle<ImmediateNotificationListener> NotificationListener
		{
			get => GetPropertyValue<CHandle<ImmediateNotificationListener>>();
			set => SetPropertyValue<CHandle<ImmediateNotificationListener>>(value);
		}

		[Ordinal(6)] 
		[RED("Item")] 
		public CHandle<UIInventoryItem> Item
		{
			get => GetPropertyValue<CHandle<UIInventoryItem>>();
			set => SetPropertyValue<CHandle<UIInventoryItem>>(value);
		}

		[Ordinal(7)] 
		[RED("DisplayContextData")] 
		public CWeakHandle<ItemDisplayContextData> DisplayContextData
		{
			get => GetPropertyValue<CWeakHandle<ItemDisplayContextData>>();
			set => SetPropertyValue<CWeakHandle<ItemDisplayContextData>>(value);
		}

		[Ordinal(8)] 
		[RED("OverrideQuantity")] 
		public CInt32 OverrideQuantity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public WrappedInventoryItemData()
		{
			ItemData = new gameInventoryItemData { ID = new gameItemID(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, Empty = true, IsAvailable = true, PositionInBackpack = uint.MaxValue, IsRequirementMet = true, IsEquippable = true, Requirement = new gameSItemStackRequirementData { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new gameSItemStackRequirementData { StatType = Enums.gamedataStatType.Invalid }, EquipRequirements = new(), Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new gameInventoryItemSortData() };
			OverrideQuantity = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
