using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameScanningComponent : gameComponent
	{
		private CArray<gameScanningTooltipElementDef> _scannableData;
		private CFloat _timeNeeded;
		private CBool _autoGenerateBoundingSphere;
		private Sphere _boundingSphere;
		private CBool _ignoresScanningDistanceLimit;
		private CBool _cpoEnableMultiplePlayersScanningModifier;
		private CBool _isBraindanceClue;
		private CEnum<braindanceVisionMode> _braindanceLayer;
		private CBool _isBraindanceBlocked;
		private CBool _isBraindanceLayerUnlocked;
		private CBool _isBraindanceTimelineUnlocked;
		private CBool _isBraindanceActive;
		private CInt32 _currentBraindanceLayer;
		private CArray<FocusClueDefinition> _clues;
		private CHandle<ObjectScanningDescription> _objectDescription;
		private TweakDBID _scanningBarText;
		private CBool _isFocusModeActive;
		private CHandle<FocusForcedHighlightData> _currentHighlight;
		private CBool _isHudManagerInitialized;
		private CBool _isBeingScanned;
		private CBool _isScanningCluesBlocked;
		private CBool _isEntityVisible;
		private CHandle<redCallbackObject> _onBraindanceVisionModeChangeCallback;
		private CHandle<redCallbackObject> _onBraindanceFppChangeCallback;

		[Ordinal(4)] 
		[RED("scannableData")] 
		public CArray<gameScanningTooltipElementDef> ScannableData
		{
			get => GetProperty(ref _scannableData);
			set => SetProperty(ref _scannableData, value);
		}

		[Ordinal(5)] 
		[RED("timeNeeded")] 
		public CFloat TimeNeeded
		{
			get => GetProperty(ref _timeNeeded);
			set => SetProperty(ref _timeNeeded, value);
		}

		[Ordinal(6)] 
		[RED("autoGenerateBoundingSphere")] 
		public CBool AutoGenerateBoundingSphere
		{
			get => GetProperty(ref _autoGenerateBoundingSphere);
			set => SetProperty(ref _autoGenerateBoundingSphere, value);
		}

		[Ordinal(7)] 
		[RED("boundingSphere")] 
		public Sphere BoundingSphere
		{
			get => GetProperty(ref _boundingSphere);
			set => SetProperty(ref _boundingSphere, value);
		}

		[Ordinal(8)] 
		[RED("ignoresScanningDistanceLimit")] 
		public CBool IgnoresScanningDistanceLimit
		{
			get => GetProperty(ref _ignoresScanningDistanceLimit);
			set => SetProperty(ref _ignoresScanningDistanceLimit, value);
		}

		[Ordinal(9)] 
		[RED("cpoEnableMultiplePlayersScanningModifier")] 
		public CBool CpoEnableMultiplePlayersScanningModifier
		{
			get => GetProperty(ref _cpoEnableMultiplePlayersScanningModifier);
			set => SetProperty(ref _cpoEnableMultiplePlayersScanningModifier, value);
		}

		[Ordinal(10)] 
		[RED("isBraindanceClue")] 
		public CBool IsBraindanceClue
		{
			get => GetProperty(ref _isBraindanceClue);
			set => SetProperty(ref _isBraindanceClue, value);
		}

		[Ordinal(11)] 
		[RED("BraindanceLayer")] 
		public CEnum<braindanceVisionMode> BraindanceLayer
		{
			get => GetProperty(ref _braindanceLayer);
			set => SetProperty(ref _braindanceLayer, value);
		}

		[Ordinal(12)] 
		[RED("isBraindanceBlocked")] 
		public CBool IsBraindanceBlocked
		{
			get => GetProperty(ref _isBraindanceBlocked);
			set => SetProperty(ref _isBraindanceBlocked, value);
		}

		[Ordinal(13)] 
		[RED("isBraindanceLayerUnlocked")] 
		public CBool IsBraindanceLayerUnlocked
		{
			get => GetProperty(ref _isBraindanceLayerUnlocked);
			set => SetProperty(ref _isBraindanceLayerUnlocked, value);
		}

		[Ordinal(14)] 
		[RED("isBraindanceTimelineUnlocked")] 
		public CBool IsBraindanceTimelineUnlocked
		{
			get => GetProperty(ref _isBraindanceTimelineUnlocked);
			set => SetProperty(ref _isBraindanceTimelineUnlocked, value);
		}

		[Ordinal(15)] 
		[RED("isBraindanceActive")] 
		public CBool IsBraindanceActive
		{
			get => GetProperty(ref _isBraindanceActive);
			set => SetProperty(ref _isBraindanceActive, value);
		}

		[Ordinal(16)] 
		[RED("currentBraindanceLayer")] 
		public CInt32 CurrentBraindanceLayer
		{
			get => GetProperty(ref _currentBraindanceLayer);
			set => SetProperty(ref _currentBraindanceLayer, value);
		}

		[Ordinal(17)] 
		[RED("clues")] 
		public CArray<FocusClueDefinition> Clues
		{
			get => GetProperty(ref _clues);
			set => SetProperty(ref _clues, value);
		}

		[Ordinal(18)] 
		[RED("objectDescription")] 
		public CHandle<ObjectScanningDescription> ObjectDescription
		{
			get => GetProperty(ref _objectDescription);
			set => SetProperty(ref _objectDescription, value);
		}

		[Ordinal(19)] 
		[RED("scanningBarText")] 
		public TweakDBID ScanningBarText
		{
			get => GetProperty(ref _scanningBarText);
			set => SetProperty(ref _scanningBarText, value);
		}

		[Ordinal(20)] 
		[RED("isFocusModeActive")] 
		public CBool IsFocusModeActive
		{
			get => GetProperty(ref _isFocusModeActive);
			set => SetProperty(ref _isFocusModeActive, value);
		}

		[Ordinal(21)] 
		[RED("currentHighlight")] 
		public CHandle<FocusForcedHighlightData> CurrentHighlight
		{
			get => GetProperty(ref _currentHighlight);
			set => SetProperty(ref _currentHighlight, value);
		}

		[Ordinal(22)] 
		[RED("isHudManagerInitialized")] 
		public CBool IsHudManagerInitialized
		{
			get => GetProperty(ref _isHudManagerInitialized);
			set => SetProperty(ref _isHudManagerInitialized, value);
		}

		[Ordinal(23)] 
		[RED("isBeingScanned")] 
		public CBool IsBeingScanned
		{
			get => GetProperty(ref _isBeingScanned);
			set => SetProperty(ref _isBeingScanned, value);
		}

		[Ordinal(24)] 
		[RED("isScanningCluesBlocked")] 
		public CBool IsScanningCluesBlocked
		{
			get => GetProperty(ref _isScanningCluesBlocked);
			set => SetProperty(ref _isScanningCluesBlocked, value);
		}

		[Ordinal(25)] 
		[RED("isEntityVisible")] 
		public CBool IsEntityVisible
		{
			get => GetProperty(ref _isEntityVisible);
			set => SetProperty(ref _isEntityVisible, value);
		}

		[Ordinal(26)] 
		[RED("OnBraindanceVisionModeChangeCallback")] 
		public CHandle<redCallbackObject> OnBraindanceVisionModeChangeCallback
		{
			get => GetProperty(ref _onBraindanceVisionModeChangeCallback);
			set => SetProperty(ref _onBraindanceVisionModeChangeCallback, value);
		}

		[Ordinal(27)] 
		[RED("OnBraindanceFppChangeCallback")] 
		public CHandle<redCallbackObject> OnBraindanceFppChangeCallback
		{
			get => GetProperty(ref _onBraindanceFppChangeCallback);
			set => SetProperty(ref _onBraindanceFppChangeCallback, value);
		}

		public gameScanningComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
