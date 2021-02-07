using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameCoverDefinition : gameSmartObjectWorkspotDefinition
	{
		[Ordinal(0)]  [RED("overridenCoveringFOVDegrees")] public CFloat OverridenCoveringFOVDegrees { get; set; }
		[Ordinal(1)]  [RED("overridenCoveringVerticalFOVDegrees")] public CFloat OverridenCoveringVerticalFOVDegrees { get; set; }
		[Ordinal(2)]  [RED("fovExposureDegrees")] public CFloat FovExposureDegrees { get; set; }
		[Ordinal(3)]  [RED("overridenHeight")] public CEnum<gameCoverHeight> OverridenHeight { get; set; }
		[Ordinal(4)]  [RED("overrideGeneratedCoverAngles")] public CBool OverrideGeneratedCoverAngles { get; set; }

		public gameCoverDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
