
namespace WolvenKit.RED4.Types
{
	public partial class gamedataApplyStatusEffectBasedOnDifficultyEffector_Record
	{
		[RED("statusEffectOnEasyDifficulty")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StatusEffectOnEasyDifficulty
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("statusEffectOnHardDifficulty")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StatusEffectOnHardDifficulty
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("statusEffectOnStoryDifficulty")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StatusEffectOnStoryDifficulty
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("statusEffectOnVeryHardDifficulty")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StatusEffectOnVeryHardDifficulty
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
