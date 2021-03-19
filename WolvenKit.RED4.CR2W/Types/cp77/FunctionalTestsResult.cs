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
			get => GetProperty(ref _code);
			set => SetProperty(ref _code, value);
		}

		[Ordinal(1)] 
		[RED("msg")] 
		public CString Msg
		{
			get => GetProperty(ref _msg);
			set => SetProperty(ref _msg, value);
		}

		public FunctionalTestsResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
