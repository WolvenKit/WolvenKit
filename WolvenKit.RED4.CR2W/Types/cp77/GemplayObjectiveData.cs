using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GemplayObjectiveData : IScriptable
	{
		private CString _questUniqueId;
		private CString _questTitle;
		private CString _objectiveDescription;
		private CString _uniqueId;
		private entEntityID _ownerID;
		private CString _objectiveEntryID;
		private CString _uniqueIdPrefix;
		private CEnum<gameJournalEntryState> _objectiveState;

		[Ordinal(0)] 
		[RED("questUniqueId")] 
		public CString QuestUniqueId
		{
			get
			{
				if (_questUniqueId == null)
				{
					_questUniqueId = (CString) CR2WTypeManager.Create("String", "questUniqueId", cr2w, this);
				}
				return _questUniqueId;
			}
			set
			{
				if (_questUniqueId == value)
				{
					return;
				}
				_questUniqueId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("questTitle")] 
		public CString QuestTitle
		{
			get
			{
				if (_questTitle == null)
				{
					_questTitle = (CString) CR2WTypeManager.Create("String", "questTitle", cr2w, this);
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
		[RED("objectiveDescription")] 
		public CString ObjectiveDescription
		{
			get
			{
				if (_objectiveDescription == null)
				{
					_objectiveDescription = (CString) CR2WTypeManager.Create("String", "objectiveDescription", cr2w, this);
				}
				return _objectiveDescription;
			}
			set
			{
				if (_objectiveDescription == value)
				{
					return;
				}
				_objectiveDescription = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("uniqueId")] 
		public CString UniqueId
		{
			get
			{
				if (_uniqueId == null)
				{
					_uniqueId = (CString) CR2WTypeManager.Create("String", "uniqueId", cr2w, this);
				}
				return _uniqueId;
			}
			set
			{
				if (_uniqueId == value)
				{
					return;
				}
				_uniqueId = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get
			{
				if (_ownerID == null)
				{
					_ownerID = (entEntityID) CR2WTypeManager.Create("entEntityID", "ownerID", cr2w, this);
				}
				return _ownerID;
			}
			set
			{
				if (_ownerID == value)
				{
					return;
				}
				_ownerID = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("objectiveEntryID")] 
		public CString ObjectiveEntryID
		{
			get
			{
				if (_objectiveEntryID == null)
				{
					_objectiveEntryID = (CString) CR2WTypeManager.Create("String", "objectiveEntryID", cr2w, this);
				}
				return _objectiveEntryID;
			}
			set
			{
				if (_objectiveEntryID == value)
				{
					return;
				}
				_objectiveEntryID = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("uniqueIdPrefix")] 
		public CString UniqueIdPrefix
		{
			get
			{
				if (_uniqueIdPrefix == null)
				{
					_uniqueIdPrefix = (CString) CR2WTypeManager.Create("String", "uniqueIdPrefix", cr2w, this);
				}
				return _uniqueIdPrefix;
			}
			set
			{
				if (_uniqueIdPrefix == value)
				{
					return;
				}
				_uniqueIdPrefix = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("objectiveState")] 
		public CEnum<gameJournalEntryState> ObjectiveState
		{
			get
			{
				if (_objectiveState == null)
				{
					_objectiveState = (CEnum<gameJournalEntryState>) CR2WTypeManager.Create("gameJournalEntryState", "objectiveState", cr2w, this);
				}
				return _objectiveState;
			}
			set
			{
				if (_objectiveState == value)
				{
					return;
				}
				_objectiveState = value;
				PropertySet(this);
			}
		}

		public GemplayObjectiveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
