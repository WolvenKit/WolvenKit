using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scannerBorderGameController : gameuiProjectedHUDGameController
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
		private inkCompoundWidgetReference _scannerBarWidget;
		private inkTextWidgetReference _scannerBarFluffText;
		private inkImageWidgetReference _scannerBarFill;
		private CArray<inkWidgetReference> _deviceFluffs;
		private CHandle<inkanimProxy> _lockOnAnimProxy;
		private CHandle<inkanimProxy> _idleAnimProxy;
		private CHandle<inkanimProxy> _bracketsAppearAnimProxy;
		private CBool _lockOutAnimWasPlayed;
		private CWeakHandle<inkCompoundWidget> _root;
		private entEntityID _currentTarget;
		private CBool _isTakeControllActive;
		private CWeakHandle<gameObject> _ownerObject;
		private entEntityID _currentTargetBuffered;
		private scannerDataStructure _scannerData;
		private CBool _shouldShowScanner;
		private CBool _isFullyScanned;
		private CWeakHandle<ScannerCrosshairLogicController> _projectionLogicController;
		private Vector2 _originalScannerBarFillSize;
		private CHandle<inkanimProxy> _zoomUpAnim;
		private CHandle<inkanimProxy> _animLockOn;
		private CHandle<inkanimProxy> _zoomDownAnim;
		private CHandle<inkanimProxy> _animLockOff;
		private CHandle<inkanimProxy> _exclusiveFocusAnim;
		private CBool _isExclusiveFocus;
		private CFloat _argZoomBuffered;
		private CArray<CWeakHandle<inkImageWidget>> _squares;
		private CArray<CWeakHandle<inkImageWidget>> _squaresFilled;
		private CWeakHandle<gameIBlackboard> _scanBlackboard;
		private CWeakHandle<gameIBlackboard> _psmBlackboard;
		private CWeakHandle<gameIBlackboard> _tcsBlackboard;
		private CHandle<redCallbackObject> _bBID_ScanObject;
		private CHandle<redCallbackObject> _bBID_ScanObject_Data;
		private CHandle<redCallbackObject> _bBID_ScanObject_Position;
		private CHandle<redCallbackObject> _bBID_ScanState;
		private CHandle<redCallbackObject> _bBID_ProgressNum;
		private CHandle<redCallbackObject> _bBID_ProgressText;
		private CHandle<redCallbackObject> _bBID_ExclusiveFocus;
		private CHandle<redCallbackObject> _pSM_BBID;
		private CHandle<redCallbackObject> _tcs_BBID;
		private CHandle<redCallbackObject> _visionStateBlackboardId;

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
		[RED("scannerBarWidget")] 
		public inkCompoundWidgetReference ScannerBarWidget
		{
			get => GetProperty(ref _scannerBarWidget);
			set => SetProperty(ref _scannerBarWidget, value);
		}

		[Ordinal(21)] 
		[RED("scannerBarFluffText")] 
		public inkTextWidgetReference ScannerBarFluffText
		{
			get => GetProperty(ref _scannerBarFluffText);
			set => SetProperty(ref _scannerBarFluffText, value);
		}

		[Ordinal(22)] 
		[RED("scannerBarFill")] 
		public inkImageWidgetReference ScannerBarFill
		{
			get => GetProperty(ref _scannerBarFill);
			set => SetProperty(ref _scannerBarFill, value);
		}

		[Ordinal(23)] 
		[RED("deviceFluffs")] 
		public CArray<inkWidgetReference> DeviceFluffs
		{
			get => GetProperty(ref _deviceFluffs);
			set => SetProperty(ref _deviceFluffs, value);
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
		public CWeakHandle<inkCompoundWidget> Root
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
		[RED("isTakeControllActive")] 
		public CBool IsTakeControllActive
		{
			get => GetProperty(ref _isTakeControllActive);
			set => SetProperty(ref _isTakeControllActive, value);
		}

		[Ordinal(31)] 
		[RED("ownerObject")] 
		public CWeakHandle<gameObject> OwnerObject
		{
			get => GetProperty(ref _ownerObject);
			set => SetProperty(ref _ownerObject, value);
		}

		[Ordinal(32)] 
		[RED("currentTargetBuffered")] 
		public entEntityID CurrentTargetBuffered
		{
			get => GetProperty(ref _currentTargetBuffered);
			set => SetProperty(ref _currentTargetBuffered, value);
		}

		[Ordinal(33)] 
		[RED("scannerData")] 
		public scannerDataStructure ScannerData
		{
			get => GetProperty(ref _scannerData);
			set => SetProperty(ref _scannerData, value);
		}

		[Ordinal(34)] 
		[RED("shouldShowScanner")] 
		public CBool ShouldShowScanner
		{
			get => GetProperty(ref _shouldShowScanner);
			set => SetProperty(ref _shouldShowScanner, value);
		}

		[Ordinal(35)] 
		[RED("isFullyScanned")] 
		public CBool IsFullyScanned
		{
			get => GetProperty(ref _isFullyScanned);
			set => SetProperty(ref _isFullyScanned, value);
		}

		[Ordinal(36)] 
		[RED("ProjectionLogicController")] 
		public CWeakHandle<ScannerCrosshairLogicController> ProjectionLogicController
		{
			get => GetProperty(ref _projectionLogicController);
			set => SetProperty(ref _projectionLogicController, value);
		}

		[Ordinal(37)] 
		[RED("OriginalScannerBarFillSize")] 
		public Vector2 OriginalScannerBarFillSize
		{
			get => GetProperty(ref _originalScannerBarFillSize);
			set => SetProperty(ref _originalScannerBarFillSize, value);
		}

		[Ordinal(38)] 
		[RED("zoomUpAnim")] 
		public CHandle<inkanimProxy> ZoomUpAnim
		{
			get => GetProperty(ref _zoomUpAnim);
			set => SetProperty(ref _zoomUpAnim, value);
		}

		[Ordinal(39)] 
		[RED("animLockOn")] 
		public CHandle<inkanimProxy> AnimLockOn
		{
			get => GetProperty(ref _animLockOn);
			set => SetProperty(ref _animLockOn, value);
		}

		[Ordinal(40)] 
		[RED("zoomDownAnim")] 
		public CHandle<inkanimProxy> ZoomDownAnim
		{
			get => GetProperty(ref _zoomDownAnim);
			set => SetProperty(ref _zoomDownAnim, value);
		}

		[Ordinal(41)] 
		[RED("animLockOff")] 
		public CHandle<inkanimProxy> AnimLockOff
		{
			get => GetProperty(ref _animLockOff);
			set => SetProperty(ref _animLockOff, value);
		}

		[Ordinal(42)] 
		[RED("exclusiveFocusAnim")] 
		public CHandle<inkanimProxy> ExclusiveFocusAnim
		{
			get => GetProperty(ref _exclusiveFocusAnim);
			set => SetProperty(ref _exclusiveFocusAnim, value);
		}

		[Ordinal(43)] 
		[RED("isExclusiveFocus")] 
		public CBool IsExclusiveFocus
		{
			get => GetProperty(ref _isExclusiveFocus);
			set => SetProperty(ref _isExclusiveFocus, value);
		}

		[Ordinal(44)] 
		[RED("argZoomBuffered")] 
		public CFloat ArgZoomBuffered
		{
			get => GetProperty(ref _argZoomBuffered);
			set => SetProperty(ref _argZoomBuffered, value);
		}

		[Ordinal(45)] 
		[RED("squares")] 
		public CArray<CWeakHandle<inkImageWidget>> Squares
		{
			get => GetProperty(ref _squares);
			set => SetProperty(ref _squares, value);
		}

		[Ordinal(46)] 
		[RED("squaresFilled")] 
		public CArray<CWeakHandle<inkImageWidget>> SquaresFilled
		{
			get => GetProperty(ref _squaresFilled);
			set => SetProperty(ref _squaresFilled, value);
		}

		[Ordinal(47)] 
		[RED("scanBlackboard")] 
		public CWeakHandle<gameIBlackboard> ScanBlackboard
		{
			get => GetProperty(ref _scanBlackboard);
			set => SetProperty(ref _scanBlackboard, value);
		}

		[Ordinal(48)] 
		[RED("psmBlackboard")] 
		public CWeakHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetProperty(ref _psmBlackboard);
			set => SetProperty(ref _psmBlackboard, value);
		}

		[Ordinal(49)] 
		[RED("tcsBlackboard")] 
		public CWeakHandle<gameIBlackboard> TcsBlackboard
		{
			get => GetProperty(ref _tcsBlackboard);
			set => SetProperty(ref _tcsBlackboard, value);
		}

		[Ordinal(50)] 
		[RED("BBID_ScanObject")] 
		public CHandle<redCallbackObject> BBID_ScanObject
		{
			get => GetProperty(ref _bBID_ScanObject);
			set => SetProperty(ref _bBID_ScanObject, value);
		}

		[Ordinal(51)] 
		[RED("BBID_ScanObject_Data")] 
		public CHandle<redCallbackObject> BBID_ScanObject_Data
		{
			get => GetProperty(ref _bBID_ScanObject_Data);
			set => SetProperty(ref _bBID_ScanObject_Data, value);
		}

		[Ordinal(52)] 
		[RED("BBID_ScanObject_Position")] 
		public CHandle<redCallbackObject> BBID_ScanObject_Position
		{
			get => GetProperty(ref _bBID_ScanObject_Position);
			set => SetProperty(ref _bBID_ScanObject_Position, value);
		}

		[Ordinal(53)] 
		[RED("BBID_ScanState")] 
		public CHandle<redCallbackObject> BBID_ScanState
		{
			get => GetProperty(ref _bBID_ScanState);
			set => SetProperty(ref _bBID_ScanState, value);
		}

		[Ordinal(54)] 
		[RED("BBID_ProgressNum")] 
		public CHandle<redCallbackObject> BBID_ProgressNum
		{
			get => GetProperty(ref _bBID_ProgressNum);
			set => SetProperty(ref _bBID_ProgressNum, value);
		}

		[Ordinal(55)] 
		[RED("BBID_ProgressText")] 
		public CHandle<redCallbackObject> BBID_ProgressText
		{
			get => GetProperty(ref _bBID_ProgressText);
			set => SetProperty(ref _bBID_ProgressText, value);
		}

		[Ordinal(56)] 
		[RED("BBID_ExclusiveFocus")] 
		public CHandle<redCallbackObject> BBID_ExclusiveFocus
		{
			get => GetProperty(ref _bBID_ExclusiveFocus);
			set => SetProperty(ref _bBID_ExclusiveFocus, value);
		}

		[Ordinal(57)] 
		[RED("PSM_BBID")] 
		public CHandle<redCallbackObject> PSM_BBID
		{
			get => GetProperty(ref _pSM_BBID);
			set => SetProperty(ref _pSM_BBID, value);
		}

		[Ordinal(58)] 
		[RED("tcs_BBID")] 
		public CHandle<redCallbackObject> Tcs_BBID
		{
			get => GetProperty(ref _tcs_BBID);
			set => SetProperty(ref _tcs_BBID, value);
		}

		[Ordinal(59)] 
		[RED("VisionStateBlackboardId")] 
		public CHandle<redCallbackObject> VisionStateBlackboardId
		{
			get => GetProperty(ref _visionStateBlackboardId);
			set => SetProperty(ref _visionStateBlackboardId, value);
		}
	}
}
