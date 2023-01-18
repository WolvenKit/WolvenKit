using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CheckGameDifficulty : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("comparedDifficulty")] 
		public CEnum<gameDifficulty> ComparedDifficulty
		{
			get => GetPropertyValue<CEnum<gameDifficulty>>();
			set => SetPropertyValue<CEnum<gameDifficulty>>(value);
		}

		[Ordinal(1)] 
		[RED("comparisonOperator")] 
		public CEnum<EComparisonOperator> ComparisonOperator
		{
			get => GetPropertyValue<CEnum<EComparisonOperator>>();
			set => SetPropertyValue<CEnum<EComparisonOperator>>(value);
		}

		[Ordinal(2)] 
		[RED("currentDifficulty")] 
		public CEnum<gameDifficulty> CurrentDifficulty
		{
			get => GetPropertyValue<CEnum<gameDifficulty>>();
			set => SetPropertyValue<CEnum<gameDifficulty>>(value);
		}

		[Ordinal(3)] 
		[RED("currentDifficultyValue")] 
		public CInt32 CurrentDifficultyValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("comparedDifficultyValue")] 
		public CInt32 ComparedDifficultyValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public CheckGameDifficulty()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
