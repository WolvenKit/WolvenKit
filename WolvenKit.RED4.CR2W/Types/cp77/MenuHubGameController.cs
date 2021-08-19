using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MenuHubGameController : gameuiMenuGameController
	{
		private CHandle<MenuDataBuilder> _menusData;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private wCHandle<MenuHubLogicController> _menuCtrl;
		private wCHandle<MetaQuestLogicController> _metaCtrl;
		private wCHandle<SubMenuPanelLogicController> _subMenuCtrl;
		private wCHandle<HubTimeSkipController> _timeCtrl;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<PlayerDevelopmentSystem> _playerDevSystem;
		private CHandle<gameTransactionSystem> _transaction;
		private wCHandle<gameIBlackboard> _playerStatsBlackboard;
		private wCHandle<gameIBlackboard> _hubMenuBlackboard;
		private CHandle<redCallbackObject> _characterCredListener;
		private CHandle<redCallbackObject> _characterLevelListener;
		private CHandle<redCallbackObject> _characterCurrentXPListener;
		private CHandle<redCallbackObject> _characterCredPointsListener;
		private CHandle<redCallbackObject> _weightListener;
		private CHandle<redCallbackObject> _maxWeightListener;
		private CHandle<redCallbackObject> _submenuHiddenListener;
		private CHandle<redCallbackObject> _metaQuestStatusListener;
		private wCHandle<gameJournalManager> _journalManager;
		private wCHandle<gameJournalQuestObjective> _trackedEntry;
		private wCHandle<gameJournalQuestPhase> _trackedPhase;
		private wCHandle<gameJournalQuest> _trackedQuest;
		private inkWidgetReference _notificationRoot;
		private inkWidgetReference _buttonHintsManagerRef;
		private inkWidgetReference _bgFluff;
		private CHandle<PlayerDevelopmentDataManager> _dataManager;
		private wCHandle<ButtonHints> _buttonHintsController;
		private inkWidgetReference _gameTimeContainer;
		private wCHandle<gameuiTimeDisplayLogicController> _gameTimeController;
		private CHandle<gameInventoryScriptListener> _inventoryListener;
		private CHandle<CurrencyUpdateCallback> _callback;
		private CUInt32 _hubMenuInstanceID;
		private CHandle<OpenMenuRequest> _previousRequest;
		private CHandle<OpenMenuRequest> _currentRequest;

		[Ordinal(3)] 
		[RED("menusData")] 
		public CHandle<MenuDataBuilder> MenusData
		{
			get => GetProperty(ref _menusData);
			set => SetProperty(ref _menusData, value);
		}

		[Ordinal(4)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(5)] 
		[RED("menuCtrl")] 
		public wCHandle<MenuHubLogicController> MenuCtrl
		{
			get => GetProperty(ref _menuCtrl);
			set => SetProperty(ref _menuCtrl, value);
		}

		[Ordinal(6)] 
		[RED("metaCtrl")] 
		public wCHandle<MetaQuestLogicController> MetaCtrl
		{
			get => GetProperty(ref _metaCtrl);
			set => SetProperty(ref _metaCtrl, value);
		}

		[Ordinal(7)] 
		[RED("subMenuCtrl")] 
		public wCHandle<SubMenuPanelLogicController> SubMenuCtrl
		{
			get => GetProperty(ref _subMenuCtrl);
			set => SetProperty(ref _subMenuCtrl, value);
		}

		[Ordinal(8)] 
		[RED("timeCtrl")] 
		public wCHandle<HubTimeSkipController> TimeCtrl
		{
			get => GetProperty(ref _timeCtrl);
			set => SetProperty(ref _timeCtrl, value);
		}

		[Ordinal(9)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(10)] 
		[RED("playerDevSystem")] 
		public CHandle<PlayerDevelopmentSystem> PlayerDevSystem
		{
			get => GetProperty(ref _playerDevSystem);
			set => SetProperty(ref _playerDevSystem, value);
		}

		[Ordinal(11)] 
		[RED("transaction")] 
		public CHandle<gameTransactionSystem> Transaction
		{
			get => GetProperty(ref _transaction);
			set => SetProperty(ref _transaction, value);
		}

		[Ordinal(12)] 
		[RED("playerStatsBlackboard")] 
		public wCHandle<gameIBlackboard> PlayerStatsBlackboard
		{
			get => GetProperty(ref _playerStatsBlackboard);
			set => SetProperty(ref _playerStatsBlackboard, value);
		}

		[Ordinal(13)] 
		[RED("hubMenuBlackboard")] 
		public wCHandle<gameIBlackboard> HubMenuBlackboard
		{
			get => GetProperty(ref _hubMenuBlackboard);
			set => SetProperty(ref _hubMenuBlackboard, value);
		}

		[Ordinal(14)] 
		[RED("characterCredListener")] 
		public CHandle<redCallbackObject> CharacterCredListener
		{
			get => GetProperty(ref _characterCredListener);
			set => SetProperty(ref _characterCredListener, value);
		}

		[Ordinal(15)] 
		[RED("characterLevelListener")] 
		public CHandle<redCallbackObject> CharacterLevelListener
		{
			get => GetProperty(ref _characterLevelListener);
			set => SetProperty(ref _characterLevelListener, value);
		}

		[Ordinal(16)] 
		[RED("characterCurrentXPListener")] 
		public CHandle<redCallbackObject> CharacterCurrentXPListener
		{
			get => GetProperty(ref _characterCurrentXPListener);
			set => SetProperty(ref _characterCurrentXPListener, value);
		}

		[Ordinal(17)] 
		[RED("characterCredPointsListener")] 
		public CHandle<redCallbackObject> CharacterCredPointsListener
		{
			get => GetProperty(ref _characterCredPointsListener);
			set => SetProperty(ref _characterCredPointsListener, value);
		}

		[Ordinal(18)] 
		[RED("weightListener")] 
		public CHandle<redCallbackObject> WeightListener
		{
			get => GetProperty(ref _weightListener);
			set => SetProperty(ref _weightListener, value);
		}

		[Ordinal(19)] 
		[RED("maxWeightListener")] 
		public CHandle<redCallbackObject> MaxWeightListener
		{
			get => GetProperty(ref _maxWeightListener);
			set => SetProperty(ref _maxWeightListener, value);
		}

		[Ordinal(20)] 
		[RED("submenuHiddenListener")] 
		public CHandle<redCallbackObject> SubmenuHiddenListener
		{
			get => GetProperty(ref _submenuHiddenListener);
			set => SetProperty(ref _submenuHiddenListener, value);
		}

		[Ordinal(21)] 
		[RED("metaQuestStatusListener")] 
		public CHandle<redCallbackObject> MetaQuestStatusListener
		{
			get => GetProperty(ref _metaQuestStatusListener);
			set => SetProperty(ref _metaQuestStatusListener, value);
		}

		[Ordinal(22)] 
		[RED("journalManager")] 
		public wCHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(23)] 
		[RED("trackedEntry")] 
		public wCHandle<gameJournalQuestObjective> TrackedEntry
		{
			get => GetProperty(ref _trackedEntry);
			set => SetProperty(ref _trackedEntry, value);
		}

		[Ordinal(24)] 
		[RED("trackedPhase")] 
		public wCHandle<gameJournalQuestPhase> TrackedPhase
		{
			get => GetProperty(ref _trackedPhase);
			set => SetProperty(ref _trackedPhase, value);
		}

		[Ordinal(25)] 
		[RED("trackedQuest")] 
		public wCHandle<gameJournalQuest> TrackedQuest
		{
			get => GetProperty(ref _trackedQuest);
			set => SetProperty(ref _trackedQuest, value);
		}

		[Ordinal(26)] 
		[RED("notificationRoot")] 
		public inkWidgetReference NotificationRoot
		{
			get => GetProperty(ref _notificationRoot);
			set => SetProperty(ref _notificationRoot, value);
		}

		[Ordinal(27)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(28)] 
		[RED("bgFluff")] 
		public inkWidgetReference BgFluff
		{
			get => GetProperty(ref _bgFluff);
			set => SetProperty(ref _bgFluff, value);
		}

		[Ordinal(29)] 
		[RED("dataManager")] 
		public CHandle<PlayerDevelopmentDataManager> DataManager
		{
			get => GetProperty(ref _dataManager);
			set => SetProperty(ref _dataManager, value);
		}

		[Ordinal(30)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(31)] 
		[RED("gameTimeContainer")] 
		public inkWidgetReference GameTimeContainer
		{
			get => GetProperty(ref _gameTimeContainer);
			set => SetProperty(ref _gameTimeContainer, value);
		}

		[Ordinal(32)] 
		[RED("gameTimeController")] 
		public wCHandle<gameuiTimeDisplayLogicController> GameTimeController
		{
			get => GetProperty(ref _gameTimeController);
			set => SetProperty(ref _gameTimeController, value);
		}

		[Ordinal(33)] 
		[RED("inventoryListener")] 
		public CHandle<gameInventoryScriptListener> InventoryListener
		{
			get => GetProperty(ref _inventoryListener);
			set => SetProperty(ref _inventoryListener, value);
		}

		[Ordinal(34)] 
		[RED("callback")] 
		public CHandle<CurrencyUpdateCallback> Callback
		{
			get => GetProperty(ref _callback);
			set => SetProperty(ref _callback, value);
		}

		[Ordinal(35)] 
		[RED("hubMenuInstanceID")] 
		public CUInt32 HubMenuInstanceID
		{
			get => GetProperty(ref _hubMenuInstanceID);
			set => SetProperty(ref _hubMenuInstanceID, value);
		}

		[Ordinal(36)] 
		[RED("previousRequest")] 
		public CHandle<OpenMenuRequest> PreviousRequest
		{
			get => GetProperty(ref _previousRequest);
			set => SetProperty(ref _previousRequest, value);
		}

		[Ordinal(37)] 
		[RED("currentRequest")] 
		public CHandle<OpenMenuRequest> CurrentRequest
		{
			get => GetProperty(ref _currentRequest);
			set => SetProperty(ref _currentRequest, value);
		}

		public MenuHubGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
