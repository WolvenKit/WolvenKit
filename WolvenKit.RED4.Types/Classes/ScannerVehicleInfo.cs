using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerVehicleInfo : ScannerChunk
	{
		private CString _vehicleInfo;

		[Ordinal(0)] 
		[RED("vehicleInfo")] 
		public CString VehicleInfo
		{
			get => GetProperty(ref _vehicleInfo);
			set => SetProperty(ref _vehicleInfo, value);
		}
	}
}
