using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiMenuGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("baseEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> BaseEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		public gameuiMenuGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
