using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameQuestDistanceRequestFilter : gameCustomRequestFilter
	{
		[Ordinal(0)] 
		[RED("distanceSquared")] 
		public CFloat DistanceSquared
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameQuestDistanceRequestFilter()
		{
			DistanceSquared = 1000000.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
