using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorPassiveConditionNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(1)] 
		[RED("condition")] 
		public CHandle<AIbehaviorPassiveConditionDefinition> Condition
		{
			get => GetPropertyValue<CHandle<AIbehaviorPassiveConditionDefinition>>();
			set => SetPropertyValue<CHandle<AIbehaviorPassiveConditionDefinition>>(value);
		}

		[Ordinal(2)] 
		[RED("resultIfFailed")] 
		public CEnum<AIbehaviorCompletionStatus> ResultIfFailed
		{
			get => GetPropertyValue<CEnum<AIbehaviorCompletionStatus>>();
			set => SetPropertyValue<CEnum<AIbehaviorCompletionStatus>>(value);
		}
	}
}
