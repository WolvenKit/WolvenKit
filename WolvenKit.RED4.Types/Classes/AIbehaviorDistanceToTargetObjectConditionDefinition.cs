
namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorDistanceToTargetObjectConditionDefinition : AIbehaviorDistanceToTargetConditionDefinition
	{
		public AIbehaviorDistanceToTargetObjectConditionDefinition()
		{
			ComparisonOperator = Enums.EComparisonType.LessOrEqual;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
