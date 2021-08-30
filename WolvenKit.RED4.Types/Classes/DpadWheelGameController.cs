using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DpadWheelGameController : gameuiHUDGameController
	{
		private inkCompoundWidgetReference _haskMarkContainer;
		private inkCompoundWidgetReference _itemContainer;
		private inkWidgetReference _selectorWrapper;
		private inkWidgetReference _centerIcon;
		private inkWidgetReference _centerGlow;
		private inkTextWidgetReference _itemLabel;
		private inkTextWidgetReference _itemDesc;
		private inkWidgetReference _buttonHintsManagerRef;
		private inkImageWidgetReference _indicator02;
		private inkImageWidgetReference _indicator03;
		private inkImageWidgetReference _indicator04;
		private inkImageWidgetReference _indicator05;
		private inkImageWidgetReference _indicator06;
		private inkImageWidgetReference _indicator07;
		private inkImageWidgetReference _indicator08;
		private CFloat _itemDistance;
		private CFloat _hashMarkDistance;
		private CFloat _minDistance;
		private CWeakHandle<inkWidget> _root;
		private CWeakHandle<PlayerPuppet> _player;
		private CWeakHandle<QuickSlotsManager> _quickSlotsManager;
		private CHandle<InventoryDataManagerV2> _inventoryDataManager;
		private CArray<CWeakHandle<DpadWheelItemController>> _dpadItemsList;
		private CArray<QuickSlotCommand> _commandsList;
		private CWeakHandle<DpadWheelItemController> _selectedWheelItem;
		private CWeakHandle<ButtonHints> _buttonHintsController;
		private inkWidgetReference _selectedIndicator;
		private CFloat _angleInterval;
		private CFloat _previousAmount;
		private CFloat _previousAngle;
		private QuickWheelStartUIStructure _data;
		private CArray<AbilityData> _masterListOfAllCyberware;
		private CArray<AbilityData> _listOfUnassignedCyberware;
		private CBool _dpadWheelOpen;
		private gameDelayID _neutralChoiceDelayId;
		private QuickSlotCommand _previouslySelectedData;
		private CWeakHandle<gameIBlackboard> _uiQuickItemsBlackboard;
		private CHandle<UI_QuickSlotsDataDef> _uiQuickSlotDef;
		private CHandle<redCallbackObject> _dPadWheelAngleBBID;
		private CHandle<redCallbackObject> _dPadWheelInterationStartedBBID;
		private CHandle<redCallbackObject> _dPadWheelInterationEndedBBID;
		private CHandle<redCallbackObject> _dpadWheelCyberwareAssignedBBID;

		[Ordinal(9)] 
		[RED("haskMarkContainer")] 
		public inkCompoundWidgetReference HaskMarkContainer
		{
			get => GetProperty(ref _haskMarkContainer);
			set => SetProperty(ref _haskMarkContainer, value);
		}

		[Ordinal(10)] 
		[RED("itemContainer")] 
		public inkCompoundWidgetReference ItemContainer
		{
			get => GetProperty(ref _itemContainer);
			set => SetProperty(ref _itemContainer, value);
		}

		[Ordinal(11)] 
		[RED("selectorWrapper")] 
		public inkWidgetReference SelectorWrapper
		{
			get => GetProperty(ref _selectorWrapper);
			set => SetProperty(ref _selectorWrapper, value);
		}

		[Ordinal(12)] 
		[RED("centerIcon")] 
		public inkWidgetReference CenterIcon
		{
			get => GetProperty(ref _centerIcon);
			set => SetProperty(ref _centerIcon, value);
		}

		[Ordinal(13)] 
		[RED("centerGlow")] 
		public inkWidgetReference CenterGlow
		{
			get => GetProperty(ref _centerGlow);
			set => SetProperty(ref _centerGlow, value);
		}

		[Ordinal(14)] 
		[RED("itemLabel")] 
		public inkTextWidgetReference ItemLabel
		{
			get => GetProperty(ref _itemLabel);
			set => SetProperty(ref _itemLabel, value);
		}

		[Ordinal(15)] 
		[RED("itemDesc")] 
		public inkTextWidgetReference ItemDesc
		{
			get => GetProperty(ref _itemDesc);
			set => SetProperty(ref _itemDesc, value);
		}

		[Ordinal(16)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(17)] 
		[RED("indicator02")] 
		public inkImageWidgetReference Indicator02
		{
			get => GetProperty(ref _indicator02);
			set => SetProperty(ref _indicator02, value);
		}

		[Ordinal(18)] 
		[RED("indicator03")] 
		public inkImageWidgetReference Indicator03
		{
			get => GetProperty(ref _indicator03);
			set => SetProperty(ref _indicator03, value);
		}

		[Ordinal(19)] 
		[RED("indicator04")] 
		public inkImageWidgetReference Indicator04
		{
			get => GetProperty(ref _indicator04);
			set => SetProperty(ref _indicator04, value);
		}

		[Ordinal(20)] 
		[RED("indicator05")] 
		public inkImageWidgetReference Indicator05
		{
			get => GetProperty(ref _indicator05);
			set => SetProperty(ref _indicator05, value);
		}

		[Ordinal(21)] 
		[RED("indicator06")] 
		public inkImageWidgetReference Indicator06
		{
			get => GetProperty(ref _indicator06);
			set => SetProperty(ref _indicator06, value);
		}

		[Ordinal(22)] 
		[RED("indicator07")] 
		public inkImageWidgetReference Indicator07
		{
			get => GetProperty(ref _indicator07);
			set => SetProperty(ref _indicator07, value);
		}

		[Ordinal(23)] 
		[RED("indicator08")] 
		public inkImageWidgetReference Indicator08
		{
			get => GetProperty(ref _indicator08);
			set => SetProperty(ref _indicator08, value);
		}

		[Ordinal(24)] 
		[RED("itemDistance")] 
		public CFloat ItemDistance
		{
			get => GetProperty(ref _itemDistance);
			set => SetProperty(ref _itemDistance, value);
		}

		[Ordinal(25)] 
		[RED("hashMarkDistance")] 
		public CFloat HashMarkDistance
		{
			get => GetProperty(ref _hashMarkDistance);
			set => SetProperty(ref _hashMarkDistance, value);
		}

		[Ordinal(26)] 
		[RED("minDistance")] 
		public CFloat MinDistance
		{
			get => GetProperty(ref _minDistance);
			set => SetProperty(ref _minDistance, value);
		}

		[Ordinal(27)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(28)] 
		[RED("Player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(29)] 
		[RED("QuickSlotsManager")] 
		public CWeakHandle<QuickSlotsManager> QuickSlotsManager
		{
			get => GetProperty(ref _quickSlotsManager);
			set => SetProperty(ref _quickSlotsManager, value);
		}

		[Ordinal(30)] 
		[RED("InventoryDataManager")] 
		public CHandle<InventoryDataManagerV2> InventoryDataManager
		{
			get => GetProperty(ref _inventoryDataManager);
			set => SetProperty(ref _inventoryDataManager, value);
		}

		[Ordinal(31)] 
		[RED("dpadItemsList")] 
		public CArray<CWeakHandle<DpadWheelItemController>> DpadItemsList
		{
			get => GetProperty(ref _dpadItemsList);
			set => SetProperty(ref _dpadItemsList, value);
		}

		[Ordinal(32)] 
		[RED("commandsList")] 
		public CArray<QuickSlotCommand> CommandsList
		{
			get => GetProperty(ref _commandsList);
			set => SetProperty(ref _commandsList, value);
		}

		[Ordinal(33)] 
		[RED("selectedWheelItem")] 
		public CWeakHandle<DpadWheelItemController> SelectedWheelItem
		{
			get => GetProperty(ref _selectedWheelItem);
			set => SetProperty(ref _selectedWheelItem, value);
		}

		[Ordinal(34)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(35)] 
		[RED("selectedIndicator")] 
		public inkWidgetReference SelectedIndicator
		{
			get => GetProperty(ref _selectedIndicator);
			set => SetProperty(ref _selectedIndicator, value);
		}

		[Ordinal(36)] 
		[RED("angleInterval")] 
		public CFloat AngleInterval
		{
			get => GetProperty(ref _angleInterval);
			set => SetProperty(ref _angleInterval, value);
		}

		[Ordinal(37)] 
		[RED("previousAmount")] 
		public CFloat PreviousAmount
		{
			get => GetProperty(ref _previousAmount);
			set => SetProperty(ref _previousAmount, value);
		}

		[Ordinal(38)] 
		[RED("previousAngle")] 
		public CFloat PreviousAngle
		{
			get => GetProperty(ref _previousAngle);
			set => SetProperty(ref _previousAngle, value);
		}

		[Ordinal(39)] 
		[RED("data")] 
		public QuickWheelStartUIStructure Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(40)] 
		[RED("masterListOfAllCyberware")] 
		public CArray<AbilityData> MasterListOfAllCyberware
		{
			get => GetProperty(ref _masterListOfAllCyberware);
			set => SetProperty(ref _masterListOfAllCyberware, value);
		}

		[Ordinal(41)] 
		[RED("listOfUnassignedCyberware")] 
		public CArray<AbilityData> ListOfUnassignedCyberware
		{
			get => GetProperty(ref _listOfUnassignedCyberware);
			set => SetProperty(ref _listOfUnassignedCyberware, value);
		}

		[Ordinal(42)] 
		[RED("dpadWheelOpen")] 
		public CBool DpadWheelOpen
		{
			get => GetProperty(ref _dpadWheelOpen);
			set => SetProperty(ref _dpadWheelOpen, value);
		}

		[Ordinal(43)] 
		[RED("neutralChoiceDelayId")] 
		public gameDelayID NeutralChoiceDelayId
		{
			get => GetProperty(ref _neutralChoiceDelayId);
			set => SetProperty(ref _neutralChoiceDelayId, value);
		}

		[Ordinal(44)] 
		[RED("previouslySelectedData")] 
		public QuickSlotCommand PreviouslySelectedData
		{
			get => GetProperty(ref _previouslySelectedData);
			set => SetProperty(ref _previouslySelectedData, value);
		}

		[Ordinal(45)] 
		[RED("UiQuickItemsBlackboard")] 
		public CWeakHandle<gameIBlackboard> UiQuickItemsBlackboard
		{
			get => GetProperty(ref _uiQuickItemsBlackboard);
			set => SetProperty(ref _uiQuickItemsBlackboard, value);
		}

		[Ordinal(46)] 
		[RED("UiQuickSlotDef")] 
		public CHandle<UI_QuickSlotsDataDef> UiQuickSlotDef
		{
			get => GetProperty(ref _uiQuickSlotDef);
			set => SetProperty(ref _uiQuickSlotDef, value);
		}

		[Ordinal(47)] 
		[RED("DPadWheelAngleBBID")] 
		public CHandle<redCallbackObject> DPadWheelAngleBBID
		{
			get => GetProperty(ref _dPadWheelAngleBBID);
			set => SetProperty(ref _dPadWheelAngleBBID, value);
		}

		[Ordinal(48)] 
		[RED("DPadWheelInterationStartedBBID")] 
		public CHandle<redCallbackObject> DPadWheelInterationStartedBBID
		{
			get => GetProperty(ref _dPadWheelInterationStartedBBID);
			set => SetProperty(ref _dPadWheelInterationStartedBBID, value);
		}

		[Ordinal(49)] 
		[RED("DPadWheelInterationEndedBBID")] 
		public CHandle<redCallbackObject> DPadWheelInterationEndedBBID
		{
			get => GetProperty(ref _dPadWheelInterationEndedBBID);
			set => SetProperty(ref _dPadWheelInterationEndedBBID, value);
		}

		[Ordinal(50)] 
		[RED("DpadWheelCyberwareAssignedBBID")] 
		public CHandle<redCallbackObject> DpadWheelCyberwareAssignedBBID
		{
			get => GetProperty(ref _dpadWheelCyberwareAssignedBBID);
			set => SetProperty(ref _dpadWheelCyberwareAssignedBBID, value);
		}

		public DpadWheelGameController()
		{
			_itemDistance = 450.000000F;
			_hashMarkDistance = 350.000000F;
			_minDistance = 0.200000F;
		}
	}
}
