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
		[RED("classicBackgrounds")] 
		public CArray<inkWidgetReference> ClassicBackgrounds
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(9)] 
		[RED("mordredBackgrounds")] 
		public CArray<inkWidgetReference> MordredBackgrounds
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(10)] 
		[RED("colorWheelColorA")] 
		public inkWidgetReference ColorWheelColorA
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("colorWheelColorB")] 
		public inkWidgetReference ColorWheelColorB
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("colorWheelColorLights")] 
		public inkWidgetReference ColorWheelColorLights
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("colorWheelColorLightsCircle")] 
		public inkWidgetReference ColorWheelColorLightsCircle
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("colorWheelColorLightsFixedCircleContainer")] 
		public inkWidgetReference ColorWheelColorLightsFixedCircleContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("colorWheelColorLightsFixedCircle")] 
		public inkWidgetReference ColorWheelColorLightsFixedCircle
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("colorPickerA")] 
		public vehicleColorSelectorPointerDef ColorPickerA
		{
			get => GetPropertyValue<vehicleColorSelectorPointerDef>();
			set => SetPropertyValue<vehicleColorSelectorPointerDef>(value);
		}

		[Ordinal(17)] 
		[RED("selectedColorPointerA")] 
		public vehicleColorSelectorPointerDef SelectedColorPointerA
		{
			get => GetPropertyValue<vehicleColorSelectorPointerDef>();
			set => SetPropertyValue<vehicleColorSelectorPointerDef>(value);
		}

		[Ordinal(18)] 
		[RED("colorPickerB")] 
		public vehicleColorSelectorPointerDef ColorPickerB
		{
			get => GetPropertyValue<vehicleColorSelectorPointerDef>();
			set => SetPropertyValue<vehicleColorSelectorPointerDef>(value);
		}

		[Ordinal(19)] 
		[RED("selectedColorPointerB")] 
		public vehicleColorSelectorPointerDef SelectedColorPointerB
		{
			get => GetPropertyValue<vehicleColorSelectorPointerDef>();
			set => SetPropertyValue<vehicleColorSelectorPointerDef>(value);
		}

		[Ordinal(20)] 
		[RED("colorPickerLights")] 
		public vehicleColorSelectorPointerDef ColorPickerLights
		{
			get => GetPropertyValue<vehicleColorSelectorPointerDef>();
			set => SetPropertyValue<vehicleColorSelectorPointerDef>(value);
		}

		[Ordinal(21)] 
		[RED("selectedColorPointerLights")] 
		public vehicleColorSelectorPointerDef SelectedColorPointerLights
		{
			get => GetPropertyValue<vehicleColorSelectorPointerDef>();
			set => SetPropertyValue<vehicleColorSelectorPointerDef>(value);
		}

		[Ordinal(22)] 
		[RED("swapColorHint")] 
		public inkWidgetReference SwapColorHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("changeSliderHint")] 
		public inkWidgetReference ChangeSliderHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("twintoneApplyHintText")] 
		public inkTextWidgetReference TwintoneApplyHintText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("changeTabRightHint")] 
		public inkWidgetReference ChangeTabRightHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("changeTabLeftHint")] 
		public inkWidgetReference ChangeTabLeftHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("mouseHitColor1Ref")] 
		public inkWidgetReference MouseHitColor1Ref
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("mouseHitColor2Ref")] 
		public inkWidgetReference MouseHitColor2Ref
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("mouseHitLightsRef")] 
		public inkWidgetReference MouseHitLightsRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("vehiclePreviewColorA")] 
		public inkImageWidgetReference VehiclePreviewColorA
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("vehiclePreviewColorB")] 
		public inkImageWidgetReference VehiclePreviewColorB
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("vehiclePreviewLightsCar")] 
		public inkImageWidgetReference VehiclePreviewLightsCar
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("vehiclePreviewLightsBike")] 
		public inkImageWidgetReference VehiclePreviewLightsBike
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("vehiclePreviewBackground")] 
		public inkImageWidgetReference VehiclePreviewBackground
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("vehiclePreviewForeground")] 
		public inkImageWidgetReference VehiclePreviewForeground
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("vehiclePreviewGlowBackground")] 
		public inkImageWidgetReference VehiclePreviewGlowBackground
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("vehiclePreviewGlowA")] 
		public inkImageWidgetReference VehiclePreviewGlowA
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(38)] 
		[RED("vehiclePreviewGlowB")] 
		public inkImageWidgetReference VehiclePreviewGlowB
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(39)] 
		[RED("vehiclePreviewGlowLights")] 
		public inkImageWidgetReference VehiclePreviewGlowLights
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(40)] 
		[RED("vehiclePreviewScalingCanvas")] 
		public inkWidgetReference VehiclePreviewScalingCanvas
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(41)] 
		[RED("lightsPreviewBeamA")] 
		public inkImageWidgetReference LightsPreviewBeamA
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(42)] 
		[RED("lightsPreviewBeamB")] 
		public inkImageWidgetReference LightsPreviewBeamB
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(43)] 
		[RED("lightsPreviewBeamBike")] 
		public inkImageWidgetReference LightsPreviewBeamBike
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(44)] 
		[RED("lightErrorMessage")] 
		public inkTextWidgetReference LightErrorMessage
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(45)] 
		[RED("timeDilationProfile")] 
		public CString TimeDilationProfile
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(46)] 
		[RED("introAnimation")] 
		public CName IntroAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(47)] 
		[RED("cancelAnimation")] 
		public CName CancelAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(48)] 
		[RED("applyAnimation")] 
		public CName ApplyAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(49)] 
		[RED("titleTextMain")] 
		public inkTextWidgetReference TitleTextMain
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(50)] 
		[RED("titleTextNumber")] 
		public inkTextWidgetReference TitleTextNumber
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(51)] 
		[RED("colorHints")] 
		public inkWidgetReference ColorHints
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(52)] 
		[RED("mouseHitSaturationBar")] 
		public inkWidgetReference MouseHitSaturationBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(53)] 
		[RED("saturationBarFill")] 
		public inkWidgetReference SaturationBarFill
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(54)] 
		[RED("saturationPointer")] 
		public inkWidgetReference SaturationPointer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(55)] 
		[RED("saturationBarHighlight")] 
		public inkImageWidgetReference SaturationBarHighlight
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(56)] 
		[RED("saturationBarHint")] 
		public inkWidgetReference SaturationBarHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(57)] 
		[RED("brightnessBarHighlight")] 
		public inkImageWidgetReference BrightnessBarHighlight
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(58)] 
		[RED("brightnessBarHint")] 
		public inkWidgetReference BrightnessBarHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(59)] 
		[RED("headlightsIcon")] 
		public inkWidgetReference HeadlightsIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(60)] 
		[RED("mouseHitBrightnessBar")] 
		public inkWidgetReference MouseHitBrightnessBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(61)] 
		[RED("brightnessPointer")] 
		public inkWidgetReference BrightnessPointer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(62)] 
		[RED("modeChangeBack")] 
		public inkWidgetReference ModeChangeBack
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(63)] 
		[RED("modeChangeNext")] 
		public inkWidgetReference ModeChangeNext
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(64)] 
		[RED("applyContainerWidget")] 
		public inkWidgetReference ApplyContainerWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(65)] 
		[RED("resetContainerWidget")] 
		public inkWidgetReference ResetContainerWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(66)] 
		[RED("vehicleUnknownPane")] 
		public inkWidgetReference VehicleUnknownPane
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(67)] 
		[RED("vehicleBrandIcon")] 
		public inkImageWidgetReference VehicleBrandIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(68)] 
		[RED("crackedCarGlitchMinimumInterval")] 
		public CFloat CrackedCarGlitchMinimumInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(69)] 
		[RED("crackedCarGlitchMaximumInterval")] 
		public CFloat CrackedCarGlitchMaximumInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(70)] 
		[RED("vehicleNameText")] 
		public inkTextWidgetReference VehicleNameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(71)] 
		[RED("templatePreviewLibraryRef")] 
		public inkWidgetLibraryReference TemplatePreviewLibraryRef
		{
			get => GetPropertyValue<inkWidgetLibraryReference>();
			set => SetPropertyValue<inkWidgetLibraryReference>(value);
		}

		[Ordinal(72)] 
		[RED("uniqueColorPanel")] 
		public inkWidgetReference UniqueColorPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(73)] 
		[RED("uniqueColorErrorPanel")] 
		public inkWidgetReference UniqueColorErrorPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(74)] 
		[RED("genericPatternsGrid")] 
		public inkVirtualCompoundWidgetReference GenericPatternsGrid
		{
			get => GetPropertyValue<inkVirtualCompoundWidgetReference>();
			set => SetPropertyValue<inkVirtualCompoundWidgetReference>(value);
		}

		[Ordinal(75)] 
		[RED("uniquePatternsGrid")] 
		public inkVirtualCompoundWidgetReference UniquePatternsGrid
		{
			get => GetPropertyValue<inkVirtualCompoundWidgetReference>();
			set => SetPropertyValue<inkVirtualCompoundWidgetReference>(value);
		}

		[Ordinal(76)] 
		[RED("saveProfileHint")] 
		public inkWidgetReference SaveProfileHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(77)] 
		[RED("deleteProfileHint")] 
		public inkWidgetReference DeleteProfileHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(78)] 
		[RED("popupData")] 
		public CHandle<inkGameNotificationData> PopupData
		{
			get => GetPropertyValue<CHandle<inkGameNotificationData>>();
			set => SetPropertyValue<CHandle<inkGameNotificationData>>(value);
		}

		[Ordinal(79)] 
		[RED("systemRequestsHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> SystemRequestsHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		[Ordinal(80)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(81)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(82)] 
		[RED("timeSystem")] 
		public CHandle<gameTimeSystem> TimeSystem
		{
			get => GetPropertyValue<CHandle<gameTimeSystem>>();
			set => SetPropertyValue<CHandle<gameTimeSystem>>(value);
		}

		[Ordinal(83)] 
		[RED("vehicle")] 
		public CWeakHandle<vehicleBaseObject> Vehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(84)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(85)] 
		[RED("fakeUpdateProxy")] 
		public CHandle<inkanimProxy> FakeUpdateProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(86)] 
		[RED("sbBarsProxy")] 
		public CHandle<inkanimProxy> SbBarsProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(87)] 
		[RED("LightsFocusProxy")] 
		public CHandle<inkanimProxy> LightsFocusProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(88)] 
		[RED("stickersPage")] 
		public CWeakHandle<inkWidget> StickersPage
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(89)] 
		[RED("isInMenuCallbackID")] 
		public CHandle<redCallbackObject> IsInMenuCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(90)] 
		[RED("activeMode")] 
		public CEnum<vehicleColorSelectorActiveMode> ActiveMode
		{
			get => GetPropertyValue<CEnum<vehicleColorSelectorActiveMode>>();
			set => SetPropertyValue<CEnum<vehicleColorSelectorActiveMode>>(value);
		}

		[Ordinal(91)] 
		[RED("previousMode")] 
		public CEnum<vehicleColorSelectorActiveMode> PreviousMode
		{
			get => GetPropertyValue<CEnum<vehicleColorSelectorActiveMode>>();
			set => SetPropertyValue<CEnum<vehicleColorSelectorActiveMode>>(value);
		}

		[Ordinal(92)] 
		[RED("activeInputMode")] 
		public CEnum<vehicleColorSelectorActiveInputMode> ActiveInputMode
		{
			get => GetPropertyValue<CEnum<vehicleColorSelectorActiveInputMode>>();
			set => SetPropertyValue<CEnum<vehicleColorSelectorActiveInputMode>>(value);
		}

		[Ordinal(93)] 
		[RED("currentAngle")] 
		public CFloat CurrentAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(94)] 
		[RED("colorADefined")] 
		public CBool ColorADefined
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(95)] 
		[RED("colorBDefined")] 
		public CBool ColorBDefined
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(96)] 
		[RED("lightsDefined")] 
		public CBool LightsDefined
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(97)] 
		[RED("targetColorAngleA")] 
		public CFloat TargetColorAngleA
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(98)] 
		[RED("targetColorAngleB")] 
		public CFloat TargetColorAngleB
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(99)] 
		[RED("targetColorAngleLights")] 
		public CFloat TargetColorAngleLights
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(100)] 
		[RED("targetColorASaturation")] 
		public CFloat TargetColorASaturation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(101)] 
		[RED("targetColorBSaturation")] 
		public CFloat TargetColorBSaturation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(102)] 
		[RED("targetColorABrightness")] 
		public CFloat TargetColorABrightness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(103)] 
		[RED("targetColorBBrightness")] 
		public CFloat TargetColorBBrightness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(104)] 
		[RED("axisInputCache")] 
		public Vector2 AxisInputCache
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(105)] 
		[RED("inputEnabled")] 
		public CBool InputEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(106)] 
		[RED("sbBarsShown")] 
		public CBool SbBarsShown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(107)] 
		[RED("sbBarsLength")] 
		public CFloat SbBarsLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(108)] 
		[RED("axisInputThreshold")] 
		public CFloat AxisInputThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(109)] 
		[RED("saturationPointerPosition")] 
		public CFloat SaturationPointerPosition
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(110)] 
		[RED("brightnessPointerPosition")] 
		public CFloat BrightnessPointerPosition
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(111)] 
		[RED("mouseInputEnabled")] 
		public CBool MouseInputEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(112)] 
		[RED("lightsEditingEnabled")] 
		public CBool LightsEditingEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(113)] 
		[RED("hasCustomRims")] 
		public CBool HasCustomRims
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(114)] 
		[RED("hasUniquePaintjobs")] 
		public CBool HasUniquePaintjobs
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(115)] 
		[RED("saturationSliderHolded")] 
		public CBool SaturationSliderHolded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(116)] 
		[RED("brightnessSliderHolded")] 
		public CBool BrightnessSliderHolded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(117)] 
		[RED("ChromaSliderStepPad")] 
		public CFloat ChromaSliderStepPad
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(118)] 
		[RED("ChromaSliderStepMouse")] 
		public CFloat ChromaSliderStepMouse
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(119)] 
		[RED("sliderHoldGamepad")] 
		public CBool SliderHoldGamepad
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(120)] 
		[RED("sliderHoldGamepadDamp")] 
		public CInt32 SliderHoldGamepadDamp
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(121)] 
		[RED("sliderPadHoldAccelerationTreshhold")] 
		public CInt32 SliderPadHoldAccelerationTreshhold
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(122)] 
		[RED("storedSelectedColorID")] 
		public CInt32 StoredSelectedColorID
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(123)] 
		[RED("cachedNewColorA")] 
		public CColor CachedNewColorA
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(124)] 
		[RED("cachedNewColorB")] 
		public CColor CachedNewColorB
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(125)] 
		[RED("cachedNewColorLights")] 
		public CColor CachedNewColorLights
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(126)] 
		[RED("CloseReason")] 
		public CEnum<vehicleColorSelectorMenuCloseReason> CloseReason
		{
			get => GetPropertyValue<CEnum<vehicleColorSelectorMenuCloseReason>>();
			set => SetPropertyValue<CEnum<vehicleColorSelectorMenuCloseReason>>(value);
		}

		[Ordinal(127)] 
		[RED("unsupportedVehicle")] 
		public CBool UnsupportedVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(128)] 
		[RED("previewDataMissing")] 
		public CBool PreviewDataMissing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(129)] 
		[RED("virtualGenericTemplateGridController")] 
		public CWeakHandle<TwintoneTemplateGridController> VirtualGenericTemplateGridController
		{
			get => GetPropertyValue<CWeakHandle<TwintoneTemplateGridController>>();
			set => SetPropertyValue<CWeakHandle<TwintoneTemplateGridController>>(value);
		}

		[Ordinal(130)] 
		[RED("virtualUniqueTemplateGridController")] 
		public CWeakHandle<TwintoneTemplateGridController> VirtualUniqueTemplateGridController
		{
			get => GetPropertyValue<CWeakHandle<TwintoneTemplateGridController>>();
			set => SetPropertyValue<CWeakHandle<TwintoneTemplateGridController>>(value);
		}

		[Ordinal(131)] 
		[RED("genericGridInitialized")] 
		public CBool GenericGridInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(132)] 
		[RED("uniqueGridInitialized")] 
		public CBool UniqueGridInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(133)] 
		[RED("currentTemplate")] 
		public VehicleVisualCustomizationTemplate CurrentTemplate
		{
			get => GetPropertyValue<VehicleVisualCustomizationTemplate>();
			set => SetPropertyValue<VehicleVisualCustomizationTemplate>(value);
		}

		[Ordinal(134)] 
		[RED("toggledTemplate")] 
		public VehicleVisualCustomizationTemplate ToggledTemplate
		{
			get => GetPropertyValue<VehicleVisualCustomizationTemplate>();
			set => SetPropertyValue<VehicleVisualCustomizationTemplate>(value);
		}

		[Ordinal(135)] 
		[RED("currentTemplatePreview")] 
		public CWeakHandle<ColorTemplatePreviewDisplayController> CurrentTemplatePreview
		{
			get => GetPropertyValue<CWeakHandle<ColorTemplatePreviewDisplayController>>();
			set => SetPropertyValue<CWeakHandle<ColorTemplatePreviewDisplayController>>(value);
		}

		[Ordinal(136)] 
		[RED("activePanel")] 
		public CEnum<vehicleColorSelectorActiveTab> ActivePanel
		{
			get => GetPropertyValue<CEnum<vehicleColorSelectorActiveTab>>();
			set => SetPropertyValue<CEnum<vehicleColorSelectorActiveTab>>(value);
		}

		[Ordinal(137)] 
		[RED("activeSBBar")] 
		public CEnum<vehicleColorSelectorSBBar> ActiveSBBar
		{
			get => GetPropertyValue<CEnum<vehicleColorSelectorSBBar>>();
			set => SetPropertyValue<CEnum<vehicleColorSelectorSBBar>>(value);
		}

		[Ordinal(138)] 
		[RED("mainPanelAnimProxy")] 
		public CHandle<inkanimProxy> MainPanelAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(139)] 
		[RED("twintonePanelAnimProxy")] 
		public CHandle<inkanimProxy> TwintonePanelAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(140)] 
		[RED("carGlitchProxy")] 
		public CHandle<inkanimProxy> CarGlitchProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(141)] 
		[RED("crackedAnimProxy")] 
		public CHandle<inkanimProxy> CrackedAnimProxy
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
			ClassicBackgrounds = new();
			MordredBackgrounds = new();
			ColorWheelColorA = new inkWidgetReference();
			ColorWheelColorB = new inkWidgetReference();
			ColorWheelColorLights = new inkWidgetReference();
			ColorWheelColorLightsCircle = new inkWidgetReference();
			ColorWheelColorLightsFixedCircleContainer = new inkWidgetReference();
			ColorWheelColorLightsFixedCircle = new inkWidgetReference();
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
			VehiclePreviewGlowBackground = new inkImageWidgetReference();
			VehiclePreviewGlowA = new inkImageWidgetReference();
			VehiclePreviewGlowB = new inkImageWidgetReference();
			VehiclePreviewGlowLights = new inkImageWidgetReference();
			VehiclePreviewScalingCanvas = new inkWidgetReference();
			LightsPreviewBeamA = new inkImageWidgetReference();
			LightsPreviewBeamB = new inkImageWidgetReference();
			LightsPreviewBeamBike = new inkImageWidgetReference();
			LightErrorMessage = new inkTextWidgetReference();
			TimeDilationProfile = "radialMenu";
			IntroAnimation = "Intro";
			CancelAnimation = "Cancel";
			ApplyAnimation = "Apply";
			TitleTextMain = new inkTextWidgetReference();
			TitleTextNumber = new inkTextWidgetReference();
			ColorHints = new inkWidgetReference();
			MouseHitSaturationBar = new inkWidgetReference();
			SaturationBarFill = new inkWidgetReference();
			SaturationPointer = new inkWidgetReference();
			SaturationBarHighlight = new inkImageWidgetReference();
			SaturationBarHint = new inkWidgetReference();
			BrightnessBarHighlight = new inkImageWidgetReference();
			BrightnessBarHint = new inkWidgetReference();
			HeadlightsIcon = new inkWidgetReference();
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
			UniqueColorPanel = new inkWidgetReference();
			UniqueColorErrorPanel = new inkWidgetReference();
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
