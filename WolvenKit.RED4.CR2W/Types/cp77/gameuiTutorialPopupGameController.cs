using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiTutorialPopupGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("actionHint")] public inkWidgetReference ActionHint { get; set; }
		[Ordinal(3)] [RED("popupPanel")] public inkWidgetReference PopupPanel { get; set; }
		[Ordinal(4)] [RED("popupFullscreenPanel")] public inkWidgetReference PopupFullscreenPanel { get; set; }
		[Ordinal(5)] [RED("popupBlockingPanel")] public inkWidgetReference PopupBlockingPanel { get; set; }
		[Ordinal(6)] [RED("popupFullscreenRightPanel")] public inkWidgetReference PopupFullscreenRightPanel { get; set; }
		[Ordinal(7)] [RED("data")] public wCHandle<TutorialPopupData> Data { get; set; }
		[Ordinal(8)] [RED("inputBlocked")] public CBool InputBlocked { get; set; }
		[Ordinal(9)] [RED("gamePaused")] public CBool GamePaused { get; set; }
		[Ordinal(10)] [RED("isShownBbId")] public CUInt32 IsShownBbId { get; set; }
		[Ordinal(11)] [RED("animIntroPopup")] public CName AnimIntroPopup { get; set; }
		[Ordinal(12)] [RED("animIntroPopupModal")] public CName AnimIntroPopupModal { get; set; }
		[Ordinal(13)] [RED("animIntroFullscreenLeft")] public CName AnimIntroFullscreenLeft { get; set; }
		[Ordinal(14)] [RED("animIntroFullscreenRight")] public CName AnimIntroFullscreenRight { get; set; }
		[Ordinal(15)] [RED("animOutroPopup")] public CName AnimOutroPopup { get; set; }
		[Ordinal(16)] [RED("animOutroPopupModal")] public CName AnimOutroPopupModal { get; set; }
		[Ordinal(17)] [RED("animOutroFullscreenLeft")] public CName AnimOutroFullscreenLeft { get; set; }
		[Ordinal(18)] [RED("animOutroFullscreenRight")] public CName AnimOutroFullscreenRight { get; set; }
		[Ordinal(19)] [RED("animIntro")] public CName AnimIntro { get; set; }
		[Ordinal(20)] [RED("animOutro")] public CName AnimOutro { get; set; }
		[Ordinal(21)] [RED("targetPopup")] public inkWidgetReference TargetPopup { get; set; }
		[Ordinal(22)] [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }

		public gameuiTutorialPopupGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
