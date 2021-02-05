using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDistanceToTargetConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(0)]  [RED("target")] public CHandle<AIArgumentMapping> Target { get; set; }
		[Ordinal(1)]  [RED("distance")] public CHandle<AIArgumentMapping> Distance { get; set; }
		[Ordinal(2)]  [RED("comparisonOperator")] public CEnum<EComparisonType> ComparisonOperator { get; set; }

		public AIbehaviorDistanceToTargetConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
