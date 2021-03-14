using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BlacklistPlayer : redEvent
	{
		private CBool _blacklist;
		private CEnum<BlacklistReason> _reason;
		private CBool _forceRemoveAuthorization;

		[Ordinal(0)] 
		[RED("blacklist")] 
		public CBool Blacklist
		{
			get
			{
				if (_blacklist == null)
				{
					_blacklist = (CBool) CR2WTypeManager.Create("Bool", "blacklist", cr2w, this);
				}
				return _blacklist;
			}
			set
			{
				if (_blacklist == value)
				{
					return;
				}
				_blacklist = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("reason")] 
		public CEnum<BlacklistReason> Reason
		{
			get
			{
				if (_reason == null)
				{
					_reason = (CEnum<BlacklistReason>) CR2WTypeManager.Create("BlacklistReason", "reason", cr2w, this);
				}
				return _reason;
			}
			set
			{
				if (_reason == value)
				{
					return;
				}
				_reason = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("forceRemoveAuthorization")] 
		public CBool ForceRemoveAuthorization
		{
			get
			{
				if (_forceRemoveAuthorization == null)
				{
					_forceRemoveAuthorization = (CBool) CR2WTypeManager.Create("Bool", "forceRemoveAuthorization", cr2w, this);
				}
				return _forceRemoveAuthorization;
			}
			set
			{
				if (_forceRemoveAuthorization == value)
				{
					return;
				}
				_forceRemoveAuthorization = value;
				PropertySet(this);
			}
		}

		public BlacklistPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
