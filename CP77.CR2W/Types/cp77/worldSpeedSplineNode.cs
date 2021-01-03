using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldSpeedSplineNode : worldSplineNode
	{
		[Ordinal(0)]  [RED("deprecatedDefaultAdjustTime")] public CFloat DeprecatedDefaultAdjustTime { get; set; }
		[Ordinal(1)]  [RED("deprecatedDefaultSpeed")] public CFloat DeprecatedDefaultSpeed { get; set; }
		[Ordinal(2)]  [RED("deprecatedSpeedRestrictions")] public CArray<worldSpeedSplineNodeSpeedRestriction> DeprecatedSpeedRestrictions { get; set; }
		[Ordinal(3)]  [RED("ignoreTerrain")] public CBool IgnoreTerrain { get; set; }
		[Ordinal(4)]  [RED("orientationChangeSections")] public CArray<worldSpeedSplineNodeOrientationChangeSection> OrientationChangeSections { get; set; }
		[Ordinal(5)]  [RED("roadAdjustmentFactorChangeSections")] public CArray<worldSpeedSplineNodeRoadAdjustmentFactorChangeSection> RoadAdjustmentFactorChangeSections { get; set; }
		[Ordinal(6)]  [RED("speedChangeSections")] public CArray<worldSpeedSplineNodeSpeedChangeSection> SpeedChangeSections { get; set; }
		[Ordinal(7)]  [RED("useDeprecated")] public CBool UseDeprecated { get; set; }

		public worldSpeedSplineNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
