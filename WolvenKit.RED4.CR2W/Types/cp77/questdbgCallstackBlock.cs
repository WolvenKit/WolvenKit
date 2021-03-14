using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questdbgCallstackBlock : CVariable
	{
		private CUInt64 _id;
		private CUInt64 _parentId;

		[Ordinal(0)] 
		[RED("id")] 
		public CUInt64 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CUInt64) CR2WTypeManager.Create("Uint64", "id", cr2w, this);
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
		[RED("parentId")] 
		public CUInt64 ParentId
		{
			get
			{
				if (_parentId == null)
				{
					_parentId = (CUInt64) CR2WTypeManager.Create("Uint64", "parentId", cr2w, this);
				}
				return _parentId;
			}
			set
			{
				if (_parentId == value)
				{
					return;
				}
				_parentId = value;
				PropertySet(this);
			}
		}

		public questdbgCallstackBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
