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
		[RED("expansionScreenName")] 
		public CName ExpansionScreenName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("thankYouScreenName")] 
		public CName ThankYouScreenName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("reloadingScreenName")] 
		public CName ReloadingScreenName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("preOrderScreenName")] 
		public CName PreOrderScreenName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("closeButtonRef")] 
		public inkWidgetReference CloseButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("introAnimationName")] 
		public CName IntroAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetPropertyValue<CHandle<gameuiGameSystemUI>>();
			set => SetPropertyValue<CHandle<gameuiGameSystemUI>>(value);
		}

		[Ordinal(10)] 
		[RED("data")] 
		public CHandle<ExpansionPopupData> Data
		{
			get => GetPropertyValue<CHandle<ExpansionPopupData>>();
			set => SetPropertyValue<CHandle<ExpansionPopupData>>(value);
		}

		[Ordinal(11)] 
		[RED("requestHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> RequestHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		[Ordinal(12)] 
		[RED("showThankYouPanel")] 
		public CBool ShowThankYouPanel
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("introAnimProxy")] 
		public CHandle<inkanimProxy> IntroAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(14)] 
		[RED("featuresExpansionPopupController")] 
		public CWeakHandle<FeaturesExpansionPopupController> FeaturesExpansionPopupController
		{
			get => GetPropertyValue<CWeakHandle<FeaturesExpansionPopupController>>();
			set => SetPropertyValue<CWeakHandle<FeaturesExpansionPopupController>>(value);
		}

		[Ordinal(15)] 
		[RED("preOrderPopupController")] 
		public CWeakHandle<PreOrderPopupController> PreOrderPopupController
		{
			get => GetPropertyValue<CWeakHandle<PreOrderPopupController>>();
			set => SetPropertyValue<CWeakHandle<PreOrderPopupController>>(value);
		}

		[Ordinal(16)] 
		[RED("reloadingPopupController")] 
		public CWeakHandle<ReloadingExpansionPopupController> ReloadingPopupController
		{
			get => GetPropertyValue<CWeakHandle<ReloadingExpansionPopupController>>();
			set => SetPropertyValue<CWeakHandle<ReloadingExpansionPopupController>>(value);
		}

		[Ordinal(17)] 
		[RED("buyButton")] 
		public inkWidgetReference BuyButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("preOrderButton")] 
		public inkWidgetReference PreOrderButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("isProcessingPurchase")] 
		public CBool IsProcessingPurchase
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ExpansionPopupGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
