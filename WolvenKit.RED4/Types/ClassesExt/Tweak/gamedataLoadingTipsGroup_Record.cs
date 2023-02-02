
namespace WolvenKit.RED4.Types
{
	public partial class gamedataLoadingTipsGroup_Record
	{
		[RED("hintLocalizationKeys")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> HintLocalizationKeys
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("unlockingFact")]
		[REDProperty(IsIgnored = true)]
		public CName UnlockingFact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
