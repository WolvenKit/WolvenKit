using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ControlledDevicesInkGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkCanvasWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(3)] 
		[RED("devicesStackSlot")] 
		public CWeakHandle<inkHorizontalPanelWidget> DevicesStackSlot
		{
			get => GetPropertyValue<CWeakHandle<inkHorizontalPanelWidget>>();
			set => SetPropertyValue<CWeakHandle<inkHorizontalPanelWidget>>(value);
		}

		[Ordinal(4)] 
		[RED("currentDeviceText")] 
		public CWeakHandle<inkTextWidget> CurrentDeviceText
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(5)] 
		[RED("controlledDevicesWidgetsData")] 
		public CArray<SWidgetPackage> ControlledDevicesWidgetsData
		{
			get => GetPropertyValue<CArray<SWidgetPackage>>();
			set => SetPropertyValue<CArray<SWidgetPackage>>(value);
		}

		[Ordinal(6)] 
		[RED("isDeviceWorking_BBID")] 
		public CHandle<redCallbackObject> IsDeviceWorking_BBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(7)] 
		[RED("activeDevice_BBID")] 
		public CHandle<redCallbackObject> ActiveDevice_BBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(8)] 
		[RED("deviceChain_BBID")] 
		public CHandle<redCallbackObject> DeviceChain_BBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(9)] 
		[RED("chainLocked_BBID")] 
		public CHandle<redCallbackObject> ChainLocked_BBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public ControlledDevicesInkGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
