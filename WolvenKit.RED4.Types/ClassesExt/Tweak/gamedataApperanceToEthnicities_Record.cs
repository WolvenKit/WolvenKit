
namespace WolvenKit.RED4.Types
{
	public partial class gamedataApperanceToEthnicities_Record
	{
		[RED("appearanceName")]
		[REDProperty(IsIgnored = true)]
		public CName AppearanceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("ethnicities")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Ethnicities
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
