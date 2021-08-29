using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectObjectProvider_QuerySphere : gameEffectObjectProvider
	{
		private CBool _gatherOnlyPuppets;
		private CHandle<physicsFilterData> _filterData;

		[Ordinal(0)] 
		[RED("gatherOnlyPuppets")] 
		public CBool GatherOnlyPuppets
		{
			get => GetProperty(ref _gatherOnlyPuppets);
			set => SetProperty(ref _gatherOnlyPuppets, value);
		}

		[Ordinal(1)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetProperty(ref _filterData);
			set => SetProperty(ref _filterData, value);
		}
	}
}
