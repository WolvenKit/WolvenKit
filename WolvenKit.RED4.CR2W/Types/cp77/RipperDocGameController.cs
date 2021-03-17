using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperDocGameController : gameuiMenuGameController
	{
		private inkWidgetReference _tooltipsManagerRef;
		private inkWidgetReference _buttonHintsManagerRef;
		private inkWidgetReference _defaultTab;
		private inkWidgetReference _itemTab;
		private inkWidgetReference _femaleHovers;
		private inkWidgetReference _maleHovers;
		private inkWidgetReference _f_frontalCortexHoverTexture;
		private inkWidgetReference _f_eyesHoverTexture;
		private inkWidgetReference _f_cardiovascularHoverTexture;
		private inkWidgetReference _f_immuneHoverTexture;
		private inkWidgetReference _f_nervousHoverTexture;
		private inkWidgetReference _f_integumentaryHoverTexture;
		private inkWidgetReference _f_systemReplacementHoverTexture;
		private inkWidgetReference _f_musculoskeletalHoverTexture;
		private inkWidgetReference _f_handsHoverTexture;
		private inkWidgetReference _f_armsHoverTexture;
		private inkWidgetReference _f_legsHoverTexture;
		private inkWidgetReference _m_frontalCortexHoverTexture;
		private inkWidgetReference _m_eyesHoverTexture;
		private inkWidgetReference _m_cardiovascularHoverTexture;
		private inkWidgetReference _m_immuneHoverTexture;
		private inkWidgetReference _m_nervousHoverTexture;
		private inkWidgetReference _m_integumentaryHoverTexture;
		private inkWidgetReference _m_systemReplacementHoverTexture;
		private inkWidgetReference _m_musculoskeletalHoverTexture;
		private inkWidgetReference _m_handsHoverTexture;
		private inkWidgetReference _m_armsHoverTexture;
		private inkWidgetReference _m_legsHoverTexture;
		private inkWidgetReference _man_wiresTexture;
		private inkWidgetReference _woman_wiresTexture;
		private inkCompoundWidgetReference _frontalCortexAnchor;
		private inkCompoundWidgetReference _ocularCortexAnchor;
		private inkCompoundWidgetReference _leftMiddleGridAnchor;
		private inkCompoundWidgetReference _leftButtomGridAnchor;
		private inkCompoundWidgetReference _rightTopGridAnchor;
		private inkCompoundWidgetReference _rightButtomGridAnchor;
		private inkCompoundWidgetReference _skeletonAnchor;
		private inkCompoundWidgetReference _handsAnchor;
		private inkWidgetReference _ripperdocIdRoot;
		private inkTextWidgetReference _playerMoney;
		private inkWidgetReference _playerMoneyHolder;
		private inkCompoundWidgetReference _cyberwareSlotsList;
		private inkVirtualCompoundWidgetReference _cyberwareVirtualGrid;
		private inkWidgetReference _radioGroupRef;
		private inkCompoundWidgetReference _cyberwareInfoContainer;
		private inkWidgetReference _itemsListScrollAreaContainer;
		private inkWidgetReference _sortingButton;
		private inkWidgetReference _sortingDropdown;
		private CEnum<RipperdocModes> _mode;
		private CEnum<CyberwareScreenType> _screen;
		private wCHandle<ButtonHints> _buttonHintsController;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private wCHandle<UIScriptableSystem> _uiScriptableSystem;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<VendorUserData> _vendorUserData;
		private CHandle<VendorDataManager> _vendorDataManager;
		private CEnum<gamedataEquipmentArea> _selectedArea;
		private CHandle<CyberwareInventoryMiniGrid> _equipmentGrid;
		private CHandle<gameIBlackboard> _vendorBlackboard;
		private CHandle<gameIBlackboard> _equipmentBlackboard;
		private CUInt32 _equipmentBlackboardCallback;
		private wCHandle<AGenericTooltipController> _cyberwareInfo;
		private CEnum<CyberwareInfoType> _cyberwareInfoType;
		private CHandle<inkanimProxy> _animationProxy;
		private CHandle<inkVirtualGridController> _virtualCyberwareListController;
		private CHandle<CyberwareTemplateClassifier> _cyberwareClassifier;
		private CHandle<inkScriptableDataSourceWrapper> _cyberwareDataSource;
		private CHandle<CyberwareDataView> _cyberwaregDataView;
		private CEnum<RipperdocFilter> _currentFilter;
		private wCHandle<FilterRadioGroup> _radioGroup;
		private CHandle<RipperdocIdPanel> _ripperId;
		private CHandle<inkanimProxy> _hoverAnimation;
		private CHandle<inkanimProxy> _introDefaultAnimation;
		private CHandle<inkanimProxy> _outroDefaultAnimation;
		private CHandle<inkanimProxy> _introPaperdollAnimation;
		private CHandle<inkanimProxy> _outroPaperdollAnimation;
		private CHandle<gameInventoryScriptListener> _inventoryListener;
		private CArray<CHandle<CyberwareInventoryMiniGrid>> _cyberareGrids;
		private CBool _isActivePanel;
		private CBool _equiped;
		private CInt32 _selectedPreviewSlot;

		[Ordinal(3)] 
		[RED("TooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetProperty(ref _tooltipsManagerRef);
			set => SetProperty(ref _tooltipsManagerRef, value);
		}

		[Ordinal(4)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(5)] 
		[RED("defaultTab")] 
		public inkWidgetReference DefaultTab
		{
			get => GetProperty(ref _defaultTab);
			set => SetProperty(ref _defaultTab, value);
		}

		[Ordinal(6)] 
		[RED("itemTab")] 
		public inkWidgetReference ItemTab
		{
			get => GetProperty(ref _itemTab);
			set => SetProperty(ref _itemTab, value);
		}

		[Ordinal(7)] 
		[RED("femaleHovers")] 
		public inkWidgetReference FemaleHovers
		{
			get => GetProperty(ref _femaleHovers);
			set => SetProperty(ref _femaleHovers, value);
		}

		[Ordinal(8)] 
		[RED("maleHovers")] 
		public inkWidgetReference MaleHovers
		{
			get => GetProperty(ref _maleHovers);
			set => SetProperty(ref _maleHovers, value);
		}

		[Ordinal(9)] 
		[RED("F_frontalCortexHoverTexture")] 
		public inkWidgetReference F_frontalCortexHoverTexture
		{
			get => GetProperty(ref _f_frontalCortexHoverTexture);
			set => SetProperty(ref _f_frontalCortexHoverTexture, value);
		}

		[Ordinal(10)] 
		[RED("F_eyesHoverTexture")] 
		public inkWidgetReference F_eyesHoverTexture
		{
			get => GetProperty(ref _f_eyesHoverTexture);
			set => SetProperty(ref _f_eyesHoverTexture, value);
		}

		[Ordinal(11)] 
		[RED("F_cardiovascularHoverTexture")] 
		public inkWidgetReference F_cardiovascularHoverTexture
		{
			get => GetProperty(ref _f_cardiovascularHoverTexture);
			set => SetProperty(ref _f_cardiovascularHoverTexture, value);
		}

		[Ordinal(12)] 
		[RED("F_immuneHoverTexture")] 
		public inkWidgetReference F_immuneHoverTexture
		{
			get => GetProperty(ref _f_immuneHoverTexture);
			set => SetProperty(ref _f_immuneHoverTexture, value);
		}

		[Ordinal(13)] 
		[RED("F_nervousHoverTexture")] 
		public inkWidgetReference F_nervousHoverTexture
		{
			get => GetProperty(ref _f_nervousHoverTexture);
			set => SetProperty(ref _f_nervousHoverTexture, value);
		}

		[Ordinal(14)] 
		[RED("F_integumentaryHoverTexture")] 
		public inkWidgetReference F_integumentaryHoverTexture
		{
			get => GetProperty(ref _f_integumentaryHoverTexture);
			set => SetProperty(ref _f_integumentaryHoverTexture, value);
		}

		[Ordinal(15)] 
		[RED("F_systemReplacementHoverTexture")] 
		public inkWidgetReference F_systemReplacementHoverTexture
		{
			get => GetProperty(ref _f_systemReplacementHoverTexture);
			set => SetProperty(ref _f_systemReplacementHoverTexture, value);
		}

		[Ordinal(16)] 
		[RED("F_musculoskeletalHoverTexture")] 
		public inkWidgetReference F_musculoskeletalHoverTexture
		{
			get => GetProperty(ref _f_musculoskeletalHoverTexture);
			set => SetProperty(ref _f_musculoskeletalHoverTexture, value);
		}

		[Ordinal(17)] 
		[RED("F_handsHoverTexture")] 
		public inkWidgetReference F_handsHoverTexture
		{
			get => GetProperty(ref _f_handsHoverTexture);
			set => SetProperty(ref _f_handsHoverTexture, value);
		}

		[Ordinal(18)] 
		[RED("F_armsHoverTexture")] 
		public inkWidgetReference F_armsHoverTexture
		{
			get => GetProperty(ref _f_armsHoverTexture);
			set => SetProperty(ref _f_armsHoverTexture, value);
		}

		[Ordinal(19)] 
		[RED("F_legsHoverTexture")] 
		public inkWidgetReference F_legsHoverTexture
		{
			get => GetProperty(ref _f_legsHoverTexture);
			set => SetProperty(ref _f_legsHoverTexture, value);
		}

		[Ordinal(20)] 
		[RED("M_frontalCortexHoverTexture")] 
		public inkWidgetReference M_frontalCortexHoverTexture
		{
			get => GetProperty(ref _m_frontalCortexHoverTexture);
			set => SetProperty(ref _m_frontalCortexHoverTexture, value);
		}

		[Ordinal(21)] 
		[RED("M_eyesHoverTexture")] 
		public inkWidgetReference M_eyesHoverTexture
		{
			get => GetProperty(ref _m_eyesHoverTexture);
			set => SetProperty(ref _m_eyesHoverTexture, value);
		}

		[Ordinal(22)] 
		[RED("M_cardiovascularHoverTexture")] 
		public inkWidgetReference M_cardiovascularHoverTexture
		{
			get => GetProperty(ref _m_cardiovascularHoverTexture);
			set => SetProperty(ref _m_cardiovascularHoverTexture, value);
		}

		[Ordinal(23)] 
		[RED("M_immuneHoverTexture")] 
		public inkWidgetReference M_immuneHoverTexture
		{
			get => GetProperty(ref _m_immuneHoverTexture);
			set => SetProperty(ref _m_immuneHoverTexture, value);
		}

		[Ordinal(24)] 
		[RED("M_nervousHoverTexture")] 
		public inkWidgetReference M_nervousHoverTexture
		{
			get => GetProperty(ref _m_nervousHoverTexture);
			set => SetProperty(ref _m_nervousHoverTexture, value);
		}

		[Ordinal(25)] 
		[RED("M_integumentaryHoverTexture")] 
		public inkWidgetReference M_integumentaryHoverTexture
		{
			get => GetProperty(ref _m_integumentaryHoverTexture);
			set => SetProperty(ref _m_integumentaryHoverTexture, value);
		}

		[Ordinal(26)] 
		[RED("M_systemReplacementHoverTexture")] 
		public inkWidgetReference M_systemReplacementHoverTexture
		{
			get => GetProperty(ref _m_systemReplacementHoverTexture);
			set => SetProperty(ref _m_systemReplacementHoverTexture, value);
		}

		[Ordinal(27)] 
		[RED("M_musculoskeletalHoverTexture")] 
		public inkWidgetReference M_musculoskeletalHoverTexture
		{
			get => GetProperty(ref _m_musculoskeletalHoverTexture);
			set => SetProperty(ref _m_musculoskeletalHoverTexture, value);
		}

		[Ordinal(28)] 
		[RED("M_handsHoverTexture")] 
		public inkWidgetReference M_handsHoverTexture
		{
			get => GetProperty(ref _m_handsHoverTexture);
			set => SetProperty(ref _m_handsHoverTexture, value);
		}

		[Ordinal(29)] 
		[RED("M_armsHoverTexture")] 
		public inkWidgetReference M_armsHoverTexture
		{
			get => GetProperty(ref _m_armsHoverTexture);
			set => SetProperty(ref _m_armsHoverTexture, value);
		}

		[Ordinal(30)] 
		[RED("M_legsHoverTexture")] 
		public inkWidgetReference M_legsHoverTexture
		{
			get => GetProperty(ref _m_legsHoverTexture);
			set => SetProperty(ref _m_legsHoverTexture, value);
		}

		[Ordinal(31)] 
		[RED("man_wiresTexture")] 
		public inkWidgetReference Man_wiresTexture
		{
			get => GetProperty(ref _man_wiresTexture);
			set => SetProperty(ref _man_wiresTexture, value);
		}

		[Ordinal(32)] 
		[RED("woman_wiresTexture")] 
		public inkWidgetReference Woman_wiresTexture
		{
			get => GetProperty(ref _woman_wiresTexture);
			set => SetProperty(ref _woman_wiresTexture, value);
		}

		[Ordinal(33)] 
		[RED("frontalCortexAnchor")] 
		public inkCompoundWidgetReference FrontalCortexAnchor
		{
			get => GetProperty(ref _frontalCortexAnchor);
			set => SetProperty(ref _frontalCortexAnchor, value);
		}

		[Ordinal(34)] 
		[RED("ocularCortexAnchor")] 
		public inkCompoundWidgetReference OcularCortexAnchor
		{
			get => GetProperty(ref _ocularCortexAnchor);
			set => SetProperty(ref _ocularCortexAnchor, value);
		}

		[Ordinal(35)] 
		[RED("leftMiddleGridAnchor")] 
		public inkCompoundWidgetReference LeftMiddleGridAnchor
		{
			get => GetProperty(ref _leftMiddleGridAnchor);
			set => SetProperty(ref _leftMiddleGridAnchor, value);
		}

		[Ordinal(36)] 
		[RED("leftButtomGridAnchor")] 
		public inkCompoundWidgetReference LeftButtomGridAnchor
		{
			get => GetProperty(ref _leftButtomGridAnchor);
			set => SetProperty(ref _leftButtomGridAnchor, value);
		}

		[Ordinal(37)] 
		[RED("rightTopGridAnchor")] 
		public inkCompoundWidgetReference RightTopGridAnchor
		{
			get => GetProperty(ref _rightTopGridAnchor);
			set => SetProperty(ref _rightTopGridAnchor, value);
		}

		[Ordinal(38)] 
		[RED("rightButtomGridAnchor")] 
		public inkCompoundWidgetReference RightButtomGridAnchor
		{
			get => GetProperty(ref _rightButtomGridAnchor);
			set => SetProperty(ref _rightButtomGridAnchor, value);
		}

		[Ordinal(39)] 
		[RED("skeletonAnchor")] 
		public inkCompoundWidgetReference SkeletonAnchor
		{
			get => GetProperty(ref _skeletonAnchor);
			set => SetProperty(ref _skeletonAnchor, value);
		}

		[Ordinal(40)] 
		[RED("handsAnchor")] 
		public inkCompoundWidgetReference HandsAnchor
		{
			get => GetProperty(ref _handsAnchor);
			set => SetProperty(ref _handsAnchor, value);
		}

		[Ordinal(41)] 
		[RED("ripperdocIdRoot")] 
		public inkWidgetReference RipperdocIdRoot
		{
			get => GetProperty(ref _ripperdocIdRoot);
			set => SetProperty(ref _ripperdocIdRoot, value);
		}

		[Ordinal(42)] 
		[RED("playerMoney")] 
		public inkTextWidgetReference PlayerMoney
		{
			get => GetProperty(ref _playerMoney);
			set => SetProperty(ref _playerMoney, value);
		}

		[Ordinal(43)] 
		[RED("playerMoneyHolder")] 
		public inkWidgetReference PlayerMoneyHolder
		{
			get => GetProperty(ref _playerMoneyHolder);
			set => SetProperty(ref _playerMoneyHolder, value);
		}

		[Ordinal(44)] 
		[RED("cyberwareSlotsList")] 
		public inkCompoundWidgetReference CyberwareSlotsList
		{
			get => GetProperty(ref _cyberwareSlotsList);
			set => SetProperty(ref _cyberwareSlotsList, value);
		}

		[Ordinal(45)] 
		[RED("cyberwareVirtualGrid")] 
		public inkVirtualCompoundWidgetReference CyberwareVirtualGrid
		{
			get => GetProperty(ref _cyberwareVirtualGrid);
			set => SetProperty(ref _cyberwareVirtualGrid, value);
		}

		[Ordinal(46)] 
		[RED("radioGroupRef")] 
		public inkWidgetReference RadioGroupRef
		{
			get => GetProperty(ref _radioGroupRef);
			set => SetProperty(ref _radioGroupRef, value);
		}

		[Ordinal(47)] 
		[RED("cyberwareInfoContainer")] 
		public inkCompoundWidgetReference CyberwareInfoContainer
		{
			get => GetProperty(ref _cyberwareInfoContainer);
			set => SetProperty(ref _cyberwareInfoContainer, value);
		}

		[Ordinal(48)] 
		[RED("itemsListScrollAreaContainer")] 
		public inkWidgetReference ItemsListScrollAreaContainer
		{
			get => GetProperty(ref _itemsListScrollAreaContainer);
			set => SetProperty(ref _itemsListScrollAreaContainer, value);
		}

		[Ordinal(49)] 
		[RED("sortingButton")] 
		public inkWidgetReference SortingButton
		{
			get => GetProperty(ref _sortingButton);
			set => SetProperty(ref _sortingButton, value);
		}

		[Ordinal(50)] 
		[RED("sortingDropdown")] 
		public inkWidgetReference SortingDropdown
		{
			get => GetProperty(ref _sortingDropdown);
			set => SetProperty(ref _sortingDropdown, value);
		}

		[Ordinal(51)] 
		[RED("mode")] 
		public CEnum<RipperdocModes> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		[Ordinal(52)] 
		[RED("screen")] 
		public CEnum<CyberwareScreenType> Screen
		{
			get => GetProperty(ref _screen);
			set => SetProperty(ref _screen, value);
		}

		[Ordinal(53)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(54)] 
		[RED("TooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		[Ordinal(55)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}

		[Ordinal(56)] 
		[RED("uiScriptableSystem")] 
		public wCHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetProperty(ref _uiScriptableSystem);
			set => SetProperty(ref _uiScriptableSystem, value);
		}

		[Ordinal(57)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(58)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(59)] 
		[RED("vendorUserData")] 
		public CHandle<VendorUserData> VendorUserData
		{
			get => GetProperty(ref _vendorUserData);
			set => SetProperty(ref _vendorUserData, value);
		}

		[Ordinal(60)] 
		[RED("VendorDataManager")] 
		public CHandle<VendorDataManager> VendorDataManager
		{
			get => GetProperty(ref _vendorDataManager);
			set => SetProperty(ref _vendorDataManager, value);
		}

		[Ordinal(61)] 
		[RED("selectedArea")] 
		public CEnum<gamedataEquipmentArea> SelectedArea
		{
			get => GetProperty(ref _selectedArea);
			set => SetProperty(ref _selectedArea, value);
		}

		[Ordinal(62)] 
		[RED("equipmentGrid")] 
		public CHandle<CyberwareInventoryMiniGrid> EquipmentGrid
		{
			get => GetProperty(ref _equipmentGrid);
			set => SetProperty(ref _equipmentGrid, value);
		}

		[Ordinal(63)] 
		[RED("VendorBlackboard")] 
		public CHandle<gameIBlackboard> VendorBlackboard
		{
			get => GetProperty(ref _vendorBlackboard);
			set => SetProperty(ref _vendorBlackboard, value);
		}

		[Ordinal(64)] 
		[RED("equipmentBlackboard")] 
		public CHandle<gameIBlackboard> EquipmentBlackboard
		{
			get => GetProperty(ref _equipmentBlackboard);
			set => SetProperty(ref _equipmentBlackboard, value);
		}

		[Ordinal(65)] 
		[RED("equipmentBlackboardCallback")] 
		public CUInt32 EquipmentBlackboardCallback
		{
			get => GetProperty(ref _equipmentBlackboardCallback);
			set => SetProperty(ref _equipmentBlackboardCallback, value);
		}

		[Ordinal(66)] 
		[RED("cyberwareInfo")] 
		public wCHandle<AGenericTooltipController> CyberwareInfo
		{
			get => GetProperty(ref _cyberwareInfo);
			set => SetProperty(ref _cyberwareInfo, value);
		}

		[Ordinal(67)] 
		[RED("cyberwareInfoType")] 
		public CEnum<CyberwareInfoType> CyberwareInfoType
		{
			get => GetProperty(ref _cyberwareInfoType);
			set => SetProperty(ref _cyberwareInfoType, value);
		}

		[Ordinal(68)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		[Ordinal(69)] 
		[RED("virtualCyberwareListController")] 
		public CHandle<inkVirtualGridController> VirtualCyberwareListController
		{
			get => GetProperty(ref _virtualCyberwareListController);
			set => SetProperty(ref _virtualCyberwareListController, value);
		}

		[Ordinal(70)] 
		[RED("cyberwareClassifier")] 
		public CHandle<CyberwareTemplateClassifier> CyberwareClassifier
		{
			get => GetProperty(ref _cyberwareClassifier);
			set => SetProperty(ref _cyberwareClassifier, value);
		}

		[Ordinal(71)] 
		[RED("cyberwareDataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> CyberwareDataSource
		{
			get => GetProperty(ref _cyberwareDataSource);
			set => SetProperty(ref _cyberwareDataSource, value);
		}

		[Ordinal(72)] 
		[RED("cyberwaregDataView")] 
		public CHandle<CyberwareDataView> CyberwaregDataView
		{
			get => GetProperty(ref _cyberwaregDataView);
			set => SetProperty(ref _cyberwaregDataView, value);
		}

		[Ordinal(73)] 
		[RED("currentFilter")] 
		public CEnum<RipperdocFilter> CurrentFilter
		{
			get => GetProperty(ref _currentFilter);
			set => SetProperty(ref _currentFilter, value);
		}

		[Ordinal(74)] 
		[RED("radioGroup")] 
		public wCHandle<FilterRadioGroup> RadioGroup
		{
			get => GetProperty(ref _radioGroup);
			set => SetProperty(ref _radioGroup, value);
		}

		[Ordinal(75)] 
		[RED("ripperId")] 
		public CHandle<RipperdocIdPanel> RipperId
		{
			get => GetProperty(ref _ripperId);
			set => SetProperty(ref _ripperId, value);
		}

		[Ordinal(76)] 
		[RED("hoverAnimation")] 
		public CHandle<inkanimProxy> HoverAnimation
		{
			get => GetProperty(ref _hoverAnimation);
			set => SetProperty(ref _hoverAnimation, value);
		}

		[Ordinal(77)] 
		[RED("introDefaultAnimation")] 
		public CHandle<inkanimProxy> IntroDefaultAnimation
		{
			get => GetProperty(ref _introDefaultAnimation);
			set => SetProperty(ref _introDefaultAnimation, value);
		}

		[Ordinal(78)] 
		[RED("outroDefaultAnimation")] 
		public CHandle<inkanimProxy> OutroDefaultAnimation
		{
			get => GetProperty(ref _outroDefaultAnimation);
			set => SetProperty(ref _outroDefaultAnimation, value);
		}

		[Ordinal(79)] 
		[RED("introPaperdollAnimation")] 
		public CHandle<inkanimProxy> IntroPaperdollAnimation
		{
			get => GetProperty(ref _introPaperdollAnimation);
			set => SetProperty(ref _introPaperdollAnimation, value);
		}

		[Ordinal(80)] 
		[RED("outroPaperdollAnimation")] 
		public CHandle<inkanimProxy> OutroPaperdollAnimation
		{
			get => GetProperty(ref _outroPaperdollAnimation);
			set => SetProperty(ref _outroPaperdollAnimation, value);
		}

		[Ordinal(81)] 
		[RED("inventoryListener")] 
		public CHandle<gameInventoryScriptListener> InventoryListener
		{
			get => GetProperty(ref _inventoryListener);
			set => SetProperty(ref _inventoryListener, value);
		}

		[Ordinal(82)] 
		[RED("cyberareGrids")] 
		public CArray<CHandle<CyberwareInventoryMiniGrid>> CyberareGrids
		{
			get => GetProperty(ref _cyberareGrids);
			set => SetProperty(ref _cyberareGrids, value);
		}

		[Ordinal(83)] 
		[RED("isActivePanel")] 
		public CBool IsActivePanel
		{
			get => GetProperty(ref _isActivePanel);
			set => SetProperty(ref _isActivePanel, value);
		}

		[Ordinal(84)] 
		[RED("equiped")] 
		public CBool Equiped
		{
			get => GetProperty(ref _equiped);
			set => SetProperty(ref _equiped, value);
		}

		[Ordinal(85)] 
		[RED("selectedPreviewSlot")] 
		public CInt32 SelectedPreviewSlot
		{
			get => GetProperty(ref _selectedPreviewSlot);
			set => SetProperty(ref _selectedPreviewSlot, value);
		}

		public RipperDocGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
