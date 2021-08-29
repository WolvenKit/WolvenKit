using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiMenuGameController : gameuiWidgetGameController
	{
		private CWeakHandle<inkMenuEventDispatcher> _baseEventDispatcher;

		[Ordinal(2)] 
		[RED("baseEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> BaseEventDispatcher
		{
			get => GetProperty(ref _baseEventDispatcher);
			set => SetProperty(ref _baseEventDispatcher, value);
		}
	}
}
