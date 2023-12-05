using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperdocTimeDilationCallback : gameDelaySystemScriptedDelayCallbackWrapper
	{
		[Ordinal(0)] 
		[RED("controller")] 
		public CWeakHandle<VendorHubMenuGameController> Controller
		{
			get => GetPropertyValue<CWeakHandle<VendorHubMenuGameController>>();
			set => SetPropertyValue<CWeakHandle<VendorHubMenuGameController>>(value);
		}

		public RipperdocTimeDilationCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
