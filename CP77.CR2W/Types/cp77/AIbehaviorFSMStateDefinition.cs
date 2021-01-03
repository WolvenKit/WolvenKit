using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorFSMStateDefinition : AIbehaviorTreeNodeDefinition
	{
		[Ordinal(0)]  [RED("behaviorRoot")] public CHandle<AIbehaviorTreeNodeDefinition> BehaviorRoot { get; set; }
		[Ordinal(1)]  [RED("completionStatus")] public CEnum<AIbehaviorStateCompletionStatus> CompletionStatus { get; set; }
		[Ordinal(2)]  [RED("isExit")] public CBool IsExit { get; set; }
		[Ordinal(3)]  [RED("isInitial")] public CBool IsInitial { get; set; }

		public AIbehaviorFSMStateDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
