
namespace WolvenKit.RED4.Types
{
	public partial class gamedataItemCategory_Record
	{
		[RED("localizedCategory")]
		[REDProperty(IsIgnored = true)]
		public gamedataLocKeyWrapper LocalizedCategory
		{
			get => GetPropertyValue<gamedataLocKeyWrapper>();
			set => SetPropertyValue<gamedataLocKeyWrapper>(value);
		}
		
		[RED("name")]
		[REDProperty(IsIgnored = true)]
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
