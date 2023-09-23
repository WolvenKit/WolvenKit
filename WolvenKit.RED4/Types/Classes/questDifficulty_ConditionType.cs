using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questDifficulty_ConditionType : questIStatsConditionType
	{
		[Ordinal(1)] 
		[RED("difficulty")] 
		public CEnum<gameDifficulty> Difficulty
		{
			get => GetPropertyValue<CEnum<gameDifficulty>>();
			set => SetPropertyValue<CEnum<gameDifficulty>>(value);
		}

		public questDifficulty_ConditionType()
		{
			Difficulty = Enums.gameDifficulty.Story;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
