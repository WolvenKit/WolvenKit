using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIMoveOnSplineCommandHandler : AICommandHandlerBase
	{
		[Ordinal(1)] [RED("outSpline")] public CHandle<AIArgumentMapping> OutSpline { get; set; }
		[Ordinal(2)] [RED("outMovementType")] public CHandle<AIArgumentMapping> OutMovementType { get; set; }
		[Ordinal(3)] [RED("outRotateTowardsFacingTarget")] public CHandle<AIArgumentMapping> OutRotateTowardsFacingTarget { get; set; }
		[Ordinal(4)] [RED("outFacingTarget")] public CHandle<AIArgumentMapping> OutFacingTarget { get; set; }
		[Ordinal(5)] [RED("outSnapToTerrain")] public CHandle<AIArgumentMapping> OutSnapToTerrain { get; set; }

		public AIMoveOnSplineCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
