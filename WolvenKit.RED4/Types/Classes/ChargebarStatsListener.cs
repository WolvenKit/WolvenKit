using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChargebarStatsListener : gameScriptStatsListener
	{
		[Ordinal(0)] 
		[RED("controller")] 
		public CWeakHandle<ChargebarController> Controller
		{
			get => GetPropertyValue<CWeakHandle<ChargebarController>>();
			set => SetPropertyValue<CWeakHandle<ChargebarController>>(value);
		}

		public ChargebarStatsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
