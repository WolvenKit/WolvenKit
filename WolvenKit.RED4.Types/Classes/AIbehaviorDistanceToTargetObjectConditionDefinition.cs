
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorDistanceToTargetObjectConditionDefinition : AIbehaviorDistanceToTargetConditionDefinition
	{

		public AIbehaviorDistanceToTargetObjectConditionDefinition()
		{
			ComparisonOperator = Enums.EComparisonType.LessOrEqual;
		}
	}
}
