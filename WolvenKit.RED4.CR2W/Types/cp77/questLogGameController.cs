using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questLogGameController : gameuiMenuGameController
	{
		private inkWidgetReference _virtualList;
		private inkWidgetReference _detailsPanel;
		private inkWidgetReference _buttonHints;
		private inkWidgetReference _buttonTrack;
		private ScriptGameInstance _game;
		private wCHandle<gameJournalManager> _journalManager;
		private CArray<wCHandle<gameJournalEntry>> _quests;
		private CArray<wCHandle<gameJournalEntry>> _resolvedQuests;
		private wCHandle<ButtonHints> _buttonHintsController;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private wCHandle<gameJournalQuest> _trackedQuest;
		private wCHandle<gameJournalQuest> _curreentQuest;
		private CInt32 _externallyOpenedQuestHash;
		private CInt32 _playerLevel;
		private CInt32 _recommendedLevel;
		private CHandle<inkanimProxy> _entryAnimProxy;
		private CArray<CHandle<VirutalNestedListData>> _listData;

		[Ordinal(3)] 
		[RED("virtualList")] 
		public inkWidgetReference VirtualList
		{
			get
			{
				if (_virtualList == null)
				{
					_virtualList = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "virtualList", cr2w, this);
				}
				return _virtualList;
			}
			set
			{
				if (_virtualList == value)
				{
					return;
				}
				_virtualList = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("detailsPanel")] 
		public inkWidgetReference DetailsPanel
		{
			get
			{
				if (_detailsPanel == null)
				{
					_detailsPanel = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "detailsPanel", cr2w, this);
				}
				return _detailsPanel;
			}
			set
			{
				if (_detailsPanel == value)
				{
					return;
				}
				_detailsPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("buttonHints")] 
		public inkWidgetReference ButtonHints
		{
			get
			{
				if (_buttonHints == null)
				{
					_buttonHints = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonHints", cr2w, this);
				}
				return _buttonHints;
			}
			set
			{
				if (_buttonHints == value)
				{
					return;
				}
				_buttonHints = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("buttonTrack")] 
		public inkWidgetReference ButtonTrack
		{
			get
			{
				if (_buttonTrack == null)
				{
					_buttonTrack = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonTrack", cr2w, this);
				}
				return _buttonTrack;
			}
			set
			{
				if (_buttonTrack == value)
				{
					return;
				}
				_buttonTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("game")] 
		public ScriptGameInstance Game
		{
			get
			{
				if (_game == null)
				{
					_game = (ScriptGameInstance) CR2WTypeManager.Create("ScriptGameInstance", "game", cr2w, this);
				}
				return _game;
			}
			set
			{
				if (_game == value)
				{
					return;
				}
				_game = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
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

		[Ordinal(9)] 
		[RED("quests")] 
		public CArray<wCHandle<gameJournalEntry>> Quests
		{
			get
			{
				if (_quests == null)
				{
					_quests = (CArray<wCHandle<gameJournalEntry>>) CR2WTypeManager.Create("array:whandle:gameJournalEntry", "quests", cr2w, this);
				}
				return _quests;
			}
			set
			{
				if (_quests == value)
				{
					return;
				}
				_quests = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("resolvedQuests")] 
		public CArray<wCHandle<gameJournalEntry>> ResolvedQuests
		{
			get
			{
				if (_resolvedQuests == null)
				{
					_resolvedQuests = (CArray<wCHandle<gameJournalEntry>>) CR2WTypeManager.Create("array:whandle:gameJournalEntry", "resolvedQuests", cr2w, this);
				}
				return _resolvedQuests;
			}
			set
			{
				if (_resolvedQuests == value)
				{
					return;
				}
				_resolvedQuests = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get
			{
				if (_buttonHintsController == null)
				{
					_buttonHintsController = (wCHandle<ButtonHints>) CR2WTypeManager.Create("whandle:ButtonHints", "buttonHintsController", cr2w, this);
				}
				return _buttonHintsController;
			}
			set
			{
				if (_buttonHintsController == value)
				{
					return;
				}
				_buttonHintsController = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get
			{
				if (_menuEventDispatcher == null)
				{
					_menuEventDispatcher = (wCHandle<inkMenuEventDispatcher>) CR2WTypeManager.Create("whandle:inkMenuEventDispatcher", "menuEventDispatcher", cr2w, this);
				}
				return _menuEventDispatcher;
			}
			set
			{
				if (_menuEventDispatcher == value)
				{
					return;
				}
				_menuEventDispatcher = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("trackedQuest")] 
		public wCHandle<gameJournalQuest> TrackedQuest
		{
			get
			{
				if (_trackedQuest == null)
				{
					_trackedQuest = (wCHandle<gameJournalQuest>) CR2WTypeManager.Create("whandle:gameJournalQuest", "trackedQuest", cr2w, this);
				}
				return _trackedQuest;
			}
			set
			{
				if (_trackedQuest == value)
				{
					return;
				}
				_trackedQuest = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("curreentQuest")] 
		public wCHandle<gameJournalQuest> CurreentQuest
		{
			get
			{
				if (_curreentQuest == null)
				{
					_curreentQuest = (wCHandle<gameJournalQuest>) CR2WTypeManager.Create("whandle:gameJournalQuest", "curreentQuest", cr2w, this);
				}
				return _curreentQuest;
			}
			set
			{
				if (_curreentQuest == value)
				{
					return;
				}
				_curreentQuest = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("externallyOpenedQuestHash")] 
		public CInt32 ExternallyOpenedQuestHash
		{
			get
			{
				if (_externallyOpenedQuestHash == null)
				{
					_externallyOpenedQuestHash = (CInt32) CR2WTypeManager.Create("Int32", "externallyOpenedQuestHash", cr2w, this);
				}
				return _externallyOpenedQuestHash;
			}
			set
			{
				if (_externallyOpenedQuestHash == value)
				{
					return;
				}
				_externallyOpenedQuestHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("playerLevel")] 
		public CInt32 PlayerLevel
		{
			get
			{
				if (_playerLevel == null)
				{
					_playerLevel = (CInt32) CR2WTypeManager.Create("Int32", "playerLevel", cr2w, this);
				}
				return _playerLevel;
			}
			set
			{
				if (_playerLevel == value)
				{
					return;
				}
				_playerLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("recommendedLevel")] 
		public CInt32 RecommendedLevel
		{
			get
			{
				if (_recommendedLevel == null)
				{
					_recommendedLevel = (CInt32) CR2WTypeManager.Create("Int32", "recommendedLevel", cr2w, this);
				}
				return _recommendedLevel;
			}
			set
			{
				if (_recommendedLevel == value)
				{
					return;
				}
				_recommendedLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("entryAnimProxy")] 
		public CHandle<inkanimProxy> EntryAnimProxy
		{
			get
			{
				if (_entryAnimProxy == null)
				{
					_entryAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "entryAnimProxy", cr2w, this);
				}
				return _entryAnimProxy;
			}
			set
			{
				if (_entryAnimProxy == value)
				{
					return;
				}
				_entryAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("listData")] 
		public CArray<CHandle<VirutalNestedListData>> ListData
		{
			get
			{
				if (_listData == null)
				{
					_listData = (CArray<CHandle<VirutalNestedListData>>) CR2WTypeManager.Create("array:handle:VirutalNestedListData", "listData", cr2w, this);
				}
				return _listData;
			}
			set
			{
				if (_listData == value)
				{
					return;
				}
				_listData = value;
				PropertySet(this);
			}
		}

		public questLogGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
