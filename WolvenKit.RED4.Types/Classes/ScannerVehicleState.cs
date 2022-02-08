using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerVehicleState : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("vehicleState")] 
		public CString VehicleState
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
