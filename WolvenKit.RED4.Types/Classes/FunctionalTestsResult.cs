using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FunctionalTestsResult : RedBaseClass
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
	}
}
