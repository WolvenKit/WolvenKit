using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficPersistentData : RedBaseClass
	{
		private CArray<worldTrafficLanePersistent> _lanes;
		private CArray<CArray<CUInt16>> _neighborGroups;

		[Ordinal(0)] 
		[RED("lanes")] 
		public CArray<worldTrafficLanePersistent> Lanes
		{
			get => GetProperty(ref _lanes);
			set => SetProperty(ref _lanes, value);
		}

		[Ordinal(1)] 
		[RED("neighborGroups")] 
		public CArray<CArray<CUInt16>> NeighborGroups
		{
			get => GetProperty(ref _neighborGroups);
			set => SetProperty(ref _neighborGroups, value);
		}
	}
}
