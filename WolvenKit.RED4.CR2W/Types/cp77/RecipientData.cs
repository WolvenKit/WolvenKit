using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RecipientData : CVariable
	{
		private CInt32 _fuseID;
		private CInt32 _entryID;

		[Ordinal(0)] 
		[RED("fuseID")] 
		public CInt32 FuseID
		{
			get
			{
				if (_fuseID == null)
				{
					_fuseID = (CInt32) CR2WTypeManager.Create("Int32", "fuseID", cr2w, this);
				}
				return _fuseID;
			}
			set
			{
				if (_fuseID == value)
				{
					return;
				}
				_fuseID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("entryID")] 
		public CInt32 EntryID
		{
			get
			{
				if (_entryID == null)
				{
					_entryID = (CInt32) CR2WTypeManager.Create("Int32", "entryID", cr2w, this);
				}
				return _entryID;
			}
			set
			{
				if (_entryID == value)
				{
					return;
				}
				_entryID = value;
				PropertySet(this);
			}
		}

		public RecipientData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
