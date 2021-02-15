using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkGameSettingsResource : CResource
	{
		[Ordinal(1)] [RED("compositionResource")] public rRef<inkFullscreenCompositionResource> CompositionResource { get; set; }
		[Ordinal(2)] [RED("permanentTextureAtlases")] public CArray<raRef<inkTextureAtlas>> PermanentTextureAtlases { get; set; }
		[Ordinal(3)] [RED("permanentTextureAtlasesPC")] public CArray<raRef<inkTextureAtlas>> PermanentTextureAtlasesPC { get; set; }
		[Ordinal(4)] [RED("permanentTextureAtlasesDurango")] public CArray<raRef<inkTextureAtlas>> PermanentTextureAtlasesDurango { get; set; }
		[Ordinal(5)] [RED("permanentTextureAtlasesOrbis")] public CArray<raRef<inkTextureAtlas>> PermanentTextureAtlasesOrbis { get; set; }
		[Ordinal(6)] [RED("themes")] public CArray<inkStyleThemeDescriptor> Themes { get; set; }

		public inkGameSettingsResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
