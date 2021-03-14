using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestDataWrapper : AJournalEntryWrapper
	{
		private CBool _isNew;
		private wCHandle<gameJournalQuest> _quest;
		private CString _title;
		private CString _description;
		private CArray<CHandle<QuestObjectiveWrapper>> _questObjectives;
		private CArray<wCHandle<gameJournalEntry>> _links;
		private CEnum<gameJournalEntryState> _questStatus;
		private CBool _isTracked;
		private CBool _isChildTracked;
		private CInt32 _recommendedLevel;
		private CHandle<gamedataDistrict_Record> _district;

		[Ordinal(1)] 
		[RED("isNew")] 
		public CBool IsNew
		{
			get
			{
				if (_isNew == null)
				{
					_isNew = (CBool) CR2WTypeManager.Create("Bool", "isNew", cr2w, this);
				}
				return _isNew;
			}
			set
			{
				if (_isNew == value)
				{
					return;
				}
				_isNew = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("quest")] 
		public wCHandle<gameJournalQuest> Quest
		{
			get
			{
				if (_quest == null)
				{
					_quest = (wCHandle<gameJournalQuest>) CR2WTypeManager.Create("whandle:gameJournalQuest", "quest", cr2w, this);
				}
				return _quest;
			}
			set
			{
				if (_quest == value)
				{
					return;
				}
				_quest = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("title")] 
		public CString Title
		{
			get
			{
				if (_title == null)
				{
					_title = (CString) CR2WTypeManager.Create("String", "title", cr2w, this);
				}
				return _title;
			}
			set
			{
				if (_title == value)
				{
					return;
				}
				_title = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("description")] 
		public CString Description
		{
			get
			{
				if (_description == null)
				{
					_description = (CString) CR2WTypeManager.Create("String", "description", cr2w, this);
				}
				return _description;
			}
			set
			{
				if (_description == value)
				{
					return;
				}
				_description = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("questObjectives")] 
		public CArray<CHandle<QuestObjectiveWrapper>> QuestObjectives
		{
			get
			{
				if (_questObjectives == null)
				{
					_questObjectives = (CArray<CHandle<QuestObjectiveWrapper>>) CR2WTypeManager.Create("array:handle:QuestObjectiveWrapper", "questObjectives", cr2w, this);
				}
				return _questObjectives;
			}
			set
			{
				if (_questObjectives == value)
				{
					return;
				}
				_questObjectives = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("links")] 
		public CArray<wCHandle<gameJournalEntry>> Links
		{
			get
			{
				if (_links == null)
				{
					_links = (CArray<wCHandle<gameJournalEntry>>) CR2WTypeManager.Create("array:whandle:gameJournalEntry", "links", cr2w, this);
				}
				return _links;
			}
			set
			{
				if (_links == value)
				{
					return;
				}
				_links = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("questStatus")] 
		public CEnum<gameJournalEntryState> QuestStatus
		{
			get
			{
				if (_questStatus == null)
				{
					_questStatus = (CEnum<gameJournalEntryState>) CR2WTypeManager.Create("gameJournalEntryState", "questStatus", cr2w, this);
				}
				return _questStatus;
			}
			set
			{
				if (_questStatus == value)
				{
					return;
				}
				_questStatus = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("isTracked")] 
		public CBool IsTracked
		{
			get
			{
				if (_isTracked == null)
				{
					_isTracked = (CBool) CR2WTypeManager.Create("Bool", "isTracked", cr2w, this);
				}
				return _isTracked;
			}
			set
			{
				if (_isTracked == value)
				{
					return;
				}
				_isTracked = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("isChildTracked")] 
		public CBool IsChildTracked
		{
			get
			{
				if (_isChildTracked == null)
				{
					_isChildTracked = (CBool) CR2WTypeManager.Create("Bool", "isChildTracked", cr2w, this);
				}
				return _isChildTracked;
			}
			set
			{
				if (_isChildTracked == value)
				{
					return;
				}
				_isChildTracked = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
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

		[Ordinal(11)] 
		[RED("district")] 
		public CHandle<gamedataDistrict_Record> District
		{
			get
			{
				if (_district == null)
				{
					_district = (CHandle<gamedataDistrict_Record>) CR2WTypeManager.Create("handle:gamedataDistrict_Record", "district", cr2w, this);
				}
				return _district;
			}
			set
			{
				if (_district == value)
				{
					return;
				}
				_district = value;
				PropertySet(this);
			}
		}

		public QuestDataWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
