
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPhotoModePoseCategory_Record
	{
		[RED("categoryName")]
		[REDProperty(IsIgnored = true)]
		public CName CategoryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("displayName")]
		[REDProperty(IsIgnored = true)]
		public CName DisplayName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
