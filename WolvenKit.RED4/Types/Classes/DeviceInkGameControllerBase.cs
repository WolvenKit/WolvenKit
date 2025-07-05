using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeviceInkGameControllerBase : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("animationManager")] 
		public CHandle<WidgetAnimationManager> AnimationManager
		{
			get => GetPropertyValue<CHandle<WidgetAnimationManager>>();
			set => SetPropertyValue<CHandle<WidgetAnimationManager>>(value);
		}

		[Ordinal(3)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkCanvasWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(4)] 
		[RED("actionWidgetsData")] 
		public CArray<SActionWidgetPackage> ActionWidgetsData
		{
			get => GetPropertyValue<CArray<SActionWidgetPackage>>();
			set => SetPropertyValue<CArray<SActionWidgetPackage>>(value);
		}

		[Ordinal(5)] 
		[RED("deviceWidgetsData")] 
		public CArray<SDeviceWidgetPackage> DeviceWidgetsData
		{
			get => GetPropertyValue<CArray<SDeviceWidgetPackage>>();
			set => SetPropertyValue<CArray<SDeviceWidgetPackage>>(value);
		}

		[Ordinal(6)] 
		[RED("breadcrumbStack")] 
		public CArray<SBreadcrumbElementData> BreadcrumbStack
		{
			get => GetPropertyValue<CArray<SBreadcrumbElementData>>();
			set => SetPropertyValue<CArray<SBreadcrumbElementData>>(value);
		}

		[Ordinal(7)] 
		[RED("cashedState")] 
		public CEnum<EDeviceStatus> CashedState
		{
			get => GetPropertyValue<CEnum<EDeviceStatus>>();
			set => SetPropertyValue<CEnum<EDeviceStatus>>(value);
		}

		[Ordinal(8)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("hasUICameraZoom")] 
		public CBool HasUICameraZoom
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("activeBreadcrumb")] 
		public SBreadcrumbElementData ActiveBreadcrumb
		{
			get => GetPropertyValue<SBreadcrumbElementData>();
			set => SetPropertyValue<SBreadcrumbElementData>(value);
		}

		[Ordinal(11)] 
		[RED("onRefreshListener")] 
		public CHandle<redCallbackObject> OnRefreshListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(12)] 
		[RED("onActionWidgetsUpdateListener")] 
		public CHandle<redCallbackObject> OnActionWidgetsUpdateListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(13)] 
		[RED("onDeviceWidgetsUpdateListener")] 
		public CHandle<redCallbackObject> OnDeviceWidgetsUpdateListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(14)] 
		[RED("onBreadcrumbBarUpdateListener")] 
		public CHandle<redCallbackObject> OnBreadcrumbBarUpdateListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(15)] 
		[RED("bbCallbacksRegistered")] 
		public CBool BbCallbacksRegistered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DeviceInkGameControllerBase()
		{
			ActionWidgetsData = new();
			DeviceWidgetsData = new();
			BreadcrumbStack = new();
			ActiveBreadcrumb = new SBreadcrumbElementData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
