
namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorDistanceToTargetObjectConditionDefinition : AIbehaviorDistanceToTargetConditionDefinition
	{
		public AIbehaviorDistanceToTargetObjectConditionDefinition()
		{
			Target = new AIArgumentMapping { Type = Enums.AIArgumentType.Object, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "whandle:gameObject" };
			Distance = new AIArgumentMapping { Type = Enums.AIArgumentType.Float, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "Float" };
			ComparisonOperator = Enums.EComparisonType.LessOrEqual;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
