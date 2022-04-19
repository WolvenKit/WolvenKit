using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectObjectProvider_SingleRicochetTarget : gameEffectObjectProvider
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

		public gameEffectObjectProvider_SingleRicochetTarget()
		{
			QueryPreset = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
