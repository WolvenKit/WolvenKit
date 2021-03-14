using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityAccessLevelEntry : CVariable
	{
		private TweakDBID _keycard;
		private CName _password;

		[Ordinal(0)] 
		[RED("keycard")] 
		public TweakDBID Keycard
		{
			get
			{
				if (_keycard == null)
				{
					_keycard = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "keycard", cr2w, this);
				}
				return _keycard;
			}
			set
			{
				if (_keycard == value)
				{
					return;
				}
				_keycard = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("password")] 
		public CName Password
		{
			get
			{
				if (_password == null)
				{
					_password = (CName) CR2WTypeManager.Create("CName", "password", cr2w, this);
				}
				return _password;
			}
			set
			{
				if (_password == value)
				{
					return;
				}
				_password = value;
				PropertySet(this);
			}
		}

		public SecurityAccessLevelEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
