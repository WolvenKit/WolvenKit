using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ElevatorInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(0)]  [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(1)]  [RED("buttonSizes")] public CArray<CFloat> ButtonSizes { get; set; }
		[Ordinal(2)]  [RED("currentFloorTextWidget")] public inkTextWidgetReference CurrentFloorTextWidget { get; set; }
		[Ordinal(3)]  [RED("dataScanningWidget")] public inkCanvasWidgetReference DataScanningWidget { get; set; }
		[Ordinal(4)]  [RED("elevatorDownArrowsWidget")] public inkFlexWidgetReference ElevatorDownArrowsWidget { get; set; }
		[Ordinal(5)]  [RED("elevatorStoppedWidget")] public inkCanvasWidgetReference ElevatorStoppedWidget { get; set; }
		[Ordinal(6)]  [RED("elevatorUpArrowsWidget")] public inkFlexWidgetReference ElevatorUpArrowsWidget { get; set; }
		[Ordinal(7)]  [RED("isAuthorized")] public CBool IsAuthorized { get; set; }
		[Ordinal(8)]  [RED("isPaused")] public CBool IsPaused { get; set; }
		[Ordinal(9)]  [RED("isPlayerScanned")] public CBool IsPlayerScanned { get; set; }
		[Ordinal(10)]  [RED("onChangeFloorListener")] public CUInt32 OnChangeFloorListener { get; set; }
		[Ordinal(11)]  [RED("onPausedChangeListener")] public CUInt32 OnPausedChangeListener { get; set; }
		[Ordinal(12)]  [RED("onPlayerScannedListener")] public CUInt32 OnPlayerScannedListener { get; set; }
		[Ordinal(13)]  [RED("openCloseButtonWidgets")] public inkCanvasWidgetReference OpenCloseButtonWidgets { get; set; }
		[Ordinal(14)]  [RED("verticalPanel")] public inkVerticalPanelWidgetReference VerticalPanel { get; set; }
		[Ordinal(15)]  [RED("waitingStateWidget")] public inkCanvasWidgetReference WaitingStateWidget { get; set; }

		public ElevatorInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
