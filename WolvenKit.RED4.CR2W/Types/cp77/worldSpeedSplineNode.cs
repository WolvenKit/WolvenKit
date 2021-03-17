using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldSpeedSplineNode : worldSplineNode
	{
		private CArray<worldSpeedSplineNodeSpeedChangeSection> _speedChangeSections;
		private CBool _useDeprecated;
		private CArray<worldSpeedSplineNodeSpeedRestriction> _deprecatedSpeedRestrictions;
		private CFloat _deprecatedDefaultSpeed;
		private CFloat _deprecatedDefaultAdjustTime;
		private CArray<worldSpeedSplineNodeOrientationChangeSection> _orientationChangeSections;
		private CArray<worldSpeedSplineNodeRoadAdjustmentFactorChangeSection> _roadAdjustmentFactorChangeSections;
		private CBool _ignoreTerrain;

		[Ordinal(9)] 
		[RED("speedChangeSections")] 
		public CArray<worldSpeedSplineNodeSpeedChangeSection> SpeedChangeSections
		{
			get => GetProperty(ref _speedChangeSections);
			set => SetProperty(ref _speedChangeSections, value);
		}

		[Ordinal(10)] 
		[RED("useDeprecated")] 
		public CBool UseDeprecated
		{
			get => GetProperty(ref _useDeprecated);
			set => SetProperty(ref _useDeprecated, value);
		}

		[Ordinal(11)] 
		[RED("deprecatedSpeedRestrictions")] 
		public CArray<worldSpeedSplineNodeSpeedRestriction> DeprecatedSpeedRestrictions
		{
			get => GetProperty(ref _deprecatedSpeedRestrictions);
			set => SetProperty(ref _deprecatedSpeedRestrictions, value);
		}

		[Ordinal(12)] 
		[RED("deprecatedDefaultSpeed")] 
		public CFloat DeprecatedDefaultSpeed
		{
			get => GetProperty(ref _deprecatedDefaultSpeed);
			set => SetProperty(ref _deprecatedDefaultSpeed, value);
		}

		[Ordinal(13)] 
		[RED("deprecatedDefaultAdjustTime")] 
		public CFloat DeprecatedDefaultAdjustTime
		{
			get => GetProperty(ref _deprecatedDefaultAdjustTime);
			set => SetProperty(ref _deprecatedDefaultAdjustTime, value);
		}

		[Ordinal(14)] 
		[RED("orientationChangeSections")] 
		public CArray<worldSpeedSplineNodeOrientationChangeSection> OrientationChangeSections
		{
			get => GetProperty(ref _orientationChangeSections);
			set => SetProperty(ref _orientationChangeSections, value);
		}

		[Ordinal(15)] 
		[RED("roadAdjustmentFactorChangeSections")] 
		public CArray<worldSpeedSplineNodeRoadAdjustmentFactorChangeSection> RoadAdjustmentFactorChangeSections
		{
			get => GetProperty(ref _roadAdjustmentFactorChangeSections);
			set => SetProperty(ref _roadAdjustmentFactorChangeSections, value);
		}

		[Ordinal(16)] 
		[RED("ignoreTerrain")] 
		public CBool IgnoreTerrain
		{
			get => GetProperty(ref _ignoreTerrain);
			set => SetProperty(ref _ignoreTerrain, value);
		}

		public worldSpeedSplineNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
