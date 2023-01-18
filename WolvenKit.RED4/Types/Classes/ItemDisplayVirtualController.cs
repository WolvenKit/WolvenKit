using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemDisplayVirtualController : inkVirtualCompoundItemController
	{
		[Ordinal(15)] 
		[RED("itemDisplayWidget")] 
		public inkWidgetReference ItemDisplayWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("widgetToSpawn")] 
		public CName WidgetToSpawn
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("wrappedData")] 
		public CHandle<WrappedInventoryItemData> WrappedData
		{
			get => GetPropertyValue<CHandle<WrappedInventoryItemData>>();
			set => SetPropertyValue<CHandle<WrappedInventoryItemData>>(value);
		}

		[Ordinal(18)] 
		[RED("data")] 
		public gameInventoryItemData Data
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		[Ordinal(19)] 
		[RED("spawnedWidget")] 
		public CWeakHandle<inkWidget> SpawnedWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(20)] 
		[RED("notificationListenerID")] 
		public CInt32 NotificationListenerID
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(21)] 
		[RED("immediateNotificationListener")] 
		public CWeakHandle<ImmediateNotificationListener> ImmediateNotificationListener
		{
			get => GetPropertyValue<CWeakHandle<ImmediateNotificationListener>>();
			set => SetPropertyValue<CWeakHandle<ImmediateNotificationListener>>(value);
		}

		public ItemDisplayVirtualController()
		{
			ItemDisplayWidget = new();
			Data = new() { ID = new(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, Empty = true, IsAvailable = true, PositionInBackpack = 4294967295, IsRequirementMet = true, IsEquippable = true, Requirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirements = new(), Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
