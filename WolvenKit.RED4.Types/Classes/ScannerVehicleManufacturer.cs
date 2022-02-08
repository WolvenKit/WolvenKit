using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerVehicleManufacturer : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("vehicleManufacturer")] 
		public CString VehicleManufacturer
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
