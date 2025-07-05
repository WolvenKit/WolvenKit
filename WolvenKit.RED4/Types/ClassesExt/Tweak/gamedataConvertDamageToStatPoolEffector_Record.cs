
namespace WolvenKit.RED4.Types
{
	public partial class gamedataConvertDamageToStatPoolEffector_Record
	{
		[RED("opSymbol")]
		[REDProperty(IsIgnored = true)]
		public CName OpSymbol
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("statPoolType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StatPoolType
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
