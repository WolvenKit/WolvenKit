using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animIKTargetRef : CVariable
	{
		private CInt32 _id;
		private CName _part;

		[Ordinal(0)] 
		[RED("id")] 
		public CInt32 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CInt32) CR2WTypeManager.Create("Int32", "id", cr2w, this);
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
		[RED("part")] 
		public CName Part
		{
			get
			{
				if (_part == null)
				{
					_part = (CName) CR2WTypeManager.Create("CName", "part", cr2w, this);
				}
				return _part;
			}
			set
			{
				if (_part == value)
				{
					return;
				}
				_part = value;
				PropertySet(this);
			}
		}

		public animIKTargetRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
