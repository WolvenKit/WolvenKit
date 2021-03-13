using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldSpeedSplineNode : worldSplineNode
	{
		[Ordinal(9)] [RED("speedChangeSections")] public CArray<worldSpeedSplineNodeSpeedChangeSection> SpeedChangeSections { get; set; }
		[Ordinal(10)] [RED("useDeprecated")] public CBool UseDeprecated { get; set; }
		[Ordinal(11)] [RED("deprecatedSpeedRestrictions")] public CArray<worldSpeedSplineNodeSpeedRestriction> DeprecatedSpeedRestrictions { get; set; }
		[Ordinal(12)] [RED("deprecatedDefaultSpeed")] public CFloat DeprecatedDefaultSpeed { get; set; }
		[Ordinal(13)] [RED("deprecatedDefaultAdjustTime")] public CFloat DeprecatedDefaultAdjustTime { get; set; }
		[Ordinal(14)] [RED("orientationChangeSections")] public CArray<worldSpeedSplineNodeOrientationChangeSection> OrientationChangeSections { get; set; }
		[Ordinal(15)] [RED("roadAdjustmentFactorChangeSections")] public CArray<worldSpeedSplineNodeRoadAdjustmentFactorChangeSection> RoadAdjustmentFactorChangeSections { get; set; }
		[Ordinal(16)] [RED("ignoreTerrain")] public CBool IgnoreTerrain { get; set; }

		public worldSpeedSplineNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
