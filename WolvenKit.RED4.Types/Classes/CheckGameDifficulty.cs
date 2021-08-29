using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckGameDifficulty : AIbehaviorconditionScript
	{
		private CEnum<gameDifficulty> _comparedDifficulty;
		private CEnum<EComparisonOperator> _comparisonOperator;
		private CEnum<gameDifficulty> _currentDifficulty;
		private CInt32 _currentDifficultyValue;
		private CInt32 _comparedDifficultyValue;

		[Ordinal(0)] 
		[RED("comparedDifficulty")] 
		public CEnum<gameDifficulty> ComparedDifficulty
		{
			get => GetProperty(ref _comparedDifficulty);
			set => SetProperty(ref _comparedDifficulty, value);
		}

		[Ordinal(1)] 
		[RED("comparisonOperator")] 
		public CEnum<EComparisonOperator> ComparisonOperator
		{
			get => GetProperty(ref _comparisonOperator);
			set => SetProperty(ref _comparisonOperator, value);
		}

		[Ordinal(2)] 
		[RED("currentDifficulty")] 
		public CEnum<gameDifficulty> CurrentDifficulty
		{
			get => GetProperty(ref _currentDifficulty);
			set => SetProperty(ref _currentDifficulty, value);
		}

		[Ordinal(3)] 
		[RED("currentDifficultyValue")] 
		public CInt32 CurrentDifficultyValue
		{
			get => GetProperty(ref _currentDifficultyValue);
			set => SetProperty(ref _currentDifficultyValue, value);
		}

		[Ordinal(4)] 
		[RED("comparedDifficultyValue")] 
		public CInt32 ComparedDifficultyValue
		{
			get => GetProperty(ref _comparedDifficultyValue);
			set => SetProperty(ref _comparedDifficultyValue, value);
		}
	}
}
