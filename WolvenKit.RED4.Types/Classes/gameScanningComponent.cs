using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameScanningComponent : gameComponent
	{
		[Ordinal(4)] 
		[RED("scannableData")] 
		public CArray<gameScanningTooltipElementDef> ScannableData
		{
			get => GetPropertyValue<CArray<gameScanningTooltipElementDef>>();
			set => SetPropertyValue<CArray<gameScanningTooltipElementDef>>(value);
		}

		[Ordinal(5)] 
		[RED("timeNeeded")] 
		public CFloat TimeNeeded
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("autoGenerateBoundingSphere")] 
		public CBool AutoGenerateBoundingSphere
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("boundingSphere")] 
		public Sphere BoundingSphere
		{
			get => GetPropertyValue<Sphere>();
			set => SetPropertyValue<Sphere>(value);
		}

		[Ordinal(8)] 
		[RED("ignoresScanningDistanceLimit")] 
		public CBool IgnoresScanningDistanceLimit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("cpoEnableMultiplePlayersScanningModifier")] 
		public CBool CpoEnableMultiplePlayersScanningModifier
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("isBraindanceClue")] 
		public CBool IsBraindanceClue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("BraindanceLayer")] 
		public CEnum<braindanceVisionMode> BraindanceLayer
		{
			get => GetPropertyValue<CEnum<braindanceVisionMode>>();
			set => SetPropertyValue<CEnum<braindanceVisionMode>>(value);
		}

		[Ordinal(12)] 
		[RED("isBraindanceBlocked")] 
		public CBool IsBraindanceBlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("isBraindanceLayerUnlocked")] 
		public CBool IsBraindanceLayerUnlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("isBraindanceTimelineUnlocked")] 
		public CBool IsBraindanceTimelineUnlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("isBraindanceActive")] 
		public CBool IsBraindanceActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("currentBraindanceLayer")] 
		public CInt32 CurrentBraindanceLayer
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(17)] 
		[RED("clues")] 
		public CArray<FocusClueDefinition> Clues
		{
			get => GetPropertyValue<CArray<FocusClueDefinition>>();
			set => SetPropertyValue<CArray<FocusClueDefinition>>(value);
		}

		[Ordinal(18)] 
		[RED("objectDescription")] 
		public CHandle<ObjectScanningDescription> ObjectDescription
		{
			get => GetPropertyValue<CHandle<ObjectScanningDescription>>();
			set => SetPropertyValue<CHandle<ObjectScanningDescription>>(value);
		}

		[Ordinal(19)] 
		[RED("scanningBarText")] 
		public TweakDBID ScanningBarText
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(20)] 
		[RED("isFocusModeActive")] 
		public CBool IsFocusModeActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("currentHighlight")] 
		public CHandle<FocusForcedHighlightData> CurrentHighlight
		{
			get => GetPropertyValue<CHandle<FocusForcedHighlightData>>();
			set => SetPropertyValue<CHandle<FocusForcedHighlightData>>(value);
		}

		[Ordinal(22)] 
		[RED("isHudManagerInitialized")] 
		public CBool IsHudManagerInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("isBeingScanned")] 
		public CBool IsBeingScanned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("isScanningCluesBlocked")] 
		public CBool IsScanningCluesBlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("isEntityVisible")] 
		public CBool IsEntityVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("OnBraindanceVisionModeChangeCallback")] 
		public CHandle<redCallbackObject> OnBraindanceVisionModeChangeCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(27)] 
		[RED("OnBraindanceFppChangeCallback")] 
		public CHandle<redCallbackObject> OnBraindanceFppChangeCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public gameScanningComponent()
		{
			Name = "scanning";
			ScannableData = new();
			AutoGenerateBoundingSphere = true;
			BoundingSphere = new() { CenterRadius2 = new() { W = -1.000000F } };
			CpoEnableMultiplePlayersScanningModifier = true;
			Clues = new();
			IsEntityVisible = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
