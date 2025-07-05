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
			ComparisonOperator = Enums.EComparisonType.Less;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
