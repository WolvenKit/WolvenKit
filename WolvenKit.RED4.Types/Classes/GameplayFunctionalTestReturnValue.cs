using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameplayFunctionalTestReturnValue : RedBaseClass
	{
		private CString _value;
		private CString _errorInfo;

		[Ordinal(0)] 
		[RED("value")] 
		public CString Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(1)] 
		[RED("errorInfo")] 
		public CString ErrorInfo
		{
			get => GetProperty(ref _errorInfo);
			set => SetProperty(ref _errorInfo, value);
		}
	}
}
