using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scannerQuestEntry : CVariable
	{
		private CName _categoryName;
		private CName _entryName;
		private TweakDBID _recordID;

		[Ordinal(0)] 
		[RED("categoryName")] 
		public CName CategoryName
		{
			get
			{
				if (_categoryName == null)
				{
					_categoryName = (CName) CR2WTypeManager.Create("CName", "categoryName", cr2w, this);
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

		[Ordinal(1)] 
		[RED("entryName")] 
		public CName EntryName
		{
			get
			{
				if (_entryName == null)
				{
					_entryName = (CName) CR2WTypeManager.Create("CName", "entryName", cr2w, this);
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
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get
			{
				if (_recordID == null)
				{
					_recordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "recordID", cr2w, this);
				}
				return _recordID;
			}
			set
			{
				if (_recordID == value)
				{
					return;
				}
				_recordID = value;
				PropertySet(this);
			}
		}

		public scannerQuestEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
