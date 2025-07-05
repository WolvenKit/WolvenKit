using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TwintoneDescriptionGameController : BaseChunkGameController
	{
		[Ordinal(5)] 
		[RED("cursorRootContainerRef")] 
		public inkWidgetReference CursorRootContainerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("paintjobInterface")] 
		public inkWidgetReference PaintjobInterface
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("restrictedPaintjobInterface")] 
		public inkWidgetReference RestrictedPaintjobInterface
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("videoHeaderRef")] 
		public inkVideoWidgetReference VideoHeaderRef
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("videoGroupRef")] 
		public inkWidgetReference VideoGroupRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("defaultVideoLoop")] 
		public redResourceReferenceScriptToken DefaultVideoLoop
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(11)] 
		[RED("thanksVideo")] 
		public redResourceReferenceScriptToken ThanksVideo
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(12)] 
		[RED("vehicleManufacturer")] 
		public inkImageWidgetReference VehicleManufacturer
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("applicableGroupRef")] 
		public inkWidgetReference ApplicableGroupRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("buyButtonText")] 
		public inkTextWidgetReference BuyButtonText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("applicableModelNamesText")] 
		public inkTextWidgetReference ApplicableModelNamesText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("templateTypeText")] 
		public inkTextWidgetReference TemplateTypeText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("priceText")] 
		public inkTextWidgetReference PriceText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("profileNotAvailableText")] 
		public inkTextWidgetReference ProfileNotAvailableText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("colorTemplatePreviewContainer")] 
		public inkWidgetReference ColorTemplatePreviewContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("c_progressBarDuration")] 
		public CUInt32 C_progressBarDuration
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(21)] 
		[RED("c_progressBarUpdateRate")] 
		public CUInt32 C_progressBarUpdateRate
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(22)] 
		[RED("colorTemplatePreview")] 
		public CWeakHandle<ColorTemplatePreviewDisplayController> ColorTemplatePreview
		{
			get => GetPropertyValue<CWeakHandle<ColorTemplatePreviewDisplayController>>();
			set => SetPropertyValue<CWeakHandle<ColorTemplatePreviewDisplayController>>(value);
		}

		[Ordinal(23)] 
		[RED("vehicleCustomizationChangedCallbackID")] 
		public CHandle<redCallbackObject> VehicleCustomizationChangedCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(24)] 
		[RED("vehicleManufacturerCallbackID")] 
		public CHandle<redCallbackObject> VehicleManufacturerCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(25)] 
		[RED("playerMountedCallbackID")] 
		public CHandle<redCallbackObject> PlayerMountedCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(26)] 
		[RED("scannerModeChangedCallbackID")] 
		public CHandle<redCallbackObject> ScannerModeChangedCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(27)] 
		[RED("activeTabChangedCallbackID")] 
		public CHandle<redCallbackObject> ActiveTabChangedCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(28)] 
		[RED("progressBarDelayID")] 
		public gameDelayID ProgressBarDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(29)] 
		[RED("scannedVehicleTemplate")] 
		public VehicleVisualCustomizationTemplate ScannedVehicleTemplate
		{
			get => GetPropertyValue<VehicleVisualCustomizationTemplate>();
			set => SetPropertyValue<VehicleVisualCustomizationTemplate>(value);
		}

		[Ordinal(30)] 
		[RED("scannedModelName")] 
		public CName ScannedModelName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(31)] 
		[RED("cachedVehicleTemplate")] 
		public VehicleVisualCustomizationTemplate CachedVehicleTemplate
		{
			get => GetPropertyValue<VehicleVisualCustomizationTemplate>();
			set => SetPropertyValue<VehicleVisualCustomizationTemplate>(value);
		}

		[Ordinal(32)] 
		[RED("cachedModelName")] 
		public CName CachedModelName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(33)] 
		[RED("isScanInProgress")] 
		public CBool IsScanInProgress
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(34)] 
		[RED("blackboardUI")] 
		public CWeakHandle<gameIBlackboard> BlackboardUI
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(35)] 
		[RED("game")] 
		public ScriptGameInstance Game
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(36)] 
		[RED("playerVVCComponent")] 
		public CHandle<vehicleVisualCustomizationComponent> PlayerVVCComponent
		{
			get => GetPropertyValue<CHandle<vehicleVisualCustomizationComponent>>();
			set => SetPropertyValue<CHandle<vehicleVisualCustomizationComponent>>(value);
		}

		[Ordinal(37)] 
		[RED("progressBarUpdateProxy")] 
		public CHandle<inkanimProxy> ProgressBarUpdateProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(38)] 
		[RED("progressBarCounter")] 
		public CFloat ProgressBarCounter
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(39)] 
		[RED("buyAnimationProxy")] 
		public CHandle<inkanimProxy> BuyAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(40)] 
		[RED("twintoneVisible")] 
		public CBool TwintoneVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(41)] 
		[RED("scanAvailable")] 
		public CBool ScanAvailable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(42)] 
		[RED("applyAvailable")] 
		public CBool ApplyAvailable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(43)] 
		[RED("applyAfterSave")] 
		public CBool ApplyAfterSave
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(44)] 
		[RED("endAnimationCancelled")] 
		public CBool EndAnimationCancelled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public TwintoneDescriptionGameController()
		{
			CursorRootContainerRef = new inkWidgetReference();
			PaintjobInterface = new inkWidgetReference();
			RestrictedPaintjobInterface = new inkWidgetReference();
			VideoHeaderRef = new inkVideoWidgetReference();
			VideoGroupRef = new inkWidgetReference();
			DefaultVideoLoop = new redResourceReferenceScriptToken();
			ThanksVideo = new redResourceReferenceScriptToken();
			VehicleManufacturer = new inkImageWidgetReference();
			ApplicableGroupRef = new inkWidgetReference();
			BuyButtonText = new inkTextWidgetReference();
			ApplicableModelNamesText = new inkTextWidgetReference();
			TemplateTypeText = new inkTextWidgetReference();
			PriceText = new inkTextWidgetReference();
			ProfileNotAvailableText = new inkTextWidgetReference();
			ColorTemplatePreviewContainer = new inkWidgetReference();
			C_progressBarDuration = 2;
			C_progressBarUpdateRate = 60;
			ProgressBarDelayID = new gameDelayID();
			ScannedVehicleTemplate = new VehicleVisualCustomizationTemplate { GenericData = new GenericTemplatePersistentData(), UniqueData = new UniqueTemplateData { CustomMultilayers = new(), CustomDecals = new(), GlobalClearCoatOverrides = new vehicleVehicleClearCoatOverrides { Opacity = -1.000000F, CoatTintFwd = new CColor(), CoatTintSide = new CColor(), CoatTintFresnelBias = -1.000000F, CoatSpecularColor = new CColor(), CoatFresnelBias = -1.000000F }, PartsClearCoatOverrides = new() } };
			CachedVehicleTemplate = new VehicleVisualCustomizationTemplate { GenericData = new GenericTemplatePersistentData(), UniqueData = new UniqueTemplateData { CustomMultilayers = new(), CustomDecals = new(), GlobalClearCoatOverrides = new vehicleVehicleClearCoatOverrides { Opacity = -1.000000F, CoatTintFwd = new CColor(), CoatTintSide = new CColor(), CoatTintFresnelBias = -1.000000F, CoatSpecularColor = new CColor(), CoatFresnelBias = -1.000000F }, PartsClearCoatOverrides = new() } };
			Game = new ScriptGameInstance();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
