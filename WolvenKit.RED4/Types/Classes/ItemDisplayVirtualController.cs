using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemDisplayVirtualController : inkVirtualCompoundItemController
	{
		[Ordinal(18)] 
		[RED("itemDisplayWidget")] 
		public inkWidgetReference ItemDisplayWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("widgetToSpawn")] 
		public CName WidgetToSpawn
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(20)] 
		[RED("wrappedData")] 
		public CHandle<WrappedInventoryItemData> WrappedData
		{
			get => GetPropertyValue<CHandle<WrappedInventoryItemData>>();
			set => SetPropertyValue<CHandle<WrappedInventoryItemData>>(value);
		}

		[Ordinal(21)] 
		[RED("data")] 
		public gameInventoryItemData Data
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		[Ordinal(22)] 
		[RED("spawnedWidget")] 
		public CWeakHandle<inkWidget> SpawnedWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(23)] 
		[RED("notificationListenerID")] 
		public CInt32 NotificationListenerID
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(24)] 
		[RED("immediateNotificationListener")] 
		public CWeakHandle<ImmediateNotificationListener> ImmediateNotificationListener
		{
			get => GetPropertyValue<CWeakHandle<ImmediateNotificationListener>>();
			set => SetPropertyValue<CWeakHandle<ImmediateNotificationListener>>(value);
		}

		public ItemDisplayVirtualController()
		{
			ItemDisplayWidget = new inkWidgetReference();
			Data = new gameInventoryItemData { ID = new gameItemID(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, Empty = true, IsAvailable = true, PositionInBackpack = uint.MaxValue, IsRequirementMet = true, IsEquippable = true, Requirement = new gameSItemStackRequirementData { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new gameSItemStackRequirementData { StatType = Enums.gamedataStatType.Invalid }, EquipRequirements = new(), Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new gameInventoryItemSortData() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
