using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectObjectProvider_SweepOverTime : gameEffectObjectProvider
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
	}
}
