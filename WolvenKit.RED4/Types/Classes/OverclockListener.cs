using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OverclockListener : gameScriptStatusEffectListener
	{
		[Ordinal(0)] 
		[RED("healthBar")] 
		public CWeakHandle<gameuiHudHealthbarGameController> HealthBar
		{
			get => GetPropertyValue<CWeakHandle<gameuiHudHealthbarGameController>>();
			set => SetPropertyValue<CWeakHandle<gameuiHudHealthbarGameController>>(value);
		}

		public OverclockListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
