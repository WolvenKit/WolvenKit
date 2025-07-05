using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OpenCodexPopupEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("entry")] 
		public CWeakHandle<gameJournalEntry> Entry
		{
			get => GetPropertyValue<CWeakHandle<gameJournalEntry>>();
			set => SetPropertyValue<CWeakHandle<gameJournalEntry>>(value);
		}

		public OpenCodexPopupEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
