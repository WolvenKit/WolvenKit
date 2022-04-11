using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerVehicleProdYears : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("vehicleProdYears")] 
		public CString VehicleProdYears
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public ScannerVehicleProdYears()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
