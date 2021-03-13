using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SetDesiredReaction : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("behaviorArgumentNameTag")] public CName BehaviorArgumentNameTag { get; set; }
		[Ordinal(1)] [RED("behaviorArgumentFloatPriority")] public CName BehaviorArgumentFloatPriority { get; set; }
		[Ordinal(2)] [RED("behaviorArgumentNameFlag")] public CName BehaviorArgumentNameFlag { get; set; }
		[Ordinal(3)] [RED("reactionData")] public CHandle<AIReactionData> ReactionData { get; set; }

		public SetDesiredReaction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
