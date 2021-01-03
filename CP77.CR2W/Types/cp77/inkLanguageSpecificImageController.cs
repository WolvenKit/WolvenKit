using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkLanguageSpecificImageController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("fallbackPartName")] public CName FallbackPartName { get; set; }
		[Ordinal(1)]  [RED("fallbackTextureAtlas")] public raRef<inkTextureAtlas> FallbackTextureAtlas { get; set; }
		[Ordinal(2)]  [RED("languages")] public CArray<CEnum<inkLanguageId>> Languages { get; set; }
		[Ordinal(3)]  [RED("partNameForLanguage")] public CName PartNameForLanguage { get; set; }
		[Ordinal(4)]  [RED("textureAtlasForLanguage")] public raRef<inkTextureAtlas> TextureAtlasForLanguage { get; set; }

		public inkLanguageSpecificImageController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
