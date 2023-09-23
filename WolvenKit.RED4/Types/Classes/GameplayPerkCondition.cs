using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GameplayPerkCondition : GameplayConditionBase
	{
		[Ordinal(1)] 
		[RED("perkToCheck")] 
		public TweakDBID PerkToCheck
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

		public GameplayPerkCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
