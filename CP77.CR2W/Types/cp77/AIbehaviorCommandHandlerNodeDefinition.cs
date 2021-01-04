using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorCommandHandlerNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(0)]  [RED("commandName")] public CName CommandName { get; set; }
		[Ordinal(1)]  [RED("commandOut")] public CHandle<AIArgumentMapping> CommandOut { get; set; }
		[Ordinal(2)]  [RED("contexts")] public CArray<CEnum<AICommandContextsType>> Contexts { get; set; }
		[Ordinal(3)]  [RED("resultIfChildFailed")] public CEnum<AIbehaviorCompletionStatus> ResultIfChildFailed { get; set; }
		[Ordinal(4)]  [RED("resultIfNoCommand")] public CEnum<AIbehaviorCompletionStatus> ResultIfNoCommand { get; set; }
		[Ordinal(5)]  [RED("retryIfCommandEnqueued")] public CBool RetryIfCommandEnqueued { get; set; }
		[Ordinal(6)]  [RED("runningSignal")] public CName RunningSignal { get; set; }
		[Ordinal(7)]  [RED("useInheritance")] public CBool UseInheritance { get; set; }
		[Ordinal(8)]  [RED("waitForCommand")] public CBool WaitForCommand { get; set; }

		public AIbehaviorCommandHandlerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
