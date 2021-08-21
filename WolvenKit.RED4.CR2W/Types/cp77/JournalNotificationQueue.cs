using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class JournalNotificationQueue : gameuiGenericNotificationGameController
	{
		private CFloat _showDuration;
		private CName _currencyNotification;
		private CName _shardNotification;
		private CName _itemNotification;
		private CName _questNotification;
		private CName _genericNotification;
		private CName _messageNotification;
		private wCHandle<gameJournalManager> _journalMgr;
		private wCHandle<gameIBlackboard> _newAreablackboard;
		private CHandle<UI_MapDef> _newAreaDef;
		private CHandle<redCallbackObject> _newAreaID;
		private wCHandle<gameIBlackboard> _tutorialBlackboard;
		private CHandle<UIGameDataDef> _tutorialDef;
		private CHandle<redCallbackObject> _tutorialID;
		private CHandle<redCallbackObject> _tutorialDataID;
		private CBool _isHiddenByTutorial;
		private CHandle<redCallbackObject> _customQuestNotificationblackBoardID;
		private CHandle<UI_CustomQuestNotificationDef> _customQuestNotificationblackboardDef;
		private wCHandle<gameIBlackboard> _customQuestNotificationblackboard;
		private wCHandle<gameTransactionSystem> _transactionSystem;
		private wCHandle<gameObject> _playerPuppet;
		private wCHandle<gameIBlackboard> _activeVehicleBlackboard;
		private CHandle<redCallbackObject> _mountBBConnectionId;
		private CBool _isPlayerMounted;
		private wCHandle<gameIBlackboard> _blackboard;
		private CHandle<UI_SystemDef> _uiSystemBB;
		private CHandle<redCallbackObject> _uiSystemId;
		private CHandle<redCallbackObject> _trackedMappinId;
		private CHandle<gameuiGameSystemUI> _uiSystem;
		private wCHandle<gameInventoryScriptListener> _shardTransactionListener;

		[Ordinal(2)] 
		[RED("showDuration")] 
		public CFloat ShowDuration
		{
			get => GetProperty(ref _showDuration);
			set => SetProperty(ref _showDuration, value);
		}

		[Ordinal(3)] 
		[RED("currencyNotification")] 
		public CName CurrencyNotification
		{
			get => GetProperty(ref _currencyNotification);
			set => SetProperty(ref _currencyNotification, value);
		}

		[Ordinal(4)] 
		[RED("shardNotification")] 
		public CName ShardNotification
		{
			get => GetProperty(ref _shardNotification);
			set => SetProperty(ref _shardNotification, value);
		}

		[Ordinal(5)] 
		[RED("itemNotification")] 
		public CName ItemNotification
		{
			get => GetProperty(ref _itemNotification);
			set => SetProperty(ref _itemNotification, value);
		}

		[Ordinal(6)] 
		[RED("questNotification")] 
		public CName QuestNotification
		{
			get => GetProperty(ref _questNotification);
			set => SetProperty(ref _questNotification, value);
		}

		[Ordinal(7)] 
		[RED("genericNotification")] 
		public CName GenericNotification
		{
			get => GetProperty(ref _genericNotification);
			set => SetProperty(ref _genericNotification, value);
		}

		[Ordinal(8)] 
		[RED("messageNotification")] 
		public CName MessageNotification
		{
			get => GetProperty(ref _messageNotification);
			set => SetProperty(ref _messageNotification, value);
		}

		[Ordinal(9)] 
		[RED("journalMgr")] 
		public wCHandle<gameJournalManager> JournalMgr
		{
			get => GetProperty(ref _journalMgr);
			set => SetProperty(ref _journalMgr, value);
		}

		[Ordinal(10)] 
		[RED("newAreablackboard")] 
		public wCHandle<gameIBlackboard> NewAreablackboard
		{
			get => GetProperty(ref _newAreablackboard);
			set => SetProperty(ref _newAreablackboard, value);
		}

		[Ordinal(11)] 
		[RED("newAreaDef")] 
		public CHandle<UI_MapDef> NewAreaDef
		{
			get => GetProperty(ref _newAreaDef);
			set => SetProperty(ref _newAreaDef, value);
		}

		[Ordinal(12)] 
		[RED("newAreaID")] 
		public CHandle<redCallbackObject> NewAreaID
		{
			get => GetProperty(ref _newAreaID);
			set => SetProperty(ref _newAreaID, value);
		}

		[Ordinal(13)] 
		[RED("tutorialBlackboard")] 
		public wCHandle<gameIBlackboard> TutorialBlackboard
		{
			get => GetProperty(ref _tutorialBlackboard);
			set => SetProperty(ref _tutorialBlackboard, value);
		}

		[Ordinal(14)] 
		[RED("tutorialDef")] 
		public CHandle<UIGameDataDef> TutorialDef
		{
			get => GetProperty(ref _tutorialDef);
			set => SetProperty(ref _tutorialDef, value);
		}

		[Ordinal(15)] 
		[RED("tutorialID")] 
		public CHandle<redCallbackObject> TutorialID
		{
			get => GetProperty(ref _tutorialID);
			set => SetProperty(ref _tutorialID, value);
		}

		[Ordinal(16)] 
		[RED("tutorialDataID")] 
		public CHandle<redCallbackObject> TutorialDataID
		{
			get => GetProperty(ref _tutorialDataID);
			set => SetProperty(ref _tutorialDataID, value);
		}

		[Ordinal(17)] 
		[RED("isHiddenByTutorial")] 
		public CBool IsHiddenByTutorial
		{
			get => GetProperty(ref _isHiddenByTutorial);
			set => SetProperty(ref _isHiddenByTutorial, value);
		}

		[Ordinal(18)] 
		[RED("customQuestNotificationblackBoardID")] 
		public CHandle<redCallbackObject> CustomQuestNotificationblackBoardID
		{
			get => GetProperty(ref _customQuestNotificationblackBoardID);
			set => SetProperty(ref _customQuestNotificationblackBoardID, value);
		}

		[Ordinal(19)] 
		[RED("customQuestNotificationblackboardDef")] 
		public CHandle<UI_CustomQuestNotificationDef> CustomQuestNotificationblackboardDef
		{
			get => GetProperty(ref _customQuestNotificationblackboardDef);
			set => SetProperty(ref _customQuestNotificationblackboardDef, value);
		}

		[Ordinal(20)] 
		[RED("customQuestNotificationblackboard")] 
		public wCHandle<gameIBlackboard> CustomQuestNotificationblackboard
		{
			get => GetProperty(ref _customQuestNotificationblackboard);
			set => SetProperty(ref _customQuestNotificationblackboard, value);
		}

		[Ordinal(21)] 
		[RED("transactionSystem")] 
		public wCHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetProperty(ref _transactionSystem);
			set => SetProperty(ref _transactionSystem, value);
		}

		[Ordinal(22)] 
		[RED("playerPuppet")] 
		public wCHandle<gameObject> PlayerPuppet
		{
			get => GetProperty(ref _playerPuppet);
			set => SetProperty(ref _playerPuppet, value);
		}

		[Ordinal(23)] 
		[RED("activeVehicleBlackboard")] 
		public wCHandle<gameIBlackboard> ActiveVehicleBlackboard
		{
			get => GetProperty(ref _activeVehicleBlackboard);
			set => SetProperty(ref _activeVehicleBlackboard, value);
		}

		[Ordinal(24)] 
		[RED("mountBBConnectionId")] 
		public CHandle<redCallbackObject> MountBBConnectionId
		{
			get => GetProperty(ref _mountBBConnectionId);
			set => SetProperty(ref _mountBBConnectionId, value);
		}

		[Ordinal(25)] 
		[RED("isPlayerMounted")] 
		public CBool IsPlayerMounted
		{
			get => GetProperty(ref _isPlayerMounted);
			set => SetProperty(ref _isPlayerMounted, value);
		}

		[Ordinal(26)] 
		[RED("blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(27)] 
		[RED("uiSystemBB")] 
		public CHandle<UI_SystemDef> UiSystemBB
		{
			get => GetProperty(ref _uiSystemBB);
			set => SetProperty(ref _uiSystemBB, value);
		}

		[Ordinal(28)] 
		[RED("uiSystemId")] 
		public CHandle<redCallbackObject> UiSystemId
		{
			get => GetProperty(ref _uiSystemId);
			set => SetProperty(ref _uiSystemId, value);
		}

		[Ordinal(29)] 
		[RED("trackedMappinId")] 
		public CHandle<redCallbackObject> TrackedMappinId
		{
			get => GetProperty(ref _trackedMappinId);
			set => SetProperty(ref _trackedMappinId, value);
		}

		[Ordinal(30)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetProperty(ref _uiSystem);
			set => SetProperty(ref _uiSystem, value);
		}

		[Ordinal(31)] 
		[RED("shardTransactionListener")] 
		public wCHandle<gameInventoryScriptListener> ShardTransactionListener
		{
			get => GetProperty(ref _shardTransactionListener);
			set => SetProperty(ref _shardTransactionListener, value);
		}

		public JournalNotificationQueue(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
