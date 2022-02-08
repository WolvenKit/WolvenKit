using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class JournalNotificationData : inkGameNotificationData
	{
		[Ordinal(6)] 
		[RED("journalEntry")] 
		public CWeakHandle<gameJournalEntry> JournalEntry
		{
			get => GetPropertyValue<CWeakHandle<gameJournalEntry>>();
			set => SetPropertyValue<CWeakHandle<gameJournalEntry>>(value);
		}

		[Ordinal(7)] 
		[RED("journalEntryState")] 
		public CEnum<gameJournalEntryState> JournalEntryState
		{
			get => GetPropertyValue<CEnum<gameJournalEntryState>>();
			set => SetPropertyValue<CEnum<gameJournalEntryState>>(value);
		}

		[Ordinal(8)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("menuMode")] 
		public CBool MenuMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
