using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayPauseActionWidgetController : NextPreviousActionWidgetController
	{
		[Ordinal(0)]  [RED("isPlaying")] public CBool IsPlaying { get; set; }
		[Ordinal(1)]  [RED("playContainer")] public inkWidgetReference PlayContainer { get; set; }

		public PlayPauseActionWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
