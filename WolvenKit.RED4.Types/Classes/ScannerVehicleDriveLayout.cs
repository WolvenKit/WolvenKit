using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerVehicleDriveLayout : ScannerChunk
	{
		private CString _vehicleDriveLayout;

		[Ordinal(0)] 
		[RED("vehicleDriveLayout")] 
		public CString VehicleDriveLayout
		{
			get => GetProperty(ref _vehicleDriveLayout);
			set => SetProperty(ref _vehicleDriveLayout, value);
		}
	}
}
