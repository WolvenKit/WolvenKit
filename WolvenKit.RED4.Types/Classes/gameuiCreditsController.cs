using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCreditsController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("creditsResourcePS4")] 
		public CResourceReference<inkCreditsResource> CreditsResourcePS4
		{
			get => GetPropertyValue<CResourceReference<inkCreditsResource>>();
			set => SetPropertyValue<CResourceReference<inkCreditsResource>>(value);
		}

		[Ordinal(3)] 
		[RED("creditsResourceXBOXPC")] 
		public CResourceReference<inkCreditsResource> CreditsResourceXBOXPC
		{
			get => GetPropertyValue<CResourceReference<inkCreditsResource>>();
			set => SetPropertyValue<CResourceReference<inkCreditsResource>>(value);
		}

		[Ordinal(4)] 
		[RED("scrollingSpeed")] 
		public CFloat ScrollingSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("fastforwardScrollingSpeed")] 
		public CFloat FastforwardScrollingSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("sectionsContainer")] 
		public inkCompoundWidgetReference SectionsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("singleTextWidget")] 
		public inkTextWidgetReference SingleTextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("speakerNameTextWidget")] 
		public inkTextWidgetReference SpeakerNameTextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("exitTooltipContainer")] 
		public inkCompoundWidgetReference ExitTooltipContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("swapBackgroundVideoAnimName")] 
		public CName SwapBackgroundVideoAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("singleAnimName")] 
		public CName SingleAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("openVideoScreenAnimName")] 
		public CName OpenVideoScreenAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("closeVideoScreenAnimName")] 
		public CName CloseVideoScreenAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(14)] 
		[RED("headerLibraryID")] 
		public CName HeaderLibraryID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("boldLibraryID")] 
		public CName BoldLibraryID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("basicLibraryID")] 
		public CName BasicLibraryID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("basicTranslatableLibraryID")] 
		public CName BasicTranslatableLibraryID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("topCreditsMargin")] 
		public CFloat TopCreditsMargin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("bottomCreditsMargin")] 
		public CFloat BottomCreditsMargin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("startPosition")] 
		public CFloat StartPosition
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("subtitlesContainer")] 
		public inkCompoundWidgetReference SubtitlesContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("subtitlesLibraryPath")] 
		public CResourceAsyncReference<CResource> SubtitlesLibraryPath
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(23)] 
		[RED("shouldShowRewardPrompt")] 
		public CBool ShouldShowRewardPrompt
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("isInFinalBoardsMode")] 
		public CBool IsInFinalBoardsMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("exitNotificationDisplayTime")] 
		public CFloat ExitNotificationDisplayTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiCreditsController()
		{
			ScrollingSpeed = 60.000000F;
			FastforwardScrollingSpeed = 1500.000000F;
			SectionsContainer = new();
			SingleTextWidget = new();
			SpeakerNameTextWidget = new();
			ExitTooltipContainer = new();
			SubtitlesContainer = new();
			ExitNotificationDisplayTime = 3.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
