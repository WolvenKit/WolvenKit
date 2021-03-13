using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scannerBorderGameController : gameuiProjectedHUDGameController
	{
		[Ordinal(9)] [RED("ZoomMovingContainer")] public inkCompoundWidgetReference ZoomMovingContainer { get; set; }
		[Ordinal(10)] [RED("DistanceMovingContainer")] public inkCompoundWidgetReference DistanceMovingContainer { get; set; }
		[Ordinal(11)] [RED("DistanceParentContainer")] public inkCompoundWidgetReference DistanceParentContainer { get; set; }
		[Ordinal(12)] [RED("CrosshairProjection")] public inkCompoundWidgetReference CrosshairProjection { get; set; }
		[Ordinal(13)] [RED("loadingBarCanvas")] public inkCompoundWidgetReference LoadingBarCanvas { get; set; }
		[Ordinal(14)] [RED("crosshairContainer")] public inkCompoundWidgetReference CrosshairContainer { get; set; }
		[Ordinal(15)] [RED("ZoomNumber")] public inkTextWidgetReference ZoomNumber { get; set; }
		[Ordinal(16)] [RED("DistanceNumber")] public inkTextWidgetReference DistanceNumber { get; set; }
		[Ordinal(17)] [RED("DistanceImageRuler")] public inkImageWidgetReference DistanceImageRuler { get; set; }
		[Ordinal(18)] [RED("ZoomMoveBracketL")] public inkImageWidgetReference ZoomMoveBracketL { get; set; }
		[Ordinal(19)] [RED("ZoomMoveBracketR")] public inkImageWidgetReference ZoomMoveBracketR { get; set; }
		[Ordinal(20)] [RED("insideCrosshair")] public inkCompoundWidgetReference InsideCrosshair { get; set; }
		[Ordinal(21)] [RED("scannerBarWidget")] public inkCompoundWidgetReference ScannerBarWidget { get; set; }
		[Ordinal(22)] [RED("scannerBarFluffText")] public inkTextWidgetReference ScannerBarFluffText { get; set; }
		[Ordinal(23)] [RED("scannerBarFill")] public inkImageWidgetReference ScannerBarFill { get; set; }
		[Ordinal(24)] [RED("LockOnAnimProxy")] public CHandle<inkanimProxy> LockOnAnimProxy { get; set; }
		[Ordinal(25)] [RED("IdleAnimProxy")] public CHandle<inkanimProxy> IdleAnimProxy { get; set; }
		[Ordinal(26)] [RED("BracketsAppearAnimProxy")] public CHandle<inkanimProxy> BracketsAppearAnimProxy { get; set; }
		[Ordinal(27)] [RED("lockOutAnimWasPlayed")] public CBool LockOutAnimWasPlayed { get; set; }
		[Ordinal(28)] [RED("root")] public wCHandle<inkCompoundWidget> Root { get; set; }
		[Ordinal(29)] [RED("currentTarget")] public entEntityID CurrentTarget { get; set; }
		[Ordinal(30)] [RED("currentTargetBuffered")] public entEntityID CurrentTargetBuffered { get; set; }
		[Ordinal(31)] [RED("scannerData")] public scannerDataStructure ScannerData { get; set; }
		[Ordinal(32)] [RED("shouldShowScanner")] public CBool ShouldShowScanner { get; set; }
		[Ordinal(33)] [RED("isFullyScanned")] public CBool IsFullyScanned { get; set; }
		[Ordinal(34)] [RED("ProjectionLogicController")] public wCHandle<ScannerCrosshairLogicController> ProjectionLogicController { get; set; }
		[Ordinal(35)] [RED("OriginalScannerBarFillSize")] public Vector2 OriginalScannerBarFillSize { get; set; }
		[Ordinal(36)] [RED("zoomUpAnim")] public CHandle<inkanimProxy> ZoomUpAnim { get; set; }
		[Ordinal(37)] [RED("animLockOn")] public CHandle<inkanimProxy> AnimLockOn { get; set; }
		[Ordinal(38)] [RED("zoomDownAnim")] public CHandle<inkanimProxy> ZoomDownAnim { get; set; }
		[Ordinal(39)] [RED("animLockOff")] public CHandle<inkanimProxy> AnimLockOff { get; set; }
		[Ordinal(40)] [RED("exclusiveFocusAnim")] public CHandle<inkanimProxy> ExclusiveFocusAnim { get; set; }
		[Ordinal(41)] [RED("isExclusiveFocus")] public CBool IsExclusiveFocus { get; set; }
		[Ordinal(42)] [RED("argZoomBuffered")] public CFloat ArgZoomBuffered { get; set; }
		[Ordinal(43)] [RED("squares")] public CArray<wCHandle<inkImageWidget>> Squares { get; set; }
		[Ordinal(44)] [RED("squaresFilled")] public CArray<wCHandle<inkImageWidget>> SquaresFilled { get; set; }
		[Ordinal(45)] [RED("scanBlackboard")] public CHandle<gameIBlackboard> ScanBlackboard { get; set; }
		[Ordinal(46)] [RED("psmBlackboard")] public CHandle<gameIBlackboard> PsmBlackboard { get; set; }
		[Ordinal(47)] [RED("BBID_ScanObject")] public CUInt32 BBID_ScanObject { get; set; }
		[Ordinal(48)] [RED("BBID_ScanObject_Data")] public CUInt32 BBID_ScanObject_Data { get; set; }
		[Ordinal(49)] [RED("BBID_ScanObject_Position")] public CUInt32 BBID_ScanObject_Position { get; set; }
		[Ordinal(50)] [RED("BBID_ScanState")] public CUInt32 BBID_ScanState { get; set; }
		[Ordinal(51)] [RED("BBID_ProgressNum")] public CUInt32 BBID_ProgressNum { get; set; }
		[Ordinal(52)] [RED("BBID_ProgressText")] public CUInt32 BBID_ProgressText { get; set; }
		[Ordinal(53)] [RED("BBID_ExclusiveFocus")] public CUInt32 BBID_ExclusiveFocus { get; set; }
		[Ordinal(54)] [RED("PSM_BBID")] public CUInt32 PSM_BBID { get; set; }
		[Ordinal(55)] [RED("VisionStateBlackboardId")] public CUInt32 VisionStateBlackboardId { get; set; }

		public scannerBorderGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
