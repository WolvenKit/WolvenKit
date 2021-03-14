using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDistanceToTargetConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] [RED("target")] public CHandle<AIArgumentMapping> Target { get; set; }
		[Ordinal(2)] [RED("distance")] public CHandle<AIArgumentMapping> Distance { get; set; }
		[Ordinal(3)] [RED("comparisonOperator")] public CEnum<EComparisonType> ComparisonOperator { get; set; }

		public AIbehaviorDistanceToTargetConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
