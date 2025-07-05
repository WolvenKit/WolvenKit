using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ApplyStatusEffectBasedOnDifficultyEffector : ApplyStatusEffectEffector
	{
		[Ordinal(8)] 
		[RED("statusEffectOnStoryDifficulty")] 
		public TweakDBID StatusEffectOnStoryDifficulty
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(9)] 
		[RED("statusEffectOnEasyDifficulty")] 
		public TweakDBID StatusEffectOnEasyDifficulty
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(10)] 
		[RED("statusEffectOnHardDifficulty")] 
		public TweakDBID StatusEffectOnHardDifficulty
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(11)] 
		[RED("statusEffectOnVeryHardDifficulty")] 
		public TweakDBID StatusEffectOnVeryHardDifficulty
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public ApplyStatusEffectBasedOnDifficultyEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
