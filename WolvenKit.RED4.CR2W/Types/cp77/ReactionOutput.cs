using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReactionOutput : CVariable
	{
		[Ordinal(0)] [RED("reactionBehavior")] public CEnum<gamedataOutput> ReactionBehavior { get; set; }
		[Ordinal(1)] [RED("reactionPriority")] public CInt32 ReactionPriority { get; set; }
		[Ordinal(2)] [RED("AIbehaviorPriority")] public CFloat AIbehaviorPriority { get; set; }
		[Ordinal(3)] [RED("reactionCooldown")] public CFloat ReactionCooldown { get; set; }
		[Ordinal(4)] [RED("startedInWorkspot")] public CBool StartedInWorkspot { get; set; }
		[Ordinal(5)] [RED("workspotReaction")] public CBool WorkspotReaction { get; set; }
		[Ordinal(6)] [RED("workspotReactionType")] public CName WorkspotReactionType { get; set; }

		public ReactionOutput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
