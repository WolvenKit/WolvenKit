using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class communityRole : ISerializable
	{
		private CName _roleName;

		[Ordinal(0)] 
		[RED("roleName")] 
		public CName RoleName
		{
			get
			{
				if (_roleName == null)
				{
					_roleName = (CName) CR2WTypeManager.Create("CName", "roleName", cr2w, this);
				}
				return _roleName;
			}
			set
			{
				if (_roleName == value)
				{
					return;
				}
				_roleName = value;
				PropertySet(this);
			}
		}

		public communityRole(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
