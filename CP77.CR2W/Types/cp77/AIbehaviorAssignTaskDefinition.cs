using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorAssignTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(0)]  [RED("assignments")] public CArray<AIbehaviorAssignTaskItem> Assignments { get; set; }
		[Ordinal(1)]  [RED("endAssignments")] public CArray<AIbehaviorAssignTaskItem> EndAssignments { get; set; }

		public AIbehaviorAssignTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
