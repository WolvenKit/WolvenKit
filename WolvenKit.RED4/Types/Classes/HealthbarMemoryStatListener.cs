using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HealthbarMemoryStatListener : gameScriptStatsListener
	{
		[Ordinal(0)] 
		[RED("healthbar")] 
		public CWeakHandle<gameuiHudHealthbarGameController> Healthbar
		{
			get => GetPropertyValue<CWeakHandle<gameuiHudHealthbarGameController>>();
			set => SetPropertyValue<CWeakHandle<gameuiHudHealthbarGameController>>(value);
		}

		public HealthbarMemoryStatListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
