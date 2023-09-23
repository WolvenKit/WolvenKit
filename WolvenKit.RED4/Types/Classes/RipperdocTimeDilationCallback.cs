using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperdocTimeDilationCallback : gameDelaySystemScriptedDelayCallbackWrapper
	{
		[Ordinal(0)] 
		[RED("controller")] 
		public CWeakHandle<RipperDocGameController> Controller
		{
			get => GetPropertyValue<CWeakHandle<RipperDocGameController>>();
			set => SetPropertyValue<CWeakHandle<RipperDocGameController>>(value);
		}

		public RipperdocTimeDilationCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
