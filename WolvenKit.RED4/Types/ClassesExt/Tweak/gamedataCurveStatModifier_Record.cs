
namespace WolvenKit.RED4.Types
{
	public partial class gamedataCurveStatModifier_Record
	{
		[RED("column")]
		[REDProperty(IsIgnored = true)]
		public CString Column
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("heightToEnterFall")]
		[REDProperty(IsIgnored = true)]
		public gamedataLocKeyWrapper HeightToEnterFall
		{
			get => GetPropertyValue<gamedataLocKeyWrapper>();
			set => SetPropertyValue<gamedataLocKeyWrapper>(value);
		}
		
		[RED("id")]
		[REDProperty(IsIgnored = true)]
		public CString Id
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
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
	}
}
