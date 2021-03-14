using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SaveGameMenuGameController : gameuiSaveHandlingController
	{
		private inkCompoundWidgetReference _list;
		private inkWidgetReference _buttonHintsManagerRef;
		private wCHandle<inkMenuEventDispatcher> _eventDispatcher;
		private CBool _loadComplete;
		private wCHandle<inkISystemRequestsHandler> _handler;
		private CHandle<inkSaveMetadataInfo> _saveInfo;
		private wCHandle<ButtonHints> _buttonHintsController;
		private CBool _hasEmptySlot;
		private CBool _saveInProgress;

		[Ordinal(3)] 
		[RED("list")] 
		public inkCompoundWidgetReference List
		{
			get
			{
				if (_list == null)
				{
					_list = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "list", cr2w, this);
				}
				return _list;
			}
			set
			{
				if (_list == value)
				{
					return;
				}
				_list = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		[Ordinal(5)] 
		[RED("eventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> EventDispatcher
		{
			get
			{
				if (_eventDispatcher == null)
				{
					_eventDispatcher = (wCHandle<inkMenuEventDispatcher>) CR2WTypeManager.Create("whandle:inkMenuEventDispatcher", "eventDispatcher", cr2w, this);
				}
				return _eventDispatcher;
			}
			set
			{
				if (_eventDispatcher == value)
				{
					return;
				}
				_eventDispatcher = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("loadComplete")] 
		public CBool LoadComplete
		{
			get
			{
				if (_loadComplete == null)
				{
					_loadComplete = (CBool) CR2WTypeManager.Create("Bool", "loadComplete", cr2w, this);
				}
				return _loadComplete;
			}
			set
			{
				if (_loadComplete == value)
				{
					return;
				}
				_loadComplete = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("handler")] 
		public wCHandle<inkISystemRequestsHandler> Handler
		{
			get
			{
				if (_handler == null)
				{
					_handler = (wCHandle<inkISystemRequestsHandler>) CR2WTypeManager.Create("whandle:inkISystemRequestsHandler", "handler", cr2w, this);
				}
				return _handler;
			}
			set
			{
				if (_handler == value)
				{
					return;
				}
				_handler = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("saveInfo")] 
		public CHandle<inkSaveMetadataInfo> SaveInfo
		{
			get
			{
				if (_saveInfo == null)
				{
					_saveInfo = (CHandle<inkSaveMetadataInfo>) CR2WTypeManager.Create("handle:inkSaveMetadataInfo", "saveInfo", cr2w, this);
				}
				return _saveInfo;
			}
			set
			{
				if (_saveInfo == value)
				{
					return;
				}
				_saveInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
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

		[Ordinal(10)] 
		[RED("hasEmptySlot")] 
		public CBool HasEmptySlot
		{
			get
			{
				if (_hasEmptySlot == null)
				{
					_hasEmptySlot = (CBool) CR2WTypeManager.Create("Bool", "hasEmptySlot", cr2w, this);
				}
				return _hasEmptySlot;
			}
			set
			{
				if (_hasEmptySlot == value)
				{
					return;
				}
				_hasEmptySlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("saveInProgress")] 
		public CBool SaveInProgress
		{
			get
			{
				if (_saveInProgress == null)
				{
					_saveInProgress = (CBool) CR2WTypeManager.Create("Bool", "saveInProgress", cr2w, this);
				}
				return _saveInProgress;
			}
			set
			{
				if (_saveInProgress == value)
				{
					return;
				}
				_saveInProgress = value;
				PropertySet(this);
			}
		}

		public SaveGameMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
