using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorPassiveConditionNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		private CHandle<AIbehaviorPassiveConditionDefinition> _condition;
		private CEnum<AIbehaviorCompletionStatus> _resultIfFailed;

		[Ordinal(1)] 
		[RED("condition")] 
		public CHandle<AIbehaviorPassiveConditionDefinition> Condition
		{
			get => GetProperty(ref _condition);
			set => SetProperty(ref _condition, value);
		}

		[Ordinal(2)] 
		[RED("resultIfFailed")] 
		public CEnum<AIbehaviorCompletionStatus> ResultIfFailed
		{
			get => GetProperty(ref _resultIfFailed);
			set => SetProperty(ref _resultIfFailed, value);
		}
	}
}
