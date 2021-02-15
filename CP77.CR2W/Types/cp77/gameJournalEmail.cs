using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalEmail : gameJournalEntry
	{
		[Ordinal(1)] [RED("sender")] public LocalizationString Sender { get; set; }
		[Ordinal(2)] [RED("addressee")] public LocalizationString Addressee { get; set; }
		[Ordinal(3)] [RED("title")] public LocalizationString Title { get; set; }
		[Ordinal(4)] [RED("content")] public LocalizationString Content { get; set; }
		[Ordinal(5)] [RED("videoResource")] public raRef<Bink> VideoResource { get; set; }
		[Ordinal(6)] [RED("pictureTweak")] public TweakDBID PictureTweak { get; set; }

		public gameJournalEmail(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
