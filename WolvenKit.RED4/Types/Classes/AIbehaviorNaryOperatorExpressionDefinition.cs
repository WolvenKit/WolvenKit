using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorNaryOperatorExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		[Ordinal(0)] 
		[RED("operator")] 
		public CEnum<AIbehaviorNaryExpressionOperators> Operator
		{
			get => GetPropertyValue<CEnum<AIbehaviorNaryExpressionOperators>>();
			set => SetPropertyValue<CEnum<AIbehaviorNaryExpressionOperators>>(value);
		}

		[Ordinal(1)] 
		[RED("operands")] 
		public CArray<CHandle<AIbehaviorExpressionSocket>> Operands
		{
			get => GetPropertyValue<CArray<CHandle<AIbehaviorExpressionSocket>>>();
			set => SetPropertyValue<CArray<CHandle<AIbehaviorExpressionSocket>>>(value);
		}

		public AIbehaviorNaryOperatorExpressionDefinition()
		{
			Operands = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
