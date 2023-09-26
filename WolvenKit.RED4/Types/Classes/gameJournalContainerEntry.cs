using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class gameJournalContainerEntry : gameJournalEntry
	{
		[Ordinal(2)] 
		[RED("entries")] 
		public CArray<CHandle<gameJournalEntry>> Entries
		{
			get => GetPropertyValue<CArray<CHandle<gameJournalEntry>>>();
			set => SetPropertyValue<CArray<CHandle<gameJournalEntry>>>(value);
		}

		public gameJournalContainerEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
