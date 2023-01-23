
namespace WolvenKit.RED4.Types
{
	public partial class gamedataStatModifier_Record
	{
		[RED("modifierType")]
		[REDProperty(IsIgnored = true)]
		public CName ModifierType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("statType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StatType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
