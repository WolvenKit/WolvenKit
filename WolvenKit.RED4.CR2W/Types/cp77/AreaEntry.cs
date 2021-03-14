using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AreaEntry : CVariable
	{
		private entEntityID _user;

		[Ordinal(0)] 
		[RED("user")] 
		public entEntityID User
		{
			get
			{
				if (_user == null)
				{
					_user = (entEntityID) CR2WTypeManager.Create("entEntityID", "user", cr2w, this);
				}
				return _user;
			}
			set
			{
				if (_user == value)
				{
					return;
				}
				_user = value;
				PropertySet(this);
			}
		}

		public AreaEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
