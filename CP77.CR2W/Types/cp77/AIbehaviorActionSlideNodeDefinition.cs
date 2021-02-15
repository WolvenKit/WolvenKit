using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionSlideNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(1)] [RED("duration")] public CHandle<AIArgumentMapping> Duration { get; set; }
		[Ordinal(2)] [RED("ignoreNavigation")] public CHandle<AIArgumentMapping> IgnoreNavigation { get; set; }
		[Ordinal(3)] [RED("rotateTowardsMovementDirection")] public CHandle<AIArgumentMapping> RotateTowardsMovementDirection { get; set; }

		public AIbehaviorActionSlideNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
