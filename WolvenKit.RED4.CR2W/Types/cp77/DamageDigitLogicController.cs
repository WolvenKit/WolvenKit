using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DamageDigitLogicController : inkWidgetLogicController
	{
		private inkTextWidgetReference _critWidget;
		private inkTextWidgetReference _headshotWidget;
		private wCHandle<inkWidget> _rootWidget;
		private wCHandle<inkWidget> _panelWidget;
		private wCHandle<inkTextWidget> _textWidget;
		private wCHandle<DamageDigitsGameController> _gameController;
		private CBool _active;
		private CBool _successful;
		private CBool _successfulCritical;
		private CBool _showingBothDigits;
		private CFloat _distanceModifier;
		private CFloat _calculatedDistanceHeightBias;
		private CFloat _stickingDistanceHeightBias;
		private CBool _stickToTarget;
		private CBool _forceStickToTarget;
		private CHandle<inkScreenProjection> _projection;
		private CHandle<inkanimDefinition> _showPositiveAnimDef;
		private CHandle<inkanimTransparencyInterpolator> _showPositiveAnimFadeInInterpolator;
		private CHandle<inkanimTransparencyInterpolator> _showPositiveAnimFadeOutInterpolator;
		private CHandle<inkanimMarginInterpolator> _showPositiveAnimMarginInterpolator;
		private CHandle<inkanimScaleInterpolator> _showPositiveAnimScaleInterpolator;
		private CHandle<inkanimDefinition> _showNegativeAnimDef;
		private CHandle<inkanimTransparencyInterpolator> _showNegativeAnimFadeInInterpolator;
		private CHandle<inkanimTransparencyInterpolator> _showNegativeAnimFadeOutInterpolator;
		private CHandle<inkanimMarginInterpolator> _showNegativeAnimMarginInterpolator;
		private CHandle<inkanimScaleInterpolator> _showNegativeAnimScaleInterpolator;
		private Vector4 _animStickTargetOffset;
		private CFloat _animTimeFadeIn;
		private CFloat _animTimeFadeOut;
		private CFloat _animBothTimeFadeIn;
		private CFloat _animBothTimeFadeOut;
		private CFloat _animTimeDelay;
		private CFloat _animTimeCritDelay;
		private CFloat _animBothTimeDelay;
		private CFloat _animBothTimeCritDelay;
		private CFloat _animStartHeight;
		private CFloat _animAngleMin1;
		private CFloat _animAngleMin2;
		private CFloat _animAngleMax1;
		private CFloat _animAngleMax2;
		private CFloat _animBothAngleMin1;
		private CFloat _animBothAngleMin2;
		private CFloat _animBothAngleMax1;
		private CFloat _animBothAngleMax2;
		private CFloat _animDistanceMin;
		private CFloat _animDistanceMax;
		private CFloat _animDistanceMin_Crit;
		private CFloat _animDistanceMax_Crit;
		private CFloat _animBothOffsetX;
		private CFloat _animBothOffsetY;
		private CFloat _animBothStickingOffsetY;
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
		private CFloat _animDynamicDuration;
		private CFloat _animDynamicDelay;
		private CFloat _animDynamicCritDuration;
		private CFloat _animDynamicCritDelay;

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
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(4)] 
		[RED("panelWidget")] 
		public wCHandle<inkWidget> PanelWidget
		{
			get => GetProperty(ref _panelWidget);
			set => SetProperty(ref _panelWidget, value);
		}

		[Ordinal(5)] 
		[RED("textWidget")] 
		public wCHandle<inkTextWidget> TextWidget
		{
			get => GetProperty(ref _textWidget);
			set => SetProperty(ref _textWidget, value);
		}

		[Ordinal(6)] 
		[RED("gameController")] 
		public wCHandle<DamageDigitsGameController> GameController
		{
			get => GetProperty(ref _gameController);
			set => SetProperty(ref _gameController, value);
		}

		[Ordinal(7)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}

		[Ordinal(8)] 
		[RED("successful")] 
		public CBool Successful
		{
			get => GetProperty(ref _successful);
			set => SetProperty(ref _successful, value);
		}

		[Ordinal(9)] 
		[RED("successfulCritical")] 
		public CBool SuccessfulCritical
		{
			get => GetProperty(ref _successfulCritical);
			set => SetProperty(ref _successfulCritical, value);
		}

		[Ordinal(10)] 
		[RED("showingBothDigits")] 
		public CBool ShowingBothDigits
		{
			get => GetProperty(ref _showingBothDigits);
			set => SetProperty(ref _showingBothDigits, value);
		}

		[Ordinal(11)] 
		[RED("distanceModifier")] 
		public CFloat DistanceModifier
		{
			get => GetProperty(ref _distanceModifier);
			set => SetProperty(ref _distanceModifier, value);
		}

		[Ordinal(12)] 
		[RED("calculatedDistanceHeightBias")] 
		public CFloat CalculatedDistanceHeightBias
		{
			get => GetProperty(ref _calculatedDistanceHeightBias);
			set => SetProperty(ref _calculatedDistanceHeightBias, value);
		}

		[Ordinal(13)] 
		[RED("stickingDistanceHeightBias")] 
		public CFloat StickingDistanceHeightBias
		{
			get => GetProperty(ref _stickingDistanceHeightBias);
			set => SetProperty(ref _stickingDistanceHeightBias, value);
		}

		[Ordinal(14)] 
		[RED("stickToTarget")] 
		public CBool StickToTarget
		{
			get => GetProperty(ref _stickToTarget);
			set => SetProperty(ref _stickToTarget, value);
		}

		[Ordinal(15)] 
		[RED("forceStickToTarget")] 
		public CBool ForceStickToTarget
		{
			get => GetProperty(ref _forceStickToTarget);
			set => SetProperty(ref _forceStickToTarget, value);
		}

		[Ordinal(16)] 
		[RED("projection")] 
		public CHandle<inkScreenProjection> Projection
		{
			get => GetProperty(ref _projection);
			set => SetProperty(ref _projection, value);
		}

		[Ordinal(17)] 
		[RED("showPositiveAnimDef")] 
		public CHandle<inkanimDefinition> ShowPositiveAnimDef
		{
			get => GetProperty(ref _showPositiveAnimDef);
			set => SetProperty(ref _showPositiveAnimDef, value);
		}

		[Ordinal(18)] 
		[RED("showPositiveAnimFadeInInterpolator")] 
		public CHandle<inkanimTransparencyInterpolator> ShowPositiveAnimFadeInInterpolator
		{
			get => GetProperty(ref _showPositiveAnimFadeInInterpolator);
			set => SetProperty(ref _showPositiveAnimFadeInInterpolator, value);
		}

		[Ordinal(19)] 
		[RED("showPositiveAnimFadeOutInterpolator")] 
		public CHandle<inkanimTransparencyInterpolator> ShowPositiveAnimFadeOutInterpolator
		{
			get => GetProperty(ref _showPositiveAnimFadeOutInterpolator);
			set => SetProperty(ref _showPositiveAnimFadeOutInterpolator, value);
		}

		[Ordinal(20)] 
		[RED("showPositiveAnimMarginInterpolator")] 
		public CHandle<inkanimMarginInterpolator> ShowPositiveAnimMarginInterpolator
		{
			get => GetProperty(ref _showPositiveAnimMarginInterpolator);
			set => SetProperty(ref _showPositiveAnimMarginInterpolator, value);
		}

		[Ordinal(21)] 
		[RED("showPositiveAnimScaleInterpolator")] 
		public CHandle<inkanimScaleInterpolator> ShowPositiveAnimScaleInterpolator
		{
			get => GetProperty(ref _showPositiveAnimScaleInterpolator);
			set => SetProperty(ref _showPositiveAnimScaleInterpolator, value);
		}

		[Ordinal(22)] 
		[RED("showNegativeAnimDef")] 
		public CHandle<inkanimDefinition> ShowNegativeAnimDef
		{
			get => GetProperty(ref _showNegativeAnimDef);
			set => SetProperty(ref _showNegativeAnimDef, value);
		}

		[Ordinal(23)] 
		[RED("showNegativeAnimFadeInInterpolator")] 
		public CHandle<inkanimTransparencyInterpolator> ShowNegativeAnimFadeInInterpolator
		{
			get => GetProperty(ref _showNegativeAnimFadeInInterpolator);
			set => SetProperty(ref _showNegativeAnimFadeInInterpolator, value);
		}

		[Ordinal(24)] 
		[RED("showNegativeAnimFadeOutInterpolator")] 
		public CHandle<inkanimTransparencyInterpolator> ShowNegativeAnimFadeOutInterpolator
		{
			get => GetProperty(ref _showNegativeAnimFadeOutInterpolator);
			set => SetProperty(ref _showNegativeAnimFadeOutInterpolator, value);
		}

		[Ordinal(25)] 
		[RED("showNegativeAnimMarginInterpolator")] 
		public CHandle<inkanimMarginInterpolator> ShowNegativeAnimMarginInterpolator
		{
			get => GetProperty(ref _showNegativeAnimMarginInterpolator);
			set => SetProperty(ref _showNegativeAnimMarginInterpolator, value);
		}

		[Ordinal(26)] 
		[RED("showNegativeAnimScaleInterpolator")] 
		public CHandle<inkanimScaleInterpolator> ShowNegativeAnimScaleInterpolator
		{
			get => GetProperty(ref _showNegativeAnimScaleInterpolator);
			set => SetProperty(ref _showNegativeAnimScaleInterpolator, value);
		}

		[Ordinal(27)] 
		[RED("animStickTargetOffset")] 
		public Vector4 AnimStickTargetOffset
		{
			get => GetProperty(ref _animStickTargetOffset);
			set => SetProperty(ref _animStickTargetOffset, value);
		}

		[Ordinal(28)] 
		[RED("animTimeFadeIn")] 
		public CFloat AnimTimeFadeIn
		{
			get => GetProperty(ref _animTimeFadeIn);
			set => SetProperty(ref _animTimeFadeIn, value);
		}

		[Ordinal(29)] 
		[RED("animTimeFadeOut")] 
		public CFloat AnimTimeFadeOut
		{
			get => GetProperty(ref _animTimeFadeOut);
			set => SetProperty(ref _animTimeFadeOut, value);
		}

		[Ordinal(30)] 
		[RED("animBothTimeFadeIn")] 
		public CFloat AnimBothTimeFadeIn
		{
			get => GetProperty(ref _animBothTimeFadeIn);
			set => SetProperty(ref _animBothTimeFadeIn, value);
		}

		[Ordinal(31)] 
		[RED("animBothTimeFadeOut")] 
		public CFloat AnimBothTimeFadeOut
		{
			get => GetProperty(ref _animBothTimeFadeOut);
			set => SetProperty(ref _animBothTimeFadeOut, value);
		}

		[Ordinal(32)] 
		[RED("animTimeDelay")] 
		public CFloat AnimTimeDelay
		{
			get => GetProperty(ref _animTimeDelay);
			set => SetProperty(ref _animTimeDelay, value);
		}

		[Ordinal(33)] 
		[RED("animTimeCritDelay")] 
		public CFloat AnimTimeCritDelay
		{
			get => GetProperty(ref _animTimeCritDelay);
			set => SetProperty(ref _animTimeCritDelay, value);
		}

		[Ordinal(34)] 
		[RED("animBothTimeDelay")] 
		public CFloat AnimBothTimeDelay
		{
			get => GetProperty(ref _animBothTimeDelay);
			set => SetProperty(ref _animBothTimeDelay, value);
		}

		[Ordinal(35)] 
		[RED("animBothTimeCritDelay")] 
		public CFloat AnimBothTimeCritDelay
		{
			get => GetProperty(ref _animBothTimeCritDelay);
			set => SetProperty(ref _animBothTimeCritDelay, value);
		}

		[Ordinal(36)] 
		[RED("animStartHeight")] 
		public CFloat AnimStartHeight
		{
			get => GetProperty(ref _animStartHeight);
			set => SetProperty(ref _animStartHeight, value);
		}

		[Ordinal(37)] 
		[RED("animAngleMin1")] 
		public CFloat AnimAngleMin1
		{
			get => GetProperty(ref _animAngleMin1);
			set => SetProperty(ref _animAngleMin1, value);
		}

		[Ordinal(38)] 
		[RED("animAngleMin2")] 
		public CFloat AnimAngleMin2
		{
			get => GetProperty(ref _animAngleMin2);
			set => SetProperty(ref _animAngleMin2, value);
		}

		[Ordinal(39)] 
		[RED("animAngleMax1")] 
		public CFloat AnimAngleMax1
		{
			get => GetProperty(ref _animAngleMax1);
			set => SetProperty(ref _animAngleMax1, value);
		}

		[Ordinal(40)] 
		[RED("animAngleMax2")] 
		public CFloat AnimAngleMax2
		{
			get => GetProperty(ref _animAngleMax2);
			set => SetProperty(ref _animAngleMax2, value);
		}

		[Ordinal(41)] 
		[RED("animBothAngleMin1")] 
		public CFloat AnimBothAngleMin1
		{
			get => GetProperty(ref _animBothAngleMin1);
			set => SetProperty(ref _animBothAngleMin1, value);
		}

		[Ordinal(42)] 
		[RED("animBothAngleMin2")] 
		public CFloat AnimBothAngleMin2
		{
			get => GetProperty(ref _animBothAngleMin2);
			set => SetProperty(ref _animBothAngleMin2, value);
		}

		[Ordinal(43)] 
		[RED("animBothAngleMax1")] 
		public CFloat AnimBothAngleMax1
		{
			get => GetProperty(ref _animBothAngleMax1);
			set => SetProperty(ref _animBothAngleMax1, value);
		}

		[Ordinal(44)] 
		[RED("animBothAngleMax2")] 
		public CFloat AnimBothAngleMax2
		{
			get => GetProperty(ref _animBothAngleMax2);
			set => SetProperty(ref _animBothAngleMax2, value);
		}

		[Ordinal(45)] 
		[RED("animDistanceMin")] 
		public CFloat AnimDistanceMin
		{
			get => GetProperty(ref _animDistanceMin);
			set => SetProperty(ref _animDistanceMin, value);
		}

		[Ordinal(46)] 
		[RED("animDistanceMax")] 
		public CFloat AnimDistanceMax
		{
			get => GetProperty(ref _animDistanceMax);
			set => SetProperty(ref _animDistanceMax, value);
		}

		[Ordinal(47)] 
		[RED("animDistanceMin_Crit")] 
		public CFloat AnimDistanceMin_Crit
		{
			get => GetProperty(ref _animDistanceMin_Crit);
			set => SetProperty(ref _animDistanceMin_Crit, value);
		}

		[Ordinal(48)] 
		[RED("animDistanceMax_Crit")] 
		public CFloat AnimDistanceMax_Crit
		{
			get => GetProperty(ref _animDistanceMax_Crit);
			set => SetProperty(ref _animDistanceMax_Crit, value);
		}

		[Ordinal(49)] 
		[RED("animBothOffsetX")] 
		public CFloat AnimBothOffsetX
		{
			get => GetProperty(ref _animBothOffsetX);
			set => SetProperty(ref _animBothOffsetX, value);
		}

		[Ordinal(50)] 
		[RED("animBothOffsetY")] 
		public CFloat AnimBothOffsetY
		{
			get => GetProperty(ref _animBothOffsetY);
			set => SetProperty(ref _animBothOffsetY, value);
		}

		[Ordinal(51)] 
		[RED("animBothStickingOffsetY")] 
		public CFloat AnimBothStickingOffsetY
		{
			get => GetProperty(ref _animBothStickingOffsetY);
			set => SetProperty(ref _animBothStickingOffsetY, value);
		}

		[Ordinal(52)] 
		[RED("animStickTargetWorldZOffset")] 
		public CFloat AnimStickTargetWorldZOffset
		{
			get => GetProperty(ref _animStickTargetWorldZOffset);
			set => SetProperty(ref _animStickTargetWorldZOffset, value);
		}

		[Ordinal(53)] 
		[RED("animStickingOffsetY")] 
		public CFloat AnimStickingOffsetY
		{
			get => GetProperty(ref _animStickingOffsetY);
			set => SetProperty(ref _animStickingOffsetY, value);
		}

		[Ordinal(54)] 
		[RED("animDistanceModifierMinDistance")] 
		public CFloat AnimDistanceModifierMinDistance
		{
			get => GetProperty(ref _animDistanceModifierMinDistance);
			set => SetProperty(ref _animDistanceModifierMinDistance, value);
		}

		[Ordinal(55)] 
		[RED("animDistanceModifierMaxDistance")] 
		public CFloat AnimDistanceModifierMaxDistance
		{
			get => GetProperty(ref _animDistanceModifierMaxDistance);
			set => SetProperty(ref _animDistanceModifierMaxDistance, value);
		}

		[Ordinal(56)] 
		[RED("animDistanceModifierMinValue")] 
		public CFloat AnimDistanceModifierMinValue
		{
			get => GetProperty(ref _animDistanceModifierMinValue);
			set => SetProperty(ref _animDistanceModifierMinValue, value);
		}

		[Ordinal(57)] 
		[RED("animDistanceModifierMaxValue")] 
		public CFloat AnimDistanceModifierMaxValue
		{
			get => GetProperty(ref _animDistanceModifierMaxValue);
			set => SetProperty(ref _animDistanceModifierMaxValue, value);
		}

		[Ordinal(58)] 
		[RED("animDistanceHeightBias")] 
		public CFloat AnimDistanceHeightBias
		{
			get => GetProperty(ref _animDistanceHeightBias);
			set => SetProperty(ref _animDistanceHeightBias, value);
		}

		[Ordinal(59)] 
		[RED("animStickingDistanceHeightBias")] 
		public CFloat AnimStickingDistanceHeightBias
		{
			get => GetProperty(ref _animStickingDistanceHeightBias);
			set => SetProperty(ref _animStickingDistanceHeightBias, value);
		}

		[Ordinal(60)] 
		[RED("animPositiveOpacity")] 
		public CFloat AnimPositiveOpacity
		{
			get => GetProperty(ref _animPositiveOpacity);
			set => SetProperty(ref _animPositiveOpacity, value);
		}

		[Ordinal(61)] 
		[RED("animNegativeOpacity")] 
		public CFloat AnimNegativeOpacity
		{
			get => GetProperty(ref _animNegativeOpacity);
			set => SetProperty(ref _animNegativeOpacity, value);
		}

		[Ordinal(62)] 
		[RED("animDynamicDuration")] 
		public CFloat AnimDynamicDuration
		{
			get => GetProperty(ref _animDynamicDuration);
			set => SetProperty(ref _animDynamicDuration, value);
		}

		[Ordinal(63)] 
		[RED("animDynamicDelay")] 
		public CFloat AnimDynamicDelay
		{
			get => GetProperty(ref _animDynamicDelay);
			set => SetProperty(ref _animDynamicDelay, value);
		}

		[Ordinal(64)] 
		[RED("animDynamicCritDuration")] 
		public CFloat AnimDynamicCritDuration
		{
			get => GetProperty(ref _animDynamicCritDuration);
			set => SetProperty(ref _animDynamicCritDuration, value);
		}

		[Ordinal(65)] 
		[RED("animDynamicCritDelay")] 
		public CFloat AnimDynamicCritDelay
		{
			get => GetProperty(ref _animDynamicCritDelay);
			set => SetProperty(ref _animDynamicCritDelay, value);
		}

		public DamageDigitLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
