using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerVehicleName : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("vehicleName")] 
		public CString VehicleName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public ScannerVehicleName()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
