using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
