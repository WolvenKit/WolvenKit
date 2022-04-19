using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PreGameSubMenuGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		public PreGameSubMenuGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
