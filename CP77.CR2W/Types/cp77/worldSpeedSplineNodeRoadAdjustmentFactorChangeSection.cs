using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldSpeedSplineNodeRoadAdjustmentFactorChangeSection : CVariable
	{
		[Ordinal(0)] [RED("pos")] public CFloat Pos { get; set; }
		[Ordinal(1)] [RED("targetFactor")] public CFloat TargetFactor { get; set; }

		public worldSpeedSplineNodeRoadAdjustmentFactorChangeSection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
