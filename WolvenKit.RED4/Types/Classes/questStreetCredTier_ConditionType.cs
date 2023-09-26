using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questStreetCredTier_ConditionType : questIStatsConditionType
	{
		[Ordinal(1)] 
		[RED("tierID")] 
		public TweakDBID TierID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetPropertyValue<CEnum<EComparisonType>>();
			set => SetPropertyValue<CEnum<EComparisonType>>(value);
		}

		public questStreetCredTier_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
