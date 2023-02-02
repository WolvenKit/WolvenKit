using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BraindanceGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("currentTimerMarker")] 
		public inkWidgetReference CurrentTimerMarker
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("currentTimerText")] 
		public inkTextWidgetReference CurrentTimerText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("activeLayer")] 
		public inkTextWidgetReference ActiveLayer
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("layerIcon")] 
		public inkImageWidgetReference LayerIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("layerThermalIcon")] 
		public inkImageWidgetReference LayerThermalIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("layerVisualIcon")] 
		public inkImageWidgetReference LayerVisualIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("layerAudioIcon")] 
		public inkImageWidgetReference LayerAudioIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("cursorPoint")] 
		public inkWidgetReference CursorPoint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("clueHolder")] 
		public CArray<inkCompoundWidgetReference> ClueHolder
		{
			get => GetPropertyValue<CArray<inkCompoundWidgetReference>>();
			set => SetPropertyValue<CArray<inkCompoundWidgetReference>>(value);
		}

		[Ordinal(19)] 
		[RED("clueBarHolder")] 
		public CArray<inkWidgetReference> ClueBarHolder
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(20)] 
		[RED("speedIndicatorManagers")] 
		public CArray<inkWidgetReference> SpeedIndicatorManagers
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(21)] 
		[RED("clueArray")] 
		public CArray<CWeakHandle<BraindanceClueLogicController>> ClueArray
		{
			get => GetPropertyValue<CArray<CWeakHandle<BraindanceClueLogicController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<BraindanceClueLogicController>>>(value);
		}

		[Ordinal(22)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(23)] 
		[RED("barSize")] 
		public CFloat BarSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(24)] 
		[RED("braindanceDuration")] 
		public CFloat BraindanceDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(25)] 
		[RED("currentTime")] 
		public CFloat CurrentTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(26)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(27)] 
		[RED("currentLayer")] 
		public CEnum<gameuiEBraindanceLayer> CurrentLayer
		{
			get => GetPropertyValue<CEnum<gameuiEBraindanceLayer>>();
			set => SetPropertyValue<CEnum<gameuiEBraindanceLayer>>(value);
		}

		[Ordinal(28)] 
		[RED("currentSpeed")] 
		public CEnum<scnPlaySpeed> CurrentSpeed
		{
			get => GetPropertyValue<CEnum<scnPlaySpeed>>();
			set => SetPropertyValue<CEnum<scnPlaySpeed>>(value);
		}

		[Ordinal(29)] 
		[RED("currentDirection")] 
		public CEnum<scnPlayDirection> CurrentDirection
		{
			get => GetPropertyValue<CEnum<scnPlayDirection>>();
			set => SetPropertyValue<CEnum<scnPlayDirection>>(value);
		}

		[Ordinal(30)] 
		[RED("startingTimerTopMargin")] 
		public CFloat StartingTimerTopMargin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(31)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(32)] 
		[RED("braindanceBB")] 
		public CWeakHandle<gameIBlackboard> BraindanceBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(33)] 
		[RED("braindanceDef")] 
		public CHandle<BraindanceBlackboardDef> BraindanceDef
		{
			get => GetPropertyValue<CHandle<BraindanceBlackboardDef>>();
			set => SetPropertyValue<CHandle<BraindanceBlackboardDef>>(value);
		}

		[Ordinal(34)] 
		[RED("ClueBBID")] 
		public CHandle<redCallbackObject> ClueBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(35)] 
		[RED("VisionModeBBID")] 
		public CHandle<redCallbackObject> VisionModeBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(36)] 
		[RED("ProgressBBID")] 
		public CHandle<redCallbackObject> ProgressBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(37)] 
		[RED("SectionTimeBBID")] 
		public CHandle<redCallbackObject> SectionTimeBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(38)] 
		[RED("IsActiveBBID")] 
		public CHandle<redCallbackObject> IsActiveBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(39)] 
		[RED("EnableExitBBID")] 
		public CHandle<redCallbackObject> EnableExitBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(40)] 
		[RED("IsFPPBBID")] 
		public CHandle<redCallbackObject> IsFPPBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(41)] 
		[RED("PlaybackSpeedID")] 
		public CHandle<redCallbackObject> PlaybackSpeedID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(42)] 
		[RED("PlaybackDirectionID")] 
		public CHandle<redCallbackObject> PlaybackDirectionID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(43)] 
		[RED("isFPPMode")] 
		public CBool IsFPPMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(44)] 
		[RED("showTimelineAnimation")] 
		public CHandle<inkanimProxy> ShowTimelineAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(45)] 
		[RED("hideTimelineAnimation")] 
		public CHandle<inkanimProxy> HideTimelineAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(46)] 
		[RED("showWidgetAnimation")] 
		public CHandle<inkanimProxy> ShowWidgetAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public BraindanceGameController()
		{
			CurrentTimerMarker = new();
			CurrentTimerText = new();
			ActiveLayer = new();
			LayerIcon = new();
			LayerThermalIcon = new();
			LayerVisualIcon = new();
			LayerAudioIcon = new();
			CursorPoint = new();
			ButtonHintsManagerRef = new();
			ClueHolder = new();
			ClueBarHolder = new();
			SpeedIndicatorManagers = new();
			ClueArray = new();
			GameInstance = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
