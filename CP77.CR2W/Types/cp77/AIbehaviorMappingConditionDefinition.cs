using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorMappingConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] [RED("value")] public CHandle<AIArgumentMapping> Value { get; set; }

		public AIbehaviorMappingConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
