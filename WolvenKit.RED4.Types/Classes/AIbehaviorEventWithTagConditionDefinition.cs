using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorEventWithTagConditionDefinition : AIbehaviorConditionDefinition
	{
		private CName _tag;
		private CBool _consumeEvent;

		[Ordinal(1)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}

		[Ordinal(2)] 
		[RED("consumeEvent")] 
		public CBool ConsumeEvent
		{
			get => GetProperty(ref _consumeEvent);
			set => SetProperty(ref _consumeEvent, value);
		}

		public AIbehaviorEventWithTagConditionDefinition()
		{
			_consumeEvent = true;
		}
	}
}
