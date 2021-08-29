using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatPoolPrereq : gameIScriptablePrereq
	{
		private CEnum<gamedataStatPoolType> _statPoolType;
		private CFloat _valueToCheck;
		private CEnum<EComparisonType> _comparisonType;
		private CBool _skipOnApply;
		private CBool _comparePercentage;

		[Ordinal(0)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetProperty(ref _statPoolType);
			set => SetProperty(ref _statPoolType, value);
		}

		[Ordinal(1)] 
		[RED("valueToCheck")] 
		public CFloat ValueToCheck
		{
			get => GetProperty(ref _valueToCheck);
			set => SetProperty(ref _valueToCheck, value);
		}

		[Ordinal(2)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetProperty(ref _comparisonType);
			set => SetProperty(ref _comparisonType, value);
		}

		[Ordinal(3)] 
		[RED("skipOnApply")] 
		public CBool SkipOnApply
		{
			get => GetProperty(ref _skipOnApply);
			set => SetProperty(ref _skipOnApply, value);
		}

		[Ordinal(4)] 
		[RED("comparePercentage")] 
		public CBool ComparePercentage
		{
			get => GetProperty(ref _comparePercentage);
			set => SetProperty(ref _comparePercentage, value);
		}
	}
}
