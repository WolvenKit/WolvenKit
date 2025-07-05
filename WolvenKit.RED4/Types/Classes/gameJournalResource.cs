using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalResource : gameJournalBaseResource
	{
		[Ordinal(1)] 
		[RED("entry")] 
		public CHandle<gameJournalEntry> Entry
		{
			get => GetPropertyValue<CHandle<gameJournalEntry>>();
			set => SetPropertyValue<CHandle<gameJournalEntry>>(value);
		}

		public gameJournalResource()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
