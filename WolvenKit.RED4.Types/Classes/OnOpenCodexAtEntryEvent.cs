using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OnOpenCodexAtEntryEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("entry")] 
		public CWeakHandle<gameJournalCodexEntry> Entry
		{
			get => GetPropertyValue<CWeakHandle<gameJournalCodexEntry>>();
			set => SetPropertyValue<CWeakHandle<gameJournalCodexEntry>>(value);
		}
	}
}
