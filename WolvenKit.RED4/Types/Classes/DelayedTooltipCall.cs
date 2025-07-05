using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DelayedTooltipCall : gameDelaySystemScriptedDelayCallbackWrapper
	{
		[Ordinal(0)] 
		[RED("controller")] 
		public CWeakHandle<UpgradingScreenController> Controller
		{
			get => GetPropertyValue<CWeakHandle<UpgradingScreenController>>();
			set => SetPropertyValue<CWeakHandle<UpgradingScreenController>>(value);
		}

		public DelayedTooltipCall()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
