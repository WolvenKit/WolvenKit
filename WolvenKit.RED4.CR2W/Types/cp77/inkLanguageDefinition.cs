using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLanguageDefinition : CVariable
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

		public inkLanguageDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
