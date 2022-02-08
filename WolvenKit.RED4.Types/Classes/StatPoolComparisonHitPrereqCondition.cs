using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatPoolComparisonHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(1)] 
		[RED("comparisonSource")] 
		public CName ComparisonSource
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("comparisonTarget")] 
		public CName ComparisonTarget
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
