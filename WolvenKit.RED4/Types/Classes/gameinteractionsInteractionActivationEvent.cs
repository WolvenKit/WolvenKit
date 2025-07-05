using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsInteractionActivationEvent : gameinteractionsInteractionBaseEvent
	{
		[Ordinal(3)] 
		[RED("eventType")] 
		public CEnum<gameinteractionsEInteractionEventType> EventType
		{
			get => GetPropertyValue<CEnum<gameinteractionsEInteractionEventType>>();
			set => SetPropertyValue<CEnum<gameinteractionsEInteractionEventType>>(value);
		}

		public gameinteractionsInteractionActivationEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
