
namespace WolvenKit.RED4.Types
{
	public partial class gamedataCharacterRandomizationCategoryUI_Record
	{
		[RED("categoryName")]
		[REDProperty(IsIgnored = true)]
		public CName CategoryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("categoryType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID CategoryType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
