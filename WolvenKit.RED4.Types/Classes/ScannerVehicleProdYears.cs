using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerVehicleProdYears : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("vehicleProdYears")] 
		public CString VehicleProdYears
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
