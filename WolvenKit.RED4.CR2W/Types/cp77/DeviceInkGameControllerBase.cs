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
			get => GetProperty(ref _animationManager);
			set => SetProperty(ref _animationManager, value);
		}

		[Ordinal(3)] 
		[RED("rootWidget")] 
		public wCHandle<inkCanvasWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(4)] 
		[RED("actionWidgetsData")] 
		public CArray<SActionWidgetPackage> ActionWidgetsData
		{
			get => GetProperty(ref _actionWidgetsData);
			set => SetProperty(ref _actionWidgetsData, value);
		}

		[Ordinal(5)] 
		[RED("deviceWidgetsData")] 
		public CArray<SDeviceWidgetPackage> DeviceWidgetsData
		{
			get => GetProperty(ref _deviceWidgetsData);
			set => SetProperty(ref _deviceWidgetsData, value);
		}

		[Ordinal(6)] 
		[RED("breadcrumbStack")] 
		public CArray<SBreadcrumbElementData> BreadcrumbStack
		{
			get => GetProperty(ref _breadcrumbStack);
			set => SetProperty(ref _breadcrumbStack, value);
		}

		[Ordinal(7)] 
		[RED("cashedState")] 
		public CEnum<EDeviceStatus> CashedState
		{
			get => GetProperty(ref _cashedState);
			set => SetProperty(ref _cashedState, value);
		}

		[Ordinal(8)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get => GetProperty(ref _isInitialized);
			set => SetProperty(ref _isInitialized, value);
		}

		[Ordinal(9)] 
		[RED("hasUICameraZoom")] 
		public CBool HasUICameraZoom
		{
			get => GetProperty(ref _hasUICameraZoom);
			set => SetProperty(ref _hasUICameraZoom, value);
		}

		[Ordinal(10)] 
		[RED("activeBreadcrumb")] 
		public SBreadcrumbElementData ActiveBreadcrumb
		{
			get => GetProperty(ref _activeBreadcrumb);
			set => SetProperty(ref _activeBreadcrumb, value);
		}

		[Ordinal(11)] 
		[RED("onRefreshListener")] 
		public CUInt32 OnRefreshListener
		{
			get => GetProperty(ref _onRefreshListener);
			set => SetProperty(ref _onRefreshListener, value);
		}

		[Ordinal(12)] 
		[RED("onActionWidgetsUpdateListener")] 
		public CUInt32 OnActionWidgetsUpdateListener
		{
			get => GetProperty(ref _onActionWidgetsUpdateListener);
			set => SetProperty(ref _onActionWidgetsUpdateListener, value);
		}

		[Ordinal(13)] 
		[RED("onDeviceWidgetsUpdateListener")] 
		public CUInt32 OnDeviceWidgetsUpdateListener
		{
			get => GetProperty(ref _onDeviceWidgetsUpdateListener);
			set => SetProperty(ref _onDeviceWidgetsUpdateListener, value);
		}

		[Ordinal(14)] 
		[RED("onBreadcrumbBarUpdateListener")] 
		public CUInt32 OnBreadcrumbBarUpdateListener
		{
			get => GetProperty(ref _onBreadcrumbBarUpdateListener);
			set => SetProperty(ref _onBreadcrumbBarUpdateListener, value);
		}

		[Ordinal(15)] 
		[RED("bbCallbacksRegistered")] 
		public CBool BbCallbacksRegistered
		{
			get => GetProperty(ref _bbCallbacksRegistered);
			set => SetProperty(ref _bbCallbacksRegistered, value);
		}

		public DeviceInkGameControllerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
