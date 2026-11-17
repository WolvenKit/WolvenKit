using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCreditsController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("creditsResourceXBOX")] 
		public CResourceReference<inkCreditsResource> CreditsResourceXBOX
		{
			get => GetPropertyValue<CResourceReference<inkCreditsResource>>();
			set => SetPropertyValue<CResourceReference<inkCreditsResource>>(value);
		}

		[Ordinal(3)] 
		[RED("creditsResourcePC")] 
		public CResourceReference<inkCreditsResource> CreditsResourcePC
		{
			get => GetPropertyValue<CResourceReference<inkCreditsResource>>();
			set => SetPropertyValue<CResourceReference<inkCreditsResource>>(value);
		}

		[Ordinal(4)] 
		[RED("creditsResourceEmporium")] 
		public CResourceReference<inkCreditsResource> CreditsResourceEmporium
		{
			get => GetPropertyValue<CResourceReference<inkCreditsResource>>();
			set => SetPropertyValue<CResourceReference<inkCreditsResource>>(value);
		}

		[Ordinal(5)] 
		[RED("creditsResourceMac")] 
		public CResourceReference<inkCreditsResource> CreditsResourceMac
		{
			get => GetPropertyValue<CResourceReference<inkCreditsResource>>();
			set => SetPropertyValue<CResourceReference<inkCreditsResource>>(value);
		}

		[Ordinal(6)] 
		[RED("creditsResourcePS5")] 
		public CResourceReference<inkCreditsResource> CreditsResourcePS5
		{
			get => GetPropertyValue<CResourceReference<inkCreditsResource>>();
			set => SetPropertyValue<CResourceReference<inkCreditsResource>>(value);
		}

		[Ordinal(7)] 
		[RED("scrollingSpeed")] 
		public CFloat ScrollingSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("fastforwardScrollingSpeed")] 
		public CFloat FastforwardScrollingSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("sectionsContainer")] 
		public inkCompoundWidgetReference SectionsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("singleTextWidget")] 
		public inkTextWidgetReference SingleTextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("speakerNameTextWidget")] 
		public inkTextWidgetReference SpeakerNameTextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("exitTooltipContainer")] 
		public inkCompoundWidgetReference ExitTooltipContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("swapBackgroundVideoAnimName")] 
		public CName SwapBackgroundVideoAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(14)] 
		[RED("singleAnimName")] 
		public CName SingleAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("openVideoScreenAnimName")] 
		public CName OpenVideoScreenAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("closeVideoScreenAnimName")] 
		public CName CloseVideoScreenAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("headerLibraryID")] 
		public CName HeaderLibraryID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("boldLibraryID")] 
		public CName BoldLibraryID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(19)] 
		[RED("basicLibraryID")] 
		public CName BasicLibraryID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(20)] 
		[RED("basicTranslatableLibraryID")] 
		public CName BasicTranslatableLibraryID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(21)] 
		[RED("topCreditsMargin")] 
		public CFloat TopCreditsMargin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("bottomCreditsMargin")] 
		public CFloat BottomCreditsMargin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(23)] 
		[RED("startPosition")] 
		public CFloat StartPosition
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(24)] 
		[RED("subtitlesContainer")] 
		public inkCompoundWidgetReference SubtitlesContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("subtitlesLibraryPath")] 
		public CResourceAsyncReference<CResource> SubtitlesLibraryPath
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(26)] 
		[RED("shouldShowRewardPrompt")] 
		public CBool ShouldShowRewardPrompt
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("isInFinalBoardsMode")] 
		public CBool IsInFinalBoardsMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("isPreVideoFinished")] 
		public CBool IsPreVideoFinished
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("isEp1CreditsImplementation")] 
		public CBool IsEp1CreditsImplementation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
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
			SectionsContainer = new inkCompoundWidgetReference();
			SingleTextWidget = new inkTextWidgetReference();
			SpeakerNameTextWidget = new inkTextWidgetReference();
			ExitTooltipContainer = new inkCompoundWidgetReference();
			SubtitlesContainer = new inkCompoundWidgetReference();
			ExitNotificationDisplayTime = 3.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
