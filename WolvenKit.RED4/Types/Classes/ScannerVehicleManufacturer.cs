using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerVehicleManufacturer : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("vehicleManufacturer")] 
		public CString VehicleManufacturer
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public ScannerVehicleManufacturer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
