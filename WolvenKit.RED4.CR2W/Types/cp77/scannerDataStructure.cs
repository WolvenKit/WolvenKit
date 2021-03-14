using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scannerDataStructure : CVariable
	{
		private CString _entityName;
		private CString _quickHackName;
		private CString _quickHackDesc;
		private CArray<scannerQuestEntry> _questEntries;
		private CBool _empty;

		[Ordinal(0)] 
		[RED("entityName")] 
		public CString EntityName
		{
			get
			{
				if (_entityName == null)
				{
					_entityName = (CString) CR2WTypeManager.Create("String", "entityName", cr2w, this);
				}
				return _entityName;
			}
			set
			{
				if (_entityName == value)
				{
					return;
				}
				_entityName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("quickHackName")] 
		public CString QuickHackName
		{
			get
			{
				if (_quickHackName == null)
				{
					_quickHackName = (CString) CR2WTypeManager.Create("String", "quickHackName", cr2w, this);
				}
				return _quickHackName;
			}
			set
			{
				if (_quickHackName == value)
				{
					return;
				}
				_quickHackName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("quickHackDesc")] 
		public CString QuickHackDesc
		{
			get
			{
				if (_quickHackDesc == null)
				{
					_quickHackDesc = (CString) CR2WTypeManager.Create("String", "quickHackDesc", cr2w, this);
				}
				return _quickHackDesc;
			}
			set
			{
				if (_quickHackDesc == value)
				{
					return;
				}
				_quickHackDesc = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("questEntries")] 
		public CArray<scannerQuestEntry> QuestEntries
		{
			get
			{
				if (_questEntries == null)
				{
					_questEntries = (CArray<scannerQuestEntry>) CR2WTypeManager.Create("array:scannerQuestEntry", "questEntries", cr2w, this);
				}
				return _questEntries;
			}
			set
			{
				if (_questEntries == value)
				{
					return;
				}
				_questEntries = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("empty")] 
		public CBool Empty
		{
			get
			{
				if (_empty == null)
				{
					_empty = (CBool) CR2WTypeManager.Create("Bool", "empty", cr2w, this);
				}
				return _empty;
			}
			set
			{
				if (_empty == value)
				{
					return;
				}
				_empty = value;
				PropertySet(this);
			}
		}

		public scannerDataStructure(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
