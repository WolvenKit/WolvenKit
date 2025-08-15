using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class cameraShotEffect_Shake : vehicleCinematicCameraShotEffect_EulerAnglesDamper
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

		public cameraShotEffect_Shake()
		{
			ShakeStrength = 0.010000F;
			Frequency = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
