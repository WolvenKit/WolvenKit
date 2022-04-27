using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FunctionalTestsResult : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("code")] 
		public CEnum<FunctionalTestsResultCode> Code
		{
			get => GetPropertyValue<CEnum<FunctionalTestsResultCode>>();
			set => SetPropertyValue<CEnum<FunctionalTestsResultCode>>(value);
		}

		[Ordinal(1)] 
		[RED("msg")] 
		public CString Msg
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public FunctionalTestsResult()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
