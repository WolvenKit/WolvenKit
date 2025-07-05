using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnVarVsVarComparison_FactConditionTypeParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("factName1")] 
		public CName FactName1
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("factName2")] 
		public CName FactName2
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetPropertyValue<CEnum<EComparisonType>>();
			set => SetPropertyValue<CEnum<EComparisonType>>(value);
		}

		public scnVarVsVarComparison_FactConditionTypeParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
