using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorMovementPolicyTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] [RED("useCurrentPolicy")] public CBool UseCurrentPolicy { get; set; }
		[Ordinal(2)] [RED("waitForPolicy")] public CBool WaitForPolicy { get; set; }
		[Ordinal(3)] [RED("stopWhenDestinationReached")] public CHandle<AIArgumentMapping> StopWhenDestinationReached { get; set; }
		[Ordinal(4)] [RED("policies")] public CArray<CHandle<AIbehaviorMovementPolicyTaskItemDefinition>> Policies { get; set; }

		public AIbehaviorMovementPolicyTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
