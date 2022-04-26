using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GameplaySkillCondition : GameplayConditionBase
	{
		[Ordinal(1)] 
		[RED("skillToCheck")] 
		public TweakDBID SkillToCheck
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("difficulty")] 
		public CEnum<EGameplayChallengeLevel> Difficulty
		{
			get => GetPropertyValue<CEnum<EGameplayChallengeLevel>>();
			set => SetPropertyValue<CEnum<EGameplayChallengeLevel>>(value);
		}

		[Ordinal(3)] 
		[RED("skillBonus")] 
		public TweakDBID SkillBonus
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public GameplaySkillCondition()
		{
			EntityID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
