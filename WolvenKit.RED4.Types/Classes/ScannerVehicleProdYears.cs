using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerVehicleProdYears : ScannerChunk
	{
		private CString _vehicleProdYears;

		[Ordinal(0)] 
		[RED("vehicleProdYears")] 
		public CString VehicleProdYears
		{
			get => GetProperty(ref _vehicleProdYears);
			set => SetProperty(ref _vehicleProdYears, value);
		}
	}
}
