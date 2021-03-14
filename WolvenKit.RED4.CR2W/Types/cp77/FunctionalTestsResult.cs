using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FunctionalTestsResult : CVariable
	{
		private CEnum<FunctionalTestsResultCode> _code;
		private CString _msg;

		[Ordinal(0)] 
		[RED("code")] 
		public CEnum<FunctionalTestsResultCode> Code
		{
			get
			{
				if (_code == null)
				{
					_code = (CEnum<FunctionalTestsResultCode>) CR2WTypeManager.Create("FunctionalTestsResultCode", "code", cr2w, this);
				}
				return _code;
			}
			set
			{
				if (_code == value)
				{
					return;
				}
				_code = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("msg")] 
		public CString Msg
		{
			get
			{
				if (_msg == null)
				{
					_msg = (CString) CR2WTypeManager.Create("String", "msg", cr2w, this);
				}
				return _msg;
			}
			set
			{
				if (_msg == value)
				{
					return;
				}
				_msg = value;
				PropertySet(this);
			}
		}

		public FunctionalTestsResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
