using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiCreditsController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("creditsResourcePS4")] public rRef<inkCreditsResource> CreditsResourcePS4 { get; set; }
		[Ordinal(3)] [RED("creditsResourceXBOXPC")] public rRef<inkCreditsResource> CreditsResourceXBOXPC { get; set; }
		[Ordinal(4)] [RED("scrollingSpeed")] public CFloat ScrollingSpeed { get; set; }
		[Ordinal(5)] [RED("fastforwardScrollingSpeed")] public CFloat FastforwardScrollingSpeed { get; set; }
		[Ordinal(6)] [RED("sectionsContainer")] public inkCompoundWidgetReference SectionsContainer { get; set; }
		[Ordinal(7)] [RED("singleTextWidget")] public inkTextWidgetReference SingleTextWidget { get; set; }
		[Ordinal(8)] [RED("speakerNameTextWidget")] public inkTextWidgetReference SpeakerNameTextWidget { get; set; }
		[Ordinal(9)] [RED("exitTooltipContainer")] public inkCompoundWidgetReference ExitTooltipContainer { get; set; }
		[Ordinal(10)] [RED("swapBackgroundVideoAnimName")] public CName SwapBackgroundVideoAnimName { get; set; }
		[Ordinal(11)] [RED("singleAnimName")] public CName SingleAnimName { get; set; }
		[Ordinal(12)] [RED("openVideoScreenAnimName")] public CName OpenVideoScreenAnimName { get; set; }
		[Ordinal(13)] [RED("closeVideoScreenAnimName")] public CName CloseVideoScreenAnimName { get; set; }
		[Ordinal(14)] [RED("headerLibraryID")] public CName HeaderLibraryID { get; set; }
		[Ordinal(15)] [RED("boldLibraryID")] public CName BoldLibraryID { get; set; }
		[Ordinal(16)] [RED("basicLibraryID")] public CName BasicLibraryID { get; set; }
		[Ordinal(17)] [RED("topCreditsMargin")] public CFloat TopCreditsMargin { get; set; }
		[Ordinal(18)] [RED("bottomCreditsMargin")] public CFloat BottomCreditsMargin { get; set; }
		[Ordinal(19)] [RED("startPosition")] public CFloat StartPosition { get; set; }
		[Ordinal(20)] [RED("subtitlesContainer")] public inkCompoundWidgetReference SubtitlesContainer { get; set; }
		[Ordinal(21)] [RED("subtitlesLibraryPath")] public raRef<CResource> SubtitlesLibraryPath { get; set; }
		[Ordinal(22)] [RED("shouldShowRewardPrompt")] public CBool ShouldShowRewardPrompt { get; set; }
		[Ordinal(23)] [RED("isInFinalBoardsMode")] public CBool IsInFinalBoardsMode { get; set; }
		[Ordinal(24)] [RED("exitNotificationDisplayTime")] public CFloat ExitNotificationDisplayTime { get; set; }

		public gameuiCreditsController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
