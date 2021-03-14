using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CodexGameController : gameuiMenuGameController
	{
		private inkWidgetReference _buttonHintsManagerRef;
		private inkCompoundWidgetReference _entryViewRef;
		private inkCompoundWidgetReference _characterEntryViewRef;
		private inkWidgetReference _noEntrySelectedWidget;
		private inkWidgetReference _virtualList;
		private inkWidgetReference _emptyPlaceholderRef;
		private inkWidgetReference _leftBlockControllerRef;
		private inkCompoundWidgetReference _filtersContainer;
		private wCHandle<gameJournalManager> _journalManager;
		private wCHandle<ButtonHints> _buttonHintsController;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private wCHandle<CodexListVirtualNestedListController> _listController;
		private wCHandle<CodexEntryViewController> _entryViewController;
		private wCHandle<CodexEntryViewController> _characterEntryViewController;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<CodexListSyncData> _activeData;
		private CHandle<CodexEntryData> _selectedData;
		private CInt32 _userDataEntry;
		private CBool _doubleInputPreventionFlag;
		private CArray<CHandle<CodexFilterButtonController>> _filtersControllers;

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
		[RED("characterEntryViewRef")] 
		public inkCompoundWidgetReference CharacterEntryViewRef
		{
			get
			{
				if (_characterEntryViewRef == null)
				{
					_characterEntryViewRef = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "characterEntryViewRef", cr2w, this);
				}
				return _characterEntryViewRef;
			}
			set
			{
				if (_characterEntryViewRef == value)
				{
					return;
				}
				_characterEntryViewRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("noEntrySelectedWidget")] 
		public inkWidgetReference NoEntrySelectedWidget
		{
			get
			{
				if (_noEntrySelectedWidget == null)
				{
					_noEntrySelectedWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "noEntrySelectedWidget", cr2w, this);
				}
				return _noEntrySelectedWidget;
			}
			set
			{
				if (_noEntrySelectedWidget == value)
				{
					return;
				}
				_noEntrySelectedWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
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

		[Ordinal(8)] 
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

		[Ordinal(9)] 
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

		[Ordinal(10)] 
		[RED("filtersContainer")] 
		public inkCompoundWidgetReference FiltersContainer
		{
			get
			{
				if (_filtersContainer == null)
				{
					_filtersContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "filtersContainer", cr2w, this);
				}
				return _filtersContainer;
			}
			set
			{
				if (_filtersContainer == value)
				{
					return;
				}
				_filtersContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
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

		[Ordinal(12)] 
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

		[Ordinal(13)] 
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

		[Ordinal(14)] 
		[RED("listController")] 
		public wCHandle<CodexListVirtualNestedListController> ListController
		{
			get
			{
				if (_listController == null)
				{
					_listController = (wCHandle<CodexListVirtualNestedListController>) CR2WTypeManager.Create("whandle:CodexListVirtualNestedListController", "listController", cr2w, this);
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

		[Ordinal(15)] 
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

		[Ordinal(16)] 
		[RED("characterEntryViewController")] 
		public wCHandle<CodexEntryViewController> CharacterEntryViewController
		{
			get
			{
				if (_characterEntryViewController == null)
				{
					_characterEntryViewController = (wCHandle<CodexEntryViewController>) CR2WTypeManager.Create("whandle:CodexEntryViewController", "characterEntryViewController", cr2w, this);
				}
				return _characterEntryViewController;
			}
			set
			{
				if (_characterEntryViewController == value)
				{
					return;
				}
				_characterEntryViewController = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
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

		[Ordinal(18)] 
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

		[Ordinal(19)] 
		[RED("selectedData")] 
		public CHandle<CodexEntryData> SelectedData
		{
			get
			{
				if (_selectedData == null)
				{
					_selectedData = (CHandle<CodexEntryData>) CR2WTypeManager.Create("handle:CodexEntryData", "selectedData", cr2w, this);
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

		[Ordinal(21)] 
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

		[Ordinal(22)] 
		[RED("filtersControllers")] 
		public CArray<CHandle<CodexFilterButtonController>> FiltersControllers
		{
			get
			{
				if (_filtersControllers == null)
				{
					_filtersControllers = (CArray<CHandle<CodexFilterButtonController>>) CR2WTypeManager.Create("array:handle:CodexFilterButtonController", "filtersControllers", cr2w, this);
				}
				return _filtersControllers;
			}
			set
			{
				if (_filtersControllers == value)
				{
					return;
				}
				_filtersControllers = value;
				PropertySet(this);
			}
		}

		public CodexGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
