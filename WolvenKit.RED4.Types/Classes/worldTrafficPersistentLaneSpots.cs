using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficPersistentLaneSpots : RedBaseClass
	{
		private CArray<CHandle<worldTrafficSpotCompiled>> _spots;

		[Ordinal(0)] 
		[RED("spots")] 
		public CArray<CHandle<worldTrafficSpotCompiled>> Spots
		{
			get => GetProperty(ref _spots);
			set => SetProperty(ref _spots, value);
		}
	}
}
