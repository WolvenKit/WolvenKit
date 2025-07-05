using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questVarVsVarComparison_ConditionType : questIFactsDBConditionType
	{
		[Ordinal(0)] 
		[RED("factName1")] 
		public CString FactName1
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("factName2")] 
		public CString FactName2
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetPropertyValue<CEnum<EComparisonType>>();
			set => SetPropertyValue<CEnum<EComparisonType>>(value);
		}

		public questVarVsVarComparison_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
