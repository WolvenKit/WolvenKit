using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkInputIconMappingJSON : CVariable
	{
		private CName _id;
		private CName _part;
		private CBool _hold;

		[Ordinal(0)] 
		[RED("id")] 
		public CName Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CName) CR2WTypeManager.Create("CName", "id", cr2w, this);
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

		[Ordinal(2)] 
		[RED("hold")] 
		public CBool Hold
		{
			get
			{
				if (_hold == null)
				{
					_hold = (CBool) CR2WTypeManager.Create("Bool", "hold", cr2w, this);
				}
				return _hold;
			}
			set
			{
				if (_hold == value)
				{
					return;
				}
				_hold = value;
				PropertySet(this);
			}
		}

		public inkInputIconMappingJSON(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
