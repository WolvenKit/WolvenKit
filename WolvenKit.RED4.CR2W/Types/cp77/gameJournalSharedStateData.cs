using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalSharedStateData : CVariable
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

		public gameJournalSharedStateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
