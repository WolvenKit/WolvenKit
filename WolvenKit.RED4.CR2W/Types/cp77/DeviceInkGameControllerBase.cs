using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceInkGameControllerBase : gameuiWidgetGameController
	{
		private CHandle<WidgetAnimationManager> _animationManager;
		private wCHandle<inkCanvasWidget> _rootWidget;
		private CArray<SActionWidgetPackage> _actionWidgetsData;
		private CArray<SDeviceWidgetPackage> _deviceWidgetsData;
		private CArray<SBreadcrumbElementData> _breadcrumbStack;
		private CEnum<EDeviceStatus> _cashedState;
		private CBool _isInitialized;
		private CBool _hasUICameraZoom;
		private SBreadcrumbElementData _activeBreadcrumb;
		private CUInt32 _onRefreshListener;
		private CUInt32 _onActionWidgetsUpdateListener;
		private CUInt32 _onDeviceWidgetsUpdateListener;
		private CUInt32 _onBreadcrumbBarUpdateListener;
		private CBool _bbCallbacksRegistered;

		[Ordinal(2)] 
		[RED("animationManager")] 
		public CHandle<WidgetAnimationManager> AnimationManager
		{
			get
			{
				if (_animationManager == null)
				{
					_animationManager = (CHandle<WidgetAnimationManager>) CR2WTypeManager.Create("handle:WidgetAnimationManager", "animationManager", cr2w, this);
				}
				return _animationManager;
			}
			set
			{
				if (_animationManager == value)
				{
					return;
				}
				_animationManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("rootWidget")] 
		public wCHandle<inkCanvasWidget> RootWidget
		{
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "rootWidget", cr2w, this);
				}
				return _rootWidget;
			}
			set
			{
				if (_rootWidget == value)
				{
					return;
				}
				_rootWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("actionWidgetsData")] 
		public CArray<SActionWidgetPackage> ActionWidgetsData
		{
			get
			{
				if (_actionWidgetsData == null)
				{
					_actionWidgetsData = (CArray<SActionWidgetPackage>) CR2WTypeManager.Create("array:SActionWidgetPackage", "actionWidgetsData", cr2w, this);
				}
				return _actionWidgetsData;
			}
			set
			{
				if (_actionWidgetsData == value)
				{
					return;
				}
				_actionWidgetsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("deviceWidgetsData")] 
		public CArray<SDeviceWidgetPackage> DeviceWidgetsData
		{
			get
			{
				if (_deviceWidgetsData == null)
				{
					_deviceWidgetsData = (CArray<SDeviceWidgetPackage>) CR2WTypeManager.Create("array:SDeviceWidgetPackage", "deviceWidgetsData", cr2w, this);
				}
				return _deviceWidgetsData;
			}
			set
			{
				if (_deviceWidgetsData == value)
				{
					return;
				}
				_deviceWidgetsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("breadcrumbStack")] 
		public CArray<SBreadcrumbElementData> BreadcrumbStack
		{
			get
			{
				if (_breadcrumbStack == null)
				{
					_breadcrumbStack = (CArray<SBreadcrumbElementData>) CR2WTypeManager.Create("array:SBreadcrumbElementData", "breadcrumbStack", cr2w, this);
				}
				return _breadcrumbStack;
			}
			set
			{
				if (_breadcrumbStack == value)
				{
					return;
				}
				_breadcrumbStack = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("cashedState")] 
		public CEnum<EDeviceStatus> CashedState
		{
			get
			{
				if (_cashedState == null)
				{
					_cashedState = (CEnum<EDeviceStatus>) CR2WTypeManager.Create("EDeviceStatus", "cashedState", cr2w, this);
				}
				return _cashedState;
			}
			set
			{
				if (_cashedState == value)
				{
					return;
				}
				_cashedState = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get
			{
				if (_isInitialized == null)
				{
					_isInitialized = (CBool) CR2WTypeManager.Create("Bool", "isInitialized", cr2w, this);
				}
				return _isInitialized;
			}
			set
			{
				if (_isInitialized == value)
				{
					return;
				}
				_isInitialized = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("hasUICameraZoom")] 
		public CBool HasUICameraZoom
		{
			get
			{
				if (_hasUICameraZoom == null)
				{
					_hasUICameraZoom = (CBool) CR2WTypeManager.Create("Bool", "hasUICameraZoom", cr2w, this);
				}
				return _hasUICameraZoom;
			}
			set
			{
				if (_hasUICameraZoom == value)
				{
					return;
				}
				_hasUICameraZoom = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("activeBreadcrumb")] 
		public SBreadcrumbElementData ActiveBreadcrumb
		{
			get
			{
				if (_activeBreadcrumb == null)
				{
					_activeBreadcrumb = (SBreadcrumbElementData) CR2WTypeManager.Create("SBreadcrumbElementData", "activeBreadcrumb", cr2w, this);
				}
				return _activeBreadcrumb;
			}
			set
			{
				if (_activeBreadcrumb == value)
				{
					return;
				}
				_activeBreadcrumb = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("onRefreshListener")] 
		public CUInt32 OnRefreshListener
		{
			get
			{
				if (_onRefreshListener == null)
				{
					_onRefreshListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onRefreshListener", cr2w, this);
				}
				return _onRefreshListener;
			}
			set
			{
				if (_onRefreshListener == value)
				{
					return;
				}
				_onRefreshListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("onActionWidgetsUpdateListener")] 
		public CUInt32 OnActionWidgetsUpdateListener
		{
			get
			{
				if (_onActionWidgetsUpdateListener == null)
				{
					_onActionWidgetsUpdateListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onActionWidgetsUpdateListener", cr2w, this);
				}
				return _onActionWidgetsUpdateListener;
			}
			set
			{
				if (_onActionWidgetsUpdateListener == value)
				{
					return;
				}
				_onActionWidgetsUpdateListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("onDeviceWidgetsUpdateListener")] 
		public CUInt32 OnDeviceWidgetsUpdateListener
		{
			get
			{
				if (_onDeviceWidgetsUpdateListener == null)
				{
					_onDeviceWidgetsUpdateListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onDeviceWidgetsUpdateListener", cr2w, this);
				}
				return _onDeviceWidgetsUpdateListener;
			}
			set
			{
				if (_onDeviceWidgetsUpdateListener == value)
				{
					return;
				}
				_onDeviceWidgetsUpdateListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("onBreadcrumbBarUpdateListener")] 
		public CUInt32 OnBreadcrumbBarUpdateListener
		{
			get
			{
				if (_onBreadcrumbBarUpdateListener == null)
				{
					_onBreadcrumbBarUpdateListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onBreadcrumbBarUpdateListener", cr2w, this);
				}
				return _onBreadcrumbBarUpdateListener;
			}
			set
			{
				if (_onBreadcrumbBarUpdateListener == value)
				{
					return;
				}
				_onBreadcrumbBarUpdateListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("bbCallbacksRegistered")] 
		public CBool BbCallbacksRegistered
		{
			get
			{
				if (_bbCallbacksRegistered == null)
				{
					_bbCallbacksRegistered = (CBool) CR2WTypeManager.Create("Bool", "bbCallbacksRegistered", cr2w, this);
				}
				return _bbCallbacksRegistered;
			}
			set
			{
				if (_bbCallbacksRegistered == value)
				{
					return;
				}
				_bbCallbacksRegistered = value;
				PropertySet(this);
			}
		}

		public DeviceInkGameControllerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
