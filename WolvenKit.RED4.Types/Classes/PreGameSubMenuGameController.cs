using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PreGameSubMenuGameController : gameuiWidgetGameController
	{
		private CWeakHandle<inkMenuEventDispatcher> _menuEventDispatcher;

		[Ordinal(2)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}
	}
}
