using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalSharedStateData : RedBaseClass
	{
		private CUInt32 _pathHash;
		private CEnum<gameJournalEntryState> _entryState;

		[Ordinal(0)] 
		[RED("pathHash")] 
		public CUInt32 PathHash
		{
			get => GetProperty(ref _pathHash);
			set => SetProperty(ref _pathHash, value);
		}

		[Ordinal(1)] 
		[RED("entryState")] 
		public CEnum<gameJournalEntryState> EntryState
		{
			get => GetProperty(ref _entryState);
			set => SetProperty(ref _entryState, value);
		}
	}
}
