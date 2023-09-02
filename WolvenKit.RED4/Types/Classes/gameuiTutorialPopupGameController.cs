using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiTutorialPopupGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("actionHint")] 
		public inkWidgetReference ActionHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("popupPanel")] 
		public inkWidgetReference PopupPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("popupFullscreenPanel")] 
		public inkWidgetReference PopupFullscreenPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("popupBlockingPanel")] 
		public inkWidgetReference PopupBlockingPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("popupFullscreenRightPanel")] 
		public inkWidgetReference PopupFullscreenRightPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("data")] 
		public CWeakHandle<TutorialPopupData> Data
		{
			get => GetPropertyValue<CWeakHandle<TutorialPopupData>>();
			set => SetPropertyValue<CWeakHandle<TutorialPopupData>>(value);
		}

		[Ordinal(8)] 
		[RED("inputBlocked")] 
		public CBool InputBlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("gamePaused")] 
		public CBool GamePaused
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("isShownBbId")] 
		public CHandle<redCallbackObject> IsShownBbId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(11)] 
		[RED("animIntroPopup")] 
		public CName AnimIntroPopup
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("animIntroPopupModal")] 
		public CName AnimIntroPopupModal
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("animIntroFullscreenLeft")] 
		public CName AnimIntroFullscreenLeft
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(14)] 
		[RED("animIntroFullscreenRight")] 
		public CName AnimIntroFullscreenRight
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("animOutroPopup")] 
		public CName AnimOutroPopup
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("animOutroPopupModal")] 
		public CName AnimOutroPopupModal
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("animOutroFullscreenLeft")] 
		public CName AnimOutroFullscreenLeft
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("animOutroFullscreenRight")] 
		public CName AnimOutroFullscreenRight
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(19)] 
		[RED("animIntro")] 
		public CName AnimIntro
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(20)] 
		[RED("animOutro")] 
		public CName AnimOutro
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(21)] 
		[RED("targetPopup")] 
		public inkWidgetReference TargetPopup
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(23)] 
		[RED("targetPosition")] 
		public CEnum<gamePopupPosition> TargetPosition
		{
			get => GetPropertyValue<CEnum<gamePopupPosition>>();
			set => SetPropertyValue<CEnum<gamePopupPosition>>(value);
		}

		public gameuiTutorialPopupGameController()
		{
			ActionHint = new inkWidgetReference();
			PopupPanel = new inkWidgetReference();
			PopupFullscreenPanel = new inkWidgetReference();
			PopupBlockingPanel = new inkWidgetReference();
			PopupFullscreenRightPanel = new inkWidgetReference();
			AnimIntroPopup = "into_popup";
			AnimIntroPopupModal = "into_popup_modal";
			AnimIntroFullscreenLeft = "into_fullscreen_left";
			AnimIntroFullscreenRight = "into_fullscreen_right";
			AnimOutroPopup = "outro_popup";
			AnimOutroPopupModal = "outro_popup_modal";
			AnimOutroFullscreenLeft = "outro_fullscreen_left";
			AnimOutroFullscreenRight = "outro_fullscreen_right";
			TargetPopup = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
