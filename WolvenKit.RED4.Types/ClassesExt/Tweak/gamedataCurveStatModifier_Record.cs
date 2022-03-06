
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
		
		[RED("id")]
		[REDProperty(IsIgnored = true)]
		public CString Id
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("modifierType")]
		[REDProperty(IsIgnored = true)]
		public CName ModifierType
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
		
		[RED("statType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StatType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
