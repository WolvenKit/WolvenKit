using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerAuthorization : ScannerChunk
	{
		private CBool _keycard;
		private CBool _password;

		[Ordinal(0)] 
		[RED("keycard")] 
		public CBool Keycard
		{
			get
			{
				if (_keycard == null)
				{
					_keycard = (CBool) CR2WTypeManager.Create("Bool", "keycard", cr2w, this);
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
		public CBool Password
		{
			get
			{
				if (_password == null)
				{
					_password = (CBool) CR2WTypeManager.Create("Bool", "password", cr2w, this);
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

		public ScannerAuthorization(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
