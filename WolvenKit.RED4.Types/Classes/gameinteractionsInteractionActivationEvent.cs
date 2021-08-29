using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsInteractionActivationEvent : gameinteractionsInteractionBaseEvent
	{
		private CEnum<gameinteractionsEInteractionEventType> _eventType;

		[Ordinal(3)] 
		[RED("eventType")] 
		public CEnum<gameinteractionsEInteractionEventType> EventType
		{
			get => GetProperty(ref _eventType);
			set => SetProperty(ref _eventType, value);
		}
	}
}
