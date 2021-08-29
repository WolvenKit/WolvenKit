using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerConnections : ScannerChunk
	{
		private CArray<DeviceConnectionScannerData> _deviceConnections;

		[Ordinal(0)] 
		[RED("deviceConnections")] 
		public CArray<DeviceConnectionScannerData> DeviceConnections
		{
			get => GetProperty(ref _deviceConnections);
			set => SetProperty(ref _deviceConnections, value);
		}
	}
}
