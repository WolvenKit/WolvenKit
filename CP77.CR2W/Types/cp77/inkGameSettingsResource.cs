using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkGameSettingsResource : CResource
	{
		[Ordinal(0)]  [RED("compositionResource")] public rRef<inkFullscreenCompositionResource> CompositionResource { get; set; }
		[Ordinal(1)]  [RED("permanentTextureAtlases")] public CArray<raRef<inkTextureAtlas>> PermanentTextureAtlases { get; set; }
		[Ordinal(2)]  [RED("permanentTextureAtlasesDurango")] public CArray<raRef<inkTextureAtlas>> PermanentTextureAtlasesDurango { get; set; }
		[Ordinal(3)]  [RED("permanentTextureAtlasesOrbis")] public CArray<raRef<inkTextureAtlas>> PermanentTextureAtlasesOrbis { get; set; }
		[Ordinal(4)]  [RED("permanentTextureAtlasesPC")] public CArray<raRef<inkTextureAtlas>> PermanentTextureAtlasesPC { get; set; }
		[Ordinal(5)]  [RED("themes")] public CArray<inkStyleThemeDescriptor> Themes { get; set; }

		public inkGameSettingsResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
