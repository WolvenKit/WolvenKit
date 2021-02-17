using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ControlledDevicesInkGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("rootWidget")] public wCHandle<inkCanvasWidget> RootWidget { get; set; }
		[Ordinal(3)] [RED("devcesStackSlot")] public wCHandle<inkHorizontalPanelWidget> DevcesStackSlot { get; set; }
		[Ordinal(4)] [RED("currentDeviceText")] public wCHandle<inkTextWidget> CurrentDeviceText { get; set; }
		[Ordinal(5)] [RED("controlledDevicesWidgetsData")] public CArray<SWidgetPackage> ControlledDevicesWidgetsData { get; set; }
		[Ordinal(6)] [RED("isDeviceWorking_BBID")] public CUInt32 IsDeviceWorking_BBID { get; set; }
		[Ordinal(7)] [RED("activeDevice_BBID")] public CUInt32 ActiveDevice_BBID { get; set; }
		[Ordinal(8)] [RED("deviceChain_BBID")] public CUInt32 DeviceChain_BBID { get; set; }
		[Ordinal(9)] [RED("chainLocked_BBID")] public CUInt32 ChainLocked_BBID { get; set; }

		public ControlledDevicesInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
