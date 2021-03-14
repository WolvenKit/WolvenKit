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
			get
			{
				if (_zoomMovingContainer == null)
				{
					_zoomMovingContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "ZoomMovingContainer", cr2w, this);
				}
				return _zoomMovingContainer;
			}
			set
			{
				if (_zoomMovingContainer == value)
				{
					return;
				}
				_zoomMovingContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("DistanceMovingContainer")] 
		public inkCompoundWidgetReference DistanceMovingContainer
		{
			get
			{
				if (_distanceMovingContainer == null)
				{
					_distanceMovingContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "DistanceMovingContainer", cr2w, this);
				}
				return _distanceMovingContainer;
			}
			set
			{
				if (_distanceMovingContainer == value)
				{
					return;
				}
				_distanceMovingContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("DistanceParentContainer")] 
		public inkCompoundWidgetReference DistanceParentContainer
		{
			get
			{
				if (_distanceParentContainer == null)
				{
					_distanceParentContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "DistanceParentContainer", cr2w, this);
				}
				return _distanceParentContainer;
			}
			set
			{
				if (_distanceParentContainer == value)
				{
					return;
				}
				_distanceParentContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("CrosshairProjection")] 
		public inkCompoundWidgetReference CrosshairProjection
		{
			get
			{
				if (_crosshairProjection == null)
				{
					_crosshairProjection = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "CrosshairProjection", cr2w, this);
				}
				return _crosshairProjection;
			}
			set
			{
				if (_crosshairProjection == value)
				{
					return;
				}
				_crosshairProjection = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("loadingBarCanvas")] 
		public inkCompoundWidgetReference LoadingBarCanvas
		{
			get
			{
				if (_loadingBarCanvas == null)
				{
					_loadingBarCanvas = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "loadingBarCanvas", cr2w, this);
				}
				return _loadingBarCanvas;
			}
			set
			{
				if (_loadingBarCanvas == value)
				{
					return;
				}
				_loadingBarCanvas = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("crosshairContainer")] 
		public inkCompoundWidgetReference CrosshairContainer
		{
			get
			{
				if (_crosshairContainer == null)
				{
					_crosshairContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "crosshairContainer", cr2w, this);
				}
				return _crosshairContainer;
			}
			set
			{
				if (_crosshairContainer == value)
				{
					return;
				}
				_crosshairContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("ZoomNumber")] 
		public inkTextWidgetReference ZoomNumber
		{
			get
			{
				if (_zoomNumber == null)
				{
					_zoomNumber = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "ZoomNumber", cr2w, this);
				}
				return _zoomNumber;
			}
			set
			{
				if (_zoomNumber == value)
				{
					return;
				}
				_zoomNumber = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("DistanceNumber")] 
		public inkTextWidgetReference DistanceNumber
		{
			get
			{
				if (_distanceNumber == null)
				{
					_distanceNumber = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "DistanceNumber", cr2w, this);
				}
				return _distanceNumber;
			}
			set
			{
				if (_distanceNumber == value)
				{
					return;
				}
				_distanceNumber = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("DistanceImageRuler")] 
		public inkImageWidgetReference DistanceImageRuler
		{
			get
			{
				if (_distanceImageRuler == null)
				{
					_distanceImageRuler = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "DistanceImageRuler", cr2w, this);
				}
				return _distanceImageRuler;
			}
			set
			{
				if (_distanceImageRuler == value)
				{
					return;
				}
				_distanceImageRuler = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("ZoomMoveBracketL")] 
		public inkImageWidgetReference ZoomMoveBracketL
		{
			get
			{
				if (_zoomMoveBracketL == null)
				{
					_zoomMoveBracketL = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "ZoomMoveBracketL", cr2w, this);
				}
				return _zoomMoveBracketL;
			}
			set
			{
				if (_zoomMoveBracketL == value)
				{
					return;
				}
				_zoomMoveBracketL = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("ZoomMoveBracketR")] 
		public inkImageWidgetReference ZoomMoveBracketR
		{
			get
			{
				if (_zoomMoveBracketR == null)
				{
					_zoomMoveBracketR = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "ZoomMoveBracketR", cr2w, this);
				}
				return _zoomMoveBracketR;
			}
			set
			{
				if (_zoomMoveBracketR == value)
				{
					return;
				}
				_zoomMoveBracketR = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("insideCrosshair")] 
		public inkCompoundWidgetReference InsideCrosshair
		{
			get
			{
				if (_insideCrosshair == null)
				{
					_insideCrosshair = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "insideCrosshair", cr2w, this);
				}
				return _insideCrosshair;
			}
			set
			{
				if (_insideCrosshair == value)
				{
					return;
				}
				_insideCrosshair = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("scannerBarWidget")] 
		public inkCompoundWidgetReference ScannerBarWidget
		{
			get
			{
				if (_scannerBarWidget == null)
				{
					_scannerBarWidget = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "scannerBarWidget", cr2w, this);
				}
				return _scannerBarWidget;
			}
			set
			{
				if (_scannerBarWidget == value)
				{
					return;
				}
				_scannerBarWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("scannerBarFluffText")] 
		public inkTextWidgetReference ScannerBarFluffText
		{
			get
			{
				if (_scannerBarFluffText == null)
				{
					_scannerBarFluffText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "scannerBarFluffText", cr2w, this);
				}
				return _scannerBarFluffText;
			}
			set
			{
				if (_scannerBarFluffText == value)
				{
					return;
				}
				_scannerBarFluffText = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("scannerBarFill")] 
		public inkImageWidgetReference ScannerBarFill
		{
			get
			{
				if (_scannerBarFill == null)
				{
					_scannerBarFill = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "scannerBarFill", cr2w, this);
				}
				return _scannerBarFill;
			}
			set
			{
				if (_scannerBarFill == value)
				{
					return;
				}
				_scannerBarFill = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("LockOnAnimProxy")] 
		public CHandle<inkanimProxy> LockOnAnimProxy
		{
			get
			{
				if (_lockOnAnimProxy == null)
				{
					_lockOnAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "LockOnAnimProxy", cr2w, this);
				}
				return _lockOnAnimProxy;
			}
			set
			{
				if (_lockOnAnimProxy == value)
				{
					return;
				}
				_lockOnAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("IdleAnimProxy")] 
		public CHandle<inkanimProxy> IdleAnimProxy
		{
			get
			{
				if (_idleAnimProxy == null)
				{
					_idleAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "IdleAnimProxy", cr2w, this);
				}
				return _idleAnimProxy;
			}
			set
			{
				if (_idleAnimProxy == value)
				{
					return;
				}
				_idleAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("BracketsAppearAnimProxy")] 
		public CHandle<inkanimProxy> BracketsAppearAnimProxy
		{
			get
			{
				if (_bracketsAppearAnimProxy == null)
				{
					_bracketsAppearAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "BracketsAppearAnimProxy", cr2w, this);
				}
				return _bracketsAppearAnimProxy;
			}
			set
			{
				if (_bracketsAppearAnimProxy == value)
				{
					return;
				}
				_bracketsAppearAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("lockOutAnimWasPlayed")] 
		public CBool LockOutAnimWasPlayed
		{
			get
			{
				if (_lockOutAnimWasPlayed == null)
				{
					_lockOutAnimWasPlayed = (CBool) CR2WTypeManager.Create("Bool", "lockOutAnimWasPlayed", cr2w, this);
				}
				return _lockOutAnimWasPlayed;
			}
			set
			{
				if (_lockOutAnimWasPlayed == value)
				{
					return;
				}
				_lockOutAnimWasPlayed = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("root")] 
		public wCHandle<inkCompoundWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkCompoundWidget>) CR2WTypeManager.Create("whandle:inkCompoundWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("currentTarget")] 
		public entEntityID CurrentTarget
		{
			get
			{
				if (_currentTarget == null)
				{
					_currentTarget = (entEntityID) CR2WTypeManager.Create("entEntityID", "currentTarget", cr2w, this);
				}
				return _currentTarget;
			}
			set
			{
				if (_currentTarget == value)
				{
					return;
				}
				_currentTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("currentTargetBuffered")] 
		public entEntityID CurrentTargetBuffered
		{
			get
			{
				if (_currentTargetBuffered == null)
				{
					_currentTargetBuffered = (entEntityID) CR2WTypeManager.Create("entEntityID", "currentTargetBuffered", cr2w, this);
				}
				return _currentTargetBuffered;
			}
			set
			{
				if (_currentTargetBuffered == value)
				{
					return;
				}
				_currentTargetBuffered = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("scannerData")] 
		public scannerDataStructure ScannerData
		{
			get
			{
				if (_scannerData == null)
				{
					_scannerData = (scannerDataStructure) CR2WTypeManager.Create("scannerDataStructure", "scannerData", cr2w, this);
				}
				return _scannerData;
			}
			set
			{
				if (_scannerData == value)
				{
					return;
				}
				_scannerData = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("shouldShowScanner")] 
		public CBool ShouldShowScanner
		{
			get
			{
				if (_shouldShowScanner == null)
				{
					_shouldShowScanner = (CBool) CR2WTypeManager.Create("Bool", "shouldShowScanner", cr2w, this);
				}
				return _shouldShowScanner;
			}
			set
			{
				if (_shouldShowScanner == value)
				{
					return;
				}
				_shouldShowScanner = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("isFullyScanned")] 
		public CBool IsFullyScanned
		{
			get
			{
				if (_isFullyScanned == null)
				{
					_isFullyScanned = (CBool) CR2WTypeManager.Create("Bool", "isFullyScanned", cr2w, this);
				}
				return _isFullyScanned;
			}
			set
			{
				if (_isFullyScanned == value)
				{
					return;
				}
				_isFullyScanned = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("ProjectionLogicController")] 
		public wCHandle<ScannerCrosshairLogicController> ProjectionLogicController
		{
			get
			{
				if (_projectionLogicController == null)
				{
					_projectionLogicController = (wCHandle<ScannerCrosshairLogicController>) CR2WTypeManager.Create("whandle:ScannerCrosshairLogicController", "ProjectionLogicController", cr2w, this);
				}
				return _projectionLogicController;
			}
			set
			{
				if (_projectionLogicController == value)
				{
					return;
				}
				_projectionLogicController = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("OriginalScannerBarFillSize")] 
		public Vector2 OriginalScannerBarFillSize
		{
			get
			{
				if (_originalScannerBarFillSize == null)
				{
					_originalScannerBarFillSize = (Vector2) CR2WTypeManager.Create("Vector2", "OriginalScannerBarFillSize", cr2w, this);
				}
				return _originalScannerBarFillSize;
			}
			set
			{
				if (_originalScannerBarFillSize == value)
				{
					return;
				}
				_originalScannerBarFillSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("zoomUpAnim")] 
		public CHandle<inkanimProxy> ZoomUpAnim
		{
			get
			{
				if (_zoomUpAnim == null)
				{
					_zoomUpAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "zoomUpAnim", cr2w, this);
				}
				return _zoomUpAnim;
			}
			set
			{
				if (_zoomUpAnim == value)
				{
					return;
				}
				_zoomUpAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("animLockOn")] 
		public CHandle<inkanimProxy> AnimLockOn
		{
			get
			{
				if (_animLockOn == null)
				{
					_animLockOn = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animLockOn", cr2w, this);
				}
				return _animLockOn;
			}
			set
			{
				if (_animLockOn == value)
				{
					return;
				}
				_animLockOn = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("zoomDownAnim")] 
		public CHandle<inkanimProxy> ZoomDownAnim
		{
			get
			{
				if (_zoomDownAnim == null)
				{
					_zoomDownAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "zoomDownAnim", cr2w, this);
				}
				return _zoomDownAnim;
			}
			set
			{
				if (_zoomDownAnim == value)
				{
					return;
				}
				_zoomDownAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("animLockOff")] 
		public CHandle<inkanimProxy> AnimLockOff
		{
			get
			{
				if (_animLockOff == null)
				{
					_animLockOff = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animLockOff", cr2w, this);
				}
				return _animLockOff;
			}
			set
			{
				if (_animLockOff == value)
				{
					return;
				}
				_animLockOff = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("exclusiveFocusAnim")] 
		public CHandle<inkanimProxy> ExclusiveFocusAnim
		{
			get
			{
				if (_exclusiveFocusAnim == null)
				{
					_exclusiveFocusAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "exclusiveFocusAnim", cr2w, this);
				}
				return _exclusiveFocusAnim;
			}
			set
			{
				if (_exclusiveFocusAnim == value)
				{
					return;
				}
				_exclusiveFocusAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("isExclusiveFocus")] 
		public CBool IsExclusiveFocus
		{
			get
			{
				if (_isExclusiveFocus == null)
				{
					_isExclusiveFocus = (CBool) CR2WTypeManager.Create("Bool", "isExclusiveFocus", cr2w, this);
				}
				return _isExclusiveFocus;
			}
			set
			{
				if (_isExclusiveFocus == value)
				{
					return;
				}
				_isExclusiveFocus = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("argZoomBuffered")] 
		public CFloat ArgZoomBuffered
		{
			get
			{
				if (_argZoomBuffered == null)
				{
					_argZoomBuffered = (CFloat) CR2WTypeManager.Create("Float", "argZoomBuffered", cr2w, this);
				}
				return _argZoomBuffered;
			}
			set
			{
				if (_argZoomBuffered == value)
				{
					return;
				}
				_argZoomBuffered = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("squares")] 
		public CArray<wCHandle<inkImageWidget>> Squares
		{
			get
			{
				if (_squares == null)
				{
					_squares = (CArray<wCHandle<inkImageWidget>>) CR2WTypeManager.Create("array:whandle:inkImageWidget", "squares", cr2w, this);
				}
				return _squares;
			}
			set
			{
				if (_squares == value)
				{
					return;
				}
				_squares = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("squaresFilled")] 
		public CArray<wCHandle<inkImageWidget>> SquaresFilled
		{
			get
			{
				if (_squaresFilled == null)
				{
					_squaresFilled = (CArray<wCHandle<inkImageWidget>>) CR2WTypeManager.Create("array:whandle:inkImageWidget", "squaresFilled", cr2w, this);
				}
				return _squaresFilled;
			}
			set
			{
				if (_squaresFilled == value)
				{
					return;
				}
				_squaresFilled = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("scanBlackboard")] 
		public CHandle<gameIBlackboard> ScanBlackboard
		{
			get
			{
				if (_scanBlackboard == null)
				{
					_scanBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "scanBlackboard", cr2w, this);
				}
				return _scanBlackboard;
			}
			set
			{
				if (_scanBlackboard == value)
				{
					return;
				}
				_scanBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("psmBlackboard")] 
		public CHandle<gameIBlackboard> PsmBlackboard
		{
			get
			{
				if (_psmBlackboard == null)
				{
					_psmBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "psmBlackboard", cr2w, this);
				}
				return _psmBlackboard;
			}
			set
			{
				if (_psmBlackboard == value)
				{
					return;
				}
				_psmBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("BBID_ScanObject")] 
		public CUInt32 BBID_ScanObject
		{
			get
			{
				if (_bBID_ScanObject == null)
				{
					_bBID_ScanObject = (CUInt32) CR2WTypeManager.Create("Uint32", "BBID_ScanObject", cr2w, this);
				}
				return _bBID_ScanObject;
			}
			set
			{
				if (_bBID_ScanObject == value)
				{
					return;
				}
				_bBID_ScanObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("BBID_ScanObject_Data")] 
		public CUInt32 BBID_ScanObject_Data
		{
			get
			{
				if (_bBID_ScanObject_Data == null)
				{
					_bBID_ScanObject_Data = (CUInt32) CR2WTypeManager.Create("Uint32", "BBID_ScanObject_Data", cr2w, this);
				}
				return _bBID_ScanObject_Data;
			}
			set
			{
				if (_bBID_ScanObject_Data == value)
				{
					return;
				}
				_bBID_ScanObject_Data = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("BBID_ScanObject_Position")] 
		public CUInt32 BBID_ScanObject_Position
		{
			get
			{
				if (_bBID_ScanObject_Position == null)
				{
					_bBID_ScanObject_Position = (CUInt32) CR2WTypeManager.Create("Uint32", "BBID_ScanObject_Position", cr2w, this);
				}
				return _bBID_ScanObject_Position;
			}
			set
			{
				if (_bBID_ScanObject_Position == value)
				{
					return;
				}
				_bBID_ScanObject_Position = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("BBID_ScanState")] 
		public CUInt32 BBID_ScanState
		{
			get
			{
				if (_bBID_ScanState == null)
				{
					_bBID_ScanState = (CUInt32) CR2WTypeManager.Create("Uint32", "BBID_ScanState", cr2w, this);
				}
				return _bBID_ScanState;
			}
			set
			{
				if (_bBID_ScanState == value)
				{
					return;
				}
				_bBID_ScanState = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("BBID_ProgressNum")] 
		public CUInt32 BBID_ProgressNum
		{
			get
			{
				if (_bBID_ProgressNum == null)
				{
					_bBID_ProgressNum = (CUInt32) CR2WTypeManager.Create("Uint32", "BBID_ProgressNum", cr2w, this);
				}
				return _bBID_ProgressNum;
			}
			set
			{
				if (_bBID_ProgressNum == value)
				{
					return;
				}
				_bBID_ProgressNum = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("BBID_ProgressText")] 
		public CUInt32 BBID_ProgressText
		{
			get
			{
				if (_bBID_ProgressText == null)
				{
					_bBID_ProgressText = (CUInt32) CR2WTypeManager.Create("Uint32", "BBID_ProgressText", cr2w, this);
				}
				return _bBID_ProgressText;
			}
			set
			{
				if (_bBID_ProgressText == value)
				{
					return;
				}
				_bBID_ProgressText = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("BBID_ExclusiveFocus")] 
		public CUInt32 BBID_ExclusiveFocus
		{
			get
			{
				if (_bBID_ExclusiveFocus == null)
				{
					_bBID_ExclusiveFocus = (CUInt32) CR2WTypeManager.Create("Uint32", "BBID_ExclusiveFocus", cr2w, this);
				}
				return _bBID_ExclusiveFocus;
			}
			set
			{
				if (_bBID_ExclusiveFocus == value)
				{
					return;
				}
				_bBID_ExclusiveFocus = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("PSM_BBID")] 
		public CUInt32 PSM_BBID
		{
			get
			{
				if (_pSM_BBID == null)
				{
					_pSM_BBID = (CUInt32) CR2WTypeManager.Create("Uint32", "PSM_BBID", cr2w, this);
				}
				return _pSM_BBID;
			}
			set
			{
				if (_pSM_BBID == value)
				{
					return;
				}
				_pSM_BBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("VisionStateBlackboardId")] 
		public CUInt32 VisionStateBlackboardId
		{
			get
			{
				if (_visionStateBlackboardId == null)
				{
					_visionStateBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "VisionStateBlackboardId", cr2w, this);
				}
				return _visionStateBlackboardId;
			}
			set
			{
				if (_visionStateBlackboardId == value)
				{
					return;
				}
				_visionStateBlackboardId = value;
				PropertySet(this);
			}
		}

		public scannerBorderGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
