using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OverclockHudListener : gameScriptStatusEffectListener
	{
		[Ordinal(0)] 
		[RED("hudController")] 
		public CWeakHandle<gameuiHUDGameController> HudController
		{
			get => GetPropertyValue<CWeakHandle<gameuiHUDGameController>>();
			set => SetPropertyValue<CWeakHandle<gameuiHUDGameController>>(value);
		}

		public OverclockHudListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
