using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerVehicleName : ScannerChunk
	{
		private CString _vehicleName;

		[Ordinal(0)] 
		[RED("vehicleName")] 
		public CString VehicleName
		{
			get => GetProperty(ref _vehicleName);
			set => SetProperty(ref _vehicleName, value);
		}
	}
}
