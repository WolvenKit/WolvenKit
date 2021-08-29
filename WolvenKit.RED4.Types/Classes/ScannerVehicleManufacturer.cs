using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerVehicleManufacturer : ScannerChunk
	{
		private CString _vehicleManufacturer;

		[Ordinal(0)] 
		[RED("vehicleManufacturer")] 
		public CString VehicleManufacturer
		{
			get => GetProperty(ref _vehicleManufacturer);
			set => SetProperty(ref _vehicleManufacturer, value);
		}
	}
}
