using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuestObjectiveCounterData : CVariable
	{
		private CHandle<gameJournalPath> _entryPath;
		private CInt32 _oldValue;
		private CInt32 _newValue;

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
		[RED("oldValue")] 
		public CInt32 OldValue
		{
			get
			{
				if (_oldValue == null)
				{
					_oldValue = (CInt32) CR2WTypeManager.Create("Int32", "oldValue", cr2w, this);
				}
				return _oldValue;
			}
			set
			{
				if (_oldValue == value)
				{
					return;
				}
				_oldValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("newValue")] 
		public CInt32 NewValue
		{
			get
			{
				if (_newValue == null)
				{
					_newValue = (CInt32) CR2WTypeManager.Create("Int32", "newValue", cr2w, this);
				}
				return _newValue;
			}
			set
			{
				if (_newValue == value)
				{
					return;
				}
				_newValue = value;
				PropertySet(this);
			}
		}

		public gameJournalQuestObjectiveCounterData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
