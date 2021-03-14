using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestListController : inkWidgetLogicController
	{
		private inkTextWidgetReference _categoryName;
		private inkImageWidgetReference _icon;
		private inkCompoundWidgetReference _questListRef;
		private CEnum<gameJournalQuestType> _questType;
		private CArray<wCHandle<QuestItemController>> _questItems;
		private wCHandle<QuestDataWrapper> _lastQuestData;

		[Ordinal(1)] 
		[RED("CategoryName")] 
		public inkTextWidgetReference CategoryName
		{
			get
			{
				if (_categoryName == null)
				{
					_categoryName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "CategoryName", cr2w, this);
				}
				return _categoryName;
			}
			set
			{
				if (_categoryName == value)
				{
					return;
				}
				_categoryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get
			{
				if (_icon == null)
				{
					_icon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "icon", cr2w, this);
				}
				return _icon;
			}
			set
			{
				if (_icon == value)
				{
					return;
				}
				_icon = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("QuestListRef")] 
		public inkCompoundWidgetReference QuestListRef
		{
			get
			{
				if (_questListRef == null)
				{
					_questListRef = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "QuestListRef", cr2w, this);
				}
				return _questListRef;
			}
			set
			{
				if (_questListRef == value)
				{
					return;
				}
				_questListRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("QuestType")] 
		public CEnum<gameJournalQuestType> QuestType
		{
			get
			{
				if (_questType == null)
				{
					_questType = (CEnum<gameJournalQuestType>) CR2WTypeManager.Create("gameJournalQuestType", "QuestType", cr2w, this);
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

		[Ordinal(5)] 
		[RED("QuestItems")] 
		public CArray<wCHandle<QuestItemController>> QuestItems
		{
			get
			{
				if (_questItems == null)
				{
					_questItems = (CArray<wCHandle<QuestItemController>>) CR2WTypeManager.Create("array:whandle:QuestItemController", "QuestItems", cr2w, this);
				}
				return _questItems;
			}
			set
			{
				if (_questItems == value)
				{
					return;
				}
				_questItems = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("LastQuestData")] 
		public wCHandle<QuestDataWrapper> LastQuestData
		{
			get
			{
				if (_lastQuestData == null)
				{
					_lastQuestData = (wCHandle<QuestDataWrapper>) CR2WTypeManager.Create("whandle:QuestDataWrapper", "LastQuestData", cr2w, this);
				}
				return _lastQuestData;
			}
			set
			{
				if (_lastQuestData == value)
				{
					return;
				}
				_lastQuestData = value;
				PropertySet(this);
			}
		}

		public QuestListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
