using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CraftingMainGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("tooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("tabRootRef")] 
		public inkWidgetReference TabRootRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("skillWidgetRoot")] 
		public inkCompoundWidgetReference SkillWidgetRoot
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("craftingLogicControllerContainer")] 
		public inkWidgetReference CraftingLogicControllerContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("upgradingLogicControllerContainer")] 
		public inkWidgetReference UpgradingLogicControllerContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(10)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(11)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(12)] 
		[RED("craftingSystem")] 
		public CHandle<CraftingSystem> CraftingSystem
		{
			get => GetPropertyValue<CHandle<CraftingSystem>>();
			set => SetPropertyValue<CHandle<CraftingSystem>>(value);
		}

		[Ordinal(13)] 
		[RED("playerCraftBook")] 
		public CHandle<CraftBook> PlayerCraftBook
		{
			get => GetPropertyValue<CHandle<CraftBook>>();
			set => SetPropertyValue<CHandle<CraftBook>>(value);
		}

		[Ordinal(14)] 
		[RED("VendorDataManager")] 
		public CHandle<VendorDataManager> VendorDataManager
		{
			get => GetPropertyValue<CHandle<VendorDataManager>>();
			set => SetPropertyValue<CHandle<VendorDataManager>>(value);
		}

		[Ordinal(15)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(16)] 
		[RED("uiScriptableSystem")] 
		public CWeakHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetPropertyValue<CWeakHandle<UIScriptableSystem>>();
			set => SetPropertyValue<CWeakHandle<UIScriptableSystem>>(value);
		}

		[Ordinal(17)] 
		[RED("tooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		[Ordinal(18)] 
		[RED("craftingDef")] 
		public CHandle<UI_CraftingDef> CraftingDef
		{
			get => GetPropertyValue<CHandle<UI_CraftingDef>>();
			set => SetPropertyValue<CHandle<UI_CraftingDef>>(value);
		}

		[Ordinal(19)] 
		[RED("craftingBlackboard")] 
		public CWeakHandle<gameIBlackboard> CraftingBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(20)] 
		[RED("craftingBBID")] 
		public CHandle<redCallbackObject> CraftingBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(21)] 
		[RED("levelUpBlackboard")] 
		public CWeakHandle<gameIBlackboard> LevelUpBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(22)] 
		[RED("playerLevelUpListener")] 
		public CHandle<redCallbackObject> PlayerLevelUpListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(23)] 
		[RED("mode")] 
		public CEnum<CraftingMode> Mode
		{
			get => GetPropertyValue<CEnum<CraftingMode>>();
			set => SetPropertyValue<CEnum<CraftingMode>>(value);
		}

		[Ordinal(24)] 
		[RED("isInitializeOver")] 
		public CBool IsInitializeOver
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("craftingLogicController")] 
		public CWeakHandle<CraftingLogicController> CraftingLogicController
		{
			get => GetPropertyValue<CWeakHandle<CraftingLogicController>>();
			set => SetPropertyValue<CWeakHandle<CraftingLogicController>>(value);
		}

		[Ordinal(26)] 
		[RED("upgradingLogicController")] 
		public CWeakHandle<UpgradingScreenController> UpgradingLogicController
		{
			get => GetPropertyValue<CWeakHandle<UpgradingScreenController>>();
			set => SetPropertyValue<CWeakHandle<UpgradingScreenController>>(value);
		}

		public CraftingMainGameController()
		{
			TooltipsManagerRef = new();
			TabRootRef = new();
			ButtonHintsManagerRef = new();
			SkillWidgetRoot = new();
			CraftingLogicControllerContainer = new();
			UpgradingLogicControllerContainer = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
