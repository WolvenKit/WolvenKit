using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerVehicleHorsepower : ScannerChunk
	{
		private CInt32 _horsepower;

		[Ordinal(0)] 
		[RED("horsepower")] 
		public CInt32 Horsepower
		{
			get => GetProperty(ref _horsepower);
			set => SetProperty(ref _horsepower, value);
		}
	}
}
