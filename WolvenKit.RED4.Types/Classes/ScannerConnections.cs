using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerConnections : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("deviceConnections")] 
		public CArray<DeviceConnectionScannerData> DeviceConnections
		{
			get => GetPropertyValue<CArray<DeviceConnectionScannerData>>();
			set => SetPropertyValue<CArray<DeviceConnectionScannerData>>(value);
		}

		public ScannerConnections()
		{
			DeviceConnections = new();
		}
	}
}
