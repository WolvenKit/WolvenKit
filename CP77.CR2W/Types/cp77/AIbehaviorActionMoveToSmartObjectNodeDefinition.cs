using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionMoveToSmartObjectNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(1)] [RED("smartObjectId")] public CHandle<AIArgumentMapping> SmartObjectId { get; set; }
		[Ordinal(2)] [RED("lookAtTarget")] public CHandle<AIArgumentMapping> LookAtTarget { get; set; }
		[Ordinal(3)] [RED("movementType")] public CHandle<AIArgumentMapping> MovementType { get; set; }
		[Ordinal(4)] [RED("tolerance")] public CHandle<AIArgumentMapping> Tolerance { get; set; }
		[Ordinal(5)] [RED("ignoreNavigation")] public CHandle<AIArgumentMapping> IgnoreNavigation { get; set; }
		[Ordinal(6)] [RED("rotateEntity")] public CHandle<AIArgumentMapping> RotateEntity { get; set; }
		[Ordinal(7)] [RED("useStart")] public CHandle<AIArgumentMapping> UseStart { get; set; }
		[Ordinal(8)] [RED("useStop")] public CHandle<AIArgumentMapping> UseStop { get; set; }
		[Ordinal(9)] [RED("forcedEntryAnimation")] public CHandle<AIArgumentMapping> ForcedEntryAnimation { get; set; }

		public AIbehaviorActionMoveToSmartObjectNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
