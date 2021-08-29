using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatsMainGameController : gameuiMenuGameController
	{
		private inkWidgetReference _mainViewRoot;
		private inkCompoundWidgetReference _statsList;
		private inkWidgetReference _tooltipsManagerRef;
		private inkWidgetReference _levelControllerRef;
		private inkWidgetReference _streetCredControllerRef;
		private inkWidgetReference _detailListControllerRef;
		private inkWidgetReference _statsStreetCredRewardRef;
		private inkWidgetReference _statsPlayTimeControllerdRef;
		private inkWidgetReference _btnInventory;
		private inkWidgetReference _buttonHintsManagerRef;
		private CWeakHandle<gameuiTooltipsManager> _tooltipsManager;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private CWeakHandle<PlayerPuppet> _player;
		private CArray<gameStatViewData> _healthStatsData;
		private CArray<gameStatViewData> _dPSStatsData;
		private CArray<gameStatViewData> _armorStatsData;
		private CArray<gameStatViewData> _otherStatsData;
		private CWeakHandle<gameIBlackboard> _playerStatsBlackboard;
		private CHandle<redCallbackObject> _currencyListener;
		private CHandle<redCallbackObject> _characterCredListener;
		private CHandle<redCallbackObject> _characterLevelListener;
		private CHandle<redCallbackObject> _characterCurrentXPListener;
		private CHandle<redCallbackObject> _characterCredPointsListener;
		private CHandle<PlayerDevelopmentSystem> _pDS;
		private CWeakHandle<StatsProgressController> _levelController;
		private CWeakHandle<StatsProgressController> _streetCredController;
		private CWeakHandle<StatsDetailListController> _detailListController;
		private CWeakHandle<StatsStreetCredReward> _statsStreetCredReward;
		private CWeakHandle<StatsPlayTimeController> _statsPlayTimeController;
		private CHandle<PreviousMenuData> _previousMenuData;
		private CWeakHandle<ButtonHints> _buttonHintsController;

		[Ordinal(3)] 
		[RED("MainViewRoot")] 
		public inkWidgetReference MainViewRoot
		{
			get => GetProperty(ref _mainViewRoot);
			set => SetProperty(ref _mainViewRoot, value);
		}

		[Ordinal(4)] 
		[RED("statsList")] 
		public inkCompoundWidgetReference StatsList
		{
			get => GetProperty(ref _statsList);
			set => SetProperty(ref _statsList, value);
		}

		[Ordinal(5)] 
		[RED("TooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetProperty(ref _tooltipsManagerRef);
			set => SetProperty(ref _tooltipsManagerRef, value);
		}

		[Ordinal(6)] 
		[RED("levelControllerRef")] 
		public inkWidgetReference LevelControllerRef
		{
			get => GetProperty(ref _levelControllerRef);
			set => SetProperty(ref _levelControllerRef, value);
		}

		[Ordinal(7)] 
		[RED("streetCredControllerRef")] 
		public inkWidgetReference StreetCredControllerRef
		{
			get => GetProperty(ref _streetCredControllerRef);
			set => SetProperty(ref _streetCredControllerRef, value);
		}

		[Ordinal(8)] 
		[RED("detailListControllerRef")] 
		public inkWidgetReference DetailListControllerRef
		{
			get => GetProperty(ref _detailListControllerRef);
			set => SetProperty(ref _detailListControllerRef, value);
		}

		[Ordinal(9)] 
		[RED("statsStreetCredRewardRef")] 
		public inkWidgetReference StatsStreetCredRewardRef
		{
			get => GetProperty(ref _statsStreetCredRewardRef);
			set => SetProperty(ref _statsStreetCredRewardRef, value);
		}

		[Ordinal(10)] 
		[RED("statsPlayTimeControllerdRef")] 
		public inkWidgetReference StatsPlayTimeControllerdRef
		{
			get => GetProperty(ref _statsPlayTimeControllerdRef);
			set => SetProperty(ref _statsPlayTimeControllerdRef, value);
		}

		[Ordinal(11)] 
		[RED("btnInventory")] 
		public inkWidgetReference BtnInventory
		{
			get => GetProperty(ref _btnInventory);
			set => SetProperty(ref _btnInventory, value);
		}

		[Ordinal(12)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(13)] 
		[RED("TooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		[Ordinal(14)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}

		[Ordinal(15)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(16)] 
		[RED("healthStatsData")] 
		public CArray<gameStatViewData> HealthStatsData
		{
			get => GetProperty(ref _healthStatsData);
			set => SetProperty(ref _healthStatsData, value);
		}

		[Ordinal(17)] 
		[RED("DPSStatsData")] 
		public CArray<gameStatViewData> DPSStatsData
		{
			get => GetProperty(ref _dPSStatsData);
			set => SetProperty(ref _dPSStatsData, value);
		}

		[Ordinal(18)] 
		[RED("armorStatsData")] 
		public CArray<gameStatViewData> ArmorStatsData
		{
			get => GetProperty(ref _armorStatsData);
			set => SetProperty(ref _armorStatsData, value);
		}

		[Ordinal(19)] 
		[RED("otherStatsData")] 
		public CArray<gameStatViewData> OtherStatsData
		{
			get => GetProperty(ref _otherStatsData);
			set => SetProperty(ref _otherStatsData, value);
		}

		[Ordinal(20)] 
		[RED("playerStatsBlackboard")] 
		public CWeakHandle<gameIBlackboard> PlayerStatsBlackboard
		{
			get => GetProperty(ref _playerStatsBlackboard);
			set => SetProperty(ref _playerStatsBlackboard, value);
		}

		[Ordinal(21)] 
		[RED("currencyListener")] 
		public CHandle<redCallbackObject> CurrencyListener
		{
			get => GetProperty(ref _currencyListener);
			set => SetProperty(ref _currencyListener, value);
		}

		[Ordinal(22)] 
		[RED("characterCredListener")] 
		public CHandle<redCallbackObject> CharacterCredListener
		{
			get => GetProperty(ref _characterCredListener);
			set => SetProperty(ref _characterCredListener, value);
		}

		[Ordinal(23)] 
		[RED("characterLevelListener")] 
		public CHandle<redCallbackObject> CharacterLevelListener
		{
			get => GetProperty(ref _characterLevelListener);
			set => SetProperty(ref _characterLevelListener, value);
		}

		[Ordinal(24)] 
		[RED("characterCurrentXPListener")] 
		public CHandle<redCallbackObject> CharacterCurrentXPListener
		{
			get => GetProperty(ref _characterCurrentXPListener);
			set => SetProperty(ref _characterCurrentXPListener, value);
		}

		[Ordinal(25)] 
		[RED("characterCredPointsListener")] 
		public CHandle<redCallbackObject> CharacterCredPointsListener
		{
			get => GetProperty(ref _characterCredPointsListener);
			set => SetProperty(ref _characterCredPointsListener, value);
		}

		[Ordinal(26)] 
		[RED("PDS")] 
		public CHandle<PlayerDevelopmentSystem> PDS
		{
			get => GetProperty(ref _pDS);
			set => SetProperty(ref _pDS, value);
		}

		[Ordinal(27)] 
		[RED("levelController")] 
		public CWeakHandle<StatsProgressController> LevelController
		{
			get => GetProperty(ref _levelController);
			set => SetProperty(ref _levelController, value);
		}

		[Ordinal(28)] 
		[RED("streetCredController")] 
		public CWeakHandle<StatsProgressController> StreetCredController
		{
			get => GetProperty(ref _streetCredController);
			set => SetProperty(ref _streetCredController, value);
		}

		[Ordinal(29)] 
		[RED("detailListController")] 
		public CWeakHandle<StatsDetailListController> DetailListController
		{
			get => GetProperty(ref _detailListController);
			set => SetProperty(ref _detailListController, value);
		}

		[Ordinal(30)] 
		[RED("statsStreetCredReward")] 
		public CWeakHandle<StatsStreetCredReward> StatsStreetCredReward
		{
			get => GetProperty(ref _statsStreetCredReward);
			set => SetProperty(ref _statsStreetCredReward, value);
		}

		[Ordinal(31)] 
		[RED("statsPlayTimeController")] 
		public CWeakHandle<StatsPlayTimeController> StatsPlayTimeController
		{
			get => GetProperty(ref _statsPlayTimeController);
			set => SetProperty(ref _statsPlayTimeController, value);
		}

		[Ordinal(32)] 
		[RED("previousMenuData")] 
		public CHandle<PreviousMenuData> PreviousMenuData
		{
			get => GetProperty(ref _previousMenuData);
			set => SetProperty(ref _previousMenuData, value);
		}

		[Ordinal(33)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}
	}
}
