using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatPoolPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetPropertyValue<CEnum<gamedataStatPoolType>>();
			set => SetPropertyValue<CEnum<gamedataStatPoolType>>(value);
		}

		[Ordinal(1)] 
		[RED("valueToCheck")] 
		public CFloat ValueToCheck
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetPropertyValue<CEnum<EComparisonType>>();
			set => SetPropertyValue<CEnum<EComparisonType>>(value);
		}

		[Ordinal(3)] 
		[RED("skipOnApply")] 
		public CBool SkipOnApply
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("comparePercentage")] 
		public CBool ComparePercentage
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
