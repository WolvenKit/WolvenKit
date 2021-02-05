using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalInternetSite : gameJournalFileEntry
	{
		[Ordinal(0)]  [RED("shortName")] public LocalizationString ShortName { get; set; }
		[Ordinal(1)]  [RED("mainPagePath")] public CHandle<gameJournalPath> MainPagePath { get; set; }
		[Ordinal(2)]  [RED("ignoredAtDesktop")] public CBool IgnoredAtDesktop { get; set; }
		[Ordinal(3)]  [RED("textureAtlas")] public raRef<inkTextureAtlas> TextureAtlas { get; set; }
		[Ordinal(4)]  [RED("texturePart")] public CName TexturePart { get; set; }

		public gameJournalInternetSite(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
