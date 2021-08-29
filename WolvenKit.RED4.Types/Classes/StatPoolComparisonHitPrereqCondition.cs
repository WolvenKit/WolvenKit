using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatPoolComparisonHitPrereqCondition : BaseHitPrereqCondition
	{
		private CName _comparisonSource;
		private CName _comparisonTarget;
		private CEnum<EComparisonType> _comparisonType;
		private CEnum<gamedataStatPoolType> _statPoolToCompare;

		[Ordinal(1)] 
		[RED("comparisonSource")] 
		public CName ComparisonSource
		{
			get => GetProperty(ref _comparisonSource);
			set => SetProperty(ref _comparisonSource, value);
		}

		[Ordinal(2)] 
		[RED("comparisonTarget")] 
		public CName ComparisonTarget
		{
			get => GetProperty(ref _comparisonTarget);
			set => SetProperty(ref _comparisonTarget, value);
		}

		[Ordinal(3)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetProperty(ref _comparisonType);
			set => SetProperty(ref _comparisonType, value);
		}

		[Ordinal(4)] 
		[RED("statPoolToCompare")] 
		public CEnum<gamedataStatPoolType> StatPoolToCompare
		{
			get => GetProperty(ref _statPoolToCompare);
			set => SetProperty(ref _statPoolToCompare, value);
		}
	}
}
