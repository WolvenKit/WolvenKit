using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseHubMenuController : gameuiWidgetGameController
	{
		private CWeakHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private CHandle<IScriptable> _menuData;

		[Ordinal(2)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(3)] 
		[RED("menuData")] 
		public CHandle<IScriptable> MenuData
		{
			get => GetProperty(ref _menuData);
			set => SetProperty(ref _menuData, value);
		}
	}
}
