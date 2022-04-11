using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerVehicleInfo : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("vehicleInfo")] 
		public CString VehicleInfo
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
