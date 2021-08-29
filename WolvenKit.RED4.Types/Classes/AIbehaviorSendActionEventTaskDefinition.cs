using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorSendActionEventTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<gameActionEvent> _event;

		[Ordinal(1)] 
		[RED("event")] 
		public CHandle<gameActionEvent> Event
		{
			get => GetProperty(ref _event);
			set => SetProperty(ref _event, value);
		}
	}
}
