using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamemappinsMappinSystemReplicatedState : gameIGameSystemReplicatedState
	{
		private CArray<gameNewMappinID> _mappinState;
		private CArray<CUInt32> _mappinWithJournalState;

		[Ordinal(0)] 
		[RED("mappinState")] 
		public CArray<gameNewMappinID> MappinState
		{
			get => GetProperty(ref _mappinState);
			set => SetProperty(ref _mappinState, value);
		}

		[Ordinal(1)] 
		[RED("mappinWithJournalState")] 
		public CArray<CUInt32> MappinWithJournalState
		{
			get => GetProperty(ref _mappinWithJournalState);
			set => SetProperty(ref _mappinWithJournalState, value);
		}
	}
}
