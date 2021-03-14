using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questJournalEntry_ConditionType : questIJournalConditionType
	{
		private CHandle<gameJournalPath> _path;
		private CEnum<gameJournalEntryUserState> _state;

		[Ordinal(0)] 
		[RED("path")] 
		public CHandle<gameJournalPath> Path
		{
			get
			{
				if (_path == null)
				{
					_path = (CHandle<gameJournalPath>) CR2WTypeManager.Create("handle:gameJournalPath", "path", cr2w, this);
				}
				return _path;
			}
			set
			{
				if (_path == value)
				{
					return;
				}
				_path = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<gameJournalEntryUserState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<gameJournalEntryUserState>) CR2WTypeManager.Create("gameJournalEntryUserState", "state", cr2w, this);
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

		public questJournalEntry_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
