using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AuthorizePlayerInSecuritySystem : redEvent
	{
		private CBool _authorize;
		private CBool _forceRemoveFromBlacklist;
		private CEnum<ESecurityAccessLevel> _eSL;

		[Ordinal(0)] 
		[RED("authorize")] 
		public CBool Authorize
		{
			get
			{
				if (_authorize == null)
				{
					_authorize = (CBool) CR2WTypeManager.Create("Bool", "authorize", cr2w, this);
				}
				return _authorize;
			}
			set
			{
				if (_authorize == value)
				{
					return;
				}
				_authorize = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("forceRemoveFromBlacklist")] 
		public CBool ForceRemoveFromBlacklist
		{
			get
			{
				if (_forceRemoveFromBlacklist == null)
				{
					_forceRemoveFromBlacklist = (CBool) CR2WTypeManager.Create("Bool", "forceRemoveFromBlacklist", cr2w, this);
				}
				return _forceRemoveFromBlacklist;
			}
			set
			{
				if (_forceRemoveFromBlacklist == value)
				{
					return;
				}
				_forceRemoveFromBlacklist = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ESL")] 
		public CEnum<ESecurityAccessLevel> ESL
		{
			get
			{
				if (_eSL == null)
				{
					_eSL = (CEnum<ESecurityAccessLevel>) CR2WTypeManager.Create("ESecurityAccessLevel", "ESL", cr2w, this);
				}
				return _eSL;
			}
			set
			{
				if (_eSL == value)
				{
					return;
				}
				_eSL = value;
				PropertySet(this);
			}
		}

		public AuthorizePlayerInSecuritySystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
