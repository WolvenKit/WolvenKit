using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatPoolHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(1)] 
		[RED("valueToCheck")] 
		public CFloat ValueToCheck
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("objectToCheck")] 
		public CName ObjectToCheck
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetPropertyValue<CEnum<EComparisonType>>();
			set => SetPropertyValue<CEnum<EComparisonType>>(value);
		}

		[Ordinal(4)] 
		[RED("statPoolToCompare")] 
		public CEnum<gamedataStatPoolType> StatPoolToCompare
		{
			get => GetPropertyValue<CEnum<gamedataStatPoolType>>();
			set => SetPropertyValue<CEnum<gamedataStatPoolType>>(value);
		}
	}
}
