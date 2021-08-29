using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerVehicleState : ScannerChunk
	{
		private CString _vehicleState;

		[Ordinal(0)] 
		[RED("vehicleState")] 
		public CString VehicleState
		{
			get => GetProperty(ref _vehicleState);
			set => SetProperty(ref _vehicleState, value);
		}
	}
}
