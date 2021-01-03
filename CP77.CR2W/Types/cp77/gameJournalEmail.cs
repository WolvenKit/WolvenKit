using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameJournalEmail : gameJournalEntry
	{
		[Ordinal(0)]  [RED("addressee")] public LocalizationString Addressee { get; set; }
		[Ordinal(1)]  [RED("content")] public LocalizationString Content { get; set; }
		[Ordinal(2)]  [RED("pictureTweak")] public TweakDBID PictureTweak { get; set; }
		[Ordinal(3)]  [RED("sender")] public LocalizationString Sender { get; set; }
		[Ordinal(4)]  [RED("title")] public LocalizationString Title { get; set; }
		[Ordinal(5)]  [RED("videoResource")] public raRef<Bink> VideoResource { get; set; }

		public gameJournalEmail(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
