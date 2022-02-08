using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorStoryActionConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] 
		[RED("action")] 
		public CEnum<AIbehaviorStoryActionType> Action
		{
			get => GetPropertyValue<CEnum<AIbehaviorStoryActionType>>();
			set => SetPropertyValue<CEnum<AIbehaviorStoryActionType>>(value);
		}
	}
}
