using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameJournalInternetVideo : gameJournalInternetBase
	{
		[Ordinal(0)]  [RED("videoResource")] public raRef<Bink> VideoResource { get; set; }

		public gameJournalInternetVideo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
