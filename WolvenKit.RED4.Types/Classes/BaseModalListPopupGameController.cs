using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseModalListPopupGameController : gameuiWidgetGameController
	{
		private inkWidgetReference _content;
		private CWeakHandle<inkVirtualListController> _listController;
		private CWeakHandle<gameObject> _playerPuppet;
		private CHandle<inkGameNotificationData> _popupData;
		private CHandle<BaseModalListPopupTemplateClassifier> _templateClassifier;
		private CWeakHandle<inkISystemRequestsHandler> _systemRequestsHandler;
		private CHandle<inkanimProxy> _switchAnimProxy;
		private CHandle<inkanimProxy> _transitionAnimProxy;
		private CHandle<redCallbackObject> _isInMenuCallbackID;
		private CFloat _c_scrollInputThreshold;
		private CBool _firstInit;

		[Ordinal(2)] 
		[RED("content")] 
		public inkWidgetReference Content
		{
			get => GetProperty(ref _content);
			set => SetProperty(ref _content, value);
		}

		[Ordinal(3)] 
		[RED("listController")] 
		public CWeakHandle<inkVirtualListController> ListController
		{
			get => GetProperty(ref _listController);
			set => SetProperty(ref _listController, value);
		}

		[Ordinal(4)] 
		[RED("playerPuppet")] 
		public CWeakHandle<gameObject> PlayerPuppet
		{
			get => GetProperty(ref _playerPuppet);
			set => SetProperty(ref _playerPuppet, value);
		}

		[Ordinal(5)] 
		[RED("popupData")] 
		public CHandle<inkGameNotificationData> PopupData
		{
			get => GetProperty(ref _popupData);
			set => SetProperty(ref _popupData, value);
		}

		[Ordinal(6)] 
		[RED("templateClassifier")] 
		public CHandle<BaseModalListPopupTemplateClassifier> TemplateClassifier
		{
			get => GetProperty(ref _templateClassifier);
			set => SetProperty(ref _templateClassifier, value);
		}

		[Ordinal(7)] 
		[RED("systemRequestsHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> SystemRequestsHandler
		{
			get => GetProperty(ref _systemRequestsHandler);
			set => SetProperty(ref _systemRequestsHandler, value);
		}

		[Ordinal(8)] 
		[RED("switchAnimProxy")] 
		public CHandle<inkanimProxy> SwitchAnimProxy
		{
			get => GetProperty(ref _switchAnimProxy);
			set => SetProperty(ref _switchAnimProxy, value);
		}

		[Ordinal(9)] 
		[RED("transitionAnimProxy")] 
		public CHandle<inkanimProxy> TransitionAnimProxy
		{
			get => GetProperty(ref _transitionAnimProxy);
			set => SetProperty(ref _transitionAnimProxy, value);
		}

		[Ordinal(10)] 
		[RED("isInMenuCallbackID")] 
		public CHandle<redCallbackObject> IsInMenuCallbackID
		{
			get => GetProperty(ref _isInMenuCallbackID);
			set => SetProperty(ref _isInMenuCallbackID, value);
		}

		[Ordinal(11)] 
		[RED("c_scrollInputThreshold")] 
		public CFloat C_scrollInputThreshold
		{
			get => GetProperty(ref _c_scrollInputThreshold);
			set => SetProperty(ref _c_scrollInputThreshold, value);
		}

		[Ordinal(12)] 
		[RED("firstInit")] 
		public CBool FirstInit
		{
			get => GetProperty(ref _firstInit);
			set => SetProperty(ref _firstInit, value);
		}
	}
}
