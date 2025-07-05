using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectExecutor_GroundSlamEffects : gameEffectExecutor
	{
		[Ordinal(1)] 
		[RED("groundEffect")] 
		public CResourceAsyncReference<worldEffect> GroundEffect
		{
			get => GetPropertyValue<CResourceAsyncReference<worldEffect>>();
			set => SetPropertyValue<CResourceAsyncReference<worldEffect>>(value);
		}

		[Ordinal(2)] 
		[RED("waterEffect")] 
		public CResourceAsyncReference<worldEffect> WaterEffect
		{
			get => GetPropertyValue<CResourceAsyncReference<worldEffect>>();
			set => SetPropertyValue<CResourceAsyncReference<worldEffect>>(value);
		}

		[Ordinal(3)] 
		[RED("earthquakeLevel1")] 
		public CResourceAsyncReference<worldEffect> EarthquakeLevel1
		{
			get => GetPropertyValue<CResourceAsyncReference<worldEffect>>();
			set => SetPropertyValue<CResourceAsyncReference<worldEffect>>(value);
		}

		[Ordinal(4)] 
		[RED("earthquakeLevel2")] 
		public CResourceAsyncReference<worldEffect> EarthquakeLevel2
		{
			get => GetPropertyValue<CResourceAsyncReference<worldEffect>>();
			set => SetPropertyValue<CResourceAsyncReference<worldEffect>>(value);
		}

		[Ordinal(5)] 
		[RED("earthquakeLevel1ChargeThreshold")] 
		public CFloat EarthquakeLevel1ChargeThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("earthquakeLevel2ChargeThreshold")] 
		public CFloat EarthquakeLevel2ChargeThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameEffectExecutor_GroundSlamEffects()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
