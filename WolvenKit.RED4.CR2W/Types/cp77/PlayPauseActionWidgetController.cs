using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayPauseActionWidgetController : NextPreviousActionWidgetController
	{
		[Ordinal(32)] [RED("playContainer")] public inkWidgetReference PlayContainer { get; set; }
		[Ordinal(33)] [RED("isPlaying")] public CBool IsPlaying { get; set; }

		public PlayPauseActionWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
