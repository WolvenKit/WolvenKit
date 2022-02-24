using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DpadWheelItemController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("selectorWrapper")] 
		public inkWidgetReference SelectorWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("displayWrapper")] 
		public inkWidgetReference DisplayWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("itemWrapper")] 
		public inkWidgetReference ItemWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("arrows")] 
		public inkWidgetReference Arrows
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("abilityIcon")] 
		public inkImageWidgetReference AbilityIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("quickHackIcon")] 
		public inkImageWidgetReference QuickHackIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("highlight02")] 
		public inkImageWidgetReference Highlight02
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("highlight03")] 
		public inkImageWidgetReference Highlight03
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("highlight04")] 
		public inkImageWidgetReference Highlight04
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("highlight05")] 
		public inkImageWidgetReference Highlight05
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("highlight06")] 
		public inkImageWidgetReference Highlight06
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("highlight07")] 
		public inkImageWidgetReference Highlight07
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("highlight08")] 
		public inkImageWidgetReference Highlight08
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("textDist")] 
		public CFloat TextDist
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("weaponTextDist")] 
		public CFloat WeaponTextDist
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("data")] 
		public QuickSlotCommand Data
		{
			get => GetPropertyValue<QuickSlotCommand>();
			set => SetPropertyValue<QuickSlotCommand>(value);
		}

		[Ordinal(18)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(19)] 
		[RED("item")] 
		public CWeakHandle<InventoryItemDisplay> Item
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemDisplay>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemDisplay>>(value);
		}

		[Ordinal(20)] 
		[RED("itemWidget")] 
		public CWeakHandle<inkWidget> ItemWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(21)] 
		[RED("InventoryDataManager")] 
		public CHandle<InventoryDataManagerV2> InventoryDataManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(22)] 
		[RED("highlight")] 
		public inkImageWidgetReference Highlight
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("itemData")] 
		public InventoryItemData ItemData
		{
			get => GetPropertyValue<InventoryItemData>();
			set => SetPropertyValue<InventoryItemData>(value);
		}

		[Ordinal(24)] 
		[RED("abilityData")] 
		public AbilityData AbilityData
		{
			get => GetPropertyValue<AbilityData>();
			set => SetPropertyValue<AbilityData>(value);
		}

		[Ordinal(25)] 
		[RED("quickHackWheelDefIcon")] 
		public CName QuickHackWheelDefIcon
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public DpadWheelItemController()
		{
			SelectorWrapper = new();
			Icon = new();
			DisplayWrapper = new();
			ItemWrapper = new();
			Arrows = new();
			AbilityIcon = new();
			QuickHackIcon = new();
			Highlight02 = new();
			Highlight03 = new();
			Highlight04 = new();
			Highlight05 = new();
			Highlight06 = new();
			Highlight07 = new();
			Highlight08 = new();
			TextDist = 60.000000F;
			WeaponTextDist = 140.000000F;
			Data = new() { IsSlotUnlocked = true, ItemId = new(), PlayerVehicleData = new() { VehicleType = Enums.gamedataVehicleType.Invalid }, InteractiveActionOwner = new() };
			Highlight = new();
			ItemData = new() { Empty = true, ID = new(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, IsAvailable = true, PositionInBackpack = 4294967295, IsRequirementMet = true, IsEquippable = true, Requirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirements = new(), Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new() };
			AbilityData = new() { Empty = true, ID = new(), EquipmentArea = Enums.gamedataEquipmentArea.Invalid, AssignedIndex = -1 };
		}
	}
}
