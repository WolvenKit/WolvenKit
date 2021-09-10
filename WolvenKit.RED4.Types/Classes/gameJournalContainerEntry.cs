using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalContainerEntry : gameJournalEntry
	{
		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<CHandle<gameJournalEntry>> Entries
		{
			get => GetPropertyValue<CArray<CHandle<gameJournalEntry>>>();
			set => SetPropertyValue<CArray<CHandle<gameJournalEntry>>>(value);
		}
	}
}
