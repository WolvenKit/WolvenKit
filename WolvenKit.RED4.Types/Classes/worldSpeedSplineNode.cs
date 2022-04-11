using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldSpeedSplineNode : worldSplineNode
	{
		[Ordinal(9)] 
		[RED("speedChangeSections")] 
		public CArray<worldSpeedSplineNodeSpeedChangeSection> SpeedChangeSections
		{
			get => GetPropertyValue<CArray<worldSpeedSplineNodeSpeedChangeSection>>();
			set => SetPropertyValue<CArray<worldSpeedSplineNodeSpeedChangeSection>>(value);
		}

		[Ordinal(10)] 
		[RED("useDeprecated")] 
		public CBool UseDeprecated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("deprecatedSpeedRestrictions")] 
		public CArray<worldSpeedSplineNodeSpeedRestriction> DeprecatedSpeedRestrictions
		{
			get => GetPropertyValue<CArray<worldSpeedSplineNodeSpeedRestriction>>();
			set => SetPropertyValue<CArray<worldSpeedSplineNodeSpeedRestriction>>(value);
		}

		[Ordinal(12)] 
		[RED("deprecatedDefaultSpeed")] 
		public CFloat DeprecatedDefaultSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("deprecatedDefaultAdjustTime")] 
		public CFloat DeprecatedDefaultAdjustTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("orientationChangeSections")] 
		public CArray<worldSpeedSplineNodeOrientationChangeSection> OrientationChangeSections
		{
			get => GetPropertyValue<CArray<worldSpeedSplineNodeOrientationChangeSection>>();
			set => SetPropertyValue<CArray<worldSpeedSplineNodeOrientationChangeSection>>(value);
		}

		[Ordinal(15)] 
		[RED("roadAdjustmentFactorChangeSections")] 
		public CArray<worldSpeedSplineNodeRoadAdjustmentFactorChangeSection> RoadAdjustmentFactorChangeSections
		{
			get => GetPropertyValue<CArray<worldSpeedSplineNodeRoadAdjustmentFactorChangeSection>>();
			set => SetPropertyValue<CArray<worldSpeedSplineNodeRoadAdjustmentFactorChangeSection>>(value);
		}

		[Ordinal(16)] 
		[RED("ignoreTerrain")] 
		public CBool IgnoreTerrain
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldSpeedSplineNode()
		{
			SpeedChangeSections = new();
			DeprecatedSpeedRestrictions = new();
			OrientationChangeSections = new();
			RoadAdjustmentFactorChangeSections = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
