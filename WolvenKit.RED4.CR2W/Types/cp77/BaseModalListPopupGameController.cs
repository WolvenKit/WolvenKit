using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseModalListPopupGameController : gameuiWidgetGameController
	{
		private inkWidgetReference _content;
		private wCHandle<inkVirtualListController> _listController;
		private wCHandle<gameObject> _playerPuppet;
		private CHandle<inkGameNotificationData> _popupData;
		private CHandle<BaseModalListPopupTemplateClassifier> _templateClassifier;
		private wCHandle<inkISystemRequestsHandler> _systemRequestsHandler;
		private CHandle<inkanimProxy> _switchAnimProxy;
		private CHandle<inkanimProxy> _transitionAnimProxy;
		private CFloat _c_scrollInputThreshold;

		[Ordinal(2)] 
		[RED("content")] 
		public inkWidgetReference Content
		{
			get => GetProperty(ref _content);
			set => SetProperty(ref _content, value);
		}

		[Ordinal(3)] 
		[RED("listController")] 
		public wCHandle<inkVirtualListController> ListController
		{
			get => GetProperty(ref _listController);
			set => SetProperty(ref _listController, value);
		}

		[Ordinal(4)] 
		[RED("playerPuppet")] 
		public wCHandle<gameObject> PlayerPuppet
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
		public wCHandle<inkISystemRequestsHandler> SystemRequestsHandler
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
		[RED("c_scrollInputThreshold")] 
		public CFloat C_scrollInputThreshold
		{
			get => GetProperty(ref _c_scrollInputThreshold);
			set => SetProperty(ref _c_scrollInputThreshold, value);
		}

		public BaseModalListPopupGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
