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
			get
			{
				if (_content == null)
				{
					_content = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "content", cr2w, this);
				}
				return _content;
			}
			set
			{
				if (_content == value)
				{
					return;
				}
				_content = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("listController")] 
		public wCHandle<inkVirtualListController> ListController
		{
			get
			{
				if (_listController == null)
				{
					_listController = (wCHandle<inkVirtualListController>) CR2WTypeManager.Create("whandle:inkVirtualListController", "listController", cr2w, this);
				}
				return _listController;
			}
			set
			{
				if (_listController == value)
				{
					return;
				}
				_listController = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("playerPuppet")] 
		public wCHandle<gameObject> PlayerPuppet
		{
			get
			{
				if (_playerPuppet == null)
				{
					_playerPuppet = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "playerPuppet", cr2w, this);
				}
				return _playerPuppet;
			}
			set
			{
				if (_playerPuppet == value)
				{
					return;
				}
				_playerPuppet = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("popupData")] 
		public CHandle<inkGameNotificationData> PopupData
		{
			get
			{
				if (_popupData == null)
				{
					_popupData = (CHandle<inkGameNotificationData>) CR2WTypeManager.Create("handle:inkGameNotificationData", "popupData", cr2w, this);
				}
				return _popupData;
			}
			set
			{
				if (_popupData == value)
				{
					return;
				}
				_popupData = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("templateClassifier")] 
		public CHandle<BaseModalListPopupTemplateClassifier> TemplateClassifier
		{
			get
			{
				if (_templateClassifier == null)
				{
					_templateClassifier = (CHandle<BaseModalListPopupTemplateClassifier>) CR2WTypeManager.Create("handle:BaseModalListPopupTemplateClassifier", "templateClassifier", cr2w, this);
				}
				return _templateClassifier;
			}
			set
			{
				if (_templateClassifier == value)
				{
					return;
				}
				_templateClassifier = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("systemRequestsHandler")] 
		public wCHandle<inkISystemRequestsHandler> SystemRequestsHandler
		{
			get
			{
				if (_systemRequestsHandler == null)
				{
					_systemRequestsHandler = (wCHandle<inkISystemRequestsHandler>) CR2WTypeManager.Create("whandle:inkISystemRequestsHandler", "systemRequestsHandler", cr2w, this);
				}
				return _systemRequestsHandler;
			}
			set
			{
				if (_systemRequestsHandler == value)
				{
					return;
				}
				_systemRequestsHandler = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("switchAnimProxy")] 
		public CHandle<inkanimProxy> SwitchAnimProxy
		{
			get
			{
				if (_switchAnimProxy == null)
				{
					_switchAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "switchAnimProxy", cr2w, this);
				}
				return _switchAnimProxy;
			}
			set
			{
				if (_switchAnimProxy == value)
				{
					return;
				}
				_switchAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("transitionAnimProxy")] 
		public CHandle<inkanimProxy> TransitionAnimProxy
		{
			get
			{
				if (_transitionAnimProxy == null)
				{
					_transitionAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "transitionAnimProxy", cr2w, this);
				}
				return _transitionAnimProxy;
			}
			set
			{
				if (_transitionAnimProxy == value)
				{
					return;
				}
				_transitionAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("c_scrollInputThreshold")] 
		public CFloat C_scrollInputThreshold
		{
			get
			{
				if (_c_scrollInputThreshold == null)
				{
					_c_scrollInputThreshold = (CFloat) CR2WTypeManager.Create("Float", "c_scrollInputThreshold", cr2w, this);
				}
				return _c_scrollInputThreshold;
			}
			set
			{
				if (_c_scrollInputThreshold == value)
				{
					return;
				}
				_c_scrollInputThreshold = value;
				PropertySet(this);
			}
		}

		public BaseModalListPopupGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
