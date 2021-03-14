using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ListItemsGroupController : CodexListItemController
	{
		private inkCompoundWidgetReference _menuList;
		private inkWidgetReference _foldArrowRef;
		private inkWidgetReference _foldoutButton;
		private CBool _foldoutIndipendently;
		private wCHandle<inkListController> _menuListController;
		private wCHandle<inkButtonController> _foldoutButtonController;
		private wCHandle<IScriptable> _lastClickedData;
		private CArray<CHandle<IScriptable>> _data;
		private CBool _isOpen;

		[Ordinal(19)] 
		[RED("menuList")] 
		public inkCompoundWidgetReference MenuList
		{
			get
			{
				if (_menuList == null)
				{
					_menuList = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "menuList", cr2w, this);
				}
				return _menuList;
			}
			set
			{
				if (_menuList == value)
				{
					return;
				}
				_menuList = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("foldArrowRef")] 
		public inkWidgetReference FoldArrowRef
		{
			get
			{
				if (_foldArrowRef == null)
				{
					_foldArrowRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "foldArrowRef", cr2w, this);
				}
				return _foldArrowRef;
			}
			set
			{
				if (_foldArrowRef == value)
				{
					return;
				}
				_foldArrowRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("foldoutButton")] 
		public inkWidgetReference FoldoutButton
		{
			get
			{
				if (_foldoutButton == null)
				{
					_foldoutButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "foldoutButton", cr2w, this);
				}
				return _foldoutButton;
			}
			set
			{
				if (_foldoutButton == value)
				{
					return;
				}
				_foldoutButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("foldoutIndipendently")] 
		public CBool FoldoutIndipendently
		{
			get
			{
				if (_foldoutIndipendently == null)
				{
					_foldoutIndipendently = (CBool) CR2WTypeManager.Create("Bool", "foldoutIndipendently", cr2w, this);
				}
				return _foldoutIndipendently;
			}
			set
			{
				if (_foldoutIndipendently == value)
				{
					return;
				}
				_foldoutIndipendently = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("menuListController")] 
		public wCHandle<inkListController> MenuListController
		{
			get
			{
				if (_menuListController == null)
				{
					_menuListController = (wCHandle<inkListController>) CR2WTypeManager.Create("whandle:inkListController", "menuListController", cr2w, this);
				}
				return _menuListController;
			}
			set
			{
				if (_menuListController == value)
				{
					return;
				}
				_menuListController = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("foldoutButtonController")] 
		public wCHandle<inkButtonController> FoldoutButtonController
		{
			get
			{
				if (_foldoutButtonController == null)
				{
					_foldoutButtonController = (wCHandle<inkButtonController>) CR2WTypeManager.Create("whandle:inkButtonController", "foldoutButtonController", cr2w, this);
				}
				return _foldoutButtonController;
			}
			set
			{
				if (_foldoutButtonController == value)
				{
					return;
				}
				_foldoutButtonController = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("lastClickedData")] 
		public wCHandle<IScriptable> LastClickedData
		{
			get
			{
				if (_lastClickedData == null)
				{
					_lastClickedData = (wCHandle<IScriptable>) CR2WTypeManager.Create("whandle:IScriptable", "lastClickedData", cr2w, this);
				}
				return _lastClickedData;
			}
			set
			{
				if (_lastClickedData == value)
				{
					return;
				}
				_lastClickedData = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("data")] 
		public CArray<CHandle<IScriptable>> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CArray<CHandle<IScriptable>>) CR2WTypeManager.Create("array:handle:IScriptable", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("isOpen")] 
		public CBool IsOpen
		{
			get
			{
				if (_isOpen == null)
				{
					_isOpen = (CBool) CR2WTypeManager.Create("Bool", "isOpen", cr2w, this);
				}
				return _isOpen;
			}
			set
			{
				if (_isOpen == value)
				{
					return;
				}
				_isOpen = value;
				PropertySet(this);
			}
		}

		public ListItemsGroupController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
