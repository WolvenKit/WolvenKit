using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiInventoryGameController : gameuiMenuGameController
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
		[RED("itemModeControllerRef")] 
		public inkWidgetReference ItemModeControllerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("defaultWrapper")] 
		public inkWidgetReference DefaultWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("itemWrapper")] 
		public inkWidgetReference ItemWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("CyberwareSlotRootRefs")] 
		public inkCompoundWidgetReference CyberwareSlotRootRefs
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("paperDollWidget")] 
		public inkWidgetReference PaperDollWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("sortingButton")] 
		public inkWidgetReference SortingButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("sortingDropdown")] 
		public inkWidgetReference SortingDropdown
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("notificationRoot")] 
		public inkWidgetReference NotificationRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("playerStatsWidget")] 
		public inkWidgetReference PlayerStatsWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("btnBackpack")] 
		public inkWidgetReference BtnBackpack
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("btnCyberware")] 
		public inkWidgetReference BtnCyberware
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("btnStats")] 
		public inkWidgetReference BtnStats
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("cyberdeckLinkContainer")] 
		public inkWidgetReference CyberdeckLinkContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("cyberdeckLinkItem")] 
		public inkWidgetReference CyberdeckLinkItem
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("itemNotificationRoot")] 
		public inkWidgetReference ItemNotificationRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("TooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		[Ordinal(21)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(22)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(23)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(24)] 
		[RED("mode")] 
		public CEnum<InventoryModes> Mode
		{
			get => GetPropertyValue<CEnum<InventoryModes>>();
			set => SetPropertyValue<CEnum<InventoryModes>>(value);
		}

		[Ordinal(25)] 
		[RED("itemViewMode")] 
		public CEnum<ItemViewModes> ItemViewMode
		{
			get => GetPropertyValue<CEnum<ItemViewModes>>();
			set => SetPropertyValue<CEnum<ItemViewModes>>(value);
		}

		[Ordinal(26)] 
		[RED("itemModeLogicController")] 
		public CWeakHandle<InventoryItemModeLogicController> ItemModeLogicController
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemModeLogicController>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemModeLogicController>>(value);
		}

		[Ordinal(27)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(28)] 
		[RED("animDef")] 
		public CHandle<inkanimDefinition> AnimDef
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(29)] 
		[RED("InventoryList")] 
		public CArray<CWeakHandle<InventoryItemDisplay>> InventoryList
		{
			get => GetPropertyValue<CArray<CWeakHandle<InventoryItemDisplay>>>();
			set => SetPropertyValue<CArray<CWeakHandle<InventoryItemDisplay>>>(value);
		}

		[Ordinal(30)] 
		[RED("WeaponsList")] 
		public CArray<CWeakHandle<InventoryItemDisplayController>> WeaponsList
		{
			get => GetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayController>>>(value);
		}

		[Ordinal(31)] 
		[RED("EquipmentList")] 
		public CArray<CWeakHandle<InventoryItemDisplayController>> EquipmentList
		{
			get => GetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayController>>>(value);
		}

		[Ordinal(32)] 
		[RED("CyberwareList")] 
		public CArray<CWeakHandle<InventoryItemDisplayController>> CyberwareList
		{
			get => GetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayController>>>(value);
		}

		[Ordinal(33)] 
		[RED("PocketList")] 
		public CArray<CWeakHandle<InventoryItemDisplayController>> PocketList
		{
			get => GetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayController>>>(value);
		}

		[Ordinal(34)] 
		[RED("ConsumablesList")] 
		public CArray<CWeakHandle<InventoryItemDisplayController>> ConsumablesList
		{
			get => GetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayController>>>(value);
		}

		[Ordinal(35)] 
		[RED("animationList")] 
		public CArray<CWeakHandle<InventoryItemDisplayController>> AnimationList
		{
			get => GetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayController>>>(value);
		}

		[Ordinal(36)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(37)] 
		[RED("uiScriptableSystem")] 
		public CWeakHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetPropertyValue<CWeakHandle<UIScriptableSystem>>();
			set => SetPropertyValue<CWeakHandle<UIScriptableSystem>>(value);
		}

		[Ordinal(38)] 
		[RED("comparisonResolver")] 
		public CHandle<ItemPreferredComparisonResolver> ComparisonResolver
		{
			get => GetPropertyValue<CHandle<ItemPreferredComparisonResolver>>();
			set => SetPropertyValue<CHandle<ItemPreferredComparisonResolver>>(value);
		}

		[Ordinal(39)] 
		[RED("equipmentSystem")] 
		public CWeakHandle<EquipmentSystem> EquipmentSystem
		{
			get => GetPropertyValue<CWeakHandle<EquipmentSystem>>();
			set => SetPropertyValue<CWeakHandle<EquipmentSystem>>(value);
		}

		[Ordinal(40)] 
		[RED("EquipAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> EquipAreas
		{
			get => GetPropertyValue<CArray<CEnum<gamedataEquipmentArea>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataEquipmentArea>>>(value);
		}

		[Ordinal(41)] 
		[RED("CyberwareAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> CyberwareAreas
		{
			get => GetPropertyValue<CArray<CEnum<gamedataEquipmentArea>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataEquipmentArea>>>(value);
		}

		[Ordinal(42)] 
		[RED("WeaponAreas")] 
		public CArray<CEnum<gamedataItemType>> WeaponAreas
		{
			get => GetPropertyValue<CArray<CEnum<gamedataItemType>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataItemType>>>(value);
		}

		[Ordinal(43)] 
		[RED("PocketAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> PocketAreas
		{
			get => GetPropertyValue<CArray<CEnum<gamedataEquipmentArea>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataEquipmentArea>>>(value);
		}

		[Ordinal(44)] 
		[RED("ConsumablesAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> ConsumablesAreas
		{
			get => GetPropertyValue<CArray<CEnum<gamedataEquipmentArea>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataEquipmentArea>>>(value);
		}

		[Ordinal(45)] 
		[RED("UIBBEquipment")] 
		public CHandle<UI_EquipmentDef> UIBBEquipment
		{
			get => GetPropertyValue<CHandle<UI_EquipmentDef>>();
			set => SetPropertyValue<CHandle<UI_EquipmentDef>>(value);
		}

		[Ordinal(46)] 
		[RED("UIBBItemMod")] 
		public CHandle<UI_ItemModSystemDef> UIBBItemMod
		{
			get => GetPropertyValue<CHandle<UI_ItemModSystemDef>>();
			set => SetPropertyValue<CHandle<UI_ItemModSystemDef>>(value);
		}

		[Ordinal(47)] 
		[RED("DisassembleCallback")] 
		public CHandle<UI_CraftingDef> DisassembleCallback
		{
			get => GetPropertyValue<CHandle<UI_CraftingDef>>();
			set => SetPropertyValue<CHandle<UI_CraftingDef>>(value);
		}

		[Ordinal(48)] 
		[RED("UIBBEquipmentBlackboard")] 
		public CWeakHandle<gameIBlackboard> UIBBEquipmentBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(49)] 
		[RED("UIBBItemModBlackbord")] 
		public CWeakHandle<gameIBlackboard> UIBBItemModBlackbord
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(50)] 
		[RED("DisassembleBlackboard")] 
		public CWeakHandle<gameIBlackboard> DisassembleBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(51)] 
		[RED("InventoryBBID")] 
		public CHandle<redCallbackObject> InventoryBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(52)] 
		[RED("EquipmentBBID")] 
		public CHandle<redCallbackObject> EquipmentBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(53)] 
		[RED("SubEquipmentBBID")] 
		public CHandle<redCallbackObject> SubEquipmentBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(54)] 
		[RED("ItemModBBID")] 
		public CHandle<redCallbackObject> ItemModBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(55)] 
		[RED("DisassembleBBID")] 
		public CHandle<redCallbackObject> DisassembleBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(56)] 
		[RED("openItemMode")] 
		public CBool OpenItemMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(57)] 
		[RED("isE3Demo")] 
		public CBool IsE3Demo
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(58)] 
		[RED("inventoryStatsListener")] 
		public CHandle<InventoryStatsListener> InventoryStatsListener
		{
			get => GetPropertyValue<CHandle<InventoryStatsListener>>();
			set => SetPropertyValue<CHandle<InventoryStatsListener>>(value);
		}

		[Ordinal(59)] 
		[RED("quantityPickerPopupToken")] 
		public CHandle<inkGameNotificationToken> QuantityPickerPopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(60)] 
		[RED("psmBlackboard")] 
		public CWeakHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(61)] 
		[RED("equipmentAreaCategoryEventQueue")] 
		public CArray<CHandle<EquipmentAreaCategoryCreated>> EquipmentAreaCategoryEventQueue
		{
			get => GetPropertyValue<CArray<CHandle<EquipmentAreaCategoryCreated>>>();
			set => SetPropertyValue<CArray<CHandle<EquipmentAreaCategoryCreated>>>(value);
		}

		[Ordinal(62)] 
		[RED("equipmentAreaCategories")] 
		public CArray<CHandle<EquipmentAreaCategory>> EquipmentAreaCategories
		{
			get => GetPropertyValue<CArray<CHandle<EquipmentAreaCategory>>>();
			set => SetPropertyValue<CArray<CHandle<EquipmentAreaCategory>>>(value);
		}

		[Ordinal(63)] 
		[RED("telemetrySystem")] 
		public CWeakHandle<gameTelemetryTelemetrySystem> TelemetrySystem
		{
			get => GetPropertyValue<CWeakHandle<gameTelemetryTelemetrySystem>>();
			set => SetPropertyValue<CWeakHandle<gameTelemetryTelemetrySystem>>(value);
		}

		public gameuiInventoryGameController()
		{
			TooltipsManagerRef = new();
			ButtonHintsManagerRef = new();
			ItemModeControllerRef = new();
			DefaultWrapper = new();
			ItemWrapper = new();
			CyberwareSlotRootRefs = new();
			PaperDollWidget = new();
			SortingButton = new();
			SortingDropdown = new();
			NotificationRoot = new();
			PlayerStatsWidget = new();
			BtnBackpack = new();
			BtnCyberware = new();
			BtnStats = new();
			CyberdeckLinkContainer = new();
			CyberdeckLinkItem = new();
			ItemNotificationRoot = new();
			InventoryList = new();
			WeaponsList = new();
			EquipmentList = new();
			CyberwareList = new();
			PocketList = new();
			ConsumablesList = new();
			AnimationList = new();
			EquipAreas = new();
			CyberwareAreas = new();
			WeaponAreas = new();
			PocketAreas = new();
			ConsumablesAreas = new();
			EquipmentAreaCategoryEventQueue = new();
			EquipmentAreaCategories = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
