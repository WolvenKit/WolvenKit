using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TypingDelayEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("conversationHash")] 
		public CInt32 ConversationHash
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("contactHash")] 
		public CInt32 ContactHash
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public TypingDelayEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
