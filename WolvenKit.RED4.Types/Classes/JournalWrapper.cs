using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class JournalWrapper : ABaseWrapper
	{
		private CWeakHandle<gameJournalManager> _journalManager;
		private gameJournalRequestContext _journalContext;
		private gameJournalRequestContext _journalSubQuestContext;
		private CArray<CWeakHandle<gameJournalEntry>> _listOfJournalEntries;
		private ScriptGameInstance _gameInstance;

		[Ordinal(0)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(1)] 
		[RED("journalContext")] 
		public gameJournalRequestContext JournalContext
		{
			get => GetProperty(ref _journalContext);
			set => SetProperty(ref _journalContext, value);
		}

		[Ordinal(2)] 
		[RED("journalSubQuestContext")] 
		public gameJournalRequestContext JournalSubQuestContext
		{
			get => GetProperty(ref _journalSubQuestContext);
			set => SetProperty(ref _journalSubQuestContext, value);
		}

		[Ordinal(3)] 
		[RED("listOfJournalEntries")] 
		public CArray<CWeakHandle<gameJournalEntry>> ListOfJournalEntries
		{
			get => GetProperty(ref _listOfJournalEntries);
			set => SetProperty(ref _listOfJournalEntries, value);
		}

		[Ordinal(4)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}
	}
}
