using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		public InventoryItemData Data
		{
			get => GetPropertyValue<InventoryItemData>();
			set => SetPropertyValue<InventoryItemData>(value);
		}

		[Ordinal(19)] 
		[RED("spawnedWidget")] 
		public CWeakHandle<inkWidget> SpawnedWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public ItemDisplayVirtualController()
		{
			ItemDisplayWidget = new();
			Data = new() { Empty = true, ID = new(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, IsAvailable = true, PositionInBackpack = 4294967295, IsRequirementMet = true, IsEquippable = true, Requirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new() { StatType = Enums.gamedataStatType.Invalid }, Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new() };
		}
	}
}
