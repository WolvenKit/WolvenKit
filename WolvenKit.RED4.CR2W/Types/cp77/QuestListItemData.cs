using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestListItemData : IScriptable
	{
		private CInt32 _questType;
		private GameTime _timestamp;
		private CBool _isTrackedQuest;
		private CBool _isOpenedQuest;
		private wCHandle<gameJournalQuest> _questData;
		private wCHandle<gameJournalManager> _journalManager;
		private CInt32 _playerLevel;
		private CInt32 _recommendedLevel;
		private CBool _isVisited;
		private CBool _isResolved;
		private CEnum<gameJournalEntryState> _state;
		private CBool _distancesFetched;
		private CArray<CHandle<QuestListDistanceData>> _objectivesDistances;

		[Ordinal(0)] 
		[RED("questType")] 
		public CInt32 QuestType
		{
			get
			{
				if (_questType == null)
				{
					_questType = (CInt32) CR2WTypeManager.Create("Int32", "questType", cr2w, this);
				}
				return _questType;
			}
			set
			{
				if (_questType == value)
				{
					return;
				}
				_questType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("timestamp")] 
		public GameTime Timestamp
		{
			get
			{
				if (_timestamp == null)
				{
					_timestamp = (GameTime) CR2WTypeManager.Create("GameTime", "timestamp", cr2w, this);
				}
				return _timestamp;
			}
			set
			{
				if (_timestamp == value)
				{
					return;
				}
				_timestamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isTrackedQuest")] 
		public CBool IsTrackedQuest
		{
			get
			{
				if (_isTrackedQuest == null)
				{
					_isTrackedQuest = (CBool) CR2WTypeManager.Create("Bool", "isTrackedQuest", cr2w, this);
				}
				return _isTrackedQuest;
			}
			set
			{
				if (_isTrackedQuest == value)
				{
					return;
				}
				_isTrackedQuest = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isOpenedQuest")] 
		public CBool IsOpenedQuest
		{
			get
			{
				if (_isOpenedQuest == null)
				{
					_isOpenedQuest = (CBool) CR2WTypeManager.Create("Bool", "isOpenedQuest", cr2w, this);
				}
				return _isOpenedQuest;
			}
			set
			{
				if (_isOpenedQuest == value)
				{
					return;
				}
				_isOpenedQuest = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("questData")] 
		public wCHandle<gameJournalQuest> QuestData
		{
			get
			{
				if (_questData == null)
				{
					_questData = (wCHandle<gameJournalQuest>) CR2WTypeManager.Create("whandle:gameJournalQuest", "questData", cr2w, this);
				}
				return _questData;
			}
			set
			{
				if (_questData == value)
				{
					return;
				}
				_questData = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		[Ordinal(8)] 
		[RED("isVisited")] 
		public CBool IsVisited
		{
			get
			{
				if (_isVisited == null)
				{
					_isVisited = (CBool) CR2WTypeManager.Create("Bool", "isVisited", cr2w, this);
				}
				return _isVisited;
			}
			set
			{
				if (_isVisited == value)
				{
					return;
				}
				_isVisited = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("isResolved")] 
		public CBool IsResolved
		{
			get
			{
				if (_isResolved == null)
				{
					_isResolved = (CBool) CR2WTypeManager.Create("Bool", "isResolved", cr2w, this);
				}
				return _isResolved;
			}
			set
			{
				if (_isResolved == value)
				{
					return;
				}
				_isResolved = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("State")] 
		public CEnum<gameJournalEntryState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<gameJournalEntryState>) CR2WTypeManager.Create("gameJournalEntryState", "State", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("distancesFetched")] 
		public CBool DistancesFetched
		{
			get
			{
				if (_distancesFetched == null)
				{
					_distancesFetched = (CBool) CR2WTypeManager.Create("Bool", "distancesFetched", cr2w, this);
				}
				return _distancesFetched;
			}
			set
			{
				if (_distancesFetched == value)
				{
					return;
				}
				_distancesFetched = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("objectivesDistances")] 
		public CArray<CHandle<QuestListDistanceData>> ObjectivesDistances
		{
			get
			{
				if (_objectivesDistances == null)
				{
					_objectivesDistances = (CArray<CHandle<QuestListDistanceData>>) CR2WTypeManager.Create("array:handle:QuestListDistanceData", "objectivesDistances", cr2w, this);
				}
				return _objectivesDistances;
			}
			set
			{
				if (_objectivesDistances == value)
				{
					return;
				}
				_objectivesDistances = value;
				PropertySet(this);
			}
		}

		public QuestListItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
