using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorIsThreatOnPathConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] [RED("threatObject")] public CHandle<AIArgumentMapping> ThreatObject { get; set; }
		[Ordinal(2)] [RED("threatRadius")] public CHandle<AIArgumentMapping> ThreatRadius { get; set; }

		public AIbehaviorIsThreatOnPathConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
