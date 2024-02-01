using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleColorSelectorGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("rootContainerRef")] 
		public inkWidgetReference RootContainerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("colorPaletteRef")] 
		public inkWidgetReference ColorPaletteRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("stickerPaletteRef")] 
		public inkWidgetReference StickerPaletteRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("colorPickerA")] 
		public vehicleColorSelectorPointerDef ColorPickerA
		{
			get => GetPropertyValue<vehicleColorSelectorPointerDef>();
			set => SetPropertyValue<vehicleColorSelectorPointerDef>(value);
		}

		[Ordinal(6)] 
		[RED("selectedColorPointerA")] 
		public vehicleColorSelectorPointerDef SelectedColorPointerA
		{
			get => GetPropertyValue<vehicleColorSelectorPointerDef>();
			set => SetPropertyValue<vehicleColorSelectorPointerDef>(value);
		}

		[Ordinal(7)] 
		[RED("colorPickerB")] 
		public vehicleColorSelectorPointerDef ColorPickerB
		{
			get => GetPropertyValue<vehicleColorSelectorPointerDef>();
			set => SetPropertyValue<vehicleColorSelectorPointerDef>(value);
		}

		[Ordinal(8)] 
		[RED("selectedColorPointerB")] 
		public vehicleColorSelectorPointerDef SelectedColorPointerB
		{
			get => GetPropertyValue<vehicleColorSelectorPointerDef>();
			set => SetPropertyValue<vehicleColorSelectorPointerDef>(value);
		}

		[Ordinal(9)] 
		[RED("mouseHitTestRef")] 
		public inkWidgetReference MouseHitTestRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("mouseHitColor1Ref")] 
		public inkWidgetReference MouseHitColor1Ref
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("mouseHitColor2Ref")] 
		public inkWidgetReference MouseHitColor2Ref
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("targetColorPrintA")] 
		public inkWidgetReference TargetColorPrintA
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("targetColorPrintB")] 
		public inkWidgetReference TargetColorPrintB
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("timeDilationProfile")] 
		public CString TimeDilationProfile
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(15)] 
		[RED("introAnimation")] 
		public CName IntroAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("cancelAnimation")] 
		public CName CancelAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("applyAnimation")] 
		public CName ApplyAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("titleTextMain")] 
		public inkTextWidgetReference TitleTextMain
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("titleTextNumber")] 
		public inkTextWidgetReference TitleTextNumber
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("brightnessBarContainer")] 
		public inkWidgetReference BrightnessBarContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("brightnessBarFill")] 
		public inkWidgetReference BrightnessBarFill
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("brightnessPointer")] 
		public inkWidgetReference BrightnessPointer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("sliderInputHintUp")] 
		public inkWidgetReference SliderInputHintUp
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("sliderInputHintDown")] 
		public inkWidgetReference SliderInputHintDown
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("applyContainerWidget")] 
		public inkWidgetReference ApplyContainerWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("resetContainerWidget")] 
		public inkWidgetReference ResetContainerWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("popupData")] 
		public CHandle<inkGameNotificationData> PopupData
		{
			get => GetPropertyValue<CHandle<inkGameNotificationData>>();
			set => SetPropertyValue<CHandle<inkGameNotificationData>>(value);
		}

		[Ordinal(28)] 
		[RED("systemRequestsHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> SystemRequestsHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		[Ordinal(29)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(30)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(31)] 
		[RED("timeSystem")] 
		public CHandle<gameTimeSystem> TimeSystem
		{
			get => GetPropertyValue<CHandle<gameTimeSystem>>();
			set => SetPropertyValue<CHandle<gameTimeSystem>>(value);
		}

		[Ordinal(32)] 
		[RED("vehicle")] 
		public CWeakHandle<vehicleBaseObject> Vehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(33)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(34)] 
		[RED("fakeUpdateProxy")] 
		public CHandle<inkanimProxy> FakeUpdateProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(35)] 
		[RED("SBBarProxy")] 
		public CHandle<inkanimProxy> SBBarProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(36)] 
		[RED("stickersPage")] 
		public CWeakHandle<inkWidget> StickersPage
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(37)] 
		[RED("isInMenuCallbackID")] 
		public CHandle<redCallbackObject> IsInMenuCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(38)] 
		[RED("activeMode")] 
		public CEnum<vehicleColorSelectorActiveMode> ActiveMode
		{
			get => GetPropertyValue<CEnum<vehicleColorSelectorActiveMode>>();
			set => SetPropertyValue<CEnum<vehicleColorSelectorActiveMode>>(value);
		}

		[Ordinal(39)] 
		[RED("currentAngle")] 
		public CFloat CurrentAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(40)] 
		[RED("colorADefined")] 
		public CBool ColorADefined
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(41)] 
		[RED("colorBDefined")] 
		public CBool ColorBDefined
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(42)] 
		[RED("targetColorAngleA")] 
		public CFloat TargetColorAngleA
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(43)] 
		[RED("targetColorAngleB")] 
		public CFloat TargetColorAngleB
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(44)] 
		[RED("targetColorASaturation")] 
		public CFloat TargetColorASaturation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(45)] 
		[RED("targetColorBSaturation")] 
		public CFloat TargetColorBSaturation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(46)] 
		[RED("targetColorABrightness")] 
		public CFloat TargetColorABrightness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(47)] 
		[RED("targetColorBBrightness")] 
		public CFloat TargetColorBBrightness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(48)] 
		[RED("axisInputCache")] 
		public Vector2 AxisInputCache
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(49)] 
		[RED("inputEnabled")] 
		public CBool InputEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(50)] 
		[RED("sbBarShown")] 
		public CBool SbBarShown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(51)] 
		[RED("sbSliderLenght")] 
		public CFloat SbSliderLenght
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(52)] 
		[RED("axisInputThreshold")] 
		public CFloat AxisInputThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(53)] 
		[RED("currentSBSliderPositionA")] 
		public CFloat CurrentSBSliderPositionA
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(54)] 
		[RED("currentSBSliderPositionB")] 
		public CFloat CurrentSBSliderPositionB
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(55)] 
		[RED("mouseInputEnabled")] 
		public CBool MouseInputEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(56)] 
		[RED("hoveredOver")] 
		public CBool HoveredOver
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(57)] 
		[RED("SBSliderStepPad")] 
		public CFloat SBSliderStepPad
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(58)] 
		[RED("SBSliderStepMouse")] 
		public CFloat SBSliderStepMouse
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(59)] 
		[RED("sliderHold")] 
		public CBool SliderHold
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(60)] 
		[RED("sliderHoldDamp")] 
		public CInt32 SliderHoldDamp
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(61)] 
		[RED("sliderPadHoldAccelerationTreshhold")] 
		public CInt32 SliderPadHoldAccelerationTreshhold
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(62)] 
		[RED("storedSelectedColorID")] 
		public CInt32 StoredSelectedColorID
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(63)] 
		[RED("cachedNewColorA")] 
		public CColor CachedNewColorA
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(64)] 
		[RED("cachedNewColorB")] 
		public CColor CachedNewColorB
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(65)] 
		[RED("CloseReason")] 
		public CEnum<vehicleColorSelectorMenuCloseReason> CloseReason
		{
			get => GetPropertyValue<CEnum<vehicleColorSelectorMenuCloseReason>>();
			set => SetPropertyValue<CEnum<vehicleColorSelectorMenuCloseReason>>(value);
		}

		public vehicleColorSelectorGameController()
		{
			RootContainerRef = new inkWidgetReference();
			ColorPaletteRef = new inkWidgetReference();
			StickerPaletteRef = new inkWidgetReference();
			ColorPickerA = new vehicleColorSelectorPointerDef { PointerRoot = new inkWidgetReference(), PartToPaint = new inkWidgetReference() };
			SelectedColorPointerA = new vehicleColorSelectorPointerDef { PointerRoot = new inkWidgetReference(), PartToPaint = new inkWidgetReference() };
			ColorPickerB = new vehicleColorSelectorPointerDef { PointerRoot = new inkWidgetReference(), PartToPaint = new inkWidgetReference() };
			SelectedColorPointerB = new vehicleColorSelectorPointerDef { PointerRoot = new inkWidgetReference(), PartToPaint = new inkWidgetReference() };
			MouseHitTestRef = new inkWidgetReference();
			MouseHitColor1Ref = new inkWidgetReference();
			MouseHitColor2Ref = new inkWidgetReference();
			TargetColorPrintA = new inkWidgetReference();
			TargetColorPrintB = new inkWidgetReference();
			TimeDilationProfile = "radialMenu";
			TitleTextMain = new inkTextWidgetReference();
			TitleTextNumber = new inkTextWidgetReference();
			BrightnessBarContainer = new inkWidgetReference();
			BrightnessBarFill = new inkWidgetReference();
			BrightnessPointer = new inkWidgetReference();
			SliderInputHintUp = new inkWidgetReference();
			SliderInputHintDown = new inkWidgetReference();
			ApplyContainerWidget = new inkWidgetReference();
			ResetContainerWidget = new inkWidgetReference();
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

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
