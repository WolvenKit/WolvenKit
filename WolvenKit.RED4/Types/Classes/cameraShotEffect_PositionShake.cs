using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class cameraShotEffect_PositionShake : vehicleCinematicCameraShotEffect_VectorDamper
	{
		[Ordinal(5)] 
		[RED("shakeStrength")] 
		public CFloat ShakeStrength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("frequency")] 
		public CFloat Frequency
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("directionsCoef")] 
		public Vector3 DirectionsCoef
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public cameraShotEffect_PositionShake()
		{
			ShakeStrength = 0.010000F;
			Frequency = 1.000000F;
			DirectionsCoef = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
