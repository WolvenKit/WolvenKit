using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ExpansionPopupGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("popupCanvasAnchor")] 
		public inkWidgetReference PopupCanvasAnchor
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("thankYouScreenName")] 
		public CName ThankYouScreenName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("reloadingScreenName")] 
		public CName ReloadingScreenName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("preOrderScreenName")] 
		public CName PreOrderScreenName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("closeButtonRef")] 
		public inkWidgetReference CloseButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("introAnimationName")] 
		public CName IntroAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("data")] 
		public CHandle<ExpansionPopupData> Data
		{
			get => GetPropertyValue<CHandle<ExpansionPopupData>>();
			set => SetPropertyValue<CHandle<ExpansionPopupData>>(value);
		}

		[Ordinal(9)] 
		[RED("requestHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> RequestHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		[Ordinal(10)] 
		[RED("showThankYouPanel")] 
		public CBool ShowThankYouPanel
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("introAnimProxy")] 
		public CHandle<inkanimProxy> IntroAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(12)] 
		[RED("preOrderPopupController")] 
		public CWeakHandle<PreOrderPopupController> PreOrderPopupController
		{
			get => GetPropertyValue<CWeakHandle<PreOrderPopupController>>();
			set => SetPropertyValue<CWeakHandle<PreOrderPopupController>>(value);
		}

		[Ordinal(13)] 
		[RED("preOrderButton")] 
		public inkWidgetReference PreOrderButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ExpansionPopupGameController()
		{
			PopupCanvasAnchor = new();
			CloseButtonRef = new();
			IntroAnimationName = "intro";
			PreOrderButton = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
