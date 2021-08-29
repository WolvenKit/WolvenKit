using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorStoryActionConditionDefinition : AIbehaviorConditionDefinition
	{
		private CEnum<AIbehaviorStoryActionType> _action;

		[Ordinal(1)] 
		[RED("action")] 
		public CEnum<AIbehaviorStoryActionType> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}
	}
}
