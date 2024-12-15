using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleColorSelectorGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("CursorRootContainerRef")] 
		public inkWidgetReference CursorRootContainerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("CursorRootOffsetPoint")] 
		public inkWidgetReference CursorRootOffsetPoint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("colorPaletteRef")] 
		public inkWidgetReference ColorPaletteRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("stickerPaletteRef")] 
		public inkWidgetReference StickerPaletteRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("currentTemplateParentRef")] 
		public inkWidgetReference CurrentTemplateParentRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("windowTitle")] 
		public inkTextWidgetReference WindowTitle
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("colorWheelColorA")] 
		public inkWidgetReference ColorWheelColorA
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("colorWheelColorB")] 
		public inkWidgetReference ColorWheelColorB
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("colorWheelColorLights")] 
		public inkWidgetReference ColorWheelColorLights
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("colorPickerA")] 
		public vehicleColorSelectorPointerDef ColorPickerA
		{
			get => GetPropertyValue<vehicleColorSelectorPointerDef>();
			set => SetPropertyValue<vehicleColorSelectorPointerDef>(value);
		}

		[Ordinal(12)] 
		[RED("selectedColorPointerA")] 
		public vehicleColorSelectorPointerDef SelectedColorPointerA
		{
			get => GetPropertyValue<vehicleColorSelectorPointerDef>();
			set => SetPropertyValue<vehicleColorSelectorPointerDef>(value);
		}

		[Ordinal(13)] 
		[RED("colorPickerB")] 
		public vehicleColorSelectorPointerDef ColorPickerB
		{
			get => GetPropertyValue<vehicleColorSelectorPointerDef>();
			set => SetPropertyValue<vehicleColorSelectorPointerDef>(value);
		}

		[Ordinal(14)] 
		[RED("selectedColorPointerB")] 
		public vehicleColorSelectorPointerDef SelectedColorPointerB
		{
			get => GetPropertyValue<vehicleColorSelectorPointerDef>();
			set => SetPropertyValue<vehicleColorSelectorPointerDef>(value);
		}

		[Ordinal(15)] 
		[RED("colorPickerLights")] 
		public vehicleColorSelectorPointerDef ColorPickerLights
		{
			get => GetPropertyValue<vehicleColorSelectorPointerDef>();
			set => SetPropertyValue<vehicleColorSelectorPointerDef>(value);
		}

		[Ordinal(16)] 
		[RED("selectedColorPointerLights")] 
		public vehicleColorSelectorPointerDef SelectedColorPointerLights
		{
			get => GetPropertyValue<vehicleColorSelectorPointerDef>();
			set => SetPropertyValue<vehicleColorSelectorPointerDef>(value);
		}

		[Ordinal(17)] 
		[RED("swapColorHint")] 
		public inkWidgetReference SwapColorHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("changeSliderHint")] 
		public inkWidgetReference ChangeSliderHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("twintoneApplyHintText")] 
		public inkTextWidgetReference TwintoneApplyHintText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("changeTabRightHint")] 
		public inkWidgetReference ChangeTabRightHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("changeTabLeftHint")] 
		public inkWidgetReference ChangeTabLeftHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("mouseHitColor1Ref")] 
		public inkWidgetReference MouseHitColor1Ref
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("mouseHitColor2Ref")] 
		public inkWidgetReference MouseHitColor2Ref
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("mouseHitLightsRef")] 
		public inkWidgetReference MouseHitLightsRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("vehiclePreviewColorA")] 
		public inkImageWidgetReference VehiclePreviewColorA
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("vehiclePreviewColorB")] 
		public inkImageWidgetReference VehiclePreviewColorB
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("vehiclePreviewLightsCar")] 
		public inkImageWidgetReference VehiclePreviewLightsCar
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("vehiclePreviewLightsBike")] 
		public inkImageWidgetReference VehiclePreviewLightsBike
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("vehiclePreviewBackground")] 
		public inkImageWidgetReference VehiclePreviewBackground
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("vehiclePreviewForeground")] 
		public inkImageWidgetReference VehiclePreviewForeground
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("vehiclePreviewScalingCanvas")] 
		public inkWidgetReference VehiclePreviewScalingCanvas
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("lightsPreviewBeamA")] 
		public inkImageWidgetReference LightsPreviewBeamA
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("lightsPreviewBeamB")] 
		public inkImageWidgetReference LightsPreviewBeamB
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("timeDilationProfile")] 
		public CString TimeDilationProfile
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(35)] 
		[RED("introAnimation")] 
		public CName IntroAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(36)] 
		[RED("cancelAnimation")] 
		public CName CancelAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(37)] 
		[RED("applyAnimation")] 
		public CName ApplyAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(38)] 
		[RED("titleTextMain")] 
		public inkTextWidgetReference TitleTextMain
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(39)] 
		[RED("titleTextNumber")] 
		public inkTextWidgetReference TitleTextNumber
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(40)] 
		[RED("mouseHitSaturationBar")] 
		public inkWidgetReference MouseHitSaturationBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(41)] 
		[RED("saturationBarFill")] 
		public inkWidgetReference SaturationBarFill
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(42)] 
		[RED("saturationPointer")] 
		public inkWidgetReference SaturationPointer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(43)] 
		[RED("saturationBarHighlight")] 
		public inkImageWidgetReference SaturationBarHighlight
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(44)] 
		[RED("saturationBarHint")] 
		public inkWidgetReference SaturationBarHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(45)] 
		[RED("brightnessBarHighlight")] 
		public inkImageWidgetReference BrightnessBarHighlight
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(46)] 
		[RED("brightnessBarHint")] 
		public inkWidgetReference BrightnessBarHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(47)] 
		[RED("mouseHitBrightnessBar")] 
		public inkWidgetReference MouseHitBrightnessBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(48)] 
		[RED("brightnessPointer")] 
		public inkWidgetReference BrightnessPointer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(49)] 
		[RED("modeChangeBack")] 
		public inkWidgetReference ModeChangeBack
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(50)] 
		[RED("modeChangeNext")] 
		public inkWidgetReference ModeChangeNext
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(51)] 
		[RED("applyContainerWidget")] 
		public inkWidgetReference ApplyContainerWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(52)] 
		[RED("resetContainerWidget")] 
		public inkWidgetReference ResetContainerWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(53)] 
		[RED("vehicleUnknownPane")] 
		public inkWidgetReference VehicleUnknownPane
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(54)] 
		[RED("vehicleBrandIcon")] 
		public inkImageWidgetReference VehicleBrandIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(55)] 
		[RED("crackedCarGlitchMinimumInterval")] 
		public CFloat CrackedCarGlitchMinimumInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(56)] 
		[RED("crackedCarGlitchMaximumInterval")] 
		public CFloat CrackedCarGlitchMaximumInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(57)] 
		[RED("vehicleNameText")] 
		public inkTextWidgetReference VehicleNameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(58)] 
		[RED("templatePreviewLibraryRef")] 
		public inkWidgetLibraryReference TemplatePreviewLibraryRef
		{
			get => GetPropertyValue<inkWidgetLibraryReference>();
			set => SetPropertyValue<inkWidgetLibraryReference>(value);
		}

		[Ordinal(59)] 
		[RED("genericPatternsGrid")] 
		public inkVirtualCompoundWidgetReference GenericPatternsGrid
		{
			get => GetPropertyValue<inkVirtualCompoundWidgetReference>();
			set => SetPropertyValue<inkVirtualCompoundWidgetReference>(value);
		}

		[Ordinal(60)] 
		[RED("uniquePatternsGrid")] 
		public inkVirtualCompoundWidgetReference UniquePatternsGrid
		{
			get => GetPropertyValue<inkVirtualCompoundWidgetReference>();
			set => SetPropertyValue<inkVirtualCompoundWidgetReference>(value);
		}

		[Ordinal(61)] 
		[RED("saveProfileHint")] 
		public inkWidgetReference SaveProfileHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(62)] 
		[RED("deleteProfileHint")] 
		public inkWidgetReference DeleteProfileHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(63)] 
		[RED("popupData")] 
		public CHandle<inkGameNotificationData> PopupData
		{
			get => GetPropertyValue<CHandle<inkGameNotificationData>>();
			set => SetPropertyValue<CHandle<inkGameNotificationData>>(value);
		}

		[Ordinal(64)] 
		[RED("systemRequestsHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> SystemRequestsHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		[Ordinal(65)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(66)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(67)] 
		[RED("timeSystem")] 
		public CHandle<gameTimeSystem> TimeSystem
		{
			get => GetPropertyValue<CHandle<gameTimeSystem>>();
			set => SetPropertyValue<CHandle<gameTimeSystem>>(value);
		}

		[Ordinal(68)] 
		[RED("vehicle")] 
		public CWeakHandle<vehicleBaseObject> Vehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(69)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(70)] 
		[RED("fakeUpdateProxy")] 
		public CHandle<inkanimProxy> FakeUpdateProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(71)] 
		[RED("sbBarsProxy")] 
		public CHandle<inkanimProxy> SbBarsProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(72)] 
		[RED("LightsFocusProxy")] 
		public CHandle<inkanimProxy> LightsFocusProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(73)] 
		[RED("stickersPage")] 
		public CWeakHandle<inkWidget> StickersPage
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(74)] 
		[RED("isInMenuCallbackID")] 
		public CHandle<redCallbackObject> IsInMenuCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(75)] 
		[RED("activeMode")] 
		public CEnum<vehicleColorSelectorActiveMode> ActiveMode
		{
			get => GetPropertyValue<CEnum<vehicleColorSelectorActiveMode>>();
			set => SetPropertyValue<CEnum<vehicleColorSelectorActiveMode>>(value);
		}

		[Ordinal(76)] 
		[RED("previousMode")] 
		public CEnum<vehicleColorSelectorActiveMode> PreviousMode
		{
			get => GetPropertyValue<CEnum<vehicleColorSelectorActiveMode>>();
			set => SetPropertyValue<CEnum<vehicleColorSelectorActiveMode>>(value);
		}

		[Ordinal(77)] 
		[RED("activeInputMode")] 
		public CEnum<vehicleColorSelectorActiveInputMode> ActiveInputMode
		{
			get => GetPropertyValue<CEnum<vehicleColorSelectorActiveInputMode>>();
			set => SetPropertyValue<CEnum<vehicleColorSelectorActiveInputMode>>(value);
		}

		[Ordinal(78)] 
		[RED("currentAngle")] 
		public CFloat CurrentAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(79)] 
		[RED("colorADefined")] 
		public CBool ColorADefined
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(80)] 
		[RED("colorBDefined")] 
		public CBool ColorBDefined
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(81)] 
		[RED("lightsDefined")] 
		public CBool LightsDefined
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(82)] 
		[RED("targetColorAngleA")] 
		public CFloat TargetColorAngleA
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(83)] 
		[RED("targetColorAngleB")] 
		public CFloat TargetColorAngleB
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(84)] 
		[RED("targetColorAngleLights")] 
		public CFloat TargetColorAngleLights
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(85)] 
		[RED("targetColorASaturation")] 
		public CFloat TargetColorASaturation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(86)] 
		[RED("targetColorBSaturation")] 
		public CFloat TargetColorBSaturation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(87)] 
		[RED("targetColorABrightness")] 
		public CFloat TargetColorABrightness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(88)] 
		[RED("targetColorBBrightness")] 
		public CFloat TargetColorBBrightness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(89)] 
		[RED("axisInputCache")] 
		public Vector2 AxisInputCache
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(90)] 
		[RED("inputEnabled")] 
		public CBool InputEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(91)] 
		[RED("sbBarsShown")] 
		public CBool SbBarsShown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(92)] 
		[RED("sbBarsLength")] 
		public CFloat SbBarsLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(93)] 
		[RED("axisInputThreshold")] 
		public CFloat AxisInputThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(94)] 
		[RED("saturationPointerPosition")] 
		public CFloat SaturationPointerPosition
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(95)] 
		[RED("brightnessPointerPosition")] 
		public CFloat BrightnessPointerPosition
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(96)] 
		[RED("mouseInputEnabled")] 
		public CBool MouseInputEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(97)] 
		[RED("saturationSliderHolded")] 
		public CBool SaturationSliderHolded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(98)] 
		[RED("brightnessSliderHolded")] 
		public CBool BrightnessSliderHolded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(99)] 
		[RED("ChromaSliderStepPad")] 
		public CFloat ChromaSliderStepPad
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(100)] 
		[RED("ChromaSliderStepMouse")] 
		public CFloat ChromaSliderStepMouse
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(101)] 
		[RED("sliderHoldGamepad")] 
		public CBool SliderHoldGamepad
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(102)] 
		[RED("sliderHoldGamepadDamp")] 
		public CInt32 SliderHoldGamepadDamp
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(103)] 
		[RED("sliderPadHoldAccelerationTreshhold")] 
		public CInt32 SliderPadHoldAccelerationTreshhold
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(104)] 
		[RED("storedSelectedColorID")] 
		public CInt32 StoredSelectedColorID
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(105)] 
		[RED("cachedNewColorA")] 
		public CColor CachedNewColorA
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(106)] 
		[RED("cachedNewColorB")] 
		public CColor CachedNewColorB
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(107)] 
		[RED("cachedNewColorLights")] 
		public CColor CachedNewColorLights
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(108)] 
		[RED("CloseReason")] 
		public CEnum<vehicleColorSelectorMenuCloseReason> CloseReason
		{
			get => GetPropertyValue<CEnum<vehicleColorSelectorMenuCloseReason>>();
			set => SetPropertyValue<CEnum<vehicleColorSelectorMenuCloseReason>>(value);
		}

		[Ordinal(109)] 
		[RED("unsupportedVehicle")] 
		public CBool UnsupportedVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(110)] 
		[RED("previewDataMissing")] 
		public CBool PreviewDataMissing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(111)] 
		[RED("virtualGenericTemplateGridController")] 
		public CWeakHandle<TwintoneTemplateGridController> VirtualGenericTemplateGridController
		{
			get => GetPropertyValue<CWeakHandle<TwintoneTemplateGridController>>();
			set => SetPropertyValue<CWeakHandle<TwintoneTemplateGridController>>(value);
		}

		[Ordinal(112)] 
		[RED("virtualUniqueTemplateGridController")] 
		public CWeakHandle<TwintoneTemplateGridController> VirtualUniqueTemplateGridController
		{
			get => GetPropertyValue<CWeakHandle<TwintoneTemplateGridController>>();
			set => SetPropertyValue<CWeakHandle<TwintoneTemplateGridController>>(value);
		}

		[Ordinal(113)] 
		[RED("genericGridInitialized")] 
		public CBool GenericGridInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(114)] 
		[RED("uniqueGridInitialized")] 
		public CBool UniqueGridInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(115)] 
		[RED("currentTemplate")] 
		public VehicleVisualCustomizationTemplate CurrentTemplate
		{
			get => GetPropertyValue<VehicleVisualCustomizationTemplate>();
			set => SetPropertyValue<VehicleVisualCustomizationTemplate>(value);
		}

		[Ordinal(116)] 
		[RED("toggledTemplate")] 
		public VehicleVisualCustomizationTemplate ToggledTemplate
		{
			get => GetPropertyValue<VehicleVisualCustomizationTemplate>();
			set => SetPropertyValue<VehicleVisualCustomizationTemplate>(value);
		}

		[Ordinal(117)] 
		[RED("currentTemplatePreview")] 
		public CWeakHandle<ColorTemplatePreviewDisplayController> CurrentTemplatePreview
		{
			get => GetPropertyValue<CWeakHandle<ColorTemplatePreviewDisplayController>>();
			set => SetPropertyValue<CWeakHandle<ColorTemplatePreviewDisplayController>>(value);
		}

		[Ordinal(118)] 
		[RED("activePanel")] 
		public CEnum<vehicleColorSelectorActiveTab> ActivePanel
		{
			get => GetPropertyValue<CEnum<vehicleColorSelectorActiveTab>>();
			set => SetPropertyValue<CEnum<vehicleColorSelectorActiveTab>>(value);
		}

		[Ordinal(119)] 
		[RED("activeSBBar")] 
		public CEnum<vehicleColorSelectorSBBar> ActiveSBBar
		{
			get => GetPropertyValue<CEnum<vehicleColorSelectorSBBar>>();
			set => SetPropertyValue<CEnum<vehicleColorSelectorSBBar>>(value);
		}

		[Ordinal(120)] 
		[RED("mainPanelAnimProxy")] 
		public CHandle<inkanimProxy> MainPanelAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(121)] 
		[RED("twintonePanelAnimProxy")] 
		public CHandle<inkanimProxy> TwintonePanelAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(122)] 
		[RED("carGlitchProxy")] 
		public CHandle<inkanimProxy> CarGlitchProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public vehicleColorSelectorGameController()
		{
			CursorRootContainerRef = new inkWidgetReference();
			CursorRootOffsetPoint = new inkWidgetReference();
			ColorPaletteRef = new inkWidgetReference();
			StickerPaletteRef = new inkWidgetReference();
			CurrentTemplateParentRef = new inkWidgetReference();
			WindowTitle = new inkTextWidgetReference();
			ColorWheelColorA = new inkWidgetReference();
			ColorWheelColorB = new inkWidgetReference();
			ColorWheelColorLights = new inkWidgetReference();
			ColorPickerA = new vehicleColorSelectorPointerDef { PointerRoot = new inkWidgetReference(), PartToPaint = new inkWidgetReference() };
			SelectedColorPointerA = new vehicleColorSelectorPointerDef { PointerRoot = new inkWidgetReference(), PartToPaint = new inkWidgetReference() };
			ColorPickerB = new vehicleColorSelectorPointerDef { PointerRoot = new inkWidgetReference(), PartToPaint = new inkWidgetReference() };
			SelectedColorPointerB = new vehicleColorSelectorPointerDef { PointerRoot = new inkWidgetReference(), PartToPaint = new inkWidgetReference() };
			ColorPickerLights = new vehicleColorSelectorPointerDef { PointerRoot = new inkWidgetReference(), PartToPaint = new inkWidgetReference() };
			SelectedColorPointerLights = new vehicleColorSelectorPointerDef { PointerRoot = new inkWidgetReference(), PartToPaint = new inkWidgetReference() };
			SwapColorHint = new inkWidgetReference();
			ChangeSliderHint = new inkWidgetReference();
			TwintoneApplyHintText = new inkTextWidgetReference();
			ChangeTabRightHint = new inkWidgetReference();
			ChangeTabLeftHint = new inkWidgetReference();
			MouseHitColor1Ref = new inkWidgetReference();
			MouseHitColor2Ref = new inkWidgetReference();
			MouseHitLightsRef = new inkWidgetReference();
			VehiclePreviewColorA = new inkImageWidgetReference();
			VehiclePreviewColorB = new inkImageWidgetReference();
			VehiclePreviewLightsCar = new inkImageWidgetReference();
			VehiclePreviewLightsBike = new inkImageWidgetReference();
			VehiclePreviewBackground = new inkImageWidgetReference();
			VehiclePreviewForeground = new inkImageWidgetReference();
			VehiclePreviewScalingCanvas = new inkWidgetReference();
			LightsPreviewBeamA = new inkImageWidgetReference();
			LightsPreviewBeamB = new inkImageWidgetReference();
			TimeDilationProfile = "radialMenu";
			IntroAnimation = "Intro";
			CancelAnimation = "Cancel";
			ApplyAnimation = "Apply";
			TitleTextMain = new inkTextWidgetReference();
			TitleTextNumber = new inkTextWidgetReference();
			MouseHitSaturationBar = new inkWidgetReference();
			SaturationBarFill = new inkWidgetReference();
			SaturationPointer = new inkWidgetReference();
			SaturationBarHighlight = new inkImageWidgetReference();
			SaturationBarHint = new inkWidgetReference();
			BrightnessBarHighlight = new inkImageWidgetReference();
			BrightnessBarHint = new inkWidgetReference();
			MouseHitBrightnessBar = new inkWidgetReference();
			BrightnessPointer = new inkWidgetReference();
			ModeChangeBack = new inkWidgetReference();
			ModeChangeNext = new inkWidgetReference();
			ApplyContainerWidget = new inkWidgetReference();
			ResetContainerWidget = new inkWidgetReference();
			VehicleUnknownPane = new inkWidgetReference();
			VehicleBrandIcon = new inkImageWidgetReference();
			VehicleNameText = new inkTextWidgetReference();
			TemplatePreviewLibraryRef = new inkWidgetLibraryReference { WidgetLibrary = new inkWidgetLibraryResourceWrapper() };
			GenericPatternsGrid = new inkVirtualCompoundWidgetReference();
			UniquePatternsGrid = new inkVirtualCompoundWidgetReference();
			SaveProfileHint = new inkWidgetReference();
			DeleteProfileHint = new inkWidgetReference();
			GameInstance = new ScriptGameInstance();
			AxisInputCache = new Vector2();
			SbBarsLength = 756.000000F;
			AxisInputThreshold = 0.100000F;
			ChromaSliderStepPad = 4.500000F;
			ChromaSliderStepMouse = 18.000000F;
			SliderPadHoldAccelerationTreshhold = 50;
			CachedNewColorA = new CColor();
			CachedNewColorB = new CColor();
			CachedNewColorLights = new CColor();
			CurrentTemplate = new VehicleVisualCustomizationTemplate { GenericData = new GenericTemplatePersistentData(), UniqueData = new UniqueTemplateData { CustomMultilayers = new(), CustomDecals = new(), GlobalClearCoatOverrides = new vehicleVehicleClearCoatOverrides { Opacity = -1.000000F, CoatTintFwd = new CColor(), CoatTintSide = new CColor(), CoatTintFresnelBias = -1.000000F, CoatSpecularColor = new CColor(), CoatFresnelBias = -1.000000F }, PartsClearCoatOverrides = new() } };
			ToggledTemplate = new VehicleVisualCustomizationTemplate { GenericData = new GenericTemplatePersistentData(), UniqueData = new UniqueTemplateData { CustomMultilayers = new(), CustomDecals = new(), GlobalClearCoatOverrides = new vehicleVehicleClearCoatOverrides { Opacity = -1.000000F, CoatTintFwd = new CColor(), CoatTintSide = new CColor(), CoatTintFresnelBias = -1.000000F, CoatSpecularColor = new CColor(), CoatFresnelBias = -1.000000F }, PartsClearCoatOverrides = new() } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
