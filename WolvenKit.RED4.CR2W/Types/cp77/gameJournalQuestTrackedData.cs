using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuestTrackedData : CVariable
	{
		private CHandle<gameJournalPath> _entryPath;
		private CName _entryType;
		private CEnum<gameJournalEntryState> _state;

		[Ordinal(0)] 
		[RED("entryPath")] 
		public CHandle<gameJournalPath> EntryPath
		{
			get
			{
				if (_entryPath == null)
				{
					_entryPath = (CHandle<gameJournalPath>) CR2WTypeManager.Create("handle:gameJournalPath", "entryPath", cr2w, this);
				}
				return _entryPath;
			}
			set
			{
				if (_entryPath == value)
				{
					return;
				}
				_entryPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("entryType")] 
		public CName EntryType
		{
			get
			{
				if (_entryType == null)
				{
					_entryType = (CName) CR2WTypeManager.Create("CName", "entryType", cr2w, this);
				}
				return _entryType;
			}
			set
			{
				if (_entryType == value)
				{
					return;
				}
				_entryType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("state")] 
		public CEnum<gameJournalEntryState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<gameJournalEntryState>) CR2WTypeManager.Create("gameJournalEntryState", "state", cr2w, this);
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

		public gameJournalQuestTrackedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
