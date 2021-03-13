using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalInternetImage : gameJournalInternetBase
	{
		[Ordinal(4)] [RED("textureAtlas")] public raRef<inkTextureAtlas> TextureAtlas { get; set; }
		[Ordinal(5)] [RED("texturePart")] public CName TexturePart { get; set; }

		public gameJournalInternetImage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
