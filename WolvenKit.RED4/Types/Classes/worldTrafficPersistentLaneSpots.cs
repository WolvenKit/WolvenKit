using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTrafficPersistentLaneSpots : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("spots")] 
		public CArray<CHandle<worldTrafficSpotCompiled>> Spots
		{
			get => GetPropertyValue<CArray<CHandle<worldTrafficSpotCompiled>>>();
			set => SetPropertyValue<CArray<CHandle<worldTrafficSpotCompiled>>>(value);
		}

		public worldTrafficPersistentLaneSpots()
		{
			Spots = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
