using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIMoveOnSplineCommandHandler : AICommandHandlerBase
	{
		[Ordinal(0)]  [RED("outFacingTarget")] public CHandle<AIArgumentMapping> OutFacingTarget { get; set; }
		[Ordinal(1)]  [RED("outMovementType")] public CHandle<AIArgumentMapping> OutMovementType { get; set; }
		[Ordinal(2)]  [RED("outRotateTowardsFacingTarget")] public CHandle<AIArgumentMapping> OutRotateTowardsFacingTarget { get; set; }
		[Ordinal(3)]  [RED("outSnapToTerrain")] public CHandle<AIArgumentMapping> OutSnapToTerrain { get; set; }
		[Ordinal(4)]  [RED("outSpline")] public CHandle<AIArgumentMapping> OutSpline { get; set; }

		public AIMoveOnSplineCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
