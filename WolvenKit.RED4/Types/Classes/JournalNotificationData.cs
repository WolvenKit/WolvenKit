using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class JournalNotificationData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("journalEntry")] 
		public CWeakHandle<gameJournalEntry> JournalEntry
		{
			get => GetPropertyValue<CWeakHandle<gameJournalEntry>>();
			set => SetPropertyValue<CWeakHandle<gameJournalEntry>>(value);
		}

		[Ordinal(8)] 
		[RED("journalEntryState")] 
		public CEnum<gameJournalEntryState> JournalEntryState
		{
			get => GetPropertyValue<CEnum<gameJournalEntryState>>();
			set => SetPropertyValue<CEnum<gameJournalEntryState>>(value);
		}

		[Ordinal(9)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("mode")] 
		public CEnum<JournalNotificationMode> Mode
		{
			get => GetPropertyValue<CEnum<JournalNotificationMode>>();
			set => SetPropertyValue<CEnum<JournalNotificationMode>>(value);
		}

		[Ordinal(11)] 
		[RED("type")] 
		public CEnum<MessengerContactType> Type
		{
			get => GetPropertyValue<CEnum<MessengerContactType>>();
			set => SetPropertyValue<CEnum<MessengerContactType>>(value);
		}

		[Ordinal(12)] 
		[RED("contactNameLocKey")] 
		public CName ContactNameLocKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("openedFromPhone")] 
		public CBool OpenedFromPhone
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("source")] 
		public CEnum<PhoneScreenType> Source
		{
			get => GetPropertyValue<CEnum<PhoneScreenType>>();
			set => SetPropertyValue<CEnum<PhoneScreenType>>(value);
		}

		public JournalNotificationData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
