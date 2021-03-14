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
			get
			{
				if (_textureAtlasForLanguage == null)
				{
					_textureAtlasForLanguage = (raRef<inkTextureAtlas>) CR2WTypeManager.Create("raRef:inkTextureAtlas", "textureAtlasForLanguage", cr2w, this);
				}
				return _textureAtlasForLanguage;
			}
			set
			{
				if (_textureAtlasForLanguage == value)
				{
					return;
				}
				_textureAtlasForLanguage = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("partNameForLanguage")] 
		public CName PartNameForLanguage
		{
			get
			{
				if (_partNameForLanguage == null)
				{
					_partNameForLanguage = (CName) CR2WTypeManager.Create("CName", "partNameForLanguage", cr2w, this);
				}
				return _partNameForLanguage;
			}
			set
			{
				if (_partNameForLanguage == value)
				{
					return;
				}
				_partNameForLanguage = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("languages")] 
		public CArray<CEnum<inkLanguageId>> Languages
		{
			get
			{
				if (_languages == null)
				{
					_languages = (CArray<CEnum<inkLanguageId>>) CR2WTypeManager.Create("array:inkLanguageId", "languages", cr2w, this);
				}
				return _languages;
			}
			set
			{
				if (_languages == value)
				{
					return;
				}
				_languages = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("fallbackTextureAtlas")] 
		public raRef<inkTextureAtlas> FallbackTextureAtlas
		{
			get
			{
				if (_fallbackTextureAtlas == null)
				{
					_fallbackTextureAtlas = (raRef<inkTextureAtlas>) CR2WTypeManager.Create("raRef:inkTextureAtlas", "fallbackTextureAtlas", cr2w, this);
				}
				return _fallbackTextureAtlas;
			}
			set
			{
				if (_fallbackTextureAtlas == value)
				{
					return;
				}
				_fallbackTextureAtlas = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("fallbackPartName")] 
		public CName FallbackPartName
		{
			get
			{
				if (_fallbackPartName == null)
				{
					_fallbackPartName = (CName) CR2WTypeManager.Create("CName", "fallbackPartName", cr2w, this);
				}
				return _fallbackPartName;
			}
			set
			{
				if (_fallbackPartName == value)
				{
					return;
				}
				_fallbackPartName = value;
				PropertySet(this);
			}
		}

		public inkLanguageSpecificImageController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
