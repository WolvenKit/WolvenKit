using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class interopGlobalNodeIDResult : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("errorMessage")] 
		public CString ErrorMessage
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("result")] 
		public CString Result
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("isValid")] 
		public CBool IsValid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public interopGlobalNodeIDResult()
		{
			ErrorMessage = "<Unknown>";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
