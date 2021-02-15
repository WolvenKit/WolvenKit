using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorJoinFollowerSquadWithTargetDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] [RED("follower")] public CHandle<AIArgumentMapping> Follower { get; set; }

		public AIbehaviorJoinFollowerSquadWithTargetDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
