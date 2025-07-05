using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FoliageShadowConfig : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("foliageShadowCascadeGradient")] 
		public CFloat FoliageShadowCascadeGradient
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("foliageShadowCascadeFilterScale")] 
		public CFloat FoliageShadowCascadeFilterScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("foliageShadowCascadeGradientDistanceRange")] 
		public CFloat FoliageShadowCascadeGradientDistanceRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public FoliageShadowConfig()
		{
			FoliageShadowCascadeGradient = 0.100000F;
			FoliageShadowCascadeFilterScale = 0.100000F;
			FoliageShadowCascadeGradientDistanceRange = 50.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
