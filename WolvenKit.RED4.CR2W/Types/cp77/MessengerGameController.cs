using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MessengerGameController : gameuiMenuGameController
	{
		private inkWidgetReference _buttonHintsManagerRef;
		private inkWidgetReference _contactsRef;
		private inkWidgetReference _dialogRef;
		private inkWidgetReference _virtualList;
		private wCHandle<ButtonHints> _buttonHintsController;
		private wCHandle<MessengerDialogViewController> _dialogController;
		private wCHandle<MessengerContactsVirtualNestedListController> _listController;
		private wCHandle<gameJournalManager> _journalManager;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private CHandle<MessengerContactSyncData> _activeData;

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
		[RED("contactsRef")] 
		public inkWidgetReference ContactsRef
		{
			get
			{
				if (_contactsRef == null)
				{
					_contactsRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "contactsRef", cr2w, this);
				}
				return _contactsRef;
			}
			set
			{
				if (_contactsRef == value)
				{
					return;
				}
				_contactsRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("dialogRef")] 
		public inkWidgetReference DialogRef
		{
			get
			{
				if (_dialogRef == null)
				{
					_dialogRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "dialogRef", cr2w, this);
				}
				return _dialogRef;
			}
			set
			{
				if (_dialogRef == value)
				{
					return;
				}
				_dialogRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		[Ordinal(8)] 
		[RED("dialogController")] 
		public wCHandle<MessengerDialogViewController> DialogController
		{
			get
			{
				if (_dialogController == null)
				{
					_dialogController = (wCHandle<MessengerDialogViewController>) CR2WTypeManager.Create("whandle:MessengerDialogViewController", "dialogController", cr2w, this);
				}
				return _dialogController;
			}
			set
			{
				if (_dialogController == value)
				{
					return;
				}
				_dialogController = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("listController")] 
		public wCHandle<MessengerContactsVirtualNestedListController> ListController
		{
			get
			{
				if (_listController == null)
				{
					_listController = (wCHandle<MessengerContactsVirtualNestedListController>) CR2WTypeManager.Create("whandle:MessengerContactsVirtualNestedListController", "listController", cr2w, this);
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

		[Ordinal(10)] 
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

		[Ordinal(11)] 
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

		[Ordinal(12)] 
		[RED("activeData")] 
		public CHandle<MessengerContactSyncData> ActiveData
		{
			get
			{
				if (_activeData == null)
				{
					_activeData = (CHandle<MessengerContactSyncData>) CR2WTypeManager.Create("handle:MessengerContactSyncData", "activeData", cr2w, this);
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

		public MessengerGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
