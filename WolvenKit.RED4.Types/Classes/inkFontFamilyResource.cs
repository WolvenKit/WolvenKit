using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkFontFamilyResource : CResource
	{
		[Ordinal(1)] 
		[RED("familyName")] 
		public CName FamilyName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("fontStyles")] 
		public CArray<inkFontStyle> FontStyles
		{
			get => GetPropertyValue<CArray<inkFontStyle>>();
			set => SetPropertyValue<CArray<inkFontStyle>>(value);
		}

		public inkFontFamilyResource()
		{
			FontStyles = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
