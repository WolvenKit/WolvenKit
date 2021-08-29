using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkLanguageDefinition : RedBaseClass
	{
		private CName _languageCode;
		private CName _isoScriptCode;
		private CEnum<inkETextDirection> _textDirection;
		private CArray<inkLanguageFont> _fonts;

		[Ordinal(0)] 
		[RED("languageCode")] 
		public CName LanguageCode
		{
			get => GetProperty(ref _languageCode);
			set => SetProperty(ref _languageCode, value);
		}

		[Ordinal(1)] 
		[RED("isoScriptCode")] 
		public CName IsoScriptCode
		{
			get => GetProperty(ref _isoScriptCode);
			set => SetProperty(ref _isoScriptCode, value);
		}

		[Ordinal(2)] 
		[RED("textDirection")] 
		public CEnum<inkETextDirection> TextDirection
		{
			get => GetProperty(ref _textDirection);
			set => SetProperty(ref _textDirection, value);
		}

		[Ordinal(3)] 
		[RED("fonts")] 
		public CArray<inkLanguageFont> Fonts
		{
			get => GetProperty(ref _fonts);
			set => SetProperty(ref _fonts, value);
		}
	}
}
