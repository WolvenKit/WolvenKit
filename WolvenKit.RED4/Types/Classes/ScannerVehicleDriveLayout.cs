using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerVehicleDriveLayout : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("vehicleDriveLayout")] 
		public CString VehicleDriveLayout
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public ScannerVehicleDriveLayout()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
