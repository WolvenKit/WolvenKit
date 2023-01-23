using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectObjectFilter_OnlyNearestMelee : gameEffectObjectGroupFilter
	{
		[Ordinal(0)] 
		[RED("count")] 
		public CUInt32 Count
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameEffectObjectFilter_OnlyNearestMelee()
		{
			Count = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
