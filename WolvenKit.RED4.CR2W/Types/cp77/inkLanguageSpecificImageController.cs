using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLanguageSpecificImageController : inkWidgetLogicController
	{
		private raRef<inkTextureAtlas> _textureAtlasForLanguage;
		private CName _partNameForLanguage;
		private CArray<CEnum<inkLanguageId>> _languages;
		private raRef<inkTextureAtlas> _fallbackTextureAtlas;
		private CName _fallbackPartName;

		[Ordinal(1)] 
		[RED("textureAtlasForLanguage")] 
		public raRef<inkTextureAtlas> TextureAtlasForLanguage
		{
			get => GetProperty(ref _textureAtlasForLanguage);
			set => SetProperty(ref _textureAtlasForLanguage, value);
		}

		[Ordinal(2)] 
		[RED("partNameForLanguage")] 
		public CName PartNameForLanguage
		{
			get => GetProperty(ref _partNameForLanguage);
			set => SetProperty(ref _partNameForLanguage, value);
		}

		[Ordinal(3)] 
		[RED("languages")] 
		public CArray<CEnum<inkLanguageId>> Languages
		{
			get => GetProperty(ref _languages);
			set => SetProperty(ref _languages, value);
		}

		[Ordinal(4)] 
		[RED("fallbackTextureAtlas")] 
		public raRef<inkTextureAtlas> FallbackTextureAtlas
		{
			get => GetProperty(ref _fallbackTextureAtlas);
			set => SetProperty(ref _fallbackTextureAtlas, value);
		}

		[Ordinal(5)] 
		[RED("fallbackPartName")] 
		public CName FallbackPartName
		{
			get => GetProperty(ref _fallbackPartName);
			set => SetProperty(ref _fallbackPartName, value);
		}

		public inkLanguageSpecificImageController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
