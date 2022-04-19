using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GameplayStatCondition : GameplayConditionBase
	{
		[Ordinal(1)] 
		[RED("statToCheck")] 
		public TweakDBID StatToCheck
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("stat")] 
		public CEnum<EDeviceChallengeAttribute> Stat
		{
			get => GetPropertyValue<CEnum<EDeviceChallengeAttribute>>();
			set => SetPropertyValue<CEnum<EDeviceChallengeAttribute>>(value);
		}

		[Ordinal(3)] 
		[RED("difficulty")] 
		public CEnum<EGameplayChallengeLevel> Difficulty
		{
			get => GetPropertyValue<CEnum<EGameplayChallengeLevel>>();
			set => SetPropertyValue<CEnum<EGameplayChallengeLevel>>(value);
		}

		public GameplayStatCondition()
		{
			EntityID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
