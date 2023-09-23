using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questMappinGPSComparison_ConditionType : questIDistanceConditionType
	{
		[Ordinal(0)] 
		[RED("distanceDefinition1")] 
		public CHandle<questMappinGPSDistance> DistanceDefinition1
		{
			get => GetPropertyValue<CHandle<questMappinGPSDistance>>();
			set => SetPropertyValue<CHandle<questMappinGPSDistance>>(value);
		}

		[Ordinal(1)] 
		[RED("distanceDefinition2")] 
		public CHandle<questValueDistance> DistanceDefinition2
		{
			get => GetPropertyValue<CHandle<questValueDistance>>();
			set => SetPropertyValue<CHandle<questValueDistance>>(value);
		}

		[Ordinal(2)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetPropertyValue<CEnum<EComparisonType>>();
			set => SetPropertyValue<CEnum<EComparisonType>>(value);
		}

		public questMappinGPSComparison_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
