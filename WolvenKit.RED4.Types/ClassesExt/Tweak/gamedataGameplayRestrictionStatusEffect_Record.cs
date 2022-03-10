
namespace WolvenKit.RED4.Types
{
	public partial class gamedataGameplayRestrictionStatusEffect_Record
	{
		[RED("actionRestriction")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ActionRestriction
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("restrictionName")]
		[REDProperty(IsIgnored = true)]
		public CName RestrictionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
