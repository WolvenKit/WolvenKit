using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectObjectProvider_QueryBox : gameEffectObjectProvider
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
		[RED("inputPosition")] 
		public gameEffectInputParameter_Vector InputPosition
		{
			get => GetPropertyValue<gameEffectInputParameter_Vector>();
			set => SetPropertyValue<gameEffectInputParameter_Vector>(value);
		}

		public gameEffectObjectProvider_QueryBox()
		{
			QueryPreset = new();
			InputPosition = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
