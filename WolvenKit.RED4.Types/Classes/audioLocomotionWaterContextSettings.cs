using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioLocomotionWaterContextSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("minDistanceBetweenImpulsesSquared")] 
		public CFloat MinDistanceBetweenImpulsesSquared
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("impulseStrength")] 
		public CFloat ImpulseStrength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("impulseMinRadius")] 
		public CFloat ImpulseMinRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("impulseMaxRadius")] 
		public CFloat ImpulseMaxRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioLocomotionWaterContextSettings()
		{
			MinDistanceBetweenImpulsesSquared = 0.010000F;
			ImpulseStrength = 0.002500F;
			ImpulseMinRadius = 0.040000F;
			ImpulseMaxRadius = 0.050000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
