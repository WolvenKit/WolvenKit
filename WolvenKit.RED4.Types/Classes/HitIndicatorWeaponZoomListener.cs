using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HitIndicatorWeaponZoomListener : gameScriptStatsListener
	{
		[Ordinal(0)] 
		[RED("gameController")] 
		public CWeakHandle<TargetHitIndicatorGameController> GameController
		{
			get => GetPropertyValue<CWeakHandle<TargetHitIndicatorGameController>>();
			set => SetPropertyValue<CWeakHandle<TargetHitIndicatorGameController>>(value);
		}

		public HitIndicatorWeaponZoomListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
