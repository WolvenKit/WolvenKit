using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorMappingExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		[Ordinal(0)] [RED("mapping")] public CHandle<AIArgumentMapping> Mapping { get; set; }
		[Ordinal(1)] [RED("update")] public CBool Update { get; set; }
		[Ordinal(2)] [RED("updatePeriod")] public CFloat UpdatePeriod { get; set; }
		[Ordinal(3)] [RED("behaviorCallbackNames")] public CArray<CName> BehaviorCallbackNames { get; set; }

		public AIbehaviorMappingExpressionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
