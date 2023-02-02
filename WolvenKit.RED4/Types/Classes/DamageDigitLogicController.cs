using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DamageDigitLogicController : inkWidgetLogicController
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
		[RED("gameController")] 
		public CWeakHandle<DamageDigitsGameController> GameController
		{
			get => GetPropertyValue<CWeakHandle<DamageDigitsGameController>>();
			set => SetPropertyValue<CWeakHandle<DamageDigitsGameController>>(value);
		}

		[Ordinal(7)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("successful")] 
		public CBool Successful
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("successfulCritical")] 
		public CBool SuccessfulCritical
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("showingBothDigits")] 
		public CBool ShowingBothDigits
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("distanceModifier")] 
		public CFloat DistanceModifier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("calculatedDistanceHeightBias")] 
		public CFloat CalculatedDistanceHeightBias
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("stickingDistanceHeightBias")] 
		public CFloat StickingDistanceHeightBias
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("stickToTarget")] 
		public CBool StickToTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("forceStickToTarget")] 
		public CBool ForceStickToTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("projection")] 
		public CHandle<inkScreenProjection> Projection
		{
			get => GetPropertyValue<CHandle<inkScreenProjection>>();
			set => SetPropertyValue<CHandle<inkScreenProjection>>(value);
		}

		[Ordinal(17)] 
		[RED("showPositiveAnimDef")] 
		public CHandle<inkanimDefinition> ShowPositiveAnimDef
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(18)] 
		[RED("showPositiveAnimFadeInInterpolator")] 
		public CHandle<inkanimTransparencyInterpolator> ShowPositiveAnimFadeInInterpolator
		{
			get => GetPropertyValue<CHandle<inkanimTransparencyInterpolator>>();
			set => SetPropertyValue<CHandle<inkanimTransparencyInterpolator>>(value);
		}

		[Ordinal(19)] 
		[RED("showPositiveAnimFadeOutInterpolator")] 
		public CHandle<inkanimTransparencyInterpolator> ShowPositiveAnimFadeOutInterpolator
		{
			get => GetPropertyValue<CHandle<inkanimTransparencyInterpolator>>();
			set => SetPropertyValue<CHandle<inkanimTransparencyInterpolator>>(value);
		}

		[Ordinal(20)] 
		[RED("showPositiveAnimMarginInterpolator")] 
		public CHandle<inkanimMarginInterpolator> ShowPositiveAnimMarginInterpolator
		{
			get => GetPropertyValue<CHandle<inkanimMarginInterpolator>>();
			set => SetPropertyValue<CHandle<inkanimMarginInterpolator>>(value);
		}

		[Ordinal(21)] 
		[RED("showPositiveAnimScaleInterpolator")] 
		public CHandle<inkanimScaleInterpolator> ShowPositiveAnimScaleInterpolator
		{
			get => GetPropertyValue<CHandle<inkanimScaleInterpolator>>();
			set => SetPropertyValue<CHandle<inkanimScaleInterpolator>>(value);
		}

		[Ordinal(22)] 
		[RED("showNegativeAnimDef")] 
		public CHandle<inkanimDefinition> ShowNegativeAnimDef
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(23)] 
		[RED("showNegativeAnimFadeInInterpolator")] 
		public CHandle<inkanimTransparencyInterpolator> ShowNegativeAnimFadeInInterpolator
		{
			get => GetPropertyValue<CHandle<inkanimTransparencyInterpolator>>();
			set => SetPropertyValue<CHandle<inkanimTransparencyInterpolator>>(value);
		}

		[Ordinal(24)] 
		[RED("showNegativeAnimFadeOutInterpolator")] 
		public CHandle<inkanimTransparencyInterpolator> ShowNegativeAnimFadeOutInterpolator
		{
			get => GetPropertyValue<CHandle<inkanimTransparencyInterpolator>>();
			set => SetPropertyValue<CHandle<inkanimTransparencyInterpolator>>(value);
		}

		[Ordinal(25)] 
		[RED("showNegativeAnimMarginInterpolator")] 
		public CHandle<inkanimMarginInterpolator> ShowNegativeAnimMarginInterpolator
		{
			get => GetPropertyValue<CHandle<inkanimMarginInterpolator>>();
			set => SetPropertyValue<CHandle<inkanimMarginInterpolator>>(value);
		}

		[Ordinal(26)] 
		[RED("showNegativeAnimScaleInterpolator")] 
		public CHandle<inkanimScaleInterpolator> ShowNegativeAnimScaleInterpolator
		{
			get => GetPropertyValue<CHandle<inkanimScaleInterpolator>>();
			set => SetPropertyValue<CHandle<inkanimScaleInterpolator>>(value);
		}

		[Ordinal(27)] 
		[RED("animStickTargetOffset")] 
		public Vector4 AnimStickTargetOffset
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(28)] 
		[RED("animTimeFadeIn")] 
		public CFloat AnimTimeFadeIn
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(29)] 
		[RED("animTimeFadeOut")] 
		public CFloat AnimTimeFadeOut
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(30)] 
		[RED("animBothTimeFadeIn")] 
		public CFloat AnimBothTimeFadeIn
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(31)] 
		[RED("animBothTimeFadeOut")] 
		public CFloat AnimBothTimeFadeOut
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(32)] 
		[RED("animTimeDelay")] 
		public CFloat AnimTimeDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(33)] 
		[RED("animTimeCritDelay")] 
		public CFloat AnimTimeCritDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(34)] 
		[RED("animBothTimeDelay")] 
		public CFloat AnimBothTimeDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(35)] 
		[RED("animBothTimeCritDelay")] 
		public CFloat AnimBothTimeCritDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(36)] 
		[RED("animStartHeight")] 
		public CFloat AnimStartHeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(37)] 
		[RED("animAngleMin1")] 
		public CFloat AnimAngleMin1
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(38)] 
		[RED("animAngleMin2")] 
		public CFloat AnimAngleMin2
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(39)] 
		[RED("animAngleMax1")] 
		public CFloat AnimAngleMax1
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(40)] 
		[RED("animAngleMax2")] 
		public CFloat AnimAngleMax2
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(41)] 
		[RED("animBothAngleMin1")] 
		public CFloat AnimBothAngleMin1
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(42)] 
		[RED("animBothAngleMin2")] 
		public CFloat AnimBothAngleMin2
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(43)] 
		[RED("animBothAngleMax1")] 
		public CFloat AnimBothAngleMax1
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(44)] 
		[RED("animBothAngleMax2")] 
		public CFloat AnimBothAngleMax2
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(45)] 
		[RED("animDistanceMin")] 
		public CFloat AnimDistanceMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(46)] 
		[RED("animDistanceMax")] 
		public CFloat AnimDistanceMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(47)] 
		[RED("animDistanceMin_Crit")] 
		public CFloat AnimDistanceMin_Crit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(48)] 
		[RED("animDistanceMax_Crit")] 
		public CFloat AnimDistanceMax_Crit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(49)] 
		[RED("animBothOffsetX")] 
		public CFloat AnimBothOffsetX
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(50)] 
		[RED("animBothOffsetY")] 
		public CFloat AnimBothOffsetY
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(51)] 
		[RED("animBothStickingOffsetY")] 
		public CFloat AnimBothStickingOffsetY
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(52)] 
		[RED("animStickTargetWorldZOffset")] 
		public CFloat AnimStickTargetWorldZOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(53)] 
		[RED("animStickingOffsetY")] 
		public CFloat AnimStickingOffsetY
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(54)] 
		[RED("animDistanceModifierMinDistance")] 
		public CFloat AnimDistanceModifierMinDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(55)] 
		[RED("animDistanceModifierMaxDistance")] 
		public CFloat AnimDistanceModifierMaxDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(56)] 
		[RED("animDistanceModifierMinValue")] 
		public CFloat AnimDistanceModifierMinValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(57)] 
		[RED("animDistanceModifierMaxValue")] 
		public CFloat AnimDistanceModifierMaxValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(58)] 
		[RED("animDistanceHeightBias")] 
		public CFloat AnimDistanceHeightBias
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(59)] 
		[RED("animStickingDistanceHeightBias")] 
		public CFloat AnimStickingDistanceHeightBias
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(60)] 
		[RED("animPositiveOpacity")] 
		public CFloat AnimPositiveOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(61)] 
		[RED("animNegativeOpacity")] 
		public CFloat AnimNegativeOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(62)] 
		[RED("animDynamicDuration")] 
		public CFloat AnimDynamicDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(63)] 
		[RED("animDynamicDelay")] 
		public CFloat AnimDynamicDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(64)] 
		[RED("animDynamicCritDuration")] 
		public CFloat AnimDynamicCritDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(65)] 
		[RED("animDynamicCritDelay")] 
		public CFloat AnimDynamicCritDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public DamageDigitLogicController()
		{
			CritWidget = new();
			HeadshotWidget = new();
			AnimStickTargetOffset = new();
			AnimTimeFadeIn = 0.100000F;
			AnimTimeFadeOut = 0.400000F;
			AnimBothTimeFadeIn = 0.100000F;
			AnimBothTimeFadeOut = 0.200000F;
			AnimTimeDelay = 0.800000F;
			AnimTimeCritDelay = 1.250000F;
			AnimBothTimeDelay = 0.500000F;
			AnimBothTimeCritDelay = 0.800000F;
			AnimStartHeight = -30.000000F;
			AnimAngleMin1 = -45.000000F;
			AnimAngleMin2 = 140.000000F;
			AnimAngleMax1 = 40.000000F;
			AnimAngleMax2 = 225.000000F;
			AnimBothAngleMin1 = -20.000000F;
			AnimBothAngleMin2 = 140.000000F;
			AnimBothAngleMax1 = 40.000000F;
			AnimBothAngleMax2 = 200.000000F;
			AnimDistanceMin = 70.000000F;
			AnimDistanceMax = 90.000000F;
			AnimDistanceMin_Crit = 110.000000F;
			AnimDistanceMax_Crit = 140.000000F;
			AnimBothStickingOffsetY = -70.000000F;
			AnimStickTargetWorldZOffset = 0.500000F;
			AnimStickingOffsetY = -70.000000F;
			AnimDistanceModifierMinDistance = 7.000000F;
			AnimDistanceModifierMaxDistance = 25.000000F;
			AnimDistanceModifierMinValue = 0.600000F;
			AnimDistanceModifierMaxValue = 1.000000F;
			AnimDistanceHeightBias = 50.000000F;
			AnimStickingDistanceHeightBias = 70.000000F;
			AnimPositiveOpacity = 0.950000F;
			AnimNegativeOpacity = 0.900000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
