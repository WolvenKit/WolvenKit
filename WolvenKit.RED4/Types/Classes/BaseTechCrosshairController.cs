using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BaseTechCrosshairController : gameuiCrosshairBaseGameController
	{
		[Ordinal(27)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(28)] 
		[RED("statsSystem")] 
		public CHandle<gameStatsSystem> StatsSystem
		{
			get => GetPropertyValue<CHandle<gameStatsSystem>>();
			set => SetPropertyValue<CHandle<gameStatsSystem>>(value);
		}

		[Ordinal(29)] 
		[RED("fullChargeAvailable")] 
		public CBool FullChargeAvailable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
		[RED("overChargeAvailable")] 
		public CBool OverChargeAvailable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(31)] 
		[RED("fullChargeListener")] 
		public CHandle<CrosshairWeaponStatsListener> FullChargeListener
		{
			get => GetPropertyValue<CHandle<CrosshairWeaponStatsListener>>();
			set => SetPropertyValue<CHandle<CrosshairWeaponStatsListener>>(value);
		}

		[Ordinal(32)] 
		[RED("overChargeListener")] 
		public CHandle<CrosshairWeaponStatsListener> OverChargeListener
		{
			get => GetPropertyValue<CHandle<CrosshairWeaponStatsListener>>();
			set => SetPropertyValue<CHandle<CrosshairWeaponStatsListener>>(value);
		}

		public BaseTechCrosshairController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
