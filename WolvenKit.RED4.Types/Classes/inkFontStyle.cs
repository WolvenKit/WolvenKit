using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkFontStyle : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("styleName")] 
		public CName StyleName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("font")] 
		public CResourceReference<rendFont> Font
		{
			get => GetPropertyValue<CResourceReference<rendFont>>();
			set => SetPropertyValue<CResourceReference<rendFont>>(value);
		}
	}
}
