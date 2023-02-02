using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerDeviceStatus : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("deviceStatus")] 
		public CString DeviceStatus
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("deviceStatusFriendlyName")] 
		public CString DeviceStatusFriendlyName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public ScannerDeviceStatus()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
