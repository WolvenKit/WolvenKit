using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorNaryOperatorExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		private CEnum<AIbehaviorNaryExpressionOperators> _operator;
		private CArray<CHandle<AIbehaviorExpressionSocket>> _operands;

		[Ordinal(0)] 
		[RED("operator")] 
		public CEnum<AIbehaviorNaryExpressionOperators> Operator
		{
			get => GetProperty(ref _operator);
			set => SetProperty(ref _operator, value);
		}

		[Ordinal(1)] 
		[RED("operands")] 
		public CArray<CHandle<AIbehaviorExpressionSocket>> Operands
		{
			get => GetProperty(ref _operands);
			set => SetProperty(ref _operands, value);
		}
	}
}
