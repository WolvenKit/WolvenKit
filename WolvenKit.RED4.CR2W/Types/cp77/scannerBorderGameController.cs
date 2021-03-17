using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scannerBorderGameController : gameuiProjectedHUDGameController
	{
		private inkCompoundWidgetReference _zoomMovingContainer;
		private inkCompoundWidgetReference _distanceMovingContainer;
		private inkCompoundWidgetReference _distanceParentContainer;
		private inkCompoundWidgetReference _crosshairProjection;
		private inkCompoundWidgetReference _loadingBarCanvas;
		private inkCompoundWidgetReference _crosshairContainer;
		private inkTextWidgetReference _zoomNumber;
		private inkTextWidgetReference _distanceNumber;
		private inkImageWidgetReference _distanceImageRuler;
		private inkImageWidgetReference _zoomMoveBracketL;
		private inkImageWidgetReference _zoomMoveBracketR;
		private inkCompoundWidgetReference _insideCrosshair;
		private inkCompoundWidgetReference _scannerBarWidget;
		private inkTextWidgetReference _scannerBarFluffText;
		private inkImageWidgetReference _scannerBarFill;
		private CHandle<inkanimProxy> _lockOnAnimProxy;
		private CHandle<inkanimProxy> _idleAnimProxy;
		private CHandle<inkanimProxy> _bracketsAppearAnimProxy;
		private CBool _lockOutAnimWasPlayed;
		private wCHandle<inkCompoundWidget> _root;
		private entEntityID _currentTarget;
		private entEntityID _currentTargetBuffered;
		private scannerDataStructure _scannerData;
		private CBool _shouldShowScanner;
		private CBool _isFullyScanned;
		private wCHandle<ScannerCrosshairLogicController> _projectionLogicController;
		private Vector2 _originalScannerBarFillSize;
		private CHandle<inkanimProxy> _zoomUpAnim;
		private CHandle<inkanimProxy> _animLockOn;
		private CHandle<inkanimProxy> _zoomDownAnim;
		private CHandle<inkanimProxy> _animLockOff;
		private CHandle<inkanimProxy> _exclusiveFocusAnim;
		private CBool _isExclusiveFocus;
		private CFloat _argZoomBuffered;
		private CArray<wCHandle<inkImageWidget>> _squares;
		private CArray<wCHandle<inkImageWidget>> _squaresFilled;
		private CHandle<gameIBlackboard> _scanBlackboard;
		private CHandle<gameIBlackboard> _psmBlackboard;
		private CUInt32 _bBID_ScanObject;
		private CUInt32 _bBID_ScanObject_Data;
		private CUInt32 _bBID_ScanObject_Position;
		private CUInt32 _bBID_ScanState;
		private CUInt32 _bBID_ProgressNum;
		private CUInt32 _bBID_ProgressText;
		private CUInt32 _bBID_ExclusiveFocus;
		private CUInt32 _pSM_BBID;
		private CUInt32 _visionStateBlackboardId;

		[Ordinal(9)] 
		[RED("ZoomMovingContainer")] 
		public inkCompoundWidgetReference ZoomMovingContainer
		{
			get => GetProperty(ref _zoomMovingContainer);
			set => SetProperty(ref _zoomMovingContainer, value);
		}

		[Ordinal(10)] 
		[RED("DistanceMovingContainer")] 
		public inkCompoundWidgetReference DistanceMovingContainer
		{
			get => GetProperty(ref _distanceMovingContainer);
			set => SetProperty(ref _distanceMovingContainer, value);
		}

		[Ordinal(11)] 
		[RED("DistanceParentContainer")] 
		public inkCompoundWidgetReference DistanceParentContainer
		{
			get => GetProperty(ref _distanceParentContainer);
			set => SetProperty(ref _distanceParentContainer, value);
		}

		[Ordinal(12)] 
		[RED("CrosshairProjection")] 
		public inkCompoundWidgetReference CrosshairProjection
		{
			get => GetProperty(ref _crosshairProjection);
			set => SetProperty(ref _crosshairProjection, value);
		}

		[Ordinal(13)] 
		[RED("loadingBarCanvas")] 
		public inkCompoundWidgetReference LoadingBarCanvas
		{
			get => GetProperty(ref _loadingBarCanvas);
			set => SetProperty(ref _loadingBarCanvas, value);
		}

		[Ordinal(14)] 
		[RED("crosshairContainer")] 
		public inkCompoundWidgetReference CrosshairContainer
		{
			get => GetProperty(ref _crosshairContainer);
			set => SetProperty(ref _crosshairContainer, value);
		}

		[Ordinal(15)] 
		[RED("ZoomNumber")] 
		public inkTextWidgetReference ZoomNumber
		{
			get => GetProperty(ref _zoomNumber);
			set => SetProperty(ref _zoomNumber, value);
		}

		[Ordinal(16)] 
		[RED("DistanceNumber")] 
		public inkTextWidgetReference DistanceNumber
		{
			get => GetProperty(ref _distanceNumber);
			set => SetProperty(ref _distanceNumber, value);
		}

		[Ordinal(17)] 
		[RED("DistanceImageRuler")] 
		public inkImageWidgetReference DistanceImageRuler
		{
			get => GetProperty(ref _distanceImageRuler);
			set => SetProperty(ref _distanceImageRuler, value);
		}

		[Ordinal(18)] 
		[RED("ZoomMoveBracketL")] 
		public inkImageWidgetReference ZoomMoveBracketL
		{
			get => GetProperty(ref _zoomMoveBracketL);
			set => SetProperty(ref _zoomMoveBracketL, value);
		}

		[Ordinal(19)] 
		[RED("ZoomMoveBracketR")] 
		public inkImageWidgetReference ZoomMoveBracketR
		{
			get => GetProperty(ref _zoomMoveBracketR);
			set => SetProperty(ref _zoomMoveBracketR, value);
		}

		[Ordinal(20)] 
		[RED("insideCrosshair")] 
		public inkCompoundWidgetReference InsideCrosshair
		{
			get => GetProperty(ref _insideCrosshair);
			set => SetProperty(ref _insideCrosshair, value);
		}

		[Ordinal(21)] 
		[RED("scannerBarWidget")] 
		public inkCompoundWidgetReference ScannerBarWidget
		{
			get => GetProperty(ref _scannerBarWidget);
			set => SetProperty(ref _scannerBarWidget, value);
		}

		[Ordinal(22)] 
		[RED("scannerBarFluffText")] 
		public inkTextWidgetReference ScannerBarFluffText
		{
			get => GetProperty(ref _scannerBarFluffText);
			set => SetProperty(ref _scannerBarFluffText, value);
		}

		[Ordinal(23)] 
		[RED("scannerBarFill")] 
		public inkImageWidgetReference ScannerBarFill
		{
			get => GetProperty(ref _scannerBarFill);
			set => SetProperty(ref _scannerBarFill, value);
		}

		[Ordinal(24)] 
		[RED("LockOnAnimProxy")] 
		public CHandle<inkanimProxy> LockOnAnimProxy
		{
			get => GetProperty(ref _lockOnAnimProxy);
			set => SetProperty(ref _lockOnAnimProxy, value);
		}

		[Ordinal(25)] 
		[RED("IdleAnimProxy")] 
		public CHandle<inkanimProxy> IdleAnimProxy
		{
			get => GetProperty(ref _idleAnimProxy);
			set => SetProperty(ref _idleAnimProxy, value);
		}

		[Ordinal(26)] 
		[RED("BracketsAppearAnimProxy")] 
		public CHandle<inkanimProxy> BracketsAppearAnimProxy
		{
			get => GetProperty(ref _bracketsAppearAnimProxy);
			set => SetProperty(ref _bracketsAppearAnimProxy, value);
		}

		[Ordinal(27)] 
		[RED("lockOutAnimWasPlayed")] 
		public CBool LockOutAnimWasPlayed
		{
			get => GetProperty(ref _lockOutAnimWasPlayed);
			set => SetProperty(ref _lockOutAnimWasPlayed, value);
		}

		[Ordinal(28)] 
		[RED("root")] 
		public wCHandle<inkCompoundWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(29)] 
		[RED("currentTarget")] 
		public entEntityID CurrentTarget
		{
			get => GetProperty(ref _currentTarget);
			set => SetProperty(ref _currentTarget, value);
		}

		[Ordinal(30)] 
		[RED("currentTargetBuffered")] 
		public entEntityID CurrentTargetBuffered
		{
			get => GetProperty(ref _currentTargetBuffered);
			set => SetProperty(ref _currentTargetBuffered, value);
		}

		[Ordinal(31)] 
		[RED("scannerData")] 
		public scannerDataStructure ScannerData
		{
			get => GetProperty(ref _scannerData);
			set => SetProperty(ref _scannerData, value);
		}

		[Ordinal(32)] 
		[RED("shouldShowScanner")] 
		public CBool ShouldShowScanner
		{
			get => GetProperty(ref _shouldShowScanner);
			set => SetProperty(ref _shouldShowScanner, value);
		}

		[Ordinal(33)] 
		[RED("isFullyScanned")] 
		public CBool IsFullyScanned
		{
			get => GetProperty(ref _isFullyScanned);
			set => SetProperty(ref _isFullyScanned, value);
		}

		[Ordinal(34)] 
		[RED("ProjectionLogicController")] 
		public wCHandle<ScannerCrosshairLogicController> ProjectionLogicController
		{
			get => GetProperty(ref _projectionLogicController);
			set => SetProperty(ref _projectionLogicController, value);
		}

		[Ordinal(35)] 
		[RED("OriginalScannerBarFillSize")] 
		public Vector2 OriginalScannerBarFillSize
		{
			get => GetProperty(ref _originalScannerBarFillSize);
			set => SetProperty(ref _originalScannerBarFillSize, value);
		}

		[Ordinal(36)] 
		[RED("zoomUpAnim")] 
		public CHandle<inkanimProxy> ZoomUpAnim
		{
			get => GetProperty(ref _zoomUpAnim);
			set => SetProperty(ref _zoomUpAnim, value);
		}

		[Ordinal(37)] 
		[RED("animLockOn")] 
		public CHandle<inkanimProxy> AnimLockOn
		{
			get => GetProperty(ref _animLockOn);
			set => SetProperty(ref _animLockOn, value);
		}

		[Ordinal(38)] 
		[RED("zoomDownAnim")] 
		public CHandle<inkanimProxy> ZoomDownAnim
		{
			get => GetProperty(ref _zoomDownAnim);
			set => SetProperty(ref _zoomDownAnim, value);
		}

		[Ordinal(39)] 
		[RED("animLockOff")] 
		public CHandle<inkanimProxy> AnimLockOff
		{
			get => GetProperty(ref _animLockOff);
			set => SetProperty(ref _animLockOff, value);
		}

		[Ordinal(40)] 
		[RED("exclusiveFocusAnim")] 
		public CHandle<inkanimProxy> ExclusiveFocusAnim
		{
			get => GetProperty(ref _exclusiveFocusAnim);
			set => SetProperty(ref _exclusiveFocusAnim, value);
		}

		[Ordinal(41)] 
		[RED("isExclusiveFocus")] 
		public CBool IsExclusiveFocus
		{
			get => GetProperty(ref _isExclusiveFocus);
			set => SetProperty(ref _isExclusiveFocus, value);
		}

		[Ordinal(42)] 
		[RED("argZoomBuffered")] 
		public CFloat ArgZoomBuffered
		{
			get => GetProperty(ref _argZoomBuffered);
			set => SetProperty(ref _argZoomBuffered, value);
		}

		[Ordinal(43)] 
		[RED("squares")] 
		public CArray<wCHandle<inkImageWidget>> Squares
		{
			get => GetProperty(ref _squares);
			set => SetProperty(ref _squares, value);
		}

		[Ordinal(44)] 
		[RED("squaresFilled")] 
		public CArray<wCHandle<inkImageWidget>> SquaresFilled
		{
			get => GetProperty(ref _squaresFilled);
			set => SetProperty(ref _squaresFilled, value);
		}

		[Ordinal(45)] 
		[RED("scanBlackboard")] 
		public CHandle<gameIBlackboard> ScanBlackboard
		{
			get => GetProperty(ref _scanBlackboard);
			set => SetProperty(ref _scanBlackboard, value);
		}

		[Ordinal(46)] 
		[RED("psmBlackboard")] 
		public CHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetProperty(ref _psmBlackboard);
			set => SetProperty(ref _psmBlackboard, value);
		}

		[Ordinal(47)] 
		[RED("BBID_ScanObject")] 
		public CUInt32 BBID_ScanObject
		{
			get => GetProperty(ref _bBID_ScanObject);
			set => SetProperty(ref _bBID_ScanObject, value);
		}

		[Ordinal(48)] 
		[RED("BBID_ScanObject_Data")] 
		public CUInt32 BBID_ScanObject_Data
		{
			get => GetProperty(ref _bBID_ScanObject_Data);
			set => SetProperty(ref _bBID_ScanObject_Data, value);
		}

		[Ordinal(49)] 
		[RED("BBID_ScanObject_Position")] 
		public CUInt32 BBID_ScanObject_Position
		{
			get => GetProperty(ref _bBID_ScanObject_Position);
			set => SetProperty(ref _bBID_ScanObject_Position, value);
		}

		[Ordinal(50)] 
		[RED("BBID_ScanState")] 
		public CUInt32 BBID_ScanState
		{
			get => GetProperty(ref _bBID_ScanState);
			set => SetProperty(ref _bBID_ScanState, value);
		}

		[Ordinal(51)] 
		[RED("BBID_ProgressNum")] 
		public CUInt32 BBID_ProgressNum
		{
			get => GetProperty(ref _bBID_ProgressNum);
			set => SetProperty(ref _bBID_ProgressNum, value);
		}

		[Ordinal(52)] 
		[RED("BBID_ProgressText")] 
		public CUInt32 BBID_ProgressText
		{
			get => GetProperty(ref _bBID_ProgressText);
			set => SetProperty(ref _bBID_ProgressText, value);
		}

		[Ordinal(53)] 
		[RED("BBID_ExclusiveFocus")] 
		public CUInt32 BBID_ExclusiveFocus
		{
			get => GetProperty(ref _bBID_ExclusiveFocus);
			set => SetProperty(ref _bBID_ExclusiveFocus, value);
		}

		[Ordinal(54)] 
		[RED("PSM_BBID")] 
		public CUInt32 PSM_BBID
		{
			get => GetProperty(ref _pSM_BBID);
			set => SetProperty(ref _pSM_BBID, value);
		}

		[Ordinal(55)] 
		[RED("VisionStateBlackboardId")] 
		public CUInt32 VisionStateBlackboardId
		{
			get => GetProperty(ref _visionStateBlackboardId);
			set => SetProperty(ref _visionStateBlackboardId, value);
		}

		public scannerBorderGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
