using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorCheckDistanceToCompanionConditionDefinition : AIbehaviorCompanionConditionDefinition
	{
		[Ordinal(3)] [RED("distance")] public CHandle<AIArgumentMapping> Distance { get; set; }
		[Ordinal(4)] [RED("comparisonOperator")] public CEnum<EComparisonType> ComparisonOperator { get; set; }

		public AIbehaviorCheckDistanceToCompanionConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
