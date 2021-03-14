using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShardsMenuGameController : gameuiMenuGameController
	{
		private inkWidgetReference _buttonHintsManagerRef;
		private inkCompoundWidgetReference _entryViewRef;
		private inkWidgetReference _virtualList;
		private inkWidgetReference _emptyPlaceholderRef;
		private inkWidgetReference _leftBlockControllerRef;
		private inkWidgetReference _crackHint;
		private wCHandle<gameJournalManager> _journalManager;
		private wCHandle<ButtonHints> _buttonHintsController;
		private wCHandle<CodexEntryViewController> _entryViewController;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private wCHandle<ShardsVirtualNestedListController> _listController;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<CodexListSyncData> _activeData;
		private CBool _hasNewCryptedEntries;
		private CBool _isEncryptedEntrySelected;
		private CHandle<ShardEntryData> _selectedData;
		private CHandle<gameIBlackboard> _mingameBB;
		private CInt32 _userDataEntry;
		private CBool _doubleInputPreventionFlag;
		private CHandle<inkanimProxy> _animationProxy;

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("entryViewRef")] 
		public inkCompoundWidgetReference EntryViewRef
		{
			get
			{
				if (_entryViewRef == null)
				{
					_entryViewRef = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "entryViewRef", cr2w, this);
				}
				return _entryViewRef;
			}
			set
			{
				if (_entryViewRef == value)
				{
					return;
				}
				_entryViewRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("virtualList")] 
		public inkWidgetReference VirtualList
		{
			get
			{
				if (_virtualList == null)
				{
					_virtualList = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "virtualList", cr2w, this);
				}
				return _virtualList;
			}
			set
			{
				if (_virtualList == value)
				{
					return;
				}
				_virtualList = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("emptyPlaceholderRef")] 
		public inkWidgetReference EmptyPlaceholderRef
		{
			get
			{
				if (_emptyPlaceholderRef == null)
				{
					_emptyPlaceholderRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "emptyPlaceholderRef", cr2w, this);
				}
				return _emptyPlaceholderRef;
			}
			set
			{
				if (_emptyPlaceholderRef == value)
				{
					return;
				}
				_emptyPlaceholderRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("leftBlockControllerRef")] 
		public inkWidgetReference LeftBlockControllerRef
		{
			get
			{
				if (_leftBlockControllerRef == null)
				{
					_leftBlockControllerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "leftBlockControllerRef", cr2w, this);
				}
				return _leftBlockControllerRef;
			}
			set
			{
				if (_leftBlockControllerRef == value)
				{
					return;
				}
				_leftBlockControllerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("crackHint")] 
		public inkWidgetReference CrackHint
		{
			get
			{
				if (_crackHint == null)
				{
					_crackHint = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "crackHint", cr2w, this);
				}
				return _crackHint;
			}
			set
			{
				if (_crackHint == value)
				{
					return;
				}
				_crackHint = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
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

		[Ordinal(10)] 
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

		[Ordinal(11)] 
		[RED("entryViewController")] 
		public wCHandle<CodexEntryViewController> EntryViewController
		{
			get
			{
				if (_entryViewController == null)
				{
					_entryViewController = (wCHandle<CodexEntryViewController>) CR2WTypeManager.Create("whandle:CodexEntryViewController", "entryViewController", cr2w, this);
				}
				return _entryViewController;
			}
			set
			{
				if (_entryViewController == value)
				{
					return;
				}
				_entryViewController = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
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

		[Ordinal(13)] 
		[RED("listController")] 
		public wCHandle<ShardsVirtualNestedListController> ListController
		{
			get
			{
				if (_listController == null)
				{
					_listController = (wCHandle<ShardsVirtualNestedListController>) CR2WTypeManager.Create("whandle:ShardsVirtualNestedListController", "listController", cr2w, this);
				}
				return _listController;
			}
			set
			{
				if (_listController == value)
				{
					return;
				}
				_listController = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get
			{
				if (_inventoryManager == null)
				{
					_inventoryManager = (CHandle<InventoryDataManagerV2>) CR2WTypeManager.Create("handle:InventoryDataManagerV2", "InventoryManager", cr2w, this);
				}
				return _inventoryManager;
			}
			set
			{
				if (_inventoryManager == value)
				{
					return;
				}
				_inventoryManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
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

		[Ordinal(16)] 
		[RED("activeData")] 
		public CHandle<CodexListSyncData> ActiveData
		{
			get
			{
				if (_activeData == null)
				{
					_activeData = (CHandle<CodexListSyncData>) CR2WTypeManager.Create("handle:CodexListSyncData", "activeData", cr2w, this);
				}
				return _activeData;
			}
			set
			{
				if (_activeData == value)
				{
					return;
				}
				_activeData = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("hasNewCryptedEntries")] 
		public CBool HasNewCryptedEntries
		{
			get
			{
				if (_hasNewCryptedEntries == null)
				{
					_hasNewCryptedEntries = (CBool) CR2WTypeManager.Create("Bool", "hasNewCryptedEntries", cr2w, this);
				}
				return _hasNewCryptedEntries;
			}
			set
			{
				if (_hasNewCryptedEntries == value)
				{
					return;
				}
				_hasNewCryptedEntries = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("isEncryptedEntrySelected")] 
		public CBool IsEncryptedEntrySelected
		{
			get
			{
				if (_isEncryptedEntrySelected == null)
				{
					_isEncryptedEntrySelected = (CBool) CR2WTypeManager.Create("Bool", "isEncryptedEntrySelected", cr2w, this);
				}
				return _isEncryptedEntrySelected;
			}
			set
			{
				if (_isEncryptedEntrySelected == value)
				{
					return;
				}
				_isEncryptedEntrySelected = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("selectedData")] 
		public CHandle<ShardEntryData> SelectedData
		{
			get
			{
				if (_selectedData == null)
				{
					_selectedData = (CHandle<ShardEntryData>) CR2WTypeManager.Create("handle:ShardEntryData", "selectedData", cr2w, this);
				}
				return _selectedData;
			}
			set
			{
				if (_selectedData == value)
				{
					return;
				}
				_selectedData = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("mingameBB")] 
		public CHandle<gameIBlackboard> MingameBB
		{
			get
			{
				if (_mingameBB == null)
				{
					_mingameBB = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "mingameBB", cr2w, this);
				}
				return _mingameBB;
			}
			set
			{
				if (_mingameBB == value)
				{
					return;
				}
				_mingameBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("userDataEntry")] 
		public CInt32 UserDataEntry
		{
			get
			{
				if (_userDataEntry == null)
				{
					_userDataEntry = (CInt32) CR2WTypeManager.Create("Int32", "userDataEntry", cr2w, this);
				}
				return _userDataEntry;
			}
			set
			{
				if (_userDataEntry == value)
				{
					return;
				}
				_userDataEntry = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("doubleInputPreventionFlag")] 
		public CBool DoubleInputPreventionFlag
		{
			get
			{
				if (_doubleInputPreventionFlag == null)
				{
					_doubleInputPreventionFlag = (CBool) CR2WTypeManager.Create("Bool", "doubleInputPreventionFlag", cr2w, this);
				}
				return _doubleInputPreventionFlag;
			}
			set
			{
				if (_doubleInputPreventionFlag == value)
				{
					return;
				}
				_doubleInputPreventionFlag = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get
			{
				if (_animationProxy == null)
				{
					_animationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animationProxy", cr2w, this);
				}
				return _animationProxy;
			}
			set
			{
				if (_animationProxy == value)
				{
					return;
				}
				_animationProxy = value;
				PropertySet(this);
			}
		}

		public ShardsMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
