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
			get
			{
				if (_journalManager == null)
				{
					_journalManager = (wCHandle<gameJournalManager>) CR2WTypeManager.Create("whandle:gameJournalManager", "journalManager", cr2w, this);
				}
				return _journalManager;
			}
			set
			{
				if (_journalManager == value)
				{
					return;
				}
				_journalManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("journalContext")] 
		public gameJournalRequestContext JournalContext
		{
			get
			{
				if (_journalContext == null)
				{
					_journalContext = (gameJournalRequestContext) CR2WTypeManager.Create("gameJournalRequestContext", "journalContext", cr2w, this);
				}
				return _journalContext;
			}
			set
			{
				if (_journalContext == value)
				{
					return;
				}
				_journalContext = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("journalSubQuestContext")] 
		public gameJournalRequestContext JournalSubQuestContext
		{
			get
			{
				if (_journalSubQuestContext == null)
				{
					_journalSubQuestContext = (gameJournalRequestContext) CR2WTypeManager.Create("gameJournalRequestContext", "journalSubQuestContext", cr2w, this);
				}
				return _journalSubQuestContext;
			}
			set
			{
				if (_journalSubQuestContext == value)
				{
					return;
				}
				_journalSubQuestContext = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("listOfJournalEntries")] 
		public CArray<wCHandle<gameJournalEntry>> ListOfJournalEntries
		{
			get
			{
				if (_listOfJournalEntries == null)
				{
					_listOfJournalEntries = (CArray<wCHandle<gameJournalEntry>>) CR2WTypeManager.Create("array:whandle:gameJournalEntry", "listOfJournalEntries", cr2w, this);
				}
				return _listOfJournalEntries;
			}
			set
			{
				if (_listOfJournalEntries == value)
				{
					return;
				}
				_listOfJournalEntries = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get
			{
				if (_gameInstance == null)
				{
					_gameInstance = (ScriptGameInstance) CR2WTypeManager.Create("ScriptGameInstance", "gameInstance", cr2w, this);
				}
				return _gameInstance;
			}
			set
			{
				if (_gameInstance == value)
				{
					return;
				}
				_gameInstance = value;
				PropertySet(this);
			}
		}

		public JournalWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
