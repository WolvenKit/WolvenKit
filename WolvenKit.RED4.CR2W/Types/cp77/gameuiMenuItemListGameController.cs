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
			get => GetProperty(ref _menuList);
			set => SetProperty(ref _menuList, value);
		}

		[Ordinal(4)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(5)] 
		[RED("menuListController")] 
		public wCHandle<inkListController> MenuListController
		{
			get => GetProperty(ref _menuListController);
			set => SetProperty(ref _menuListController, value);
		}

		public gameuiMenuItemListGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
