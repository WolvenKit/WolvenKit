using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIInterruptionHandlerBehaviorDefinition : AIInterruptionHandlerDefinition
	{
		[Ordinal(2)] [RED("ai")] public CHandle<LibTreeINodeDefinition> Ai { get; set; }
		[Ordinal(3)] [RED("parallelActivation")] public CBool ParallelActivation { get; set; }
		[Ordinal(4)] [RED("parallelExecution")] public CBool ParallelExecution { get; set; }
		[Ordinal(5)] [RED("blockInterruption")] public CBool BlockInterruption { get; set; }

		public AIInterruptionHandlerBehaviorDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
