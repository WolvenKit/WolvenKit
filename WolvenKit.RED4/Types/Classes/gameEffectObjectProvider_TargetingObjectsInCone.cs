using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectObjectProvider_TargetingObjectsInCone : gameEffectObjectProvider
	{
		[Ordinal(0)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetPropertyValue<CHandle<physicsFilterData>>();
			set => SetPropertyValue<CHandle<physicsFilterData>>(value);
		}

		[Ordinal(1)] 
		[RED("queryPreset")] 
		public physicsQueryPreset QueryPreset
		{
			get => GetPropertyValue<physicsQueryPreset>();
			set => SetPropertyValue<physicsQueryPreset>(value);
		}

		[Ordinal(2)] 
		[RED("searchQuery")] 
		public gameTargetSearchQuery SearchQuery
		{
			get => GetPropertyValue<gameTargetSearchQuery>();
			set => SetPropertyValue<gameTargetSearchQuery>(value);
		}

		[Ordinal(3)] 
		[RED("maxTargets")] 
		public CUInt32 MaxTargets
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("usePlayerPosAndForward")] 
		public CBool UsePlayerPosAndForward
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameEffectObjectProvider_TargetingObjectsInCone()
		{
			QueryPreset = new physicsQueryPreset();
			SearchQuery = new gameTargetSearchQuery { SearchFilter = new gameTargetSearchFilter(), IncludeSecondaryTargets = true, QueryTarget = new entEntityID() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
