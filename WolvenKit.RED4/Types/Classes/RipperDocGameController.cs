using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperDocGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("TooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("animationControllerContainer")] 
		public inkWidgetReference AnimationControllerContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("ripperdocIdContainerV1")] 
		public inkWidgetReference RipperdocIdContainerV1
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("ripperdocIdContainerV2")] 
		public inkWidgetReference RipperdocIdContainerV2
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("frontalCortexAnchor")] 
		public inkCompoundWidgetReference FrontalCortexAnchor
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("ocularCortexAnchor")] 
		public inkCompoundWidgetReference OcularCortexAnchor
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("leftMiddleGridAnchor")] 
		public inkCompoundWidgetReference LeftMiddleGridAnchor
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("leftButtomGridAnchor")] 
		public inkCompoundWidgetReference LeftButtomGridAnchor
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("rightTopGridAnchor")] 
		public inkCompoundWidgetReference RightTopGridAnchor
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("rightButtomGridAnchor")] 
		public inkCompoundWidgetReference RightButtomGridAnchor
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("skeletonAnchor")] 
		public inkCompoundWidgetReference SkeletonAnchor
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("handsAnchor")] 
		public inkCompoundWidgetReference HandsAnchor
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("playerMoney")] 
		public inkTextWidgetReference PlayerMoney
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("playerMoneyHolder")] 
		public inkWidgetReference PlayerMoneyHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("allocationPointContainerDefault")] 
		public inkCompoundWidgetReference AllocationPointContainerDefault
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("cyberwareSlotsList")] 
		public inkCompoundWidgetReference CyberwareSlotsList
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("cyberwareVirtualGrid")] 
		public inkVirtualCompoundWidgetReference CyberwareVirtualGrid
		{
			get => GetPropertyValue<inkVirtualCompoundWidgetReference>();
			set => SetPropertyValue<inkVirtualCompoundWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("radioGroupRef")] 
		public inkWidgetReference RadioGroupRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("cyberwareInfoContainer")] 
		public inkCompoundWidgetReference CyberwareInfoContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("itemsListScrollAreaContainer")] 
		public inkWidgetReference ItemsListScrollAreaContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("sortingButton")] 
		public inkWidgetReference SortingButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("sortingDropdown")] 
		public inkWidgetReference SortingDropdown
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("mode")] 
		public CEnum<RipperdocModes> Mode
		{
			get => GetPropertyValue<CEnum<RipperdocModes>>();
			set => SetPropertyValue<CEnum<RipperdocModes>>(value);
		}

		[Ordinal(27)] 
		[RED("screen")] 
		public CEnum<CyberwareScreenType> Screen
		{
			get => GetPropertyValue<CEnum<CyberwareScreenType>>();
			set => SetPropertyValue<CEnum<CyberwareScreenType>>(value);
		}

		[Ordinal(28)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(29)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(30)] 
		[RED("TooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		[Ordinal(31)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(32)] 
		[RED("uiScriptableSystem")] 
		public CWeakHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetPropertyValue<CWeakHandle<UIScriptableSystem>>();
			set => SetPropertyValue<CWeakHandle<UIScriptableSystem>>(value);
		}

		[Ordinal(33)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(34)] 
		[RED("ripperdocTokenManager")] 
		public CHandle<RipperdocTokenManager> RipperdocTokenManager
		{
			get => GetPropertyValue<CHandle<RipperdocTokenManager>>();
			set => SetPropertyValue<CHandle<RipperdocTokenManager>>(value);
		}

		[Ordinal(35)] 
		[RED("vendorUserData")] 
		public CHandle<VendorUserData> VendorUserData
		{
			get => GetPropertyValue<CHandle<VendorUserData>>();
			set => SetPropertyValue<CHandle<VendorUserData>>(value);
		}

		[Ordinal(36)] 
		[RED("VendorDataManager")] 
		public CHandle<VendorDataManager> VendorDataManager
		{
			get => GetPropertyValue<CHandle<VendorDataManager>>();
			set => SetPropertyValue<CHandle<VendorDataManager>>(value);
		}

		[Ordinal(37)] 
		[RED("soldItems")] 
		public CHandle<SoldItemsCache> SoldItems
		{
			get => GetPropertyValue<CHandle<SoldItemsCache>>();
			set => SetPropertyValue<CHandle<SoldItemsCache>>(value);
		}

		[Ordinal(38)] 
		[RED("VendorBlackboard")] 
		public CWeakHandle<gameIBlackboard> VendorBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(39)] 
		[RED("equipmentBlackboard")] 
		public CWeakHandle<gameIBlackboard> EquipmentBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(40)] 
		[RED("equipmentBlackboardCallback")] 
		public CHandle<redCallbackObject> EquipmentBlackboardCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(41)] 
		[RED("tokenBlackboard")] 
		public CWeakHandle<gameIBlackboard> TokenBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(42)] 
		[RED("tokenBlackboardCallback")] 
		public CHandle<redCallbackObject> TokenBlackboardCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(43)] 
		[RED("cyberwareInfo")] 
		public CWeakHandle<AGenericTooltipController> CyberwareInfo
		{
			get => GetPropertyValue<CWeakHandle<AGenericTooltipController>>();
			set => SetPropertyValue<CWeakHandle<AGenericTooltipController>>(value);
		}

		[Ordinal(44)] 
		[RED("cyberwareInfoType")] 
		public CEnum<CyberwareInfoType> CyberwareInfoType
		{
			get => GetPropertyValue<CEnum<CyberwareInfoType>>();
			set => SetPropertyValue<CEnum<CyberwareInfoType>>(value);
		}

		[Ordinal(45)] 
		[RED("virtualCyberwareListController")] 
		public CWeakHandle<inkVirtualGridController> VirtualCyberwareListController
		{
			get => GetPropertyValue<CWeakHandle<inkVirtualGridController>>();
			set => SetPropertyValue<CWeakHandle<inkVirtualGridController>>(value);
		}

		[Ordinal(46)] 
		[RED("cyberwareClassifier")] 
		public CHandle<CyberwareTemplateClassifier> CyberwareClassifier
		{
			get => GetPropertyValue<CHandle<CyberwareTemplateClassifier>>();
			set => SetPropertyValue<CHandle<CyberwareTemplateClassifier>>(value);
		}

		[Ordinal(47)] 
		[RED("cyberwareDataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> CyberwareDataSource
		{
			get => GetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>();
			set => SetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>(value);
		}

		[Ordinal(48)] 
		[RED("cyberwaregDataView")] 
		public CHandle<CyberwareDataView> CyberwaregDataView
		{
			get => GetPropertyValue<CHandle<CyberwareDataView>>();
			set => SetPropertyValue<CHandle<CyberwareDataView>>(value);
		}

		[Ordinal(49)] 
		[RED("currentFilter")] 
		public CEnum<RipperdocFilter> CurrentFilter
		{
			get => GetPropertyValue<CEnum<RipperdocFilter>>();
			set => SetPropertyValue<CEnum<RipperdocFilter>>(value);
		}

		[Ordinal(50)] 
		[RED("radioGroup")] 
		public CWeakHandle<FilterRadioGroup> RadioGroup
		{
			get => GetPropertyValue<CWeakHandle<FilterRadioGroup>>();
			set => SetPropertyValue<CWeakHandle<FilterRadioGroup>>(value);
		}

		[Ordinal(51)] 
		[RED("ripperId")] 
		public CWeakHandle<RipperdocIdPanel> RipperId
		{
			get => GetPropertyValue<CWeakHandle<RipperdocIdPanel>>();
			set => SetPropertyValue<CWeakHandle<RipperdocIdPanel>>(value);
		}

		[Ordinal(52)] 
		[RED("selectedArea")] 
		public CEnum<gamedataEquipmentArea> SelectedArea
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(53)] 
		[RED("equipmentGrid")] 
		public CWeakHandle<CyberwareInventoryMiniGrid> EquipmentGrid
		{
			get => GetPropertyValue<CWeakHandle<CyberwareInventoryMiniGrid>>();
			set => SetPropertyValue<CWeakHandle<CyberwareInventoryMiniGrid>>(value);
		}

		[Ordinal(54)] 
		[RED("inventoryListener")] 
		public CHandle<gameInventoryScriptListener> InventoryListener
		{
			get => GetPropertyValue<CHandle<gameInventoryScriptListener>>();
			set => SetPropertyValue<CHandle<gameInventoryScriptListener>>(value);
		}

		[Ordinal(55)] 
		[RED("cybewareGrids")] 
		public CArray<CWeakHandle<CyberwareInventoryMiniGrid>> CybewareGrids
		{
			get => GetPropertyValue<CArray<CWeakHandle<CyberwareInventoryMiniGrid>>>();
			set => SetPropertyValue<CArray<CWeakHandle<CyberwareInventoryMiniGrid>>>(value);
		}

		[Ordinal(56)] 
		[RED("isActivePanel")] 
		public CBool IsActivePanel
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(57)] 
		[RED("equiped")] 
		public CBool Equiped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(58)] 
		[RED("activeSlotIndex")] 
		public CInt32 ActiveSlotIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(59)] 
		[RED("animationController")] 
		public CWeakHandle<RipperdocScreenAnimationController> AnimationController
		{
			get => GetPropertyValue<CWeakHandle<RipperdocScreenAnimationController>>();
			set => SetPropertyValue<CWeakHandle<RipperdocScreenAnimationController>>(value);
		}

		[Ordinal(60)] 
		[RED("tokenPopup")] 
		public CHandle<inkGameNotificationToken> TokenPopup
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(61)] 
		[RED("useAlternativeSwitch")] 
		public CBool UseAlternativeSwitch
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RipperDocGameController()
		{
			TooltipsManagerRef = new inkWidgetReference();
			ButtonHintsManagerRef = new inkWidgetReference();
			AnimationControllerContainer = new inkWidgetReference();
			RipperdocIdContainerV1 = new inkWidgetReference();
			RipperdocIdContainerV2 = new inkWidgetReference();
			FrontalCortexAnchor = new inkCompoundWidgetReference();
			OcularCortexAnchor = new inkCompoundWidgetReference();
			LeftMiddleGridAnchor = new inkCompoundWidgetReference();
			LeftButtomGridAnchor = new inkCompoundWidgetReference();
			RightTopGridAnchor = new inkCompoundWidgetReference();
			RightButtomGridAnchor = new inkCompoundWidgetReference();
			SkeletonAnchor = new inkCompoundWidgetReference();
			HandsAnchor = new inkCompoundWidgetReference();
			PlayerMoney = new inkTextWidgetReference();
			PlayerMoneyHolder = new inkWidgetReference();
			AllocationPointContainerDefault = new inkCompoundWidgetReference();
			CyberwareSlotsList = new inkCompoundWidgetReference();
			CyberwareVirtualGrid = new inkVirtualCompoundWidgetReference();
			RadioGroupRef = new inkWidgetReference();
			CyberwareInfoContainer = new inkCompoundWidgetReference();
			ItemsListScrollAreaContainer = new inkWidgetReference();
			SortingButton = new inkWidgetReference();
			SortingDropdown = new inkWidgetReference();
			CybewareGrids = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
