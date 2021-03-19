using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCreditsController : gameuiWidgetGameController
	{
		private rRef<inkCreditsResource> _creditsResourcePS4;
		private rRef<inkCreditsResource> _creditsResourceXBOXPC;
		private CFloat _scrollingSpeed;
		private CFloat _fastforwardScrollingSpeed;
		private inkCompoundWidgetReference _sectionsContainer;
		private inkTextWidgetReference _singleTextWidget;
		private inkTextWidgetReference _speakerNameTextWidget;
		private inkCompoundWidgetReference _exitTooltipContainer;
		private CName _swapBackgroundVideoAnimName;
		private CName _singleAnimName;
		private CName _openVideoScreenAnimName;
		private CName _closeVideoScreenAnimName;
		private CName _headerLibraryID;
		private CName _boldLibraryID;
		private CName _basicLibraryID;
		private CFloat _topCreditsMargin;
		private CFloat _bottomCreditsMargin;
		private CFloat _startPosition;
		private inkCompoundWidgetReference _subtitlesContainer;
		private raRef<CResource> _subtitlesLibraryPath;
		private CBool _shouldShowRewardPrompt;
		private CBool _isInFinalBoardsMode;
		private CFloat _exitNotificationDisplayTime;

		[Ordinal(2)] 
		[RED("creditsResourcePS4")] 
		public rRef<inkCreditsResource> CreditsResourcePS4
		{
			get => GetProperty(ref _creditsResourcePS4);
			set => SetProperty(ref _creditsResourcePS4, value);
		}

		[Ordinal(3)] 
		[RED("creditsResourceXBOXPC")] 
		public rRef<inkCreditsResource> CreditsResourceXBOXPC
		{
			get => GetProperty(ref _creditsResourceXBOXPC);
			set => SetProperty(ref _creditsResourceXBOXPC, value);
		}

		[Ordinal(4)] 
		[RED("scrollingSpeed")] 
		public CFloat ScrollingSpeed
		{
			get => GetProperty(ref _scrollingSpeed);
			set => SetProperty(ref _scrollingSpeed, value);
		}

		[Ordinal(5)] 
		[RED("fastforwardScrollingSpeed")] 
		public CFloat FastforwardScrollingSpeed
		{
			get => GetProperty(ref _fastforwardScrollingSpeed);
			set => SetProperty(ref _fastforwardScrollingSpeed, value);
		}

		[Ordinal(6)] 
		[RED("sectionsContainer")] 
		public inkCompoundWidgetReference SectionsContainer
		{
			get => GetProperty(ref _sectionsContainer);
			set => SetProperty(ref _sectionsContainer, value);
		}

		[Ordinal(7)] 
		[RED("singleTextWidget")] 
		public inkTextWidgetReference SingleTextWidget
		{
			get => GetProperty(ref _singleTextWidget);
			set => SetProperty(ref _singleTextWidget, value);
		}

		[Ordinal(8)] 
		[RED("speakerNameTextWidget")] 
		public inkTextWidgetReference SpeakerNameTextWidget
		{
			get => GetProperty(ref _speakerNameTextWidget);
			set => SetProperty(ref _speakerNameTextWidget, value);
		}

		[Ordinal(9)] 
		[RED("exitTooltipContainer")] 
		public inkCompoundWidgetReference ExitTooltipContainer
		{
			get => GetProperty(ref _exitTooltipContainer);
			set => SetProperty(ref _exitTooltipContainer, value);
		}

		[Ordinal(10)] 
		[RED("swapBackgroundVideoAnimName")] 
		public CName SwapBackgroundVideoAnimName
		{
			get => GetProperty(ref _swapBackgroundVideoAnimName);
			set => SetProperty(ref _swapBackgroundVideoAnimName, value);
		}

		[Ordinal(11)] 
		[RED("singleAnimName")] 
		public CName SingleAnimName
		{
			get => GetProperty(ref _singleAnimName);
			set => SetProperty(ref _singleAnimName, value);
		}

		[Ordinal(12)] 
		[RED("openVideoScreenAnimName")] 
		public CName OpenVideoScreenAnimName
		{
			get => GetProperty(ref _openVideoScreenAnimName);
			set => SetProperty(ref _openVideoScreenAnimName, value);
		}

		[Ordinal(13)] 
		[RED("closeVideoScreenAnimName")] 
		public CName CloseVideoScreenAnimName
		{
			get => GetProperty(ref _closeVideoScreenAnimName);
			set => SetProperty(ref _closeVideoScreenAnimName, value);
		}

		[Ordinal(14)] 
		[RED("headerLibraryID")] 
		public CName HeaderLibraryID
		{
			get => GetProperty(ref _headerLibraryID);
			set => SetProperty(ref _headerLibraryID, value);
		}

		[Ordinal(15)] 
		[RED("boldLibraryID")] 
		public CName BoldLibraryID
		{
			get => GetProperty(ref _boldLibraryID);
			set => SetProperty(ref _boldLibraryID, value);
		}

		[Ordinal(16)] 
		[RED("basicLibraryID")] 
		public CName BasicLibraryID
		{
			get => GetProperty(ref _basicLibraryID);
			set => SetProperty(ref _basicLibraryID, value);
		}

		[Ordinal(17)] 
		[RED("topCreditsMargin")] 
		public CFloat TopCreditsMargin
		{
			get => GetProperty(ref _topCreditsMargin);
			set => SetProperty(ref _topCreditsMargin, value);
		}

		[Ordinal(18)] 
		[RED("bottomCreditsMargin")] 
		public CFloat BottomCreditsMargin
		{
			get => GetProperty(ref _bottomCreditsMargin);
			set => SetProperty(ref _bottomCreditsMargin, value);
		}

		[Ordinal(19)] 
		[RED("startPosition")] 
		public CFloat StartPosition
		{
			get => GetProperty(ref _startPosition);
			set => SetProperty(ref _startPosition, value);
		}

		[Ordinal(20)] 
		[RED("subtitlesContainer")] 
		public inkCompoundWidgetReference SubtitlesContainer
		{
			get => GetProperty(ref _subtitlesContainer);
			set => SetProperty(ref _subtitlesContainer, value);
		}

		[Ordinal(21)] 
		[RED("subtitlesLibraryPath")] 
		public raRef<CResource> SubtitlesLibraryPath
		{
			get => GetProperty(ref _subtitlesLibraryPath);
			set => SetProperty(ref _subtitlesLibraryPath, value);
		}

		[Ordinal(22)] 
		[RED("shouldShowRewardPrompt")] 
		public CBool ShouldShowRewardPrompt
		{
			get => GetProperty(ref _shouldShowRewardPrompt);
			set => SetProperty(ref _shouldShowRewardPrompt, value);
		}

		[Ordinal(23)] 
		[RED("isInFinalBoardsMode")] 
		public CBool IsInFinalBoardsMode
		{
			get => GetProperty(ref _isInFinalBoardsMode);
			set => SetProperty(ref _isInFinalBoardsMode, value);
		}

		[Ordinal(24)] 
		[RED("exitNotificationDisplayTime")] 
		public CFloat ExitNotificationDisplayTime
		{
			get => GetProperty(ref _exitNotificationDisplayTime);
			set => SetProperty(ref _exitNotificationDisplayTime, value);
		}

		public gameuiCreditsController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
