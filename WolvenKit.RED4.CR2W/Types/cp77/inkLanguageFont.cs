using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLanguageFont : CVariable
	{
		private raRef<inkFontFamilyResource> _font;
		private CHandle<inkLanguageFontMapper> _mapper;

		[Ordinal(0)] 
		[RED("font")] 
		public raRef<inkFontFamilyResource> Font
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

		public inkLanguageFont(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
