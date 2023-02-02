
namespace WolvenKit.RED4.Types
{
	public partial class gamedataSubStatModifier_Record
	{
		[RED("refObject")]
		[REDProperty(IsIgnored = true)]
		public CName RefObject
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("refStat")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID RefStat
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
