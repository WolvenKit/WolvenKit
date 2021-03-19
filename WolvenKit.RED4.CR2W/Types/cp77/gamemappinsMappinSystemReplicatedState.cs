using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsMappinSystemReplicatedState : gameIGameSystemReplicatedState
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

		public gamemappinsMappinSystemReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
