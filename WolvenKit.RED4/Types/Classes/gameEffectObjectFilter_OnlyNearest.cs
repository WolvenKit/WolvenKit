using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectObjectFilter_OnlyNearest : gameEffectObjectGroupFilter
	{
		[Ordinal(0)] 
		[RED("count")] 
		public CUInt32 Count
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameEffectObjectFilter_OnlyNearest()
		{
			Count = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
