using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorFSMStateDefinition : AIbehaviorTreeNodeDefinition
	{
		[Ordinal(0)] [RED("behaviorRoot")] public CHandle<AIbehaviorTreeNodeDefinition> BehaviorRoot { get; set; }
		[Ordinal(1)] [RED("isInitial")] public CBool IsInitial { get; set; }
		[Ordinal(2)] [RED("isExit")] public CBool IsExit { get; set; }
		[Ordinal(3)] [RED("completionStatus")] public CEnum<AIbehaviorStateCompletionStatus> CompletionStatus { get; set; }

		public AIbehaviorFSMStateDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
