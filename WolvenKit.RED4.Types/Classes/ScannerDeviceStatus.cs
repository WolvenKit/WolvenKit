using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerDeviceStatus : ScannerChunk
	{
		private CString _deviceStatus;
		private CString _deviceStatusFriendlyName;

		[Ordinal(0)] 
		[RED("deviceStatus")] 
		public CString DeviceStatus
		{
			get => GetProperty(ref _deviceStatus);
			set => SetProperty(ref _deviceStatus, value);
		}

		[Ordinal(1)] 
		[RED("deviceStatusFriendlyName")] 
		public CString DeviceStatusFriendlyName
		{
			get => GetProperty(ref _deviceStatusFriendlyName);
			set => SetProperty(ref _deviceStatusFriendlyName, value);
		}
	}
}
