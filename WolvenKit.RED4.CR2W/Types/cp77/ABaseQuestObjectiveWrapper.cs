using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ABaseQuestObjectiveWrapper : AJournalEntryWrapper
	{
		private wCHandle<gameJournalQuestObjectiveBase> _questObjective;
		private CEnum<gameJournalEntryState> _objectiveStatus;
		private CBool _isTracked;
		private CInt32 _currentCounter;
		private CInt32 _totalCounter;

		[Ordinal(1)] 
		[RED("questObjective")] 
		public wCHandle<gameJournalQuestObjectiveBase> QuestObjective
		{
			get
			{
				if (_questObjective == null)
				{
					_questObjective = (wCHandle<gameJournalQuestObjectiveBase>) CR2WTypeManager.Create("whandle:gameJournalQuestObjectiveBase", "questObjective", cr2w, this);
				}
				return _questObjective;
			}
			set
			{
				if (_questObjective == value)
				{
					return;
				}
				_questObjective = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("objectiveStatus")] 
		public CEnum<gameJournalEntryState> ObjectiveStatus
		{
			get
			{
				if (_objectiveStatus == null)
				{
					_objectiveStatus = (CEnum<gameJournalEntryState>) CR2WTypeManager.Create("gameJournalEntryState", "objectiveStatus", cr2w, this);
				}
				return _objectiveStatus;
			}
			set
			{
				if (_objectiveStatus == value)
				{
					return;
				}
				_objectiveStatus = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("currentCounter")] 
		public CInt32 CurrentCounter
		{
			get
			{
				if (_currentCounter == null)
				{
					_currentCounter = (CInt32) CR2WTypeManager.Create("Int32", "currentCounter", cr2w, this);
				}
				return _currentCounter;
			}
			set
			{
				if (_currentCounter == value)
				{
					return;
				}
				_currentCounter = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("totalCounter")] 
		public CInt32 TotalCounter
		{
			get
			{
				if (_totalCounter == null)
				{
					_totalCounter = (CInt32) CR2WTypeManager.Create("Int32", "totalCounter", cr2w, this);
				}
				return _totalCounter;
			}
			set
			{
				if (_totalCounter == value)
				{
					return;
				}
				_totalCounter = value;
				PropertySet(this);
			}
		}

		public ABaseQuestObjectiveWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
