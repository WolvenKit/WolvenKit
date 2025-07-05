
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIStatusEffectCond_Record
	{
		[RED("gameplayTag")]
		[REDProperty(IsIgnored = true)]
		public CName GameplayTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("statusEffect")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StatusEffect
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("statusEffectType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StatusEffectType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("target")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Target
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
