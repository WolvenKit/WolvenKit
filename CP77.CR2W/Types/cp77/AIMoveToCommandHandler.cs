using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIMoveToCommandHandler : AICommandHandlerBase
	{
		[Ordinal(1)]  [RED("outIsDynamicMove")] public CHandle<AIArgumentMapping> OutIsDynamicMove { get; set; }
		[Ordinal(2)]  [RED("outMovementTarget")] public CHandle<AIArgumentMapping> OutMovementTarget { get; set; }
		[Ordinal(3)]  [RED("outMovementTargetPos")] public CHandle<AIArgumentMapping> OutMovementTargetPos { get; set; }
		[Ordinal(4)]  [RED("outRotateEntityTowardsFacingTarget")] public CHandle<AIArgumentMapping> OutRotateEntityTowardsFacingTarget { get; set; }
		[Ordinal(5)]  [RED("outFacingTarget")] public CHandle<AIArgumentMapping> OutFacingTarget { get; set; }
		[Ordinal(6)]  [RED("outMovementType")] public CHandle<AIArgumentMapping> OutMovementType { get; set; }
		[Ordinal(7)]  [RED("outIgnoreNavigation")] public CHandle<AIArgumentMapping> OutIgnoreNavigation { get; set; }
		[Ordinal(8)]  [RED("outUseStart")] public CHandle<AIArgumentMapping> OutUseStart { get; set; }
		[Ordinal(9)]  [RED("outUseStop")] public CHandle<AIArgumentMapping> OutUseStop { get; set; }
		[Ordinal(10)]  [RED("outDesiredDistanceFromTarget")] public CHandle<AIArgumentMapping> OutDesiredDistanceFromTarget { get; set; }
		[Ordinal(11)]  [RED("outFinishWhenDestinationReached")] public CHandle<AIArgumentMapping> OutFinishWhenDestinationReached { get; set; }

		public AIMoveToCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
