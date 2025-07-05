using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorComparisonExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		[Ordinal(0)] 
		[RED("leftHandSide")] 
		public CHandle<AIbehaviorExpressionSocket> LeftHandSide
		{
			get => GetPropertyValue<CHandle<AIbehaviorExpressionSocket>>();
			set => SetPropertyValue<CHandle<AIbehaviorExpressionSocket>>(value);
		}

		[Ordinal(1)] 
		[RED("operator")] 
		public CEnum<EComparisonType> Operator
		{
			get => GetPropertyValue<CEnum<EComparisonType>>();
			set => SetPropertyValue<CEnum<EComparisonType>>(value);
		}

		[Ordinal(2)] 
		[RED("rightHandSide")] 
		public CHandle<AIbehaviorExpressionSocket> RightHandSide
		{
			get => GetPropertyValue<CHandle<AIbehaviorExpressionSocket>>();
			set => SetPropertyValue<CHandle<AIbehaviorExpressionSocket>>(value);
		}

		public AIbehaviorComparisonExpressionDefinition()
		{
			Operator = Enums.EComparisonType.Equal;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
