using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorCheckDistanceToCompanionConditionDefinition : AIbehaviorCompanionConditionDefinition
	{
		[Ordinal(3)] 
		[RED("distance")] 
		public CHandle<AIArgumentMapping> Distance
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(4)] 
		[RED("comparisonOperator")] 
		public CEnum<EComparisonType> ComparisonOperator
		{
			get => GetPropertyValue<CEnum<EComparisonType>>();
			set => SetPropertyValue<CEnum<EComparisonType>>(value);
		}

		public AIbehaviorCheckDistanceToCompanionConditionDefinition()
		{
			Spline = new AIArgumentMapping { Type = Enums.AIArgumentType.NodeRef, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "NodeRef" };
			Companion = new AIArgumentMapping { Type = Enums.AIArgumentType.Object, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "whandle:gameObject" };
			Distance = new AIArgumentMapping { Type = Enums.AIArgumentType.Float, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "Float" };
			ComparisonOperator = Enums.EComparisonType.Less;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
