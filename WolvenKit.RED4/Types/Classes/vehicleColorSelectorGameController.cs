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
		[RED("colorWheelColorA")] 
		public inkWidgetReference ColorWheelColorA
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("colorWheelColorB")] 
		public inkWidgetReference ColorWheelColorB
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("colorWheelColorLights")] 
		public inkWidgetReference ColorWheelColorLights
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("colorPickerA")] 
		public vehicleColorSelectorPointerDef ColorPickerA
		{
			get => GetPropertyValue<vehicleColorSelectorPointerDef>();
			set => SetPropertyValue<vehicleColorSelectorPointerDef>(value);
		}

		[Ordinal(10)] 
		[RED("selectedColorPointerA")] 
		public vehicleColorSelectorPointerDef SelectedColorPointerA
		{
			get => GetPropertyValue<vehicleColorSelectorPointerDef>();
			set => SetPropertyValue<vehicleColorSelectorPointerDef>(value);
		}

		[Ordinal(11)] 
		[RED("colorPickerB")] 
		public vehicleColorSelectorPointerDef ColorPickerB
		{
			get => GetPropertyValue<vehicleColorSelectorPointerDef>();
			set => SetPropertyValue<vehicleColorSelectorPointerDef>(value);
		}

		[Ordinal(12)] 
		[RED("selectedColorPointerB")] 
		public vehicleColorSelectorPointerDef SelectedColorPointerB
		{
			get => GetPropertyValue<vehicleColorSelectorPointerDef>();
			set => SetPropertyValue<vehicleColorSelectorPointerDef>(value);
		}

		[Ordinal(13)] 
		[RED("colorPickerLights")] 
		public vehicleColorSelectorPointerDef ColorPickerLights
		{
			get => GetPropertyValue<vehicleColorSelectorPointerDef>();
			set => SetPropertyValue<vehicleColorSelectorPointerDef>(value);
		}

		[Ordinal(14)] 
		[RED("selectedColorPointerLights")] 
		public vehicleColorSelectorPointerDef SelectedColorPointerLights
		{
			get => GetPropertyValue<vehicleColorSelectorPointerDef>();
			set => SetPropertyValue<vehicleColorSelectorPointerDef>(value);
		}

		[Ordinal(15)] 
		[RED("mouseHitColor1Ref")] 
		public inkWidgetReference MouseHitColor1Ref
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("mouseHitColor2Ref")] 
		public inkWidgetReference MouseHitColor2Ref
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("mouseHitLightsRef")] 
		public inkWidgetReference MouseHitLightsRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("targetColorPrintA")] 
		public inkWidgetReference TargetColorPrintA
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("targetColorPrintB")] 
		public inkWidgetReference TargetColorPrintB
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("targetColorPrintLights")] 
		public CArray<inkWidgetReference> TargetColorPrintLights
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(21)] 
		[RED("timeDilationProfile")] 
		public CString TimeDilationProfile
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(22)] 
		[RED("introAnimation")] 
		public CName IntroAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(23)] 
		[RED("cancelAnimation")] 
		public CName CancelAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(24)] 
		[RED("applyAnimation")] 
		public CName ApplyAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(25)] 
		[RED("titleTextMain")] 
		public inkTextWidgetReference TitleTextMain
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("titleTextNumber")] 
		public inkTextWidgetReference TitleTextNumber
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("brightnessBarContainer")] 
		public inkWidgetReference BrightnessBarContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("brightnessBarFill")] 
		public inkWidgetReference BrightnessBarFill
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("brightnessPointer")] 
		public inkWidgetReference BrightnessPointer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("sliderInputHintUp")] 
		public inkWidgetReference SliderInputHintUp
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("sliderInputHintDown")] 
		public inkWidgetReference SliderInputHintDown
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("modeChangeBack")] 
		public inkWidgetReference ModeChangeBack
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("modeChangeNext")] 
		public inkWidgetReference ModeChangeNext
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("applyContainerWidget")] 
		public inkWidgetReference ApplyContainerWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("resetContainerWidget")] 
		public inkWidgetReference ResetContainerWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("vehicleUnknownPane")] 
		public inkWidgetReference VehicleUnknownPane
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("vehicleBrandIcon")] 
		public inkImageWidgetReference VehicleBrandIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(38)] 
		[RED("popupData")] 
		public CHandle<inkGameNotificationData> PopupData
		{
			get => GetPropertyValue<CHandle<inkGameNotificationData>>();
			set => SetPropertyValue<CHandle<inkGameNotificationData>>(value);
		}

		[Ordinal(39)] 
		[RED("systemRequestsHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> SystemRequestsHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		[Ordinal(40)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(41)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(42)] 
		[RED("timeSystem")] 
		public CHandle<gameTimeSystem> TimeSystem
		{
			get => GetPropertyValue<CHandle<gameTimeSystem>>();
			set => SetPropertyValue<CHandle<gameTimeSystem>>(value);
		}

		[Ordinal(43)] 
		[RED("vehicle")] 
		public CWeakHandle<vehicleBaseObject> Vehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(44)] 
		[RED("vvcComponent")] 
		public CWeakHandle<vehicleVisualCustomizationComponent> VvcComponent
		{
			get => GetPropertyValue<CWeakHandle<vehicleVisualCustomizationComponent>>();
			set => SetPropertyValue<CWeakHandle<vehicleVisualCustomizationComponent>>(value);
		}

		[Ordinal(45)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(46)] 
		[RED("fakeUpdateProxy")] 
		public CHandle<inkanimProxy> FakeUpdateProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(47)] 
		[RED("SBBarProxy")] 
		public CHandle<inkanimProxy> SBBarProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(48)] 
		[RED("LightsFocusProxy")] 
		public CHandle<inkanimProxy> LightsFocusProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(49)] 
		[RED("stickersPage")] 
		public CWeakHandle<inkWidget> StickersPage
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(50)] 
		[RED("isInMenuCallbackID")] 
		public CHandle<redCallbackObject> IsInMenuCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(51)] 
		[RED("activeMode")] 
		public CEnum<vehicleColorSelectorActiveMode> ActiveMode
		{
			get => GetPropertyValue<CEnum<vehicleColorSelectorActiveMode>>();
			set => SetPropertyValue<CEnum<vehicleColorSelectorActiveMode>>(value);
		}

		[Ordinal(52)] 
		[RED("previousMode")] 
		public CEnum<vehicleColorSelectorActiveMode> PreviousMode
		{
			get => GetPropertyValue<CEnum<vehicleColorSelectorActiveMode>>();
			set => SetPropertyValue<CEnum<vehicleColorSelectorActiveMode>>(value);
		}

		[Ordinal(53)] 
		[RED("currentAngle")] 
		public CFloat CurrentAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(54)] 
		[RED("colorADefined")] 
		public CBool ColorADefined
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(55)] 
		[RED("colorBDefined")] 
		public CBool ColorBDefined
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(56)] 
		[RED("lightsDefined")] 
		public CBool LightsDefined
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(57)] 
		[RED("targetColorAngleA")] 
		public CFloat TargetColorAngleA
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(58)] 
		[RED("targetColorAngleB")] 
		public CFloat TargetColorAngleB
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(59)] 
		[RED("targetColorAngleLights")] 
		public CFloat TargetColorAngleLights
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(60)] 
		[RED("targetColorASaturation")] 
		public CFloat TargetColorASaturation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(61)] 
		[RED("targetColorBSaturation")] 
		public CFloat TargetColorBSaturation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(62)] 
		[RED("targetColorABrightness")] 
		public CFloat TargetColorABrightness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(63)] 
		[RED("targetColorBBrightness")] 
		public CFloat TargetColorBBrightness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(64)] 
		[RED("axisInputCache")] 
		public Vector2 AxisInputCache
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(65)] 
		[RED("inputEnabled")] 
		public CBool InputEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(66)] 
		[RED("sbBarShown")] 
		public CBool SbBarShown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(67)] 
		[RED("sbSliderLenght")] 
		public CFloat SbSliderLenght
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(68)] 
		[RED("axisInputThreshold")] 
		public CFloat AxisInputThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(69)] 
		[RED("currentSBSliderPositionA")] 
		public CFloat CurrentSBSliderPositionA
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(70)] 
		[RED("currentSBSliderPositionB")] 
		public CFloat CurrentSBSliderPositionB
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(71)] 
		[RED("mouseInputEnabled")] 
		public CBool MouseInputEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(72)] 
		[RED("hoveredOver")] 
		public CBool HoveredOver
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(73)] 
		[RED("SBSliderStepPad")] 
		public CFloat SBSliderStepPad
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(74)] 
		[RED("SBSliderStepMouse")] 
		public CFloat SBSliderStepMouse
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(75)] 
		[RED("sliderHold")] 
		public CBool SliderHold
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(76)] 
		[RED("sliderHoldDamp")] 
		public CInt32 SliderHoldDamp
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(77)] 
		[RED("sliderPadHoldAccelerationTreshhold")] 
		public CInt32 SliderPadHoldAccelerationTreshhold
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(78)] 
		[RED("storedSelectedColorID")] 
		public CInt32 StoredSelectedColorID
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(79)] 
		[RED("cachedNewColorA")] 
		public CColor CachedNewColorA
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(80)] 
		[RED("cachedNewColorB")] 
		public CColor CachedNewColorB
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(81)] 
		[RED("cachedNewColorLights")] 
		public CColor CachedNewColorLights
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(82)] 
		[RED("CloseReason")] 
		public CEnum<vehicleColorSelectorMenuCloseReason> CloseReason
		{
			get => GetPropertyValue<CEnum<vehicleColorSelectorMenuCloseReason>>();
			set => SetPropertyValue<CEnum<vehicleColorSelectorMenuCloseReason>>(value);
		}

		[Ordinal(83)] 
		[RED("unsupportedVehicle")] 
		public CBool UnsupportedVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public vehicleColorSelectorGameController()
		{
			CursorRootContainerRef = new inkWidgetReference();
			CursorRootOffsetPoint = new inkWidgetReference();
			ColorPaletteRef = new inkWidgetReference();
			StickerPaletteRef = new inkWidgetReference();
			ColorWheelColorA = new inkWidgetReference();
			ColorWheelColorB = new inkWidgetReference();
			ColorWheelColorLights = new inkWidgetReference();
			ColorPickerA = new vehicleColorSelectorPointerDef { PointerRoot = new inkWidgetReference(), PartToPaint = new inkWidgetReference() };
			SelectedColorPointerA = new vehicleColorSelectorPointerDef { PointerRoot = new inkWidgetReference(), PartToPaint = new inkWidgetReference() };
			ColorPickerB = new vehicleColorSelectorPointerDef { PointerRoot = new inkWidgetReference(), PartToPaint = new inkWidgetReference() };
			SelectedColorPointerB = new vehicleColorSelectorPointerDef { PointerRoot = new inkWidgetReference(), PartToPaint = new inkWidgetReference() };
			ColorPickerLights = new vehicleColorSelectorPointerDef { PointerRoot = new inkWidgetReference(), PartToPaint = new inkWidgetReference() };
			SelectedColorPointerLights = new vehicleColorSelectorPointerDef { PointerRoot = new inkWidgetReference(), PartToPaint = new inkWidgetReference() };
			MouseHitColor1Ref = new inkWidgetReference();
			MouseHitColor2Ref = new inkWidgetReference();
			MouseHitLightsRef = new inkWidgetReference();
			TargetColorPrintA = new inkWidgetReference();
			TargetColorPrintB = new inkWidgetReference();
			TargetColorPrintLights = new();
			TimeDilationProfile = "radialMenu";
			IntroAnimation = "Intro";
			CancelAnimation = "Cancel";
			ApplyAnimation = "Apply";
			TitleTextMain = new inkTextWidgetReference();
			TitleTextNumber = new inkTextWidgetReference();
			BrightnessBarContainer = new inkWidgetReference();
			BrightnessBarFill = new inkWidgetReference();
			BrightnessPointer = new inkWidgetReference();
			SliderInputHintUp = new inkWidgetReference();
			SliderInputHintDown = new inkWidgetReference();
			ModeChangeBack = new inkWidgetReference();
			ModeChangeNext = new inkWidgetReference();
			ApplyContainerWidget = new inkWidgetReference();
			ResetContainerWidget = new inkWidgetReference();
			VehicleUnknownPane = new inkWidgetReference();
			VehicleBrandIcon = new inkImageWidgetReference();
			GameInstance = new ScriptGameInstance();
			ActiveMode = Enums.vehicleColorSelectorActiveMode.Primary;
			AxisInputCache = new Vector2();
			SbSliderLenght = 756.000000F;
			AxisInputThreshold = 0.100000F;
			SBSliderStepPad = 18.000000F;
			SBSliderStepMouse = 18.000000F;
			SliderPadHoldAccelerationTreshhold = 50;
			CachedNewColorA = new CColor();
			CachedNewColorB = new CColor();
			CachedNewColorLights = new CColor();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
