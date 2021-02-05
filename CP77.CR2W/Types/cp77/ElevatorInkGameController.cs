using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ElevatorInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(0)]  [RED("animationManager")] public CHandle<WidgetAnimationManager> AnimationManager { get; set; }
		[Ordinal(1)]  [RED("rootWidget")] public wCHandle<inkCanvasWidget> RootWidget { get; set; }
		[Ordinal(2)]  [RED("actionWidgetsData")] public CArray<SActionWidgetPackage> ActionWidgetsData { get; set; }
		[Ordinal(3)]  [RED("deviceWidgetsData")] public CArray<SDeviceWidgetPackage> DeviceWidgetsData { get; set; }
		[Ordinal(4)]  [RED("breadcrumbStack")] public CArray<SBreadcrumbElementData> BreadcrumbStack { get; set; }
		[Ordinal(5)]  [RED("cashedState")] public CEnum<EDeviceStatus> CashedState { get; set; }
		[Ordinal(6)]  [RED("isInitialized")] public CBool IsInitialized { get; set; }
		[Ordinal(7)]  [RED("hasUICameraZoom")] public CBool HasUICameraZoom { get; set; }
		[Ordinal(8)]  [RED("activeBreadcrumb")] public SBreadcrumbElementData ActiveBreadcrumb { get; set; }
		[Ordinal(9)]  [RED("onRefreshListener")] public CUInt32 OnRefreshListener { get; set; }
		[Ordinal(10)]  [RED("onActionWidgetsUpdateListener")] public CUInt32 OnActionWidgetsUpdateListener { get; set; }
		[Ordinal(11)]  [RED("onDeviceWidgetsUpdateListener")] public CUInt32 OnDeviceWidgetsUpdateListener { get; set; }
		[Ordinal(12)]  [RED("onBreadcrumbBarUpdateListener")] public CUInt32 OnBreadcrumbBarUpdateListener { get; set; }
		[Ordinal(13)]  [RED("bbCallbacksRegistered")] public CBool BbCallbacksRegistered { get; set; }
		[Ordinal(14)]  [RED("verticalPanel")] public inkVerticalPanelWidgetReference VerticalPanel { get; set; }
		[Ordinal(15)]  [RED("currentFloorTextWidget")] public inkTextWidgetReference CurrentFloorTextWidget { get; set; }
		[Ordinal(16)]  [RED("openCloseButtonWidgets")] public inkCanvasWidgetReference OpenCloseButtonWidgets { get; set; }
		[Ordinal(17)]  [RED("elevatorUpArrowsWidget")] public inkFlexWidgetReference ElevatorUpArrowsWidget { get; set; }
		[Ordinal(18)]  [RED("elevatorDownArrowsWidget")] public inkFlexWidgetReference ElevatorDownArrowsWidget { get; set; }
		[Ordinal(19)]  [RED("waitingStateWidget")] public inkCanvasWidgetReference WaitingStateWidget { get; set; }
		[Ordinal(20)]  [RED("dataScanningWidget")] public inkCanvasWidgetReference DataScanningWidget { get; set; }
		[Ordinal(21)]  [RED("elevatorStoppedWidget")] public inkCanvasWidgetReference ElevatorStoppedWidget { get; set; }
		[Ordinal(22)]  [RED("isPlayerScanned")] public CBool IsPlayerScanned { get; set; }
		[Ordinal(23)]  [RED("isPaused")] public CBool IsPaused { get; set; }
		[Ordinal(24)]  [RED("isAuthorized")] public CBool IsAuthorized { get; set; }
		[Ordinal(25)]  [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(26)]  [RED("buttonSizes")] public CArray<CFloat> ButtonSizes { get; set; }
		[Ordinal(27)]  [RED("onChangeFloorListener")] public CUInt32 OnChangeFloorListener { get; set; }
		[Ordinal(28)]  [RED("onPlayerScannedListener")] public CUInt32 OnPlayerScannedListener { get; set; }
		[Ordinal(29)]  [RED("onPausedChangeListener")] public CUInt32 OnPausedChangeListener { get; set; }

		public ElevatorInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
