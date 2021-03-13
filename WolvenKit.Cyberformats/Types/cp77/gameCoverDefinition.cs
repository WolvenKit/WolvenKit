using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameCoverDefinition : gameSmartObjectWorkspotDefinition
	{
		[Ordinal(6)] [RED("overridenCoveringFOVDegrees")] public CFloat OverridenCoveringFOVDegrees { get; set; }
		[Ordinal(7)] [RED("overridenCoveringVerticalFOVDegrees")] public CFloat OverridenCoveringVerticalFOVDegrees { get; set; }
		[Ordinal(8)] [RED("fovExposureDegrees")] public CFloat FovExposureDegrees { get; set; }
		[Ordinal(9)] [RED("overridenHeight")] public CEnum<gameCoverHeight> OverridenHeight { get; set; }
		[Ordinal(10)] [RED("overrideGeneratedCoverAngles")] public CBool OverrideGeneratedCoverAngles { get; set; }

		public gameCoverDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
