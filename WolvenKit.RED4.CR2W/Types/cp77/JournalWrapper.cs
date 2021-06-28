using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class JournalWrapper : ABaseWrapper
	{
		private wCHandle<gameJournalManager> _journalManager;
		private gameJournalRequestContext _journalContext;
		private gameJournalRequestContext _journalSubQuestContext;
		private CArray<wCHandle<gameJournalEntry>> _listOfJournalEntries;
		private ScriptGameInstance _gameInstance;

		[Ordinal(0)] 
		[RED("journalManager")] 
		public wCHandle<gameJournalManager> JournalManager
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
		public CArray<wCHandle<gameJournalEntry>> ListOfJournalEntries
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

		public JournalWrapper(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
