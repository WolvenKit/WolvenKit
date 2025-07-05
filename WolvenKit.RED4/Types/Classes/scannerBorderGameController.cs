using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scannerBorderGameController : gameuiProjectedHUDGameController
	{
		[Ordinal(9)] 
		[RED("ZoomMovingContainer")] 
		public inkCompoundWidgetReference ZoomMovingContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("DistanceMovingContainer")] 
		public inkCompoundWidgetReference DistanceMovingContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("DistanceParentContainer")] 
		public inkCompoundWidgetReference DistanceParentContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("CrosshairProjection")] 
		public inkCompoundWidgetReference CrosshairProjection
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("loadingBarCanvas")] 
		public inkCompoundWidgetReference LoadingBarCanvas
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("crosshairContainer")] 
		public inkCompoundWidgetReference CrosshairContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("ZoomNumber")] 
		public inkTextWidgetReference ZoomNumber
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("DistanceNumber")] 
		public inkTextWidgetReference DistanceNumber
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("DistanceImageRuler")] 
		public inkImageWidgetReference DistanceImageRuler
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("ZoomMoveBracketL")] 
		public inkImageWidgetReference ZoomMoveBracketL
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("ZoomMoveBracketR")] 
		public inkImageWidgetReference ZoomMoveBracketR
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("scannerBarWidget")] 
		public inkCompoundWidgetReference ScannerBarWidget
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("scannerBarFluffText")] 
		public inkTextWidgetReference ScannerBarFluffText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("scannerBarFill")] 
		public inkImageWidgetReference ScannerBarFill
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("deviceFluffs")] 
		public CArray<inkWidgetReference> DeviceFluffs
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(24)] 
		[RED("LockOnAnimProxy")] 
		public CHandle<inkanimProxy> LockOnAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(25)] 
		[RED("IdleAnimProxy")] 
		public CHandle<inkanimProxy> IdleAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(26)] 
		[RED("BracketsAppearAnimProxy")] 
		public CHandle<inkanimProxy> BracketsAppearAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(27)] 
		[RED("lockOutAnimWasPlayed")] 
		public CBool LockOutAnimWasPlayed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("root")] 
		public CWeakHandle<inkCompoundWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(29)] 
		[RED("currentTarget")] 
		public entEntityID CurrentTarget
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(30)] 
		[RED("isTakeControllActive")] 
		public CBool IsTakeControllActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(31)] 
		[RED("ownerObject")] 
		public CWeakHandle<gameObject> OwnerObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(32)] 
		[RED("currentTargetBuffered")] 
		public entEntityID CurrentTargetBuffered
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(33)] 
		[RED("scannerData")] 
		public scannerDataStructure ScannerData
		{
			get => GetPropertyValue<scannerDataStructure>();
			set => SetPropertyValue<scannerDataStructure>(value);
		}

		[Ordinal(34)] 
		[RED("shouldShowScanner")] 
		public CBool ShouldShowScanner
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(35)] 
		[RED("isFullyScanned")] 
		public CBool IsFullyScanned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(36)] 
		[RED("ProjectionLogicController")] 
		public CWeakHandle<ScannerCrosshairLogicController> ProjectionLogicController
		{
			get => GetPropertyValue<CWeakHandle<ScannerCrosshairLogicController>>();
			set => SetPropertyValue<CWeakHandle<ScannerCrosshairLogicController>>(value);
		}

		[Ordinal(37)] 
		[RED("OriginalScannerBarFillSize")] 
		public Vector2 OriginalScannerBarFillSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(38)] 
		[RED("zoomUpAnim")] 
		public CHandle<inkanimProxy> ZoomUpAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(39)] 
		[RED("animLockOn")] 
		public CHandle<inkanimProxy> AnimLockOn
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(40)] 
		[RED("zoomDownAnim")] 
		public CHandle<inkanimProxy> ZoomDownAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(41)] 
		[RED("animLockOff")] 
		public CHandle<inkanimProxy> AnimLockOff
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(42)] 
		[RED("exclusiveFocusAnim")] 
		public CHandle<inkanimProxy> ExclusiveFocusAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(43)] 
		[RED("isExclusiveFocus")] 
		public CBool IsExclusiveFocus
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(44)] 
		[RED("argZoomBuffered")] 
		public CFloat ArgZoomBuffered
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(45)] 
		[RED("squares")] 
		public CArray<CWeakHandle<inkImageWidget>> Squares
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkImageWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkImageWidget>>>(value);
		}

		[Ordinal(46)] 
		[RED("squaresFilled")] 
		public CArray<CWeakHandle<inkImageWidget>> SquaresFilled
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkImageWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkImageWidget>>>(value);
		}

		[Ordinal(47)] 
		[RED("scanBlackboard")] 
		public CWeakHandle<gameIBlackboard> ScanBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(48)] 
		[RED("psmBlackboard")] 
		public CWeakHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(49)] 
		[RED("tcsBlackboard")] 
		public CWeakHandle<gameIBlackboard> TcsBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(50)] 
		[RED("BBID_ScanObject")] 
		public CHandle<redCallbackObject> BBID_ScanObject
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(51)] 
		[RED("BBID_ScanObject_Data")] 
		public CHandle<redCallbackObject> BBID_ScanObject_Data
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(52)] 
		[RED("BBID_ScanObject_Position")] 
		public CHandle<redCallbackObject> BBID_ScanObject_Position
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(53)] 
		[RED("BBID_ScanState")] 
		public CHandle<redCallbackObject> BBID_ScanState
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(54)] 
		[RED("BBID_ProgressNum")] 
		public CHandle<redCallbackObject> BBID_ProgressNum
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(55)] 
		[RED("BBID_ProgressText")] 
		public CHandle<redCallbackObject> BBID_ProgressText
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(56)] 
		[RED("BBID_ExclusiveFocus")] 
		public CHandle<redCallbackObject> BBID_ExclusiveFocus
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(57)] 
		[RED("PSM_BBID")] 
		public CHandle<redCallbackObject> PSM_BBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(58)] 
		[RED("tcs_BBID")] 
		public CHandle<redCallbackObject> Tcs_BBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(59)] 
		[RED("VisionStateBlackboardId")] 
		public CHandle<redCallbackObject> VisionStateBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public scannerBorderGameController()
		{
			ZoomMovingContainer = new inkCompoundWidgetReference();
			DistanceMovingContainer = new inkCompoundWidgetReference();
			DistanceParentContainer = new inkCompoundWidgetReference();
			CrosshairProjection = new inkCompoundWidgetReference();
			LoadingBarCanvas = new inkCompoundWidgetReference();
			CrosshairContainer = new inkCompoundWidgetReference();
			ZoomNumber = new inkTextWidgetReference();
			DistanceNumber = new inkTextWidgetReference();
			DistanceImageRuler = new inkImageWidgetReference();
			ZoomMoveBracketL = new inkImageWidgetReference();
			ZoomMoveBracketR = new inkImageWidgetReference();
			ScannerBarWidget = new inkCompoundWidgetReference();
			ScannerBarFluffText = new inkTextWidgetReference();
			ScannerBarFill = new inkImageWidgetReference();
			DeviceFluffs = new();
			CurrentTarget = new entEntityID();
			CurrentTargetBuffered = new entEntityID();
			ScannerData = new scannerDataStructure { QuestEntries = new() };
			OriginalScannerBarFillSize = new Vector2();
			Squares = new();
			SquaresFilled = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
