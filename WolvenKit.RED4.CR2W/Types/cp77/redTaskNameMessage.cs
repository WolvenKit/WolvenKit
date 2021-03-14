using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class redTaskNameMessage : CVariable
	{
		private CUInt32 _id;
		private CString _title;
		private CName _uniqueName;

		[Ordinal(0)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CUInt32) CR2WTypeManager.Create("Uint32", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("title")] 
		public CString Title
		{
			get
			{
				if (_title == null)
				{
					_title = (CString) CR2WTypeManager.Create("String", "title", cr2w, this);
				}
				return _title;
			}
			set
			{
				if (_title == value)
				{
					return;
				}
				_title = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("uniqueName")] 
		public CName UniqueName
		{
			get
			{
				if (_uniqueName == null)
				{
					_uniqueName = (CName) CR2WTypeManager.Create("CName", "uniqueName", cr2w, this);
				}
				return _uniqueName;
			}
			set
			{
				if (_uniqueName == value)
				{
					return;
				}
				_uniqueName = value;
				PropertySet(this);
			}
		}

		public redTaskNameMessage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
