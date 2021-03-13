using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorParallelNodeDefinition : AIbehaviorCompositeTreeNodeDefinition
	{
		[Ordinal(1)] [RED("waitFor")] public CEnum<AIbehaviorParallelNodeWaitFor> WaitFor { get; set; }

		public AIbehaviorParallelNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
