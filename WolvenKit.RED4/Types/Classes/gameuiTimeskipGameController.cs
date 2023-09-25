using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiTimeskipGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("currentTimeLabel")] 
		public inkTextWidgetReference CurrentTimeLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("tragetTimeLabel")] 
		public inkTextWidgetReference TragetTimeLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("diffTimeLabel")] 
		public inkTextWidgetReference DiffTimeLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("rootContainerRef")] 
		public inkWidgetReference RootContainerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("currentTimePointerRef")] 
		public inkWidgetReference CurrentTimePointerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("targetTimePointerRef")] 
		public inkWidgetReference TargetTimePointerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("timeBarRef")] 
		public inkWidgetReference TimeBarRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("circleGradientRef")] 
		public inkWidgetReference CircleGradientRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("startCircleGradientRef")] 
		public inkWidgetReference StartCircleGradientRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("mouseHitTestRef")] 
		public inkWidgetReference MouseHitTestRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("dayIconRef")] 
		public inkWidgetReference DayIconRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("nightIconRef")] 
		public inkWidgetReference NightIconRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("morningIconRef")] 
		public inkWidgetReference MorningIconRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("eveningIconRef")] 
		public inkWidgetReference EveningIconRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("weatherIcon")] 
		public inkImageWidgetReference WeatherIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("intoAnimation")] 
		public CName IntoAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("outroCancelAnimation")] 
		public CName OutroCancelAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(19)] 
		[RED("outroFinishedAnimation")] 
		public CName OutroFinishedAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(20)] 
		[RED("progressAnimation")] 
		public CName ProgressAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(21)] 
		[RED("finishingAnimation")] 
		public CName FinishingAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(22)] 
		[RED("loopAnimationMarkerFrom")] 
		public CName LoopAnimationMarkerFrom
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(23)] 
		[RED("loopAnimationMarkerTo")] 
		public CName LoopAnimationMarkerTo
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(24)] 
		[RED("mouseHoverOverAnimation")] 
		public CName MouseHoverOverAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(25)] 
		[RED("mouseHoverOutAnimation")] 
		public CName MouseHoverOutAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(26)] 
		[RED("outroAnimDuration")] 
		public CFloat OutroAnimDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(27)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(28)] 
		[RED("data")] 
		public CHandle<TimeSkipPopupData> Data
		{
			get => GetPropertyValue<CHandle<TimeSkipPopupData>>();
			set => SetPropertyValue<CHandle<TimeSkipPopupData>>(value);
		}

		[Ordinal(29)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(30)] 
		[RED("timeSystem")] 
		public CHandle<gameTimeSystem> TimeSystem
		{
			get => GetPropertyValue<CHandle<gameTimeSystem>>();
			set => SetPropertyValue<CHandle<gameTimeSystem>>(value);
		}

		[Ordinal(31)] 
		[RED("currentTimeTextParams")] 
		public CHandle<textTextParameterSet> CurrentTimeTextParams
		{
			get => GetPropertyValue<CHandle<textTextParameterSet>>();
			set => SetPropertyValue<CHandle<textTextParameterSet>>(value);
		}

		[Ordinal(32)] 
		[RED("targetTimeTextParams")] 
		public CHandle<textTextParameterSet> TargetTimeTextParams
		{
			get => GetPropertyValue<CHandle<textTextParameterSet>>();
			set => SetPropertyValue<CHandle<textTextParameterSet>>(value);
		}

		[Ordinal(33)] 
		[RED("diffTimeTextParams")] 
		public CHandle<textTextParameterSet> DiffTimeTextParams
		{
			get => GetPropertyValue<CHandle<textTextParameterSet>>();
			set => SetPropertyValue<CHandle<textTextParameterSet>>(value);
		}

		[Ordinal(34)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(35)] 
		[RED("progressAnimProxy")] 
		public CHandle<inkanimProxy> ProgressAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(36)] 
		[RED("hoverAnimProxy")] 
		public CHandle<inkanimProxy> HoverAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(37)] 
		[RED("currentTime")] 
		public GameTime CurrentTime
		{
			get => GetPropertyValue<GameTime>();
			set => SetPropertyValue<GameTime>(value);
		}

		[Ordinal(38)] 
		[RED("hoursToSkip")] 
		public CInt32 HoursToSkip
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(39)] 
		[RED("currentTimeAngle")] 
		public CFloat CurrentTimeAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(40)] 
		[RED("targetTimeAngle")] 
		public CFloat TargetTimeAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(41)] 
		[RED("axisInputCache")] 
		public Vector2 AxisInputCache
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(42)] 
		[RED("inputEnabled")] 
		public CBool InputEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(43)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(44)] 
		[RED("axisInputThreshold")] 
		public CFloat AxisInputThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(45)] 
		[RED("animationDurationMin")] 
		public CFloat AnimationDurationMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(46)] 
		[RED("animationDurationMax")] 
		public CFloat AnimationDurationMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(47)] 
		[RED("diff")] 
		public CFloat Diff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(48)] 
		[RED("timeSkipped")] 
		public CBool TimeSkipped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(49)] 
		[RED("mouseInputEnabled")] 
		public CBool MouseInputEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(50)] 
		[RED("scenarioEvt")] 
		public CHandle<TimeSkipFinishEvent> ScenarioEvt
		{
			get => GetPropertyValue<CHandle<TimeSkipFinishEvent>>();
			set => SetPropertyValue<CHandle<TimeSkipFinishEvent>>(value);
		}

		[Ordinal(51)] 
		[RED("hoveredOver")] 
		public CBool HoveredOver
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiTimeskipGameController()
		{
			CurrentTimeLabel = new inkTextWidgetReference();
			TragetTimeLabel = new inkTextWidgetReference();
			DiffTimeLabel = new inkTextWidgetReference();
			RootContainerRef = new inkWidgetReference();
			CurrentTimePointerRef = new inkWidgetReference();
			TargetTimePointerRef = new inkWidgetReference();
			TimeBarRef = new inkWidgetReference();
			CircleGradientRef = new inkWidgetReference();
			StartCircleGradientRef = new inkWidgetReference();
			MouseHitTestRef = new inkWidgetReference();
			DayIconRef = new inkWidgetReference();
			NightIconRef = new inkWidgetReference();
			MorningIconRef = new inkWidgetReference();
			EveningIconRef = new inkWidgetReference();
			WeatherIcon = new inkImageWidgetReference();
			IntoAnimation = "intro";
			OutroCancelAnimation = "outro_cancel";
			OutroFinishedAnimation = "outro_finish";
			ProgressAnimation = "progress";
			FinishingAnimation = "finishing";
			LoopAnimationMarkerFrom = "loop_from";
			LoopAnimationMarkerTo = "loop_to";
			MouseHoverOverAnimation = "mouseHoverOver";
			MouseHoverOutAnimation = "mouseHoverOut";
			GameInstance = new ScriptGameInstance();
			CurrentTime = new GameTime();
			HoursToSkip = 1;
			AxisInputCache = new Vector2();
			Radius = 310.000000F;
			AxisInputThreshold = 0.000500F;
			AnimationDurationMin = 3.000000F;
			AnimationDurationMax = 6.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
