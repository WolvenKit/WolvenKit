using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerVehicleMass : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("mass")] 
		public CInt32 Mass
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ScannerVehicleMass()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
