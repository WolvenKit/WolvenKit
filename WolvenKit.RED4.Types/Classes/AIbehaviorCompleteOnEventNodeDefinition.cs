using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorCompleteOnEventNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		private CName _eventName;
		private CEnum<AIbehaviorCompletionStatus> _resultOnEvent;

		[Ordinal(1)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetProperty(ref _eventName);
			set => SetProperty(ref _eventName, value);
		}

		[Ordinal(2)] 
		[RED("resultOnEvent")] 
		public CEnum<AIbehaviorCompletionStatus> ResultOnEvent
		{
			get => GetProperty(ref _resultOnEvent);
			set => SetProperty(ref _resultOnEvent, value);
		}

		public AIbehaviorCompleteOnEventNodeDefinition()
		{
			_resultOnEvent = new() { Value = Enums.AIbehaviorCompletionStatus.SUCCESS };
		}
	}
}
