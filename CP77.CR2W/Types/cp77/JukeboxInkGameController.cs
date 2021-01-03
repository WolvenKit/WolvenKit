using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class JukeboxInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(0)]  [RED("ActionsPanel")] public inkHorizontalPanelWidgetReference ActionsPanel { get; set; }
		[Ordinal(1)]  [RED("PriceText")] public inkTextWidgetReference PriceText { get; set; }
		[Ordinal(2)]  [RED("isPlaying")] public CBool IsPlaying { get; set; }
		[Ordinal(3)]  [RED("nextButton")] public CHandle<NextPreviousActionWidgetController> NextButton { get; set; }
		[Ordinal(4)]  [RED("playButton")] public CHandle<PlayPauseActionWidgetController> PlayButton { get; set; }
		[Ordinal(5)]  [RED("previousButton")] public CHandle<NextPreviousActionWidgetController> PreviousButton { get; set; }

		public JukeboxInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
