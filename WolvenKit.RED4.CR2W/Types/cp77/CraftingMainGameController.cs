using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CraftingMainGameController : gameuiMenuGameController
	{
		private inkWidgetReference _tooltipsManagerRef;
		private inkWidgetReference _tabRootRef;
		private inkWidgetReference _buttonHintsManagerRef;
		private inkCompoundWidgetReference _skillWidgetRoot;
		private inkWidgetReference _craftingLogicControllerContainer;
		private inkWidgetReference _upgradingLogicControllerContainer;
		private wCHandle<ButtonHints> _buttonHintsController;
		private wCHandle<PlayerPuppet> _player;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private CHandle<CraftingSystem> _craftingSystem;
		private CHandle<CraftBook> _playerCraftBook;
		private CHandle<VendorDataManager> _vendorDataManager;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private wCHandle<UIScriptableSystem> _uiScriptableSystem;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private CHandle<UI_CraftingDef> _craftingDef;
		private wCHandle<gameIBlackboard> _craftingBlackboard;
		private CHandle<redCallbackObject> _craftingBBID;
		private wCHandle<gameIBlackboard> _levelUpBlackboard;
		private CHandle<redCallbackObject> _playerLevelUpListener;
		private CEnum<CraftingMode> _mode;
		private CBool _isInitializeOver;
		private wCHandle<CraftingLogicController> _craftingLogicController;
		private wCHandle<UpgradingScreenController> _upgradingLogicController;

		[Ordinal(3)] 
		[RED("tooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetProperty(ref _tooltipsManagerRef);
			set => SetProperty(ref _tooltipsManagerRef, value);
		}

		[Ordinal(4)] 
		[RED("tabRootRef")] 
		public inkWidgetReference TabRootRef
		{
			get => GetProperty(ref _tabRootRef);
			set => SetProperty(ref _tabRootRef, value);
		}

		[Ordinal(5)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(6)] 
		[RED("skillWidgetRoot")] 
		public inkCompoundWidgetReference SkillWidgetRoot
		{
			get => GetProperty(ref _skillWidgetRoot);
			set => SetProperty(ref _skillWidgetRoot, value);
		}

		[Ordinal(7)] 
		[RED("craftingLogicControllerContainer")] 
		public inkWidgetReference CraftingLogicControllerContainer
		{
			get => GetProperty(ref _craftingLogicControllerContainer);
			set => SetProperty(ref _craftingLogicControllerContainer, value);
		}

		[Ordinal(8)] 
		[RED("upgradingLogicControllerContainer")] 
		public inkWidgetReference UpgradingLogicControllerContainer
		{
			get => GetProperty(ref _upgradingLogicControllerContainer);
			set => SetProperty(ref _upgradingLogicControllerContainer, value);
		}

		[Ordinal(9)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(10)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(11)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(12)] 
		[RED("craftingSystem")] 
		public CHandle<CraftingSystem> CraftingSystem
		{
			get => GetProperty(ref _craftingSystem);
			set => SetProperty(ref _craftingSystem, value);
		}

		[Ordinal(13)] 
		[RED("playerCraftBook")] 
		public CHandle<CraftBook> PlayerCraftBook
		{
			get => GetProperty(ref _playerCraftBook);
			set => SetProperty(ref _playerCraftBook, value);
		}

		[Ordinal(14)] 
		[RED("VendorDataManager")] 
		public CHandle<VendorDataManager> VendorDataManager
		{
			get => GetProperty(ref _vendorDataManager);
			set => SetProperty(ref _vendorDataManager, value);
		}

		[Ordinal(15)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}

		[Ordinal(16)] 
		[RED("uiScriptableSystem")] 
		public wCHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetProperty(ref _uiScriptableSystem);
			set => SetProperty(ref _uiScriptableSystem, value);
		}

		[Ordinal(17)] 
		[RED("tooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		[Ordinal(18)] 
		[RED("craftingDef")] 
		public CHandle<UI_CraftingDef> CraftingDef
		{
			get => GetProperty(ref _craftingDef);
			set => SetProperty(ref _craftingDef, value);
		}

		[Ordinal(19)] 
		[RED("craftingBlackboard")] 
		public wCHandle<gameIBlackboard> CraftingBlackboard
		{
			get => GetProperty(ref _craftingBlackboard);
			set => SetProperty(ref _craftingBlackboard, value);
		}

		[Ordinal(20)] 
		[RED("craftingBBID")] 
		public CHandle<redCallbackObject> CraftingBBID
		{
			get => GetProperty(ref _craftingBBID);
			set => SetProperty(ref _craftingBBID, value);
		}

		[Ordinal(21)] 
		[RED("levelUpBlackboard")] 
		public wCHandle<gameIBlackboard> LevelUpBlackboard
		{
			get => GetProperty(ref _levelUpBlackboard);
			set => SetProperty(ref _levelUpBlackboard, value);
		}

		[Ordinal(22)] 
		[RED("playerLevelUpListener")] 
		public CHandle<redCallbackObject> PlayerLevelUpListener
		{
			get => GetProperty(ref _playerLevelUpListener);
			set => SetProperty(ref _playerLevelUpListener, value);
		}

		[Ordinal(23)] 
		[RED("mode")] 
		public CEnum<CraftingMode> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		[Ordinal(24)] 
		[RED("isInitializeOver")] 
		public CBool IsInitializeOver
		{
			get => GetProperty(ref _isInitializeOver);
			set => SetProperty(ref _isInitializeOver, value);
		}

		[Ordinal(25)] 
		[RED("craftingLogicController")] 
		public wCHandle<CraftingLogicController> CraftingLogicController
		{
			get => GetProperty(ref _craftingLogicController);
			set => SetProperty(ref _craftingLogicController, value);
		}

		[Ordinal(26)] 
		[RED("upgradingLogicController")] 
		public wCHandle<UpgradingScreenController> UpgradingLogicController
		{
			get => GetProperty(ref _upgradingLogicController);
			set => SetProperty(ref _upgradingLogicController, value);
		}

		public CraftingMainGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
