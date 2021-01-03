using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorCheckDistanceToCompanionConditionDefinition : AIbehaviorCompanionConditionDefinition
	{
		[Ordinal(0)]  [RED("comparisonOperator")] public CEnum<EComparisonType> ComparisonOperator { get; set; }
		[Ordinal(1)]  [RED("distance")] public CHandle<AIArgumentMapping> Distance { get; set; }

		public AIbehaviorCheckDistanceToCompanionConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
