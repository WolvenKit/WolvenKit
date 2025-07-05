using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestMessageLinkController : BaseCodexLinkController
	{
		[Ordinal(6)] 
		[RED("contactEntry")] 
		public CHandle<gameJournalContact> ContactEntry
		{
			get => GetPropertyValue<CHandle<gameJournalContact>>();
			set => SetPropertyValue<CHandle<gameJournalContact>>(value);
		}

		[Ordinal(7)] 
		[RED("messageEntry")] 
		public CHandle<gameJournalPhoneMessage> MessageEntry
		{
			get => GetPropertyValue<CHandle<gameJournalPhoneMessage>>();
			set => SetPropertyValue<CHandle<gameJournalPhoneMessage>>(value);
		}

		[Ordinal(8)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(9)] 
		[RED("childEntry")] 
		public CWeakHandle<gameJournalEntry> ChildEntry
		{
			get => GetPropertyValue<CWeakHandle<gameJournalEntry>>();
			set => SetPropertyValue<CWeakHandle<gameJournalEntry>>(value);
		}

		[Ordinal(10)] 
		[RED("conversation")] 
		public CHandle<gameJournalPhoneConversation> Conversation
		{
			get => GetPropertyValue<CHandle<gameJournalPhoneConversation>>();
			set => SetPropertyValue<CHandle<gameJournalPhoneConversation>>(value);
		}

		[Ordinal(11)] 
		[RED("phoneSystem")] 
		public CWeakHandle<PhoneSystem> PhoneSystem
		{
			get => GetPropertyValue<CWeakHandle<PhoneSystem>>();
			set => SetPropertyValue<CWeakHandle<PhoneSystem>>(value);
		}

		public QuestMessageLinkController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
