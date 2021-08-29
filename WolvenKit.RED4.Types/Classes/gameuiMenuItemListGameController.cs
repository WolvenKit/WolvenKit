using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiMenuItemListGameController : gameuiSaveHandlingController
	{
		private inkCompoundWidgetReference _menuList;
		private CWeakHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private CWeakHandle<inkListController> _menuListController;

		[Ordinal(3)] 
		[RED("menuList")] 
		public inkCompoundWidgetReference MenuList
		{
			get => GetProperty(ref _menuList);
			set => SetProperty(ref _menuList, value);
		}

		[Ordinal(4)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(5)] 
		[RED("menuListController")] 
		public CWeakHandle<inkListController> MenuListController
		{
			get => GetProperty(ref _menuListController);
			set => SetProperty(ref _menuListController, value);
		}
	}
}
