using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTrafficPersistentSpatialResource : resStreamedResource
	{
		[Ordinal(1)] 
		[RED("neighborGroups")] 
		public CArray<CArray<CUInt16>> NeighborGroups
		{
			get => GetPropertyValue<CArray<CArray<CUInt16>>>();
			set => SetPropertyValue<CArray<CArray<CUInt16>>>(value);
		}

		public worldTrafficPersistentSpatialResource()
		{
			NeighborGroups = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
