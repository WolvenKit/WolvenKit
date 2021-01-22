using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIInterruptionHandlerBehaviorDefinition : AIInterruptionHandlerDefinition
	{
		[Ordinal(0)]  [RED("ai")] public CHandle<LibTreeINodeDefinition> Ai { get; set; }
		[Ordinal(1)]  [RED("blockInterruption")] public CBool BlockInterruption { get; set; }
		[Ordinal(2)]  [RED("parallelActivation")] public CBool ParallelActivation { get; set; }
		[Ordinal(3)]  [RED("parallelExecution")] public CBool ParallelExecution { get; set; }

		public AIInterruptionHandlerBehaviorDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
