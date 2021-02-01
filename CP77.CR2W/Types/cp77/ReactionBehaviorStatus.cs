using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ReactionBehaviorStatus : redEvent
	{
		[Ordinal(0)]  [RED("reactionData")] public CHandle<AIReactionData> ReactionData { get; set; }
		[Ordinal(1)]  [RED("status")] public CEnum<AIbehaviorUpdateOutcome> Status { get; set; }

		public ReactionBehaviorStatus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
