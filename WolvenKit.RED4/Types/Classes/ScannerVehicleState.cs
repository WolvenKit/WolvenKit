using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerVehicleState : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("vehicleState")] 
		public CString VehicleState
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public ScannerVehicleState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
