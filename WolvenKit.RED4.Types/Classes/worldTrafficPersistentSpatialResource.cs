using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficPersistentSpatialResource : resStreamedResource
	{
		private CArray<CArray<CUInt16>> _neighborGroups;

		[Ordinal(1)] 
		[RED("neighborGroups")] 
		public CArray<CArray<CUInt16>> NeighborGroups
		{
			get => GetProperty(ref _neighborGroups);
			set => SetProperty(ref _neighborGroups, value);
		}
	}
}
