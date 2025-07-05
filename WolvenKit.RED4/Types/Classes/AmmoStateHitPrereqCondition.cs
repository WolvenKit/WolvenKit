using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AmmoStateHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(3)] 
		[RED("valueToListen")] 
		public CEnum<EMagazineAmmoState> ValueToListen
		{
			get => GetPropertyValue<CEnum<EMagazineAmmoState>>();
			set => SetPropertyValue<CEnum<EMagazineAmmoState>>(value);
		}

		[Ordinal(4)] 
		[RED("ratio")] 
		public CFloat Ratio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetPropertyValue<CEnum<EComparisonType>>();
			set => SetPropertyValue<CEnum<EComparisonType>>(value);
		}

		public AmmoStateHitPrereqCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
