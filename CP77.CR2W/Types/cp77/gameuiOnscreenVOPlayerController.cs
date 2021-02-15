using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiOnscreenVOPlayerController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("subtitlesContainer")] public inkCompoundWidgetReference SubtitlesContainer { get; set; }
		[Ordinal(3)] [RED("subtitlesLibraryResource")] public raRef<inkWidgetLibraryResource> SubtitlesLibraryResource { get; set; }
		[Ordinal(4)] [RED("subtitlesRootName")] public CName SubtitlesRootName { get; set; }
		[Ordinal(5)] [RED("audioVOList")] public CArray<gameuiVOWithDelay> AudioVOList { get; set; }

		public gameuiOnscreenVOPlayerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
