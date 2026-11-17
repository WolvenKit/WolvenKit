
namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorDistanceToTargetPositionConditionDefinition : AIbehaviorDistanceToTargetConditionDefinition
	{
		public AIbehaviorDistanceToTargetPositionConditionDefinition()
		{
			Target = new AIArgumentMapping { Type = Enums.AIArgumentType.Vector, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "Vector3" };
			Distance = new AIArgumentMapping { Type = Enums.AIArgumentType.Float, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "Float" };
			ComparisonOperator = Enums.EComparisonType.LessOrEqual;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
