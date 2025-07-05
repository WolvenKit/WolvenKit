using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class gameJournalEntry : IScriptable
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CString Id
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("journalEntryOverrideDataList")] 
		public CArray<gameJournalEntryOverrideData> JournalEntryOverrideDataList
		{
			get => GetPropertyValue<CArray<gameJournalEntryOverrideData>>();
			set => SetPropertyValue<CArray<gameJournalEntryOverrideData>>(value);
		}

		public gameJournalEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
