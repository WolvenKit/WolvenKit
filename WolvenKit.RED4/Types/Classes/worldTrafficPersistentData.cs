using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTrafficPersistentData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("lanes")] 
		public CArray<worldTrafficLanePersistent> Lanes
		{
			get => GetPropertyValue<CArray<worldTrafficLanePersistent>>();
			set => SetPropertyValue<CArray<worldTrafficLanePersistent>>(value);
		}

		[Ordinal(1)] 
		[RED("neighborGroups")] 
		public CArray<CArray<CUInt16>> NeighborGroups
		{
			get => GetPropertyValue<CArray<CArray<CUInt16>>>();
			set => SetPropertyValue<CArray<CArray<CUInt16>>>(value);
		}

		public worldTrafficPersistentData()
		{
			Lanes = new();
			NeighborGroups = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
