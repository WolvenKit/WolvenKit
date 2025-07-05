using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetPhoneStatusRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("status")] 
		public CName Status
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questSetPhoneStatusRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
