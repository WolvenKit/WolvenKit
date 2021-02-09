using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class JukeboxInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(14)]  [RED("ActionsPanel")] public inkHorizontalPanelWidgetReference ActionsPanel { get; set; }
		[Ordinal(15)]  [RED("PriceText")] public inkTextWidgetReference PriceText { get; set; }
		[Ordinal(16)]  [RED("playButton")] public CHandle<PlayPauseActionWidgetController> PlayButton { get; set; }
		[Ordinal(17)]  [RED("nextButton")] public CHandle<NextPreviousActionWidgetController> NextButton { get; set; }
		[Ordinal(18)]  [RED("previousButton")] public CHandle<NextPreviousActionWidgetController> PreviousButton { get; set; }
		[Ordinal(19)]  [RED("isPlaying")] public CBool IsPlaying { get; set; }

		public JukeboxInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
