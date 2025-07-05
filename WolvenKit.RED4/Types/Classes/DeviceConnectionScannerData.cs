using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeviceConnectionScannerData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("connectionType")] 
		public CString ConnectionType
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("icon")] 
		public CName Icon
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public DeviceConnectionScannerData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
