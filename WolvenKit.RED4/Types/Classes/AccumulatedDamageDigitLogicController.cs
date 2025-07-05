using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AccumulatedDamageDigitLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("critWidget")] 
		public inkTextWidgetReference CritWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("headshotWidget")] 
		public inkTextWidgetReference HeadshotWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(4)] 
		[RED("panelWidget")] 
		public CWeakHandle<inkWidget> PanelWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(5)] 
		[RED("textWidget")] 
		public CWeakHandle<inkTextWidget> TextWidget
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(6)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(7)] 
		[RED("gameController")] 
		public CWeakHandle<DamageDigitsGameController> GameController
		{
			get => GetPropertyValue<CWeakHandle<DamageDigitsGameController>>();
			set => SetPropertyValue<CWeakHandle<DamageDigitsGameController>>(value);
		}

		[Ordinal(8)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("successful")] 
		public CBool Successful
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("successfulCritical")] 
		public CBool SuccessfulCritical
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("damageAccumulated")] 
		public CFloat DamageAccumulated
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("showingBothDigits")] 
		public CBool ShowingBothDigits
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("stickToTarget")] 
		public CBool StickToTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("currentlySticking")] 
		public CBool CurrentlySticking
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("projection")] 
		public CHandle<inkScreenProjection> Projection
		{
			get => GetPropertyValue<CHandle<inkScreenProjection>>();
			set => SetPropertyValue<CHandle<inkScreenProjection>>(value);
		}

		[Ordinal(16)] 
		[RED("showAnimProxy")] 
		public CHandle<inkanimProxy> ShowAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(17)] 
		[RED("critAnimProxy")] 
		public CHandle<inkanimProxy> CritAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(18)] 
		[RED("blinkProxy")] 
		public CHandle<inkanimProxy> BlinkProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(19)] 
		[RED("headshotAnimProxy")] 
		public CHandle<inkanimProxy> HeadshotAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(20)] 
		[RED("distanceModifier")] 
		public CFloat DistanceModifier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("calculatedDistanceHeightBias")] 
		public CFloat CalculatedDistanceHeightBias
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("stickingDistanceHeightBias")] 
		public CFloat StickingDistanceHeightBias
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(23)] 
		[RED("projectionInterpolationOffset")] 
		public inkMargin ProjectionInterpolationOffset
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		[Ordinal(24)] 
		[RED("projectionInterpolationOffsetTotal")] 
		public inkMargin ProjectionInterpolationOffsetTotal
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		[Ordinal(25)] 
		[RED("projectionInterpolationProgress")] 
		public CFloat ProjectionInterpolationProgress
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(26)] 
		[RED("projectionFreezePosition")] 
		public CBool ProjectionFreezePosition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("positionUpdated")] 
		public CBool PositionUpdated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("currentEngineTime")] 
		public CFloat CurrentEngineTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(29)] 
		[RED("lastEngineTime")] 
		public CFloat LastEngineTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(30)] 
		[RED("arrayPosition")] 
		public CInt32 ArrayPosition
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(31)] 
		[RED("showPositiveAnimDef")] 
		public CHandle<inkanimDefinition> ShowPositiveAnimDef
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(32)] 
		[RED("showPositiveAnimFadeInInterpolator")] 
		public CHandle<inkanimTransparencyInterpolator> ShowPositiveAnimFadeInInterpolator
		{
			get => GetPropertyValue<CHandle<inkanimTransparencyInterpolator>>();
			set => SetPropertyValue<CHandle<inkanimTransparencyInterpolator>>(value);
		}

		[Ordinal(33)] 
		[RED("showPositiveAnimFadeOutInterpolator")] 
		public CHandle<inkanimTransparencyInterpolator> ShowPositiveAnimFadeOutInterpolator
		{
			get => GetPropertyValue<CHandle<inkanimTransparencyInterpolator>>();
			set => SetPropertyValue<CHandle<inkanimTransparencyInterpolator>>(value);
		}

		[Ordinal(34)] 
		[RED("showPositiveAnimMarginInterpolator")] 
		public CHandle<inkanimMarginInterpolator> ShowPositiveAnimMarginInterpolator
		{
			get => GetPropertyValue<CHandle<inkanimMarginInterpolator>>();
			set => SetPropertyValue<CHandle<inkanimMarginInterpolator>>(value);
		}

		[Ordinal(35)] 
		[RED("showPositiveAnimScaleUpInterpolator")] 
		public CHandle<inkanimScaleInterpolator> ShowPositiveAnimScaleUpInterpolator
		{
			get => GetPropertyValue<CHandle<inkanimScaleInterpolator>>();
			set => SetPropertyValue<CHandle<inkanimScaleInterpolator>>(value);
		}

		[Ordinal(36)] 
		[RED("showPositiveAnimScaleDownInterpolator")] 
		public CHandle<inkanimScaleInterpolator> ShowPositiveAnimScaleDownInterpolator
		{
			get => GetPropertyValue<CHandle<inkanimScaleInterpolator>>();
			set => SetPropertyValue<CHandle<inkanimScaleInterpolator>>(value);
		}

		[Ordinal(37)] 
		[RED("showNegativeAnimDef")] 
		public CHandle<inkanimDefinition> ShowNegativeAnimDef
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(38)] 
		[RED("showNegativeAnimFadeInInterpolator")] 
		public CHandle<inkanimTransparencyInterpolator> ShowNegativeAnimFadeInInterpolator
		{
			get => GetPropertyValue<CHandle<inkanimTransparencyInterpolator>>();
			set => SetPropertyValue<CHandle<inkanimTransparencyInterpolator>>(value);
		}

		[Ordinal(39)] 
		[RED("showNegativeAnimFadeOutInterpolator")] 
		public CHandle<inkanimTransparencyInterpolator> ShowNegativeAnimFadeOutInterpolator
		{
			get => GetPropertyValue<CHandle<inkanimTransparencyInterpolator>>();
			set => SetPropertyValue<CHandle<inkanimTransparencyInterpolator>>(value);
		}

		[Ordinal(40)] 
		[RED("showNegativeAnimMarginInterpolator")] 
		public CHandle<inkanimMarginInterpolator> ShowNegativeAnimMarginInterpolator
		{
			get => GetPropertyValue<CHandle<inkanimMarginInterpolator>>();
			set => SetPropertyValue<CHandle<inkanimMarginInterpolator>>(value);
		}

		[Ordinal(41)] 
		[RED("showCritAnimDef")] 
		public CHandle<inkanimDefinition> ShowCritAnimDef
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(42)] 
		[RED("showCritAnimFadeOutInterpolator")] 
		public CHandle<inkanimTransparencyInterpolator> ShowCritAnimFadeOutInterpolator
		{
			get => GetPropertyValue<CHandle<inkanimTransparencyInterpolator>>();
			set => SetPropertyValue<CHandle<inkanimTransparencyInterpolator>>(value);
		}

		[Ordinal(43)] 
		[RED("animStickTargetOffset")] 
		public Vector4 AnimStickTargetOffset
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(44)] 
		[RED("animTimeFadeIn")] 
		public CFloat AnimTimeFadeIn
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(45)] 
		[RED("animTimeFadeOut")] 
		public CFloat AnimTimeFadeOut
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(46)] 
		[RED("animBothTimeFadeIn")] 
		public CFloat AnimBothTimeFadeIn
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(47)] 
		[RED("animBothTimeFadeOut")] 
		public CFloat AnimBothTimeFadeOut
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(48)] 
		[RED("animTimeDelay")] 
		public CFloat AnimTimeDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(49)] 
		[RED("animBothTimeDelay")] 
		public CFloat AnimBothTimeDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(50)] 
		[RED("animStartHeight")] 
		public CFloat AnimStartHeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(51)] 
		[RED("animEndHeight")] 
		public CFloat AnimEndHeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(52)] 
		[RED("animPopScale")] 
		public CFloat AnimPopScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(53)] 
		[RED("animPopEndScale")] 
		public CFloat AnimPopEndScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(54)] 
		[RED("animPopInDuration")] 
		public CFloat AnimPopInDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(55)] 
		[RED("animPopOutDuration")] 
		public CFloat AnimPopOutDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(56)] 
		[RED("animBothOffsetX")] 
		public CFloat AnimBothOffsetX
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(57)] 
		[RED("animBothOffsetY")] 
		public CFloat AnimBothOffsetY
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(58)] 
		[RED("animBothStickingOffsetY")] 
		public CFloat AnimBothStickingOffsetY
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(59)] 
		[RED("animTimeCritDelay")] 
		public CFloat AnimTimeCritDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(60)] 
		[RED("animBothTimeCritDelay")] 
		public CFloat AnimBothTimeCritDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(61)] 
		[RED("animTimeCritFade")] 
		public CFloat AnimTimeCritFade
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(62)] 
		[RED("animBothTimeCritFade")] 
		public CFloat AnimBothTimeCritFade
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(63)] 
		[RED("animMaxScreenDistanceFromLast")] 
		public CFloat AnimMaxScreenDistanceFromLast
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(64)] 
		[RED("animScreenInterpolationTime")] 
		public CFloat AnimScreenInterpolationTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(65)] 
		[RED("animMinScreenDistanceFromLast")] 
		public CFloat AnimMinScreenDistanceFromLast
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(66)] 
		[RED("animStickTargetWorldZOffset")] 
		public CFloat AnimStickTargetWorldZOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(67)] 
		[RED("animStickingOffsetY")] 
		public CFloat AnimStickingOffsetY
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(68)] 
		[RED("animDistanceModifierMinDistance")] 
		public CFloat AnimDistanceModifierMinDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(69)] 
		[RED("animDistanceModifierMaxDistance")] 
		public CFloat AnimDistanceModifierMaxDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(70)] 
		[RED("animDistanceModifierMinValue")] 
		public CFloat AnimDistanceModifierMinValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(71)] 
		[RED("animDistanceModifierMaxValue")] 
		public CFloat AnimDistanceModifierMaxValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(72)] 
		[RED("animDistanceHeightBias")] 
		public CFloat AnimDistanceHeightBias
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(73)] 
		[RED("animStickingDistanceHeightBias")] 
		public CFloat AnimStickingDistanceHeightBias
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(74)] 
		[RED("animPositiveOpacity")] 
		public CFloat AnimPositiveOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(75)] 
		[RED("animNegativeOpacity")] 
		public CFloat AnimNegativeOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(76)] 
		[RED("animDynamicFadeInDuration")] 
		public CFloat AnimDynamicFadeInDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AccumulatedDamageDigitLogicController()
		{
			CritWidget = new inkTextWidgetReference();
			HeadshotWidget = new inkTextWidgetReference();
			ProjectionInterpolationOffset = new inkMargin();
			ProjectionInterpolationOffsetTotal = new inkMargin();
			AnimStickTargetOffset = new Vector4();
			AnimTimeFadeIn = 0.100000F;
			AnimTimeFadeOut = 0.400000F;
			AnimBothTimeFadeIn = 0.100000F;
			AnimBothTimeFadeOut = 0.250000F;
			AnimTimeDelay = 1.300000F;
			AnimBothTimeDelay = 1.750000F;
			AnimStartHeight = -80.000000F;
			AnimEndHeight = -140.000000F;
			AnimPopScale = 1.500000F;
			AnimPopEndScale = 1.200000F;
			AnimPopInDuration = 0.050000F;
			AnimPopOutDuration = 0.150000F;
			AnimBothOffsetY = -50.000000F;
			AnimBothStickingOffsetY = -105.000000F;
			AnimTimeCritDelay = 1.300000F;
			AnimBothTimeCritDelay = 1.750000F;
			AnimTimeCritFade = 0.400000F;
			AnimBothTimeCritFade = 0.250000F;
			AnimMaxScreenDistanceFromLast = 500.000000F;
			AnimScreenInterpolationTime = 0.080000F;
			AnimMinScreenDistanceFromLast = 60.000000F;
			AnimStickTargetWorldZOffset = 0.500000F;
			AnimStickingOffsetY = -85.000000F;
			AnimDistanceModifierMinDistance = 7.000000F;
			AnimDistanceModifierMaxDistance = 25.000000F;
			AnimDistanceModifierMinValue = 0.600000F;
			AnimDistanceModifierMaxValue = 1.000000F;
			AnimDistanceHeightBias = 70.000000F;
			AnimStickingDistanceHeightBias = 70.000000F;
			AnimPositiveOpacity = 1.000000F;
			AnimNegativeOpacity = 0.800000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
