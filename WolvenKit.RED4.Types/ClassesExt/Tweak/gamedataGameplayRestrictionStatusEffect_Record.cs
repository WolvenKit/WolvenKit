
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
	}
}
