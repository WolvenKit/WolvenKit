using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AccumulatedDamageDigitLogicController : inkWidgetLogicController
	{
		private inkTextWidgetReference _critWidget;
		private inkTextWidgetReference _headshotWidget;
		private CWeakHandle<inkWidget> _rootWidget;
		private CWeakHandle<inkWidget> _panelWidget;
		private CWeakHandle<inkTextWidget> _textWidget;
		private CWeakHandle<gameObject> _owner;
		private CWeakHandle<DamageDigitsGameController> _gameController;
		private CBool _active;
		private CBool _successful;
		private CBool _successfulCritical;
		private CFloat _damageAccumulated;
		private CBool _showingBothDigits;
		private CBool _stickToTarget;
		private CBool _currentlySticking;
		private CHandle<inkScreenProjection> _projection;
		private CHandle<inkanimProxy> _showAnimProxy;
		private CHandle<inkanimProxy> _critAnimProxy;
		private CHandle<inkanimProxy> _blinkProxy;
		private CHandle<inkanimProxy> _headshotAnimProxy;
		private CFloat _distanceModifier;
		private CFloat _calculatedDistanceHeightBias;
		private CFloat _stickingDistanceHeightBias;
		private inkMargin _projectionInterpolationOffset;
		private inkMargin _projectionInterpolationOffsetTotal;
		private CFloat _projectionInterpolationProgress;
		private CBool _projectionFreezePosition;
		private CBool _positionUpdated;
		private CFloat _currentEngineTime;
		private CFloat _lastEngineTime;
		private CInt32 _arrayPosition;
		private CHandle<inkanimDefinition> _showPositiveAnimDef;
		private CHandle<inkanimTransparencyInterpolator> _showPositiveAnimFadeInInterpolator;
		private CHandle<inkanimTransparencyInterpolator> _showPositiveAnimFadeOutInterpolator;
		private CHandle<inkanimMarginInterpolator> _showPositiveAnimMarginInterpolator;
		private CHandle<inkanimScaleInterpolator> _showPositiveAnimScaleUpInterpolator;
		private CHandle<inkanimScaleInterpolator> _showPositiveAnimScaleDownInterpolator;
		private CHandle<inkanimDefinition> _showNegativeAnimDef;
		private CHandle<inkanimTransparencyInterpolator> _showNegativeAnimFadeInInterpolator;
		private CHandle<inkanimTransparencyInterpolator> _showNegativeAnimFadeOutInterpolator;
		private CHandle<inkanimMarginInterpolator> _showNegativeAnimMarginInterpolator;
		private CHandle<inkanimDefinition> _showCritAnimDef;
		private CHandle<inkanimTransparencyInterpolator> _showCritAnimFadeOutInterpolator;
		private Vector4 _animStickTargetOffset;
		private CFloat _animTimeFadeIn;
		private CFloat _animTimeFadeOut;
		private CFloat _animBothTimeFadeIn;
		private CFloat _animBothTimeFadeOut;
		private CFloat _animTimeDelay;
		private CFloat _animBothTimeDelay;
		private CFloat _animStartHeight;
		private CFloat _animEndHeight;
		private CFloat _animPopScale;
		private CFloat _animPopEndScale;
		private CFloat _animPopInDuration;
		private CFloat _animPopOutDuration;
		private CFloat _animBothOffsetX;
		private CFloat _animBothOffsetY;
		private CFloat _animBothStickingOffsetY;
		private CFloat _animTimeCritDelay;
		private CFloat _animBothTimeCritDelay;
		private CFloat _animTimeCritFade;
		private CFloat _animBothTimeCritFade;
		private CFloat _animMaxScreenDistanceFromLast;
		private CFloat _animScreenInterpolationTime;
		private CFloat _animMinScreenDistanceFromLast;
		private CFloat _animStickTargetWorldZOffset;
		private CFloat _animStickingOffsetY;
		private CFloat _animDistanceModifierMinDistance;
		private CFloat _animDistanceModifierMaxDistance;
		private CFloat _animDistanceModifierMinValue;
		private CFloat _animDistanceModifierMaxValue;
		private CFloat _animDistanceHeightBias;
		private CFloat _animStickingDistanceHeightBias;
		private CFloat _animPositiveOpacity;
		private CFloat _animNegativeOpacity;
		private CFloat _animDynamicFadeInDuration;

		[Ordinal(1)] 
		[RED("critWidget")] 
		public inkTextWidgetReference CritWidget
		{
			get => GetProperty(ref _critWidget);
			set => SetProperty(ref _critWidget, value);
		}

		[Ordinal(2)] 
		[RED("headshotWidget")] 
		public inkTextWidgetReference HeadshotWidget
		{
			get => GetProperty(ref _headshotWidget);
			set => SetProperty(ref _headshotWidget, value);
		}

		[Ordinal(3)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(4)] 
		[RED("panelWidget")] 
		public CWeakHandle<inkWidget> PanelWidget
		{
			get => GetProperty(ref _panelWidget);
			set => SetProperty(ref _panelWidget, value);
		}

		[Ordinal(5)] 
		[RED("textWidget")] 
		public CWeakHandle<inkTextWidget> TextWidget
		{
			get => GetProperty(ref _textWidget);
			set => SetProperty(ref _textWidget, value);
		}

		[Ordinal(6)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(7)] 
		[RED("gameController")] 
		public CWeakHandle<DamageDigitsGameController> GameController
		{
			get => GetProperty(ref _gameController);
			set => SetProperty(ref _gameController, value);
		}

		[Ordinal(8)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}

		[Ordinal(9)] 
		[RED("successful")] 
		public CBool Successful
		{
			get => GetProperty(ref _successful);
			set => SetProperty(ref _successful, value);
		}

		[Ordinal(10)] 
		[RED("successfulCritical")] 
		public CBool SuccessfulCritical
		{
			get => GetProperty(ref _successfulCritical);
			set => SetProperty(ref _successfulCritical, value);
		}

		[Ordinal(11)] 
		[RED("damageAccumulated")] 
		public CFloat DamageAccumulated
		{
			get => GetProperty(ref _damageAccumulated);
			set => SetProperty(ref _damageAccumulated, value);
		}

		[Ordinal(12)] 
		[RED("showingBothDigits")] 
		public CBool ShowingBothDigits
		{
			get => GetProperty(ref _showingBothDigits);
			set => SetProperty(ref _showingBothDigits, value);
		}

		[Ordinal(13)] 
		[RED("stickToTarget")] 
		public CBool StickToTarget
		{
			get => GetProperty(ref _stickToTarget);
			set => SetProperty(ref _stickToTarget, value);
		}

		[Ordinal(14)] 
		[RED("currentlySticking")] 
		public CBool CurrentlySticking
		{
			get => GetProperty(ref _currentlySticking);
			set => SetProperty(ref _currentlySticking, value);
		}

		[Ordinal(15)] 
		[RED("projection")] 
		public CHandle<inkScreenProjection> Projection
		{
			get => GetProperty(ref _projection);
			set => SetProperty(ref _projection, value);
		}

		[Ordinal(16)] 
		[RED("showAnimProxy")] 
		public CHandle<inkanimProxy> ShowAnimProxy
		{
			get => GetProperty(ref _showAnimProxy);
			set => SetProperty(ref _showAnimProxy, value);
		}

		[Ordinal(17)] 
		[RED("critAnimProxy")] 
		public CHandle<inkanimProxy> CritAnimProxy
		{
			get => GetProperty(ref _critAnimProxy);
			set => SetProperty(ref _critAnimProxy, value);
		}

		[Ordinal(18)] 
		[RED("blinkProxy")] 
		public CHandle<inkanimProxy> BlinkProxy
		{
			get => GetProperty(ref _blinkProxy);
			set => SetProperty(ref _blinkProxy, value);
		}

		[Ordinal(19)] 
		[RED("headshotAnimProxy")] 
		public CHandle<inkanimProxy> HeadshotAnimProxy
		{
			get => GetProperty(ref _headshotAnimProxy);
			set => SetProperty(ref _headshotAnimProxy, value);
		}

		[Ordinal(20)] 
		[RED("distanceModifier")] 
		public CFloat DistanceModifier
		{
			get => GetProperty(ref _distanceModifier);
			set => SetProperty(ref _distanceModifier, value);
		}

		[Ordinal(21)] 
		[RED("calculatedDistanceHeightBias")] 
		public CFloat CalculatedDistanceHeightBias
		{
			get => GetProperty(ref _calculatedDistanceHeightBias);
			set => SetProperty(ref _calculatedDistanceHeightBias, value);
		}

		[Ordinal(22)] 
		[RED("stickingDistanceHeightBias")] 
		public CFloat StickingDistanceHeightBias
		{
			get => GetProperty(ref _stickingDistanceHeightBias);
			set => SetProperty(ref _stickingDistanceHeightBias, value);
		}

		[Ordinal(23)] 
		[RED("projectionInterpolationOffset")] 
		public inkMargin ProjectionInterpolationOffset
		{
			get => GetProperty(ref _projectionInterpolationOffset);
			set => SetProperty(ref _projectionInterpolationOffset, value);
		}

		[Ordinal(24)] 
		[RED("projectionInterpolationOffsetTotal")] 
		public inkMargin ProjectionInterpolationOffsetTotal
		{
			get => GetProperty(ref _projectionInterpolationOffsetTotal);
			set => SetProperty(ref _projectionInterpolationOffsetTotal, value);
		}

		[Ordinal(25)] 
		[RED("projectionInterpolationProgress")] 
		public CFloat ProjectionInterpolationProgress
		{
			get => GetProperty(ref _projectionInterpolationProgress);
			set => SetProperty(ref _projectionInterpolationProgress, value);
		}

		[Ordinal(26)] 
		[RED("projectionFreezePosition")] 
		public CBool ProjectionFreezePosition
		{
			get => GetProperty(ref _projectionFreezePosition);
			set => SetProperty(ref _projectionFreezePosition, value);
		}

		[Ordinal(27)] 
		[RED("positionUpdated")] 
		public CBool PositionUpdated
		{
			get => GetProperty(ref _positionUpdated);
			set => SetProperty(ref _positionUpdated, value);
		}

		[Ordinal(28)] 
		[RED("currentEngineTime")] 
		public CFloat CurrentEngineTime
		{
			get => GetProperty(ref _currentEngineTime);
			set => SetProperty(ref _currentEngineTime, value);
		}

		[Ordinal(29)] 
		[RED("lastEngineTime")] 
		public CFloat LastEngineTime
		{
			get => GetProperty(ref _lastEngineTime);
			set => SetProperty(ref _lastEngineTime, value);
		}

		[Ordinal(30)] 
		[RED("arrayPosition")] 
		public CInt32 ArrayPosition
		{
			get => GetProperty(ref _arrayPosition);
			set => SetProperty(ref _arrayPosition, value);
		}

		[Ordinal(31)] 
		[RED("showPositiveAnimDef")] 
		public CHandle<inkanimDefinition> ShowPositiveAnimDef
		{
			get => GetProperty(ref _showPositiveAnimDef);
			set => SetProperty(ref _showPositiveAnimDef, value);
		}

		[Ordinal(32)] 
		[RED("showPositiveAnimFadeInInterpolator")] 
		public CHandle<inkanimTransparencyInterpolator> ShowPositiveAnimFadeInInterpolator
		{
			get => GetProperty(ref _showPositiveAnimFadeInInterpolator);
			set => SetProperty(ref _showPositiveAnimFadeInInterpolator, value);
		}

		[Ordinal(33)] 
		[RED("showPositiveAnimFadeOutInterpolator")] 
		public CHandle<inkanimTransparencyInterpolator> ShowPositiveAnimFadeOutInterpolator
		{
			get => GetProperty(ref _showPositiveAnimFadeOutInterpolator);
			set => SetProperty(ref _showPositiveAnimFadeOutInterpolator, value);
		}

		[Ordinal(34)] 
		[RED("showPositiveAnimMarginInterpolator")] 
		public CHandle<inkanimMarginInterpolator> ShowPositiveAnimMarginInterpolator
		{
			get => GetProperty(ref _showPositiveAnimMarginInterpolator);
			set => SetProperty(ref _showPositiveAnimMarginInterpolator, value);
		}

		[Ordinal(35)] 
		[RED("showPositiveAnimScaleUpInterpolator")] 
		public CHandle<inkanimScaleInterpolator> ShowPositiveAnimScaleUpInterpolator
		{
			get => GetProperty(ref _showPositiveAnimScaleUpInterpolator);
			set => SetProperty(ref _showPositiveAnimScaleUpInterpolator, value);
		}

		[Ordinal(36)] 
		[RED("showPositiveAnimScaleDownInterpolator")] 
		public CHandle<inkanimScaleInterpolator> ShowPositiveAnimScaleDownInterpolator
		{
			get => GetProperty(ref _showPositiveAnimScaleDownInterpolator);
			set => SetProperty(ref _showPositiveAnimScaleDownInterpolator, value);
		}

		[Ordinal(37)] 
		[RED("showNegativeAnimDef")] 
		public CHandle<inkanimDefinition> ShowNegativeAnimDef
		{
			get => GetProperty(ref _showNegativeAnimDef);
			set => SetProperty(ref _showNegativeAnimDef, value);
		}

		[Ordinal(38)] 
		[RED("showNegativeAnimFadeInInterpolator")] 
		public CHandle<inkanimTransparencyInterpolator> ShowNegativeAnimFadeInInterpolator
		{
			get => GetProperty(ref _showNegativeAnimFadeInInterpolator);
			set => SetProperty(ref _showNegativeAnimFadeInInterpolator, value);
		}

		[Ordinal(39)] 
		[RED("showNegativeAnimFadeOutInterpolator")] 
		public CHandle<inkanimTransparencyInterpolator> ShowNegativeAnimFadeOutInterpolator
		{
			get => GetProperty(ref _showNegativeAnimFadeOutInterpolator);
			set => SetProperty(ref _showNegativeAnimFadeOutInterpolator, value);
		}

		[Ordinal(40)] 
		[RED("showNegativeAnimMarginInterpolator")] 
		public CHandle<inkanimMarginInterpolator> ShowNegativeAnimMarginInterpolator
		{
			get => GetProperty(ref _showNegativeAnimMarginInterpolator);
			set => SetProperty(ref _showNegativeAnimMarginInterpolator, value);
		}

		[Ordinal(41)] 
		[RED("showCritAnimDef")] 
		public CHandle<inkanimDefinition> ShowCritAnimDef
		{
			get => GetProperty(ref _showCritAnimDef);
			set => SetProperty(ref _showCritAnimDef, value);
		}

		[Ordinal(42)] 
		[RED("showCritAnimFadeOutInterpolator")] 
		public CHandle<inkanimTransparencyInterpolator> ShowCritAnimFadeOutInterpolator
		{
			get => GetProperty(ref _showCritAnimFadeOutInterpolator);
			set => SetProperty(ref _showCritAnimFadeOutInterpolator, value);
		}

		[Ordinal(43)] 
		[RED("animStickTargetOffset")] 
		public Vector4 AnimStickTargetOffset
		{
			get => GetProperty(ref _animStickTargetOffset);
			set => SetProperty(ref _animStickTargetOffset, value);
		}

		[Ordinal(44)] 
		[RED("animTimeFadeIn")] 
		public CFloat AnimTimeFadeIn
		{
			get => GetProperty(ref _animTimeFadeIn);
			set => SetProperty(ref _animTimeFadeIn, value);
		}

		[Ordinal(45)] 
		[RED("animTimeFadeOut")] 
		public CFloat AnimTimeFadeOut
		{
			get => GetProperty(ref _animTimeFadeOut);
			set => SetProperty(ref _animTimeFadeOut, value);
		}

		[Ordinal(46)] 
		[RED("animBothTimeFadeIn")] 
		public CFloat AnimBothTimeFadeIn
		{
			get => GetProperty(ref _animBothTimeFadeIn);
			set => SetProperty(ref _animBothTimeFadeIn, value);
		}

		[Ordinal(47)] 
		[RED("animBothTimeFadeOut")] 
		public CFloat AnimBothTimeFadeOut
		{
			get => GetProperty(ref _animBothTimeFadeOut);
			set => SetProperty(ref _animBothTimeFadeOut, value);
		}

		[Ordinal(48)] 
		[RED("animTimeDelay")] 
		public CFloat AnimTimeDelay
		{
			get => GetProperty(ref _animTimeDelay);
			set => SetProperty(ref _animTimeDelay, value);
		}

		[Ordinal(49)] 
		[RED("animBothTimeDelay")] 
		public CFloat AnimBothTimeDelay
		{
			get => GetProperty(ref _animBothTimeDelay);
			set => SetProperty(ref _animBothTimeDelay, value);
		}

		[Ordinal(50)] 
		[RED("animStartHeight")] 
		public CFloat AnimStartHeight
		{
			get => GetProperty(ref _animStartHeight);
			set => SetProperty(ref _animStartHeight, value);
		}

		[Ordinal(51)] 
		[RED("animEndHeight")] 
		public CFloat AnimEndHeight
		{
			get => GetProperty(ref _animEndHeight);
			set => SetProperty(ref _animEndHeight, value);
		}

		[Ordinal(52)] 
		[RED("animPopScale")] 
		public CFloat AnimPopScale
		{
			get => GetProperty(ref _animPopScale);
			set => SetProperty(ref _animPopScale, value);
		}

		[Ordinal(53)] 
		[RED("animPopEndScale")] 
		public CFloat AnimPopEndScale
		{
			get => GetProperty(ref _animPopEndScale);
			set => SetProperty(ref _animPopEndScale, value);
		}

		[Ordinal(54)] 
		[RED("animPopInDuration")] 
		public CFloat AnimPopInDuration
		{
			get => GetProperty(ref _animPopInDuration);
			set => SetProperty(ref _animPopInDuration, value);
		}

		[Ordinal(55)] 
		[RED("animPopOutDuration")] 
		public CFloat AnimPopOutDuration
		{
			get => GetProperty(ref _animPopOutDuration);
			set => SetProperty(ref _animPopOutDuration, value);
		}

		[Ordinal(56)] 
		[RED("animBothOffsetX")] 
		public CFloat AnimBothOffsetX
		{
			get => GetProperty(ref _animBothOffsetX);
			set => SetProperty(ref _animBothOffsetX, value);
		}

		[Ordinal(57)] 
		[RED("animBothOffsetY")] 
		public CFloat AnimBothOffsetY
		{
			get => GetProperty(ref _animBothOffsetY);
			set => SetProperty(ref _animBothOffsetY, value);
		}

		[Ordinal(58)] 
		[RED("animBothStickingOffsetY")] 
		public CFloat AnimBothStickingOffsetY
		{
			get => GetProperty(ref _animBothStickingOffsetY);
			set => SetProperty(ref _animBothStickingOffsetY, value);
		}

		[Ordinal(59)] 
		[RED("animTimeCritDelay")] 
		public CFloat AnimTimeCritDelay
		{
			get => GetProperty(ref _animTimeCritDelay);
			set => SetProperty(ref _animTimeCritDelay, value);
		}

		[Ordinal(60)] 
		[RED("animBothTimeCritDelay")] 
		public CFloat AnimBothTimeCritDelay
		{
			get => GetProperty(ref _animBothTimeCritDelay);
			set => SetProperty(ref _animBothTimeCritDelay, value);
		}

		[Ordinal(61)] 
		[RED("animTimeCritFade")] 
		public CFloat AnimTimeCritFade
		{
			get => GetProperty(ref _animTimeCritFade);
			set => SetProperty(ref _animTimeCritFade, value);
		}

		[Ordinal(62)] 
		[RED("animBothTimeCritFade")] 
		public CFloat AnimBothTimeCritFade
		{
			get => GetProperty(ref _animBothTimeCritFade);
			set => SetProperty(ref _animBothTimeCritFade, value);
		}

		[Ordinal(63)] 
		[RED("animMaxScreenDistanceFromLast")] 
		public CFloat AnimMaxScreenDistanceFromLast
		{
			get => GetProperty(ref _animMaxScreenDistanceFromLast);
			set => SetProperty(ref _animMaxScreenDistanceFromLast, value);
		}

		[Ordinal(64)] 
		[RED("animScreenInterpolationTime")] 
		public CFloat AnimScreenInterpolationTime
		{
			get => GetProperty(ref _animScreenInterpolationTime);
			set => SetProperty(ref _animScreenInterpolationTime, value);
		}

		[Ordinal(65)] 
		[RED("animMinScreenDistanceFromLast")] 
		public CFloat AnimMinScreenDistanceFromLast
		{
			get => GetProperty(ref _animMinScreenDistanceFromLast);
			set => SetProperty(ref _animMinScreenDistanceFromLast, value);
		}

		[Ordinal(66)] 
		[RED("animStickTargetWorldZOffset")] 
		public CFloat AnimStickTargetWorldZOffset
		{
			get => GetProperty(ref _animStickTargetWorldZOffset);
			set => SetProperty(ref _animStickTargetWorldZOffset, value);
		}

		[Ordinal(67)] 
		[RED("animStickingOffsetY")] 
		public CFloat AnimStickingOffsetY
		{
			get => GetProperty(ref _animStickingOffsetY);
			set => SetProperty(ref _animStickingOffsetY, value);
		}

		[Ordinal(68)] 
		[RED("animDistanceModifierMinDistance")] 
		public CFloat AnimDistanceModifierMinDistance
		{
			get => GetProperty(ref _animDistanceModifierMinDistance);
			set => SetProperty(ref _animDistanceModifierMinDistance, value);
		}

		[Ordinal(69)] 
		[RED("animDistanceModifierMaxDistance")] 
		public CFloat AnimDistanceModifierMaxDistance
		{
			get => GetProperty(ref _animDistanceModifierMaxDistance);
			set => SetProperty(ref _animDistanceModifierMaxDistance, value);
		}

		[Ordinal(70)] 
		[RED("animDistanceModifierMinValue")] 
		public CFloat AnimDistanceModifierMinValue
		{
			get => GetProperty(ref _animDistanceModifierMinValue);
			set => SetProperty(ref _animDistanceModifierMinValue, value);
		}

		[Ordinal(71)] 
		[RED("animDistanceModifierMaxValue")] 
		public CFloat AnimDistanceModifierMaxValue
		{
			get => GetProperty(ref _animDistanceModifierMaxValue);
			set => SetProperty(ref _animDistanceModifierMaxValue, value);
		}

		[Ordinal(72)] 
		[RED("animDistanceHeightBias")] 
		public CFloat AnimDistanceHeightBias
		{
			get => GetProperty(ref _animDistanceHeightBias);
			set => SetProperty(ref _animDistanceHeightBias, value);
		}

		[Ordinal(73)] 
		[RED("animStickingDistanceHeightBias")] 
		public CFloat AnimStickingDistanceHeightBias
		{
			get => GetProperty(ref _animStickingDistanceHeightBias);
			set => SetProperty(ref _animStickingDistanceHeightBias, value);
		}

		[Ordinal(74)] 
		[RED("animPositiveOpacity")] 
		public CFloat AnimPositiveOpacity
		{
			get => GetProperty(ref _animPositiveOpacity);
			set => SetProperty(ref _animPositiveOpacity, value);
		}

		[Ordinal(75)] 
		[RED("animNegativeOpacity")] 
		public CFloat AnimNegativeOpacity
		{
			get => GetProperty(ref _animNegativeOpacity);
			set => SetProperty(ref _animNegativeOpacity, value);
		}

		[Ordinal(76)] 
		[RED("animDynamicFadeInDuration")] 
		public CFloat AnimDynamicFadeInDuration
		{
			get => GetProperty(ref _animDynamicFadeInDuration);
			set => SetProperty(ref _animDynamicFadeInDuration, value);
		}

		public AccumulatedDamageDigitLogicController()
		{
			_animTimeFadeIn = 0.100000F;
			_animTimeFadeOut = 0.400000F;
			_animBothTimeFadeIn = 0.100000F;
			_animBothTimeFadeOut = 0.250000F;
			_animTimeDelay = 1.300000F;
			_animBothTimeDelay = 1.750000F;
			_animStartHeight = -80.000000F;
			_animEndHeight = -140.000000F;
			_animPopScale = 1.500000F;
			_animPopEndScale = 1.200000F;
			_animPopInDuration = 0.050000F;
			_animPopOutDuration = 0.150000F;
			_animBothOffsetY = -50.000000F;
			_animBothStickingOffsetY = -105.000000F;
			_animTimeCritDelay = 1.300000F;
			_animBothTimeCritDelay = 1.750000F;
			_animTimeCritFade = 0.400000F;
			_animBothTimeCritFade = 0.250000F;
			_animMaxScreenDistanceFromLast = 500.000000F;
			_animScreenInterpolationTime = 0.080000F;
			_animMinScreenDistanceFromLast = 60.000000F;
			_animStickTargetWorldZOffset = 0.500000F;
			_animStickingOffsetY = -85.000000F;
			_animDistanceModifierMinDistance = 7.000000F;
			_animDistanceModifierMaxDistance = 25.000000F;
			_animDistanceModifierMinValue = 0.600000F;
			_animDistanceModifierMaxValue = 1.000000F;
			_animDistanceHeightBias = 70.000000F;
			_animStickingDistanceHeightBias = 70.000000F;
			_animPositiveOpacity = 1.000000F;
			_animNegativeOpacity = 0.800000F;
		}
	}
}
