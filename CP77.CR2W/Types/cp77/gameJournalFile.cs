using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalFile : gameJournalEntry
	{
		[Ordinal(1)] [RED("title")] public LocalizationString Title { get; set; }
		[Ordinal(2)] [RED("content")] public LocalizationString Content { get; set; }
		[Ordinal(3)] [RED("videoResource")] public raRef<Bink> VideoResource { get; set; }
		[Ordinal(4)] [RED("PictureFilename(legacy)")] public CString PictureFilename_legacy_ { get; set; }
		[Ordinal(5)] [RED("pictureTweak")] public TweakDBID PictureTweak { get; set; }

		public gameJournalFile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
