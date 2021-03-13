using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorUnaryConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] [RED("child")] public CHandle<AIbehaviorConditionDefinition> Child { get; set; }

		public AIbehaviorUnaryConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
