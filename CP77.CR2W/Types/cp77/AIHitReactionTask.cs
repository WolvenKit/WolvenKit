using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIHitReactionTask : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("activationTimeStamp")] public CFloat ActivationTimeStamp { get; set; }
		[Ordinal(1)] [RED("reactionDuration")] public CFloat ReactionDuration { get; set; }
		[Ordinal(2)] [RED("hitReactionAction")] public CHandle<ActionHitReactionScriptProxy> HitReactionAction { get; set; }
		[Ordinal(3)] [RED("hitReactionType")] public CEnum<animHitReactionType> HitReactionType { get; set; }

		public AIHitReactionTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
