using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DpadWheelGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("haskMarkContainer")] 
		public inkCompoundWidgetReference HaskMarkContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("itemContainer")] 
		public inkCompoundWidgetReference ItemContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("selectorWrapper")] 
		public inkWidgetReference SelectorWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("centerIcon")] 
		public inkWidgetReference CenterIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("centerGlow")] 
		public inkWidgetReference CenterGlow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("itemLabel")] 
		public inkTextWidgetReference ItemLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("itemDesc")] 
		public inkTextWidgetReference ItemDesc
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("indicator02")] 
		public inkImageWidgetReference Indicator02
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("indicator03")] 
		public inkImageWidgetReference Indicator03
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("indicator04")] 
		public inkImageWidgetReference Indicator04
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("indicator05")] 
		public inkImageWidgetReference Indicator05
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("indicator06")] 
		public inkImageWidgetReference Indicator06
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("indicator07")] 
		public inkImageWidgetReference Indicator07
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("indicator08")] 
		public inkImageWidgetReference Indicator08
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("itemDistance")] 
		public CFloat ItemDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(25)] 
		[RED("hashMarkDistance")] 
		public CFloat HashMarkDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(26)] 
		[RED("minDistance")] 
		public CFloat MinDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(27)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(28)] 
		[RED("Player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(29)] 
		[RED("QuickSlotsManager")] 
		public CWeakHandle<QuickSlotsManager> QuickSlotsManager
		{
			get => GetPropertyValue<CWeakHandle<QuickSlotsManager>>();
			set => SetPropertyValue<CWeakHandle<QuickSlotsManager>>(value);
		}

		[Ordinal(30)] 
		[RED("InventoryDataManager")] 
		public CHandle<InventoryDataManagerV2> InventoryDataManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(31)] 
		[RED("dpadItemsList")] 
		public CArray<CWeakHandle<DpadWheelItemController>> DpadItemsList
		{
			get => GetPropertyValue<CArray<CWeakHandle<DpadWheelItemController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<DpadWheelItemController>>>(value);
		}

		[Ordinal(32)] 
		[RED("commandsList")] 
		public CArray<QuickSlotCommand> CommandsList
		{
			get => GetPropertyValue<CArray<QuickSlotCommand>>();
			set => SetPropertyValue<CArray<QuickSlotCommand>>(value);
		}

		[Ordinal(33)] 
		[RED("selectedWheelItem")] 
		public CWeakHandle<DpadWheelItemController> SelectedWheelItem
		{
			get => GetPropertyValue<CWeakHandle<DpadWheelItemController>>();
			set => SetPropertyValue<CWeakHandle<DpadWheelItemController>>(value);
		}

		[Ordinal(34)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(35)] 
		[RED("selectedIndicator")] 
		public inkWidgetReference SelectedIndicator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("angleInterval")] 
		public CFloat AngleInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(37)] 
		[RED("previousAmount")] 
		public CFloat PreviousAmount
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(38)] 
		[RED("previousAngle")] 
		public CFloat PreviousAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(39)] 
		[RED("data")] 
		public QuickWheelStartUIStructure Data
		{
			get => GetPropertyValue<QuickWheelStartUIStructure>();
			set => SetPropertyValue<QuickWheelStartUIStructure>(value);
		}

		[Ordinal(40)] 
		[RED("masterListOfAllCyberware")] 
		public CArray<AbilityData> MasterListOfAllCyberware
		{
			get => GetPropertyValue<CArray<AbilityData>>();
			set => SetPropertyValue<CArray<AbilityData>>(value);
		}

		[Ordinal(41)] 
		[RED("listOfUnassignedCyberware")] 
		public CArray<AbilityData> ListOfUnassignedCyberware
		{
			get => GetPropertyValue<CArray<AbilityData>>();
			set => SetPropertyValue<CArray<AbilityData>>(value);
		}

		[Ordinal(42)] 
		[RED("dpadWheelOpen")] 
		public CBool DpadWheelOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(43)] 
		[RED("neutralChoiceDelayId")] 
		public gameDelayID NeutralChoiceDelayId
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(44)] 
		[RED("previouslySelectedData")] 
		public QuickSlotCommand PreviouslySelectedData
		{
			get => GetPropertyValue<QuickSlotCommand>();
			set => SetPropertyValue<QuickSlotCommand>(value);
		}

		[Ordinal(45)] 
		[RED("UiQuickItemsBlackboard")] 
		public CWeakHandle<gameIBlackboard> UiQuickItemsBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(46)] 
		[RED("UiQuickSlotDef")] 
		public CHandle<UI_QuickSlotsDataDef> UiQuickSlotDef
		{
			get => GetPropertyValue<CHandle<UI_QuickSlotsDataDef>>();
			set => SetPropertyValue<CHandle<UI_QuickSlotsDataDef>>(value);
		}

		[Ordinal(47)] 
		[RED("DPadWheelAngleBBID")] 
		public CHandle<redCallbackObject> DPadWheelAngleBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(48)] 
		[RED("DPadWheelInterationStartedBBID")] 
		public CHandle<redCallbackObject> DPadWheelInterationStartedBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(49)] 
		[RED("DPadWheelInterationEndedBBID")] 
		public CHandle<redCallbackObject> DPadWheelInterationEndedBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(50)] 
		[RED("DpadWheelCyberwareAssignedBBID")] 
		public CHandle<redCallbackObject> DpadWheelCyberwareAssignedBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public DpadWheelGameController()
		{
			HaskMarkContainer = new inkCompoundWidgetReference();
			ItemContainer = new inkCompoundWidgetReference();
			SelectorWrapper = new inkWidgetReference();
			CenterIcon = new inkWidgetReference();
			CenterGlow = new inkWidgetReference();
			ItemLabel = new inkTextWidgetReference();
			ItemDesc = new inkTextWidgetReference();
			ButtonHintsManagerRef = new inkWidgetReference();
			Indicator02 = new inkImageWidgetReference();
			Indicator03 = new inkImageWidgetReference();
			Indicator04 = new inkImageWidgetReference();
			Indicator05 = new inkImageWidgetReference();
			Indicator06 = new inkImageWidgetReference();
			Indicator07 = new inkImageWidgetReference();
			Indicator08 = new inkImageWidgetReference();
			ItemDistance = 450.000000F;
			HashMarkDistance = 350.000000F;
			MinDistance = 0.200000F;
			DpadItemsList = new();
			CommandsList = new();
			SelectedIndicator = new inkWidgetReference();
			Data = new QuickWheelStartUIStructure { WheelItems = new() };
			MasterListOfAllCyberware = new();
			ListOfUnassignedCyberware = new();
			NeutralChoiceDelayId = new gameDelayID();
			PreviouslySelectedData = new QuickSlotCommand { IsSlotUnlocked = true, ItemId = new gameItemID(), PlayerVehicleData = new vehiclePlayerVehicle { VehicleType = Enums.gamedataVehicleType.Invalid }, InteractiveActionOwner = new entEntityID() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
