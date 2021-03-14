using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestTrackerGameController : gameuiHUDGameController
	{
		private inkTextWidgetReference _questTitle;
		private inkCompoundWidgetReference _objectiveContainer;
		private inkTextWidgetReference _trackedMappinTitle;
		private inkWidgetReference _trackedMappinContainer;
		private inkCompoundWidgetReference _trackedMappinObjectiveContainer;
		private wCHandle<gameObject> _player;
		private wCHandle<gameJournalManager> _journalManager;
		private wCHandle<gameJournalQuestObjective> _bufferedEntry;
		private wCHandle<gameJournalQuestPhase> _bufferedPhase;
		private wCHandle<gameJournalQuest> _bufferedQuest;
		private wCHandle<inkWidget> _root;
		private CHandle<gameIBlackboard> _blackboard;
		private CHandle<UI_SystemDef> _uiSystemBB;
		private CUInt32 _uiSystemId;
		private CUInt32 _trackedMappinId;

		[Ordinal(9)] 
		[RED("QuestTitle")] 
		public inkTextWidgetReference QuestTitle
		{
			get
			{
				if (_questTitle == null)
				{
					_questTitle = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "QuestTitle", cr2w, this);
				}
				return _questTitle;
			}
			set
			{
				if (_questTitle == value)
				{
					return;
				}
				_questTitle = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("ObjectiveContainer")] 
		public inkCompoundWidgetReference ObjectiveContainer
		{
			get
			{
				if (_objectiveContainer == null)
				{
					_objectiveContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "ObjectiveContainer", cr2w, this);
				}
				return _objectiveContainer;
			}
			set
			{
				if (_objectiveContainer == value)
				{
					return;
				}
				_objectiveContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("TrackedMappinTitle")] 
		public inkTextWidgetReference TrackedMappinTitle
		{
			get
			{
				if (_trackedMappinTitle == null)
				{
					_trackedMappinTitle = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "TrackedMappinTitle", cr2w, this);
				}
				return _trackedMappinTitle;
			}
			set
			{
				if (_trackedMappinTitle == value)
				{
					return;
				}
				_trackedMappinTitle = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("TrackedMappinContainer")] 
		public inkWidgetReference TrackedMappinContainer
		{
			get
			{
				if (_trackedMappinContainer == null)
				{
					_trackedMappinContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "TrackedMappinContainer", cr2w, this);
				}
				return _trackedMappinContainer;
			}
			set
			{
				if (_trackedMappinContainer == value)
				{
					return;
				}
				_trackedMappinContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("TrackedMappinObjectiveContainer")] 
		public inkCompoundWidgetReference TrackedMappinObjectiveContainer
		{
			get
			{
				if (_trackedMappinObjectiveContainer == null)
				{
					_trackedMappinObjectiveContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "TrackedMappinObjectiveContainer", cr2w, this);
				}
				return _trackedMappinObjectiveContainer;
			}
			set
			{
				if (_trackedMappinObjectiveContainer == value)
				{
					return;
				}
				_trackedMappinObjectiveContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
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

		[Ordinal(16)] 
		[RED("bufferedEntry")] 
		public wCHandle<gameJournalQuestObjective> BufferedEntry
		{
			get
			{
				if (_bufferedEntry == null)
				{
					_bufferedEntry = (wCHandle<gameJournalQuestObjective>) CR2WTypeManager.Create("whandle:gameJournalQuestObjective", "bufferedEntry", cr2w, this);
				}
				return _bufferedEntry;
			}
			set
			{
				if (_bufferedEntry == value)
				{
					return;
				}
				_bufferedEntry = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("bufferedPhase")] 
		public wCHandle<gameJournalQuestPhase> BufferedPhase
		{
			get
			{
				if (_bufferedPhase == null)
				{
					_bufferedPhase = (wCHandle<gameJournalQuestPhase>) CR2WTypeManager.Create("whandle:gameJournalQuestPhase", "bufferedPhase", cr2w, this);
				}
				return _bufferedPhase;
			}
			set
			{
				if (_bufferedPhase == value)
				{
					return;
				}
				_bufferedPhase = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("bufferedQuest")] 
		public wCHandle<gameJournalQuest> BufferedQuest
		{
			get
			{
				if (_bufferedQuest == null)
				{
					_bufferedQuest = (wCHandle<gameJournalQuest>) CR2WTypeManager.Create("whandle:gameJournalQuest", "bufferedQuest", cr2w, this);
				}
				return _bufferedQuest;
			}
			set
			{
				if (_bufferedQuest == value)
				{
					return;
				}
				_bufferedQuest = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("blackboard")] 
		public CHandle<gameIBlackboard> Blackboard
		{
			get
			{
				if (_blackboard == null)
				{
					_blackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "blackboard", cr2w, this);
				}
				return _blackboard;
			}
			set
			{
				if (_blackboard == value)
				{
					return;
				}
				_blackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("uiSystemBB")] 
		public CHandle<UI_SystemDef> UiSystemBB
		{
			get
			{
				if (_uiSystemBB == null)
				{
					_uiSystemBB = (CHandle<UI_SystemDef>) CR2WTypeManager.Create("handle:UI_SystemDef", "uiSystemBB", cr2w, this);
				}
				return _uiSystemBB;
			}
			set
			{
				if (_uiSystemBB == value)
				{
					return;
				}
				_uiSystemBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("uiSystemId")] 
		public CUInt32 UiSystemId
		{
			get
			{
				if (_uiSystemId == null)
				{
					_uiSystemId = (CUInt32) CR2WTypeManager.Create("Uint32", "uiSystemId", cr2w, this);
				}
				return _uiSystemId;
			}
			set
			{
				if (_uiSystemId == value)
				{
					return;
				}
				_uiSystemId = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("trackedMappinId")] 
		public CUInt32 TrackedMappinId
		{
			get
			{
				if (_trackedMappinId == null)
				{
					_trackedMappinId = (CUInt32) CR2WTypeManager.Create("Uint32", "trackedMappinId", cr2w, this);
				}
				return _trackedMappinId;
			}
			set
			{
				if (_trackedMappinId == value)
				{
					return;
				}
				_trackedMappinId = value;
				PropertySet(this);
			}
		}

		public QuestTrackerGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
