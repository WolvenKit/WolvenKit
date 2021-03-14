using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ResolveActionData : IScriptable
	{
		private CString _password;

		[Ordinal(0)] 
		[RED("password")] 
		public CString Password
		{
			get
			{
				if (_password == null)
				{
					_password = (CString) CR2WTypeManager.Create("String", "password", cr2w, this);
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

		public ResolveActionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
