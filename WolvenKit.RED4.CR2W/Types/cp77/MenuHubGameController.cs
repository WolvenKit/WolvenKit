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
		private CHandle<gameIBlackboard> _playerStatsBlackboard;
		private CHandle<gameIBlackboard> _hubMenuBlackboard;
		private CUInt32 _characterCredListener;
		private CUInt32 _characterLevelListener;
		private CUInt32 _characterCurrentXPListener;
		private CUInt32 _characterCredPointsListener;
		private CUInt32 _weightListener;
		private CUInt32 _maxWeightListener;
		private CUInt32 _submenuHiddenListener;
		private CUInt32 _metaQuestStatusListener;
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
		private CHandle<gameuiTimeDisplayLogicController> _gameTimeController;
		private CHandle<OpenMenuRequest> _previousRequest;
		private CHandle<OpenMenuRequest> _currentRequest;

		[Ordinal(3)] 
		[RED("menusData")] 
		public CHandle<MenuDataBuilder> MenusData
		{
			get
			{
				if (_menusData == null)
				{
					_menusData = (CHandle<MenuDataBuilder>) CR2WTypeManager.Create("handle:MenuDataBuilder", "menusData", cr2w, this);
				}
				return _menusData;
			}
			set
			{
				if (_menusData == value)
				{
					return;
				}
				_menusData = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get
			{
				if (_menuEventDispatcher == null)
				{
					_menuEventDispatcher = (wCHandle<inkMenuEventDispatcher>) CR2WTypeManager.Create("whandle:inkMenuEventDispatcher", "menuEventDispatcher", cr2w, this);
				}
				return _menuEventDispatcher;
			}
			set
			{
				if (_menuEventDispatcher == value)
				{
					return;
				}
				_menuEventDispatcher = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("menuCtrl")] 
		public wCHandle<MenuHubLogicController> MenuCtrl
		{
			get
			{
				if (_menuCtrl == null)
				{
					_menuCtrl = (wCHandle<MenuHubLogicController>) CR2WTypeManager.Create("whandle:MenuHubLogicController", "menuCtrl", cr2w, this);
				}
				return _menuCtrl;
			}
			set
			{
				if (_menuCtrl == value)
				{
					return;
				}
				_menuCtrl = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("metaCtrl")] 
		public wCHandle<MetaQuestLogicController> MetaCtrl
		{
			get
			{
				if (_metaCtrl == null)
				{
					_metaCtrl = (wCHandle<MetaQuestLogicController>) CR2WTypeManager.Create("whandle:MetaQuestLogicController", "metaCtrl", cr2w, this);
				}
				return _metaCtrl;
			}
			set
			{
				if (_metaCtrl == value)
				{
					return;
				}
				_metaCtrl = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("subMenuCtrl")] 
		public wCHandle<SubMenuPanelLogicController> SubMenuCtrl
		{
			get
			{
				if (_subMenuCtrl == null)
				{
					_subMenuCtrl = (wCHandle<SubMenuPanelLogicController>) CR2WTypeManager.Create("whandle:SubMenuPanelLogicController", "subMenuCtrl", cr2w, this);
				}
				return _subMenuCtrl;
			}
			set
			{
				if (_subMenuCtrl == value)
				{
					return;
				}
				_subMenuCtrl = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("timeCtrl")] 
		public wCHandle<HubTimeSkipController> TimeCtrl
		{
			get
			{
				if (_timeCtrl == null)
				{
					_timeCtrl = (wCHandle<HubTimeSkipController>) CR2WTypeManager.Create("whandle:HubTimeSkipController", "timeCtrl", cr2w, this);
				}
				return _timeCtrl;
			}
			set
			{
				if (_timeCtrl == value)
				{
					return;
				}
				_timeCtrl = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("playerDevSystem")] 
		public CHandle<PlayerDevelopmentSystem> PlayerDevSystem
		{
			get
			{
				if (_playerDevSystem == null)
				{
					_playerDevSystem = (CHandle<PlayerDevelopmentSystem>) CR2WTypeManager.Create("handle:PlayerDevelopmentSystem", "playerDevSystem", cr2w, this);
				}
				return _playerDevSystem;
			}
			set
			{
				if (_playerDevSystem == value)
				{
					return;
				}
				_playerDevSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("transaction")] 
		public CHandle<gameTransactionSystem> Transaction
		{
			get
			{
				if (_transaction == null)
				{
					_transaction = (CHandle<gameTransactionSystem>) CR2WTypeManager.Create("handle:gameTransactionSystem", "transaction", cr2w, this);
				}
				return _transaction;
			}
			set
			{
				if (_transaction == value)
				{
					return;
				}
				_transaction = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("playerStatsBlackboard")] 
		public CHandle<gameIBlackboard> PlayerStatsBlackboard
		{
			get
			{
				if (_playerStatsBlackboard == null)
				{
					_playerStatsBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "playerStatsBlackboard", cr2w, this);
				}
				return _playerStatsBlackboard;
			}
			set
			{
				if (_playerStatsBlackboard == value)
				{
					return;
				}
				_playerStatsBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("hubMenuBlackboard")] 
		public CHandle<gameIBlackboard> HubMenuBlackboard
		{
			get
			{
				if (_hubMenuBlackboard == null)
				{
					_hubMenuBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "hubMenuBlackboard", cr2w, this);
				}
				return _hubMenuBlackboard;
			}
			set
			{
				if (_hubMenuBlackboard == value)
				{
					return;
				}
				_hubMenuBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("characterCredListener")] 
		public CUInt32 CharacterCredListener
		{
			get
			{
				if (_characterCredListener == null)
				{
					_characterCredListener = (CUInt32) CR2WTypeManager.Create("Uint32", "characterCredListener", cr2w, this);
				}
				return _characterCredListener;
			}
			set
			{
				if (_characterCredListener == value)
				{
					return;
				}
				_characterCredListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("characterLevelListener")] 
		public CUInt32 CharacterLevelListener
		{
			get
			{
				if (_characterLevelListener == null)
				{
					_characterLevelListener = (CUInt32) CR2WTypeManager.Create("Uint32", "characterLevelListener", cr2w, this);
				}
				return _characterLevelListener;
			}
			set
			{
				if (_characterLevelListener == value)
				{
					return;
				}
				_characterLevelListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("characterCurrentXPListener")] 
		public CUInt32 CharacterCurrentXPListener
		{
			get
			{
				if (_characterCurrentXPListener == null)
				{
					_characterCurrentXPListener = (CUInt32) CR2WTypeManager.Create("Uint32", "characterCurrentXPListener", cr2w, this);
				}
				return _characterCurrentXPListener;
			}
			set
			{
				if (_characterCurrentXPListener == value)
				{
					return;
				}
				_characterCurrentXPListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("characterCredPointsListener")] 
		public CUInt32 CharacterCredPointsListener
		{
			get
			{
				if (_characterCredPointsListener == null)
				{
					_characterCredPointsListener = (CUInt32) CR2WTypeManager.Create("Uint32", "characterCredPointsListener", cr2w, this);
				}
				return _characterCredPointsListener;
			}
			set
			{
				if (_characterCredPointsListener == value)
				{
					return;
				}
				_characterCredPointsListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("weightListener")] 
		public CUInt32 WeightListener
		{
			get
			{
				if (_weightListener == null)
				{
					_weightListener = (CUInt32) CR2WTypeManager.Create("Uint32", "weightListener", cr2w, this);
				}
				return _weightListener;
			}
			set
			{
				if (_weightListener == value)
				{
					return;
				}
				_weightListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("maxWeightListener")] 
		public CUInt32 MaxWeightListener
		{
			get
			{
				if (_maxWeightListener == null)
				{
					_maxWeightListener = (CUInt32) CR2WTypeManager.Create("Uint32", "maxWeightListener", cr2w, this);
				}
				return _maxWeightListener;
			}
			set
			{
				if (_maxWeightListener == value)
				{
					return;
				}
				_maxWeightListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("submenuHiddenListener")] 
		public CUInt32 SubmenuHiddenListener
		{
			get
			{
				if (_submenuHiddenListener == null)
				{
					_submenuHiddenListener = (CUInt32) CR2WTypeManager.Create("Uint32", "submenuHiddenListener", cr2w, this);
				}
				return _submenuHiddenListener;
			}
			set
			{
				if (_submenuHiddenListener == value)
				{
					return;
				}
				_submenuHiddenListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("metaQuestStatusListener")] 
		public CUInt32 MetaQuestStatusListener
		{
			get
			{
				if (_metaQuestStatusListener == null)
				{
					_metaQuestStatusListener = (CUInt32) CR2WTypeManager.Create("Uint32", "metaQuestStatusListener", cr2w, this);
				}
				return _metaQuestStatusListener;
			}
			set
			{
				if (_metaQuestStatusListener == value)
				{
					return;
				}
				_metaQuestStatusListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("journalManager")] 
		public wCHandle<gameJournalManager> JournalManager
		{
			get
			{
				if (_journalManager == null)
				{
					_journalManager = (wCHandle<gameJournalManager>) CR2WTypeManager.Create("whandle:gameJournalManager", "journalManager", cr2w, this);
				}
				return _journalManager;
			}
			set
			{
				if (_journalManager == value)
				{
					return;
				}
				_journalManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("trackedEntry")] 
		public wCHandle<gameJournalQuestObjective> TrackedEntry
		{
			get
			{
				if (_trackedEntry == null)
				{
					_trackedEntry = (wCHandle<gameJournalQuestObjective>) CR2WTypeManager.Create("whandle:gameJournalQuestObjective", "trackedEntry", cr2w, this);
				}
				return _trackedEntry;
			}
			set
			{
				if (_trackedEntry == value)
				{
					return;
				}
				_trackedEntry = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("trackedPhase")] 
		public wCHandle<gameJournalQuestPhase> TrackedPhase
		{
			get
			{
				if (_trackedPhase == null)
				{
					_trackedPhase = (wCHandle<gameJournalQuestPhase>) CR2WTypeManager.Create("whandle:gameJournalQuestPhase", "trackedPhase", cr2w, this);
				}
				return _trackedPhase;
			}
			set
			{
				if (_trackedPhase == value)
				{
					return;
				}
				_trackedPhase = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("trackedQuest")] 
		public wCHandle<gameJournalQuest> TrackedQuest
		{
			get
			{
				if (_trackedQuest == null)
				{
					_trackedQuest = (wCHandle<gameJournalQuest>) CR2WTypeManager.Create("whandle:gameJournalQuest", "trackedQuest", cr2w, this);
				}
				return _trackedQuest;
			}
			set
			{
				if (_trackedQuest == value)
				{
					return;
				}
				_trackedQuest = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("notificationRoot")] 
		public inkWidgetReference NotificationRoot
		{
			get
			{
				if (_notificationRoot == null)
				{
					_notificationRoot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "notificationRoot", cr2w, this);
				}
				return _notificationRoot;
			}
			set
			{
				if (_notificationRoot == value)
				{
					return;
				}
				_notificationRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get
			{
				if (_buttonHintsManagerRef == null)
				{
					_buttonHintsManagerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonHintsManagerRef", cr2w, this);
				}
				return _buttonHintsManagerRef;
			}
			set
			{
				if (_buttonHintsManagerRef == value)
				{
					return;
				}
				_buttonHintsManagerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("bgFluff")] 
		public inkWidgetReference BgFluff
		{
			get
			{
				if (_bgFluff == null)
				{
					_bgFluff = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "bgFluff", cr2w, this);
				}
				return _bgFluff;
			}
			set
			{
				if (_bgFluff == value)
				{
					return;
				}
				_bgFluff = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("dataManager")] 
		public CHandle<PlayerDevelopmentDataManager> DataManager
		{
			get
			{
				if (_dataManager == null)
				{
					_dataManager = (CHandle<PlayerDevelopmentDataManager>) CR2WTypeManager.Create("handle:PlayerDevelopmentDataManager", "dataManager", cr2w, this);
				}
				return _dataManager;
			}
			set
			{
				if (_dataManager == value)
				{
					return;
				}
				_dataManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get
			{
				if (_buttonHintsController == null)
				{
					_buttonHintsController = (wCHandle<ButtonHints>) CR2WTypeManager.Create("whandle:ButtonHints", "buttonHintsController", cr2w, this);
				}
				return _buttonHintsController;
			}
			set
			{
				if (_buttonHintsController == value)
				{
					return;
				}
				_buttonHintsController = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("gameTimeContainer")] 
		public inkWidgetReference GameTimeContainer
		{
			get
			{
				if (_gameTimeContainer == null)
				{
					_gameTimeContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "gameTimeContainer", cr2w, this);
				}
				return _gameTimeContainer;
			}
			set
			{
				if (_gameTimeContainer == value)
				{
					return;
				}
				_gameTimeContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("gameTimeController")] 
		public CHandle<gameuiTimeDisplayLogicController> GameTimeController
		{
			get
			{
				if (_gameTimeController == null)
				{
					_gameTimeController = (CHandle<gameuiTimeDisplayLogicController>) CR2WTypeManager.Create("handle:gameuiTimeDisplayLogicController", "gameTimeController", cr2w, this);
				}
				return _gameTimeController;
			}
			set
			{
				if (_gameTimeController == value)
				{
					return;
				}
				_gameTimeController = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("previousRequest")] 
		public CHandle<OpenMenuRequest> PreviousRequest
		{
			get
			{
				if (_previousRequest == null)
				{
					_previousRequest = (CHandle<OpenMenuRequest>) CR2WTypeManager.Create("handle:OpenMenuRequest", "previousRequest", cr2w, this);
				}
				return _previousRequest;
			}
			set
			{
				if (_previousRequest == value)
				{
					return;
				}
				_previousRequest = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("currentRequest")] 
		public CHandle<OpenMenuRequest> CurrentRequest
		{
			get
			{
				if (_currentRequest == null)
				{
					_currentRequest = (CHandle<OpenMenuRequest>) CR2WTypeManager.Create("handle:OpenMenuRequest", "currentRequest", cr2w, this);
				}
				return _currentRequest;
			}
			set
			{
				if (_currentRequest == value)
				{
					return;
				}
				_currentRequest = value;
				PropertySet(this);
			}
		}

		public MenuHubGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
