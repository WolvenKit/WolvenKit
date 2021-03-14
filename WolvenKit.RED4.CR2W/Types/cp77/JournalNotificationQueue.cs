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
		private CHandle<gameIBlackboard> _newAreablackboard;
		private CHandle<UI_MapDef> _newAreaDef;
		private CUInt32 _newAreaID;
		private CHandle<gameIBlackboard> _tutorialBlackboard;
		private CHandle<UIGameDataDef> _tutorialDef;
		private CUInt32 _tutorialID;
		private CUInt32 _tutorialDataID;
		private CBool _isHiddenByTutorial;
		private CUInt32 _customQuestNotificationblackBoardID;
		private CHandle<UI_CustomQuestNotificationDef> _customQuestNotificationblackboardDef;
		private CHandle<gameIBlackboard> _customQuestNotificationblackboard;
		private wCHandle<gameTransactionSystem> _transactionSystem;
		private wCHandle<gameObject> _playerPuppet;
		private CHandle<gameIBlackboard> _activeVehicleBlackboard;
		private CUInt32 _mountBBConnectionId;
		private CBool _isPlayerMounted;
		private CHandle<gameIBlackboard> _blackboard;
		private CHandle<UI_SystemDef> _uiSystemBB;
		private CUInt32 _uiSystemId;
		private CUInt32 _trackedMappinId;
		private CHandle<gameuiGameSystemUI> _uiSystem;
		private wCHandle<gameInventoryScriptListener> _shardTransactionListener;

		[Ordinal(2)] 
		[RED("showDuration")] 
		public CFloat ShowDuration
		{
			get
			{
				if (_showDuration == null)
				{
					_showDuration = (CFloat) CR2WTypeManager.Create("Float", "showDuration", cr2w, this);
				}
				return _showDuration;
			}
			set
			{
				if (_showDuration == value)
				{
					return;
				}
				_showDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("currencyNotification")] 
		public CName CurrencyNotification
		{
			get
			{
				if (_currencyNotification == null)
				{
					_currencyNotification = (CName) CR2WTypeManager.Create("CName", "currencyNotification", cr2w, this);
				}
				return _currencyNotification;
			}
			set
			{
				if (_currencyNotification == value)
				{
					return;
				}
				_currencyNotification = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("shardNotification")] 
		public CName ShardNotification
		{
			get
			{
				if (_shardNotification == null)
				{
					_shardNotification = (CName) CR2WTypeManager.Create("CName", "shardNotification", cr2w, this);
				}
				return _shardNotification;
			}
			set
			{
				if (_shardNotification == value)
				{
					return;
				}
				_shardNotification = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("itemNotification")] 
		public CName ItemNotification
		{
			get
			{
				if (_itemNotification == null)
				{
					_itemNotification = (CName) CR2WTypeManager.Create("CName", "itemNotification", cr2w, this);
				}
				return _itemNotification;
			}
			set
			{
				if (_itemNotification == value)
				{
					return;
				}
				_itemNotification = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("questNotification")] 
		public CName QuestNotification
		{
			get
			{
				if (_questNotification == null)
				{
					_questNotification = (CName) CR2WTypeManager.Create("CName", "questNotification", cr2w, this);
				}
				return _questNotification;
			}
			set
			{
				if (_questNotification == value)
				{
					return;
				}
				_questNotification = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("genericNotification")] 
		public CName GenericNotification
		{
			get
			{
				if (_genericNotification == null)
				{
					_genericNotification = (CName) CR2WTypeManager.Create("CName", "genericNotification", cr2w, this);
				}
				return _genericNotification;
			}
			set
			{
				if (_genericNotification == value)
				{
					return;
				}
				_genericNotification = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("messageNotification")] 
		public CName MessageNotification
		{
			get
			{
				if (_messageNotification == null)
				{
					_messageNotification = (CName) CR2WTypeManager.Create("CName", "messageNotification", cr2w, this);
				}
				return _messageNotification;
			}
			set
			{
				if (_messageNotification == value)
				{
					return;
				}
				_messageNotification = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("journalMgr")] 
		public wCHandle<gameJournalManager> JournalMgr
		{
			get
			{
				if (_journalMgr == null)
				{
					_journalMgr = (wCHandle<gameJournalManager>) CR2WTypeManager.Create("whandle:gameJournalManager", "journalMgr", cr2w, this);
				}
				return _journalMgr;
			}
			set
			{
				if (_journalMgr == value)
				{
					return;
				}
				_journalMgr = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("newAreablackboard")] 
		public CHandle<gameIBlackboard> NewAreablackboard
		{
			get
			{
				if (_newAreablackboard == null)
				{
					_newAreablackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "newAreablackboard", cr2w, this);
				}
				return _newAreablackboard;
			}
			set
			{
				if (_newAreablackboard == value)
				{
					return;
				}
				_newAreablackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("newAreaDef")] 
		public CHandle<UI_MapDef> NewAreaDef
		{
			get
			{
				if (_newAreaDef == null)
				{
					_newAreaDef = (CHandle<UI_MapDef>) CR2WTypeManager.Create("handle:UI_MapDef", "newAreaDef", cr2w, this);
				}
				return _newAreaDef;
			}
			set
			{
				if (_newAreaDef == value)
				{
					return;
				}
				_newAreaDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("newAreaID")] 
		public CUInt32 NewAreaID
		{
			get
			{
				if (_newAreaID == null)
				{
					_newAreaID = (CUInt32) CR2WTypeManager.Create("Uint32", "newAreaID", cr2w, this);
				}
				return _newAreaID;
			}
			set
			{
				if (_newAreaID == value)
				{
					return;
				}
				_newAreaID = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("tutorialBlackboard")] 
		public CHandle<gameIBlackboard> TutorialBlackboard
		{
			get
			{
				if (_tutorialBlackboard == null)
				{
					_tutorialBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "tutorialBlackboard", cr2w, this);
				}
				return _tutorialBlackboard;
			}
			set
			{
				if (_tutorialBlackboard == value)
				{
					return;
				}
				_tutorialBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("tutorialDef")] 
		public CHandle<UIGameDataDef> TutorialDef
		{
			get
			{
				if (_tutorialDef == null)
				{
					_tutorialDef = (CHandle<UIGameDataDef>) CR2WTypeManager.Create("handle:UIGameDataDef", "tutorialDef", cr2w, this);
				}
				return _tutorialDef;
			}
			set
			{
				if (_tutorialDef == value)
				{
					return;
				}
				_tutorialDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("tutorialID")] 
		public CUInt32 TutorialID
		{
			get
			{
				if (_tutorialID == null)
				{
					_tutorialID = (CUInt32) CR2WTypeManager.Create("Uint32", "tutorialID", cr2w, this);
				}
				return _tutorialID;
			}
			set
			{
				if (_tutorialID == value)
				{
					return;
				}
				_tutorialID = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("tutorialDataID")] 
		public CUInt32 TutorialDataID
		{
			get
			{
				if (_tutorialDataID == null)
				{
					_tutorialDataID = (CUInt32) CR2WTypeManager.Create("Uint32", "tutorialDataID", cr2w, this);
				}
				return _tutorialDataID;
			}
			set
			{
				if (_tutorialDataID == value)
				{
					return;
				}
				_tutorialDataID = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("isHiddenByTutorial")] 
		public CBool IsHiddenByTutorial
		{
			get
			{
				if (_isHiddenByTutorial == null)
				{
					_isHiddenByTutorial = (CBool) CR2WTypeManager.Create("Bool", "isHiddenByTutorial", cr2w, this);
				}
				return _isHiddenByTutorial;
			}
			set
			{
				if (_isHiddenByTutorial == value)
				{
					return;
				}
				_isHiddenByTutorial = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("customQuestNotificationblackBoardID")] 
		public CUInt32 CustomQuestNotificationblackBoardID
		{
			get
			{
				if (_customQuestNotificationblackBoardID == null)
				{
					_customQuestNotificationblackBoardID = (CUInt32) CR2WTypeManager.Create("Uint32", "customQuestNotificationblackBoardID", cr2w, this);
				}
				return _customQuestNotificationblackBoardID;
			}
			set
			{
				if (_customQuestNotificationblackBoardID == value)
				{
					return;
				}
				_customQuestNotificationblackBoardID = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("customQuestNotificationblackboardDef")] 
		public CHandle<UI_CustomQuestNotificationDef> CustomQuestNotificationblackboardDef
		{
			get
			{
				if (_customQuestNotificationblackboardDef == null)
				{
					_customQuestNotificationblackboardDef = (CHandle<UI_CustomQuestNotificationDef>) CR2WTypeManager.Create("handle:UI_CustomQuestNotificationDef", "customQuestNotificationblackboardDef", cr2w, this);
				}
				return _customQuestNotificationblackboardDef;
			}
			set
			{
				if (_customQuestNotificationblackboardDef == value)
				{
					return;
				}
				_customQuestNotificationblackboardDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("customQuestNotificationblackboard")] 
		public CHandle<gameIBlackboard> CustomQuestNotificationblackboard
		{
			get
			{
				if (_customQuestNotificationblackboard == null)
				{
					_customQuestNotificationblackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "customQuestNotificationblackboard", cr2w, this);
				}
				return _customQuestNotificationblackboard;
			}
			set
			{
				if (_customQuestNotificationblackboard == value)
				{
					return;
				}
				_customQuestNotificationblackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("transactionSystem")] 
		public wCHandle<gameTransactionSystem> TransactionSystem
		{
			get
			{
				if (_transactionSystem == null)
				{
					_transactionSystem = (wCHandle<gameTransactionSystem>) CR2WTypeManager.Create("whandle:gameTransactionSystem", "transactionSystem", cr2w, this);
				}
				return _transactionSystem;
			}
			set
			{
				if (_transactionSystem == value)
				{
					return;
				}
				_transactionSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("playerPuppet")] 
		public wCHandle<gameObject> PlayerPuppet
		{
			get
			{
				if (_playerPuppet == null)
				{
					_playerPuppet = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "playerPuppet", cr2w, this);
				}
				return _playerPuppet;
			}
			set
			{
				if (_playerPuppet == value)
				{
					return;
				}
				_playerPuppet = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("activeVehicleBlackboard")] 
		public CHandle<gameIBlackboard> ActiveVehicleBlackboard
		{
			get
			{
				if (_activeVehicleBlackboard == null)
				{
					_activeVehicleBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "activeVehicleBlackboard", cr2w, this);
				}
				return _activeVehicleBlackboard;
			}
			set
			{
				if (_activeVehicleBlackboard == value)
				{
					return;
				}
				_activeVehicleBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("mountBBConnectionId")] 
		public CUInt32 MountBBConnectionId
		{
			get
			{
				if (_mountBBConnectionId == null)
				{
					_mountBBConnectionId = (CUInt32) CR2WTypeManager.Create("Uint32", "mountBBConnectionId", cr2w, this);
				}
				return _mountBBConnectionId;
			}
			set
			{
				if (_mountBBConnectionId == value)
				{
					return;
				}
				_mountBBConnectionId = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("isPlayerMounted")] 
		public CBool IsPlayerMounted
		{
			get
			{
				if (_isPlayerMounted == null)
				{
					_isPlayerMounted = (CBool) CR2WTypeManager.Create("Bool", "isPlayerMounted", cr2w, this);
				}
				return _isPlayerMounted;
			}
			set
			{
				if (_isPlayerMounted == value)
				{
					return;
				}
				_isPlayerMounted = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("blackboard")] 
		public CHandle<gameIBlackboard> Blackboard
		{
			get
			{
				if (_blackboard == null)
				{
					_blackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "blackboard", cr2w, this);
				}
				return _blackboard;
			}
			set
			{
				if (_blackboard == value)
				{
					return;
				}
				_blackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("uiSystemBB")] 
		public CHandle<UI_SystemDef> UiSystemBB
		{
			get
			{
				if (_uiSystemBB == null)
				{
					_uiSystemBB = (CHandle<UI_SystemDef>) CR2WTypeManager.Create("handle:UI_SystemDef", "uiSystemBB", cr2w, this);
				}
				return _uiSystemBB;
			}
			set
			{
				if (_uiSystemBB == value)
				{
					return;
				}
				_uiSystemBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("uiSystemId")] 
		public CUInt32 UiSystemId
		{
			get
			{
				if (_uiSystemId == null)
				{
					_uiSystemId = (CUInt32) CR2WTypeManager.Create("Uint32", "uiSystemId", cr2w, this);
				}
				return _uiSystemId;
			}
			set
			{
				if (_uiSystemId == value)
				{
					return;
				}
				_uiSystemId = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("trackedMappinId")] 
		public CUInt32 TrackedMappinId
		{
			get
			{
				if (_trackedMappinId == null)
				{
					_trackedMappinId = (CUInt32) CR2WTypeManager.Create("Uint32", "trackedMappinId", cr2w, this);
				}
				return _trackedMappinId;
			}
			set
			{
				if (_trackedMappinId == value)
				{
					return;
				}
				_trackedMappinId = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get
			{
				if (_uiSystem == null)
				{
					_uiSystem = (CHandle<gameuiGameSystemUI>) CR2WTypeManager.Create("handle:gameuiGameSystemUI", "uiSystem", cr2w, this);
				}
				return _uiSystem;
			}
			set
			{
				if (_uiSystem == value)
				{
					return;
				}
				_uiSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("shardTransactionListener")] 
		public wCHandle<gameInventoryScriptListener> ShardTransactionListener
		{
			get
			{
				if (_shardTransactionListener == null)
				{
					_shardTransactionListener = (wCHandle<gameInventoryScriptListener>) CR2WTypeManager.Create("whandle:gameInventoryScriptListener", "shardTransactionListener", cr2w, this);
				}
				return _shardTransactionListener;
			}
			set
			{
				if (_shardTransactionListener == value)
				{
					return;
				}
				_shardTransactionListener = value;
				PropertySet(this);
			}
		}

		public JournalNotificationQueue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
