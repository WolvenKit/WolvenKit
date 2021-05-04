using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectProvider_TargetingObjectsInCone : gameEffectObjectProvider
	{
		private CHandle<physicsFilterData> _filterData;
		private gameTargetSearchQuery _searchQuery;
		private EulerAngles _searchAngles;
		private CUInt32 _maxTargets;

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

		public gameEffectObjectProvider_TargetingObjectsInCone(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
