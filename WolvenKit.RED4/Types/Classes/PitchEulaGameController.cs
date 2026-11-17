using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PitchEulaGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("eulaWidget")] 
		public inkWidgetReference EulaWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("sliderWidget")] 
		public inkWidgetReference SliderWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("declineButtonText")] 
		public inkTextWidgetReference DeclineButtonText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("acceptButtonText")] 
		public inkTextWidgetReference AcceptButtonText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("contentTextRef")] 
		public inkTextWidgetReference ContentTextRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("contentTextLocKey")] 
		public CName ContentTextLocKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("gamerTagContainerRef")] 
		public inkWidgetReference GamerTagContainerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("gamerTagText")] 
		public inkTextWidgetReference GamerTagText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("declineEulaPopup")] 
		public inkWidgetReference DeclineEulaPopup
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("declineEulaPopupConfirmButtonRef")] 
		public inkWidgetReference DeclineEulaPopupConfirmButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("declineEulaQuitGameHintRef")] 
		public inkWidgetReference DeclineEulaQuitGameHintRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("eulaHintsContainerRef")] 
		public inkWidgetReference EulaHintsContainerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetPropertyValue<CHandle<gameuiGameSystemUI>>();
			set => SetPropertyValue<CHandle<gameuiGameSystemUI>>(value);
		}

		[Ordinal(16)] 
		[RED("delaySystem")] 
		public CHandle<gameDelaySystem> DelaySystem
		{
			get => GetPropertyValue<CHandle<gameDelaySystem>>();
			set => SetPropertyValue<CHandle<gameDelaySystem>>(value);
		}

		[Ordinal(17)] 
		[RED("requestHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> RequestHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		[Ordinal(18)] 
		[RED("eventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> EventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(19)] 
		[RED("eulaIsAccepted")] 
		public CBool EulaIsAccepted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("eulaRead")] 
		public CBool EulaRead
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("eulaReadWhenButtonWasPressed")] 
		public CBool EulaReadWhenButtonWasPressed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("declinePopupOpened")] 
		public CBool DeclinePopupOpened
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("sliderController")] 
		public CWeakHandle<inkSliderController> SliderController
		{
			get => GetPropertyValue<CWeakHandle<inkSliderController>>();
			set => SetPropertyValue<CWeakHandle<inkSliderController>>(value);
		}

		[Ordinal(24)] 
		[RED("declineEulaPopupConfirmButtonController")] 
		public CWeakHandle<inkButtonController> DeclineEulaPopupConfirmButtonController
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(25)] 
		[RED("declineEulaPopupProxy")] 
		public CHandle<inkanimProxy> DeclineEulaPopupProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(26)] 
		[RED("eulaAnimationProxy")] 
		public CHandle<inkanimProxy> EulaAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public PitchEulaGameController()
		{
			EulaWidget = new inkWidgetReference();
			SliderWidget = new inkWidgetReference();
			DeclineButtonText = new inkTextWidgetReference();
			AcceptButtonText = new inkTextWidgetReference();
			ContentTextRef = new inkTextWidgetReference();
			ContentTextLocKey = "UI-EULA-EULAFullText";
			GamerTagContainerRef = new inkWidgetReference();
			GamerTagText = new inkTextWidgetReference();
			DeclineEulaPopup = new inkWidgetReference();
			DeclineEulaPopupConfirmButtonRef = new inkWidgetReference();
			DeclineEulaQuitGameHintRef = new inkWidgetReference();
			EulaHintsContainerRef = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
