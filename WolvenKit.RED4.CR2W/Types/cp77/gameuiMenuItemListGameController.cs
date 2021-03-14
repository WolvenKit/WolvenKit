using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMenuItemListGameController : gameuiSaveHandlingController
	{
		private inkCompoundWidgetReference _menuList;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private wCHandle<inkListController> _menuListController;

		[Ordinal(3)] 
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

		public gameuiMenuItemListGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
