using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class JournalNotificationData : inkGameNotificationData
	{
		private wCHandle<gameJournalEntry> _journalEntry;
		private CEnum<gameJournalEntryState> _journalEntryState;
		private CName _className;
		private CBool _menuMode;

		[Ordinal(6)] 
		[RED("journalEntry")] 
		public wCHandle<gameJournalEntry> JournalEntry
		{
			get
			{
				if (_journalEntry == null)
				{
					_journalEntry = (wCHandle<gameJournalEntry>) CR2WTypeManager.Create("whandle:gameJournalEntry", "journalEntry", cr2w, this);
				}
				return _journalEntry;
			}
			set
			{
				if (_journalEntry == value)
				{
					return;
				}
				_journalEntry = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("journalEntryState")] 
		public CEnum<gameJournalEntryState> JournalEntryState
		{
			get
			{
				if (_journalEntryState == null)
				{
					_journalEntryState = (CEnum<gameJournalEntryState>) CR2WTypeManager.Create("gameJournalEntryState", "journalEntryState", cr2w, this);
				}
				return _journalEntryState;
			}
			set
			{
				if (_journalEntryState == value)
				{
					return;
				}
				_journalEntryState = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("className")] 
		public CName ClassName
		{
			get
			{
				if (_className == null)
				{
					_className = (CName) CR2WTypeManager.Create("CName", "className", cr2w, this);
				}
				return _className;
			}
			set
			{
				if (_className == value)
				{
					return;
				}
				_className = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("menuMode")] 
		public CBool MenuMode
		{
			get
			{
				if (_menuMode == null)
				{
					_menuMode = (CBool) CR2WTypeManager.Create("Bool", "menuMode", cr2w, this);
				}
				return _menuMode;
			}
			set
			{
				if (_menuMode == value)
				{
					return;
				}
				_menuMode = value;
				PropertySet(this);
			}
		}

		public JournalNotificationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
