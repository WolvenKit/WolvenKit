using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ElevatorInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] [RED("verticalPanel")] public inkVerticalPanelWidgetReference VerticalPanel { get; set; }
		[Ordinal(17)] [RED("currentFloorTextWidget")] public inkTextWidgetReference CurrentFloorTextWidget { get; set; }
		[Ordinal(18)] [RED("openCloseButtonWidgets")] public inkCanvasWidgetReference OpenCloseButtonWidgets { get; set; }
		[Ordinal(19)] [RED("elevatorUpArrowsWidget")] public inkFlexWidgetReference ElevatorUpArrowsWidget { get; set; }
		[Ordinal(20)] [RED("elevatorDownArrowsWidget")] public inkFlexWidgetReference ElevatorDownArrowsWidget { get; set; }
		[Ordinal(21)] [RED("waitingStateWidget")] public inkCanvasWidgetReference WaitingStateWidget { get; set; }
		[Ordinal(22)] [RED("dataScanningWidget")] public inkCanvasWidgetReference DataScanningWidget { get; set; }
		[Ordinal(23)] [RED("elevatorStoppedWidget")] public inkCanvasWidgetReference ElevatorStoppedWidget { get; set; }
		[Ordinal(24)] [RED("isPlayerScanned")] public CBool IsPlayerScanned { get; set; }
		[Ordinal(25)] [RED("isPaused")] public CBool IsPaused { get; set; }
		[Ordinal(26)] [RED("isAuthorized")] public CBool IsAuthorized { get; set; }
		[Ordinal(27)] [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(28)] [RED("buttonSizes")] public CArray<CFloat> ButtonSizes { get; set; }
		[Ordinal(29)] [RED("onChangeFloorListener")] public CUInt32 OnChangeFloorListener { get; set; }
		[Ordinal(30)] [RED("onPlayerScannedListener")] public CUInt32 OnPlayerScannedListener { get; set; }
		[Ordinal(31)] [RED("onPausedChangeListener")] public CUInt32 OnPausedChangeListener { get; set; }

		public ElevatorInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
