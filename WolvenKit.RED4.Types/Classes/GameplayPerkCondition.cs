using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameplayPerkCondition : GameplayConditionBase
	{
		private TweakDBID _perkToCheck;
		private CEnum<EGameplayChallengeLevel> _difficulty;

		[Ordinal(1)] 
		[RED("perkToCheck")] 
		public TweakDBID PerkToCheck
		{
			get => GetProperty(ref _perkToCheck);
			set => SetProperty(ref _perkToCheck, value);
		}

		[Ordinal(2)] 
		[RED("difficulty")] 
		public CEnum<EGameplayChallengeLevel> Difficulty
		{
			get => GetProperty(ref _difficulty);
			set => SetProperty(ref _difficulty, value);
		}
	}
}
