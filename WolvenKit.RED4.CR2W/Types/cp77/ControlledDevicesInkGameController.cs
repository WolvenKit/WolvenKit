using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ControlledDevicesInkGameController : gameuiWidgetGameController
	{
		private wCHandle<inkCanvasWidget> _rootWidget;
		private wCHandle<inkHorizontalPanelWidget> _devcesStackSlot;
		private wCHandle<inkTextWidget> _currentDeviceText;
		private CArray<SWidgetPackage> _controlledDevicesWidgetsData;
		private CHandle<redCallbackObject> _isDeviceWorking_BBID;
		private CHandle<redCallbackObject> _activeDevice_BBID;
		private CHandle<redCallbackObject> _deviceChain_BBID;
		private CHandle<redCallbackObject> _chainLocked_BBID;

		[Ordinal(2)] 
		[RED("rootWidget")] 
		public wCHandle<inkCanvasWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(3)] 
		[RED("devcesStackSlot")] 
		public wCHandle<inkHorizontalPanelWidget> DevcesStackSlot
		{
			get => GetProperty(ref _devcesStackSlot);
			set => SetProperty(ref _devcesStackSlot, value);
		}

		[Ordinal(4)] 
		[RED("currentDeviceText")] 
		public wCHandle<inkTextWidget> CurrentDeviceText
		{
			get => GetProperty(ref _currentDeviceText);
			set => SetProperty(ref _currentDeviceText, value);
		}

		[Ordinal(5)] 
		[RED("controlledDevicesWidgetsData")] 
		public CArray<SWidgetPackage> ControlledDevicesWidgetsData
		{
			get => GetProperty(ref _controlledDevicesWidgetsData);
			set => SetProperty(ref _controlledDevicesWidgetsData, value);
		}

		[Ordinal(6)] 
		[RED("isDeviceWorking_BBID")] 
		public CHandle<redCallbackObject> IsDeviceWorking_BBID
		{
			get => GetProperty(ref _isDeviceWorking_BBID);
			set => SetProperty(ref _isDeviceWorking_BBID, value);
		}

		[Ordinal(7)] 
		[RED("activeDevice_BBID")] 
		public CHandle<redCallbackObject> ActiveDevice_BBID
		{
			get => GetProperty(ref _activeDevice_BBID);
			set => SetProperty(ref _activeDevice_BBID, value);
		}

		[Ordinal(8)] 
		[RED("deviceChain_BBID")] 
		public CHandle<redCallbackObject> DeviceChain_BBID
		{
			get => GetProperty(ref _deviceChain_BBID);
			set => SetProperty(ref _deviceChain_BBID, value);
		}

		[Ordinal(9)] 
		[RED("chainLocked_BBID")] 
		public CHandle<redCallbackObject> ChainLocked_BBID
		{
			get => GetProperty(ref _chainLocked_BBID);
			set => SetProperty(ref _chainLocked_BBID, value);
		}

		public ControlledDevicesInkGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
