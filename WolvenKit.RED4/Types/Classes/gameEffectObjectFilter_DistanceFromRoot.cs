using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectObjectFilter_DistanceFromRoot : gameEffectObjectGroupFilter
	{
		[Ordinal(0)] 
		[RED("rootZOffset")] 
		public CFloat RootZOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("bonusRange")] 
		public CFloat BonusRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameEffectObjectFilter_DistanceFromRoot()
		{
			RootZOffset = 1.000000F;
			BonusRange = 0.500000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
