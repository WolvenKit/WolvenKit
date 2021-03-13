using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorJoinFollowerSquadWithTargetDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] [RED("follower")] public CHandle<AIArgumentMapping> Follower { get; set; }

		public AIbehaviorJoinFollowerSquadWithTargetDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
