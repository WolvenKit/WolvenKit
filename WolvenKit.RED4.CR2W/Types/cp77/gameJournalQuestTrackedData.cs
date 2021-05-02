using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuestTrackedData : CVariable
	{
		private CHandle<gameJournalPath> _entryPath;
		private CName _entryType;
		private CEnum<gameJournalEntryState> _state;

		[Ordinal(0)] 
		[RED("entryPath")] 
		public CHandle<gameJournalPath> EntryPath
		{
			get => GetProperty(ref _entryPath);
			set => SetProperty(ref _entryPath, value);
		}

		[Ordinal(1)] 
		[RED("entryType")] 
		public CName EntryType
		{
			get => GetProperty(ref _entryType);
			set => SetProperty(ref _entryType, value);
		}

		[Ordinal(2)] 
		[RED("state")] 
		public CEnum<gameJournalEntryState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		public gameJournalQuestTrackedData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
