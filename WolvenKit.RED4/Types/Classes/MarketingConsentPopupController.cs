using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MarketingConsentPopupController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("titleOneRef")] 
		public inkWidgetReference TitleOneRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("titleTwoRef")] 
		public inkWidgetReference TitleTwoRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("messageIntroOneRef")] 
		public inkWidgetReference MessageIntroOneRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("messageIntroTwoRef")] 
		public inkWidgetReference MessageIntroTwoRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("ageConsentRef")] 
		public inkWidgetReference AgeConsentRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("qrCodeContainerRef")] 
		public inkWidgetReference QrCodeContainerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("questionOne_State")] 
		public CBool QuestionOne_State
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("questionTwo_State")] 
		public CBool QuestionTwo_State
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("questionOne_ContainerRef")] 
		public inkWidgetReference QuestionOne_ContainerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("questionTwo_ContainerRef")] 
		public inkWidgetReference QuestionTwo_ContainerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("questionOne_ToggleRef")] 
		public inkWidgetReference QuestionOne_ToggleRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("questionOne_ToggleFillRef")] 
		public inkWidgetReference QuestionOne_ToggleFillRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("questionTwo_ToggleRef")] 
		public inkWidgetReference QuestionTwo_ToggleRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("questionTwo_ToggleFillRef")] 
		public inkWidgetReference QuestionTwo_ToggleFillRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("hyperlinkButtonRef")] 
		public inkWidgetReference HyperlinkButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("applyButtonRef")] 
		public inkWidgetReference ApplyButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("declineButtonRef")] 
		public inkWidgetReference DeclineButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("aceptAllButtonRef")] 
		public inkWidgetReference AceptAllButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("declineAllButtonRef")] 
		public inkWidgetReference DeclineAllButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("introAnimationName")] 
		public CName IntroAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(22)] 
		[RED("aceptAllAnimationName")] 
		public CName AceptAllAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(23)] 
		[RED("declineAllAnimationName")] 
		public CName DeclineAllAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(24)] 
		[RED("data")] 
		public CHandle<MarketingConsentPopupData> Data
		{
			get => GetPropertyValue<CHandle<MarketingConsentPopupData>>();
			set => SetPropertyValue<CHandle<MarketingConsentPopupData>>(value);
		}

		[Ordinal(25)] 
		[RED("showBothQuestions")] 
		public CBool ShowBothQuestions
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("requestHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> RequestHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		[Ordinal(27)] 
		[RED("introAnimProxy")] 
		public CHandle<inkanimProxy> IntroAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(28)] 
		[RED("confirmationAnimProxy")] 
		public CHandle<inkanimProxy> ConfirmationAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public MarketingConsentPopupController()
		{
			TitleOneRef = new inkWidgetReference();
			TitleTwoRef = new inkWidgetReference();
			MessageIntroOneRef = new inkWidgetReference();
			MessageIntroTwoRef = new inkWidgetReference();
			AgeConsentRef = new inkWidgetReference();
			QrCodeContainerRef = new inkWidgetReference();
			QuestionOne_ContainerRef = new inkWidgetReference();
			QuestionTwo_ContainerRef = new inkWidgetReference();
			QuestionOne_ToggleRef = new inkWidgetReference();
			QuestionOne_ToggleFillRef = new inkWidgetReference();
			QuestionTwo_ToggleRef = new inkWidgetReference();
			QuestionTwo_ToggleFillRef = new inkWidgetReference();
			HyperlinkButtonRef = new inkWidgetReference();
			ApplyButtonRef = new inkWidgetReference();
			DeclineButtonRef = new inkWidgetReference();
			AceptAllButtonRef = new inkWidgetReference();
			DeclineAllButtonRef = new inkWidgetReference();
			IntroAnimationName = "intro";
			AceptAllAnimationName = "acceptAll";
			DeclineAllAnimationName = "declineAll";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
