using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalEntryVisitedStatusData : RedBaseClass
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
	}
}
