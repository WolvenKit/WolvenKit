using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BaseModalListPopupGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("content")] 
		public inkWidgetReference Content
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("listController")] 
		public CWeakHandle<inkVirtualListController> ListController
		{
			get => GetPropertyValue<CWeakHandle<inkVirtualListController>>();
			set => SetPropertyValue<CWeakHandle<inkVirtualListController>>(value);
		}

		[Ordinal(4)] 
		[RED("playerPuppet")] 
		public CWeakHandle<gameObject> PlayerPuppet
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(5)] 
		[RED("popupData")] 
		public CHandle<inkGameNotificationData> PopupData
		{
			get => GetPropertyValue<CHandle<inkGameNotificationData>>();
			set => SetPropertyValue<CHandle<inkGameNotificationData>>(value);
		}

		[Ordinal(6)] 
		[RED("timeDilationProfile")] 
		public CString TimeDilationProfile
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(7)] 
		[RED("templateClassifier")] 
		public CHandle<BaseModalListPopupTemplateClassifier> TemplateClassifier
		{
			get => GetPropertyValue<CHandle<BaseModalListPopupTemplateClassifier>>();
			set => SetPropertyValue<CHandle<BaseModalListPopupTemplateClassifier>>(value);
		}

		[Ordinal(8)] 
		[RED("systemRequestsHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> SystemRequestsHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		[Ordinal(9)] 
		[RED("switchAnimProxy")] 
		public CHandle<inkanimProxy> SwitchAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(10)] 
		[RED("inoutTransitionAnimProxy")] 
		public CHandle<inkanimProxy> InoutTransitionAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(11)] 
		[RED("isInMenuCallbackID")] 
		public CHandle<redCallbackObject> IsInMenuCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(12)] 
		[RED("c_scrollInputThreshold")] 
		public CFloat C_scrollInputThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("firstInit")] 
		public CBool FirstInit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public BaseModalListPopupGameController()
		{
			Content = new inkWidgetReference();
			TimeDilationProfile = "radialMenu";
			C_scrollInputThreshold = 0.750000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
