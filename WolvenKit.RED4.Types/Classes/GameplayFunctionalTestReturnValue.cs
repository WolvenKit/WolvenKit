using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameplayFunctionalTestReturnValue : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("value")] 
		public CString Value
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("errorInfo")] 
		public CString ErrorInfo
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
