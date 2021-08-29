using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerVehicleMass : ScannerChunk
	{
		private CInt32 _mass;

		[Ordinal(0)] 
		[RED("mass")] 
		public CInt32 Mass
		{
			get => GetProperty(ref _mass);
			set => SetProperty(ref _mass, value);
		}
	}
}
