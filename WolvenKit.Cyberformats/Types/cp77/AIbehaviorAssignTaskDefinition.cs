using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorAssignTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] [RED("assignments")] public CArray<AIbehaviorAssignTaskItem> Assignments { get; set; }
		[Ordinal(2)] [RED("endAssignments")] public CArray<AIbehaviorAssignTaskItem> EndAssignments { get; set; }

		public AIbehaviorAssignTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
