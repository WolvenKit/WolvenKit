using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ControlledDevicesInkGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("activeDevice_BBID")] public CUInt32 ActiveDevice_BBID { get; set; }
		[Ordinal(1)]  [RED("chainLocked_BBID")] public CUInt32 ChainLocked_BBID { get; set; }
		[Ordinal(2)]  [RED("controlledDevicesWidgetsData")] public CArray<SWidgetPackage> ControlledDevicesWidgetsData { get; set; }
		[Ordinal(3)]  [RED("currentDeviceText")] public wCHandle<inkTextWidget> CurrentDeviceText { get; set; }
		[Ordinal(4)]  [RED("devcesStackSlot")] public wCHandle<inkHorizontalPanelWidget> DevcesStackSlot { get; set; }
		[Ordinal(5)]  [RED("deviceChain_BBID")] public CUInt32 DeviceChain_BBID { get; set; }
		[Ordinal(6)]  [RED("isDeviceWorking_BBID")] public CUInt32 IsDeviceWorking_BBID { get; set; }
		[Ordinal(7)]  [RED("rootWidget")] public wCHandle<inkCanvasWidget> RootWidget { get; set; }

		public ControlledDevicesInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
