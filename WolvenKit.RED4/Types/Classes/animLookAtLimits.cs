using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animLookAtLimits : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("softLimitDegrees")] 
		public CFloat SoftLimitDegrees
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("hardLimitDegrees")] 
		public CFloat HardLimitDegrees
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("hardLimitDistance")] 
		public CFloat HardLimitDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("backLimitDegrees")] 
		public CFloat BackLimitDegrees
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animLookAtLimits()
		{
			SoftLimitDegrees = 360.000000F;
			HardLimitDegrees = 360.000000F;
			HardLimitDistance = 1000000.000000F;
			BackLimitDegrees = 180.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
