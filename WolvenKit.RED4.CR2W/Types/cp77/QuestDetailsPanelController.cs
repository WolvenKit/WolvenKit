using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestDetailsPanelController : inkWidgetLogicController
	{
		private inkTextWidgetReference _questTitle;
		private inkTextWidgetReference _questDescription;
		private inkTextWidgetReference _questLevel;
		private inkCompoundWidgetReference _activeObjectives;
		private inkCompoundWidgetReference _optionalObjectives;
		private inkCompoundWidgetReference _completedObjectives;
		private inkCompoundWidgetReference _codexLinksContainer;
		private inkWidgetReference _contentContainer;
		private inkWidgetReference _noSelectedQuestContainer;
		private wCHandle<gameJournalQuest> _currentQuestData;
		private wCHandle<gameJournalManager> _journalManager;
		private wCHandle<PhoneSystem> _phoneSystem;
		private wCHandle<gamemappinsMappinSystem> _mappinSystem;
		private wCHandle<gameJournalQuestObjective> _trackedObjective;

		[Ordinal(1)] 
		[RED("questTitle")] 
		public inkTextWidgetReference QuestTitle
		{
			get
			{
				if (_questTitle == null)
				{
					_questTitle = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "questTitle", cr2w, this);
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

		[Ordinal(2)] 
		[RED("questDescription")] 
		public inkTextWidgetReference QuestDescription
		{
			get
			{
				if (_questDescription == null)
				{
					_questDescription = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "questDescription", cr2w, this);
				}
				return _questDescription;
			}
			set
			{
				if (_questDescription == value)
				{
					return;
				}
				_questDescription = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("questLevel")] 
		public inkTextWidgetReference QuestLevel
		{
			get
			{
				if (_questLevel == null)
				{
					_questLevel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "questLevel", cr2w, this);
				}
				return _questLevel;
			}
			set
			{
				if (_questLevel == value)
				{
					return;
				}
				_questLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("activeObjectives")] 
		public inkCompoundWidgetReference ActiveObjectives
		{
			get
			{
				if (_activeObjectives == null)
				{
					_activeObjectives = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "activeObjectives", cr2w, this);
				}
				return _activeObjectives;
			}
			set
			{
				if (_activeObjectives == value)
				{
					return;
				}
				_activeObjectives = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("optionalObjectives")] 
		public inkCompoundWidgetReference OptionalObjectives
		{
			get
			{
				if (_optionalObjectives == null)
				{
					_optionalObjectives = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "optionalObjectives", cr2w, this);
				}
				return _optionalObjectives;
			}
			set
			{
				if (_optionalObjectives == value)
				{
					return;
				}
				_optionalObjectives = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("completedObjectives")] 
		public inkCompoundWidgetReference CompletedObjectives
		{
			get
			{
				if (_completedObjectives == null)
				{
					_completedObjectives = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "completedObjectives", cr2w, this);
				}
				return _completedObjectives;
			}
			set
			{
				if (_completedObjectives == value)
				{
					return;
				}
				_completedObjectives = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("codexLinksContainer")] 
		public inkCompoundWidgetReference CodexLinksContainer
		{
			get
			{
				if (_codexLinksContainer == null)
				{
					_codexLinksContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "codexLinksContainer", cr2w, this);
				}
				return _codexLinksContainer;
			}
			set
			{
				if (_codexLinksContainer == value)
				{
					return;
				}
				_codexLinksContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("contentContainer")] 
		public inkWidgetReference ContentContainer
		{
			get
			{
				if (_contentContainer == null)
				{
					_contentContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "contentContainer", cr2w, this);
				}
				return _contentContainer;
			}
			set
			{
				if (_contentContainer == value)
				{
					return;
				}
				_contentContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("noSelectedQuestContainer")] 
		public inkWidgetReference NoSelectedQuestContainer
		{
			get
			{
				if (_noSelectedQuestContainer == null)
				{
					_noSelectedQuestContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "noSelectedQuestContainer", cr2w, this);
				}
				return _noSelectedQuestContainer;
			}
			set
			{
				if (_noSelectedQuestContainer == value)
				{
					return;
				}
				_noSelectedQuestContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("currentQuestData")] 
		public wCHandle<gameJournalQuest> CurrentQuestData
		{
			get
			{
				if (_currentQuestData == null)
				{
					_currentQuestData = (wCHandle<gameJournalQuest>) CR2WTypeManager.Create("whandle:gameJournalQuest", "currentQuestData", cr2w, this);
				}
				return _currentQuestData;
			}
			set
			{
				if (_currentQuestData == value)
				{
					return;
				}
				_currentQuestData = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
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

		[Ordinal(12)] 
		[RED("phoneSystem")] 
		public wCHandle<PhoneSystem> PhoneSystem
		{
			get
			{
				if (_phoneSystem == null)
				{
					_phoneSystem = (wCHandle<PhoneSystem>) CR2WTypeManager.Create("whandle:PhoneSystem", "phoneSystem", cr2w, this);
				}
				return _phoneSystem;
			}
			set
			{
				if (_phoneSystem == value)
				{
					return;
				}
				_phoneSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("mappinSystem")] 
		public wCHandle<gamemappinsMappinSystem> MappinSystem
		{
			get
			{
				if (_mappinSystem == null)
				{
					_mappinSystem = (wCHandle<gamemappinsMappinSystem>) CR2WTypeManager.Create("whandle:gamemappinsMappinSystem", "mappinSystem", cr2w, this);
				}
				return _mappinSystem;
			}
			set
			{
				if (_mappinSystem == value)
				{
					return;
				}
				_mappinSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("trackedObjective")] 
		public wCHandle<gameJournalQuestObjective> TrackedObjective
		{
			get
			{
				if (_trackedObjective == null)
				{
					_trackedObjective = (wCHandle<gameJournalQuestObjective>) CR2WTypeManager.Create("whandle:gameJournalQuestObjective", "trackedObjective", cr2w, this);
				}
				return _trackedObjective;
			}
			set
			{
				if (_trackedObjective == value)
				{
					return;
				}
				_trackedObjective = value;
				PropertySet(this);
			}
		}

		public QuestDetailsPanelController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
