using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiTutorialPopupGameController : gameuiWidgetGameController
	{
		private inkWidgetReference _actionHint;
		private inkWidgetReference _popupPanel;
		private inkWidgetReference _popupFullscreenPanel;
		private inkWidgetReference _popupBlockingPanel;
		private inkWidgetReference _popupFullscreenRightPanel;
		private CWeakHandle<TutorialPopupData> _data;
		private CBool _inputBlocked;
		private CBool _gamePaused;
		private CHandle<redCallbackObject> _isShownBbId;
		private CName _animIntroPopup;
		private CName _animIntroPopupModal;
		private CName _animIntroFullscreenLeft;
		private CName _animIntroFullscreenRight;
		private CName _animOutroPopup;
		private CName _animOutroPopupModal;
		private CName _animOutroFullscreenLeft;
		private CName _animOutroFullscreenRight;
		private CName _animIntro;
		private CName _animOutro;
		private inkWidgetReference _targetPopup;
		private CHandle<inkanimProxy> _animationProxy;
		private CEnum<gamePopupPosition> _targetPosition;

		[Ordinal(2)] 
		[RED("actionHint")] 
		public inkWidgetReference ActionHint
		{
			get => GetProperty(ref _actionHint);
			set => SetProperty(ref _actionHint, value);
		}

		[Ordinal(3)] 
		[RED("popupPanel")] 
		public inkWidgetReference PopupPanel
		{
			get => GetProperty(ref _popupPanel);
			set => SetProperty(ref _popupPanel, value);
		}

		[Ordinal(4)] 
		[RED("popupFullscreenPanel")] 
		public inkWidgetReference PopupFullscreenPanel
		{
			get => GetProperty(ref _popupFullscreenPanel);
			set => SetProperty(ref _popupFullscreenPanel, value);
		}

		[Ordinal(5)] 
		[RED("popupBlockingPanel")] 
		public inkWidgetReference PopupBlockingPanel
		{
			get => GetProperty(ref _popupBlockingPanel);
			set => SetProperty(ref _popupBlockingPanel, value);
		}

		[Ordinal(6)] 
		[RED("popupFullscreenRightPanel")] 
		public inkWidgetReference PopupFullscreenRightPanel
		{
			get => GetProperty(ref _popupFullscreenRightPanel);
			set => SetProperty(ref _popupFullscreenRightPanel, value);
		}

		[Ordinal(7)] 
		[RED("data")] 
		public CWeakHandle<TutorialPopupData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(8)] 
		[RED("inputBlocked")] 
		public CBool InputBlocked
		{
			get => GetProperty(ref _inputBlocked);
			set => SetProperty(ref _inputBlocked, value);
		}

		[Ordinal(9)] 
		[RED("gamePaused")] 
		public CBool GamePaused
		{
			get => GetProperty(ref _gamePaused);
			set => SetProperty(ref _gamePaused, value);
		}

		[Ordinal(10)] 
		[RED("isShownBbId")] 
		public CHandle<redCallbackObject> IsShownBbId
		{
			get => GetProperty(ref _isShownBbId);
			set => SetProperty(ref _isShownBbId, value);
		}

		[Ordinal(11)] 
		[RED("animIntroPopup")] 
		public CName AnimIntroPopup
		{
			get => GetProperty(ref _animIntroPopup);
			set => SetProperty(ref _animIntroPopup, value);
		}

		[Ordinal(12)] 
		[RED("animIntroPopupModal")] 
		public CName AnimIntroPopupModal
		{
			get => GetProperty(ref _animIntroPopupModal);
			set => SetProperty(ref _animIntroPopupModal, value);
		}

		[Ordinal(13)] 
		[RED("animIntroFullscreenLeft")] 
		public CName AnimIntroFullscreenLeft
		{
			get => GetProperty(ref _animIntroFullscreenLeft);
			set => SetProperty(ref _animIntroFullscreenLeft, value);
		}

		[Ordinal(14)] 
		[RED("animIntroFullscreenRight")] 
		public CName AnimIntroFullscreenRight
		{
			get => GetProperty(ref _animIntroFullscreenRight);
			set => SetProperty(ref _animIntroFullscreenRight, value);
		}

		[Ordinal(15)] 
		[RED("animOutroPopup")] 
		public CName AnimOutroPopup
		{
			get => GetProperty(ref _animOutroPopup);
			set => SetProperty(ref _animOutroPopup, value);
		}

		[Ordinal(16)] 
		[RED("animOutroPopupModal")] 
		public CName AnimOutroPopupModal
		{
			get => GetProperty(ref _animOutroPopupModal);
			set => SetProperty(ref _animOutroPopupModal, value);
		}

		[Ordinal(17)] 
		[RED("animOutroFullscreenLeft")] 
		public CName AnimOutroFullscreenLeft
		{
			get => GetProperty(ref _animOutroFullscreenLeft);
			set => SetProperty(ref _animOutroFullscreenLeft, value);
		}

		[Ordinal(18)] 
		[RED("animOutroFullscreenRight")] 
		public CName AnimOutroFullscreenRight
		{
			get => GetProperty(ref _animOutroFullscreenRight);
			set => SetProperty(ref _animOutroFullscreenRight, value);
		}

		[Ordinal(19)] 
		[RED("animIntro")] 
		public CName AnimIntro
		{
			get => GetProperty(ref _animIntro);
			set => SetProperty(ref _animIntro, value);
		}

		[Ordinal(20)] 
		[RED("animOutro")] 
		public CName AnimOutro
		{
			get => GetProperty(ref _animOutro);
			set => SetProperty(ref _animOutro, value);
		}

		[Ordinal(21)] 
		[RED("targetPopup")] 
		public inkWidgetReference TargetPopup
		{
			get => GetProperty(ref _targetPopup);
			set => SetProperty(ref _targetPopup, value);
		}

		[Ordinal(22)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		[Ordinal(23)] 
		[RED("targetPosition")] 
		public CEnum<gamePopupPosition> TargetPosition
		{
			get => GetProperty(ref _targetPosition);
			set => SetProperty(ref _targetPosition, value);
		}

		public gameuiTutorialPopupGameController()
		{
			_animIntroPopup = "into_popup";
			_animIntroPopupModal = "into_popup_modal";
			_animIntroFullscreenLeft = "into_fullscreen_left";
			_animIntroFullscreenRight = "into_fullscreen_right";
			_animOutroPopup = "outro_popup";
			_animOutroPopupModal = "outro_popup_modal";
			_animOutroFullscreenLeft = "outro_fullscreen_left";
			_animOutroFullscreenRight = "outro_fullscreen_right";
		}
	}
}
