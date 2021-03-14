using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RevokeAuthorization : redEvent
	{
		private entEntityID _user;
		private CEnum<ESecurityAccessLevel> _level;

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

		[Ordinal(1)] 
		[RED("level")] 
		public CEnum<ESecurityAccessLevel> Level
		{
			get
			{
				if (_level == null)
				{
					_level = (CEnum<ESecurityAccessLevel>) CR2WTypeManager.Create("ESecurityAccessLevel", "level", cr2w, this);
				}
				return _level;
			}
			set
			{
				if (_level == value)
				{
					return;
				}
				_level = value;
				PropertySet(this);
			}
		}

		public RevokeAuthorization(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
