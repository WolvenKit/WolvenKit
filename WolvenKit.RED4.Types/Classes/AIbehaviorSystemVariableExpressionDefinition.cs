using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorSystemVariableExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		[Ordinal(0)] 
		[RED("variable")] 
		public CEnum<AIbehaviorSystemVariableExpressionTypes> Variable
		{
			get => GetPropertyValue<CEnum<AIbehaviorSystemVariableExpressionTypes>>();
			set => SetPropertyValue<CEnum<AIbehaviorSystemVariableExpressionTypes>>(value);
		}
	}
}
