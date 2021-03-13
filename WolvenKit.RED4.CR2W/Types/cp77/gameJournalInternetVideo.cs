using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalInternetVideo : gameJournalInternetBase
	{
		[Ordinal(4)] [RED("videoResource")] public raRef<Bink> VideoResource { get; set; }

		public gameJournalInternetVideo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
