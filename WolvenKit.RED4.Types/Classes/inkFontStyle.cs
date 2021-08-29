using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkFontStyle : RedBaseClass
	{
		private CName _styleName;
		private CResourceReference<rendFont> _font;

		[Ordinal(0)] 
		[RED("styleName")] 
		public CName StyleName
		{
			get => GetProperty(ref _styleName);
			set => SetProperty(ref _styleName, value);
		}

		[Ordinal(1)] 
		[RED("font")] 
		public CResourceReference<rendFont> Font
		{
			get => GetProperty(ref _font);
			set => SetProperty(ref _font, value);
		}
	}
}
