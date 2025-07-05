using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OnVisitedJournalEntryEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("entry")] 
		public CWeakHandle<gameJournalEntry> Entry
		{
			get => GetPropertyValue<CWeakHandle<gameJournalEntry>>();
			set => SetPropertyValue<CWeakHandle<gameJournalEntry>>(value);
		}

		public OnVisitedJournalEntryEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
