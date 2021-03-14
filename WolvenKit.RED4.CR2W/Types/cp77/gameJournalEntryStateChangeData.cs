using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalEntryStateChangeData : CVariable
	{
		private CHandle<gameJournalPath> _entryPath;
		private CString _entryName;
		private CName _entryType;
		private CBool _isEntryTracked;
		private CBool _isQuestEntryTracked;
		private CEnum<gameJournalEntryState> _oldState;
		private CEnum<gameJournalEntryState> _newState;
		private CEnum<gameJournalNotifyOption> _notifyOption;
		private CEnum<gameJournalChangeType> _changeType;

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
		[RED("entryName")] 
		public CString EntryName
		{
			get
			{
				if (_entryName == null)
				{
					_entryName = (CString) CR2WTypeManager.Create("String", "entryName", cr2w, this);
				}
				return _entryName;
			}
			set
			{
				if (_entryName == value)
				{
					return;
				}
				_entryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("isEntryTracked")] 
		public CBool IsEntryTracked
		{
			get
			{
				if (_isEntryTracked == null)
				{
					_isEntryTracked = (CBool) CR2WTypeManager.Create("Bool", "isEntryTracked", cr2w, this);
				}
				return _isEntryTracked;
			}
			set
			{
				if (_isEntryTracked == value)
				{
					return;
				}
				_isEntryTracked = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isQuestEntryTracked")] 
		public CBool IsQuestEntryTracked
		{
			get
			{
				if (_isQuestEntryTracked == null)
				{
					_isQuestEntryTracked = (CBool) CR2WTypeManager.Create("Bool", "isQuestEntryTracked", cr2w, this);
				}
				return _isQuestEntryTracked;
			}
			set
			{
				if (_isQuestEntryTracked == value)
				{
					return;
				}
				_isQuestEntryTracked = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("oldState")] 
		public CEnum<gameJournalEntryState> OldState
		{
			get
			{
				if (_oldState == null)
				{
					_oldState = (CEnum<gameJournalEntryState>) CR2WTypeManager.Create("gameJournalEntryState", "oldState", cr2w, this);
				}
				return _oldState;
			}
			set
			{
				if (_oldState == value)
				{
					return;
				}
				_oldState = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("newState")] 
		public CEnum<gameJournalEntryState> NewState
		{
			get
			{
				if (_newState == null)
				{
					_newState = (CEnum<gameJournalEntryState>) CR2WTypeManager.Create("gameJournalEntryState", "newState", cr2w, this);
				}
				return _newState;
			}
			set
			{
				if (_newState == value)
				{
					return;
				}
				_newState = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("notifyOption")] 
		public CEnum<gameJournalNotifyOption> NotifyOption
		{
			get
			{
				if (_notifyOption == null)
				{
					_notifyOption = (CEnum<gameJournalNotifyOption>) CR2WTypeManager.Create("gameJournalNotifyOption", "notifyOption", cr2w, this);
				}
				return _notifyOption;
			}
			set
			{
				if (_notifyOption == value)
				{
					return;
				}
				_notifyOption = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("changeType")] 
		public CEnum<gameJournalChangeType> ChangeType
		{
			get
			{
				if (_changeType == null)
				{
					_changeType = (CEnum<gameJournalChangeType>) CR2WTypeManager.Create("gameJournalChangeType", "changeType", cr2w, this);
				}
				return _changeType;
			}
			set
			{
				if (_changeType == value)
				{
					return;
				}
				_changeType = value;
				PropertySet(this);
			}
		}

		public gameJournalEntryStateChangeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
