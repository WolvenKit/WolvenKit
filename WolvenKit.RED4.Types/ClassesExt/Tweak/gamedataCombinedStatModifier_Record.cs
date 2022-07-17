
namespace WolvenKit.RED4.Types
{
	public partial class gamedataCombinedStatModifier_Record
	{
		[RED("opSymbol")]
		[REDProperty(IsIgnored = true)]
		public CName OpSymbol
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
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
		
		[RED("value")]
		[REDProperty(IsIgnored = true)]
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
