using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnCheckIntScenarioActiveReturnConditionParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("intScenarioName")] 
		public CName IntScenarioName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CUInt32 Value
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetPropertyValue<CEnum<EComparisonType>>();
			set => SetPropertyValue<CEnum<EComparisonType>>(value);
		}
	}
}
