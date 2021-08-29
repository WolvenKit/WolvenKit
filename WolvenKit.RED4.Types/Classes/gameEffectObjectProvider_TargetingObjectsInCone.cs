using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectObjectProvider_TargetingObjectsInCone : gameEffectObjectProvider
	{
		private CHandle<physicsFilterData> _filterData;
		private gameTargetSearchQuery _searchQuery;
		private EulerAngles _searchAngles;
		private CUInt32 _maxTargets;
		private CBool _usePlayerPosAndForward;

		[Ordinal(0)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetProperty(ref _filterData);
			set => SetProperty(ref _filterData, value);
		}

		[Ordinal(1)] 
		[RED("searchQuery")] 
		public gameTargetSearchQuery SearchQuery
		{
			get => GetProperty(ref _searchQuery);
			set => SetProperty(ref _searchQuery, value);
		}

		[Ordinal(2)] 
		[RED("searchAngles")] 
		public EulerAngles SearchAngles
		{
			get => GetProperty(ref _searchAngles);
			set => SetProperty(ref _searchAngles, value);
		}

		[Ordinal(3)] 
		[RED("maxTargets")] 
		public CUInt32 MaxTargets
		{
			get => GetProperty(ref _maxTargets);
			set => SetProperty(ref _maxTargets, value);
		}

		[Ordinal(4)] 
		[RED("usePlayerPosAndForward")] 
		public CBool UsePlayerPosAndForward
		{
			get => GetProperty(ref _usePlayerPosAndForward);
			set => SetProperty(ref _usePlayerPosAndForward, value);
		}
	}
}
