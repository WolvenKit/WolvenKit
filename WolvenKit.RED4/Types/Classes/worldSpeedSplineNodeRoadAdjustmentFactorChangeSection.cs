using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldSpeedSplineNodeRoadAdjustmentFactorChangeSection : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("pos")] 
		public CFloat Pos
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("targetFactor")] 
		public CFloat TargetFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldSpeedSplineNodeRoadAdjustmentFactorChangeSection()
		{
			TargetFactor = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
