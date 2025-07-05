using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectObjectFilter_NotObstructed : gameEffectObjectGroupFilter
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

		public gameEffectObjectFilter_NotObstructed()
		{
			QueryPreset = new physicsQueryPreset();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
