using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FoliageShadowConfig : RedBaseClass
	{
		private CFloat _foliageShadowCascadeGradient;
		private CFloat _foliageShadowCascadeFilterScale;
		private CFloat _foliageShadowCascadeGradientDistanceRange;

		[Ordinal(0)] 
		[RED("foliageShadowCascadeGradient")] 
		public CFloat FoliageShadowCascadeGradient
		{
			get => GetProperty(ref _foliageShadowCascadeGradient);
			set => SetProperty(ref _foliageShadowCascadeGradient, value);
		}

		[Ordinal(1)] 
		[RED("foliageShadowCascadeFilterScale")] 
		public CFloat FoliageShadowCascadeFilterScale
		{
			get => GetProperty(ref _foliageShadowCascadeFilterScale);
			set => SetProperty(ref _foliageShadowCascadeFilterScale, value);
		}

		[Ordinal(2)] 
		[RED("foliageShadowCascadeGradientDistanceRange")] 
		public CFloat FoliageShadowCascadeGradientDistanceRange
		{
			get => GetProperty(ref _foliageShadowCascadeGradientDistanceRange);
			set => SetProperty(ref _foliageShadowCascadeGradientDistanceRange, value);
		}

		public FoliageShadowConfig()
		{
			_foliageShadowCascadeGradient = 0.100000F;
			_foliageShadowCascadeFilterScale = 0.100000F;
			_foliageShadowCascadeGradientDistanceRange = 50.000000F;
		}
	}
}
