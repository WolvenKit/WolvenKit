using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UnregisterReactionAction : AIbehaviortaskScript
	{
		[Ordinal(0)]  [RED("onDeactivation")] public CBool OnDeactivation { get; set; }
		[Ordinal(1)]  [RED("reactionName")] public CName ReactionName { get; set; }

		public UnregisterReactionAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
