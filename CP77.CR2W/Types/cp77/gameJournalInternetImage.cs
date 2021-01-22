using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalInternetImage : gameJournalInternetBase
	{
		[Ordinal(0)]  [RED("textureAtlas")] public raRef<inkTextureAtlas> TextureAtlas { get; set; }
		[Ordinal(1)]  [RED("texturePart")] public CName TexturePart { get; set; }

		public gameJournalInternetImage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
