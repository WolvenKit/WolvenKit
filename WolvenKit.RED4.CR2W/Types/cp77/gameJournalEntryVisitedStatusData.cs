using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalEntryVisitedStatusData : CVariable
	{
		private CHandle<gameJournalPath> _entryPath;
		private CName _entryType;
		private CBool _isVisited;

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
		[RED("isVisited")] 
		public CBool IsVisited
		{
			get => GetProperty(ref _isVisited);
			set => SetProperty(ref _isVisited, value);
		}

		public gameJournalEntryVisitedStatusData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
