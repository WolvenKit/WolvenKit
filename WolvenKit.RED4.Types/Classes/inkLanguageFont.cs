using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkLanguageFont : RedBaseClass
	{
		private CResourceAsyncReference<inkFontFamilyResource> _font;
		private CHandle<inkLanguageFontMapper> _mapper;

		[Ordinal(0)] 
		[RED("font")] 
		public CResourceAsyncReference<inkFontFamilyResource> Font
		{
			get => GetProperty(ref _font);
			set => SetProperty(ref _font, value);
		}

		[Ordinal(1)] 
		[RED("mapper")] 
		public CHandle<inkLanguageFontMapper> Mapper
		{
			get => GetProperty(ref _mapper);
			set => SetProperty(ref _mapper, value);
		}
	}
}
