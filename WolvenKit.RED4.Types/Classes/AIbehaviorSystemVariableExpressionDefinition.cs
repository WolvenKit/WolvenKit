using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorSystemVariableExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		private CEnum<AIbehaviorSystemVariableExpressionTypes> _variable;

		[Ordinal(0)] 
		[RED("variable")] 
		public CEnum<AIbehaviorSystemVariableExpressionTypes> Variable
		{
			get => GetProperty(ref _variable);
			set => SetProperty(ref _variable, value);
		}
	}
}
