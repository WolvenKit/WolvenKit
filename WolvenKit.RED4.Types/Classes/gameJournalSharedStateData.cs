using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalSharedStateData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("pathHash")] 
		public CUInt32 PathHash
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("entryState")] 
		public CEnum<gameJournalEntryState> EntryState
		{
			get => GetPropertyValue<CEnum<gameJournalEntryState>>();
			set => SetPropertyValue<CEnum<gameJournalEntryState>>(value);
		}
	}
}
