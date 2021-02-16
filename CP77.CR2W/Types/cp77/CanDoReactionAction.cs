using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CanDoReactionAction : AIbehaviorconditionScript
	{
		[Ordinal(0)] [RED("reactionName")] public CName ReactionName { get; set; }

		public CanDoReactionAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
